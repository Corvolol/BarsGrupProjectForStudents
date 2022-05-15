using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public interface ITeacherRepository
    {
        public Task<TeacherModel> GetTeacher(int teacherId);
        public Task<List<TeacherModel>> GetAllTeachers();
    }
}
