using System;
using System.Windows.Media;

namespace DEV.AX.EditorExtensions
{
    [Serializable()]
    public class DEV_CurrentLineHighlightSettings
    {
        public Colour BackColor { get; set; }
        public Colour FrameColor { get; set; }
        public double BackOpacity { get; set; }

        public DEV_CurrentLineHighlightSettings()
        {
            this.BackColor = new Colour(System.Drawing.Color.Lavender);
            this.FrameColor = new Colour(System.Drawing.Color.Lavender);
            this.BackOpacity = 0.2;
        }
    }
}
