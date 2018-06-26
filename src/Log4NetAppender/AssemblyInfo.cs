// -----------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs" company="Microsoft">
// Copyright (c) Microsoft Corporation. 
// All rights reserved.  2013
// </copyright>
// -----------------------------------------------------------------------

using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Microsoft.ApplicationInsights.Log4NetAppender")]
[assembly: AssemblyDescription("Application Insights Log4Net Appender is a customer appender allowing you to send Log4Net log messages to Application Insights. Application Insights will collect your logs from multiple sources and provide rich powerful search capabilities. This functionality depends on Microsoft Monitoring Agent being installed onto your machine, http://go.microsoft.com/fwlink/?LinkID=328052.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: NeutralResourcesLanguageAttribute("en-US")]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("599daa99-7d0b-4cae-81b8-3a73509f2efa")]

[assembly: InternalsVisibleTo("Microsoft.ApplicationInsights.Log4NetAppender.Net45.Tests")]
[assembly: InternalsVisibleTo("Microsoft.ApplicationInsights.Log4NetAppender.NetCoreApp10.Tests")]