﻿// <copyright file="AndroidWebAttribute.cs" company="Automate The Planet Ltd.">
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
using System;

namespace Bellatrix.Mobile
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AndroidWebAttribute : AppAttribute
    {
        public AndroidWebAttribute(string appPath, string platformVersion, string deviceName, AppBehavior behavior = AppBehavior.NotSet)
            : base(appPath, platformVersion, deviceName, behavior)
        {
            AppConfiguration.MobileOSType = MobileOSType.Android;
            AppConfiguration.PlatformName = "Android";
            AppConfiguration.BrowserName = "Chrome";
        }

        public AndroidWebAttribute(OS osPlatform, string appPath, string platformVersion, string deviceName, AppBehavior behavior = AppBehavior.NotSet)
            : base(osPlatform, appPath, platformVersion, deviceName, behavior)
        {
            AppConfiguration.MobileOSType = MobileOSType.Android;
            AppConfiguration.PlatformName = "Android";
            AppConfiguration.BrowserName = "Chrome";
        }
    }
}
