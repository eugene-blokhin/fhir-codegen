// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR2.Serialization;

namespace fhirCsR2.Models
{
  /// <summary>
  /// Record details about the anatomical location of a specimen or body part.  This resource may be used when a coded concept does not provide the necessary detail needed for the use case.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<BodySite>))]
  public class BodySite : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "BodySite";
    /// <summary>
    /// Named anatomical location - ideally coded where possible.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// Description of anatomical location.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// Identifier for this instance of the anatomical location.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Image or images used to identify a location.
    /// </summary>
    public List<Attachment> Image { get; set; }
    /// <summary>
    /// Modifier to refine the anatomical location.  These include modifiers for laterality, relative location, directionality, number, and plane.
    /// </summary>
    public List<CodeableConcept> Modifier { get; set; }
    /// <summary>
    /// The person to which the body site belongs.
    /// </summary>
    public Reference Patient { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((fhirCsR2.Models.DomainResource)this).SerializeJson(writer, options, false);

      if (Patient != null)
      {
        writer.WritePropertyName("patient");
        Patient.SerializeJson(writer, options);
      }

      if ((Identifier != null) && (Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();

        foreach (Identifier valIdentifier in Identifier)
        {
          valIdentifier.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
      }

      if ((Modifier != null) && (Modifier.Count != 0))
      {
        writer.WritePropertyName("modifier");
        writer.WriteStartArray();

        foreach (CodeableConcept valModifier in Modifier)
        {
          valModifier.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Description))
      {
        writer.WriteString("description", (string)Description!);
      }

      if (_Description != null)
      {
        writer.WritePropertyName("_description");
        _Description.SerializeJson(writer, options);
      }

      if ((Image != null) && (Image.Count != 0))
      {
        writer.WritePropertyName("image");
        writer.WriteStartArray();

        foreach (Attachment valImage in Image)
        {
          valImage.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          Code = new fhirCsR2.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new fhirCsR2.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.Identifier objIdentifier = new fhirCsR2.Models.Identifier();
            objIdentifier.DeserializeJson(ref reader, options);
            Identifier.Add(objIdentifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Identifier.Count == 0)
          {
            Identifier = null;
          }

          break;

        case "image":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Image = new List<Attachment>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.Attachment objImage = new fhirCsR2.Models.Attachment();
            objImage.DeserializeJson(ref reader, options);
            Image.Add(objImage);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Image.Count == 0)
          {
            Image = null;
          }

          break;

        case "modifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Modifier = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.CodeableConcept objModifier = new fhirCsR2.Models.CodeableConcept();
            objModifier.DeserializeJson(ref reader, options);
            Modifier.Add(objModifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Modifier.Count == 0)
          {
            Modifier = null;
          }

          break;

        case "patient":
          Patient = new fhirCsR2.Models.Reference();
          Patient.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR2.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
}
