# 来源与整合记录

- 上游仓库：https://github.com/lejoyke/ZMotionSDK
- 上游作者：Lejoy（GitHub：lejoyke）。
- 整合基线：`dcc2929dff3a7d67a35f3bd65baabe2a6560c28b`。
- 基线提交说明：重构 ProtocolDataMapping，改用组合替代继承。
- 核对日期：2026-11-14；通过 GitHub API 确认当时上游 `main` 与本地基线一致。

## 本地整合内容

1. 移除不可还原的 `WPFProject.Share` 2.5.1 包引用。
2. 加入本地 `DataStatusModel<TAddress>` 和 `DataStatusControl`。
3. 更新 IO 页面命名空间与 ViewModel 引用。
4. 加入中文项目结构与运行指南、平台首页和来源说明。

保留原始提交历史与上游原始 README。SDK 项目的 `Authors`、NuGet 包标识和来源元数据沿用上游，未发布同名 NuGet 包。

## 依赖与许可信息

上游 SDK 项目声明 `PackageLicenseExpression=MIT`；整合基线未包含单独的 LICENSE 文件。本次保留原有元数据与来源说明，没有另行给上游代码或厂家原生 DLL 指定新的许可证。

`zauxdll.dll`、`zmotion.dll` 沿用上游随附文件。MessageToolkit、MaterialDesignThemes、MaterialDesignColors、CommunityToolkit.Mvvm 等通过 NuGet 还原，其许可和作者信息以各包元数据为准。

## 验证

```powershell
dotnet build .\ZMotionSDK.sln -c Release -p:Platform=x64
```

2026-11-14 本机构建通过：0 错误、150 警告。未连接硬件执行验证，也未将现有调试程序改为离线仿真后端。
