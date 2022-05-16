using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class TeacherRepository : ITeacherRepository
    {
        private Context _context;
        public TeacherRepository(Context context)
        {
            _context = context;
        }

        public async Task<TeacherModel> GetTeacher(int teacherId)
        {
            var teacher = await _context.Teachers.FirstOrDefaultAsync(x => x.Id == teacherId);
            return teacher;
        }

        public async Task<List<TeacherModel>> GetAllTeachers()
        {
            var teachers = await _context.Teachers.ToListAsync();
            return teachers;
        }
    }
}
