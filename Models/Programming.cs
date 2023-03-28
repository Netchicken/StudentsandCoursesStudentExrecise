namespace StudentsandCoursesStudentExrecise.Models
{
    public class Programming : Student
    {

        public Programming()
        {
            HasExtroversion = false;
            Course.CourseName = "Software Development";
            Course.Tutor = "Mr. Smith";
            Course.Room = "Room 1";
            Course.Weeks = 34;
            MainTransportType.Add("Taxi");
            FirstName = "Harold";
            LastName = "Smith";
            HasLaptop = true;
        }



    }
}
