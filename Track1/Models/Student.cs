using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Track1.Models
{
    [Table("Student")]
    public class Student
    {
        public Student()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        
        public int? StandardId { get; set; }
        [ForeignKey("StandardId")]
        public Standard Standard { get; set; }
    }
}