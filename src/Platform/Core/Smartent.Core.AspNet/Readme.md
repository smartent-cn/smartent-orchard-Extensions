# Smartent.Core.AspNet | Smartent Core AspNet

> **状态 | Status**：已迁入 `src/`（M2）。
> **è·¯å¾ | Path**ï¼`src/Platform/Core/Smartent.Core.AspNet`

---

## æè¦ | Summary

**ä¸­æ**ï¼é¢å?ASP.NET Core çæ©å±åºï¼å«åå®¹å®å¨ç­ç¥ï¼CSPï¼ãMvc ç»å®ä¸ç­éå¨ãå»¶è¿ä»»å¡ä¸­é´ä»¶ãæ¬å°åä¸?HTTP æ©å±ï¼ä¾èµ?`Smartent.Core.Primitives`ã?

**English**: ASP.NET Core helpersâCSP providers, MVC utilities, deferred-task middleware, localization and HTTP extensions; depends on `Smartent.Core.Primitives`.

---

## åè½è¯´æ | Features

### ä¸­æ

- **Security**ï¼`ContentSecurityPolicyDirectives`ãå¤ç§?`IContentSecurityPolicyProvider`ã`ConfigureSecurityDefaults`ï¼è§ `Docs/Security.md`ï¼ã?
- **Mvc**ï¼`JsonModelBinder`ã`DevelopmentOnlyAttribute`ã`FrontendException` éå¥ï¼è§ `Docs/Mvc.md`ã`Docs/Exceptions.md`ï¼ã?
- **Middlewares**ï¼`DeferredTaskMiddleware`ï¼è§ `Docs/Middlewares.md`ï¼ã?
- **Extensions / Localization**ï¼HTTPãéç½®ãCookieãForwardedHeaders ç­ï¼è§?`Docs/`ï¼ã?
- **ä¸å®ç?*ï¼Orchard æ¨¡åæ¸åãYesSqlãå¤ç§æ· Shellï¼å¨ `Smartent.Orchard.Platform.*`ï¼ã?

### English

CSP, MVC, middleware, extensionsâsee `Docs/`. No Orchard CMS features.

---

## å¼ç¨æ¹å¼ | References

### Monorepoï¼å¼å?| Developmentï¼?

```xml
<ProjectReference Include="..\..\..\..\src\Platform\Core\Smartent.Core.AspNet\Smartent.Core.AspNet.csproj" />
```

éå¸¸åæ¶éè¦?`Smartent.Core.Primitives`ã?

### NuGetï¼åå¸å | When publishedï¼?

```xml
<PackageReference Include="Smartent.Core.AspNet" Version="1.0.0" />
```

---

## ä½¿ç¨æ¹å¼ | Usage

### ä¸­æ

1. å¼ç¨ç¨åºéåï¼å¨ `Startup` / `Program` ä¸­è°ç?`ConfigureSecurityDefaults()` æææ¡£ä¸­çæ©å±æ¹æ³æ³¨å?CSPã?
2. Orchard æ¨¡åä¸­æ³¨åèªå®ä¹ `IContentSecurityPolicyProvider` æ¶ï¼å¼ç¨ `Smartent.Core.AspNet.Security` å½åç©ºé´ã?
3. Web åºæ¯ä¸ç¨æ·å¯è§éè¯¯ä¼åä½¿ç?`FrontendException` èé `UserReadableException`ã?

### English

Register security defaults and CSP providers per `Docs/Security.md`; use `FrontendException` for web UX errors.

---

## ä¾èµè¯´æ | Dependencies

| ä¾èµ | ç±»å | ç¨é?|
|------|------|------|
| `Microsoft.AspNetCore.App` | FrameworkReference | ASP.NET Core è¿è¡æ?|
| `Smartent.Core.Primitives` | Project | åºç¡å·¥å·ä¸å¼å¸¸ç±»å?|

### åç«¯

æ¬åºå®ä¹ **CSP æä»¤** ä¸æä¾ç¨åºï¼ä¸èªå¸?npm åï¼ä½¿ç¨æ¹çåç«¯èµæºé¡»å¨åèªæ¨¡å Readme ä¸­è¯´æï¼è§?`docs/standards/frontend-dependencies.md`ï¼ã?

---

## åçº§ä¸æ©å±?| Upgrade & Extension

### ä¸­æ

- æ°å¢ CSP Providerï¼å®ç?`IContentSecurityPolicyProvider` å¹¶å¨ DI ä¸­æ³¨åã?
- ä¸?Orchard `ResourceManagement` èç¨æ¶ï¼æ³¨æèæ¬ nonce/hash ä¸æ¨¡åå è½½é¡ºåºã?
- è?Lombiq `HelpfulLibraries.AspNetCore` è¿å¥ï¼å½åç©ºé?`Smartent.Core.AspNet.*`ã?

### English

Extend via new CSP providers and documented DI registration patterns.

---

## æµè¯ | Tests

```powershell
dotnet build src/Platform/Core/Smartent.Core.AspNet/Smartent.Core.AspNet.csproj
dotnet build src/Libraries/Lombiq.HelpfulLibraries/Smartent.Orchard.Platform/Smartent.Orchard.Platform.csproj
```

相关单元/集成测试见 `Smartent.Test.Platform` 与依赖模块的测试。

---

## æ¥æºä¸è®¸å?| Provenance & License

- æºèª Lombiq Helpful-Libraries / AspNetCoreï¼MITã? 
- Smartent è¡çé¨å Copyright Â© Smartentã