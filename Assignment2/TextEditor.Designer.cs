namespace Assignment2
{
    partial class TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TMSNew = new System.Windows.Forms.ToolStripMenuItem();
            this.TMSOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TMSSave = new System.Windows.Forms.ToolStripMenuItem();
            this.TMSSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TMSLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TMSCut = new System.Windows.Forms.ToolStripMenuItem();
            this.TMSCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.TMSPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TMSAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TTSNew = new System.Windows.Forms.ToolStripButton();
            this.TTSOpen = new System.Windows.Forms.ToolStripButton();
            this.TTSSave = new System.Windows.Forms.ToolStripButton();
            this.TTSSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TTSBold = new System.Windows.Forms.ToolStripButton();
            this.TTSItalic = new System.Windows.Forms.ToolStripButton();
            this.TTSUnderline = new System.Windows.Forms.ToolStripButton();
            this.TTSFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.TTSHelp = new System.Windows.Forms.ToolStripButton();
            this.TTSLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.LTSCut = new System.Windows.Forms.ToolStripButton();
            this.LTSCopy = new System.Windows.Forms.ToolStripButton();
            this.LTSPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.RichTB = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMSNew,
            this.TMSOpen,
            this.toolStripSeparator2,
            this.TMSSave,
            this.TMSSaveAs,
            this.toolStripSeparator3,
            this.TMSLogout});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // TMSNew
            // 
            this.TMSNew.Name = "TMSNew";
            this.TMSNew.Size = new System.Drawing.Size(114, 22);
            this.TMSNew.Text = "New";
            this.TMSNew.Click += new System.EventHandler(this.TMSNew_Click);
            // 
            // TMSOpen
            // 
            this.TMSOpen.Name = "TMSOpen";
            this.TMSOpen.Size = new System.Drawing.Size(114, 22);
            this.TMSOpen.Text = "Open";
            this.TMSOpen.Click += new System.EventHandler(this.TMSOpen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            // 
            // TMSSave
            // 
            this.TMSSave.Name = "TMSSave";
            this.TMSSave.Size = new System.Drawing.Size(114, 22);
            this.TMSSave.Text = "Save";
            this.TMSSave.Click += new System.EventHandler(this.TMSSave_Click);
            // 
            // TMSSaveAs
            // 
            this.TMSSaveAs.Name = "TMSSaveAs";
            this.TMSSaveAs.Size = new System.Drawing.Size(114, 22);
            this.TMSSaveAs.Text = "Save As";
            this.TMSSaveAs.Click += new System.EventHandler(this.TMSSaveAs_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(111, 6);
            // 
            // TMSLogout
            // 
            this.TMSLogout.Name = "TMSLogout";
            this.TMSLogout.Size = new System.Drawing.Size(114, 22);
            this.TMSLogout.Text = "Logout";
            this.TMSLogout.Click += new System.EventHandler(this.TMSLogout_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMSCut,
            this.TMSCopy,
            this.TMSPaste});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // TMSCut
            // 
            this.TMSCut.Name = "TMSCut";
            this.TMSCut.Size = new System.Drawing.Size(102, 22);
            this.TMSCut.Text = "Cut";
            this.TMSCut.Click += new System.EventHandler(this.TMSCut_Click);
            // 
            // TMSCopy
            // 
            this.TMSCopy.Name = "TMSCopy";
            this.TMSCopy.Size = new System.Drawing.Size(102, 22);
            this.TMSCopy.Text = "Copy";
            this.TMSCopy.Click += new System.EventHandler(this.TMSCopy_Click);
            // 
            // TMSPaste
            // 
            this.TMSPaste.Name = "TMSPaste";
            this.TMSPaste.Size = new System.Drawing.Size(102, 22);
            this.TMSPaste.Text = "Paste";
            this.TMSPaste.Click += new System.EventHandler(this.TMSPaste_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMSAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // TMSAbout
            // 
            this.TMSAbout.Name = "TMSAbout";
            this.TMSAbout.Size = new System.Drawing.Size(116, 22);
            this.TMSAbout.Text = "About...";
            this.TMSAbout.Click += new System.EventHandler(this.TMSAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TTSNew,
            this.TTSOpen,
            this.TTSSave,
            this.TTSSaveAs,
            this.toolStripSeparator4,
            this.TTSBold,
            this.TTSItalic,
            this.TTSUnderline,
            this.TTSFontSize,
            this.toolStripSeparator,
            this.TTSHelp,
            this.TTSLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TTSNew
            // 
            this.TTSNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TTSNew.Image = ((System.Drawing.Image)(resources.GetObject("TTSNew.Image")));
            this.TTSNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TTSNew.Name = "TTSNew";
            this.TTSNew.Size = new System.Drawing.Size(23, 22);
            this.TTSNew.Text = "&New";
            this.TTSNew.Click += new System.EventHandler(this.TTSNew_Click);
            // 
            // TTSOpen
            // 
            this.TTSOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TTSOpen.Image = ((System.Drawing.Image)(resources.GetObject("TTSOpen.Image")));
            this.TTSOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TTSOpen.Name = "TTSOpen";
            this.TTSOpen.Size = new System.Drawing.Size(23, 22);
            this.TTSOpen.Text = "&Open";
            this.TTSOpen.Click += new System.EventHandler(this.TTSOpen_Click);
            // 
            // TTSSave
            // 
            this.TTSSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TTSSave.Image = ((System.Drawing.Image)(resources.GetObject("TTSSave.Image")));
            this.TTSSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TTSSave.Name = "TTSSave";
            this.TTSSave.Size = new System.Drawing.Size(23, 22);
            this.TTSSave.Text = "&Save";
            this.TTSSave.Click += new System.EventHandler(this.TTSSave_Click);
            // 
            // TTSSaveAs
            // 
            this.TTSSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TTSSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("TTSSaveAs.Image")));
            this.TTSSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TTSSaveAs.Name = "TTSSaveAs";
            this.TTSSaveAs.Size = new System.Drawing.Size(23, 22);
            this.TTSSaveAs.Text = "&Save";
            this.TTSSaveAs.ToolTipText = "SaveAs";
            this.TTSSaveAs.Click += new System.EventHandler(this.TTSSaveAs_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // TTSBold
            // 
            this.TTSBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TTSBold.Image = ((System.Drawing.Image)(resources.GetObject("TTSBold.Image")));
            this.TTSBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TTSBold.Name = "TTSBold";
            this.TTSBold.Size = new System.Drawing.Size(23, 22);
            this.TTSBold.Text = "toolStripButton2";
            this.TTSBold.ToolTipText = "Bold";
            this.TTSBold.Click += new System.EventHandler(this.TTSBold_Click);
            // 
            // TTSItalic
            // 
            this.TTSItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TTSItalic.Image = ((System.Drawing.Image)(resources.GetObject("TTSItalic.Image")));
            this.TTSItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TTSItalic.Name = "TTSItalic";
            this.TTSItalic.Size = new System.Drawing.Size(23, 22);
            this.TTSItalic.Text = "toolStripButton2";
            this.TTSItalic.ToolTipText = "Italic";
            this.TTSItalic.Click += new System.EventHandler(this.TTSItalic_Click);
            // 
            // TTSUnderline
            // 
            this.TTSUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TTSUnderline.Image = ((System.Drawing.Image)(resources.GetObject("TTSUnderline.Image")));
            this.TTSUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TTSUnderline.Name = "TTSUnderline";
            this.TTSUnderline.Size = new System.Drawing.Size(23, 22);
            this.TTSUnderline.Text = "toolStripButton2";
            this.TTSUnderline.ToolTipText = "Underline";
            this.TTSUnderline.Click += new System.EventHandler(this.TTSUnderline_Click);
            // 
            // TTSFontSize
            // 
            this.TTSFontSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.TTSFontSize.Name = "TTSFontSize";
            this.TTSFontSize.Size = new System.Drawing.Size(121, 25);
            this.TTSFontSize.Text = "10";
            this.TTSFontSize.ToolTipText = "Font Size";
            this.TTSFontSize.SelectedIndexChanged += new System.EventHandler(this.TTSFontSize_SelectedIndexChanged);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // TTSHelp
            // 
            this.TTSHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TTSHelp.Image = ((System.Drawing.Image)(resources.GetObject("TTSHelp.Image")));
            this.TTSHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TTSHelp.Name = "TTSHelp";
            this.TTSHelp.Size = new System.Drawing.Size(23, 22);
            this.TTSHelp.Text = "He&lp";
            this.TTSHelp.Click += new System.EventHandler(this.TTSHelp_Click);
            // 
            // TTSLabel
            // 
            this.TTSLabel.Name = "TTSLabel";
            this.TTSLabel.Size = new System.Drawing.Size(71, 22);
            this.TTSLabel.Text = "User Name: ";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.LTSCut,
            this.LTSCopy,
            this.LTSPaste,
            this.toolStripSeparator6});
            this.toolStrip2.Location = new System.Drawing.Point(0, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(24, 401);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(21, 6);
            // 
            // LTSCut
            // 
            this.LTSCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LTSCut.Image = ((System.Drawing.Image)(resources.GetObject("LTSCut.Image")));
            this.LTSCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LTSCut.Name = "LTSCut";
            this.LTSCut.Size = new System.Drawing.Size(21, 20);
            this.LTSCut.Text = "C&ut";
            this.LTSCut.Click += new System.EventHandler(this.LTSCut_Click);
            // 
            // LTSCopy
            // 
            this.LTSCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LTSCopy.Image = ((System.Drawing.Image)(resources.GetObject("LTSCopy.Image")));
            this.LTSCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LTSCopy.Name = "LTSCopy";
            this.LTSCopy.Size = new System.Drawing.Size(21, 20);
            this.LTSCopy.Text = "&Copy";
            this.LTSCopy.Click += new System.EventHandler(this.LTSCopy_Click);
            // 
            // LTSPaste
            // 
            this.LTSPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LTSPaste.Image = ((System.Drawing.Image)(resources.GetObject("LTSPaste.Image")));
            this.LTSPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LTSPaste.Name = "LTSPaste";
            this.LTSPaste.Size = new System.Drawing.Size(21, 20);
            this.LTSPaste.Text = "&Paste";
            this.LTSPaste.Click += new System.EventHandler(this.LTSPaste_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(21, 6);
            // 
            // RichTB
            // 
            this.RichTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTB.Location = new System.Drawing.Point(27, 49);
            this.RichTB.Name = "RichTB";
            this.RichTB.Size = new System.Drawing.Size(773, 401);
            this.RichTB.TabIndex = 3;
            this.RichTB.Text = "";
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RichTB);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextEditor";
            this.Text = "TextEditor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TextEditor_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TMSNew;
        private System.Windows.Forms.ToolStripMenuItem TMSOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TMSSave;
        private System.Windows.Forms.ToolStripMenuItem TMSSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem TMSLogout;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TMSCut;
        private System.Windows.Forms.ToolStripMenuItem TMSCopy;
        private System.Windows.Forms.ToolStripMenuItem TMSPaste;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TMSAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox TTSFontSize;
        private System.Windows.Forms.ToolStripLabel TTSLabel;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.RichTextBox RichTB;
        private System.Windows.Forms.ToolStripButton TTSNew;
        private System.Windows.Forms.ToolStripButton TTSOpen;
        private System.Windows.Forms.ToolStripButton TTSSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton TTSHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton LTSCut;
        private System.Windows.Forms.ToolStripButton LTSCopy;
        private System.Windows.Forms.ToolStripButton LTSPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton TTSSave;
        private System.Windows.Forms.ToolStripButton TTSBold;
        private System.Windows.Forms.ToolStripButton TTSItalic;
        private System.Windows.Forms.ToolStripButton TTSUnderline;
    }
}