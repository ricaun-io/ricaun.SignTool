# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [1.0.0] / 2025-05-06
### Features
- SignTool target task to sign assemblies after build using a file certificate.
### Updated
- Update `SignToolTarget` to use `AfterTargets` equal `CoreBuild`.
- Update `SignToolImportance` default to `High`.
- Update `SignToolTarget` to use propriety `SignToolAfterTargets` in the `AfterTargets` with default `CoreBuild`.
- Update `SignToolTarget` to use propriety `SignToolBeforeTargets` in the `BeforeTargets` with default ``.
### Sample
- Add `signfile.pfx` file to sign the assembly, copy from [ricaun.Security.WinTrust](https://github.com/ricaun-io/ricaun.Security.WinTrust/)
### Tests
- Sign with local file certificate.

[vNext]: ../../compare/1.0.0...HEAD
[1.0.0]: ../../compare/1.0.0