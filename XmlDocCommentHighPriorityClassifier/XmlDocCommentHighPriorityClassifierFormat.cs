//------------------------------------------------------------------------------
// <copyright file="XmlDocCommentHighPriorityClassifierFormat.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace XmlDocCommentHighPriorityClassifier
{
    /// <summary>
    /// Defines an editor format for the XmlDocCommentHighPriorityClassifier type that has a purple background
    /// and is underlined.
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "XmlDocCommentHighPriorityClassifier")]
    [Name("XmlDocCommentHighPriorityClassifier")]
    [UserVisible(true)] // This should be visible to the end user
    [Order(After = Priority.High)] // Set the priority to be above the default classifiers. Necessary for uniform text coloring
    internal sealed class XmlDocCommentHighPriorityClassifierFormat : ClassificationFormatDefinition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XmlDocCommentHighPriorityClassifierFormat"/> class.
        /// </summary>
        public XmlDocCommentHighPriorityClassifierFormat()
        {
            this.DisplayName = "XML Doc Comment (High priority)";
            this.ForegroundColor = Colors.LightGray;
        }
    }
}
