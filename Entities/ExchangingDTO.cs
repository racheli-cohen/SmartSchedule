using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExchangingDTO
    {
        public int id { get; set; }
        public int classId { get; set; }
        public System.DateTime sourceDate { get; set; }
        public int teacherId { get; set; }
        public Nullable<int> substituteTeacherId { get; set; }
        public Nullable<System.DateTime> destinationDate { get; set; }
        public bool is_exchaning { get; set; }
        public int ask_id { get; set; }
        public bool is_relevant { get; set; }
    }
}
