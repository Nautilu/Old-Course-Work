﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App0.Models
{
    public class Job
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Job()
        {
        }
        public Job(int id, string Name)
        {
            this.ID = id;
            this.Name = Name;
        }
    }
}
