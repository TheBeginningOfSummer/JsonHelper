namespace JsonHelper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OFD_JsonDoc = new System.Windows.Forms.OpenFileDialog();
            this.TS_JsonTool = new System.Windows.Forms.ToolStrip();
            this.TSB_OpenFile = new System.Windows.Forms.ToolStripButton();
            this.TSB_JsonSerialize = new System.Windows.Forms.ToolStripButton();
            this.TSTB_FileName = new System.Windows.Forms.ToolStripTextBox();
            this.TSL_FileName = new System.Windows.Forms.ToolStripLabel();
            this.TSB_JsonDeserialize = new System.Windows.Forms.ToolStripButton();
            this.TSB_SetData = new System.Windows.Forms.ToolStripButton();
            this.TB_JsonText = new System.Windows.Forms.TextBox();
            this.TB_JsonData = new System.Windows.Forms.TextBox();
            this.TS_JsonTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // OFD_JsonDoc
            // 
            this.OFD_JsonDoc.FileName = "Json";
            // 
            // TS_JsonTool
            // 
            this.TS_JsonTool.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_JsonTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_OpenFile,
            this.TSB_JsonSerialize,
            this.TSTB_FileName,
            this.TSL_FileName,
            this.TSB_JsonDeserialize,
            this.TSB_SetData});
            this.TS_JsonTool.Location = new System.Drawing.Point(0, 0);
            this.TS_JsonTool.Name = "TS_JsonTool";
            this.TS_JsonTool.Size = new System.Drawing.Size(800, 25);
            this.TS_JsonTool.TabIndex = 0;
            this.TS_JsonTool.Text = "toolStrip1";
            // 
            // TSB_OpenFile
            // 
            this.TSB_OpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("TSB_OpenFile.Image")));
            this.TSB_OpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_OpenFile.Name = "TSB_OpenFile";
            this.TSB_OpenFile.Size = new System.Drawing.Size(36, 22);
            this.TSB_OpenFile.Text = "打开";
            this.TSB_OpenFile.Click += new System.EventHandler(this.TSB_OpenFile_Click);
            // 
            // TSB_JsonSerialize
            // 
            this.TSB_JsonSerialize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_JsonSerialize.Image = ((System.Drawing.Image)(resources.GetObject("TSB_JsonSerialize.Image")));
            this.TSB_JsonSerialize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_JsonSerialize.Name = "TSB_JsonSerialize";
            this.TSB_JsonSerialize.Size = new System.Drawing.Size(72, 22);
            this.TSB_JsonSerialize.Text = "序列化存档";
            this.TSB_JsonSerialize.Click += new System.EventHandler(this.TSB_JsonSerialize_Click);
            // 
            // TSTB_FileName
            // 
            this.TSTB_FileName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSTB_FileName.Name = "TSTB_FileName";
            this.TSTB_FileName.Size = new System.Drawing.Size(100, 25);
            this.TSTB_FileName.Text = "Test";
            // 
            // TSL_FileName
            // 
            this.TSL_FileName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSL_FileName.Name = "TSL_FileName";
            this.TSL_FileName.Size = new System.Drawing.Size(92, 22);
            this.TSL_FileName.Text = "存档文件名称：";
            // 
            // TSB_JsonDeserialize
            // 
            this.TSB_JsonDeserialize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_JsonDeserialize.Image = ((System.Drawing.Image)(resources.GetObject("TSB_JsonDeserialize.Image")));
            this.TSB_JsonDeserialize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_JsonDeserialize.Name = "TSB_JsonDeserialize";
            this.TSB_JsonDeserialize.Size = new System.Drawing.Size(60, 22);
            this.TSB_JsonDeserialize.Text = "反序列化";
            this.TSB_JsonDeserialize.Click += new System.EventHandler(this.TSB_JsonDeserialize_Click);
            // 
            // TSB_SetData
            // 
            this.TSB_SetData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSB_SetData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_SetData.Image = ((System.Drawing.Image)(resources.GetObject("TSB_SetData.Image")));
            this.TSB_SetData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_SetData.Name = "TSB_SetData";
            this.TSB_SetData.Size = new System.Drawing.Size(60, 22);
            this.TSB_SetData.Text = "设置数据";
            this.TSB_SetData.Click += new System.EventHandler(this.TSB_SetData_Click);
            // 
            // TB_JsonText
            // 
            this.TB_JsonText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_JsonText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_JsonText.Location = new System.Drawing.Point(0, 28);
            this.TB_JsonText.Multiline = true;
            this.TB_JsonText.Name = "TB_JsonText";
            this.TB_JsonText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_JsonText.Size = new System.Drawing.Size(600, 420);
            this.TB_JsonText.TabIndex = 1;
            // 
            // TB_JsonData
            // 
            this.TB_JsonData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_JsonData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_JsonData.Location = new System.Drawing.Point(606, 28);
            this.TB_JsonData.Multiline = true;
            this.TB_JsonData.Name = "TB_JsonData";
            this.TB_JsonData.ReadOnly = true;
            this.TB_JsonData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_JsonData.Size = new System.Drawing.Size(194, 420);
            this.TB_JsonData.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB_JsonData);
            this.Controls.Add(this.TB_JsonText);
            this.Controls.Add(this.TS_JsonTool);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JsonHelper";
            this.TS_JsonTool.ResumeLayout(false);
            this.TS_JsonTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog OFD_JsonDoc;
        private ToolStrip TS_JsonTool;
        private ToolStripButton TSB_OpenFile;
        private TextBox TB_JsonText;
        private ToolStripButton TSB_JsonSerialize;
        private ToolStripTextBox TSTB_FileName;
        private ToolStripLabel TSL_FileName;
        private ToolStripButton TSB_JsonDeserialize;
        private ToolStripButton TSB_SetData;
        private TextBox TB_JsonData;
    }
}