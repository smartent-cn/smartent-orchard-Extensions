using System;

namespace Smartent.Core.CodeGen.Attributes;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class ConstantFromJsonAttribute : Attribute
{
    public ConstantFromJsonAttribute(string constantName, string fileName, string propertyName)
    {
    }
}
