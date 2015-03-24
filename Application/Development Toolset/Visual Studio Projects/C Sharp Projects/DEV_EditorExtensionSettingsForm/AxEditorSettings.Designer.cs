﻿namespace DEV.AX.EditorExtensions
{
    partial class AxEditorSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AxEditorSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.propHighlightWord = new System.Windows.Forms.PropertyGrid();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.tabPageHighlightWords = new System.Windows.Forms.TabPage();
            this.SelectedCB = new System.Windows.Forms.CheckBox();
            this.tabPageHighlightLine = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.propHighlightLine = new System.Windows.Forms.PropertyGrid();
            this.tabPageOutlining = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nRows = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.GeneralGB = new System.Windows.Forms.GroupBox();
            this.EnableOL = new System.Windows.Forms.CheckBox();
            this.EnableWH = new System.Windows.Forms.CheckBox();
            this.EnableCL = new System.Windows.Forms.CheckBox();
            this.EnableBM = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tabPageHighlightWords.SuspendLayout();
            this.tabPageHighlightLine.SuspendLayout();
            this.tabPageOutlining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRows)).BeginInit();
            this.GeneralGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Highlight selected word";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(263, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Location = new System.Drawing.Point(182, 286);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // propHighlightWord
            // 
            this.propHighlightWord.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.propHighlightWord.Location = new System.Drawing.Point(11, 31);
            this.propHighlightWord.Name = "propHighlightWord";
            this.propHighlightWord.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propHighlightWord.Size = new System.Drawing.Size(296, 176);
            this.propHighlightWord.TabIndex = 8;
            this.propHighlightWord.ToolbarVisible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGeneral);
            this.tabControl1.Controls.Add(this.tabPageHighlightWords);
            this.tabControl1.Controls.Add(this.tabPageHighlightLine);
            this.tabControl1.Controls.Add(this.tabPageOutlining);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(325, 268);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.GeneralGB);
            this.tabPageGeneral.Controls.Add(this.label6);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(317, 242);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // tabPageHighlightWords
            // 
            this.tabPageHighlightWords.Controls.Add(this.SelectedCB);
            this.tabPageHighlightWords.Controls.Add(this.label1);
            this.tabPageHighlightWords.Controls.Add(this.propHighlightWord);
            this.tabPageHighlightWords.Location = new System.Drawing.Point(4, 22);
            this.tabPageHighlightWords.Name = "tabPageHighlightWords";
            this.tabPageHighlightWords.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHighlightWords.Size = new System.Drawing.Size(317, 242);
            this.tabPageHighlightWords.TabIndex = 1;
            this.tabPageHighlightWords.Text = "Highlight Words";
            this.tabPageHighlightWords.UseVisualStyleBackColor = true;
            // 
            // SelectedCB
            // 
            this.SelectedCB.AutoSize = true;
            this.SelectedCB.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.SelectedCB.Location = new System.Drawing.Point(11, 213);
            this.SelectedCB.Name = "SelectedCB";
            this.SelectedCB.Size = new System.Drawing.Size(141, 23);
            this.SelectedCB.TabIndex = 9;
            this.SelectedCB.Text = "Highlight selected ";
            this.SelectedCB.UseVisualStyleBackColor = true;
            // 
            // tabPageHighlightLine
            // 
            this.tabPageHighlightLine.Controls.Add(this.label3);
            this.tabPageHighlightLine.Controls.Add(this.propHighlightLine);
            this.tabPageHighlightLine.Location = new System.Drawing.Point(4, 22);
            this.tabPageHighlightLine.Name = "tabPageHighlightLine";
            this.tabPageHighlightLine.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHighlightLine.Size = new System.Drawing.Size(317, 242);
            this.tabPageHighlightLine.TabIndex = 3;
            this.tabPageHighlightLine.Text = "Highlight Line";
            this.tabPageHighlightLine.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Highlight current line color settings";
            // 
            // propHighlightLine
            // 
            this.propHighlightLine.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.propHighlightLine.Location = new System.Drawing.Point(11, 31);
            this.propHighlightLine.Name = "propHighlightLine";
            this.propHighlightLine.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propHighlightLine.Size = new System.Drawing.Size(296, 196);
            this.propHighlightLine.TabIndex = 10;
            this.propHighlightLine.ToolbarVisible = false;
            // 
            // tabPageOutlining
            // 
            this.tabPageOutlining.Controls.Add(this.label4);
            this.tabPageOutlining.Controls.Add(this.label2);
            this.tabPageOutlining.Controls.Add(this.label5);
            this.tabPageOutlining.Controls.Add(this.nRows);
            this.tabPageOutlining.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutlining.Name = "tabPageOutlining";
            this.tabPageOutlining.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutlining.Size = new System.Drawing.Size(317, 242);
            this.tabPageOutlining.TabIndex = 2;
            this.tabPageOutlining.Text = "Outlining";
            this.tabPageOutlining.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Outlining sections of code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(158, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "0 is no limit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label5.Location = new System.Drawing.Point(7, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Max tooltip size (rows):";
            // 
            // nRows
            // 
            this.nRows.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.nRows.Location = new System.Drawing.Point(161, 57);
            this.nRows.Name = "nRows";
            this.nRows.Size = new System.Drawing.Size(53, 27);
            this.nRows.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Setup editor extensions";
            // 
            // GeneralGB
            // 
            this.GeneralGB.Controls.Add(this.EnableOL);
            this.GeneralGB.Controls.Add(this.EnableWH);
            this.GeneralGB.Controls.Add(this.EnableCL);
            this.GeneralGB.Controls.Add(this.EnableBM);
            this.GeneralGB.Location = new System.Drawing.Point(11, 35);
            this.GeneralGB.Name = "GeneralGB";
            this.GeneralGB.Size = new System.Drawing.Size(230, 154);
            this.GeneralGB.TabIndex = 15;
            this.GeneralGB.TabStop = false;
            // 
            // EnableOL
            // 
            this.EnableOL.AutoSize = true;
            this.EnableOL.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.EnableOL.Location = new System.Drawing.Point(6, 102);
            this.EnableOL.Name = "EnableOL";
            this.EnableOL.Size = new System.Drawing.Size(126, 23);
            this.EnableOL.TabIndex = 17;
            this.EnableOL.Text = "Enable outlining";
            this.EnableOL.UseVisualStyleBackColor = true;
            // 
            // EnableWH
            // 
            this.EnableWH.AutoSize = true;
            this.EnableWH.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.EnableWH.Location = new System.Drawing.Point(6, 73);
            this.EnableWH.Name = "EnableWH";
            this.EnableWH.Size = new System.Drawing.Size(161, 23);
            this.EnableWH.TabIndex = 16;
            this.EnableWH.Text = "Enable word highlight";
            this.EnableWH.UseVisualStyleBackColor = true;
            // 
            // EnableCL
            // 
            this.EnableCL.AutoSize = true;
            this.EnableCL.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.EnableCL.Location = new System.Drawing.Point(6, 44);
            this.EnableCL.Name = "EnableCL";
            this.EnableCL.Size = new System.Drawing.Size(199, 23);
            this.EnableCL.TabIndex = 15;
            this.EnableCL.Text = "Enable current line highlight";
            this.EnableCL.UseVisualStyleBackColor = true;
            // 
            // EnableBM
            // 
            this.EnableBM.AutoSize = true;
            this.EnableBM.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.EnableBM.Location = new System.Drawing.Point(6, 15);
            this.EnableBM.Name = "EnableBM";
            this.EnableBM.Size = new System.Drawing.Size(166, 23);
            this.EnableBM.TabIndex = 14;
            this.EnableBM.Text = "Enable brace matching";
            this.EnableBM.UseVisualStyleBackColor = true;
            // 
            // AxEditorSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(350, 321);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AxEditorSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AX 2012 Editor Extensions";
            this.Load += new System.EventHandler(this.AxEditorSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.tabPageHighlightWords.ResumeLayout(false);
            this.tabPageHighlightWords.PerformLayout();
            this.tabPageHighlightLine.ResumeLayout(false);
            this.tabPageHighlightLine.PerformLayout();
            this.tabPageOutlining.ResumeLayout(false);
            this.tabPageOutlining.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRows)).EndInit();
            this.GeneralGB.ResumeLayout(false);
            this.GeneralGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PropertyGrid propHighlightWord;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageHighlightWords;
        private System.Windows.Forms.TabPage tabPageOutlining;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nRows;
        private System.Windows.Forms.TabPage tabPageHighlightLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PropertyGrid propHighlightLine;
        private System.Windows.Forms.CheckBox SelectedCB;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.GroupBox GeneralGB;
        private System.Windows.Forms.CheckBox EnableOL;
        private System.Windows.Forms.CheckBox EnableWH;
        private System.Windows.Forms.CheckBox EnableCL;
        private System.Windows.Forms.CheckBox EnableBM;
        private System.Windows.Forms.Label label6;
    }
}

