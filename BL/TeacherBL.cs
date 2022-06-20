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
        public static TeacherDTO GetTeacherById(int id)
        {
            Teacher t = new TeacherDAL().GetTeacherById(id);
            TeacherDTO dto = new Converters().ConvertTeacherToDto(t);

            return dto;
        }
        public static List<TeacherDTO> GetTeachers()
        {
            List<Teacher> teachers = new TeacherDAL().GetTeachers();

            List<TeacherDTO> dto = new Converters().ConvertListTeacherToTeacherDto(teachers);

            return dto;
        }
        public static TeacherDTO Login(string email, string password)
        {
            Teacher t = new TeacherDAL().Login(email, password);
            TeacherDTO dto = new Converters().ConvertTeacherToDto(t);
            return dto;
        }

    }
}
