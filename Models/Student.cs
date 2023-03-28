namespace StudentsandCoursesStudentExrecise.Models
{
    public class Student : PersonalDetails
    {
        //has a ....  Aggregation
        public Course Course { get; set; }
        public bool HasExtroversion { get; set; }
        public List<string> MainTransportType = new List<string>
            {
                "Car",
                "Bus",
                "Cycle",
                "Walk",
                "Train",
                "Scooter,",
                "Skateboard"

            };
        public bool HasLaptop { get; set; }

        public Student()
        {
            Course = new Course();


        }



    }
}
