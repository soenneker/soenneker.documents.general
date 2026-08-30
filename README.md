[![](https://img.shields.io/nuget/v/soenneker.documents.general.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.documents.general/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.documents.general/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.documents.general/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.documents.general.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.documents.general/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.documents.general/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.documents.general/actions/workflows/codeql.yml)

# Soenneker.Documents.General

Provides a semantic base type and marker interface for general-purpose typed documents.

## Installation

```bash
dotnet add package Soenneker.Documents.General
```

## Usage

```csharp
using Soenneker.Documents.General;

public sealed class SettingDocument : GeneralDocument
{
    public override string EntityType { get; set; } = "setting";

    public string Key { get; set; } = null!;
    public string Value { get; set; } = null!;
}

var setting = new SettingDocument
{
    DocumentId = "theme",
    PartitionKey = "tenant-7",
    CreatedAt = DateTimeOffset.UtcNow,
    Key = "theme",
    Value = "dark"
};
```

`GeneralDocument` inherits the identity and timestamp fields from `Document` and the required `EntityType` discriminator from `TypedDocument`. `EntityType` serializes as `entityType` with both System.Text.Json and Newtonsoft.Json.

The package adds no persistence, validation, discriminator enforcement, or serialization converter. Derived types must implement `EntityType`, initialize required values, and keep the discriminator stable if readers use it to select a concrete type.

`IGeneralDocument` adds no members beyond `ITypedDocument`; use it when registration or persistence code needs to identify this general-document family separately from other typed documents.
