# Quick start

> Index: [README.md](README.md) · Gateway: [../README.md](../README.md)

Install the [NuGet package](https://www.nuget.org/packages/Smartent.Tailwind.Targets/). If you use the project from a
submodule, add the following lines to the csproj file where the Tailwind input CSS file lives. Make sure that the paths
are pointing to the _Smartent.Build.Tailwind.props_ and _Smartent.Build.Tailwind.targets_ files of this project.

```xml
<Import Project="path\to\Smartent.Tailwind.Targets\Smartent.Tailwind.Targets\Smartent.Tailwind.Targets.props" />
<Import Project="path\to\Smartent.Tailwind.Targets\Smartent.Tailwind.Targets\Smartent.Tailwind.Targets.targets" />
```

Create a Tailwind input CSS file (for Tailwind v4 this typically contains `@import "tailwindcss";` and `@source`
directives). By default the CLI is downloaded from GitHub releases. On Windows, the targets use `curl.exe`; on
Linux/macOS they use `curl`. You can override the download command with `TailwindDownloadCommand` or disable it and point
`TailwindCliPath` to a pre-downloaded binary.

This repository vendors the Windows x64 CLI as **`cli/tailwindcss-windows-x64-v4_3_5.zip`** (Tailwind **v4.3.5**). The
extracted `.exe` in the same folder is local-only and ignored by Git. When the zip or extracted CLI is available,
MSBuild uses it and skips GitHub download—useful on restricted networks. Add matching `cli/*.zip` archives for other
platforms if needed.
