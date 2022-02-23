using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assign1.Data;
using Assign1.Model;
using Assign1.Service;

namespace Assign1.Service
{
    public interface IStudentService
    {
        
        Task Add(Student student);  
        Task<Student> Update(Student student);  
        Task Delete(string id);  
        Task<List<Student>> GetAllStudent(); 
    }
}