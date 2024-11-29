# School Application - ASP.NET Core with MySQL

This is a simple school management application built with ASP.NET Core and MySQL. The application allows to manage Teachers, Students, and Courses via an API and displays data on specific pages.

## Controllers and Views

The application contains three main controllers: **Teacher**, **Student**, and **Course**. Each controller manages its respective entity and provides views for displaying data.

### 1. **Teacher Controller**

- **TeacherPage/List.cshtml**:  
  Displays a list of all teachers.
  
- **TeacherPage/Show.cshtml**:  
  Displays detailed information about a specific teacher.

- **TeacherPage/New.cshtml**:
  Displays a form to add a teacher to the database.

- **TeacherPage/DeleteConfirm.cshtml**:
   Displays a delete confirmation page where the user can either confirm the deletion of a teacher or cancel to go back without performing the delete operation.

- **TeacherPage/Validation.cshtml**:
   Displays validation errors when the form is submitted with invalid data.

The `TeacherAPIController.cs` exposes an API for interacting with teacher data, while the TeacherPage views handle displaying data, creating, and deleting teachers and perform validation.

### 2. **Student Controller**

- **StudentPage/List.cshtml**:  
  Displays a list of all students.
  
- **StudentPage/Show.cshtml**:  
  Displays detailed information about a specific student.

- **StudentPage/New.cshtml**:
  Displays a form to add a student to the database.

- **StudentPage/DeleteConfirm.cshtml**:
  Displays a delete confirmation page where the user can either confirm the deletion of a student or cancel to go back without performing the delete operation.

- **StudentPage/Validation.cshtml**:
  Displays validation errors when the form is submitted with invalid data.

The `StudentAPIController.cs` exposes an API for interacting with student data, while the StudentPage views handle displaying data, creating, and deleting students and perform validation.

### 3. **Course Controller**

- **CoursePage/List.cshtml**:  
  Displays a list of all courses.
  
- **CoursePage/Show.cshtml**:  
  Displays detailed information about a specific course.

- **CoursePage/New.cshtml**:
  Displays a form to add a course to the database.

- **CoursePage/DeleteConfirm.cshtml**:
  Displays a delete confirmation page where the user can either confirm the deletion of a course or cancel to go back without performing the delete operation.

- **CoursePage/Validation.cshtml**:
  Displays validation errors when the form is submitted with invalid data.

The `CourseAPIController.cs` exposes an API for interacting with course data, while the CoursePage views handle displaying data, creating, and deleting courses and perform validation.

## Setup

1. Install MySQL and create a database (`school_db`).
2. Update the connection string with your MySQL credentials.
3. Run the application using the command `F5`.
4. Use command prompt or browser (`Swagger`) to test the API.

## API Endpoints

- **Teacher API**:  
  `GET /api/ListTeachers`,  `GET /api/ListCourses`,  `GET /api/FindTeacher/{id}`, `POST /api/AddTeacher`, `DELETE /api/DeleteTeacher/{TeacherId}`

- **Course API**:  
  `GET /api/ListCourses`, `GET /api/FindCourse/{id}`, `POST /api/AddCourse`, `DELETE /api/DeleteCourse/{CourseId}`

- **Student API**:  
  `GET /api/ListStudents`, `GET /api/FindStudent/{id}`, `POST /api/AddStudent`, `DELETE /api/DeleteStudent/{StudentId}`

## Views and Pages

- **TeacherPage**: The TeacherPage contains the following views: `List.cshtml`, `Show.cshtml`, `New.cshtml`, `DeleteConfirm.cshtml`, and `Validation.cshtml`. These views are used to display teacher information, create new teachers, delete existing teachers, and perform validation.
- **StudentPage**: The StudentPage contains the following views: `List.cshtml`, `Show.cshtml`, `New.cshtml`, `DeleteConfirm.cshtml`, and `Validation.cshtml`. These views are used to display student information, create new students, delete existing students, and perform validation.
- **CoursePage**: The CoursePage contains the following views: `List.cshtml`, `Show.cshtml`, `New.cshtml`, `DeleteConfirm.cshtml`, and `Validation.cshtml`. These views are used to display teacher information, create new courses, delete existing courses, and perform validation.

These views make it easy for users to browse through lists of teachers, students, and courses, view detailed information, and perform add and delete operations.
