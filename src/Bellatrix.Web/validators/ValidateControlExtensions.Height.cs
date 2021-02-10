﻿// <copyright file="ValidateControlExtensions.Height.cs" company="Automate The Planet Ltd.">
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
using Bellatrix.Web.Contracts;
using Bellatrix.Web.Events;

namespace Bellatrix.Web
{
    public static partial class ValidateControlExtensions
    {
        public static void ValidateHeightIsNull<T>(this T control, int? timeout = null, int? sleepInterval = null)
            where T : IElementHeight, IElement
        {
            WaitUntil(() => control.Height == null, $"The control's height should be null but was '{control.Height}'.", timeout, sleepInterval);
            ValidatedHeightIsNullEvent?.Invoke(control, new ElementActionEventArgs(control));
        }

        public static void ValidateHeightIsNotNull<T>(this T control, int? timeout = null, int? sleepInterval = null)
            where T : IElementHeight, IElement
        {
            WaitUntil(() => control.Height != null, "The control's height should be NOT be null but it was.", timeout, sleepInterval);
            ValidatedHeightIsNotNullEvent?.Invoke(control, new ElementActionEventArgs(control));
        }

        public static event EventHandler<ElementActionEventArgs> ValidatedHeightIsNullEvent;
        public static event EventHandler<ElementActionEventArgs> ValidatedHeightIsNotNullEvent;
    }
}