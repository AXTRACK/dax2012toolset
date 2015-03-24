using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DEV.AX.EditorExtensions
{
    public partial class AxEditorSettings : Form
    {
        private EditorSettings singletonSettings = null;

        #region - SETTINGS -

        private void loadSettings()
        {
            singletonSettings = EditorSettings.getInstance();

            HighlightWordProperties highlightWordProperties = new HighlightWordProperties(singletonSettings.HighlightWord);
            this.propHighlightWord.SelectedObject = highlightWordProperties;

            HighlightLineProperties highlightLineProperties = new HighlightLineProperties(singletonSettings.HighlightCurrentLine);
            this.propHighlightLine.SelectedObject = highlightLineProperties;

            nRows.Value = singletonSettings.Outlining.MaxRowsInTooltip;

            SelectedCB.Checked = singletonSettings.HighlightWord.SelectedWord;
            EnableBM.Checked = singletonSettings.GeneralSettings.EnableBM;
            EnableCL.Checked = singletonSettings.GeneralSettings.EnableCL;
            EnableWH.Checked = singletonSettings.GeneralSettings.EnableWH;
            EnableOL.Checked = singletonSettings.GeneralSettings.EnableOL;
        }

        private void saveSettings()
        {
            HighlightWordProperties propHighlightWord = (HighlightWordProperties)this.propHighlightWord.SelectedObject;
            HighlightLineProperties propHighlightLine = (HighlightLineProperties)this.propHighlightLine.SelectedObject;

            singletonSettings = EditorSettings.getInstance();

            // General
            singletonSettings.GeneralSettings.EnableBM = EnableBM.Checked;
            singletonSettings.GeneralSettings.EnableCL = EnableCL.Checked;
            singletonSettings.GeneralSettings.EnableWH = EnableWH.Checked;
            singletonSettings.GeneralSettings.EnableOL = EnableOL.Checked;

            // Highliht selected word
            singletonSettings.HighlightWord.BackColor = propHighlightWord.BackColor;
            singletonSettings.HighlightWord.FrameColor = propHighlightWord.FrameColor;
            singletonSettings.HighlightWord.SelectedWord = SelectedCB.Checked;

            // Highlight current line
            singletonSettings.HighlightCurrentLine.BackColor = propHighlightLine.BackColor;
            singletonSettings.HighlightCurrentLine.FrameColor = propHighlightLine.FrameColor;
            singletonSettings.HighlightCurrentLine.BackOpacity = propHighlightLine.BackOpacity;

            // Outlining 
            singletonSettings.Outlining.MaxRowsInTooltip = Convert.ToInt32(nRows.Value);
            
            singletonSettings.saveChanges();
        }

        #endregion

        #region - FORM -
        
        public AxEditorSettings()
        {
            InitializeComponent();

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.SelectedCB, "Highlight only selected words.");
        }

        private void AxEditorSettings_Load(object sender, EventArgs e)
        {
            this.loadSettings();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.saveSettings();
            //MessageBox.Show("Please reopen Microsot Dynamics AX client to see the changes.");
            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.btnOK, "Please reopen Microsot Dynamics AX client to see the changes.");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
