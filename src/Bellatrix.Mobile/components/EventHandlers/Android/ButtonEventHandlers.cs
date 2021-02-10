﻿// <copyright file="ButtonEventHandlers.cs" company="Automate The Planet Ltd.">
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
using Bellatrix.Mobile.Android;
using Bellatrix.Mobile.Events;
using OpenQA.Selenium.Appium.Android;

namespace Bellatrix.Mobile.EventHandlers.Android
{
    public class ButtonEventHandlers : ElementEventHandlers
    {
        public override void SubscribeToAll()
        {
            base.SubscribeToAll();
            Button.Clicking += ClickingEventHandler;
            Button.Clicked += ClickedEventHandler;
        }

        public override void UnsubscribeToAll()
        {
            base.UnsubscribeToAll();
            Button.Clicking -= ClickingEventHandler;
            Button.Clicked -= ClickedEventHandler;
        }

        protected virtual void ClickingEventHandler(object sender, ElementActionEventArgs<AndroidElement> arg)
        {
        }

        protected virtual void ClickedEventHandler(object sender, ElementActionEventArgs<AndroidElement> arg)
        {
        }
    }
}
