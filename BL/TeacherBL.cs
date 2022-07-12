using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class TeacherBL
    {
        public static List<TeacherDto> GetTeacherList()
        {
            return TeacherDAL.GetTeachers();
        }
        public static TeacherDto GetTeacherById(int id)
        {
            return TeacherDAL.GetTeacherById(id);
        }




        public static TeacherDto Login(string email, string password)
        {
            TeacherDto t = new TeacherDAL().Login(email, password);
            return t;
        }

    }
}
