using System.ComponentModel.DataAnnotations.Schema;
using WebAPI.Models;

namespace WebAPI
{
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public int? ClassId { get; set; }
    }
}
