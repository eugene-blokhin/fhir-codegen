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
  /// Link to a resource that concerns the same actual person.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<PersonLink>))]
  public class PersonLink : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Level of assurance that this link is actually associated with the target resource.
    /// </summary>
    public string Assurance { get; set; }
    /// <summary>
    /// Extension container element for Assurance
    /// </summary>
    public Element _Assurance { get; set; }
    /// <summary>
    /// The resource to which this actual person is associated.
    /// </summary>
    public Reference Target { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR2.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Target != null)
      {
        writer.WritePropertyName("target");
        Target.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Assurance))
      {
        writer.WriteString("assurance", (string)Assurance!);
      }

      if (_Assurance != null)
      {
        writer.WritePropertyName("_assurance");
        _Assurance.SerializeJson(writer, options);
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
        case "assurance":
          Assurance = reader.GetString();
          break;

        case "_assurance":
          _Assurance = new fhirCsR2.Models.Element();
          _Assurance.DeserializeJson(ref reader, options);
          break;

        case "target":
          Target = new fhirCsR2.Models.Reference();
          Target.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR2.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Code Values for the Person.link.assurance field
  /// </summary>
  public static class PersonLinkAssuranceCodes {
    public const string LEVEL1 = "level1";
    public const string LEVEL2 = "level2";
    public const string LEVEL3 = "level3";
    public const string LEVEL4 = "level4";
    public static HashSet<string> Values = new HashSet<string>() {
      "level1",
      "level2",
      "level3",
      "level4",
    };
  }
  /// <summary>
  /// Demographics and administrative information about a person independent of a specific health-related context.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<Person>))]
  public class Person : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Person";
    /// <summary>
    /// Need to be able to mark a person record as not to be used because it was created in error.
    /// </summary>
    public bool? Active { get; set; }
    /// <summary>
    /// Extension container element for Active
    /// </summary>
    public Element _Active { get; set; }
    /// <summary>
    /// May need to keep track of person's addresses for contacting, billing or reporting requirements and also to help with identification.
    /// </summary>
    public List<Address> Address { get; set; }
    /// <summary>
    /// Age of person drives many clinical processes, and is often used in performing identification of the person. Times are not included so as to not confuse things with potential timezone issues.
    /// </summary>
    public string BirthDate { get; set; }
    /// <summary>
    /// Extension container element for BirthDate
    /// </summary>
    public Element _BirthDate { get; set; }
    /// <summary>
    /// Needed for identification of the person, in combination with (at least) name and birth date. Gender of person drives many clinical processes.
    /// </summary>
    public string Gender { get; set; }
    /// <summary>
    /// Extension container element for Gender
    /// </summary>
    public Element _Gender { get; set; }
    /// <summary>
    /// People are known by a variety of ids. Some institutions maintain several, and most collect identifiers for exchange with other organizations concerning the person. Examples are national person identifier and local identifier.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Link to a resource that concerns the same actual person.
    /// </summary>
    public List<PersonLink> Link { get; set; }
    /// <summary>
    /// Need to know who recognizes this person record, manages and updates it.
    /// </summary>
    public Reference ManagingOrganization { get; set; }
    /// <summary>
    /// Need to be able to track the person by multiple names. Examples are your official name and a partner name.
    /// </summary>
    public List<HumanName> Name { get; set; }
    /// <summary>
    /// An image that can be displayed as a thumbnail of the person to enhance the identification of the individual.
    /// </summary>
    public Attachment Photo { get; set; }
    /// <summary>
    /// People have (primary) ways to contact them in some way such as phone, email.
    /// </summary>
    public List<ContactPoint> Telecom { get; set; }
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

      if ((Name != null) && (Name.Count != 0))
      {
        writer.WritePropertyName("name");
        writer.WriteStartArray();

        foreach (HumanName valName in Name)
        {
          valName.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Telecom != null) && (Telecom.Count != 0))
      {
        writer.WritePropertyName("telecom");
        writer.WriteStartArray();

        foreach (ContactPoint valTelecom in Telecom)
        {
          valTelecom.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Gender))
      {
        writer.WriteString("gender", (string)Gender!);
      }

      if (_Gender != null)
      {
        writer.WritePropertyName("_gender");
        _Gender.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(BirthDate))
      {
        writer.WriteString("birthDate", (string)BirthDate!);
      }

      if (_BirthDate != null)
      {
        writer.WritePropertyName("_birthDate");
        _BirthDate.SerializeJson(writer, options);
      }

      if ((Address != null) && (Address.Count != 0))
      {
        writer.WritePropertyName("address");
        writer.WriteStartArray();

        foreach (Address valAddress in Address)
        {
          valAddress.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Photo != null)
      {
        writer.WritePropertyName("photo");
        Photo.SerializeJson(writer, options);
      }

      if (ManagingOrganization != null)
      {
        writer.WritePropertyName("managingOrganization");
        ManagingOrganization.SerializeJson(writer, options);
      }

      if (Active != null)
      {
        writer.WriteBoolean("active", (bool)Active!);
      }

      if (_Active != null)
      {
        writer.WritePropertyName("_active");
        _Active.SerializeJson(writer, options);
      }

      if ((Link != null) && (Link.Count != 0))
      {
        writer.WritePropertyName("link");
        writer.WriteStartArray();

        foreach (PersonLink valLink in Link)
        {
          valLink.SerializeJson(writer, options, true);
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
        case "active":
          Active = reader.GetBoolean();
          break;

        case "_active":
          _Active = new fhirCsR2.Models.Element();
          _Active.DeserializeJson(ref reader, options);
          break;

        case "address":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Address = new List<Address>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.Address objAddress = new fhirCsR2.Models.Address();
            objAddress.DeserializeJson(ref reader, options);
            Address.Add(objAddress);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Address.Count == 0)
          {
            Address = null;
          }

          break;

        case "birthDate":
          BirthDate = reader.GetString();
          break;

        case "_birthDate":
          _BirthDate = new fhirCsR2.Models.Element();
          _BirthDate.DeserializeJson(ref reader, options);
          break;

        case "gender":
          Gender = reader.GetString();
          break;

        case "_gender":
          _Gender = new fhirCsR2.Models.Element();
          _Gender.DeserializeJson(ref reader, options);
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

        case "link":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Link = new List<PersonLink>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.PersonLink objLink = new fhirCsR2.Models.PersonLink();
            objLink.DeserializeJson(ref reader, options);
            Link.Add(objLink);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Link.Count == 0)
          {
            Link = null;
          }

          break;

        case "managingOrganization":
          ManagingOrganization = new fhirCsR2.Models.Reference();
          ManagingOrganization.DeserializeJson(ref reader, options);
          break;

        case "name":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Name = new List<HumanName>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.HumanName objName = new fhirCsR2.Models.HumanName();
            objName.DeserializeJson(ref reader, options);
            Name.Add(objName);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Name.Count == 0)
          {
            Name = null;
          }

          break;

        case "photo":
          Photo = new fhirCsR2.Models.Attachment();
          Photo.DeserializeJson(ref reader, options);
          break;

        case "telecom":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Telecom = new List<ContactPoint>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.ContactPoint objTelecom = new fhirCsR2.Models.ContactPoint();
            objTelecom.DeserializeJson(ref reader, options);
            Telecom.Add(objTelecom);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Telecom.Count == 0)
          {
            Telecom = null;
          }

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
  /// Code Values for the Person.gender field
  /// </summary>
  public static class PersonGenderCodes {
    public const string MALE = "male";
    public const string FEMALE = "female";
    public const string OTHER = "other";
    public const string UNKNOWN = "unknown";
    public static HashSet<string> Values = new HashSet<string>() {
      "male",
      "female",
      "other",
      "unknown",
    };
  }
}
