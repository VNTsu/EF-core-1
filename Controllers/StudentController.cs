using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assign1.Model;
using Assign1.Data;
using Assign1.Service;

namespace Assign1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost("/Add")]  
        public async Task Add ([FromBody] Student student)  
        {  
            if (ModelState.IsValid)  
            {  
                await _studentService.Add(student);  
            }  
        }

        [HttpPut("/edit-student")]
        public async Task<Student> Update (Student student)
        {
            return await _studentService.Update(student);
        }

        [HttpDelete("/delete-student")]  
        public async Task Delete(string id)  
        {  
            await _studentService.Delete(id);  
        }  

        [HttpGet("/get-all-student")]
        public async Task<List<Student>> GetAllStudent()
        {
            return await _studentService.GetAllStudent();
        }
    }
}