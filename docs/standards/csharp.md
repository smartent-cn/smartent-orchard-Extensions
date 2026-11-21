# C# / .NET 编码规范 | C# / .NET Standards

## 中文

### 基础原则

- 遵循 [.NET 设计准则](https://learn.microsoft.com/dotnet/standard/design-guidelines/) 与 [C# 编码样式](https://learn.microsoft.com/dotnet/csharp/fundamentals/coding-style/coding-conventions)。  
- 与本仓库既有 Lombiq 代码风格一致：**`var` 在类型明显时使用**、`Nullable` 启用、异步方法以 `Async` 结尾。  
- **最小改动**：只改任务相关代码；不顺便重构无关文件。

### 强制中文说明（代码内）

| 元素 | 要求 |
|------|------|
| `public` / `protected` 类型 | XML 文档注释 **`///`**，**中文为主**；关键术语可括号附英文 |
| `public` / `protected` 成员方法、属性 | 同上；说明参数、返回值、异常、副作用 |
| 非显而易见的 `internal` API（供跨程序集使用） | 同上 |
| 复杂私有方法（>15 行或分支多） | 至少一行 **中文** `//` 说明意图 |
| Orchard `Startup`、`Manifest`、Recipe 相关 | 中文注释说明启用条件、依赖模块、权限 |
| 禁止 | 用英文独占公共 API 文档而无中文（`*Tests*` 中断言消息可英文） |

示例：

```csharp
/// <summary>
/// 在指定租户 Shell 内解析并执行操作。多租户场景下用于跨租户读取内容。
/// </summary>
/// <param name="scopeName">租户 scope 名称；单租户时可传默认 scope。</param>
public static Task<T> GetWithShellScopeAsync<T>(...)
```

### 命名

| 类别 | 规则 |
|------|------|
| 命名空间 | `Smartent.*`（新代码）；与文件夹、程序集一致 |
| 接口 | `I` 前缀；实现类语义化命名 |
| 异步 | `*Async`，返回 `Task`/`ValueTask` |
| 扩展方法 | 静态类名 `*Extensions`，方法名动词短语 |

### Orchard Core 模块

- 模块清单 `Manifest.cs` 保留英文 `Name`/`Description` 时，在模块 `Readme.md` 用 **中英文** 写清用途。  
- `Startup` 分 `ConfigureServices` / `Configure` 职责；避免在 `Startup` 内写大段业务逻辑。  
- Content Part/Field：Part 类、Display Driver、Handler 各文件顶部用中文一行说明职责。

### 依赖与引用

- 新代码 **禁止** 引用 `Lombiq.HelpfulLibraries` 元包。  
- 仅引用实际需要的 `Smartent.*` / `OrchardCore.*` 包（见项目 `Readme.md` 引用一节）。  
- 不在库项目中引用仅 Web 宿主才需要的 Orchard 包。

### 错误处理

- 不吞异常；业务可恢复场景用明确返回值或 `Try*` 模式。  
- 用户可见错误通过 Orchard `INotifier` 或验证框架，**不** 仅 `Console.WriteLine`。

### 测试

- 测试方法名英文可接受；**类级** `///` 或文件头注释用中文说明覆盖场景。  
- 新功能优先补与行为相关的测试，不单测 trivial getter。

---

## English (summary)

Follow Microsoft .NET design guidelines and repo Lombiq conventions. **Public/protected APIs require Chinese XML docs** (English may appear in parentheses for terms). Smartent namespaces for new code. No Lombiq meta-packages. Minimal diff scope. Orchard modules: document Manifest/Startup in bilingual project README.