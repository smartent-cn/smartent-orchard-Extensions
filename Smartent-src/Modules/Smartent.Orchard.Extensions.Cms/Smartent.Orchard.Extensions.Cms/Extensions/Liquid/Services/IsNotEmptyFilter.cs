using Fluid;
using Fluid.Ast;
using Fluid.Values;
using Smartent.Orchard.Extensions.Cms.Extensions.Liquid.Helpers;
using OrchardCore.Liquid;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Smartent.Orchard.Extensions.Cms.Extensions.Liquid;

public class IsNotEmptyFilter : ILiquidFilter
{
    public async ValueTask<FluidValue> ProcessAsync(
        FluidValue input,
        FilterArguments arguments,
        LiquidTemplateContext context)
    {
        var argumentExpressions = new List<Expression>(capacity: arguments.Count + 1) { new LiteralExpression(input) };

        for (var i = 0; i < arguments.Count; i++)
        {
            argumentExpressions.Add(new LiteralExpression(arguments.At(i)));
        }

        return BooleanValue.Create(await LiquidParserHelpers.IsAnyNotNullOrWhiteSpaceAsync(argumentExpressions, context));
    }
}
