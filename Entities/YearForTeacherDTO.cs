using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class YearForTeacherDTO
    {
        public int id { get; set; }
        public int teacherId { get; set; }
        public int year { get; set; }
        public int organizationCode { get; set; }
    }
}
