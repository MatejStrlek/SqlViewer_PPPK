namespace SqlViewer.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            tsbSelect = new ToolStripButton();
            tsbSave = new ToolStripButton();
            tsbExec = new ToolStripButton();
            tvServer = new TreeView();
            tbContent = new TextBox();
            tbResult = new TextBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbSelect, tsbSave, tsbExec });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0);
            toolStrip1.Size = new Size(689, 47);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbSelect
            // 
            tsbSelect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSelect.Image = (Image)resources.GetObject("tsbSelect.Image");
            tsbSelect.ImageTransparentColor = Color.Magenta;
            tsbSelect.Name = "tsbSelect";
            tsbSelect.Size = new Size(44, 44);
            tsbSelect.Text = "Select";
            tsbSelect.Click += TsbSelect_Click;
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSave.Image = (Image)resources.GetObject("tsbSave.Image");
            tsbSave.ImageTransparentColor = Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(44, 44);
            tsbSave.Text = "Save";
            tsbSave.Click += TsbSave_Click;
            // 
            // tsbExec
            // 
            tsbExec.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbExec.Image = (Image)resources.GetObject("tsbExec.Image");
            tsbExec.ImageTransparentColor = Color.Magenta;
            tsbExec.Name = "tsbExec";
            tsbExec.Size = new Size(44, 44);
            tsbExec.Click += tsbExec_Click;
            // 
            // tvServer
            // 
            tvServer.Location = new Point(19, 64);
            tvServer.Margin = new Padding(1);
            tvServer.Name = "tvServer";
            tvServer.Size = new Size(230, 592);
            tvServer.TabIndex = 1;
            tvServer.AfterCollapse += TvServer_AfterCollapse;
            tvServer.BeforeExpand += TvServer_BeforeExpand;
            // 
            // tbContent
            // 
            tbContent.Location = new Point(279, 64);
            tbContent.Margin = new Padding(1);
            tbContent.Multiline = true;
            tbContent.Name = "tbContent";
            tbContent.ScrollBars = ScrollBars.Vertical;
            tbContent.Size = new Size(372, 331);
            tbContent.TabIndex = 2;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(279, 431);
            tbResult.Multiline = true;
            tbResult.Name = "tbResult";
            tbResult.ScrollBars = ScrollBars.Vertical;
            tbResult.Size = new Size(372, 225);
            tbResult.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 685);
            Controls.Add(tbResult);
            Controls.Add(tbContent);
            Controls.Add(tvServer);
            Controls.Add(toolStrip1);
            Margin = new Padding(1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SSMS";
            FormClosed += MainForm_FormClosed;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbSelect;
        private ToolStripButton tsbSave;
        private TreeView tvServer;
        private TextBox tbContent;
        private ToolStripButton tsbExec;
        private TextBox tbResult;
    }
}