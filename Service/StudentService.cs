using Assign1.Data;
using Assign1.Model;
using Assign1.Service;
using Microsoft.EntityFrameworkCore;

namespace Assign1.Service
{
    public class StudentService : IStudentService
    {
        private StudentContext _dbContext;
        public StudentService(StudentContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Student student)
        {
            student.Id = Guid.NewGuid().ToString();  
            _dbContext.Students1.Add(student);  
            try  
            {  
                await _dbContext.SaveChangesAsync();  
            }  
            catch  
            {  
                throw;  
            }  
        }

        public async Task Delete(string id)
        {
            try  
            {  
                var student = await _dbContext.Students1.FindAsync(id);  
                _dbContext.Students1.Remove(student);  
                await _dbContext.SaveChangesAsync();  
            }  
            catch  
            {  
                throw;  
            }  
        }

        public async Task<List<Student>> GetAllStudent()
        {
           return await _dbContext.Students1.ToListAsync();
        }

        public async Task<Student> Update(Student student)
        {
            var item = await _dbContext.Students1.FindAsync(student.Id);
            if (item != null)
            {
                item.City = student.City;
                item.FirtName = student.FirtName;
                item.LastName = student.LastName;
                item.State = student.State;
                await _dbContext.SaveChangesAsync();
                return item;
            }

            return null;
        }
    }
}