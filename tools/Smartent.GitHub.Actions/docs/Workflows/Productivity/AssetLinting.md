# Asset Linting

This workflow uses `eslint` and `stylelint` to validate your JavaScript, CSS and Markdown files.

If you just want to lint all _.css_, _.js_, and _.md_ files in your repository, then nothing to configure, simply do this:

```yaml
...

jobs:
  asset-linting:
    name: Asset Linting
    uses: Lombiq/GitHub-Actions/.github/workflows/asset-lint.yml@dev
```

If you want to opt-in instead, then you'd typically consume the workflow by passing in a semicolon-separated list of the project paths where scripts, styles, or texts are to be linted:

```yaml
...

jobs:
  asset-linting:
    name: Asset Linting
    uses: Lombiq/GitHub-Actions/.github/workflows/asset-lint.yml@dev
    with:
      scripts: >
        src/Modules/Smartent.Orchard.ContentEditors/Smartent.Orchard.ContentEditors;
        src/Modules/Smartent.Orchard.ContentEditors/Smartent.Orchard.ContentEditors.Samples;
        src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables;
        src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms;
        src/Modules/Smartent.Orchard.UIKit/Smartent.Orchard.UIKit;
        src/Modules/Smartent.Orchard.Walkthroughs/Smartent.Orchard.Walkthroughs;
        src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.Maintenance;
      styles: >-
        src/Modules/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs.Samples;
        src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms;
        src/Modules/Smartent.Orchard.JsonEditor/Smartent.Orchard.JsonEditor;
        src/Modules/Smartent.Orchard.Privacy/Smartent.Orchard.Privacy;
        src/Modules/Smartent.Orchard.UIKit/Smartent.Orchard.UIKit;
        src/Themes/Smartent.Orchard.Theme.Base/Smartent.Orchard.Theme.Base.Core;
        src/Themes/Smartent.Orchard.Theme.Base/Smartent.Orchard.Theme.Base.Native;
        src/Themes/Smartent.Orchard.Theme.Base/Smartent.Orchard.Theme.Base.Samples;
      texts: >-
        src/Modules/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs.Samples;
        src/Modules/Smartent.Orchard.ContentEditors/Smartent.Orchard.ContentEditors;
        src/Modules/Smartent.Orchard.ContentEditors/Smartent.Orchard.ContentEditors.Samples;
        src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables;
        src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms;
        src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.Maintenance;
        src/Modules/Smartent.Orchard.JsonEditor/Smartent.Orchard.JsonEditor;
        src/Modules/Smartent.Orchard.Privacy/Smartent.Orchard.Privacy;
        src/Modules/Smartent.Orchard.UIKit/Smartent.Orchard.UIKit;
        src/Modules/Smartent.Orchard.Walkthroughs/Smartent.Orchard.Walkthroughs;
        src/Themes/Smartent.Orchard.Theme.Base/Smartent.Orchard.Theme.Base.Core;
        src/Themes/Smartent.Orchard.Theme.Base/Smartent.Orchard.Theme.Base.Native;
        src/Themes/Smartent.Orchard.Theme.Base/Smartent.Orchard.Theme.Base.Samples;
```

This will lint the files in _wwwroot/js_ and _wwwroot/css_ folders under the given folders, respectively. If you need linting in a different directory, you can also append `:{relative path or glob pattern}` after each project directory path. For example to lint scripts in the project root:

```yaml
  asset-linting:
    name: Asset Linting
    uses: Lombiq/GitHub-Actions/.github/workflows/asset-lint.yml@dev
    with:
      scripts: >
        src/Libraries/Smartent.Orchard.EInvoice/Smartent.Orchard.EInvoice:.
```

For descriptions of all of the workflow inputs, see [the workflow file](../../../.github/workflows/asset-lint.yml).

## Configuration

You can override the following configuration files by having their counterpart in your repository root:

CSS configuration files:

- .stylelintignore: A _.gitignore_ style file where you can list excludes for Stylelint.
- stylelint.config.mjs: The main configuration file for Stylelint.

JavaScript configuration files:

- eslint.config.mjs: The main configuration file for ESLint. It is not recommended to override this file.
- eslint.custom.mjs: If this file exists, it's loaded in by the the workflow's _eslint.config.mjs_ at the highest precedence. In other words you can override rules or other settings here while still extending the main Lombiq ESLint config file.

Markdown configuration files:

- .markdownlint-cli2.mjs: The main configuration file for [markdownlint-cli2](https://github.com/DavidAnson/markdownlint-cli2?tab=readme-ov-file#configuration).
- .markdownlintignore: A file of newline separated glob expressions used to ignore items in the project when running markdownlint.
- .textlintignore: The same but for textlint.
- .textlintrc.js: The main configuration file for [textlint](https://textlint.org/docs/configuring/).

> [!TIP]
> You can disable rules in textlint using the "comments" filter, which is installed by default. Read more about it in [the package's readme](https://github.com/textlint/textlint-filter-rule-comments).

## How to Run Locally

1. Check out this repository in your local machine.
2. Open PowerShell in the root directory of the repository you want to lint.
3. Type `path-to-GHA/.github/actions/asset-lint/Invoke-Linter.ps1 -ScriptsString relative/path/to/project -StylesString relative/path/to/project`. You can omit either switches if you don't want to lint both.

> [!WARNING]
> To be safe, always quote parameters so PowerShell passes them correctly.

```pwsh
.../Open-Source-Orchard-Core-Extensions/tools/Smartent.GitHub.Actions/.github/actions/asset-lint/Invoke-Linter.ps1 -ScriptsString 'src/Modules/Smartent.Orchard.UIKit/Smartent.Orchard.UIKit:wwwroot/js' -StylesString 'src/Modules/Smartent.Orchard.UIKit/Smartent.Orchard.UIKit:wwwroot/css' -TextsString .
```

> [!TIP]
> Add the _path-to-GHA/.github/actions/asset-lint_ directory to your execution path so you can use `Invoke-Linter` like a regular command.
