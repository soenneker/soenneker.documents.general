using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Documents.General.Abstract;

namespace Soenneker.Documents.General;

/// <inheritdoc cref="IGeneralDocument"/>
public abstract class GeneralDocument : Document.Document, IGeneralDocument
{
    [JsonPropertyName("entityType")]
    [JsonProperty("entityType")]
    public abstract string EntityType { get; set; }
}