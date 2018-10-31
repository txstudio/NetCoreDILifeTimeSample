# .NET Core 的 Dependency Injection 不同模式下差異的範例

此範例程式碼將示範 Transient、Singleton、Scoped 的差異

使用 .NET Core 的 Dependency Injection 功能需加入下列套件參考

```
dotnet add package Microsoft.Extensions.Options
dotnet add package Microsoft.Extensions.DependencyInjection
```

若要在 Console 應用程式中使用 async/await 方法呼叫時

變更 *.csproj 檔案設定加入 LangVersion 標籤如下

```
<PropertyGroup>
  <OutputType>Exe</OutputType>
  <TargetFramework>netcoreapp2.1</TargetFramework>
  <LangVersion>latest</LangVersion>
</PropertyGroup>
```

### 參考資料

https://blog.johnwu.cc/article/ironman-day04-asp-net-core-dependency-injection.html

https://keestalkstech.com/2018/04/dependency-injection-with-ioptions-in-console-apps-in-net-core-2/
