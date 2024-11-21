using System.ComponentModel.DataAnnotations;

namespace SAR.Models
{
    public class StudentAccount
    {
        public int Id { get; set; }
        public string StudentId { get; set; } = null!;
        public string Password { get; set; } = "";
    }
}
