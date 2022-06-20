using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class TeacherDAL
    {
        public Teacher GetTeacherById(int id)
        {
            using (FinalProjectRachelShifiEntities2 ctx = new FinalProjectRachelShifiEntities2())
            {
                return ctx.Teachers.Find(id);
            }
        }
        public List<Teacher> GetTeachers()
        {
            using (FinalProjectRachelShifiEntities2 ctx = new FinalProjectRachelShifiEntities2())
            {
                return ctx.Teachers.ToList();
            }
        }
        public Teacher Login(string email,string password)
        {
            using (FinalProjectRachelShifiEntities2 ctx = new FinalProjectRachelShifiEntities2())
            {
                Teacher t2 = ctx.Teachers.FirstOrDefault(x => x.email == email&&x.password==password);
                 return t2;
            }
        }
    }
}
