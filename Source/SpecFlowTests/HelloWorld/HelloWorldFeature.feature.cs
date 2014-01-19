﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18408
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

#region Designer generated code

using TechTalk.SpecFlow;

#pragma warning disable

namespace SpecFlowTests.HelloWorld
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class HelloWorldFeatureFeature : Xunit.IUseFixture<HelloWorldFeatureFeature.FixtureData>,
        System.IDisposable
    {
        private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "HelloWorldFeature.feature"
#line hidden

        public HelloWorldFeatureFeature()
        {
            this.TestInitialize();
        }

        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            var featureInfo = new TechTalk.SpecFlow.FeatureInfo(
                new System.Globalization.CultureInfo("en-US"),
                "HelloWorldFeature",
                "In order to find person\r\nAs a BDD fan\r\nI want to find Gojko",
                ProgrammingLanguage.CSharp,
                ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }

        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }

        public virtual void TestInitialize()
        {
        }

        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }

        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }

        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }

        public virtual void SetFixture(HelloWorldFeatureFeature.FixtureData fixtureData)
        {
        }

        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }

        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "HelloWorldFeature")]
        [Xunit.TraitAttribute("Description", "Add two numbers")]
        public virtual void AddTwoNumbers()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "Add two numbers",
                new string[]
                    {
                        "test"
                    });
#line 7
            this.ScenarioSetup(scenarioInfo);
#line hidden
            var table1 = new TechTalk.SpecFlow.Table(
                new string[]
                    {
                        "FirstName",
                        "LastName"
                    });
            table1.AddRow(
                new string[]
                    {
                        "Martin",
                        "Fowler"
                    });
            table1.AddRow(
                new string[]
                    {
                        "Gojko",
                        "Adzic"
                    });
#line 8
            testRunner.Given("the following persons", ((string)(null)), table1, "Given ");
#line hidden
            var table2 = new TechTalk.SpecFlow.Table(
                new string[]
                    {
                        "FirstName",
                        "LastName"
                    });
            table2.AddRow(
                new string[]
                    {
                        "Abraham",
                        "Lincoln"
                    });
            table2.AddRow(
                new string[]
                    {
                        "Thomas",
                        "Jefferson"
                    });
#line 12
            testRunner.And("following", ((string)(null)), table2, "And ");
#line 16
            testRunner.When("the person start on \'G\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            var table3 = new TechTalk.SpecFlow.Table(
                new string[]
                    {
                        "FirstName",
                        "LastName"
                    });
            table3.AddRow(
                new string[]
                    {
                        "Gojko",
                        "Adzic"
                    });
#line 17
            testRunner.Then("the person was found", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            public FixtureData()
            {
                FeatureSetup();
            }

            void System.IDisposable.Dispose()
            {
                FeatureTearDown();
            }
        }
    }
}

#pragma warning restore

#endregion
