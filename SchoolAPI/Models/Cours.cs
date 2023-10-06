using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolAPI.Models
{
    public class Cours
    {
        public int CoursId { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime Datefin { get; set; }
        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
        public int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }
    }
}
