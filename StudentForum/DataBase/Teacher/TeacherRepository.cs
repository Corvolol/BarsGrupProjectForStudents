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

        public async Task AddTeacher(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTeacher(Teacher teacher)
        {
            Teacher teacherToDelete = await GetTeacher(teacher.Id);
            _context.Teachers.Remove(teacherToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTeacher(Teacher teacher)
        {
            Teacher teacherToUpdate = await GetTeacher(teacher.Id);
            _context.Teachers.Update(teacherToUpdate);
            await _context.SaveChangesAsync();
        }

        public async Task<Teacher> GetTeacher(int teacherId)
        {
            var teacher = await _context.Teachers.FirstOrDefaultAsync(x => x.Id == teacherId);
            return teacher;
        }

        public async Task<List<Teacher>> GetAllTeachers()
        {
            var teachers = await _context.Teachers.ToListAsync();
            return teachers;
        }
    }
}
