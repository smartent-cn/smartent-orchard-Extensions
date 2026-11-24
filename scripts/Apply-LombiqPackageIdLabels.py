#!/usr/bin/env python3
"""Rename Lombiq.* display labels in docs to Smartent PackageIds (not runtime/API symbols)."""

from __future__ import annotations

import os
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
SCOPE_DIRS = ("src", "tools", "NuGetVerify", "docs")
ROOT_FILES = ("Readme.md",)
SKIP_DIR_NAMES = {"node_modules", "bin", "obj", ".git"}
SKIP_REL_PREFIXES = (
    os.path.join("docs", "migration"),
    "重构-重组-改名项目方案",
)
SKIP_BASENAMES = {
    "CompatibilitySuppressions.xml",
    "Legacy-to-Smartent-src-Mapping.md",
    "Apply-LombiqPackageIdLabels.py",
}

# Longest Lombiq.* identifiers first.
PACKAGE_ID_LABELS = [
    ("Lombiq.HelpfulLibraries.SourceGenerators", "Smartent.Core.CodeGen.SourceGenerators"),
    ("Lombiq.HelpfulLibraries.LinqToDb", "Smartent.Orchard.Platform.Data.LinqToYesSql"),
    ("Lombiq.HelpfulLibraries.Refit", "Smartent.Orchard.Http.Refit"),
    ("Lombiq.HelpfulLibraries.RestEase", "Smartent.Orchard.Http.RestEase"),
    ("Lombiq.HelpfulLibraries.Cli", "Smartent.Core.Cli"),
    ("Lombiq.HelpfulLibraries", "Smartent.Orchard.Platform"),
    ("Lombiq.OrchardCoreApiClient", "Smartent.Orchard.ApiClient"),
    ("Lombiq.Hosting.Azure.ApplicationInsights", "Smartent.Orchard.Hosting.ApplicationInsights"),
    ("Lombiq.Hosting.BuildVersionDisplay", "Smartent.Orchard.Hosting.BuildVersion"),
    ("Lombiq.Hosting.MediaTheme.Bridge", "Smartent.Orchard.Theme.Media.Bridge"),
    ("Lombiq.Hosting.MediaTheme", "Smartent.Orchard.Theme.Media"),
    ("Lombiq.Hosting.Tenants.Admin.Login", "Smartent.Orchard.Hosting.Tenants.Admin.Login"),
    ("Lombiq.Hosting.Tenants.EnvironmentRobots", "Smartent.Orchard.Hosting.Tenants.EnvironmentRobots"),
    ("Lombiq.Hosting.Tenants.FeaturesGuard", "Smartent.Orchard.Hosting.Tenants.FeaturesGuard"),
    ("Lombiq.Hosting.Tenants.IdleTenantManagement", "Smartent.Orchard.Hosting.Tenants.IdleTenantManagement"),
    ("Lombiq.Hosting.Tenants.HealthChecks", "Smartent.Orchard.Hosting.Tenants.HealthChecks"),
    ("Lombiq.Hosting.Tenants.Maintenance", "Smartent.Orchard.Hosting.Tenants.Maintenance"),
    ("Lombiq.Hosting.Tenants.Management", "Smartent.Orchard.Hosting.Tenants.Management"),
    ("Lombiq.Hosting.Tenants.EmailQuotaManagement", "Smartent.Orchard.Hosting.Tenants.EmailQuotaManagement"),
    ("Lombiq.Hosting.Tenants.MediaStorageManagement", "Smartent.Orchard.Hosting.Tenants.MediaStorageManagement"),
    ("Lombiq.ContentEditors.Samples", "Smartent.Orchard.ContentEditors.Samples"),
    ("Lombiq.AuditTrailExtensions", "Smartent.Orchard.AuditTrail"),
    ("Lombiq.ContentEditors", "Smartent.Orchard.ContentEditors"),
    ("Lombiq.LoginAsAnybody", "Smartent.Orchard.LoginAsAnybody"),
    ("Lombiq.Marketing.UrlShortener", "Smartent.Orchard.Marketing.UrlShortener"),
    ("Lombiq.Marketing.Pirsch", "Smartent.Orchard.Marketing.Pirsch"),
    ("Lombiq.Marketing", "Smartent.Orchard.Marketing"),
    ("Lombiq.TrainingDemo", "Smartent.Orchard.TrainingDemo"),
    ("Lombiq.Walkthroughs", "Smartent.Orchard.Walkthroughs"),
    ("Lombiq.JsonEditor", "Smartent.Orchard.JsonEditor"),
    ("Lombiq.EmailClient", "Smartent.Orchard.EmailClient"),
    ("Lombiq.Privacy", "Smartent.Orchard.Privacy"),
    ("Lombiq.VueJs", "Smartent.Orchard.VueJs"),
    ("Lombiq.OSOCE.Samples", "Smartent.Demo.Samples"),
]

PROSE = [
    ("Lombiq's Open-Source Orchard Extensions", "Smartent Orchard Extensions (Orchard 1)"),
    ("Lombiq Open Source Orchard Core Extensions", "Smartent Orchard Extensions"),
    ("Lombiq Helpful Libraries", "Smartent Orchard Platform libraries"),
    ("Lombiq Testing Toolbox for Orchard Core", "Smartent UI Testing for Orchard Core"),
    ("Lombiq Testing Toolbox", "Smartent UI Testing"),
    ("Lombiq Training Demo for Orchard Core", "Smartent Orchard Training Demo"),
    ("Lombiq Training Demo", "Smartent Orchard Training Demo"),
    ("Lombiq GitHub Actions", "Smartent GitHub Actions"),
    ("Lombiq's recommended", "Smartent's recommended"),
    ("between Lombiq projects", "between Smartent projects"),
    ("Lombiq UI Kit", "Smartent Orchard UIKit"),
    ("Lombiq Privacy", "Smartent Orchard Privacy"),
    ("the Lombiq UI Kit", "Smartent Orchard UIKit"),
]


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
                if not f.endswith((".md", ".cshtml", ".yml")):
                    continue
                path = Path(root) / f
                rel = path.relative_to(ROOT).as_posix()
                if should_skip(rel, f):
                    continue
                paths.append(path)
    return paths


def transform(text: str) -> str:
    out = text
    for old, new in PACKAGE_ID_LABELS:
        out = out.replace(f"`{old}`", f"`{new}`")
        out = out.replace(old, new)
    for old, new in PROSE:
        out = out.replace(old, new)
    out = out.replace(
        "下列 Lombiq 外链为 Legacy OSOCE 说明，逐项迁移中。",
        "下列为仓库内 Smartent PackageId 索引（链至本单体仓）。",
    )
    return out


def main() -> None:
    changed = 0
    for path in iter_files():
        try:
            text = path.read_text(encoding="utf-8")
        except (UnicodeDecodeError, OSError):
            continue
        updated = transform(text)
        if updated != text:
            path.write_text(updated, encoding="utf-8", newline="\n")
            changed += 1
    print(f"Lombiq PackageId labels in docs: {changed} files.")


if __name__ == "__main__":
    main()