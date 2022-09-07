﻿// <copyright file="ExporterOptions.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

namespace Microsoft.Health.Fhir.SpecManager.Manager;

/// <summary>An exporter options.</summary>
public class ExporterOptions
{
    private readonly HashSet<string> _extensionUrls;
    private readonly HashSet<string> _extensionElementPaths;
    private readonly Dictionary<string, string> _languageOptions;

    /// <summary>Initializes a new instance of the <see cref="ExporterOptions"/> class.</summary>
    /// <param name="languageName">           Name of the language.</param>
    /// <param name="exportList">             List of exports.</param>
    /// <param name="optionalClassesToExport">Language optional class types to export (e.g., Enums).</param>
    /// <param name="extensionSupport">       The extension support.</param>
    /// <param name="extensionUrls">          Manually supported extension URLs that should be added.</param>
    /// <param name="extensionElementPaths">  Manually supported element paths that should have
    ///  extensions.</param>
    /// <param name="languageOptions">        Options for controlling the language.</param>
    /// <param name="fhirServerUrl">          FHIR Server URL to pull a CapabilityStatement (or
    ///  Conformance) from.  Requires application/fhir+json.</param>
    /// <param name="includeExperimental">    A value indicating whether structures marked experimental
    ///  should be included.</param>
    /// <param name="languageInputDir">       The language input dir.</param>
    public ExporterOptions(
        string languageName,
        IEnumerable<string> exportList,
        List<FhirExportClassType> optionalClassesToExport,
        ExtensionSupportLevel extensionSupport,
        IEnumerable<string> extensionUrls,
        IEnumerable<string> extensionElementPaths,
        Dictionary<string, string> languageOptions,
        string fhirServerUrl,
        bool includeExperimental,
        string languageInputDir)
    {
        LanguageName = languageName;
        ExportList = exportList ?? new string[0];
        ExtensionSupport = extensionSupport;

        OptionalClassTypesToExport = optionalClassesToExport ?? new();

        _extensionUrls = new();
        if (extensionUrls != null)
        {
            foreach (string url in extensionUrls)
            {
                if (!_extensionUrls.Contains(url))
                {
                    _extensionUrls.Add(url);
                }
            }
        }

        _extensionElementPaths = new();
        if (extensionElementPaths != null)
        {
            foreach (string path in extensionElementPaths)
            {
                if (!_extensionElementPaths.Contains(path))
                {
                    _extensionElementPaths.Add(path);
                }
            }
        }

        _languageOptions = languageOptions ?? new(StringComparer.InvariantCultureIgnoreCase);

        ServerUrl = fhirServerUrl ?? string.Empty;
        IncludeExperimental = includeExperimental;

        LanguageInputDir = languageInputDir ?? string.Empty;
        if (!string.IsNullOrEmpty(languageInputDir))
        {
            SupportFiles = new Language.LanguageSupportFiles(languageInputDir, languageName);
        }
    }

    /// <summary>Values that represent FHIR export class types.</summary>
    public enum FhirExportClassType
    {
        /// <summary>
        /// Primitive Types (e.g., string, uri).
        /// See http://hl7.org/fhir/datatypes.html#primitive
        /// </summary>
        PrimitiveType,

        /// <summary>
        /// Complex Types (e.g., Address, Coding).
        /// See http://hl7.org/fhir/datatypes.html#complex
        /// </summary>
        ComplexType,

        /// <summary>
        /// Resources (e.g., Patient, Bundle).
        /// See http://hl7.org/fhir/resourcelist.html
        /// </summary>
        Resource,

        /// <summary>
        /// Interactions (e.g., read, create).
        /// See http://hl7.org/fhir/http.html#3.1.0
        /// </summary>
        Interaction,

        /// <summary>
        /// Enumerations (e.g., instances of Codes and Value Sets).
        /// </summary>
        Enum,

        /// <summary>A resource or data type profile.</summary>
        Profile,
    }

    /// <summary>Values that represent extension support requests.</summary>
    public enum ExtensionSupportLevel
    {
        /// <summary>No extensions should be included.</summary>
        None,

        /// <summary>Official (core) extensions should be included.</summary>
        Official,

        /// <summary>An enum constant representing the official non primitive option.</summary>
        OfficialNonPrimitive,

        /// <summary>Every field should have a mockup for extensions.</summary>
        All,

        /// <summary>Non-primitive type fields should have extensions.</summary>
        NonPrimitive,

        /// <summary>Only extensions with a URL in the provided list should be included.</summary>
        ByExtensionUrl,

        /// <summary>Only elements with a path in the provided list should have extensions.</summary>
        ByElementPath,
    }

    /// <summary>Gets the name of the language.</summary>
    /// <value>The name of the language.</value>
    public string LanguageName { get; }

    /// <summary>Gets a list of exports.</summary>
    /// <value>A list of exports.</value>
    public IEnumerable<string> ExportList { get; }

    /// <summary>Gets the optional class types to export.</summary>
    public List<FhirExportClassType> OptionalClassTypesToExport { get; }

    /// <summary>Gets the extension support.</summary>
    /// <value>The extension support.</value>
    public ExtensionSupportLevel ExtensionSupport { get; }

    /// <summary>Gets the extension urls.</summary>
    /// <value>The extension urls.</value>
    public HashSet<string> ExtensionUrls => _extensionUrls;

    /// <summary>Gets the extension element paths.</summary>
    /// <value>The extension element paths.</value>
    public HashSet<string> ExtensionElementPaths => _extensionElementPaths;

    /// <summary>Gets options for controlling the language.</summary>
    public Dictionary<string, string> LanguageOptions => _languageOptions;

    /// <summary>Gets URL of the FHIR server (if specified).</summary>
    public string ServerUrl { get; }

    /// <summary>Gets a value indicating whether structures marked experimental should be included.</summary>
    public bool IncludeExperimental { get; }

    /// <summary>Gets the language input dir.</summary>
    public string LanguageInputDir { get; }

    /// <summary>Gets the language input.</summary>
    public Language.LanguageSupportFiles SupportFiles { get; }

    /// <summary>Gets a language parameter.</summary>
    /// <param name="field">       The field.</param>
    /// <param name="valueDefault">The value default.</param>
    /// <returns>The language parameter.</returns>
    public bool GetParam(
        string field,
        bool valueDefault)
    {
        if (string.IsNullOrEmpty(field))
        {
            return valueDefault;
        }

        string name = field.ToUpperInvariant();

        if (!_languageOptions.ContainsKey(name) ||
            string.IsNullOrEmpty(_languageOptions[name]))
        {
            return valueDefault;
        }

        if (bool.TryParse(_languageOptions[name], out bool bValue))
        {
            return bValue;
        }

        return valueDefault;
    }

    /// <summary>Gets language parameter.</summary>
    /// <param name="field">       The field.</param>
    /// <param name="valueDefault">The value default.</param>
    /// <returns>The language parameter.</returns>
    public int GetParam(
        string field,
        int valueDefault)
    {
        if (string.IsNullOrEmpty(field))
        {
            return valueDefault;
        }

        string name = field.ToUpperInvariant();

        if (!_languageOptions.ContainsKey(name) ||
            string.IsNullOrEmpty(_languageOptions[name]))
        {
            return valueDefault;
        }

        if (int.TryParse(_languageOptions[name], out int iValue))
        {
            return iValue;
        }

        return valueDefault;
    }

    /// <summary>Gets language parameter.</summary>
    /// <param name="field">       The field.</param>
    /// <param name="valueDefault">The value default.</param>
    /// <returns>The language parameter.</returns>
    public string GetParam(
        string field,
        string valueDefault)
    {
        if (string.IsNullOrEmpty(field))
        {
            return valueDefault;
        }

        string name = field.ToUpperInvariant();

        if (!_languageOptions.ContainsKey(name) ||
            string.IsNullOrEmpty(_languageOptions[name]))
        {
            return valueDefault;
        }

        return _languageOptions[name];
    }
}
