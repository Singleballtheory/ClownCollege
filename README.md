
As a registrar, I want to be able to assign students to a course, so that teachers know which students are in their course. A course can have many students and a student can take many courses at the same time.
If you make it this far, great job! If you have time, work on these other user stories.

As a registrar, I want to be able to create departments. A student can be assigned to a department when they declare their major and a course can be assigned to a department when it is created.
As a registrar, I want to be able to list out all of the courses or all of the students in a particular department, so that I can inform the counselors which departments need more students and which need more courses.
As a registrar, I want to change a student's file to show that they have completed a course, so that I can see if they need to take the course again.
As a registrar, I want to list out all of the courses a student has taken, so that I can see if they have met their degree requirements.
As a registrar, I want to see how many students have not completed courses in any particular departments, so that I can tell the administration which departments need help.
As a registrar, I want to …
If you make it this far before the end of the day, think up and write some other user stories that a University registrar might have.



Student
Name
Date of Enrollment
StudentId

Course
Name
Course Number
CourseId


Course-Student
StudentId
CourseId
CourseStudentId

![db](/ClownCollege/wwwroot/img/db_layout.png)

courses
-------

 id | course
 ---+------------------------
  1 | Epicodus
  2 | How to cook vegan
  3 | Intro to rocket science

students
--------

 id | student
 ---+--------
  1 | libby  
  2 | tiny   
  3 | bub    
  4 | lizzy  
  5 | hank   

enrollments
-----------

 id | student_id | course_id
 ---------------------------
  1 | 1          | 1
  2 | 2          | 1
  3 | 3          | 2
  4 | 4          | 1
  5 | 5          | 3
  6 | 2          | 3
  7 | 4          | 3
