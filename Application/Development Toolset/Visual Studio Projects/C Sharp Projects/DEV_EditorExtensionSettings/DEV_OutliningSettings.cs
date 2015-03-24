using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEV.AX.EditorExtensions
{
    [Serializable()]
    public class DEV_OutliningSettings
    {
        public int MaxRowsInTooltip { get; set; }

        public DEV_OutliningSettings()
        {
            this.MaxRowsInTooltip = 20;
        }
    }
}
