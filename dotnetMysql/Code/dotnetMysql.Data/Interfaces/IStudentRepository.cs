using dotnetMysql.Entities.Entities;


namespace dotnetMysql.Data.Interfaces
{
    public interface IStudentRepository : IGetById<Student>, IGetAll<Student>, ISave<Student>, IUpdate<Student>, IDelete<int>
    {
    }
}
