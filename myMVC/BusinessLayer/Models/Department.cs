using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.Models
{
    [Table("tblDepartment")]
    public class Department
    {
        [Key]
        public int DepId { get; set; }
        public string Name { get; set; }
        public List<Employee> employees { get; set; }
    }
}
