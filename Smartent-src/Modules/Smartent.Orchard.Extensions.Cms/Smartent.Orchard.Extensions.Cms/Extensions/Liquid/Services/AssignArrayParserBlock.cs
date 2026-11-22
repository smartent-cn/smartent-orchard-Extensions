using Fluid;
using Fluid.Ast;
using Fluid.Values;
using Smartent.Orchard.Extensions.Cms.Extensions.Liquid.Helpers;
using Smartent.Orchard.Platform.Liquid;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Smartent.Orchard.Extensions.Cms.Extensions.Liquid;

public class AssignArrayParserBlock : ILiquidParserTag
{
    public async ValueTask<Completion> WriteToAsync(
        IReadOnlyList<FilterArgument> argumentsList,
        TextWriter writer,
        TextEncoder encoder,
        TemplateContext context)
    {
        var arguments = await LiquidParserHelpers.EvaluateAsync(argumentsList, context);

        if (arguments.Count >= 1)
        {
            context.SetValue(
                arguments[0].ToStringValue(),
                FluidValue.Create(arguments.Skip(1).ToArray(), context.Options));
        }

        return Completion.Normal;
    }
}
