# ricaun.SignTool

[![Visual Studio 2022](https://img.shields.io/badge/Visual%20Studio-2022-blue)](../..)
[![Nuke](https://img.shields.io/badge/Nuke-Build-blue)](https://nuke.build/)
[![License MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Build](../../actions/workflows/Build.yml/badge.svg)](../../actions)

`ricaun.SignTool` is a tool to sign assembly file after build using a file certificate. This package use the [App Certification Kit](https://learn.microsoft.com/en-us/windows/uwp/debug-test-perf/windows-app-certification-kit) as tools with the `signtool.exe` to sign the files.

## Installation

Install the package using the `NuGet` package manager or using `PackageReference`.

```xml
<PackageReference Include="ricaun.SignTool" Version="*">
  <PrivateAssets>all</PrivateAssets>
  <IncludeAssets>runtime; build; native; contentfiles; analyzers</IncludeAssets>
</PackageReference>
```

By default, the output file is sign using the environment variable `SIGN_FILE` and `SIGN_PASSWORD` to sign the file.

## Configuration

### PropertyGroups
Property Name | Default Value | Description
-------------|--------|-------------
`SignToolEnabled`| `true` | Enable / Disable SignTool target task.
`SignToolImportance` | `High` | Log importance to show in the console. (`Low` or `High`)
`SignToolCommandImportance` | `Low` | Log importance from the `SignTool.exe` to show in the console. (`Low` or `High`)
`SignToolAfterTargets`| `CoreBuild` | AfterTargets to run the SignTool target task. (`CoreBuild`, `Build`, etc.)
`SignToolBeforeTargets`| `` | BeforeTargets to run the SignTool target task. (`CoreBuild`, `Build`, etc.)
`SignToolFile`| `$(SIGN_FILE)` | Path to the certificate file (`.pfx`).
`SignToolPassword`| `$(SIGN_PASSWORD)` | Password to the certificate file (`.pfx`).
`SignToolTimestampUrl`| `http://timestamp.digicert.com` | URL to the timestamp server.
`SignToolTimestampDigest`| `sha256` | Digest algorithm to use for the timestamp server. (`sha1`, `sha256`, `sha384`, `sha512`)

```xml
<PropertyGroup>
  <SignToolEnabled>true</SignToolEnabled>
  <SignToolImportance>High</SignToolImportance>
  <SignToolCommandImportance>Low</SignToolCommandImportance>
  <SignToolAfterTargets>CoreBuild</SignToolAfterTargets>
  <SignToolBeforeTargets></SignToolBeforeTargets>
  <SignToolFile>$(SIGN_FILE)</SignToolFile>
  <SignToolPassword>$(SIGN_PASSWORD)</SignToolPassword>
  <SignToolTimestampUrl>http://timestamp.digicert.com</SignToolTimestampUrl>
  <SignToolTimestampDigest>sha256</SignToolTimestampDigest>
</PropertyGroup>
```

## Release

* [Latest release](../../releases/latest)

## License

This project is [licensed](LICENSE) under the [MIT License](https://en.wikipedia.org/wiki/MIT_License).

---

Do you like this project? Please [star this project on GitHub](../../stargazers)!