﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3.Model
{
    public class General<T>
    {
        public bool IsSucces { get; set; }

        public T Entity { get; set; }
        public List<T> List { get; set; }

        public int TotalCount { get; set; }

        public List<string> ValidationErrorList { get; set; }

        public string ExceptionMessage { get; set; }
    }
}