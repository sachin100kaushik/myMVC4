using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.Models
{
    [Table("tblCustomer")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }  
        public string Gender { get; set; }
        public String City { get; set; }
        public DateTime DateOfBirth { get; set; }


        
    }
}
