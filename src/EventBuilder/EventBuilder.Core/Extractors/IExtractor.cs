﻿// Copyright (c) 2019 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventBuilder.Core.Extractors
{
    /// <summary>
    /// Extracts information from a platform, assembly or nuget package.
    /// </summary>
    public interface IExtractor
    {
        /// <summary>
        /// Gets the assemblies.
        /// </summary>
        List<string> Assemblies { get; }

        /// <summary>
        /// Gets the cecil search directories.
        /// Cecil when run on Mono needs some direction as to the location of the platform specific MSCORLIB.
        /// </summary>
        List<string> SearchDirectories { get; }
    }
}
