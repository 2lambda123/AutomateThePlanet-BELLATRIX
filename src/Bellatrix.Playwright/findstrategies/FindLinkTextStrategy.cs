﻿// <copyright file="ByLinkText.cs" company="Automate The Planet Ltd.">
// Copyright 2024 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Miriam Kyoseva</author>
// <site>https://bellatrix.solutions/</site>

using Bellatrix.Playwright.SyncPlaywright;

namespace Bellatrix.Playwright;

public class FindLinkTextStrategy : FindStrategy
{
    public FindLinkTextStrategy(string value)
        : base(value)
    {
    }

    public override WebElement Convert(IPage searchContext)
    {
        return new WebElement(searchContext.Locator($"//a[text()='{Value}']"));
    }

    public override WebElement Convert(WebElement searchContext)
    {
        return searchContext.Locate($"//a[text()='{Value}']");
    }

    public override string ToString()
    {
        return $"LinkText = {Value}";
    }
}