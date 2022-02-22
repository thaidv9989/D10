using EFCore.Models;

namespace EFCore.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentContext _context;

        public StudentService(StudentContext context)
        {
            _context = context;
        }

        public void Add(StudentModel model)
        {
            _context.Students.Add(model);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var rs = _context.Students.FirstOrDefault(x => x.stuId == id);
            if(rs != null)
            {
                _context.Students.Remove(rs);
                _context.SaveChanges();
            }
        }

        public List<StudentModel> GetAll()
        {
            return _context.Students.ToList();
        }

        public StudentModel? GetById(int id)
        {
            return _context.Students.FirstOrDefault(x => x.stuId == id);
        }

        public void Update(StudentModel model)
        {
            var rs = _context.Students.FirstOrDefault(x => x.stuId == model.stuId);
            if(rs != null)
            {
                rs.stuFirstName = model.stuFirstName;
                rs.stuFirstName = model.stuLastName;
                rs.stuCity = model.stuCity;
                rs.stuState = model.stuState;
                _context.Students.Update(rs);
                _context.SaveChanges();
            }
            
        }
    }
}
