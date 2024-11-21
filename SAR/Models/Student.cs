namespace SAR.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentId { get; set; } = null!;
        public string FirstName { get; set; } = "";
        public string MiddleName { get; set; } = "";
        public string LastName { get; set; } = "";
    }
}
