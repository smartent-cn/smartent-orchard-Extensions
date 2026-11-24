#!/usr/bin/env python3
"""Remove legacy Lombiq identifiers and compatibility artifacts (no dual-read)."""

from __future__ import annotations

import os
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
SCOPE_DIRS = ("src", "tools", "NuGetVerify", "docs", "Demo")
ROOT_FILES = ("Readme.md", "AGENTS.md", ".codespellrc")
SKIP_DIR_NAMES = {"node_modules", "bin", "obj", ".git"}
SKIP_REL_PREFIXES = ("重构-重组-改名项目方案",)

TEXT_EXT = {
    ".cs", ".cshtml", ".csproj", ".props", ".targets", ".md", ".json", ".json5", ".yml",
    ".yaml", ".js", ".mjs", ".ps1", ".bat", ".liquid", ".xml", ".config", ".scss", ".css",
    ".sln", ".slnx", ".editorconfig",
}

# Order: longest first.
REPLACEMENTS = [
    ("Lombiq_Hosting_Azure_ApplicationInsights", "Smartent_Orchard_Hosting_ApplicationInsights"),
    ("Lombiq_HelpfulLibraries_OrchardCore_ContentSecurityPolicy", "Smartent_Orchard_Platform_ContentSecurityPolicy"),
    ("Lombiq_Hosting_Tenants_MediaStorageManagement", "Smartent_Orchard_Hosting_Tenants_MediaStorageManagement"),
    ("Lombiq_Hosting_Tenants_IdleTenantManagement", "Smartent_Orchard_Hosting_Tenants_IdleTenantManagement"),
    ("Lombiq_Hosting_Tenants_EmailQuotaManagement", "Smartent_Orchard_Hosting_Tenants_EmailQuotaManagement"),
    ("Lombiq_Hosting_Tenants_EnvironmentRobots", "Smartent_Orchard_Hosting_Tenants_EnvironmentRobots"),
    ("Lombiq_Hosting_Tenants_FeaturesGuard", "Smartent_Orchard_Hosting_Tenants_FeaturesGuard"),
    ("Lombiq_Hosting_Tenants_HealthChecks", "Smartent_Orchard_Hosting_Tenants_HealthChecks"),
    ("Lombiq_Hosting_Tenants_Maintenance", "Smartent_Orchard_Hosting_Tenants_Maintenance"),
    ("Lombiq_Hosting_Tenants_Management", "Smartent_Orchard_Hosting_Tenants_Management"),
    ("Lombiq_Hosting_Tenants_Admin_Login", "Smartent_Orchard_Hosting_Tenants_Admin_Login"),
    ("Lombiq_EmailClient_EmailSync", "Smartent_Orchard_EmailClient_EmailSync"),
    ("Lombiq_EmailClient_Imap", "Smartent_Orchard_EmailClient_Imap"),
    ("Lombiq_Privacy_ConsentBanner_Resources", "Smartent_Orchard_Privacy_ConsentBanner_Resources"),
    ("Lombiq_Privacy_ConsentCheckbox_Text", "Smartent_Orchard_Privacy_ConsentCheckbox_Text"),
    ("Lombiq_Privacy_RegistrationCheckbox_Text", "Smartent_Orchard_Privacy_RegistrationCheckbox_Text"),
    ("Lombiq_Privacy_ConsentBanner_Text", "Smartent_Orchard_Privacy_ConsentBanner_Text"),
    ("Lombiq_Privacy_RegistrationCheckbox", "Smartent_Orchard_Privacy_RegistrationCheckbox"),
    ("Lombiq_Privacy_ConsentBanner", "Smartent_Orchard_Privacy_ConsentBanner"),
    ("Lombiq_Tests_UI_Scrolling_Context", "Smartent_Test_UI_Scrolling_Context"),
    ("Lombiq_Tests_UI", "Smartent_Test_UI"),
    ("Lombiq_TrainingDemo", "Smartent_TrainingDemo"),
    ("Lombiq_Marketing", "Smartent_Marketing"),
    ("btn-disable-Lombiq_Hosting_Tenants_Admin_Login", "btn-disable-Smartent_Orchard_Hosting_Tenants_Admin_Login"),
    ("btn-disable-Lombiq_", "btn-disable-Smartent_Orchard_"),
    ("btn-enable-Lombiq_ChartJs", "btn-enable-Smartent_Orchard_ChartJs"),
    ("btn-enable-Lombiq_", "btn-enable-Smartent_Orchard_"),
    ("lombiq-privacy-consent-banner.css", "smartent-privacy-consent-banner.css"),
    ("LombiqUiKitEditorStyle", "SmartentUiKitEditorStyle"),
    ("LombiqDropdownScript", "SmartentDropdownScript"),
    ("LombiqTextBoxScript", "SmartentTextBoxScript"),
    ("LombiqSlickCarousel", "SmartentSlickCarousel"),
    ("LombiqShowcaseStyle", "SmartentShowcaseStyle"),
    ("lombiq_DataTables", "smartent_DataTables"),
    (".lombiqdt", ".smartentdt"),
    ("lombiqdt", "smartentdt"),
    ("lombiq-vue", "smartent-vue"),
    ("lombiq-vuejs", "smartent-vuejs"),
    ("lombiq-hosting-build-version-display-build-version", "smartent-hosting-build-version-display-build-version"),
    ("LombiqUITestingToolbox_", "SmartentUITestingToolbox_"),
    ("lombiquitestingtoolbox", "smartentuitestingtoolbox"),
    ("lombiqChartJsSamplesChartContainer", "smartentChartJsSamplesChartContainer"),
    ("LOMBIQ_UI_TESTING_TOOLBOX_SHARED_TEST_CONFIGURATION", "SMARTENT_UI_TESTING_TOOLBOX_SHARED_TEST_CONFIGURATION"),
    ("LOMBIQ_NODEJS_EXTENSIONS_GITHUB_ACTIONS_ROOT", "SMARTENT_NODEJS_EXTENSIONS_GITHUB_ACTIONS_ROOT"),
    ("LOMBIQ_NODEJS_EXTENSIONS_GITHUB_ACTIONS", "SMARTENT_NODEJS_EXTENSIONS_GITHUB_ACTIONS"),
    ("LOMBIQ_NODEJS_EXTENSIONS_WARN_AS_ERROR", "SMARTENT_NODEJS_EXTENSIONS_WARN_AS_ERROR"),
    ("LOMBIQ_NODEJS_EXTENSIONS_PROJECT_DIRECTORY", "SMARTENT_NODEJS_EXTENSIONS_PROJECT_DIRECTORY"),
    ("LOMBIQ_NODEJS_EXTENSIONS", "SMARTENT_NODEJS_EXTENSIONS"),
    ("currentThemeUsesLombiqBaseTheme", "currentThemeUsesSmartentBaseTheme"),
    (".eslintrc.lombiq-base.js", ".eslintrc.smartent-base.js"),
    (".prettierrc.lombiq-base.js", ".prettierrc.smartent-base.js"),
    (".stylelintrc.lombiq-base.js", ".stylelintrc.smartent-base.js"),
    ("lombiq.hosting.mediatheme.deployer", "smartent.hosting.mediatheme.deployer"),
    ("./src/Utilities/Lombiq.NodeJs.Extensions/Lombiq.NodeJs.Extensions/config/", "../"),
    ("lombiq-logo-small.svg", "smartent-logo-small.svg"),
    ("_Lombiq,UIKit_", "_Smartent,UIKit_"),
    ("const lombiqConfig", "const smartentConfig"),
    ("const lombiqRules", "const smartentRules"),
    ("lombiqRules", "smartentRules"),
    ("...lombiqConfig", "...smartentConfig"),
]

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
            rel_root = Path(root).relative_to(ROOT).as_posix()
            if any(rel_root.startswith(p.replace("\\", "/")) for p in SKIP_REL_PREFIXES):
                continue
            for f in files:
                if Path(f).suffix.lower() not in TEXT_EXT and f not in {"NuGet.config", "License.md"}:
                    continue
                paths.append(Path(root) / f)
    return paths


def transform(text: str) -> str:
    for old, new in REPLACEMENTS:
        text = text.replace(old, new)
    return text


def main() -> None:
    removed = 0
    for path in ROOT.rglob("CompatibilitySuppressions.xml"):
        if any(p in path.parts for p in SKIP_DIR_NAMES):
            continue
        path.unlink()
        removed += 1
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
    print(f"Removed {removed} CompatibilitySuppressions.xml; updated {changed} files.")


if __name__ == "__main__":
    main()