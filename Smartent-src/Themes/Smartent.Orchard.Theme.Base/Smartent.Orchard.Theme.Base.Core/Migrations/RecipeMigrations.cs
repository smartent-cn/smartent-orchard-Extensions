using OrchardCore.Data.Migration;
using OrchardCore.Recipes.Services;
using System.Threading.Tasks;

namespace Smartent.Orchard.Theme.Base.Core.Migrations;

public sealed class RecipeMigrations : DataMigration
{
    private readonly IRecipeMigrator _recipeMigrator;

    public RecipeMigrations(IRecipeMigrator recipeMigrator) => _recipeMigrator = recipeMigrator;

    public async Task<int> CreateAsync()
    {
        await _recipeMigrator.ExecuteAsync("Smartent.Orchard.Theme.Base.LayersAndZones.recipe.json", this);

        return 1;
    }
}
