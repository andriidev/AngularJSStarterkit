﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SeleniumTest.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class _2ItemCreationFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "2 ItemCreation.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "2 ItemCreation", "\tAfter you login you can create items (active or not) to add to the list", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "2 ItemCreation")))
            {
                SeleniumTest.Features._2ItemCreationFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        public virtual void CreateActiveAndNotActiveItem(string title, string parent_Id, string active, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "login"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create active and not active item", @__tags);
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
    testRunner.Given("I click \'Add new\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Parent_id",
                        "Active"});
            table1.AddRow(new string[] {
                        string.Format("{0}", title),
                        string.Format("{0}", parent_Id),
                        string.Format("{0}", active)});
#line 7
    testRunner.When("I create new Item filling Title field, Parent_Id field and Active staus", ((string)(null)), table1, "When ");
#line 10
    testRunner.Then("I click \'Logout\' button in header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Create active and not active item: Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "2 ItemCreation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("login")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Title", "ActiveItem")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Parent_id", "1900")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Active", "true")]
        public virtual void CreateActiveAndNotActiveItem_Variant0()
        {
            this.CreateActiveAndNotActiveItem("ActiveItem", "1900", "true", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Create active and not active item: Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "2 ItemCreation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("login")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Title", "ActiveItem")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Parent_id", "1901")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Active", "false")]
        public virtual void CreateActiveAndNotActiveItem_Variant1()
        {
            this.CreateActiveAndNotActiveItem("ActiveItem", "1901", "false", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Create active and not active item: Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "2 ItemCreation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("login")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Title", "PassiveItem")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Parent_id", "2030")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Active", "true")]
        public virtual void CreateActiveAndNotActiveItem_Variant2()
        {
            this.CreateActiveAndNotActiveItem("PassiveItem", "2030", "true", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Create active and not active item: Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "2 ItemCreation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("login")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Title", "PassiveItem")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Parent_id", "2029")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Active", "false")]
        public virtual void CreateActiveAndNotActiveItem_Variant3()
        {
            this.CreateActiveAndNotActiveItem("PassiveItem", "2029", "false", ((string[])(null)));
#line hidden
        }
        
        public virtual void CanTCreateActiveAndNotActiveItem(string title, string parent_Id, string active, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "login"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Can\'t create active and not active item", @__tags);
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
    testRunner.Given("I click \'Add new\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Parent_id",
                        "Active"});
            table2.AddRow(new string[] {
                        string.Format("{0}", title),
                        string.Format("{0}", parent_Id),
                        string.Format("{0}", active)});
#line 22
    testRunner.When("I attempt to create new Item with invalid data", ((string)(null)), table2, "When ");
#line 25
    testRunner.Then("I still on New Payment page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
      testRunner.And("I click \'Logout\' button in header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Can\'t create active and not active item: Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "2 ItemCreation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("login")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Title", "ActiveItem")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Parent_id", "1899")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Active", "true")]
        public virtual void CanTCreateActiveAndNotActiveItem_Variant0()
        {
            this.CanTCreateActiveAndNotActiveItem("ActiveItem", "1899", "true", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Can\'t create active and not active item: Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "2 ItemCreation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("login")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Title", "ActiveItem")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Parent_id", "@sDt!")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Active", "false")]
        public virtual void CanTCreateActiveAndNotActiveItem_Variant1()
        {
            this.CanTCreateActiveAndNotActiveItem("ActiveItem", "@sDt!", "false", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Can\'t create active and not active item: Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "2 ItemCreation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("login")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Title", "PassiveItem")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Parent_id", "2031")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Active", "true")]
        public virtual void CanTCreateActiveAndNotActiveItem_Variant2()
        {
            this.CanTCreateActiveAndNotActiveItem("PassiveItem", "2031", "true", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Can\'t create active and not active item: Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "2 ItemCreation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("login")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Title", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Parent_id", "2030")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Active", "true")]
        public virtual void CanTCreateActiveAndNotActiveItem_Variant3()
        {
            this.CanTCreateActiveAndNotActiveItem("", "2030", "true", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
