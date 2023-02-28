using NSubstitute;
using dotnetMysql.Test.Framework;
using dotnetMysql.Api.Controllers;
using dotnetMysql.Business.Interfaces;


namespace dotnetMysql.Test.Api.StudentControllerSpec
{
    public abstract class UsingStudentControllerSpec : SpecFor<StudentController>
    {
        protected IStudentService _studentService;

        public override void Context()
        {
            _studentService = Substitute.For<IStudentService>();
            subject = new StudentController(_studentService);

        }

    }
}
