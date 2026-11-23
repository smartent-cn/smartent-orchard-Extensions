using System;

namespace Smartent.Test.UI.Attributes;

/// <summary>
/// This attribute is used to annotate the VisualVerificationApproved methods in the call stack to get the consumer
/// method.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public sealed class VisualVerificationApprovedMethodAttribute : Attribute;
