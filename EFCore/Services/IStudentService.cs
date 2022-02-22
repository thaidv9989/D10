using EFCore.Models;

namespace EFCore.Services
{
    public interface IStudentService
    {
        public List<StudentModel> GetAll();
        StudentModel? GetById(int id);   
        void Add(StudentModel model);
        void Update(StudentModel model);    
        void Delete(int id);    
    }
}
