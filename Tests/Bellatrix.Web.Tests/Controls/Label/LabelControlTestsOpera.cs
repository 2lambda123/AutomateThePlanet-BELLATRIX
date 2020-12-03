﻿// <copyright file="LabelControlTestsOpera.cs" company="Automate The Planet Ltd.">
// Copyright 2020 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>https://bellatrix.solutions/</site>
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bellatrix.Web.Tests.Controls
{
    [TestClass]
    [Browser(BrowserType.Opera, BrowserBehavior.ReuseIfStarted)]
    [AllureSuite("Label Control")]
    public class LabelControlTestsOpera : WebTest
    {
        public override void TestInit() => App.NavigationService.NavigateToLocalPage(ConfigurationService.GetSection<TestPagesSettings>().LabelLocalPage);

        [TestMethod]
        [TestCategory(Categories.Opera)]
        public void ReturnRed_When_Hover_Opera()
        {
            var labelElement = App.ElementCreateService.CreateById<Label>("myLabel");

            labelElement.Hover();

            Assert.AreEqual("color: red;", labelElement.GetStyle());
        }

        [TestMethod]
        [TestCategory(Categories.Opera)]
        public void ReturnAutomateThePlanet_When_InnerText_Opera()
        {
            var labelElement = App.ElementCreateService.CreateById<Label>("myLabel");

            Assert.AreEqual("Hover", labelElement.InnerText);
        }

        [TestMethod]
        [TestCategory(Categories.Opera)]
        public void ReturnNull_When_InnerTextNotSet_Opera()
        {
            var labelElement = App.ElementCreateService.CreateById<Label>("myLabel2");

            Assert.IsNotNull(labelElement.InnerText);
        }

        [TestMethod]
        [TestCategory(Categories.Opera)]
        public void ReturnHover_When_InnerTextSet_Opera()
        {
            var labelElement = App.ElementCreateService.CreateById<Label>("myLabel");

            Assert.AreEqual("Hover", labelElement.InnerText);
        }

        [TestMethod]
        [TestCategory(Categories.Opera)]
        public void ReturnNull_When_InnerHtmlNotSet_Opera()
        {
            var labelElement = App.ElementCreateService.CreateById<Label>("myLabel2");

            Assert.IsNotNull(labelElement.InnerHtml);
        }

        [TestMethod]
        [TestCategory(Categories.Opera)]
        public void ReturnButtonHtml_When_InnerHtmlSet_Opera()
        {
            var labelElement = App.ElementCreateService.CreateById<Label>("myLabel1");

            Assert.IsTrue(labelElement.InnerHtml.Contains("<button name=\"button\">Click me</button>"));
        }

        [TestMethod]
        [TestCategory(Categories.Opera)]
        public void ReturnNull_When_ForNotSet_Opera()
        {
            var labelElement = App.ElementCreateService.CreateById<Label>("myLabel2");

            Assert.IsNull(labelElement.For);
        }

        [TestMethod]
        [TestCategory(Categories.Opera)]
        public void ReturnLabelFor_When_ForSet_Opera()
        {
            var labelElement = App.ElementCreateService.CreateById<Label>("myLabel");

            Assert.AreEqual("myLabel", labelElement.For);
        }
    }
}