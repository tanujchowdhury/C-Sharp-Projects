﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ParametersAssignment
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }
    }
}
