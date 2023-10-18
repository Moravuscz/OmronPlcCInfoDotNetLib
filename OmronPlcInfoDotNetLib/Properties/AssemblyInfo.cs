#if NET40_OR_GREATER || (NET5_0_OR_GREATER && WINDOWS7_0_OR_GREATER)
using System.Windows.Markup;
#endif
using System.Runtime.InteropServices;

// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties

#if NET40_OR_GREATER || (NET5_0_OR_GREATER && WINDOWS7_0_OR_GREATER)
/* XML Namespace Prefix and Definition for use in XAML UI
 * Only available for projects targetting .NET Framework or Windows-specific .NET 5, 6 or 7
 */

[assembly: XmlnsPrefix("https://github.com/Moravuscz/OmronPLCCommDotNetLib", "OmrPLCInfo")]
[assembly: XmlnsDefinition("https://github.com/Moravuscz/OmronPLCCommDotNetLib", "Moravuscz.OmronPlcInformation", AssemblyName = "Moravuscz.OmronPlcInformation")]
#endif

// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

[assembly: Guid("c144ff7a-6c44-4a71-84e4-6a925ef0aacf")]
