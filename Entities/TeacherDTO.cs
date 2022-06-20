using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class TeacherDTO
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int neighborhoodCode { get; set; }
        public string street { get; set; }
        public int buildingNumber { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
