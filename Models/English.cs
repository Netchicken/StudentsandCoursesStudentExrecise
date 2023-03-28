namespace StudentsandCoursesStudentExrecise.Models
{
    public class English : Student
    {
        public English()
        {
            HasExtroversion = false;
            Course.CourseName = "English";
            Course.Tutor = "Mr. Smith";
            Course.Room = "Room 1";
            Course.Weeks = 16;
            FirstName = "Kevin";
            LastName = "English";

            MainTransportType = new List<string>
{
    "Class bus pickup",
                  };
        }
    }
}