namespace SchoolAPI.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Cours> Cours { get; set; }

    }
}
