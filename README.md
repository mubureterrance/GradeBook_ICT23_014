# GradeBook_ICT23_014
# Gradebook System - README

## Project Overview
Welcome to the Gradebook System! This project was developed as part of a first-year programming assignment using C#. 
The Gradebook System is designed to help instructors manage student information, marks and grading, providing functionalities such as adding, viewing, and updating grades.

## Features
- **Register User:** Add new user to the system [ admin, admin assistince, registrar, lecturer ] 
- **Register Students:** Add new students to the gradebook.
- **Capture Marks:** Record marks for each student.
- **Assessment Model:** Edit the assessment model used for calculating module mark.
- **Grading Criteria:** Edit the grading criteria for determining the student grading.
- **View Grades:** Display the grades of all students or individual students.
- **View Module Perfomance** Display students perfomance statistics per module
- **Update Grades:** Modify existing grades for students.
- **Delete Students/Grades:** Remove students or specific grades from the system.

## Requirements
- **Development Environment:** Visual Studio (recommended) or any C# IDE
- **.NET Framework:** .NET Core 3.1 or later

## Installation
1. **Clone the Repository:**
   ```bash
   git clone [https://github.com/MubureT/GradeBook_ICT23_014]
   ```
2. **Open the Project:**
   - Launch Visual Studio.
   - Open the `GradeBook_ICT23_014.sln` solution file.

3. **Build the Project:**
   - Build the solution to restore the necessary NuGet packages and compile the code.

4. **Run the Application:**
   - Set the startup project to `GradeBook_ICT23_014`.
   - Run the application using `F5` or the "Start Debugging" option.

## Usage
1. **Register Student:**
   - Click "Register Student" button to navigate to the register student section [only the Registrar or administrator can register students].
   - Enter the student details (e.g., Name, student ID) all nine details are required fields.
   - Click "Save" to save the student information.
   - Click "Update" to edit any selected record.
   - Click "Clear" to clear any entries made but are nolonger required to be saved.
   - Click "Delete" to delete a selected record from the system.
   - Click "Close" to close the current form and navigate back to the "Main form". 

2. **Register User:**
   - Click the "Register User" button to navigate to the register user section [Ony administraters can register users].
   - Enter the user details (e.g., Name, staff ID) all nine details are required fields.
   - Click "Save" to save the user information into the system
   - Click "Update" to edit any selected record.
   - Click "Clear" to clear any entries made but are nolonger required to be saved.
   - Click "Delete" to delete a selected record from the system.
   - Click "Close" to close the current form and navigate back to the "Main form". 

3. **Accessment Model:**
   - Click "Assessment Model" Button to navigate to the section [Requires administrator access].
   - Edit the assessment model as required
   - Model includes [Assessment Test, Assignment, CourseWork and Final Examination] weights.
   - Click "Save" to save the record into the system.
   - Click "Clear" to clear any entries made but are nolonger required to be saved.
   - Click "Close" to close the current form and navigate back to the "Main form". 
     

4. **Grading Criteria:**
   - Click "Grading Criteria" Button to navigate to the section [Requires administrator access].
   - Edit the Grading Criteria as required
   - Criteria must follow the format: [Eg. Mark From xxx Mark To xxx Grade xxx].
   - Click "Save" to save the record into the system.
   - Click "Update" to edit any selected record.
   - Click "Clear" to clear any entries made but are nolonger required to be saved.
   - Click "Delete" to delete a selected record from the system.
   - Click "Close" to close the current form and navigate back to the "Main form". 

5. **Capture Marks:**
   - Click "Capture Marks" Button to navigate to the section [Requires Lecturer access].
   - Select student_ID from the dropdown list.
   - Varify the student name in the student details section that will appear after selecting student ID.
   - Select Module Code and Staff ID from dropdown list.
   - Enter student marks [[Assessment Test, Assignment and Final Examination].
   - Module Mark and Module Grade are automatically calculated by the system when saving.
   - Click "Save" to save the record into the system #this is when module mark and grade are computed.
   - Click "Update" to edit any selected record.
   - Click "Clear" to clear any entries made but are nolonger required to be saved.
   - Click "Delete" to delete a selected record from the system.
   - Click "Close" to close the current form and navigate back to the "Main form". 

6. **Perfomance**
   - Click "Perfomance" Button to navigate to the section [all users have access].
   - Select the "Module Code" from the dropdown list.
   - Click the Load button to auto populate the module statistics in all fields.
   - Click "Close" to close the current form and navigate back to the "Main form". 

7. **View Results**
   - Click "View Results" Button to navigate to the section [all users have access].
   - This is a view only section.

8. **View User Deails**
   - Click "User Details" Button on the manu-strip to navigate to the section [all users have access].
   - This is a view only section.

9. **View Student Deails**
   - Click "Student Details" Button on the manu-strip to navigate to the section [all users have access].
   - This is a view only section.
     
## Project Structure
- **GradeBook_ICT23_014:** Main project directory.
  - **Program.cs:** Entry point of the application.
  - **frmRegisterUser.cs** user class defination.
  - **frmRegisterStudent.cs:** Student class definition.
  - **DataAccess.cs:** Core functionality for managing users, students and marks.
  - **DataValidate.cs** Core functionality for data validation.
  

## Contributing
If you would like to contribute to this project, please fork the repository and create a pull request. For major changes, please open an issue first to discuss what you would like to change.

## License
This project is licensed under the MIT License - see the LICENSE file for details.

## Contact
For any questions or feedback, please contact me at [ mubureterrance@gmail.com ].

Thank you for using the Gradebook System!

---

Feel free to customize this README file based on your specific project details and requirements.
