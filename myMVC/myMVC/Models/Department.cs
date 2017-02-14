using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace myMVC.Models
{
    [Table("tblDepartment")]
    public class Department
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }      
        public List<Employee> employees { get; set; }
    }
}