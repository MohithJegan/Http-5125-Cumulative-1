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
  
- **TeacherPage/Edit.cshtml**:
  Displays a form to update a teacher to the database.
  
The `TeacherAPIController.cs` handles CRUD operations for teacher data, while the TeacherPage views manage displaying, creating, editing, deleting, and validating teacher information.

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

- **StudentPage/Edit.cshtml**:
  Displays a form to update a student to the database.

The `StudentAPIController.cs` handles CRUD operations for student data, while the StudentPage views manage displaying, creating, editing, deleting, and validating student information.

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

- **CoursePage/Edit.cshtml**:
  Displays a form to update a course to the database.

The `CourseAPIController.cs` handles CRUD operations for course data, while the CoursePage views manage displaying, creating, editing, deleting, and validating course information.

### 4. **TeacherAjaxPageController**
- **TeacherAjaxPage/New.cshtml**:
Displays a form to add a teacher to the database using JavaScript and Ajax.

The `TeacherAjaxPageController.cs` handles teacher data with JavaScript and Ajax, using New.cshtml to add teachers.

### 5. **StudentAjaxPageController**
- **StudentAjaxPage/New.cshtml**:
Displays a form to add a student to the database using JavaScript and Ajax.

The `StudentAjaxPageController.cs` handles student data with JavaScript and Ajax, using New.cshtml to add students.

### 6. **CourseAjaxPageController**
- **CourseAjaxPage/New.cshtml**:
Displays a form to add a course to the database using JavaScript and Ajax.

The `CourseAjaxPageController.cs` handles course data with JavaScript and Ajax, using New.cshtml to add courses.

## Setup

1. Install MySQL and create a database (`school_db`).
2. Update the connection string with your MySQL credentials.
3. Run the application using the command `F5`.
4. Use command prompt or browser (`Swagger`) to test the API.

## API Endpoints

- **Teacher API**:  
  `GET /api/ListTeachers`,  `GET /api/ListCourses`,  `GET /api/FindTeacher/{id}`, `POST /api/AddTeacher`, `DELETE /api/DeleteTeacher/{TeacherId}`, `PUT /api/UpdateTeacher/{TeacherId}`

- **Course API**:  
  `GET /api/ListCourses`, `GET /api/FindCourse/{id}`, `POST /api/AddCourse`, `DELETE /api/DeleteCourse/{CourseId}`, `PUT /api/UpdateCourse/{CourseId}`

- **Student API**:  
  `GET /api/ListStudents`, `GET /api/FindStudent/{id}`, `POST /api/AddStudent`, `DELETE /api/DeleteStudent/{StudentId}`, `PUT /api/UpdateStudent/{StudentId}`

## Views and Pages
### 1. TeacherPage

The **TeacherPage** contains the following views:

- **List.cshtml**: Displays a list of all teachers.
- **Show.cshtml**: Shows detailed information about a specific teacher.
- **New.cshtml**: Provides a form to add a new teacher.
- **Edit.cshtml**: Provides a form to update a teacher.
- **DeleteConfirm.cshtml**: Displays a confirmation page before deleting a teacher.
- **Validation.cshtml**: Handles errors and displays validation messages for teacher.

These views help manage teacher information by supporting CRUD operations (Create, Read, Update, Delete) with validation.

### 2. StudentPage

The **StudentPage** contains the following views:

- **List.cshtml**: Displays a list of all students.
- **Show.cshtml**: Shows detailed information about a specific student.
- **New.cshtml**: Provides a form to add a new student.
- **Edit.cshtml**: Provides a form to update a student.
- **DeleteConfirm.cshtml**: Displays a confirmation page before deleting a student.
- **Validation.cshtml**: Handles errors and displays validation messages for student.

These views help manage student information by supporting CRUD operations (Create, Read, Update, Delete) with validation.

### 3. CoursePage

The **CoursePage** contains the following views:

- **List.cshtml**: Displays a list of all courses.
- **Show.cshtml**: Shows detailed information about a specific course.
- **New.cshtml**: Provides a form to add a new course.
- **Edit.cshtml**: Provides a form to update a course.
- **DeleteConfirm.cshtml**: Displays a confirmation page before deleting a course.
- **Validation.cshtml**: Handles errors and displays validation messages for course.

These views help manage course information by supporting CRUD operations (Create, Read, Update, Delete) with validation.

### 4. TeacherAjaxPage

The **TeacherAjaxPage** contains the following view:
- **New.cshtml**: Provides a form to add a new teacher.
 
This view helps add teacher information using JavaScript and Ajax.

### 5. StudentAjaxPage

The **StudentAjaxPage** contains the following view:
- **New.cshtml**: Provides a form to add a new student.
 
This view helps add student information using JavaScript and Ajax.

### 6. CourseAjaxPage

The **CourseAjaxPage** contains the following view:
- **New.cshtml**: Provides a form to add a new course.

This view helps add course information using JavaScript and Ajax.


