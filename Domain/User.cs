﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public int ID { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
            
        public string password { get; set; }
        public string email { get; set; }
        public bool IsAdmin { get; set; }
    }
}