using OrchardCore.DisplayManagement.Views;

namespace Smartent.Orchard.TrainingDemo.ViewModels;

public class StaticallyTypedDerivedTestShapeViewModel : ShapeViewModel
{
    public int SomeValue { get; set; }
    public int SomeOtherValue { get; set; }

    public StaticallyTypedDerivedTestShapeViewModel() => Metadata.Type = "StaticallyTypedDerivedTestShape";
}
