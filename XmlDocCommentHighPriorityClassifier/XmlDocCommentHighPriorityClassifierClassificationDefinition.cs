//------------------------------------------------------------------------------
// <copyright file="XmlDocCommentHighPriorityClassifierClassificationDefinition.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace XmlDocCommentHighPriorityClassifier
{
    /// <summary>
    /// Classification type definition export for XmlDocCommentHighPriorityClassifier
    /// </summary>
    internal static class XmlDocCommentHighPriorityClassifierClassificationDefinition
    {
        // This disables "The field is never used" compiler's warning. Justification: the field is used by MEF.
#pragma warning disable 169

        /// <summary>
        /// Defines the "XmlDocCommentHighPriorityClassifier" classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("XmlDocCommentHighPriorityClassifier")]
        private static ClassificationTypeDefinition typeDefinition;

#pragma warning restore 169
    }
}
