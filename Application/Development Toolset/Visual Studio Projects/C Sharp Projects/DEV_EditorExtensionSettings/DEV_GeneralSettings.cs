using System;
using System.Drawing;

namespace DEV.AX.EditorExtensions
{
    [Serializable()]
    public class DEV_GeneralSettings
    {
        public Boolean EnableBM { get; set; }
        public Boolean EnableCL { get; set; }
        public Boolean EnableWH { get; set; }
        public Boolean EnableOL { get; set; }
        
        public DEV_GeneralSettings()
        {
            this.EnableBM = true;
            this.EnableCL = true;
            this.EnableWH = true;
            this.EnableOL = true;
        }
    }
}
