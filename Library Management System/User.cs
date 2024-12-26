﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    abstract class User
    {
        public string Name { get; set; }
        public string UserID { get; set; }

        public abstract void DisplayDetails();
    }
}