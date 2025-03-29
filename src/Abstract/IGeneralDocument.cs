using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Documents.Document.Abstract;

namespace Soenneker.Documents.General.Abstract;

/// <summary>
/// A document type for general storage purposes, with an EntityType property
/// </summary>
public interface IGeneralDocument : IDocument
{
    /// <summary>
    /// Does not exist on the entity itself, and only belongs to documents
    /// </summary>
    [JsonPropertyName("entityType")]
    [JsonProperty("entityType")]
    string EntityType { get; set; }
}