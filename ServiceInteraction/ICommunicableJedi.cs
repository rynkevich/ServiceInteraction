﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInteraction
{
    public interface ICommunicableJedi
    {
        string SayHi(uint greetingsCounter, string log);
    }
}
