using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Track1.Models
{
    [Table("Standard")]
    public class Standard
    {
        public Standard()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
         
        public ICollection<Student> Students { get; set; }

    }
}
