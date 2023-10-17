﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTest
{
    internal interface XML<T>
    {
        bool SerializarGeneric(T dato, string path);
        T DeserializarGeneric(string path);
    }
}
