# School Application - ASP.NET Core with MySQL

This is a simple school management application built with ASP.NET Core and MySQL. The application allows to manage Teachers, Students, and Courses via an API and displays data on specific pages.

## Controllers and Views

The application contains three main controllers: **Teacher**, **Student**, and **Course**. Each controller manages its respective entity and provides views for displaying data.

### 1. **Teacher Controller**

- **TeacherPage/List.cshtml**:  
  Displays a list of all teachers.
  
- **TeacherPage/Show.cshtml**:  
  Displays detailed information about a specific teacher.

The `TeacherAPIController.cs` exposes an API for interacting with teacher data, and the views are used to display this data in a user-friendly manner.

### 2. **Student Controller**

- **StudentPage/List.cshtml**:  
  Displays a list of all students.
  
- **StudentPage/Show.cshtml**:  
  Displays detailed information about a specific student.

The `StudentAPIController.cs` provides the API for managing student data, and the views allow users to easily view and interact with the student information.

### 3. **Course Controller**

- **CoursePage/List.cshtml**:  
  Displays a list of all courses.
  
- **CoursePage/Show.cshtml**:  
  Displays detailed information about a specific course.

The `CourseAPIController.cs` handles API requests related to courses, and the views are used to show course details in a clear format.

## Setup

1. Install MySQL and create a database (`school_db`).
2. Update the connection string with your MySQL credentials.
3. Run the application using the command `F5`.
4. Use command prompt or browser (`Swagger`) to test the API.

## API Endpoints

- **Teacher API**:  
  `GET /api/ListTeachers`,  `GET /api/ListCourses`,  `GET /api/FindTeacher/{id}`

- **Course API**:  
  `GET /api/ListCourses`, `GET /api/FindCourse/{id}`

- **Student API**:  
  `GET /api/ListStudents`, `GET /api/FindStudent/{id}`

## Views and Pages

- **TeacherPage**: Contains the `List.cshtml` and `Show.cshtml` for displaying teacher information.
- **StudentPage**: Contains the `List.cshtml` and `Show.cshtml` for displaying student information.
- **CoursePage**: Contains the `List.cshtml` and `Show.cshtml` for displaying course information.

These views make it easy for users to browse through lists of teachers, students, and courses, as well as view detailed information.
