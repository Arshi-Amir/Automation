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
    [NUnit.Framework.DescriptionAttribute("CompanyDetails")]
    public partial class CompanyDetailsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CompanyDetails.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "CompanyDetails", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 4
#line hidden
#line 5
 testRunner.Given("User log into Dispute Tracking Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.And("User should be able to see Dashboard in Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Company Details")]
        [NUnit.Framework.CategoryAttribute("CompanyDetails")]
        public virtual void CompanyDetails()
        {
            string[] tagsOfScenario = new string[] {
                    "CompanyDetails"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Company Details", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 9
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
#line 4
this.FeatureBackground();
#line hidden
#line 10
 testRunner.Given("User clicks the Profile Icon on the Dashboard page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 11
 testRunner.And("User selects the Company Details Option from the dropdown menu of ProfileIcon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                            "UI Controls"});
                table15.AddRow(new string[] {
                            "Company Details"});
                table15.AddRow(new string[] {
                            "Basic Info"});
                table15.AddRow(new string[] {
                            "General Settings"});
                table15.AddRow(new string[] {
                            "Lookup Values"});
                table15.AddRow(new string[] {
                            "Style"});
                table15.AddRow(new string[] {
                            "Save"});
#line 12
 testRunner.And("User validates the following UI Controls on Company Details Page", ((string)(null)), table15, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Basic Info")]
        public virtual void BasicInfo()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Basic Info", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 22
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
#line 4
this.FeatureBackground();
#line hidden
#line 23
 testRunner.And("User selects the Basic Info button on Company Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                            "Fields"});
                table16.AddRow(new string[] {
                            "Company Name"});
                table16.AddRow(new string[] {
                            "Address"});
                table16.AddRow(new string[] {
                            "City"});
                table16.AddRow(new string[] {
                            "State"});
                table16.AddRow(new string[] {
                            "Zip"});
                table16.AddRow(new string[] {
                            "Phone"});
                table16.AddRow(new string[] {
                            "Email"});
                table16.AddRow(new string[] {
                            "Support Email"});
                table16.AddRow(new string[] {
                            "Email Distribution List"});
                table16.AddRow(new string[] {
                            "Time Zone"});
                table16.AddRow(new string[] {
                            "Read only Questionnaires"});
#line 24
 testRunner.And("User validates the following fields on Basic Info Page", ((string)(null)), table16, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("General Settings")]
        public virtual void GeneralSettings()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("General Settings", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 40
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
#line 4
this.FeatureBackground();
#line hidden
#line 41
 testRunner.Given("User clicks on the General Settings button on Company Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                            "Fields"});
                table17.AddRow(new string[] {
                            "Signature Pad"});
                table17.AddRow(new string[] {
                            "Enter max idle time in minutes"});
                table17.AddRow(new string[] {
                            "Month End Statement"});
                table17.AddRow(new string[] {
                            "Select Logo File"});
#line 42
 testRunner.And("User validates the following fields on General Settings Page", ((string)(null)), table17, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Lookup Values")]
        public virtual void LookupValues()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Lookup Values", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 50
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
#line 4
this.FeatureBackground();
#line hidden
#line 51
 testRunner.Given("User clicks on the Lookup Values button on Company Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                            "UI Controls"});
                table18.AddRow(new string[] {
                            "Cross Button"});
                table18.AddRow(new string[] {
                            "Add Submission Status"});
                table18.AddRow(new string[] {
                            "Edit Submission Status"});
                table18.AddRow(new string[] {
                            "Delete Submission Status"});
                table18.AddRow(new string[] {
                            "Add Source"});
                table18.AddRow(new string[] {
                            "Edit Source"});
                table18.AddRow(new string[] {
                            "Delete Source"});
                table18.AddRow(new string[] {
                            "Add Account Type"});
                table18.AddRow(new string[] {
                            "Edit Account Type"});
                table18.AddRow(new string[] {
                            "Delete Account Type"});
                table18.AddRow(new string[] {
                            "Add Dispute Research Detail"});
                table18.AddRow(new string[] {
                            "Edit Dispute Research Detail"});
                table18.AddRow(new string[] {
                            "Delete Dispute Research Detail"});
                table18.AddRow(new string[] {
                            "Add Branch"});
                table18.AddRow(new string[] {
                            "Edit Branch"});
                table18.AddRow(new string[] {
                            "Delete Branch"});
                table18.AddRow(new string[] {
                            "Add Charter/Branding"});
                table18.AddRow(new string[] {
                            "Edit Charter/Branding"});
                table18.AddRow(new string[] {
                            "Delete Charter/Branding"});
                table18.AddRow(new string[] {
                            "Contacts Lookup"});
                table18.AddRow(new string[] {
                            "Edit Contacts Lookup"});
                table18.AddRow(new string[] {
                            "Delete Contacts Lookup"});
                table18.AddRow(new string[] {
                            "Transaction Decline Reason"});
                table18.AddRow(new string[] {
                            "Edit Transaction Decline Reason"});
                table18.AddRow(new string[] {
                            "Delete Transaction Decline Reason"});
                table18.AddRow(new string[] {
                            "Batch Reporting Reference"});
                table18.AddRow(new string[] {
                            "Edit Batch Reporting Reference"});
                table18.AddRow(new string[] {
                            "Delete Batch Reporting Reference"});
#line 52
 testRunner.And("User validates the following UI Controls on Lookup Values Page", ((string)(null)), table18, "And ");
#line hidden
                TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                            "Fields"});
                table19.AddRow(new string[] {
                            "Text Area"});
                table19.AddRow(new string[] {
                            "Save"});
                table19.AddRow(new string[] {
                            "Close"});
#line 84
 testRunner.And("User validates the following UI Controls on Add Lookup Values Page", ((string)(null)), table19, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Style")]
        public virtual void Style()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Style", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 91
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
#line 4
this.FeatureBackground();
#line hidden
#line 92
 testRunner.Given("User clicks on Style Button on Company Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                            "UI Controls"});
                table20.AddRow(new string[] {
                            "Primary Buttons Color"});
                table20.AddRow(new string[] {
                            "Secondary Buttons Color"});
                table20.AddRow(new string[] {
                            "Primary Buttons Font Color"});
                table20.AddRow(new string[] {
                            "Secondary Buttons Font Color"});
#line 93
 testRunner.And("User validates the following UI Controls on Style Button Page", ((string)(null)), table20, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
