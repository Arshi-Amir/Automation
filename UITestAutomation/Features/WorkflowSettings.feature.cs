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
    [NUnit.Framework.DescriptionAttribute("WorkflowSettings")]
    public partial class WorkflowSettingsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "WorkflowSettings.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "WorkflowSettings", "A short summary of the feature", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Workflow Settings")]
        [NUnit.Framework.CategoryAttribute("Add")]
        public virtual void WorkflowSettings()
        {
            string[] tagsOfScenario = new string[] {
                    "Add"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Workflow Settings", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.Given("User clicks the Profile Icon on Dashboard page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 11
 testRunner.And("User selects the Workflow Settings Field from the dropdown menu of Profile Icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table110 = new TechTalk.SpecFlow.Table(new string[] {
                            "UI Controls"});
                table110.AddRow(new string[] {
                            "Add"});
                table110.AddRow(new string[] {
                            "Edit"});
                table110.AddRow(new string[] {
                            "Delete"});
                table110.AddRow(new string[] {
                            "Download Letter"});
                table110.AddRow(new string[] {
                            "Action"});
                table110.AddRow(new string[] {
                            "ID"});
                table110.AddRow(new string[] {
                            "Workflow"});
                table110.AddRow(new string[] {
                            "Refresh"});
#line 12
 testRunner.And("User validates the following UI Controls on Workflow Settings Page", ((string)(null)), table110, "And ");
#line hidden
#line 22
 testRunner.And("User clicks the Add Workflow Setting on on Workflow Settings Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table111 = new TechTalk.SpecFlow.Table(new string[] {
                            "Controls"});
                table111.AddRow(new string[] {
                            "Settings"});
                table111.AddRow(new string[] {
                            "Event Triggers"});
                table111.AddRow(new string[] {
                            "Self-Service Verbiage"});
                table111.AddRow(new string[] {
                            "Close"});
                table111.AddRow(new string[] {
                            "Save"});
#line 23
 testRunner.And("User validates the following Controls on Edit Setting Dialog", ((string)(null)), table111, "And ");
#line hidden
                TechTalk.SpecFlow.Table table112 = new TechTalk.SpecFlow.Table(new string[] {
                            "Fields"});
                table112.AddRow(new string[] {
                            "Workflow"});
                table112.AddRow(new string[] {
                            "Publish"});
                table112.AddRow(new string[] {
                            "Allow Customer Access"});
                table112.AddRow(new string[] {
                            "Search By"});
                table112.AddRow(new string[] {
                            "Send Notifications"});
                table112.AddRow(new string[] {
                            "Distribution List"});
                table112.AddRow(new string[] {
                            "Transaction Type"});
                table112.AddRow(new string[] {
                            "Account Types Allowed"});
                table112.AddRow(new string[] {
                            "Closed Account Status"});
                table112.AddRow(new string[] {
                            "Add Transactions"});
                table112.AddRow(new string[] {
                            "Allow Manual Transactions"});
                table112.AddRow(new string[] {
                            "Allow user to copy / duplicate transactions"});
                table112.AddRow(new string[] {
                            "Copy Description to Merchant Field by Default"});
                table112.AddRow(new string[] {
                            "Merchant Copy Source Field Name"});
                table112.AddRow(new string[] {
                            "Transaction Filter Condition"});
                table112.AddRow(new string[] {
                            "Transaction Not Allowed Condition"});
                table112.AddRow(new string[] {
                            "Show Fraud / Non-Fraud Option"});
                table112.AddRow(new string[] {
                            "Disable Customer Edit"});
                table112.AddRow(new string[] {
                            "Has Questionnaire"});
                table112.AddRow(new string[] {
                            "Has Provisional Credit Calculation"});
                table112.AddRow(new string[] {
                            "Show Customer Type"});
                table112.AddRow(new string[] {
                            "Hide Comments And Resolution"});
                table112.AddRow(new string[] {
                            "Reimburse Fees"});
                table112.AddRow(new string[] {
                            "Transaction Code Filter"});
                table112.AddRow(new string[] {
                            "GL Reference"});
                table112.AddRow(new string[] {
                            "Interest Posting GL Reference"});
                table112.AddRow(new string[] {
                            "Compliance Regulation Screen"});
                table112.AddRow(new string[] {
                            "Dispute Screen Type"});
                table112.AddRow(new string[] {
                            "Email Template Reference"});
                table112.AddRow(new string[] {
                            "Confirmation Email Template Reference"});
                table112.AddRow(new string[] {
                            "Post Submission Automation Reference"});
                table112.AddRow(new string[] {
                            "Automation Reference On Submission Complete"});
                table112.AddRow(new string[] {
                            "Submission Screen Template"});
#line 30
 testRunner.And("User validates the following Fields in Settings Page on Edit Setting Dialog", ((string)(null)), table112, "And ");
#line hidden
                TechTalk.SpecFlow.Table table113 = new TechTalk.SpecFlow.Table(new string[] {
                            "Fields",
                            "Values"});
                table113.AddRow(new string[] {
                            "Workflow",
                            "Debit Card"});
                table113.AddRow(new string[] {
                            "Publish",
                            ""});
                table113.AddRow(new string[] {
                            "Allow Customer Access",
                            ""});
                table113.AddRow(new string[] {
                            "Customer Description",
                            "Casual User"});
                table113.AddRow(new string[] {
                            "Search By",
                            "Card"});
                table113.AddRow(new string[] {
                            "Send Notifications",
                            ""});
                table113.AddRow(new string[] {
                            "Distribution List",
                            "abc"});
                table113.AddRow(new string[] {
                            "Transaction Type",
                            "Default"});
                table113.AddRow(new string[] {
                            "Account Types Allowed",
                            "Default"});
                table113.AddRow(new string[] {
                            "Closed Account Status",
                            "Default"});
                table113.AddRow(new string[] {
                            "Add Transactions",
                            ""});
                table113.AddRow(new string[] {
                            "Allow Manual Transactions",
                            ""});
                table113.AddRow(new string[] {
                            "Allow user to copy / duplicate transactions",
                            ""});
                table113.AddRow(new string[] {
                            "Copy Description to Merchant Field by Default",
                            ""});
                table113.AddRow(new string[] {
                            "Merchant Copy Source Field Name",
                            "Arshi"});
                table113.AddRow(new string[] {
                            "Transaction Filter Condition",
                            "abc"});
                table113.AddRow(new string[] {
                            "Transaction Not Allowed Condition",
                            "abc"});
                table113.AddRow(new string[] {
                            "Show Fraud / Non-Fraud Option",
                            ""});
                table113.AddRow(new string[] {
                            "Verbiage for Fraud",
                            "donot"});
                table113.AddRow(new string[] {
                            "Verbiage for Non-Fraud",
                            "problem"});
                table113.AddRow(new string[] {
                            "Disable Customer Edit",
                            ""});
                table113.AddRow(new string[] {
                            "Has Questionnaire",
                            ""});
                table113.AddRow(new string[] {
                            "Has Provisional Credit Calculation",
                            ""});
                table113.AddRow(new string[] {
                            "Show Customer Type",
                            ""});
                table113.AddRow(new string[] {
                            "Hide Comments And Resolution",
                            ""});
                table113.AddRow(new string[] {
                            "Reimburse Fees",
                            ""});
                table113.AddRow(new string[] {
                            "Transaction Code Filter",
                            "123"});
                table113.AddRow(new string[] {
                            "GL Reference",
                            "Red1"});
                table113.AddRow(new string[] {
                            "Interest Posting GL Reference",
                            "Red1"});
                table113.AddRow(new string[] {
                            "Compliance Regulation Screen",
                            "None"});
                table113.AddRow(new string[] {
                            "PC Business Days",
                            ""});
                table113.AddRow(new string[] {
                            "Provisional Credit Days",
                            "4"});
                table113.AddRow(new string[] {
                            "Resolution Business Days",
                            ""});
                table113.AddRow(new string[] {
                            "Resolution Days",
                            "12"});
                table113.AddRow(new string[] {
                            "Dispute Screen Type",
                            "Default"});
                table113.AddRow(new string[] {
                            "Email Template Reference",
                            "DC"});
                table113.AddRow(new string[] {
                            "Confirmation Email Template Reference",
                            "PC"});
                table113.AddRow(new string[] {
                            "Post Submission Automation Reference",
                            "AC"});
                table113.AddRow(new string[] {
                            "Automation Reference On Submission Complete",
                            "SFFS"});
                table113.AddRow(new string[] {
                            "Submission Screen Template",
                            "Default"});
#line 65
 testRunner.And("User adds the following data to fields in Settings Page", ((string)(null)), table113, "And ");
#line hidden
                TechTalk.SpecFlow.Table table114 = new TechTalk.SpecFlow.Table(new string[] {
                            "Fields",
                            "Values"});
                table114.AddRow(new string[] {
                            "Questionnaire Template",
                            "Check Fraud"});
                table114.AddRow(new string[] {
                            "e-Consent Notice Template",
                            "smart title"});
                table114.AddRow(new string[] {
                            "Read Only Questionnaire",
                            ""});
                table114.AddRow(new string[] {
                            "Hide Send To Customer",
                            ""});
                table114.AddRow(new string[] {
                            "Hide Customer Acknowledgement Form",
                            ""});
                table114.AddRow(new string[] {
                            "Close Screen Message",
                            ""});
#line 107
 testRunner.And("User validates the following Fields in Questionaire Dialog on Edit Setting Dialog" +
                        "", ((string)(null)), table114, "And ");
#line hidden
#line 115
 testRunner.And("User clicks the Event Triggers in Settings Page on Edit Setting Dialog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table115 = new TechTalk.SpecFlow.Table(new string[] {
                            "UI Controls"});
                table115.AddRow(new string[] {
                            "Action"});
                table115.AddRow(new string[] {
                            "Trigger Name"});
                table115.AddRow(new string[] {
                            "Trigger Event Type"});
                table115.AddRow(new string[] {
                            "Add"});
#line 116
 testRunner.And("User validates the following Controls in Event Triggers on Edit Setting Dialog", ((string)(null)), table115, "And ");
#line hidden
#line 122
 testRunner.And("User clicks the Add Event Trigger in Event Triggers Page on on Edit Setting Dialo" +
                        "g", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table116 = new TechTalk.SpecFlow.Table(new string[] {
                            "Fields"});
                table116.AddRow(new string[] {
                            "Trigger Name"});
                table116.AddRow(new string[] {
                            "Trigger Event Type"});
                table116.AddRow(new string[] {
                            "Additional Condition (search for below)"});
                table116.AddRow(new string[] {
                            "Account Type"});
                table116.AddRow(new string[] {
                            "Automation Reference"});
                table116.AddRow(new string[] {
                            "Letter Template Reference"});
                table116.AddRow(new string[] {
                            "GL Reference"});
                table116.AddRow(new string[] {
                            "Run Automation"});
                table116.AddRow(new string[] {
                            "AutomationReference"});
                table116.AddRow(new string[] {
                            "Send Email Notification"});
                table116.AddRow(new string[] {
                            "Email Letter Template Reference"});
                table116.AddRow(new string[] {
                            "Email Distribution List"});
                table116.AddRow(new string[] {
                            "Close"});
                table116.AddRow(new string[] {
                            "Save"});
#line 123
 testRunner.And("User validates the following Fields in Add Trigger Page on Edit Setting Dialog", ((string)(null)), table116, "And ");
#line hidden
                TechTalk.SpecFlow.Table table117 = new TechTalk.SpecFlow.Table(new string[] {
                            "Fields",
                            "Values"});
                table117.AddRow(new string[] {
                            "Trigger Name",
                            "abc"});
                table117.AddRow(new string[] {
                            "Trigger Event Type",
                            "ab"});
                table117.AddRow(new string[] {
                            "Additional Condition (search for below)",
                            ""});
                table117.AddRow(new string[] {
                            "Account Type",
                            ""});
                table117.AddRow(new string[] {
                            "Account Type Restriction",
                            "Business"});
                table117.AddRow(new string[] {
                            "Automation Reference",
                            ""});
                table117.AddRow(new string[] {
                            "Automation Reference Box",
                            "T1"});
                table117.AddRow(new string[] {
                            "Letter Template Reference",
                            ""});
                table117.AddRow(new string[] {
                            "Template Reference",
                            "AM1"});
                table117.AddRow(new string[] {
                            "GL Reference",
                            ""});
                table117.AddRow(new string[] {
                            "GL Reference Box",
                            "FC"});
                table117.AddRow(new string[] {
                            "Run Automation",
                            ""});
                table117.AddRow(new string[] {
                            "AutomationReference",
                            "T1"});
                table117.AddRow(new string[] {
                            "Send Email Notification",
                            ""});
                table117.AddRow(new string[] {
                            "Email Letter Template Reference",
                            "ref"});
                table117.AddRow(new string[] {
                            "Email Distribution List",
                            "abc"});
#line 139
 testRunner.And("User adds the following data to fields in Add Trigger Page on Edit Setting Dialog" +
                        "", ((string)(null)), table117, "And ");
#line hidden
#line 157
 testRunner.And("User clicks the Save Button on Add Trigger Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 158
 testRunner.And("User clicks the Self-Service Verbiage in Settings Page on Edit Setting Dialog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table118 = new TechTalk.SpecFlow.Table(new string[] {
                            "Fileds"});
                table118.AddRow(new string[] {
                            "Self-Service Portal Submission Completion Title"});
                table118.AddRow(new string[] {
                            "Self-Service Portal Submission Completion Note"});
                table118.AddRow(new string[] {
                            "Close"});
                table118.AddRow(new string[] {
                            "Save"});
#line 159
 testRunner.And("User validates the following Fields in Self-Service Verbiage Page on Edit Setting" +
                        " Dialog", ((string)(null)), table118, "And ");
#line hidden
                TechTalk.SpecFlow.Table table119 = new TechTalk.SpecFlow.Table(new string[] {
                            "Fileds",
                            "Value"});
                table119.AddRow(new string[] {
                            "Self-Service Portal Submission Completion Title",
                            "Completion"});
                table119.AddRow(new string[] {
                            "Self-Service Portal Submission Completion Note",
                            "Completion"});
#line 165
 testRunner.And("User adds the following data to fields in Self-Service Verbiage Page", ((string)(null)), table119, "And ");
#line hidden
#line 169
 testRunner.And("User clicks the Save Button on Self-Service Verbiage Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 170
 testRunner.And("User validates the total number of Action Fields on Workflow Settings Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 171
 testRunner.And("User clicks the Dashboard Icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
