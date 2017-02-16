using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace myMVC.Models
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