﻿// Copyright (c) 2019 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using EventBuilder.Core.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using static EventBuilder.Core.Reflection.XmlSyntaxFactory;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace EventBuilder.Benchmarks
{
    [ClrJob]
    [CoreJob]
    [MemoryDiagnoser]
    [MarkdownExporterAttribute.GitHub]
    public class CommentGenerator
    {
        private static readonly string[] _testValues = { "This is a test {0}.", "Test2 this is a test {0}" };
        private static readonly string[] _testValuesTypes = { "System.Blah1", "System.Blah2" };

        /// <summary>
        /// A benchmark which tests the <see cref="XmlSyntaxFactory.GenerateSummarySeeAlsoComment(string, string)"/> method.
        /// </summary>
        [Benchmark]
        public void GenerateSummarySeeAlsoCommentBenchmark()
        {
            for (int i = 0; i < _testValues.Length * 5; ++i)
            {
                int currentIndex = i % _testValues.Length;
                var testValue = _testValues[currentIndex];
                var testValueType = _testValuesTypes[currentIndex];
                var syntax = XmlSyntaxFactory.GenerateSummarySeeAlsoComment(testValue, testValueType);
            }
        }
    }
}