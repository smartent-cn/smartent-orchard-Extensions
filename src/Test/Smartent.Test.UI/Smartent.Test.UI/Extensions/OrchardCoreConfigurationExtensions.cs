using Smartent.Test.UI.Services;
using OrchardCore.Elasticsearch.Core.Recipes;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace Smartent.Test.UI.Extensions;

[SuppressMessage("Naming", "CA1708:Identifiers should differ by more than case", Justification = "Necessary due to a typo.")]
public static class OrchardCoreConfigurationExtensions
{
    /// <summary>
    /// Configure the app settings to use the provided <paramref name="prefix"/> in the Elasticsearch indexes created by
    /// the <see cref="ElasticsearchIndexStep"/>.
    /// </summary>
    public static void ConfigureElasticsearchPrefix(this OrchardCoreConfiguration configuration, string prefix) =>
        configuration.BeforeAppStart += (_, arguments) =>
        {
            arguments.AddWithValue("OrchardCore:OrchardCore_Elasticsearch:IndexPrefix", prefix);
            return Task.CompletedTask;
        };
}
