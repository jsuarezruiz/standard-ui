﻿using System;

namespace Microsoft.StandardUI
{
    [AttributeUsage(AttributeTargets.Class)]
    public class WpfStandardUIElementAttribute : Attribute
    {
        /// <summary>
        /// The interface type that the UIElement implements
        /// </summary>
        public Type InterfaceType { get; }

        public WpfStandardUIElementAttribute(Type interfaceType)
        {
            InterfaceType = interfaceType;
        }
    }
}
