﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> employees { get; set; }
    }
}