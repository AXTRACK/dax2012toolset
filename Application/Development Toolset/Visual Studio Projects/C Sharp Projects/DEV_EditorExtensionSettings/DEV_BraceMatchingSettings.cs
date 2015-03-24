using System;
using System.Drawing;

namespace DEV.AX.EditorExtensions
{
    [Serializable()]
    public class DEV_BraceMatchingSettings
    {
        public Color BackColor { get; set; }
        public Color FrameColor { get; set; }

        public DEV_BraceMatchingSettings()
        {
            this.BackColor = Color.Silver;
            this.FrameColor = Color.Black;
        }

    }
}
