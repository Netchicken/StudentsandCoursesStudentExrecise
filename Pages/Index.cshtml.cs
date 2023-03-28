using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using StudentsandCoursesStudentExrecise.Models;
using StudentsandCoursesStudentExrecise.Operations;

namespace StudentsandCoursesStudentExrecise.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {

        List<Student> students;

        /* public Programming programming;

         public Web web;*/

        public Student student { get; set; } //base student that inherits other classes
        public int StudentSelected { get; set; } //the selected student class
        public bool hasData { get; set; } //hide properties not used in other classes
        public string TransportTypeUsed { get; set; }
        public void OnGet()
        {
            student = new Student();
            hasData = false;

        }
        public async Task<IActionResult> OnPost()
        {

            hasData = true;
            student = Factory.GetAStudentType(StudentSelected);

            return Page();


        }
    }
}