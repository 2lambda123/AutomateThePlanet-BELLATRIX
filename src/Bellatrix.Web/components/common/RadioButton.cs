﻿// <copyright file="RadioButton.cs" company="Automate The Planet Ltd.">
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
using System.Diagnostics;
using Bellatrix.Web.Contracts;
using Bellatrix.Web.Events;

namespace Bellatrix.Web
{
    public class RadioButton : Element, IElementDisabled, IElementValue, IElementChecked
    {
        public static event EventHandler<ElementActionEventArgs> Clicking;
        public static event EventHandler<ElementActionEventArgs> Clicked;
        public static event EventHandler<ElementActionEventArgs> Hovering;
        public static event EventHandler<ElementActionEventArgs> Hovered;

        public override Type ElementType => GetType();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string Value => DefaultGetValue();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool IsDisabled => GetDisabledAttribute();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool IsChecked => WrappedElement.Selected;

        public void Hover()
        {
            Hover(Hovering, Hovered);
        }

        public void Click()
        {
            Click(Clicking, Clicked);
        }
    }
}