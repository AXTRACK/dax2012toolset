using Microsoft.VisualStudio.Text.Tagging;

namespace DEV.AX.EditorExtensions
{
    internal class HighlightWordTag : TextMarkerTag
    {
        public HighlightWordTag() : base("MarkerFormatDefinition/HighlightWordFormatDefinition") { }
    }
}
