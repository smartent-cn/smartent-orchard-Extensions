#!/usr/bin/env python3
"""Replace Lombiq product branding with Smartent in src/tools/scripts/NuGetVerify."""

from __future__ import annotations

import os
import re
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
SCOPE_DIRS = ("src", "tools", "scripts", "NuGetVerify")
ROOT_FILES = ("Readme.md", "Directory.Build.props", "Directory.Build.targets", "AGENTS.md")
SKIP_DIR_NAMES = {"node_modules", "bin", "obj", ".git", ".vs"}
SKIP_REL_PREFIXES = (
    "重构-重组-改名项目方案",
    os.path.join("docs", "migration"),
)
SKIP_BASENAMES = {"CompatibilitySuppressions.xml", "Apply-SmartentBrandCleanup.py"}

TEXT_EXTENSIONS = {
    ".cs", ".cshtml", ".csproj", ".props", ".targets", ".md", ".json", ".json5", ".yml", ".yaml",
    ".js", ".mjs", ".ps1", ".psd1", ".psm1", ".nuspec", ".sln", ".slnx", ".liquid", ".xml",
    ".scss", ".css", ".html", ".txt", ".config", ".editorconfig", ".gitattributes", ".gitignore",
}

REPLACEMENTS = [
    ("PackageVersionLombiqHelpfulLibraries", "PackageVersionSmartentPlatform"),
    ("PackageVersionLombiqTestsUI", "PackageVersionSmartentTestsUI"),
    ("PackageVersionLombiqTests", "PackageVersionSmartentTests"),
    ("LombiqHostingSuite", "SmartentHosting"),
    ("OrchardCore;Lombiq;", "OrchardCore;Smartent;"),
    ("<Authors>Lombiq Technologies</Authors>", "<Authors>Smartent</Authors>"),
    ('Author = "Lombiq Technologies"', 'Author = "Smartent"'),
    ("Lombiq Technologies Ltd.", "Smartent"),
    ("Lombiq Technologies", "Smartent"),
    ("Lombiq Helpful Extensions", "Smartent Orchard Extensions"),
    ("Lombiq Hosting", "Smartent Orchard Hosting"),
    ("Lombiq Base Theme", "Smartent Orchard Theme Base"),
    ("Lombiq Vue.js", "Smartent Orchard Vue.js"),
    ("Lombiq Data Tables", "Smartent Orchard Data Tables"),
    ("Lombiq Chart.js", "Smartent Orchard Chart.js"),
    ("Lombiq Content Editors", "Smartent Orchard Content Editors"),
    ("Lombiq Marketing", "Smartent Orchard Marketing"),
    ("Lombiq UI Testing Toolbox", "Smartent UI Testing"),
    ("Lombiq Open-Source Orchard Core Extensions", "Smartent Orchard Demo"),
    ("Lombiq Async Editor", "Smartent Async Editor"),
    ("Lombiq PowerShell Analyzers", "Smartent PowerShell Analyzers"),
    ("Lombiq .NET Analyzers", "Smartent .NET Analyzers"),
    ("Lombiq MSBuild SDK", "Smartent MSBuild SDK"),
    ("lombiq.markdownlint.json", "smartent.markdownlint.json"),
    ("LombiqSymbolLogoColorWhiteFlaskSquareForNuGetPackages.png", "SmartentSymbolLogoColorWhiteFlaskSquareForNuGetPackages.png"),
    ("'$(SmartentSdkName)' == '' AND '$(LombiqSdkName)' == ''", "'$(SmartentSdkName)' == ''"),
    ("btn-disable-Lombiq_HelpfulExtensions_Widgets", "btn-disable-Smartent_Orchard_Extensions_Widgets"),
    ('<add key="LombiqPreview"', '<add key="SmartentPreview"'),
    ('<add key="Lombiq"', '<add key="SmartentLegacyFeed"'),
]

GITHUB_LOMBIQ_RE = re.compile(r"https://github\.com/Lombiq/[^\s\"'<>)\]]+")
GITEE_ORCHARD_EXTENSIONS = "https://gitee.com/smartent/smartent-orchard-Extensions"
GITEE_TRAINING_DEMO = "https://gitee.com/smartent/smartent-training-demo-modules"


def map_lombiq_github_url(url: str) -> str:
    lower = url.lower()
    if "training-demo" in lower or "orchard-training" in lower:
        return GITEE_TRAINING_DEMO
    return GITEE_ORCHARD_EXTENSIONS


def should_skip(rel: str, name: str) -> bool:
    if name in SKIP_BASENAMES:
        return True
    rel_posix = rel.replace("\\", "/")
    for prefix in SKIP_REL_PREFIXES:
        if rel_posix.startswith(prefix.replace("\\", "/")):
            return True
    return False


def iter_files() -> list[Path]:
    paths: list[Path] = []
    for name in ROOT_FILES:
        p = ROOT / name
        if p.is_file():
            paths.append(p)
    for scope in SCOPE_DIRS:
        base = ROOT / scope
        if not base.is_dir():
            continue
        for root, dirs, files in os.walk(base):
            dirs[:] = [d for d in dirs if d not in SKIP_DIR_NAMES]
            for f in files:
                path = Path(root) / f
                rel = path.relative_to(ROOT).as_posix()
                if should_skip(rel, f):
                    continue
                suf = path.suffix.lower()
                if suf in {".png", ".jpg", ".gif", ".webp", ".dll", ".pdb", ".vsidx"}:
                    continue
                if suf not in TEXT_EXTENSIONS and f not in {".eslintrc", "License.md", "NuGet.config"}:
                    continue
                paths.append(path)
    return paths


def transform(content: str, rel: str) -> str:
    new = content
    for old, rep in REPLACEMENTS:
        new = new.replace(old, rep)

    new = GITHUB_LOMBIQ_RE.sub(lambda m: map_lombiq_github_url(m.group(0)), new)

    if rel.endswith("License.md"):
        new = re.sub(
            r"Copyright © \d{4}, \[Lombiq Technologies Ltd\.\]\(https://lombiq\.com\)",
            "Copyright © 2026, Smartent",
            new,
        )

    new = new.replace(
        "($(MSBuildProjectName.StartsWith('Smartent.')) OR $(MSBuildProjectName.StartsWith('Lombiq.')))",
        "$(MSBuildProjectName.StartsWith('Smartent.'))",
    )
    new = new.replace(
        "<IsLombiqProject Condition=\"'$(IsLombiqProject)' == '' AND '$(IsSmartentProject)' == 'true'\">true</IsLombiqProject>\n",
        "",
    )
    new = new.replace(
        "<IsLombiqProject Condition=\"'$(IsLombiqProject)' == '' AND '$(IsSmartentProject)' == 'true'\">true</IsLombiqProject>",
        "",
    )

    lines = []
    for line in new.splitlines(keepends=True):
        if "<LombiqSdkName>" in line:
            continue
        if "PackageVersionLombiq" in line and "<PackageVersion" in line:
            continue
        lines.append(line)
    new = "".join(lines)

    return new


def main() -> None:
    changed = 0
    for path in iter_files():
        try:
            text = path.read_text(encoding="utf-8")
        except (UnicodeDecodeError, OSError):
            continue
        rel = path.relative_to(ROOT).as_posix()
        updated = transform(text, rel)
        if updated != text:
            path.write_text(updated, encoding="utf-8", newline="\n")
            changed += 1
    print(f"Smartent brand cleanup: updated {changed} files.")


if __name__ == "__main__":
    main()