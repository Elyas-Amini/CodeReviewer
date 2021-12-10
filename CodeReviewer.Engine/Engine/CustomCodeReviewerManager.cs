﻿using CodeReviewer.Reviewers.Customizations;
using CodeReviewer.Structures;
using System;
using System.Collections.Generic;

namespace CodeReviewer.Engine
{
    public static class CustomCodeReviewerManager
    {
        public static List<IReviewer> CustomCodeReviewer { get; } = new List<IReviewer>();

        /// <summary>
        /// check suffix text naming of custom types
        /// </summary>
        /// <param name="suffixes">suffixes names you want to be in end of type name conventions</param>
        /// <param name="checkTypeReviewerFunc">everytypes come here, return true for any type you want check this suffix</param>
        /// <param name="checkType">types of you want to check in c#</param>
        public static void AddCustomTypeSuffixNamingCodeReviewer(Func<Type, bool> checkTypeReviewerFunc, CheckType checkType, StringComparison stringComparison, params string[] suffixes)
        {
            CustomTypeSuffixAndPrefixNamingCodeReviewer reviewer = new CustomTypeSuffixAndPrefixNamingCodeReviewer();
            reviewer.InitializeSuffix(checkTypeReviewerFunc, null, checkType, stringComparison, suffixes);
            CustomCodeReviewer.Add(reviewer);
        }

        /// <summary>
        /// check suffix text naming of custom types
        /// </summary>
        /// <param name="suffixes">suffixes names you want to be in end of type name conventions</param>
        /// <param name="checkTypeReviewerFunc">everytypes come here, return true for any type you want check this suffix</param>
        /// <param name="checkInsideOfTypeReviewerFunc">everytypes inside of the main type come here, return true for any type you want check this suffix</param>
        /// <param name="checkType">types of you want to check in c#</param>
        public static void AddCustomInsideOfTypeSuffixNamingCodeReviewer(Func<Type, bool> checkTypeReviewerFunc, Func<Type, bool> checkInsideOfTypeReviewerFunc, CheckType checkType, StringComparison stringComparison, params string[] suffixes)
        {
            CustomTypeSuffixAndPrefixNamingCodeReviewer reviewer = new CustomTypeSuffixAndPrefixNamingCodeReviewer();
            reviewer.InitializeSuffix(checkTypeReviewerFunc, checkInsideOfTypeReviewerFunc, checkType, stringComparison, suffixes);
            CustomCodeReviewer.Add(reviewer);
        }

        /// <summary>
        /// check prefix text naming of custom types
        /// </summary>
        /// <param name="prefixes">prefixes names you want to be in end of type name conventions</param>
        /// <param name="checkTypeReviewerFunc">everytypes come here, return true for any type you want check this prefix</param>
        /// <param name="checkType">types of you want to check in c#</param>
        public static void AddCustomTypePrefixNamingCodeReviewer(Func<Type, bool> checkTypeReviewerFunc, CheckType checkType, StringComparison stringComparison, params string[] prefixes)
        {
            CustomTypeSuffixAndPrefixNamingCodeReviewer reviewer = new CustomTypeSuffixAndPrefixNamingCodeReviewer();
            reviewer.InitializePrefix(checkTypeReviewerFunc, null, checkType, stringComparison, prefixes);
            CustomCodeReviewer.Add(reviewer);
        }

        /// <summary>
        /// check prefix text naming of custom types
        /// </summary>
        /// <param name="prefixes">prefixes names you want to be in end of type name conventions</param>
        /// <param name="checkTypeReviewerFunc">everytypes come here, return true for any type you want check this prefix</param>
        /// <param name="checkInsideOfTypeReviewerFunc">everytypes inside of the main type come here, return true for any type you want check this prefix</param>
        /// <param name="checkType">types of you want to check in c#</param>
        public static void AddCustomInsideOfTypePrefixNamingCodeReviewer(Func<Type, bool> checkTypeReviewerFunc, Func<Type, bool> checkInsideOfTypeReviewerFunc, CheckType checkType, StringComparison stringComparison, params string[] prefixes)
        {
            CustomTypeSuffixAndPrefixNamingCodeReviewer reviewer = new CustomTypeSuffixAndPrefixNamingCodeReviewer();
            reviewer.InitializePrefix(checkTypeReviewerFunc, checkInsideOfTypeReviewerFunc, checkType, stringComparison, prefixes);
            CustomCodeReviewer.Add(reviewer);
        }
    }
}
