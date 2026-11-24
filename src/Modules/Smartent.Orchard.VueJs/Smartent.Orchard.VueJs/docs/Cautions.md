# Pitfalls & cautions

> Parent: [docs/README.md](README.md)

- Requires Node/pnpm for asset build before `dotnet build` when scripts change.
- CSP may block inline Vue hydration; align with `Smartent.Orchard.Platform` CSP module.
