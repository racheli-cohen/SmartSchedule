
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TeacherScheduleDto
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int TeacherId { get; set; }


        public string TeacherName { get; set; }
        public string TeacherPhone { get; set; }
        public string TeacherEmail { get; set; }
        public List<DetailsDto> Details { get; set; }
        public bool IsExchanging { get; set; }

    }
}
