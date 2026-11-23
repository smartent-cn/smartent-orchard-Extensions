using Smartent.Orchard.ChartJs.Samples.Constants;
using Smartent.Orchard.ChartJs.Samples.Helpers;
using Smartent.Orchard.ChartJs.Samples.Models;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.Data.Migration;
using System.Threading.Tasks;

namespace Smartent.Orchard.ChartJs.Samples.Migrations;
public sealed class ExpenseMigrations : DataMigration
{
    private readonly IContentDefinitionManager _contentDefinitionManager;
    private readonly IContentManager _contentManager;

    public ExpenseMigrations(IContentDefinitionManager contentDefinitionManager, IContentManager contentManager)
    {
        _contentDefinitionManager = contentDefinitionManager;
        _contentManager = contentManager;
    }

    public Task<int> CreateAsync() =>
        TransactionMigrationHelpers.CreateTransactionAsync<ExpensePart>(
            _contentDefinitionManager,
            _contentManager,
            SchemaBuilder,
            ContentTypes.Expense,
            ContentItemIds.ExpenseTagsTaxonomy);
}
