using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace CppCommentRegionFolding
{
    internal static class RegionClassifierClassificationDefinition
    {
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("RegionClassifier")]
        private static ClassificationTypeDefinition typeDefinition;
    }
}
