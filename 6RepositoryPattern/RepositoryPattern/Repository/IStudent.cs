using RepositoryPattern.Models;
namespace RepositoryPattern.Repository

{
    public interface IStudent
    {
        List<Student> GetAll();

        Student GetById(int id);
    }
}
