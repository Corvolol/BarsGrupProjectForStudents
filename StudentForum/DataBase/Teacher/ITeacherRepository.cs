using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public interface ITeacherRepository
    {
        public Task AddTeacher(Teacher teacher);
        public Task DeleteTeacher(Teacher teacher);
        public Task UpdateTeacher(Teacher teacher);
        public Task<Teacher> GetTeacher(int teacherId);
        public Task<List<Teacher>> GetAllTeachers();
    }
}
