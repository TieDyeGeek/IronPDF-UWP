# IronPDF UWP demo

---

This code will build and run fine in "Debug" mode. Click the button to generate and save a PDF into the downloads folder. 

However, when building in "Release" mode, I get the following error:

```
Error		ILT0014: Failed to compile interop source code. See the build log for error details.
```
```
Task "Gatekeeper"
1>  Launching 'C:\Program Files (x86)\Microsoft SDKs\UWPNuGetPackages\runtime.win10-x86.microsoft.net.native.compiler\2.2.8-rel-28605-00\tools\x86\ilc\ilc.exe --gatekeeper @"C:\GitHubWorkspace\TieDyeGeek\IronPDF-UWP\IronPdfUwp\IronPdfUwp\obj\x86\Release\ilc\intermediate\gkargs.rsp"'
1>  Microsoft (R) .NET Native Gatekeeper Version 2.2.28605.00 
1>  Copyright (C) Microsoft Corporation.  All rights reserved. 
1>   
1>  ILCTelemetry: System.ArgumentException: Could not deserialize to TelemetrySession object
1>  Parameter name: serializedSession ---> System.Runtime.Serialization.SerializationException: There was an error deserializing the object of type Microsoft.VisualStudio.Telemetry.TelemetrySessionSettings. The token '"' was expected but found 'I'. ---> System.Xml.XmlException: The token '"' was expected but found 'I'.
1>     at System.Xml.XmlExceptionHelper.ThrowXmlException(XmlDictionaryReader reader, String res, String arg1, String arg2, String arg3)
1>     at System.Xml.XmlExceptionHelper.ThrowTokenExpected(XmlDictionaryReader reader, String expected, Char found)
1>     at System.Runtime.Serialization.Json.XmlJsonReader.ReadServerTypeAttribute(Boolean consumedObjectChar)
1>     at System.Runtime.Serialization.Json.XmlJsonReader.ReadAttributes()
1>     at System.Runtime.Serialization.Json.XmlJsonReader.ReadNonExistentElementName(StringHandleConstStringType elementName)
1>     at System.Runtime.Serialization.Json.XmlJsonReader.Read()
1>     at System.Xml.XmlBaseReader.IsStartElement()
1>     at System.Xml.XmlBaseReader.IsStartElement(XmlDictionaryString localName, XmlDictionaryString namespaceUri)
1>     at System.Runtime.Serialization.XmlReaderDelegator.IsStartElement(XmlDictionaryString localname, XmlDictionaryString ns)
1>     at System.Runtime.Serialization.XmlObjectSerializer.IsRootElement(XmlReaderDelegator reader, DataContract contract, XmlDictionaryString name, XmlDictionaryString ns)
1>     at System.Runtime.Serialization.Json.DataContractJsonSerializer.InternalIsStartObject(XmlReaderDelegator reader)
1>     at System.Runtime.Serialization.Json.DataContractJsonSerializer.InternalReadObject(XmlReaderDelegator xmlReader, Boolean verifyObjectName)
1>     at System.Runtime.Serialization.XmlObjectSerializer.InternalReadObject(XmlReaderDelegator reader, Boolean verifyObjectName, DataContractResolver dataContractResolver)
1>     at System.Runtime.Serialization.XmlObjectSerializer.ReadObjectHandleExceptions(XmlReaderDelegator reader, Boolean verifyObjectName, DataContractResolver dataContractResolver)
1>     --- End of inner exception stack trace ---
1>     at System.Runtime.Serialization.XmlObjectSerializer.ReadObjectHandleExceptions(XmlReaderDelegator reader, Boolean verifyObjectName, DataContractResolver dataContractResolver)
1>     at System.Runtime.Serialization.Json.DataContractJsonSerializer.ReadObject(XmlDictionaryReader reader)
1>     at System.Runtime.Serialization.Json.DataContractJsonSerializer.ReadObject(Stream stream)
1>     at Microsoft.VisualStudio.Telemetry.TelemetrySessionSettings.Deserialize(String settings)
1>     at Microsoft.VisualStudio.Telemetry.TelemetrySessionSettings.Parse(String serializedSession)
1>     --- End of inner exception stack trace ---
1>     at Microsoft.VisualStudio.Telemetry.TelemetrySessionSettings.Parse(String serializedSession)
1>     at ILCTelemetry.Program.ReadEvents()
1>     at ILCTelemetry.Program.Main(String[] args)
1>  Checking assembly 'C:\GitHubWorkspace\TieDyeGeek\IronPDF-UWP\IronPdfUwp\IronPdfUwp\obj\x86\Release\ilc\in\IronPdf.dll'. 
1>  Checking assembly 'C:\GitHubWorkspace\TieDyeGeek\IronPDF-UWP\IronPdfUwp\IronPdfUwp\obj\x86\Release\ilc\in\IronPdf.Assets.Rendering.Universal.dll'. 
1>  Checking assembly 'C:\GitHubWorkspace\TieDyeGeek\IronPDF-UWP\IronPdfUwp\IronPdfUwp\obj\x86\Release\ilc\in\IronPdfUwp.exe'. 
1>  'C:\Program Files (x86)\Microsoft SDKs\UWPNuGetPackages\runtime.win10-x86.microsoft.net.native.compiler\2.2.8-rel-28605-00\tools\x86\ilc\ilc.exe --gatekeeper @"C:\GitHubWorkspace\TieDyeGeek\IronPDF-UWP\IronPdfUwp\IronPdfUwp\obj\x86\Release\ilc\intermediate\gkargs.rsp"' completed.
```
I belive the issue is due to the restrictions of .NET Native.