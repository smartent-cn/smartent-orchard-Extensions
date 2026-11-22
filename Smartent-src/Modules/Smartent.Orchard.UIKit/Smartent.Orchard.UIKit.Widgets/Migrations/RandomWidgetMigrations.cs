using Smartent.Orchard.UIKit.Widgets.Models;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Builders;

namespace Smartent.Orchard.UIKit.Widgets.Migrations;

public class RandomWidgetMigrations : WidgetMigrationBase<RandomWidget>
{
    public RandomWidgetMigrations(IContentDefinitionManager contentDefinitionManager)
        : base(contentDefinitionManager)
    { }

    protected override void DefinePart(ContentPartDefinitionBuilder<RandomWidget> builder) { }
}
