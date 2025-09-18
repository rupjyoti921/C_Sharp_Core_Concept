using RepositoryPattern.Models;

namespace RepositoryPattern.Repository
{
    public class DataClass : IStudent
    {
        public List<Student> GetAll()
        {
            return StudentData();
        }

        public Student GetById(int id)
        {
            return StudentData().FirstOrDefault(x => x.RollNo == id);
            //return StudentData().Where(x => x.RollNo == id).FirstOrDefault();
        }

        private List<Student> StudentData()
        {
            return new List<Student>()
            {
                new Student() {RollNo = 1,Name="Rohan", Gender="Male", Class="11th"},
                new Student() {RollNo= 2,Name="kohan", Gender="Fale", Class="12th"},
                new Student() {RollNo=3,Name="gahan", Gender="Male", Class="10th"}
            };
        }
    }
}
