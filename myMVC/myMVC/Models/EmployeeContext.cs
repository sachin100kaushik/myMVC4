﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace myMVC.Models
{
    public class EmployeeContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}