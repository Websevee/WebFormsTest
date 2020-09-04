using System;
using System.ComponentModel.DataAnnotations;

namespace WebFormsTest.Models
{
    public class Payment
    {
        [ScaffoldColumn(false)]
        public int PaymentId { get; set; }

        [Range(typeof(DateTime), "1.1.1000", "1.1.3000", ErrorMessage = "Please provide an enrollment date after 1.1.1000")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        [DataType(DataType.Date)]
        public System.DateTime PaymentDate { get; set; }

        public decimal Sum { get; set; }

        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}