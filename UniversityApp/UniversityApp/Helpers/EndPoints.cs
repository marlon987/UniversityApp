namespace UniversityApp.Helpers
{
    public class EndPoints
    {


        #region Courses
        public static string GET_COURSES = "api/Courses/GetCourses/";
        public static string GET_COURSE = "api/Courses/GetCourse/";
        public static string GET_COURSE_BY_STUDENT = "api/Courses/GetCoursesByStudentId/";
        public static string GET_COURSE_BY_INSTRUCTOR = "api/Courses/GetCoursesByInstructorId/";

        public static string POST_COURSES = "api/Courses/";
        public static string PUT_COURSES = "api/Courses/";
        public static string DELETE_COURSES = "api/Courses/";
        #endregion


        #region CoursesInstructors
        public static string GET_COURSE_INSTRUCTORS = "api/CourseInstructors/";

        public static string POST_COURSES_INSTRUCTORS, PUT_COURSES_INSTRUCTORS, DELETE_COURSES_INSTRUCTORS = "api/CourseInstructors/";
        #endregion

        #region Instructors 

        public static string GET_INSTRUCTORS = "/api/Instructors/GetInstructors/";

        public static string POST_INSTRUCTORS = "api/Instructors/";
        public static string PUT_INSTRUCTORS = "api/Instructors/";
        public static string DELETE_INSTRUCTORS = "api/Instructors/";
        #endregion

        #region Departments

        public static string GET_DEPARTMENTS = "api/Departments/";

        public static string POST_DEPARTMENTS, PUT_DEPARTMENTS, DELETE_DEPARTMENTS = "api/Departments/";
        #endregion

        #region Enrollments

        public static string GET_ENROLLMENTS = "api/Enrollments/";

        public static string POST_ENROLLMENTS, PUT_ENROLLMENTS, DELETE_ENROLLMENTS = "api/Enrollments/";
        #endregion

        #region OfficeAssignments

        public static string GET_OFFICEASSIGNMENTS = "api/OfficeAssignments/";

        public static string POST_OFFICEASSIGNMENTS, PUT_OFFICEASSIGNMENTS, DELETE_OFFICEASSIGNMENTS = "api/OfficeAssignments/";
        #endregion

        #region Students

        public static string GET_STUDENTS = "/api/Students/GetStudents/";
        public static string GET_STUDENT = "/api/Students/GetStudent/";
        public static string GET_STUDENT_BY_COURSE = "/api/Students/GetStudentsByCourseId/";



        public static string POST_STUDENTS = "api/Students/";
        public static string PUT_STUDENTS = "api/Students/";
        public static string DELETE_STUDENTS = "api/Students/";
        #endregion






    }
}
