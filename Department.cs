﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCSharpBTLINQ2
{
    class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Department> getDepartments()
        {
            return new List<Department>()
            {
                new Department { ID = 1, Name = "IT" },
                new Department { ID = 2, Name = "HR" },
                new Department { ID = 3, Name = "Marketing" }
            };
        }
    }
}
