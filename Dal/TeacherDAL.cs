using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TeacherDAL
    {
        public static List<TeacherDto> GetTeachers()
        {
            List<Teacher> list = new List<Teacher>();
            using (FinalProjectRachelShifiEntities2 db = new FinalProjectRachelShifiEntities2())
            {
                list = db.Teachers.ToList();
            }
            return Convert.ConvertToTeacherDtoList(list);

        }
        public static TeacherDto GetTeacherById(int id)
        {
            Teacher t = new Teacher();
            using (FinalProjectRachelShifiEntities2 db = new FinalProjectRachelShifiEntities2())
            {
                t = db.Teachers.ToList().First(a => a.id == id);
            }
            return Convert.ConvertToTeacherDto(t);
        }

        public TeacherDto Login(string email, string password)
        {
            using (FinalProjectRachelShifiEntities2 ctx = new FinalProjectRachelShifiEntities2())
            {
                Teacher t2 = ctx.Teachers.FirstOrDefault(x => x.email == email && x.password == password);
                return Convert.ConvertToTeacherDto(t2);
            }
        }
    }
}
