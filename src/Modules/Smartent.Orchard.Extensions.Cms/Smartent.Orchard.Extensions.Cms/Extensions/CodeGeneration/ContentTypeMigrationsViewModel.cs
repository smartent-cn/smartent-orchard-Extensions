using System;

namespace Smartent.Orchard.Extensions.Cms.Extensions.CodeGeneration;

public class ContentTypeMigrationsViewModel
{
    internal Lazy<string> MigrationCodeLazy { get; set; }
    public string MigrationCode => MigrationCodeLazy.Value;
}
