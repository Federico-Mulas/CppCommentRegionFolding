using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Editor;

namespace CppCommentRegionFolding
{
    [Export(typeof(IClassifierProvider))]
    [ContentType("C/C++")]
    [Order(After = "Default")]
    [TextViewRole(PredefinedTextViewRoles.Document)]
    internal class RegionClassifierProvider : IClassifierProvider
    {

        [Import]
        public IClassificationTypeRegistryService Registry { get; set; }
        // #region Something
        public IClassifier GetClassifier(ITextBuffer textBuffer)
        {
            return textBuffer.Properties.GetOrCreateSingletonProperty(() => new RegionClassifier(Registry));
        }

        // #endregion
    }
}
