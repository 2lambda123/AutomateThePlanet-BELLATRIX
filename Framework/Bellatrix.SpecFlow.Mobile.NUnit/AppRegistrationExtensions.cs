﻿// <copyright file="AppRegistrationExtensions.cs" company="Automate The Planet Ltd.">
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
using System;
using Bellatrix.Application;
using Bellatrix.Assertions;
using Bellatrix.Mobile.Screenshots;
using Bellatrix.SpecFlow.NUnit;
using Bellatrix.SpecFlow.TestWorkflowPlugins;
using Bellatrix.TestExecutionExtensions.Screenshots;
using Bellatrix.TestExecutionExtensions.Screenshots.Contracts;

namespace Bellatrix.Mobile.SpecFlow
{
    public static class AppRegistrationExtensions
    {
        public static BaseApp UseNUnitSettings(this BaseApp baseApp)
        {
            ServicesCollection.Current.RegisterType<IAssert, NUnitAssert>();
            ServicesCollection.Current.RegisterType<ICollectionAssert, NUnitCollectionAssert>();
            return baseApp;
        }

        public static BaseApp UseScreenshotsOnFail(this BaseApp baseApp)
        {
            baseApp.RegisterType<IScreenshotEngine, AndroidDriverScreenshotEngine>();
            baseApp.RegisterType<IScreenshotEngine, IOSDriverScreenshotEngine>();
            baseApp.RegisterType<IScreenshotOutputProvider, ScreenshotOutputProvider>();
            baseApp.RegisterType<Bellatrix.SpecFlow.TestExecutionExtensions.Screenshots.IScreenshotPluginProvider, Bellatrix.SpecFlow.TestExecutionExtensions.Screenshots.ScreenshotPluginProvider>();
            baseApp.RegisterType<TestWorkflowPlugin, Bellatrix.SpecFlow.TestExecutionExtensions.Screenshots.ScreenshotWorkflowPlugin>(Guid.NewGuid().ToString());
            return baseApp;
        }
    }
}