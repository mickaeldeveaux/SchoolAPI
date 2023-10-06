using SchoolAPI.Filtre;
using SchoolAPI.Models;
using SchoolAPI.SchoolDbContext;

namespace SchoolAPI.Repositories
{

    public class TeacherRepository : ITeacherRepository
    {
        private readonly SchoolContext _context;

        public TeacherRepository(SchoolContext context)
        {
            _context = context;
        }
        public void CreateTeacher(Teacher teacher)
        {
            _context.Teachers.Add(teacher);

            _context.SaveChanges();
        }

        public void DeleteTeacher(int teacherId)
        {
            _context.Teachers.Remove(GetTeacherById(teacherId));

            _context.SaveChanges();
        }

        public IEnumerable<Teacher> GetAllTeacher(TeacherFiltre filtre)
        {
            var query = _context.Set<Teacher>().AsQueryable();

            if (filtre.FirstName != null)
            {
                query = query.Where(t => t.FirstName.Contains(filtre.FirstName));
            }
            if (filtre.Name != null)
            {
                query = query.Where(t => t.Name.Contains(filtre.Name));
            }
            if (filtre.BirthDatemin != null)
            {
                DateTime minBirthDate = DateTime.Parse(filtre.BirthDatemin);

                query = query.Where(t => t.BirthDate.Date >= minBirthDate.Date);
            }
            if (filtre.BirthDatemax != null)
            {
                DateTime maxBirthDate = DateTime.Parse(filtre.BirthDatemax);

                query = query.Where(t => t.BirthDate.Date <= maxBirthDate.Date);
            }

            return query.ToList();
        }

        public IEnumerable<Teacher> GetTeacherByFN(string teacherFN)
        {
            return _context.Teachers.Where(t => t.FirstName.StartsWith(teacherFN));
        }

        public Teacher GetTeacherById(int teacherId)
        {
            return _context.Teachers.Find(teacherId);
        }

        public void UpdateTeacher(Teacher teacher, int teacherId)
        {
            Teacher teacherEntity = GetTeacherById(teacherId);
            teacherEntity.Name = teacher.Name;
            teacherEntity.BirthDate = teacher.BirthDate;
            teacherEntity.FirstName = teacher.FirstName;
            _context.Teachers.Update(teacherEntity);
            _context.SaveChanges();
        }
    }
}
