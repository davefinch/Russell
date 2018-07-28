using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russell
{
    public class DataJob
    {
        public int JobId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public int AgencyId { get; set; }
        public string AgencyName { get; set; }
        public string JobDetails { get; set; }
        public DateTime? StartJob { get; set; }
        public DateTime? EndJob { get; set; }
        public decimal Hours { get; set; }
        public decimal Rate { get; set; }
        public DateTime? PaymentReceivedDate { get; set; }
        public decimal TotalPaymentReceived { get; set; }



    }
}