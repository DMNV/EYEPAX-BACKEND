﻿using System;

namespace EyepaxCalculation.Domain
{
    public abstract class NotFoundException : Exception
    {
        protected NotFoundException(string message)
            : base(message)
        {
        }
    }
}
