﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Libreria.Exceptions
{
    public class NoUIntException: Exception
    {
        public NoUIntException()
        {

        }
        public NoUIntException(string message) : base(message)
        {

        }
    }
}