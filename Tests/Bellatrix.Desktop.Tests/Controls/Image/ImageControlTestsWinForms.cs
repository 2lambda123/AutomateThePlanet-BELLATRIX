﻿// <copyright file="ImageControlTestsWinForms.cs" company="Automate The Planet Ltd.">
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

namespace Bellatrix.Desktop.Tests
{
    [TestClass]
    [App(Constants.WinFormsAppPath, Lifecycle.RestartEveryTime)]
    [AllureSuite("Image Control")]
    [AllureTag("WinForms")]
    public class ImageControlTestsWinForms : BellatrixBaseTest
    {
        [TestMethod]
        [TestCategory(Categories.CI)]
        [TestCategory(Categories.Desktop)]
        public void MessageChanged_When_ImageHovered_WinForms()
        {
            var image = App.ElementCreateService.CreateByAutomationId<Image>("image");

            image.Hover();

            var label = App.ElementCreateService.CreateByAutomationId<Label>("resultLabel");
            Assert.IsTrue(label.IsPresent);
        }
    }
}
