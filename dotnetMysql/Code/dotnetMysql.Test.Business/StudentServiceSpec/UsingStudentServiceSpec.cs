using NSubstitute;
using dotnetMysql.Test.Framework;
using dotnetMysql.Business.Services;
using dotnetMysql.Data.Interfaces;

namespace dotnetMysql.Test.Business.StudentServiceSpec
{
    public abstract class UsingStudentServiceSpec : SpecFor<StudentService>
    {
        protected IStudentRepository _studentRepository;

        public override void Context()
        {
            _studentRepository = Substitute.For<IStudentRepository>();
            subject = new StudentService(_studentRepository);

        }

    }
}
