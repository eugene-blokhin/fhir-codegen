// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using fhirCsR2.Models;

namespace fhirCsR2.ValueSets
{
  /// <summary>
  /// Availability of the resource
  /// </summary>
  public static class InstanceAvailabilityCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NEARLINE = new Coding
    {
      Code = "NEARLINE",
      System = "http://nema.org/dicom/dicm"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OFFLINE = new Coding
    {
      Code = "OFFLINE",
      System = "http://nema.org/dicom/dicm"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ONLINE = new Coding
    {
      Code = "ONLINE",
      System = "http://nema.org/dicom/dicm"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding UNAVAILABLE = new Coding
    {
      Code = "UNAVAILABLE",
      System = "http://nema.org/dicom/dicm"
    };

    /// <summary>
    /// Literal for code: NEARLINE
    /// </summary>
    public const string LiteralNEARLINE = "NEARLINE";

    /// <summary>
    /// Literal for code: NONENEARLINE
    /// </summary>
    public const string LiteralNONENEARLINE = "http://nema.org/dicom/dicm#NEARLINE";

    /// <summary>
    /// Literal for code: OFFLINE
    /// </summary>
    public const string LiteralOFFLINE = "OFFLINE";

    /// <summary>
    /// Literal for code: NONEOFFLINE
    /// </summary>
    public const string LiteralNONEOFFLINE = "http://nema.org/dicom/dicm#OFFLINE";

    /// <summary>
    /// Literal for code: ONLINE
    /// </summary>
    public const string LiteralONLINE = "ONLINE";

    /// <summary>
    /// Literal for code: NONEONLINE
    /// </summary>
    public const string LiteralNONEONLINE = "http://nema.org/dicom/dicm#ONLINE";

    /// <summary>
    /// Literal for code: UNAVAILABLE
    /// </summary>
    public const string LiteralUNAVAILABLE = "UNAVAILABLE";

    /// <summary>
    /// Literal for code: NONEUNAVAILABLE
    /// </summary>
    public const string LiteralNONEUNAVAILABLE = "http://nema.org/dicom/dicm#UNAVAILABLE";

    /// <summary>
    /// Dictionary for looking up InstanceAvailability Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "NEARLINE", NEARLINE }, 
      { "http://nema.org/dicom/dicm#NEARLINE", NEARLINE }, 
      { "OFFLINE", OFFLINE }, 
      { "http://nema.org/dicom/dicm#OFFLINE", OFFLINE }, 
      { "ONLINE", ONLINE }, 
      { "http://nema.org/dicom/dicm#ONLINE", ONLINE }, 
      { "UNAVAILABLE", UNAVAILABLE }, 
      { "http://nema.org/dicom/dicm#UNAVAILABLE", UNAVAILABLE }, 
    };
  };
}
