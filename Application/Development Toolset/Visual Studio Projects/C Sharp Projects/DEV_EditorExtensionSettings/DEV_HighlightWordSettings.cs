using System;
using System.Drawing;

namespace DEV.AX.EditorExtensions
{
    [Serializable()]
    public class DEV_HighlightWordSettings
    {
        public Color BackColor { get; set; }
        public Color FrameColor { get; set; }
        public Boolean SelectedWord { get; set; }

        public DEV_HighlightWordSettings()
        {
            this.BackColor = Color.PaleGoldenrod;
            this.FrameColor = Color.PaleGoldenrod;
            this.SelectedWord = true;
        }
    }
}
