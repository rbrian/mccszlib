/*---------------------------------------------------------------------------
  RemObjects SDK for .NET - Core Library
  (c)opyright RemObjects Software, Inc. 2002-2011. All rights reserved.

  #ZipLib Library (c)opyright Mike Krueger 2001-2002

  Using this code requires a valid license of the RemObjects SDK for .NET
  which can be obtained at http://www.remobjects.com?ro.

  Using this code requires you to accept the conditions explained below.
  Visit http://www.icsharpcode.net/OpenSource/SharpZipLib/ for more
  information on this Library and for new/updated versions.

  For non GPL usage, make sure you understand the limitations explained
  below, namely that you may not link the code from the library statically
  into your application on other non-GPL code but must use a separate
  assembly.

  This version is based on #ziplib 0.81.0.1407.
---------------------------------------------------------------------------*/

// Copyright (C) 2001 Mike Krueger
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// Linking this library statically or dynamically with other modules is
// making a combined work based on this library.  Thus, the terms and
// conditions of the GNU General Public License cover the whole
// combination.
//
// As a special exception, the copyright holders of this library give you
// permission to link this library with independent modules to produce an
// executable, regardless of the license terms of these independent
// modules, and to copy and distribute the resulting executable under
// terms of your choice, provided that you also meet, for each linked
// independent module, the terms and conditions of the license of that
// module.  An independent module is a module which is not derived from
// or based on this library.  If you modify this library, you may extend
// this exception to your version of the library, but you are not
// obligated to do so.  If you do not wish to do so, delete this
// exception statement from your version.

using System;
using System.Reflection;
using System.Runtime.CompilerServices;


[assembly: AssemblyTitle("")]
[assembly: AssemblyDescription("RemObjects SDK for .NET - ZLib Library - A free C# zlib implementation (Based on #ziplib 0.8)")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("RemObjects Software, Inc.")]
[assembly: AssemblyProduct("RemObjects SDK for .NET")]
[assembly: AssemblyCopyright("Copyright RemObjects Software, Inc. 2002-2011. All Rights Reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyVersion("6.0.0.0")]

[assembly: CLSCompliant(true)]
#if REMOBJECTS_SIGN_ASSEMBLY
[assembly: AssemblyKeyName("RemObjectsSoftware")]
#if !SILVERLIGHT
[assembly: System.Security.AllowPartiallyTrustedCallers()]
#endif
#endif

#if SILVERLIGHT
[assembly: AssemblyKeyName("RemObjectsSoftwareSilverlight")]
#endif
#if WINDOWS_PHONE
[assembly: System.Runtime.Versioning.TargetFramework("Silverlight,Version=v4.0,Profile=WindowsPhone", FrameworkDisplayName="Silverlight 4.0 Windows Phone Profile")]
#endif