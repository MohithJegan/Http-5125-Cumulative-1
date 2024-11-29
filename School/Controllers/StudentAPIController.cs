using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using School.Models;

namespace School.Controllers
{
    [Route("api/Student")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        private readonly SchoolDbContext _context;

        // Dependency injection of school database context
        public StudentAPIController(SchoolDbContext context)
        {    
            _context = context;
        }

        /// <summary>
        /// Returns a list of Students in the system
        /// </summary>
        /// <example>
        /// GET api/Student/ListStudents -> [{"studentId":1,"studentFName":"Sarah","studentLName":"Valdez","studentNumber":"N1678","enrolDate":"2018-06-18"},{"studentId":2,"studentFName":"Jennifer","studentLName":"Faulkner","studentNumber":"N1679","enrolDate":"2018-08-02"},{"studentId":3,"studentFName":"Austin","studentLName":"Simon","studentNumber":"N1682","enrolDate":"2018-06-14"},..]
        /// </example>
        /// <returns>
        /// A list of student objects 
        /// </returns>
        [HttpGet]
        [Route(template: "ListStudents")]
        public List<Student> ListStudents()
        {
            // Create an empty list of Students
            List<Student> Students = new List<Student>();

            // 'using' will close the connection after the code executes
            using (MySqlConnection Connection = _context.AccessDatabase())
            {
                // Open the connection
                Connection.Open();

                // Establish a new command (query) for our database
                MySqlCommand Command = Connection.CreateCommand();

                // Set the SQL Query
                Command.CommandText = "SELECT * FROM students";

                // Gather Result Set of Query into a variable
                using (MySqlDataReader ResultSet = Command.ExecuteReader())
                {
                    // Loop Through Each Row of the Result Set
                    while (ResultSet.Read())
                    {
                        Student CurrentStudent = new Student();
                        // Access Column information by the DB column name as an index
                        CurrentStudent.StudentId = Convert.ToInt32(ResultSet["studentid"]);
                        CurrentStudent.StudentFName = (ResultSet["studentfname"]).ToString();
                        CurrentStudent.StudentLName = (ResultSet["studentlname"]).ToString();
                        CurrentStudent.StudentNumber = (ResultSet["studentnumber"]).ToString();
                        CurrentStudent.EnrolDate = ResultSet["enroldate"] != DBNull.Value ? Convert.ToDateTime(ResultSet["enroldate"]).ToString("yyyy/MM/dd") : "";
                        // Add it to the Students list
                        Students.Add(CurrentStudent);
                    }
                }
            }
            // Return the final list of students
            return Students;
        }


        /// <summary>
        /// Returns a student in the database by their ID
        /// </summary>
        /// <param name="id">It accepts an id which is an integer</param>
        /// <example>
        /// GET api/Student/FindStudent/7 -> {"studentId":7,"studentFName":"Jason","studentLName":"Freeman","studentNumber":"N1694","enrolDate":"2018-08-16"}
        /// </example>
        /// <returns>
        /// A matching student object by its ID. Empty object if Student not found
        /// </returns>
        [HttpGet]
        [Route(template: "FindStudent/{id}")]
        public Student FindStudent(int id)
        {
            //Empty Student
            Student SelectedStudent = new Student();

            // 'using' will close the connection after the code executes
            using (MySqlConnection Connection = _context.AccessDatabase())
            {
                // Open the connection
                Connection.Open();

                // Establish a new command (query) for our database
                MySqlCommand Command = Connection.CreateCommand();

                // Set the SQL Query
                Command.CommandText = "SELECT * FROM students WHERE studentid=@id";
                Command.Parameters.AddWithValue("@id", id);

                // Gather Result Set of Query into a variable
                using (MySqlDataReader ResultSet = Command.ExecuteReader())
                {
                    // Loop Through Each Row of the Result Set
                    while (ResultSet.Read())
                    {
                        // Access Column information by the DB column name as an index
                        SelectedStudent.StudentId = Convert.ToInt32(ResultSet["studentid"]);
                        SelectedStudent.StudentFName = (ResultSet["studentfname"]).ToString();
                        SelectedStudent.StudentLName = (ResultSet["studentlname"]).ToString();
                        SelectedStudent.StudentNumber = (ResultSet["studentnumber"]).ToString();
                        SelectedStudent.EnrolDate = ResultSet["enroldate"] != DBNull.Value ? Convert.ToDateTime(ResultSet["enroldate"]).ToString("yyyy/MM/dd") : "";

                    }
                }
            }
            // Return the final list of student names
            return SelectedStudent;
        }

        
        /// curl -X "POST" -H "Content-Type: application/json" -d "{\"studentFName\": \"Jane\",\"studentLName\": \"Williams\",\"studentNumber\": \"N7879\",\"enrolDate\": \"2019-01-15\"}" "https://localhost:7151/api/Student/AddStudent"
 
        /// <summary>
        /// Adds a student to the database
        /// </summary>
        /// <param name="StudentData">Student Object</param>
        /// <example>
        /// POST: api/Student/AddStudent
        /// Headers: Content-Type: application/json
        /// Request Body:
        /// {
        /// "StudentFname": "James",
        /// "StudentLname": "Oliver",
        /// "StudentNumber": "N1243",
        /// "EnrolDate": "01-15-2018"
        /// } -> 25
        /// </example>
        /// <returns>
        /// The inserted Student Id from the database if successful. 0 if Unsuccessful
        /// </returns>

        [HttpPost(template: "AddStudent")]
        public int AddStudent([FromBody] Student StudentData)
        {
            // 'using' will close the connection after the code executes
            using (MySqlConnection Connection = _context.AccessDatabase())
            {
                // Open the connection
                Connection.Open();

                // Establish a new command (query) for our database
                MySqlCommand Command = Connection.CreateCommand();

                // Set the SQL Command
                Command.CommandText = "INSERT INTO students (studentfname,studentlname,studentnumber,enroldate) VALUES (@studentfname,@studentlname,@studentnumber,@enroldate)";

                Command.Parameters.AddWithValue("@studentfname", StudentData.StudentFName);
                Command.Parameters.AddWithValue("@studentlname", StudentData.StudentLName);
                Command.Parameters.AddWithValue("@studentnumber", StudentData.StudentNumber);
                Command.Parameters.AddWithValue("@enroldate", StudentData.EnrolDate);

                Command.ExecuteNonQuery();

                // Send the last inserted id of the data created
                return Convert.ToInt32(Command.LastInsertedId);

            }

            // if failure
            return 0;
        }

        /// curl -X "DELETE" "https://localhost:7151/api/Student/DeleteStudent/33"

        /// <summary>
        /// Deletes a Student from the database
        /// </summary>
        /// <param name="StudentId">Primary key of the student to delete</param>
        /// <example>
        /// DELETE: api/Student/DeleteStudent -> 1
        /// </example>
        /// <returns>
        /// It returns the string "The student with given id {studentid} has been removed from the DB" if the student id is found in DB, otherwise it returns the string "The student with given id {studentid} is not found"
        /// </returns>

        [HttpDelete(template:"DeleteStudent/{StudentId}")]
        public string DeleteStudent(int StudentId)
        {
            // initialize the variable to track the rows affected
            int RowsAffected = 0;

            using (MySqlConnection Connection = _context.AccessDatabase())
            {
                // Open the connection
                Connection.Open();

                // Establish a new command (query) for our database
                MySqlCommand Command = Connection.CreateCommand();

                // Set the SQL Command
                Command.CommandText = "DELETE FROM students WHERE studentid=@id";

                Command.Parameters.AddWithValue("@id", StudentId);

                RowsAffected = Command.ExecuteNonQuery();
                    
            }
            // Check for the deletion
            if (RowsAffected > 0)
            {
                return $"The student with given id {StudentId} has been removed from the DB";
            }
            else
            {
                return $"The student with given id {StudentId} is not found";
            }
        }

    }
}
