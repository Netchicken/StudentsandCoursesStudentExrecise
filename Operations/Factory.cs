using StudentsandCoursesStudentExrecise.Models;

namespace StudentsandCoursesStudentExrecise.Operations
{
    public class Factory
    {
        public static Student GetAStudentType(int id)
        {
            if (id == 1)
            {
                return new Web();
            }
            if (id == 2)
            {
                return new Programming();
            }
            if (id == 3)
            {
                return new English();
            }
            return new Web();
        }
    }
}
