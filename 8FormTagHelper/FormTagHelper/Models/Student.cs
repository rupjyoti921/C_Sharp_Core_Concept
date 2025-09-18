namespace FormTagHelper.Models
{
    public class Student
    {
        public int Id { get; set; }
        public Gender Gender { get; set; }
        public string Name { get; set; }
        public int RollNo {  get; set; }
        public int Age { get; set; }


    }

    public enum Gender{
        Male, Female
    }
}
