using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExchangingDto
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string SourceDate { get; set; }
        public string SourceDayName { get; set; }
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public int? SubstituteTeacherId { get; set; }
        public string SubstituteTeacherName { get; set; }
        public string DestinationDate { get; set; }
        public string DestinationDayName { get; set; }
        public bool IsExchanging { get; set; }
        public string Message { get; set; }
        public string ClassAddress { get; set; }
        public int AskId { get; set; }
        public bool IsRelevant { get; set; }


    }
}
