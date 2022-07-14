﻿using System;

namespace Microsoft.StandardUI
{
    public class FactoryNotInitializedException : Exception
    {
        public FactoryNotInitializedException(string controlLibraryName) : base($"{controlLibraryName} factory hasn't been initialized yet. Call {controlLibraryName}Library.Initialize()")
        {
        }
    }
}
