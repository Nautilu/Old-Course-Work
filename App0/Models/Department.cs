﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App0.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Department()
        {
        }
        public Department(int id, string Name)
        {
            this.ID = id;
            this.Name = Name;
            
        }
    }

}
