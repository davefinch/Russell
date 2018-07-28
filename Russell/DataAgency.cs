using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russell
{
    public class DataRecord
    {
        public int RecordId { get; set; }
        public string RecordName { get; set; }
        public string TerritoryName { get; set; }
        public string MarkName { get; set; }
        public string ApplicationNumber { get; set; }
        public string RegistrationNumber { get; set; }
        public string StatusTypeName { get; set; }
        public string Class { get; set; }
        public DateTime? FiledDate { get; set; }
        public DateTime? GrantedDate { get; set; }
        public DateTime? RenewalDueDate { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public string Tasks { get; set; }


    }
}


