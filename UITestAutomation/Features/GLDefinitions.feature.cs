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
    [NUnit.Framework.DescriptionAttribute("GL Definitions")]
    public partial class GLDefinitionsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "GLDefinitions.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "GL Definitions", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("GL Definitions")]
        [NUnit.Framework.CategoryAttribute("GLDefinitions")]
        public virtual void GLDefinitions()
        {
            string[] tagsOfScenario = new string[] {
                    "GLDefinitions"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GL Definitions", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 8
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
#line 9
    testRunner.Given("User clicks the Profile Icon on Dashboard page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
 testRunner.And("User selects the GL Definitions option from the drop down menu of the ProfileIcon" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table54 = new TechTalk.SpecFlow.Table(new string[] {
                            "UI Controls"});
                table54.AddRow(new string[] {
                            "GL Definition Option"});
                table54.AddRow(new string[] {
                            "Add GL Definition"});
                table54.AddRow(new string[] {
                            "Delete GL Definition"});
                table54.AddRow(new string[] {
                            "Edit GL Definition"});
                table54.AddRow(new string[] {
                            "Copy GL Definition"});
                table54.AddRow(new string[] {
                            "Refresh"});
                table54.AddRow(new string[] {
                            "Download Letter"});
                table54.AddRow(new string[] {
                            "Show Deleted GL Definition"});
                table54.AddRow(new string[] {
                            "Action"});
                table54.AddRow(new string[] {
                            "Transfer Type"});
                table54.AddRow(new string[] {
                            "GL Account"});
                table54.AddRow(new string[] {
                            "Description"});
                table54.AddRow(new string[] {
                            "Reference"});
                table54.AddRow(new string[] {
                            "Source"});
                table54.AddRow(new string[] {
                            "Branch"});
                table54.AddRow(new string[] {
                            "Customer Type"});
#line 11
 testRunner.And("User validates the following UI Controls on the GL Definitions Page", ((string)(null)), table54, "And ");
#line hidden
#line 31
 testRunner.And("User clicks the Add GL Definition Icon on the GL Definitions Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table55 = new TechTalk.SpecFlow.Table(new string[] {
                            "Fields"});
                table55.AddRow(new string[] {
                            "Transfer Type"});
                table55.AddRow(new string[] {
                            "Transaction Type"});
                table55.AddRow(new string[] {
                            "Transfer Account"});
                table55.AddRow(new string[] {
                            "Transfer GL Code"});
                table55.AddRow(new string[] {
                            "Transfer Account Type (DDA, SAV)"});
                table55.AddRow(new string[] {
                            "Transfer Description"});
                table55.AddRow(new string[] {
                            "Transfer Transaction Code"});
                table55.AddRow(new string[] {
                            "Transfer GL Branch Code"});
                table55.AddRow(new string[] {
                            "Transfer GL Cost Center"});
                table55.AddRow(new string[] {
                            "GL Account"});
                table55.AddRow(new string[] {
                            "GL Code"});
                table55.AddRow(new string[] {
                            "GL Transaction Code"});
                table55.AddRow(new string[] {
                            "GL Branch Code"});
                table55.AddRow(new string[] {
                            "GL Cost Center"});
                table55.AddRow(new string[] {
                            "GL Description"});
                table55.AddRow(new string[] {
                            "Reference"});
                table55.AddRow(new string[] {
                            "Workflow"});
                table55.AddRow(new string[] {
                            "Branch"});
                table55.AddRow(new string[] {
                            "Customer Type"});
                table55.AddRow(new string[] {
                            "Save"});
                table55.AddRow(new string[] {
                            "Close"});
                table55.AddRow(new string[] {
                            "Delete Definition"});
#line 32
 testRunner.And("User validates the following fields on the Add GL Definitions Page", ((string)(null)), table55, "And ");
#line hidden
#line 57
 testRunner.And("User clicks the Download from Library Button on the GL Definitions Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table56 = new TechTalk.SpecFlow.Table(new string[] {
                            "Fields"});
                table56.AddRow(new string[] {
                            "Cross Button 2"});
                table56.AddRow(new string[] {
                            "Search Bar"});
                table56.AddRow(new string[] {
                            "Search Button"});
                table56.AddRow(new string[] {
                            "Action"});
                table56.AddRow(new string[] {
                            "ID"});
                table56.AddRow(new string[] {
                            "Description"});
                table56.AddRow(new string[] {
                            "Download GL Definition"});
                table56.AddRow(new string[] {
                            "Close"});
#line 58
 testRunner.And("User validates the following fields on the Download from Library Button Page", ((string)(null)), table56, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
