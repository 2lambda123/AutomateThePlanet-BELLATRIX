﻿// <copyright file="ByAndroidUIAutomator.cs" company="Automate The Planet Ltd.">
// Copyright 2021 Automate The Planet Ltd.
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
using System.Collections.Generic;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Bellatrix.Mobile.Locators.Android
{
    public class FindAndroidUIAutomatorStrategy : FindStrategy<AndroidDriver<AndroidElement>, AndroidElement>
    {
        public FindAndroidUIAutomatorStrategy(string name)
            : base(name)
        {
        }

        public override AndroidElement FindElement(AndroidDriver<AndroidElement> searchContext)
        {
            return searchContext.FindElementByAndroidUIAutomator(Value);
        }

        public override IEnumerable<AndroidElement> FindAllElements(AndroidDriver<AndroidElement> searchContext) => searchContext.FindElementsByAndroidUIAutomator(Value);

        public override AppiumWebElement FindElement(AndroidElement element)
        {
            return element.FindElementByAndroidUIAutomator(Value);
        }

        public override IEnumerable<AppiumWebElement> FindAllElements(AndroidElement element)
        {
            return element.FindElementsByAndroidUIAutomator(Value);
        }

        public override string ToString()
        {
            return $"AndroidUIAutomator = {Value}";
        }
    }
}
