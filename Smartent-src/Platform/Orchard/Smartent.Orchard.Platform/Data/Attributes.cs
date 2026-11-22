using System;

namespace Smartent.Orchard.Platform.Data;

[AttributeUsage(AttributeTargets.Property)]
public sealed class ContentItemIdColumnAttribute : Attribute;

[AttributeUsage(AttributeTargets.Property)]
public sealed class UnlimitedLengthAttribute : Attribute;
