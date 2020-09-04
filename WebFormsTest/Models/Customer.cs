using System.ComponentModel.DataAnnotations;

namespace WebFormsTest.Models
{
    public class Customer
    {
        [ScaffoldColumn(false)]
        public int CustomerId { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string CustomerName { get; set; }
    }
}