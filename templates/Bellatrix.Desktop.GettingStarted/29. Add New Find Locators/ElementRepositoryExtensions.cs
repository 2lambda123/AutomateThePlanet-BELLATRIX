﻿using Bellatrix.Desktop.Controls.Core;

namespace Bellatrix.Desktop.GettingStarted.ExtensionMethodsLocators
{
    // 1. To ease the usage of the locator, we need to create extension methods of ElementCreateService.
    // This is everything after that you can use your new locator as it was originally part of Bellatrix.
    public static class ElementRepositoryExtensions
    {
        public static TElement CreateByNameStartingWith<TElement>(this ElementCreateService repo, string tag)
            where TElement : Component => repo.Create<TElement, FindNameStartingWithStrategy>(new FindNameStartingWithStrategy(tag));

        public static ComponentsList<TElement> CreateAllByNameStartingWith<TElement>(this ElementCreateService repo, string tag)
            where TElement : Component => new ComponentsList<TElement>(new FindNameStartingWithStrategy(tag), null);
    }
}
