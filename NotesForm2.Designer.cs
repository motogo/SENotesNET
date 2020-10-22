namespace SENotesNET
{
    partial class NotesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesForm));
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.hsClose = new SeControlsLib.HotSpot();
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.gbPagePosition = new System.Windows.Forms.GroupBox();
            this.pbShownPages = new System.Windows.Forms.ProgressBar();
            this.gbVolume = new System.Windows.Forms.GroupBox();
            this.btnSoundDown = new System.Windows.Forms.Button();
            this.btnVolumeUp = new System.Windows.Forms.Button();
            this.gbMetronom = new System.Windows.Forms.GroupBox();
            this.btnMetronom = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.nMetronom = new System.Windows.Forms.NumericUpDown();
            this.lblMetronomTempo = new System.Windows.Forms.Label();
            this.gbAutoStep = new System.Windows.Forms.GroupBox();
            this.pbAutoStep = new System.Windows.Forms.ProgressBar();
            this.nAutoStep = new System.Windows.Forms.NumericUpDown();
            this.btnAutoStep = new System.Windows.Forms.Button();
            this.gbAttributes = new System.Windows.Forms.GroupBox();
            this.nPicShowCount = new System.Windows.Forms.NumericUpDown();
            this.lblShowCount = new System.Windows.Forms.Label();
            this.nPicStep = new System.Windows.Forms.NumericUpDown();
            this.lblPicStep = new System.Windows.Forms.Label();
            this.nPicWidth = new System.Windows.Forms.NumericUpDown();
            this.lblPicWidth = new System.Windows.Forms.Label();
            this.nPicHeightFactor = new System.Windows.Forms.NumericUpDown();
            this.lblPicHeightFactor = new System.Windows.Forms.Label();
            this.btnDefaultSize = new System.Windows.Forms.Button();
            this.btnSaveAttributes = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlSheets = new System.Windows.Forms.Panel();
            this.timerAutoStep = new System.Windows.Forms.Timer(this.components);
            this.tmMetronom = new System.Windows.Forms.Timer(this.components);
            this.pnlUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.gbPagePosition.SuspendLayout();
            this.gbVolume.SuspendLayout();
            this.gbMetronom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMetronom)).BeginInit();
            this.gbAutoStep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAutoStep)).BeginInit();
            this.gbAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPicShowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPicStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPicWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPicHeightFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Controls.Add(this.axWMP);
            this.pnlUpper.Controls.Add(this.gbPagePosition);
            this.pnlUpper.Controls.Add(this.gbVolume);
            this.pnlUpper.Controls.Add(this.gbMetronom);
            this.pnlUpper.Controls.Add(this.gbAutoStep);
            this.pnlUpper.Controls.Add(this.gbAttributes);
            this.pnlUpper.Controls.Add(this.btnDefaultSize);
            this.pnlUpper.Controls.Add(this.btnSaveAttributes);
            this.pnlUpper.Controls.Add(this.btnRefresh);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1788, 92);
            this.pnlUpper.TabIndex = 1;
            this.pnlUpper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlUpper_MouseClick);
            // 
            // hsClose
            // 
            this.hsClose.BackColor = System.Drawing.Color.Transparent;
            this.hsClose.BackColorHover = System.Drawing.Color.Transparent;
            this.hsClose.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsClose.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsClose.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsClose.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsClose.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsClose.FlatAppearance.BorderSize = 0;
            this.hsClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsClose.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClose.Image = global::SENotesNET.Properties.Resources.go_previous32x;
            this.hsClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsClose.ImageHover = global::SENotesNET.Properties.Resources.go_left_blue32x;
            this.hsClose.ImageToggleOnSelect = false;
            this.hsClose.Location = new System.Drawing.Point(3, 5);
            this.hsClose.Marked = false;
            this.hsClose.MarkedColor = System.Drawing.Color.Teal;
            this.hsClose.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClose.MarkedText = "";
            this.hsClose.MarkMode = false;
            this.hsClose.Name = "hsClose";
            this.hsClose.NonMarkedText = "";
            this.hsClose.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsClose.ShowShortcut = false;
            this.hsClose.Size = new System.Drawing.Size(69, 40);
            this.hsClose.TabIndex = 23;
            this.hsClose.Text = "Close";
            this.hsClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsClose.ToolTipActive = false;
            this.hsClose.ToolTipAutomaticDelay = 500;
            this.hsClose.ToolTipAutoPopDelay = 5000;
            this.hsClose.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsClose.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsClose.ToolTipFor4ContextMenu = true;
            this.hsClose.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsClose.ToolTipInitialDelay = 500;
            this.hsClose.ToolTipIsBallon = false;
            this.hsClose.ToolTipOwnerDraw = false;
            this.hsClose.ToolTipReshowDelay = 100;
            this.hsClose.ToolTipShowAlways = false;
            this.hsClose.ToolTipText = "";
            this.hsClose.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsClose.ToolTipTitle = "";
            this.hsClose.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClose.UseVisualStyleBackColor = false;
            this.hsClose.Click += new System.EventHandler(this.hsClose_Click);
            // 
            // axWMP
            // 
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(752, 9);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(344, 77);
            this.axWMP.TabIndex = 0;
            this.axWMP.DurationUnitChange += new AxWMPLib._WMPOCXEvents_DurationUnitChangeEventHandler(this.axWMP_DurationUnitChange);
            this.axWMP.DpiChangedBeforeParent += new System.EventHandler(this.axWMP_DpiChangedBeforeParent);
            // 
            // gbPagePosition
            // 
            this.gbPagePosition.Controls.Add(this.pbShownPages);
            this.gbPagePosition.Location = new System.Drawing.Point(647, 3);
            this.gbPagePosition.Name = "gbPagePosition";
            this.gbPagePosition.Size = new System.Drawing.Size(99, 41);
            this.gbPagePosition.TabIndex = 22;
            this.gbPagePosition.TabStop = false;
            this.gbPagePosition.Text = "Page Position";
            // 
            // pbShownPages
            // 
            this.pbShownPages.Location = new System.Drawing.Point(4, 16);
            this.pbShownPages.Maximum = 8;
            this.pbShownPages.Name = "pbShownPages";
            this.pbShownPages.Size = new System.Drawing.Size(89, 16);
            this.pbShownPages.Step = 1;
            this.pbShownPages.TabIndex = 10;
            // 
            // gbVolume
            // 
            this.gbVolume.Controls.Add(this.btnSoundDown);
            this.gbVolume.Controls.Add(this.btnVolumeUp);
            this.gbVolume.Location = new System.Drawing.Point(1271, 3);
            this.gbVolume.Name = "gbVolume";
            this.gbVolume.Size = new System.Drawing.Size(94, 41);
            this.gbVolume.TabIndex = 21;
            this.gbVolume.TabStop = false;
            this.gbVolume.Text = "Sound Volume";
            // 
            // btnSoundDown
            // 
            this.btnSoundDown.Image = ((System.Drawing.Image)(resources.GetObject("btnSoundDown.Image")));
            this.btnSoundDown.Location = new System.Drawing.Point(42, 12);
            this.btnSoundDown.Name = "btnSoundDown";
            this.btnSoundDown.Size = new System.Drawing.Size(32, 26);
            this.btnSoundDown.TabIndex = 8;
            this.btnSoundDown.UseVisualStyleBackColor = true;
            this.btnSoundDown.Click += new System.EventHandler(this.btnSoundDown_Click);
            // 
            // btnVolumeUp
            // 
            this.btnVolumeUp.Image = ((System.Drawing.Image)(resources.GetObject("btnVolumeUp.Image")));
            this.btnVolumeUp.Location = new System.Drawing.Point(5, 11);
            this.btnVolumeUp.Name = "btnVolumeUp";
            this.btnVolumeUp.Size = new System.Drawing.Size(32, 27);
            this.btnVolumeUp.TabIndex = 7;
            this.btnVolumeUp.UseVisualStyleBackColor = true;
            this.btnVolumeUp.Click += new System.EventHandler(this.btnVolumeUp_Click);
            // 
            // gbMetronom
            // 
            this.gbMetronom.Controls.Add(this.btnMetronom);
            this.gbMetronom.Controls.Add(this.nMetronom);
            this.gbMetronom.Controls.Add(this.lblMetronomTempo);
            this.gbMetronom.Location = new System.Drawing.Point(1133, 3);
            this.gbMetronom.Name = "gbMetronom";
            this.gbMetronom.Size = new System.Drawing.Size(131, 40);
            this.gbMetronom.TabIndex = 20;
            this.gbMetronom.TabStop = false;
            this.gbMetronom.Text = "Metronom";
            // 
            // btnMetronom
            // 
            this.btnMetronom.ImageKey = "appointment_new_24.png";
            this.btnMetronom.ImageList = this.imageList1;
            this.btnMetronom.Location = new System.Drawing.Point(85, 8);
            this.btnMetronom.Name = "btnMetronom";
            this.btnMetronom.Size = new System.Drawing.Size(32, 29);
            this.btnMetronom.TabIndex = 6;
            this.btnMetronom.UseVisualStyleBackColor = true;
            this.btnMetronom.Click += new System.EventHandler(this.btnMetronom_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "go_previous32x.png");
            this.imageList1.Images.SetKeyName(1, "minus_rt32x.png");
            this.imageList1.Images.SetKeyName(2, "plus_gn32x.png");
            this.imageList1.Images.SetKeyName(3, "plus_blue32x.png");
            this.imageList1.Images.SetKeyName(4, "minus_blau32x.png");
            this.imageList1.Images.SetKeyName(5, "view_refresh22x.png");
            this.imageList1.Images.SetKeyName(6, "view_refresh32x.png");
            this.imageList1.Images.SetKeyName(7, "floppy_x32.png");
            this.imageList1.Images.SetKeyName(8, "arrange_forms_24x.png");
            this.imageList1.Images.SetKeyName(9, "appointment_new_24.png");
            this.imageList1.Images.SetKeyName(10, "appointment_remove_x24.png");
            // 
            // nMetronom
            // 
            this.nMetronom.Location = new System.Drawing.Point(47, 15);
            this.nMetronom.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nMetronom.Name = "nMetronom";
            this.nMetronom.Size = new System.Drawing.Size(34, 20);
            this.nMetronom.TabIndex = 5;
            this.nMetronom.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // lblMetronomTempo
            // 
            this.lblMetronomTempo.AutoSize = true;
            this.lblMetronomTempo.Location = new System.Drawing.Point(5, 16);
            this.lblMetronomTempo.Name = "lblMetronomTempo";
            this.lblMetronomTempo.Size = new System.Drawing.Size(40, 13);
            this.lblMetronomTempo.TabIndex = 0;
            this.lblMetronomTempo.Text = "Tempo";
            // 
            // gbAutoStep
            // 
            this.gbAutoStep.Controls.Add(this.pbAutoStep);
            this.gbAutoStep.Controls.Add(this.nAutoStep);
            this.gbAutoStep.Controls.Add(this.btnAutoStep);
            this.gbAutoStep.Location = new System.Drawing.Point(414, 3);
            this.gbAutoStep.Name = "gbAutoStep";
            this.gbAutoStep.Size = new System.Drawing.Size(229, 40);
            this.gbAutoStep.TabIndex = 18;
            this.gbAutoStep.TabStop = false;
            this.gbAutoStep.Text = "Auto Step";
            // 
            // pbAutoStep
            // 
            this.pbAutoStep.BackColor = System.Drawing.SystemColors.Control;
            this.pbAutoStep.Location = new System.Drawing.Point(81, 16);
            this.pbAutoStep.Maximum = 8;
            this.pbAutoStep.Name = "pbAutoStep";
            this.pbAutoStep.Size = new System.Drawing.Size(147, 16);
            this.pbAutoStep.Step = 1;
            this.pbAutoStep.TabIndex = 11;
            // 
            // nAutoStep
            // 
            this.nAutoStep.Dock = System.Windows.Forms.DockStyle.Left;
            this.nAutoStep.Location = new System.Drawing.Point(3, 16);
            this.nAutoStep.Name = "nAutoStep";
            this.nAutoStep.Size = new System.Drawing.Size(34, 20);
            this.nAutoStep.TabIndex = 4;
            this.nAutoStep.ValueChanged += new System.EventHandler(this.nUpSheets_ValueChanged);
            // 
            // btnAutoStep
            // 
            this.btnAutoStep.ImageKey = "appointment_new_24.png";
            this.btnAutoStep.ImageList = this.imageList1;
            this.btnAutoStep.Location = new System.Drawing.Point(42, 12);
            this.btnAutoStep.Name = "btnAutoStep";
            this.btnAutoStep.Size = new System.Drawing.Size(32, 29);
            this.btnAutoStep.TabIndex = 3;
            this.btnAutoStep.UseVisualStyleBackColor = true;
            this.btnAutoStep.Click += new System.EventHandler(this.btnDefa);
            // 
            // gbAttributes
            // 
            this.gbAttributes.Controls.Add(this.nPicShowCount);
            this.gbAttributes.Controls.Add(this.lblShowCount);
            this.gbAttributes.Controls.Add(this.nPicStep);
            this.gbAttributes.Controls.Add(this.lblPicStep);
            this.gbAttributes.Controls.Add(this.nPicWidth);
            this.gbAttributes.Controls.Add(this.lblPicWidth);
            this.gbAttributes.Controls.Add(this.nPicHeightFactor);
            this.gbAttributes.Controls.Add(this.lblPicHeightFactor);
            this.gbAttributes.Location = new System.Drawing.Point(75, 3);
            this.gbAttributes.Name = "gbAttributes";
            this.gbAttributes.Size = new System.Drawing.Size(335, 40);
            this.gbAttributes.TabIndex = 17;
            this.gbAttributes.TabStop = false;
            this.gbAttributes.Text = "Attributes";
            // 
            // nPicShowCount
            // 
            this.nPicShowCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.nPicShowCount.Location = new System.Drawing.Point(306, 16);
            this.nPicShowCount.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nPicShowCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nPicShowCount.Name = "nPicShowCount";
            this.nPicShowCount.Size = new System.Drawing.Size(34, 20);
            this.nPicShowCount.TabIndex = 7;
            this.nPicShowCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nPicShowCount.ValueChanged += new System.EventHandler(this.nShowCount_ValueChanged);
            // 
            // lblShowCount
            // 
            this.lblShowCount.AutoSize = true;
            this.lblShowCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblShowCount.Location = new System.Drawing.Point(241, 16);
            this.lblShowCount.Name = "lblShowCount";
            this.lblShowCount.Size = new System.Drawing.Size(65, 13);
            this.lblShowCount.TabIndex = 8;
            this.lblShowCount.Text = "Show Count";
            // 
            // nPicStep
            // 
            this.nPicStep.Dock = System.Windows.Forms.DockStyle.Left;
            this.nPicStep.Location = new System.Drawing.Point(207, 16);
            this.nPicStep.Name = "nPicStep";
            this.nPicStep.Size = new System.Drawing.Size(34, 20);
            this.nPicStep.TabIndex = 4;
            this.nPicStep.ValueChanged += new System.EventHandler(this.nUpSheets_ValueChanged);
            // 
            // lblPicStep
            // 
            this.lblPicStep.AutoSize = true;
            this.lblPicStep.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPicStep.Location = new System.Drawing.Point(178, 16);
            this.lblPicStep.Name = "lblPicStep";
            this.lblPicStep.Size = new System.Drawing.Size(29, 13);
            this.lblPicStep.TabIndex = 6;
            this.lblPicStep.Text = "Step";
            // 
            // nPicWidth
            // 
            this.nPicWidth.Dock = System.Windows.Forms.DockStyle.Left;
            this.nPicWidth.Location = new System.Drawing.Point(139, 16);
            this.nPicWidth.Name = "nPicWidth";
            this.nPicWidth.Size = new System.Drawing.Size(39, 20);
            this.nPicWidth.TabIndex = 4;
            this.nPicWidth.ValueChanged += new System.EventHandler(this.nUpWidth_ValueChanged);
            // 
            // lblPicWidth
            // 
            this.lblPicWidth.AutoSize = true;
            this.lblPicWidth.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPicWidth.Location = new System.Drawing.Point(104, 16);
            this.lblPicWidth.Name = "lblPicWidth";
            this.lblPicWidth.Size = new System.Drawing.Size(35, 13);
            this.lblPicWidth.TabIndex = 6;
            this.lblPicWidth.Text = "Width";
            // 
            // nPicHeightFactor
            // 
            this.nPicHeightFactor.Dock = System.Windows.Forms.DockStyle.Left;
            this.nPicHeightFactor.Location = new System.Drawing.Point(71, 16);
            this.nPicHeightFactor.Name = "nPicHeightFactor";
            this.nPicHeightFactor.Size = new System.Drawing.Size(33, 20);
            this.nPicHeightFactor.TabIndex = 4;
            this.nPicHeightFactor.ValueChanged += new System.EventHandler(this.nUpDwn_ValueChanged);
            // 
            // lblPicHeightFactor
            // 
            this.lblPicHeightFactor.AutoSize = true;
            this.lblPicHeightFactor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPicHeightFactor.Location = new System.Drawing.Point(3, 16);
            this.lblPicHeightFactor.Name = "lblPicHeightFactor";
            this.lblPicHeightFactor.Size = new System.Drawing.Size(68, 13);
            this.lblPicHeightFactor.TabIndex = 5;
            this.lblPicHeightFactor.Text = "Height factor";
            // 
            // btnDefaultSize
            // 
            this.btnDefaultSize.ImageKey = "arrange_forms_24x.png";
            this.btnDefaultSize.ImageList = this.imageList1;
            this.btnDefaultSize.Location = new System.Drawing.Point(1408, 13);
            this.btnDefaultSize.Name = "btnDefaultSize";
            this.btnDefaultSize.Size = new System.Drawing.Size(36, 30);
            this.btnDefaultSize.TabIndex = 3;
            this.btnDefaultSize.UseVisualStyleBackColor = true;
            this.btnDefaultSize.Click += new System.EventHandler(this.btnDefaultSize_Click);
            // 
            // btnSaveAttributes
            // 
            this.btnSaveAttributes.ImageKey = "floppy_x32.png";
            this.btnSaveAttributes.ImageList = this.imageList1;
            this.btnSaveAttributes.Location = new System.Drawing.Point(1371, 13);
            this.btnSaveAttributes.Name = "btnSaveAttributes";
            this.btnSaveAttributes.Size = new System.Drawing.Size(36, 30);
            this.btnSaveAttributes.TabIndex = 3;
            this.btnSaveAttributes.UseVisualStyleBackColor = true;
            this.btnSaveAttributes.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageKey = "view_refresh32x.png";
            this.btnRefresh.ImageList = this.imageList1;
            this.btnRefresh.Location = new System.Drawing.Point(1445, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlSheets
            // 
            this.pnlSheets.AutoScroll = true;
            this.pnlSheets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSheets.Location = new System.Drawing.Point(0, 92);
            this.pnlSheets.Name = "pnlSheets";
            this.pnlSheets.Size = new System.Drawing.Size(1788, 298);
            this.pnlSheets.TabIndex = 0;
            // 
            // timerAutoStep
            // 
            this.timerAutoStep.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmMetronom
            // 
            this.tmMetronom.Tick += new System.EventHandler(this.tmMetronom_Tick);
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1788, 390);
            this.Controls.Add(this.pnlSheets);
            this.Controls.Add(this.pnlUpper);
            this.Name = "NotesForm";
            this.Text = "NotesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotesForm_FormClosing);
            this.Load += new System.EventHandler(this.NotesForm_Load);
            this.Resize += new System.EventHandler(this.NotesForm_Resize);
            this.pnlUpper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.gbPagePosition.ResumeLayout(false);
            this.gbVolume.ResumeLayout(false);
            this.gbMetronom.ResumeLayout(false);
            this.gbMetronom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMetronom)).EndInit();
            this.gbAutoStep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nAutoStep)).EndInit();
            this.gbAttributes.ResumeLayout(false);
            this.gbAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPicShowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPicStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPicWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPicHeightFactor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlSheets;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.NumericUpDown nPicHeightFactor;
        private System.Windows.Forms.NumericUpDown nPicWidth;
        private System.Windows.Forms.Label lblPicWidth;
        private System.Windows.Forms.Label lblPicHeightFactor;
        private System.Windows.Forms.NumericUpDown nPicStep;
        private System.Windows.Forms.Label lblPicStep;
        private System.Windows.Forms.Button btnSaveAttributes;
        private System.Windows.Forms.Button btnDefaultSize;
        private System.Windows.Forms.Button btnAutoStep;
        private System.Windows.Forms.NumericUpDown nAutoStep;
        private System.Windows.Forms.Timer timerAutoStep;
        private System.Windows.Forms.NumericUpDown nPicShowCount;
        private System.Windows.Forms.Label lblShowCount;
        private System.Windows.Forms.ProgressBar pbShownPages;
        private System.Windows.Forms.GroupBox gbAutoStep;
        private System.Windows.Forms.GroupBox gbAttributes;
        private System.Windows.Forms.GroupBox gbMetronom;
        private System.Windows.Forms.Button btnMetronom;
        private System.Windows.Forms.NumericUpDown nMetronom;
        private System.Windows.Forms.Label lblMetronomTempo;
        private System.Windows.Forms.Timer tmMetronom;
        private System.Windows.Forms.Button btnVolumeUp;
        private System.Windows.Forms.GroupBox gbVolume;
        private System.Windows.Forms.Button btnSoundDown;
        private System.Windows.Forms.GroupBox gbPagePosition;
        private System.Windows.Forms.ProgressBar pbAutoStep;
        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private SeControlsLib.HotSpot hsClose;
    }
}