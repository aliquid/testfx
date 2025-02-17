﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Linq;

using FluentAssertions;

using Microsoft.MSTestV2.CLIAutomation;

namespace MSTest.IntegrationTests;
public partial class TestId : CLITestBase
{
    private const string LegacyStrategyDll = "TestIdProject.LegacyStrategy";

    public void TestIdUniqueness_DataRowArray_LegacyStrategy()
    {
        // Arrange
        var assemblyPath = GetAssetFullPath(LegacyStrategyDll);

        // Act
        var testCases = DiscoverTests(assemblyPath, "FullyQualifiedName~DataRowArraysTests");
        var testResults = RunTests(testCases);

        // Assert
        VerifyE2E.FailedTestCount(testResults, 0);
        VerifyE2E.TestsPassed(
            testResults,
            null, // For legacy, there is an extra test result, being the parent and it has no display name
            "DataRowArraysTests (0,System.Int32[])",
            "DataRowArraysTests (0,System.Int32[])",
            "DataRowArraysTests (0,System.Int32[])");

        // We cannot assert the expected ID as it is path dependent
        testResults.Select(x => x.TestCase.Id.ToString()).Distinct().Should().ContainSingle();
    }

    public void TestIdUniqueness_DataRowString_LegacyStrategy()
    {
        // Arrange
        var assemblyPath = GetAssetFullPath(LegacyStrategyDll);

        // Act
        var testCases = DiscoverTests(assemblyPath, "FullyQualifiedName~DataRowStringTests");
        var testResults = RunTests(testCases);

        // Assert
        VerifyE2E.FailedTestCount(testResults, 0);
        VerifyE2E.TestsPassed(
            testResults,
            null, // For legacy, there is an extra test result, being the parent and it has no display name
            "DataRowStringTests ()",
            "DataRowStringTests ()",
            "DataRowStringTests ( )",
            "DataRowStringTests (  )");

        // We cannot assert the expected ID as it is path dependent
        testResults.Select(x => x.TestCase.Id.ToString()).Distinct().Should().ContainSingle();
    }

    public void TestIdUniqueness_DynamicDataArrays_LegacyStrategy()
    {
        // Arrange
        var assemblyPath = GetAssetFullPath(LegacyStrategyDll);

        // Act
        var testCases = DiscoverTests(assemblyPath, "FullyQualifiedName~DynamicDataArraysTests");
        var testResults = RunTests(testCases);

        // Assert
        VerifyE2E.FailedTestCount(testResults, 0);
        VerifyE2E.TestsPassed(
            testResults,
            null, // For legacy, there is an extra test result, being the parent and it has no display name
            "DynamicDataArraysTests (0,System.Int32[])",
            "DynamicDataArraysTests (0,System.Int32[])",
            "DynamicDataArraysTests (0,System.Int32[])");

        // We cannot assert the expected ID as it is path dependent
        testResults.Select(x => x.TestCase.Id.ToString()).Distinct().Should().ContainSingle();
    }

    public void TestIdUniqueness_DynamicDataTuple_LegacyStrategy()
    {
        // Arrange
        var assemblyPath = GetAssetFullPath(LegacyStrategyDll);

        // Act
        var testCases = DiscoverTests(assemblyPath, "FullyQualifiedName~DynamicDataTuplesTests");
        var testResults = RunTests(testCases);

        // Assert
        VerifyE2E.FailedTestCount(testResults, 0);
        VerifyE2E.TestsPassed(
            testResults,
            null, // For legacy, there is an extra test result, being the parent and it has no display name
            "DynamicDataTuplesTests ((1, text, True))",
            "DynamicDataTuplesTests ((1, text, False))");

        // We cannot assert the expected ID as it is path dependent
        testResults.Select(x => x.TestCase.Id.ToString()).Distinct().Should().ContainSingle();
    }

    public void TestIdUniqueness_DynamicDataGenericCollections_LegacyStrategy()
    {
        // Arrange
        var assemblyPath = GetAssetFullPath(LegacyStrategyDll);

        // Act
        var testCases = DiscoverTests(assemblyPath, "FullyQualifiedName~DynamicDataGenericCollectionsTests");
        var testResults = RunTests(testCases);

        // Assert
        VerifyE2E.FailedTestCount(testResults, 0);
        VerifyE2E.TestsPassed(
            testResults,
            null, // For legacy, there is an extra test result, being the parent and it has no display name
            "DynamicDataGenericCollectionsTests (System.Collections.Generic.List`1[System.Int32],System.Collections.Generic.List`1[System.String],System.Collections.Generic.List`1[System.Boolean])",
            "DynamicDataGenericCollectionsTests (System.Collections.Generic.List`1[System.Int32],System.Collections.Generic.List`1[System.String],System.Collections.Generic.List`1[System.Boolean])",
            "DynamicDataGenericCollectionsTests (System.Collections.Generic.List`1[System.Int32],System.Collections.Generic.List`1[System.String],System.Collections.Generic.List`1[System.Boolean])",
            "DynamicDataGenericCollectionsTests (System.Collections.Generic.List`1[System.Int32],System.Collections.Generic.List`1[System.String],System.Collections.Generic.List`1[System.Boolean])");

        // We cannot assert the expected ID as it is path dependent
        testResults.Select(x => x.TestCase.Id.ToString()).Distinct().Should().ContainSingle();
    }

    public void TestIdUniqueness_TestDataSourceArrays_LegacyStrategy()
    {
        // Arrange
        var assemblyPath = GetAssetFullPath(LegacyStrategyDll);

        // Act
        var testCases = DiscoverTests(assemblyPath, "FullyQualifiedName~TestDataSourceArraysTests");
        var testResults = RunTests(testCases);

        // Assert
        VerifyE2E.FailedTestCount(testResults, 0);
        VerifyE2E.TestsPassed(
            testResults,
            null, // For legacy, there is an extra test result, being the parent and it has no display name
            "Custom name",
            "Custom name",
            "Custom name");

        // We cannot assert the expected ID as it is path dependent
        testResults.Select(x => x.TestCase.Id.ToString()).Distinct().Should().ContainSingle();
    }

    public void TestIdUniqueness_TestDataSourceTuples_LegacyStrategy()
    {
        // Arrange
        var assemblyPath = GetAssetFullPath(LegacyStrategyDll);

        // Act
        var testCases = DiscoverTests(assemblyPath, "FullyQualifiedName~TestDataSourceTuplesTests");
        var testResults = RunTests(testCases);

        // Assert
        VerifyE2E.FailedTestCount(testResults, 0);
        VerifyE2E.TestsPassed(
            testResults,
            null, // For legacy, there is an extra test result, being the parent and it has no display name
            "Custom name",
            "Custom name");

        // We cannot assert the expected ID as it is path dependent
        testResults.Select(x => x.TestCase.Id.ToString()).Distinct().Should().ContainSingle();
    }

    public void TestIdUniqueness_TestDataSourceGenericCollections_LegacyStrategy()
    {
        // Arrange
        var assemblyPath = GetAssetFullPath(LegacyStrategyDll);

        // Act
        var testCases = DiscoverTests(assemblyPath, "FullyQualifiedName~TestDataSourceGenericCollectionsTests");
        var testResults = RunTests(testCases);

        // Assert
        VerifyE2E.FailedTestCount(testResults, 0);
        VerifyE2E.TestsPassed(
            testResults,
            null, // For legacy, there is an extra test result, being the parent and it has no display name
            "Custom name",
            "Custom name",
            "Custom name",
            "Custom name");

        // We cannot assert the expected ID as it is path dependent
        testResults.Select(x => x.TestCase.Id.ToString()).Distinct().Should().ContainSingle();
    }
}
