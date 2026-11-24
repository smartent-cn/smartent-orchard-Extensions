# Pitfalls & cautions

> Parent: [docs/README.md](README.md)

- **Orchard**: Aligns with repository `OrchardCoreVersion` / central package management.
- **Extension points**: MSBuild targets and Sdk hooks in `build/*.targets`.
- **Customization**: Prefer configuration keys under `Smartent_*` / `Smartent_Orchard_*`; this demo repo does not read legacy `Lombiq_*` sections.
