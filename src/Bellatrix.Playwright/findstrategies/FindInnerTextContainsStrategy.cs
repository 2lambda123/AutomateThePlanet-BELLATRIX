﻿// <copyright file="ByInnerTextContains.cs" company="Automate The Planet Ltd.">
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

namespace Bellatrix.Playwright;

public class FindInnerTextContainsStrategy : FindStrategy
{
    public FindInnerTextContainsStrategy(string value)
        : base(value)
    {
    }

    public override ILocator Convert(IPage searchContext)
    {
        return searchContext.Locator($"//*[contains(text(), '{Value}')]");
    }
    public override ILocator Convert(ILocator searchContext)
    {
        return searchContext.Locator($"//*[contains(text(), '{Value}')]");
    }

    public override string ToString()
    {
        return $"InnerText containing {Value}";
    }
}