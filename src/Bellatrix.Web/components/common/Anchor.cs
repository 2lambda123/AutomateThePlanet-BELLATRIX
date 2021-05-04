﻿// <copyright file="Anchor.cs" company="Automate The Planet Ltd.">
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
using System.Web;
using Bellatrix.Web.Contracts;
using Bellatrix.Web.Events;

namespace Bellatrix.Web
{
    public class Anchor : Component, IElementHref, IElementInnerText, IElementInnerHtml, IElementRel, IElementTarget
    {
        public static event EventHandler<ElementActionEventArgs> Clicking;
        public static event EventHandler<ElementActionEventArgs> Clicked;
        public static event EventHandler<ElementActionEventArgs> Hovering;
        public static event EventHandler<ElementActionEventArgs> Hovered;

        public override Type ElementType => GetType();

        public void Click()
        {
            Click(Clicking, Clicked);
        }

        public void Hover()
        {
            Hover(Hovering, Hovered);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string Href => HttpUtility.HtmlDecode(HttpUtility.UrlDecode(GetAttribute("href")));

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string InnerText => GetInnerText();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string InnerHtml => GetInnerHtmlAttribute();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string Target => WrappedElement.GetAttribute("target");

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string Rel => WrappedElement.GetAttribute("rel");
    }
}