﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UITestAutomation.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Company Settings")]
    public partial class CompanySettingsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Company Settings.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Company Settings", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line hidden
#line 4
 testRunner.Given("User log into Dispute Tracking Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 5
 testRunner.And("User should be able to see Dashboard in Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Company Settings")]
        [NUnit.Framework.CategoryAttribute("tag1")]
        public virtual void CompanySettings()
        {
            string[] tagsOfScenario = new string[] {
                    "tag1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Company Settings", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 7
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 8
 testRunner.Given("User clicks the Profile Icon on Dashboard page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
 testRunner.And("User selects the Company Settings Field from the dropdown menu of Profile Icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                            "UI Control"});
                table14.AddRow(new string[] {
                            "Provisional Credit Days"});
                table14.AddRow(new string[] {
                            "Audit Start"});
                table14.AddRow(new string[] {
                            "Audit End"});
                table14.AddRow(new string[] {
                            "Daily GL Cut-Off Time"});
                table14.AddRow(new string[] {
                            "Post On Saturdays"});
                table14.AddRow(new string[] {
                            "Post 7 Days a Week"});
                table14.AddRow(new string[] {
                            "Statement Date"});
                table14.AddRow(new string[] {
                            "Use Last Business Date"});
                table14.AddRow(new string[] {
                            "Customer Create/Update Settings"});
                table14.AddRow(new string[] {
                            "Hide Address2"});
                table14.AddRow(new string[] {
                            "Hide Address3"});
                table14.AddRow(new string[] {
                            "Hide Address4"});
                table14.AddRow(new string[] {
                            "Hide City"});
                table14.AddRow(new string[] {
                            "Hide State"});
                table14.AddRow(new string[] {
                            "Hide Zip"});
                table14.AddRow(new string[] {
                            "Enable Task"});
                table14.AddRow(new string[] {
                            "Display Task Configuration and Sections"});
#line 10
 testRunner.And("User validates the following UI Controls on Company Settings Page", ((string)(null)), table14, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
