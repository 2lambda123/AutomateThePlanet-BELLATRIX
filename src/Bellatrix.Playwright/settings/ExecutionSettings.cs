﻿// <copyright file="ExecutionSettings.cs" company="Automate The Planet Ltd.">
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

using Microsoft.Extensions.Configuration;

namespace Bellatrix.Playwright.Settings;

public class ExecutionSettings
{
    public string ExecutionType { get; set; }
    public string DefaultBrowser { get; set; }
    public string BrowserVersion { get; set; }
    public string DefaultLifeCycle { get; set; }
    public string Resolution { get; set; }
    public string GridUrl { get; set; }
    public string FileRemoteLocation { get; set; }
    public List<Capabilities> Arguments { get; set; }
    public string PackedExtensionPath { get; set; }
    public string UnpackedExtensionPath { get; set; }
    public bool IsCloudRun { get; set; }
}