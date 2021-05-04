﻿namespace Bellatrix.Web.GettingStarted.ExtensionMethodsLocators
{
    // 1. To ease the usage of the locator, we need to create extension methods of ElementCreateService.
    // This is everything after that you can use your new locator as it was originally part of Bellatrix.
    public static class ElementCreateExtensions
    {
        // public static TElement CreateByIdStartingWith<TElement>(this Element element, string idPrefix)
        // where TElement : Element => ElementCreateService.Create<TElement, FindIdStartingWithStrategy>(new FindIdStartingWithStrategy(idPrefix));
        public static ComponentsList<TElement> CreateAllByIdStartingWith<TElement>(this Component element, string idEnding)
            where TElement : Component => new ComponentsList<TElement>(new FindIdStartingWithStrategy(idEnding), element.WrappedElement);
    }
}