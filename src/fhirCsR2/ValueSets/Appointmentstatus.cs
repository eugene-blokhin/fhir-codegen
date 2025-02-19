// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using fhirCsR2.Models;

namespace fhirCsR2.ValueSets
{
  /// <summary>
  /// The free/busy status of an appointment.
  /// </summary>
  public static class AppointmentstatusCodes
  {
    /// <summary>
    /// Some of the patients have arrived.
    /// </summary>
    public static readonly Coding Arrived = new Coding
    {
      Code = "arrived",
      Display = "Arrived",
      System = "http://hl7.org/fhir/appointmentstatus"
    };
    /// <summary>
    /// All participant(s) have been considered and the appointment is confirmed to go ahead at the date/times specified.
    /// </summary>
    public static readonly Coding Booked = new Coding
    {
      Code = "booked",
      Display = "Booked",
      System = "http://hl7.org/fhir/appointmentstatus"
    };
    /// <summary>
    /// The appointment has been cancelled.
    /// </summary>
    public static readonly Coding Cancelled = new Coding
    {
      Code = "cancelled",
      Display = "Cancelled",
      System = "http://hl7.org/fhir/appointmentstatus"
    };
    /// <summary>
    /// This appointment has completed and may have resulted in an encounter.
    /// </summary>
    public static readonly Coding Fulfilled = new Coding
    {
      Code = "fulfilled",
      Display = "Fulfilled",
      System = "http://hl7.org/fhir/appointmentstatus"
    };
    /// <summary>
    /// Some or all of the participant(s) have not/did not appear for the appointment (usually the patient).
    /// </summary>
    public static readonly Coding NoShow = new Coding
    {
      Code = "noshow",
      Display = "No Show",
      System = "http://hl7.org/fhir/appointmentstatus"
    };
    /// <summary>
    /// Some or all of the participant(s) have not finalized their acceptance of the appointment request.
    /// </summary>
    public static readonly Coding Pending = new Coding
    {
      Code = "pending",
      Display = "Pending",
      System = "http://hl7.org/fhir/appointmentstatus"
    };
    /// <summary>
    /// None of the participant(s) have finalized their acceptance of the appointment request, and the start/end time may not be set yet.
    /// </summary>
    public static readonly Coding Proposed = new Coding
    {
      Code = "proposed",
      Display = "Proposed",
      System = "http://hl7.org/fhir/appointmentstatus"
    };

    /// <summary>
    /// Literal for code: Arrived
    /// </summary>
    public const string LiteralArrived = "arrived";

    /// <summary>
    /// Literal for code: AppointmentstatusArrived
    /// </summary>
    public const string LiteralAppointmentstatusArrived = "http://hl7.org/fhir/appointmentstatus#arrived";

    /// <summary>
    /// Literal for code: Booked
    /// </summary>
    public const string LiteralBooked = "booked";

    /// <summary>
    /// Literal for code: AppointmentstatusBooked
    /// </summary>
    public const string LiteralAppointmentstatusBooked = "http://hl7.org/fhir/appointmentstatus#booked";

    /// <summary>
    /// Literal for code: Cancelled
    /// </summary>
    public const string LiteralCancelled = "cancelled";

    /// <summary>
    /// Literal for code: AppointmentstatusCancelled
    /// </summary>
    public const string LiteralAppointmentstatusCancelled = "http://hl7.org/fhir/appointmentstatus#cancelled";

    /// <summary>
    /// Literal for code: Fulfilled
    /// </summary>
    public const string LiteralFulfilled = "fulfilled";

    /// <summary>
    /// Literal for code: AppointmentstatusFulfilled
    /// </summary>
    public const string LiteralAppointmentstatusFulfilled = "http://hl7.org/fhir/appointmentstatus#fulfilled";

    /// <summary>
    /// Literal for code: NoShow
    /// </summary>
    public const string LiteralNoShow = "noshow";

    /// <summary>
    /// Literal for code: AppointmentstatusNoShow
    /// </summary>
    public const string LiteralAppointmentstatusNoShow = "http://hl7.org/fhir/appointmentstatus#noshow";

    /// <summary>
    /// Literal for code: Pending
    /// </summary>
    public const string LiteralPending = "pending";

    /// <summary>
    /// Literal for code: AppointmentstatusPending
    /// </summary>
    public const string LiteralAppointmentstatusPending = "http://hl7.org/fhir/appointmentstatus#pending";

    /// <summary>
    /// Literal for code: Proposed
    /// </summary>
    public const string LiteralProposed = "proposed";

    /// <summary>
    /// Literal for code: AppointmentstatusProposed
    /// </summary>
    public const string LiteralAppointmentstatusProposed = "http://hl7.org/fhir/appointmentstatus#proposed";

    /// <summary>
    /// Dictionary for looking up Appointmentstatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "arrived", Arrived }, 
      { "http://hl7.org/fhir/appointmentstatus#arrived", Arrived }, 
      { "booked", Booked }, 
      { "http://hl7.org/fhir/appointmentstatus#booked", Booked }, 
      { "cancelled", Cancelled }, 
      { "http://hl7.org/fhir/appointmentstatus#cancelled", Cancelled }, 
      { "fulfilled", Fulfilled }, 
      { "http://hl7.org/fhir/appointmentstatus#fulfilled", Fulfilled }, 
      { "noshow", NoShow }, 
      { "http://hl7.org/fhir/appointmentstatus#noshow", NoShow }, 
      { "pending", Pending }, 
      { "http://hl7.org/fhir/appointmentstatus#pending", Pending }, 
      { "proposed", Proposed }, 
      { "http://hl7.org/fhir/appointmentstatus#proposed", Proposed }, 
    };
  };
}
