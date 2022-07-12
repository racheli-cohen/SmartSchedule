using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GenderConstraintDto
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int GenderCode { get; set; }
        public string GenderName { get; set; }
    }
}
