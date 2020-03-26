using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnet.Reflection.Example
{
    public class CustomAttribute : Attribute
    {
        public override bool IsDefaultAttribute()
        {
            return base.IsDefaultAttribute();
        }

        public override bool Match(object obj)
        {
            return base.Match(obj);
        }
    }
}
