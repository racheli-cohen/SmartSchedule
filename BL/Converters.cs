using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Converters
    {
        public TeacherDTO ConvertTeacherToDto(Teacher res)
        {
            TeacherDTO dest = new TeacherDTO();
            dest.buildingNumber = res.buildingNumber;
            dest.email = res.email;
            dest.firstName = res.firstName;
            dest.id = res.id;
            dest.lastName = res.lastName;
            dest.neighborhoodCode = res.neighborhoodCode;
            dest.password = res.password;
            dest.phone = res.phone;
            dest.street = res.street;
            return dest;
        }
        public Teacher ConvertTeacherDtoToTeacher(TeacherDTO res)
        {
            Teacher dest = new Teacher();
            dest.buildingNumber = res.buildingNumber;
            dest.email = res.email;
            dest.firstName = res.firstName;
            dest.id = res.id;
            dest.lastName = res.lastName;
            dest.neighborhoodCode = res.neighborhoodCode;
            dest.password = res.password;
            dest.phone = res.phone;
            dest.street = res.street;
            return dest;
        }
        public List<Teacher> ConvertListTeacherDtoToTeacher(List<TeacherDTO> res)
        {
           List<Teacher> dest = new List<Teacher>();
            foreach (TeacherDTO item in res)
            {
                dest.Add(ConvertTeacherDtoToTeacher(item));
            }
            
            return dest;
        }
        public List<TeacherDTO> ConvertListTeacherToTeacherDto(List<Teacher> res)
        {
            List<TeacherDTO> dest = new List<TeacherDTO>();
            foreach (Teacher item in res)
            {
                dest.Add(ConvertTeacherToDto(item));
            }

            return dest;
        }
        public Neighborhood ConvertNeighborhoodDtoToNeighborood(NeighborhoodDTO res)
        {
            Neighborhood dest = new Neighborhood();
            dest.cityCode = res.cityCode;
            dest.neighborhoodCode = res.neighborhoodCode;
            dest.neighborhoodName = res.neighborhoodName;
            return dest;
        }
        public NeighborhoodDTO ConvertNeighborhoodToNeighboroodDto(Neighborhood res)
        {
            NeighborhoodDTO dest = new NeighborhoodDTO();
            dest.cityCode = res.cityCode;
            dest.neighborhoodCode = res.neighborhoodCode;
            dest.neighborhoodName = res.neighborhoodName;
            return dest;
        }
       
    }
}
