﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemManagementSystem.Model
{
    class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public string Email { get; set; }
        public int DesignationId { get; set; }
        public string Password { get; set; }
    }
}
