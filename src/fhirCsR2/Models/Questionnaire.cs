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
  /// Must register answers to questions.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<QuestionnaireGroupQuestion>))]
  public class QuestionnaireGroupQuestion : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Allows linking of questions (and their answers) to formal terminologies.
    /// </summary>
    public List<Coding> Concept { get; set; }
    /// <summary>
    /// It is useful to have "sub-questions", questions which normally appear when certain answers are given and which collect additional details.
    /// </summary>
    public List<QuestionnaireGroup> Group { get; set; }
    /// <summary>
    /// [[[QuestionnaireResponse]]] does not require omitted groups to be included and may have some groups that repeat, so linkage based on position alone is not sufficient.
    /// </summary>
    public string LinkId { get; set; }
    /// <summary>
    /// Extension container element for LinkId
    /// </summary>
    public Element _LinkId { get; set; }
    /// <summary>
    /// For a "choice" question, identifies one of the permitted answers for the question.
    /// </summary>
    public List<Coding> Option { get; set; }
    /// <summary>
    /// Reference to a value set containing a list of codes representing permitted answers for the question.
    /// </summary>
    public Reference Options { get; set; }
    /// <summary>
    /// Used for "check all that apply" types of questions or "list your top 3", etc.
    /// </summary>
    public bool? Repeats { get; set; }
    /// <summary>
    /// Extension container element for Repeats
    /// </summary>
    public Element _Repeats { get; set; }
    /// <summary>
    /// If true, indicates that the question must be answered and have required groups within it also present.  If false, the question and any contained groups may be skipped when answering the questionnaire.
    /// </summary>
    public bool? Required { get; set; }
    /// <summary>
    /// Extension container element for Required
    /// </summary>
    public Element _Required { get; set; }
    /// <summary>
    /// When including text for the questionnaire, each question may contain its actual question display text.
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// Extension container element for Text
    /// </summary>
    public Element _Text { get; set; }
    /// <summary>
    /// Defines the format in which the user is to be prompted for the answer.
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Extension container element for Type
    /// </summary>
    public Element _Type { get; set; }
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

      if (!string.IsNullOrEmpty(LinkId))
      {
        writer.WriteString("linkId", (string)LinkId!);
      }

      if (_LinkId != null)
      {
        writer.WritePropertyName("_linkId");
        _LinkId.SerializeJson(writer, options);
      }

      if ((Concept != null) && (Concept.Count != 0))
      {
        writer.WritePropertyName("concept");
        writer.WriteStartArray();

        foreach (Coding valConcept in Concept)
        {
          valConcept.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Text))
      {
        writer.WriteString("text", (string)Text!);
      }

      if (_Text != null)
      {
        writer.WritePropertyName("_text");
        _Text.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Type))
      {
        writer.WriteString("type", (string)Type!);
      }

      if (_Type != null)
      {
        writer.WritePropertyName("_type");
        _Type.SerializeJson(writer, options);
      }

      if (Required != null)
      {
        writer.WriteBoolean("required", (bool)Required!);
      }

      if (_Required != null)
      {
        writer.WritePropertyName("_required");
        _Required.SerializeJson(writer, options);
      }

      if (Repeats != null)
      {
        writer.WriteBoolean("repeats", (bool)Repeats!);
      }

      if (_Repeats != null)
      {
        writer.WritePropertyName("_repeats");
        _Repeats.SerializeJson(writer, options);
      }

      if (Options != null)
      {
        writer.WritePropertyName("options");
        Options.SerializeJson(writer, options);
      }

      if ((Option != null) && (Option.Count != 0))
      {
        writer.WritePropertyName("option");
        writer.WriteStartArray();

        foreach (Coding valOption in Option)
        {
          valOption.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Group != null) && (Group.Count != 0))
      {
        writer.WritePropertyName("group");
        writer.WriteStartArray();

        foreach (QuestionnaireGroup valGroup in Group)
        {
          valGroup.SerializeJson(writer, options, true);
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
        case "concept":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Concept = new List<Coding>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.Coding objConcept = new fhirCsR2.Models.Coding();
            objConcept.DeserializeJson(ref reader, options);
            Concept.Add(objConcept);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Concept.Count == 0)
          {
            Concept = null;
          }

          break;

        case "group":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Group = new List<QuestionnaireGroup>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.QuestionnaireGroup objGroup = new fhirCsR2.Models.QuestionnaireGroup();
            objGroup.DeserializeJson(ref reader, options);
            Group.Add(objGroup);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Group.Count == 0)
          {
            Group = null;
          }

          break;

        case "linkId":
          LinkId = reader.GetString();
          break;

        case "_linkId":
          _LinkId = new fhirCsR2.Models.Element();
          _LinkId.DeserializeJson(ref reader, options);
          break;

        case "option":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Option = new List<Coding>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.Coding objOption = new fhirCsR2.Models.Coding();
            objOption.DeserializeJson(ref reader, options);
            Option.Add(objOption);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Option.Count == 0)
          {
            Option = null;
          }

          break;

        case "options":
          Options = new fhirCsR2.Models.Reference();
          Options.DeserializeJson(ref reader, options);
          break;

        case "repeats":
          Repeats = reader.GetBoolean();
          break;

        case "_repeats":
          _Repeats = new fhirCsR2.Models.Element();
          _Repeats.DeserializeJson(ref reader, options);
          break;

        case "required":
          Required = reader.GetBoolean();
          break;

        case "_required":
          _Required = new fhirCsR2.Models.Element();
          _Required.DeserializeJson(ref reader, options);
          break;

        case "text":
          Text = reader.GetString();
          break;

        case "_text":
          _Text = new fhirCsR2.Models.Element();
          _Text.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = reader.GetString();
          break;

        case "_type":
          _Type = new fhirCsR2.Models.Element();
          _Type.DeserializeJson(ref reader, options);
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
  /// Code Values for the Questionnaire.group.question.type field
  /// </summary>
  public static class QuestionnaireGroupQuestionTypeCodes {
    public const string BOOLEAN = "boolean";
    public const string VAL_DECIMAL = "decimal";
    public const string INTEGER = "integer";
    public const string DATE = "date";
    public const string DATETIME = "dateTime";
    public const string INSTANT = "instant";
    public const string TIME = "time";
    public const string VAL_STRING = "string";
    public const string TEXT = "text";
    public const string URL = "url";
    public const string CHOICE = "choice";
    public const string OPEN_CHOICE = "open-choice";
    public const string ATTACHMENT = "attachment";
    public const string REFERENCE = "reference";
    public const string QUANTITY = "quantity";
    public static HashSet<string> Values = new HashSet<string>() {
      "boolean",
      "decimal",
      "integer",
      "date",
      "dateTime",
      "instant",
      "time",
      "string",
      "text",
      "url",
      "choice",
      "open-choice",
      "attachment",
      "reference",
      "quantity",
    };
  }
  /// <summary>
  /// Need to be able to logically group answers to grouped questions.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<QuestionnaireGroup>))]
  public class QuestionnaireGroup : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Allows linking of groups of questions (and complete Questionnaire resources) to formal terminologies.
    /// </summary>
    public List<Coding> Concept { get; set; }
    /// <summary>
    /// Reports can consist of complex nested groups.
    /// </summary>
    public List<QuestionnaireGroup> Group { get; set; }
    /// <summary>
    /// [[[QuestionnaireResponse]]] does not require omitted groups to be included and may have some groups that repeat, so linkage based on position alone is not sufficient.
    /// </summary>
    public string LinkId { get; set; }
    /// <summary>
    /// Extension container element for LinkId
    /// </summary>
    public Element _LinkId { get; set; }
    /// <summary>
    /// Must register answers to questions.
    /// </summary>
    public List<QuestionnaireGroupQuestion> Question { get; set; }
    /// <summary>
    /// Groups may be used to create set of (related) questions that can be repeated to give multiple answers to such a set.
    /// </summary>
    public bool? Repeats { get; set; }
    /// <summary>
    /// Extension container element for Repeats
    /// </summary>
    public Element _Repeats { get; set; }
    /// <summary>
    /// If true, indicates that the group must be present and have required questions within it answered.  If false, the group may be skipped when answering the questionnaire.
    /// </summary>
    public bool? Required { get; set; }
    /// <summary>
    /// Extension container element for Required
    /// </summary>
    public Element _Required { get; set; }
    /// <summary>
    /// When including text for the questionnaire, each section may contain additional explanations are background text.
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// Extension container element for Text
    /// </summary>
    public Element _Text { get; set; }
    /// <summary>
    /// When including text for the questionnaire with the answers, sections may have a section header.
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// Extension container element for Title
    /// </summary>
    public Element _Title { get; set; }
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

      if (!string.IsNullOrEmpty(LinkId))
      {
        writer.WriteString("linkId", (string)LinkId!);
      }

      if (_LinkId != null)
      {
        writer.WritePropertyName("_linkId");
        _LinkId.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Title))
      {
        writer.WriteString("title", (string)Title!);
      }

      if (_Title != null)
      {
        writer.WritePropertyName("_title");
        _Title.SerializeJson(writer, options);
      }

      if ((Concept != null) && (Concept.Count != 0))
      {
        writer.WritePropertyName("concept");
        writer.WriteStartArray();

        foreach (Coding valConcept in Concept)
        {
          valConcept.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Text))
      {
        writer.WriteString("text", (string)Text!);
      }

      if (_Text != null)
      {
        writer.WritePropertyName("_text");
        _Text.SerializeJson(writer, options);
      }

      if (Required != null)
      {
        writer.WriteBoolean("required", (bool)Required!);
      }

      if (_Required != null)
      {
        writer.WritePropertyName("_required");
        _Required.SerializeJson(writer, options);
      }

      if (Repeats != null)
      {
        writer.WriteBoolean("repeats", (bool)Repeats!);
      }

      if (_Repeats != null)
      {
        writer.WritePropertyName("_repeats");
        _Repeats.SerializeJson(writer, options);
      }

      if ((Group != null) && (Group.Count != 0))
      {
        writer.WritePropertyName("group");
        writer.WriteStartArray();

        foreach (QuestionnaireGroup valGroup in Group)
        {
          valGroup.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Question != null) && (Question.Count != 0))
      {
        writer.WritePropertyName("question");
        writer.WriteStartArray();

        foreach (QuestionnaireGroupQuestion valQuestion in Question)
        {
          valQuestion.SerializeJson(writer, options, true);
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
        case "concept":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Concept = new List<Coding>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.Coding objConcept = new fhirCsR2.Models.Coding();
            objConcept.DeserializeJson(ref reader, options);
            Concept.Add(objConcept);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Concept.Count == 0)
          {
            Concept = null;
          }

          break;

        case "group":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Group = new List<QuestionnaireGroup>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.QuestionnaireGroup objGroup = new fhirCsR2.Models.QuestionnaireGroup();
            objGroup.DeserializeJson(ref reader, options);
            Group.Add(objGroup);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Group.Count == 0)
          {
            Group = null;
          }

          break;

        case "linkId":
          LinkId = reader.GetString();
          break;

        case "_linkId":
          _LinkId = new fhirCsR2.Models.Element();
          _LinkId.DeserializeJson(ref reader, options);
          break;

        case "question":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Question = new List<QuestionnaireGroupQuestion>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.QuestionnaireGroupQuestion objQuestion = new fhirCsR2.Models.QuestionnaireGroupQuestion();
            objQuestion.DeserializeJson(ref reader, options);
            Question.Add(objQuestion);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Question.Count == 0)
          {
            Question = null;
          }

          break;

        case "repeats":
          Repeats = reader.GetBoolean();
          break;

        case "_repeats":
          _Repeats = new fhirCsR2.Models.Element();
          _Repeats.DeserializeJson(ref reader, options);
          break;

        case "required":
          Required = reader.GetBoolean();
          break;

        case "_required":
          _Required = new fhirCsR2.Models.Element();
          _Required.DeserializeJson(ref reader, options);
          break;

        case "text":
          Text = reader.GetString();
          break;

        case "_text":
          _Text = new fhirCsR2.Models.Element();
          _Text.DeserializeJson(ref reader, options);
          break;

        case "title":
          Title = reader.GetString();
          break;

        case "_title":
          _Title = new fhirCsR2.Models.Element();
          _Title.DeserializeJson(ref reader, options);
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
  /// A structured set of questions intended to guide the collection of answers. The questions are ordered and grouped into coherent subsets, corresponding to the structure of the grouping of the underlying questions.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<Questionnaire>))]
  public class Questionnaire : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Questionnaire";
    /// <summary>
    /// The date that this questionnaire was last changed.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// Need to be able to logically group answers to grouped questions.
    /// </summary>
    public QuestionnaireGroup Group { get; set; }
    /// <summary>
    /// Need to allow connection to a wider workflow.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Conveys responsibility for the questions and their organization and also helps evaluate the questionnaire's "authority".
    /// </summary>
    public string Publisher { get; set; }
    /// <summary>
    /// Extension container element for Publisher
    /// </summary>
    public Element _Publisher { get; set; }
    /// <summary>
    /// The lifecycle status of the questionnaire as a whole.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// Identifies the types of subjects that can be the subject of the questionnaire.
    /// </summary>
    public List<string> SubjectType { get; set; }
    /// <summary>
    /// Extension container element for SubjectType
    /// </summary>
    public List<Element> _SubjectType { get; set; }
    /// <summary>
    /// Contact details to assist a user in finding and communicating with the publisher.
    /// </summary>
    public List<ContactPoint> Telecom { get; set; }
    /// <summary>
    /// In some cases, separate resource instances might be created for each version (if an older version can be maintained once a new version exists).
    /// </summary>
    public string Version { get; set; }
    /// <summary>
    /// Extension container element for Version
    /// </summary>
    public Element _Version { get; set; }
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

      if (!string.IsNullOrEmpty(Version))
      {
        writer.WriteString("version", (string)Version!);
      }

      if (_Version != null)
      {
        writer.WritePropertyName("_version");
        _Version.SerializeJson(writer, options);
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

      if (!string.IsNullOrEmpty(Date))
      {
        writer.WriteString("date", (string)Date!);
      }

      if (_Date != null)
      {
        writer.WritePropertyName("_date");
        _Date.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Publisher))
      {
        writer.WriteString("publisher", (string)Publisher!);
      }

      if (_Publisher != null)
      {
        writer.WritePropertyName("_publisher");
        _Publisher.SerializeJson(writer, options);
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

      if ((SubjectType != null) && (SubjectType.Count != 0))
      {
        writer.WritePropertyName("subjectType");
        writer.WriteStartArray();

        foreach (string valSubjectType in SubjectType)
        {
          writer.WriteStringValue(valSubjectType);
        }

        writer.WriteEndArray();
      }

      if ((_SubjectType != null) && (_SubjectType.Count != 0))
      {
        writer.WritePropertyName("_subjectType");
        writer.WriteStartArray();

        foreach (Element val_SubjectType in _SubjectType)
        {
          val_SubjectType.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Group != null)
      {
        writer.WritePropertyName("group");
        Group.SerializeJson(writer, options);
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
        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new fhirCsR2.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "group":
          Group = new fhirCsR2.Models.QuestionnaireGroup();
          Group.DeserializeJson(ref reader, options);
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

        case "publisher":
          Publisher = reader.GetString();
          break;

        case "_publisher":
          _Publisher = new fhirCsR2.Models.Element();
          _Publisher.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR2.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "subjectType":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          SubjectType = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            SubjectType.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (SubjectType.Count == 0)
          {
            SubjectType = null;
          }

          break;

        case "_subjectType":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _SubjectType = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.Element obj_SubjectType = new fhirCsR2.Models.Element();
            obj_SubjectType.DeserializeJson(ref reader, options);
            _SubjectType.Add(obj_SubjectType);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_SubjectType.Count == 0)
          {
            _SubjectType = null;
          }

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

        case "version":
          Version = reader.GetString();
          break;

        case "_version":
          _Version = new fhirCsR2.Models.Element();
          _Version.DeserializeJson(ref reader, options);
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
  /// Code Values for the Questionnaire.status field
  /// </summary>
  public static class QuestionnaireStatusCodes {
    public const string DRAFT = "draft";
    public const string PUBLISHED = "published";
    public const string RETIRED = "retired";
    public static HashSet<string> Values = new HashSet<string>() {
      "draft",
      "published",
      "retired",
    };
  }
}
