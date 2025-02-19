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
  /// Record of delivery of what is supplied.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<SupplyDelivery>))]
  public class SupplyDelivery : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "SupplyDelivery";
    /// <summary>
    /// Identification of the facility/location where the Supply was shipped to, as part of the dispense event.
    /// </summary>
    public Reference Destination { get; set; }
    /// <summary>
    /// Identifier assigned by the dispensing facility when the item(s) is dispensed.
    /// </summary>
    public Identifier Identifier { get; set; }
    /// <summary>
    /// A link to a resource representing the person whom the delivered item is for.
    /// </summary>
    public Reference Patient { get; set; }
    /// <summary>
    /// The amount of supply that has been dispensed. Includes unit of measure.
    /// </summary>
    public Quantity Quantity { get; set; }
    /// <summary>
    /// Identifies the person who picked up the Supply.
    /// </summary>
    public List<Reference> Receiver { get; set; }
    /// <summary>
    /// A code specifying the state of the dispense event.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// Identifies the medication, substance or device being dispensed. This is either a link to a resource representing the details of the item or a simple attribute carrying a code that identifies the item from a known list.
    /// </summary>
    public Reference SuppliedItem { get; set; }
    /// <summary>
    /// The individual responsible for dispensing the medication, supplier or device.
    /// </summary>
    public Reference Supplier { get; set; }
    /// <summary>
    /// The time the dispensed item was sent or handed to the patient (or agent).
    /// </summary>
    public string Time { get; set; }
    /// <summary>
    /// Extension container element for Time
    /// </summary>
    public Element _Time { get; set; }
    /// <summary>
    /// Indicates the type of dispensing event that is performed. Examples include: Trial Fill, Completion of Trial, Partial Fill, Emergency Fill, Samples, etc.
    /// </summary>
    public CodeableConcept Type { get; set; }
    /// <summary>
    /// The time the dispense event occurred.
    /// </summary>
    public Period WhenPrepared { get; set; }
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

      if (Identifier != null)
      {
        writer.WritePropertyName("identifier");
        Identifier.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if (Patient != null)
      {
        writer.WritePropertyName("patient");
        Patient.SerializeJson(writer, options);
      }

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (Quantity != null)
      {
        writer.WritePropertyName("quantity");
        Quantity.SerializeJson(writer, options);
      }

      if (SuppliedItem != null)
      {
        writer.WritePropertyName("suppliedItem");
        SuppliedItem.SerializeJson(writer, options);
      }

      if (Supplier != null)
      {
        writer.WritePropertyName("supplier");
        Supplier.SerializeJson(writer, options);
      }

      if (WhenPrepared != null)
      {
        writer.WritePropertyName("whenPrepared");
        WhenPrepared.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Time))
      {
        writer.WriteString("time", (string)Time!);
      }

      if (_Time != null)
      {
        writer.WritePropertyName("_time");
        _Time.SerializeJson(writer, options);
      }

      if (Destination != null)
      {
        writer.WritePropertyName("destination");
        Destination.SerializeJson(writer, options);
      }

      if ((Receiver != null) && (Receiver.Count != 0))
      {
        writer.WritePropertyName("receiver");
        writer.WriteStartArray();

        foreach (Reference valReceiver in Receiver)
        {
          valReceiver.SerializeJson(writer, options, true);
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
        case "destination":
          Destination = new fhirCsR2.Models.Reference();
          Destination.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          Identifier = new fhirCsR2.Models.Identifier();
          Identifier.DeserializeJson(ref reader, options);
          break;

        case "patient":
          Patient = new fhirCsR2.Models.Reference();
          Patient.DeserializeJson(ref reader, options);
          break;

        case "quantity":
          Quantity = new fhirCsR2.Models.Quantity();
          Quantity.DeserializeJson(ref reader, options);
          break;

        case "receiver":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Receiver = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.Reference objReceiver = new fhirCsR2.Models.Reference();
            objReceiver.DeserializeJson(ref reader, options);
            Receiver.Add(objReceiver);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Receiver.Count == 0)
          {
            Receiver = null;
          }

          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR2.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "suppliedItem":
          SuppliedItem = new fhirCsR2.Models.Reference();
          SuppliedItem.DeserializeJson(ref reader, options);
          break;

        case "supplier":
          Supplier = new fhirCsR2.Models.Reference();
          Supplier.DeserializeJson(ref reader, options);
          break;

        case "time":
          Time = reader.GetString();
          break;

        case "_time":
          _Time = new fhirCsR2.Models.Element();
          _Time.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new fhirCsR2.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
          break;

        case "whenPrepared":
          WhenPrepared = new fhirCsR2.Models.Period();
          WhenPrepared.DeserializeJson(ref reader, options);
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
  /// <summary>
  /// Code Values for the SupplyDelivery.status field
  /// </summary>
  public static class SupplyDeliveryStatusCodes {
    public const string IN_PROGRESS = "in-progress";
    public const string COMPLETED = "completed";
    public const string ABANDONED = "abandoned";
    public static HashSet<string> Values = new HashSet<string>() {
      "in-progress",
      "completed",
      "abandoned",
    };
  }
}
