using System;
using System.ComponentModel.DataAnnotations;

namespace StudyHelperSpa.Models
{
    public class Question
    {
        [Required, Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public string CorrectAnswer { get; set; }
        public string Category { get; set; }
        public string Exam { get; set; }
    }
}
