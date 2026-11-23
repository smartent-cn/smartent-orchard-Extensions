using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace Smartent.Core.AspNet.Mvc;

[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = true)]
public sealed class FromJsonQueryStringAttribute : ModelBinderAttribute
{
    public FromJsonQueryStringAttribute()
    {
        BinderType = typeof(JsonModelBinder);
        BindingSource = BindingSource.Query;
    }
}
