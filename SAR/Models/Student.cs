﻿namespace SAR.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentId { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Gender { get; set; } = null!;
    }
}
