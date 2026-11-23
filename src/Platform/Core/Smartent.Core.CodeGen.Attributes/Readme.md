# Smartent.Core.CodeGen.Attributes | CodeGen 特性

> **状态 | Status**：已迁入 src（M2）  
> **路径 | Path**：`src/Platform/Core/Smartent.Core.CodeGen.Attributes`

---

## 摘要 | Summary

**中文**：供 Roslyn 源生成器消费的标注类型，例如 `LibManVersionsAttribute`（LibMan 资源版本）、`ConstantFromJsonAttribute`（从 JSON 生成常量）。

**English**: Attributes consumed by Smartent CodeGen source generators—LibMan resource versions, JSON-backed constants.

---

## 主要类型 | Types

- `LibManVersionsAttribute` — 与 `libman.json` 联动，由 `Smartent.Core.CodeGen.SourceGenerators` 生成版本常量。
- `ConstantFromJsonAttribute` — 从 `AdditionalFiles` 中的 JSON 生成只读常量。

---

## 引用 | References

```xml
<ProjectReference Include="..\..\..\..\src\Platform\Core\Smartent.Core.CodeGen.Attributes\Smartent.Core.CodeGen.Attributes.csproj"
                  OutputItemType="Analyzer"
                  ReferenceOutputAssembly="true" />
```

须与 `Smartent.Core.CodeGen.SourceGenerators` 配套使用（见相邻目录 Readme）。

---

## 验证 | Verification

```powershell
dotnet build src/Platform/Core/Smartent.Core.CodeGen.Attributes/Smartent.Core.CodeGen.Attributes.csproj
```