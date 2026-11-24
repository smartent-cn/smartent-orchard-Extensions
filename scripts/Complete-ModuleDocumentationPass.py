#!/usr/bin/env python3
"""AuditTrail → Walkthroughs: thicken module readmes and sync docs/ for module csproj dirs."""

from __future__ import annotations

import subprocess
import sys
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
MODULES = ROOT / "src" / "Modules"

ORDER = [
    "Smartent.Orchard.AuditTrail",
    "Smartent.Orchard.ChartJs",
    "Smartent.Orchard.ContentEditors",
    "Smartent.Orchard.DataTables",
    "Smartent.Orchard.EmailClient",
    "Smartent.Orchard.Extensions.Cms",
    "Smartent.Orchard.Hosting.ApplicationInsights",
    "Smartent.Orchard.Hosting.BuildVersion",
    "Smartent.Orchard.Hosting.Tenants",
    "Smartent.Orchard.JsonEditor",
    "Smartent.Orchard.LoginAsAnybody",
    "Smartent.Orchard.Marketing",
    "Smartent.Orchard.Privacy",
    "Smartent.Orchard.TrainingDemo",
    "Smartent.Orchard.UIKit",
    "Smartent.Orchard.VueJs",
    "Smartent.Orchard.Walkthroughs",
]


def run_script(name: str) -> None:
    path = ROOT / "scripts" / name
    subprocess.check_call([sys.executable, str(path)], cwd=ROOT)


def write_status() -> None:
    out = ROOT / "docs" / "modules" / "MODULE-DOCUMENTATION-STATUS.md"
    lines = [
        "# Module documentation pass (AuditTrail → Walkthroughs)",
        "",
        "Regenerate: `python scripts/Complete-ModuleDocumentationPass.py`",
        "",
        "| # | Module | Family Readme | Main `docs/` |",
        "|---|--------|---------------|--------------|",
    ]
    for i, name in enumerate(ORDER, 1):
        family = MODULES / name
        readme = "yes" if (family / "Readme.md").is_file() else "—"
        main_docs = "—"
        for csproj in family.rglob("*.csproj"):
            if ".Tests" in csproj.stem or ".Samples" in csproj.stem:
                continue
            if (csproj.parent / "docs" / "en" / "README.md").is_file():
                main_docs = f"`{csproj.parent.relative_to(MODULES).as_posix()}/docs/{{en,zh-cn}}/`"
                break
        lines.append(f"| {i} | `{name}` | {readme} | {main_docs} |")
    out.write_text("\n".join(lines) + "\n", encoding="utf-8", newline="\n")


def main() -> None:
    run_script("Thicken-ModuleReadmes.py")
    run_script("Restructure-ProjectDocsEnZhCn.py")
    write_status()
    print(f"Completed documentation pass for {len(ORDER)} module families.")


if __name__ == "__main__":
    main()