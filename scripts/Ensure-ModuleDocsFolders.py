#!/usr/bin/env python3
"""Delegates to Ensure-ProjectDocsFolders.py (all non-test projects under src/)."""

import subprocess
import sys
from pathlib import Path

if __name__ == "__main__":
    script = Path(__file__).with_name("Ensure-ProjectDocsFolders.py")
    raise SystemExit(subprocess.call([sys.executable, str(script)]))