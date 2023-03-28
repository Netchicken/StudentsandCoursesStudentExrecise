namespace StudentsandCoursesStudentExrecise.Models
{
    public class Web : Student
    {

        public Web()
        {
            HasExtroversion = true;
            Course.CourseName = "Web Development";
            Course.Tutor = "Mr. Jones";
            Course.Room = "Room 2";
            Course.Weeks = 34;
            MainTransportType = new List<string>
            {
                "foot",
                "Cycle",
                "Walk",
               "Scooter,",
                "Skateboard",
                          };

            FirstName = "Webbly";
            LastName = "Javascript";

        }



    }
}
