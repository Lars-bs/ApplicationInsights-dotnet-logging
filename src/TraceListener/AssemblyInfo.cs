// -----------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs" company="Microsoft">
// Copyright (c) Microsoft Corporation. 
// All rights reserved.  2013
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Microsoft.ApplicationInsights.TraceListener")]
[assembly: AssemblyDescription("Application Insights Trace Listener is a customer trace listener allowing you to send trace log messages to Application Insights. Application Insights will collect your logs from multiple sources and provide rich powerful search capabilities. This functionality depends on Microsoft Monitoring Agent being installed onto your machine, http://go.microsoft.com/fwlink/?LinkID=328052.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: NeutralResourcesLanguageAttribute("en-US")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("3aada9bf-fc15-42fd-ace5-4cb2f11c1f2a")]

[assembly: InternalsVisibleTo("Microsoft.ApplicationInsights.TraceListener.Net45.Tests")]
[assembly: InternalsVisibleTo("Microsoft.ApplicationInsights.TraceListener.NetCoreApp10.Tests")]
