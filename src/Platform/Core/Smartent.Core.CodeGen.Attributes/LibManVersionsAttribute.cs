using System;

namespace Smartent.Core.CodeGen.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public sealed class LibManVersionsAttribute : Attribute
{
    public LibManVersionsAttribute(string fileName = "libman.json")
    {
    }
}
