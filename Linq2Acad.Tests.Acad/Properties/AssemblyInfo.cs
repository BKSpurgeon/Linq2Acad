﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Linq2Acad.Tests.Acad")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Linq2Acad")]
[assembly: AssemblyCopyright("Copyright ©  2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("c12ba054-301b-4578-96c5-657408bd25c9")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: CommandClass(typeof(Linq2Acad.Tests.BlockContainerTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.LayerContainerTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.DimStyleContainerTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.LinetypeContainerTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.RegAppContainerTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.TextStyleContainerTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.UcsContainerTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.ViewportContainerTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.ViewContainerTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.LayoutContainerTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.GroupContainerTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.MLeaderStyleContainerTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.MlineStyleContainerTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.MaterialContainerTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.DBVisualStyleContainerTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.PlotSettingsContainerTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.TableStyleContainerTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.SectionViewStyleContainerTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.DetailViewStyleContainerTests))]