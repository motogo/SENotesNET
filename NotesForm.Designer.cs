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
            this.gbPagePosition = new System.Windows.Forms.GroupBox();
            this.pbShownPages = new System.Windows.Forms.ProgressBar();
            this.gbVolume = new System.Windows.Forms.GroupBox();
            this.gbMetronom = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.nMetronom = new System.Windows.Forms.NumericUpDown();
            this.lblMetronomTempo = new System.Windows.Forms.Label();
            this.gbSongPlayer = new System.Windows.Forms.GroupBox();
            this.lblSoundPlayer = new System.Windows.Forms.Label();
            this.pbPlayMedia = new System.Windows.Forms.ProgressBar();
            this.gbAutoStep = new System.Windows.Forms.GroupBox();
            this.pbAutoStep = new System.Windows.Forms.ProgressBar();
            this.nAutoStep = new System.Windows.Forms.NumericUpDown();
            this.gbAttributes = new System.Windows.Forms.GroupBox();
            this.nPicShowCount = new System.Windows.Forms.NumericUpDown();
            this.lblShowCount = new System.Windows.Forms.Label();
            this.nPicStep = new System.Windows.Forms.NumericUpDown();
            this.lblPicStep = new System.Windows.Forms.Label();
            this.nPicWidth = new System.Windows.Forms.NumericUpDown();
            this.lblPicWidth = new System.Windows.Forms.Label();
            this.nPicHeightFactor = new System.Windows.Forms.NumericUpDown();
            this.lblPicHeightFactor = new System.Windows.Forms.Label();
            this.pnlSheets = new System.Windows.Forms.Panel();
            this.timerAutoStep = new System.Windows.Forms.Timer(this.components);
            this.tmSoundPlayer = new System.Windows.Forms.Timer(this.components);
            this.tmMetronom = new System.Windows.Forms.Timer(this.components);
            this.hsDefaultSize = new SeControlsLib.HotSpot();
            this.hsSaveAttributes = new SeControlsLib.HotSpot();
            this.hsClose = new SeControlsLib.HotSpot();
            this.hsSoundDown = new SeControlsLib.HotSpot();
            this.hsSoundUp = new SeControlsLib.HotSpot();
            this.hsStartMetronom = new SeControlsLib.HotSpot();
            this.hsStopSong = new SeControlsLib.HotSpot();
            this.hsPauseSong = new SeControlsLib.HotSpot();
            this.hsPlaySong = new SeControlsLib.HotSpot();
            this.hsAutoStep = new SeControlsLib.HotSpot();
            this.hsRefresh = new SeControlsLib.HotSpot();
            this.pnlUpper.SuspendLayout();
            this.gbPagePosition.SuspendLayout();
            this.gbVolume.SuspendLayout();
            this.gbMetronom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMetronom)).BeginInit();
            this.gbSongPlayer.SuspendLayout();
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
            this.pnlUpper.Controls.Add(this.hsRefresh);
            this.pnlUpper.Controls.Add(this.hsDefaultSize);
            this.pnlUpper.Controls.Add(this.hsSaveAttributes);
            this.pnlUpper.Controls.Add(this.hsClose);
            this.pnlUpper.Controls.Add(this.gbPagePosition);
            this.pnlUpper.Controls.Add(this.gbVolume);
            this.pnlUpper.Controls.Add(this.gbMetronom);
            this.pnlUpper.Controls.Add(this.gbSongPlayer);
            this.pnlUpper.Controls.Add(this.gbAutoStep);
            this.pnlUpper.Controls.Add(this.gbAttributes);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1699, 44);
            this.pnlUpper.TabIndex = 1;
            this.pnlUpper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlUpper_MouseClick);
            // 
            // gbPagePosition
            // 
            this.gbPagePosition.Controls.Add(this.pbShownPages);
            this.gbPagePosition.Location = new System.Drawing.Point(655, 2);
            this.gbPagePosition.Name = "gbPagePosition";
            this.gbPagePosition.Size = new System.Drawing.Size(99, 39);
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
            this.gbVolume.Controls.Add(this.hsSoundDown);
            this.gbVolume.Controls.Add(this.hsSoundUp);
            this.gbVolume.Location = new System.Drawing.Point(1235, 2);
            this.gbVolume.Name = "gbVolume";
            this.gbVolume.Size = new System.Drawing.Size(61, 38);
            this.gbVolume.TabIndex = 21;
            this.gbVolume.TabStop = false;
            this.gbVolume.Text = "Volume";
            // 
            // gbMetronom
            // 
            this.gbMetronom.Controls.Add(this.hsStartMetronom);
            this.gbMetronom.Controls.Add(this.nMetronom);
            this.gbMetronom.Controls.Add(this.lblMetronomTempo);
            this.gbMetronom.Location = new System.Drawing.Point(1107, 1);
            this.gbMetronom.Name = "gbMetronom";
            this.gbMetronom.Size = new System.Drawing.Size(120, 41);
            this.gbMetronom.TabIndex = 20;
            this.gbMetronom.TabStop = false;
            this.gbMetronom.Text = "Metronom";
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
            this.nMetronom.Location = new System.Drawing.Point(45, 15);
            this.nMetronom.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nMetronom.Name = "nMetronom";
            this.nMetronom.Size = new System.Drawing.Size(39, 20);
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
            this.lblMetronomTempo.Location = new System.Drawing.Point(3, 18);
            this.lblMetronomTempo.Name = "lblMetronomTempo";
            this.lblMetronomTempo.Size = new System.Drawing.Size(40, 13);
            this.lblMetronomTempo.TabIndex = 0;
            this.lblMetronomTempo.Text = "Tempo";
            // 
            // gbSongPlayer
            // 
            this.gbSongPlayer.Controls.Add(this.hsStopSong);
            this.gbSongPlayer.Controls.Add(this.lblSoundPlayer);
            this.gbSongPlayer.Controls.Add(this.hsPauseSong);
            this.gbSongPlayer.Controls.Add(this.pbPlayMedia);
            this.gbSongPlayer.Controls.Add(this.hsPlaySong);
            this.gbSongPlayer.Location = new System.Drawing.Point(760, 1);
            this.gbSongPlayer.Name = "gbSongPlayer";
            this.gbSongPlayer.Size = new System.Drawing.Size(339, 40);
            this.gbSongPlayer.TabIndex = 19;
            this.gbSongPlayer.TabStop = false;
            this.gbSongPlayer.Text = "Song Player";
            // 
            // lblSoundPlayer
            // 
            this.lblSoundPlayer.AutoSize = true;
            this.lblSoundPlayer.Location = new System.Drawing.Point(261, 21);
            this.lblSoundPlayer.Name = "lblSoundPlayer";
            this.lblSoundPlayer.Size = new System.Drawing.Size(25, 13);
            this.lblSoundPlayer.TabIndex = 17;
            this.lblSoundPlayer.Text = "0(0)";
            // 
            // pbPlayMedia
            // 
            this.pbPlayMedia.Location = new System.Drawing.Point(81, 19);
            this.pbPlayMedia.Maximum = 8;
            this.pbPlayMedia.Name = "pbPlayMedia";
            this.pbPlayMedia.Size = new System.Drawing.Size(165, 16);
            this.pbPlayMedia.Step = 1;
            this.pbPlayMedia.TabIndex = 16;
            // 
            // gbAutoStep
            // 
            this.gbAutoStep.Controls.Add(this.hsAutoStep);
            this.gbAutoStep.Controls.Add(this.pbAutoStep);
            this.gbAutoStep.Controls.Add(this.nAutoStep);
            this.gbAutoStep.Location = new System.Drawing.Point(420, 2);
            this.gbAutoStep.Name = "gbAutoStep";
            this.gbAutoStep.Size = new System.Drawing.Size(229, 39);
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
            this.gbAttributes.Location = new System.Drawing.Point(75, 2);
            this.gbAttributes.Name = "gbAttributes";
            this.gbAttributes.Size = new System.Drawing.Size(341, 39);
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
            // pnlSheets
            // 
            this.pnlSheets.AutoScroll = true;
            this.pnlSheets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSheets.Location = new System.Drawing.Point(0, 44);
            this.pnlSheets.Name = "pnlSheets";
            this.pnlSheets.Size = new System.Drawing.Size(1699, 346);
            this.pnlSheets.TabIndex = 0;
            // 
            // timerAutoStep
            // 
            this.timerAutoStep.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmSoundPlayer
            // 
            this.tmSoundPlayer.Interval = 1000;
            this.tmSoundPlayer.Tick += new System.EventHandler(this.tmSoundPlayer_Tick);
            // 
            // tmMetronom
            // 
            this.tmMetronom.Tick += new System.EventHandler(this.tmMetronom_Tick);
            // 
            // hsDefaultSize
            // 
            this.hsDefaultSize.BackColor = System.Drawing.Color.Transparent;
            this.hsDefaultSize.BackColorHover = System.Drawing.Color.Transparent;
            this.hsDefaultSize.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsDefaultSize.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsDefaultSize.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsDefaultSize.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsDefaultSize.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsDefaultSize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsDefaultSize.FlatAppearance.BorderSize = 0;
            this.hsDefaultSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsDefaultSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsDefaultSize.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsDefaultSize.Image = global::SENotesNET.Properties.Resources.arrange_forms_24x;
            this.hsDefaultSize.ImageHover = global::SENotesNET.Properties.Resources.arrange_forms_2_24x;
            this.hsDefaultSize.ImageToggleOnSelect = false;
            this.hsDefaultSize.Location = new System.Drawing.Point(1356, 13);
            this.hsDefaultSize.Marked = false;
            this.hsDefaultSize.MarkedColor = System.Drawing.Color.Teal;
            this.hsDefaultSize.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDefaultSize.MarkedText = "";
            this.hsDefaultSize.MarkMode = false;
            this.hsDefaultSize.Name = "hsDefaultSize";
            this.hsDefaultSize.NonMarkedText = "";
            this.hsDefaultSize.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsDefaultSize.ShowShortcut = false;
            this.hsDefaultSize.Size = new System.Drawing.Size(24, 21);
            this.hsDefaultSize.TabIndex = 26;
            this.hsDefaultSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsDefaultSize.ToolTipActive = false;
            this.hsDefaultSize.ToolTipAutomaticDelay = 500;
            this.hsDefaultSize.ToolTipAutoPopDelay = 5000;
            this.hsDefaultSize.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsDefaultSize.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsDefaultSize.ToolTipFor4ContextMenu = true;
            this.hsDefaultSize.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsDefaultSize.ToolTipInitialDelay = 500;
            this.hsDefaultSize.ToolTipIsBallon = false;
            this.hsDefaultSize.ToolTipOwnerDraw = false;
            this.hsDefaultSize.ToolTipReshowDelay = 100;
            this.hsDefaultSize.ToolTipShowAlways = false;
            this.hsDefaultSize.ToolTipText = "";
            this.hsDefaultSize.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsDefaultSize.ToolTipTitle = "";
            this.hsDefaultSize.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsDefaultSize.UseVisualStyleBackColor = false;
            this.hsDefaultSize.Click += new System.EventHandler(this.hsDefaultSize_Click);
            // 
            // hsSaveAttributes
            // 
            this.hsSaveAttributes.BackColor = System.Drawing.Color.Transparent;
            this.hsSaveAttributes.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSaveAttributes.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSaveAttributes.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSaveAttributes.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSaveAttributes.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSaveAttributes.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSaveAttributes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsSaveAttributes.FlatAppearance.BorderSize = 0;
            this.hsSaveAttributes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSaveAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSaveAttributes.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveAttributes.Image = global::SENotesNET.Properties.Resources.floppy_x24;
            this.hsSaveAttributes.ImageHover = global::SENotesNET.Properties.Resources.floppy2_x24;
            this.hsSaveAttributes.ImageToggleOnSelect = false;
            this.hsSaveAttributes.Location = new System.Drawing.Point(1316, 13);
            this.hsSaveAttributes.Marked = false;
            this.hsSaveAttributes.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveAttributes.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveAttributes.MarkedText = "";
            this.hsSaveAttributes.MarkMode = false;
            this.hsSaveAttributes.Name = "hsSaveAttributes";
            this.hsSaveAttributes.NonMarkedText = "";
            this.hsSaveAttributes.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSaveAttributes.ShowShortcut = false;
            this.hsSaveAttributes.Size = new System.Drawing.Size(24, 21);
            this.hsSaveAttributes.TabIndex = 25;
            this.hsSaveAttributes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsSaveAttributes.ToolTipActive = false;
            this.hsSaveAttributes.ToolTipAutomaticDelay = 500;
            this.hsSaveAttributes.ToolTipAutoPopDelay = 5000;
            this.hsSaveAttributes.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSaveAttributes.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSaveAttributes.ToolTipFor4ContextMenu = true;
            this.hsSaveAttributes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSaveAttributes.ToolTipInitialDelay = 500;
            this.hsSaveAttributes.ToolTipIsBallon = false;
            this.hsSaveAttributes.ToolTipOwnerDraw = false;
            this.hsSaveAttributes.ToolTipReshowDelay = 100;
            this.hsSaveAttributes.ToolTipShowAlways = false;
            this.hsSaveAttributes.ToolTipText = "";
            this.hsSaveAttributes.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSaveAttributes.ToolTipTitle = "";
            this.hsSaveAttributes.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSaveAttributes.UseVisualStyleBackColor = false;
            this.hsSaveAttributes.Click += new System.EventHandler(this.hsSaveAttributes_Click);
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
            this.hsClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsClose.FlatAppearance.BorderSize = 0;
            this.hsClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsClose.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClose.Image = global::SENotesNET.Properties.Resources.go_previous32x;
            this.hsClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsClose.ImageHover = global::SENotesNET.Properties.Resources.go_left_blue32x;
            this.hsClose.ImageToggleOnSelect = false;
            this.hsClose.Location = new System.Drawing.Point(0, 0);
            this.hsClose.Marked = false;
            this.hsClose.MarkedColor = System.Drawing.Color.Teal;
            this.hsClose.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClose.MarkedText = "";
            this.hsClose.MarkMode = false;
            this.hsClose.Name = "hsClose";
            this.hsClose.NonMarkedText = "";
            this.hsClose.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsClose.ShowShortcut = false;
            this.hsClose.Size = new System.Drawing.Size(69, 44);
            this.hsClose.TabIndex = 23;
            this.hsClose.Text = "Exit";
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
            // hsSoundDown
            // 
            this.hsSoundDown.BackColor = System.Drawing.Color.Transparent;
            this.hsSoundDown.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSoundDown.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSoundDown.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSoundDown.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSoundDown.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSoundDown.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSoundDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsSoundDown.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsSoundDown.FlatAppearance.BorderSize = 0;
            this.hsSoundDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSoundDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSoundDown.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSoundDown.Image = global::SENotesNET.Properties.Resources.go_down22x;
            this.hsSoundDown.ImageHover = global::SENotesNET.Properties.Resources.go_down_blue_22x;
            this.hsSoundDown.ImageToggleOnSelect = false;
            this.hsSoundDown.Location = new System.Drawing.Point(27, 16);
            this.hsSoundDown.Marked = false;
            this.hsSoundDown.MarkedColor = System.Drawing.Color.Teal;
            this.hsSoundDown.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSoundDown.MarkedText = "";
            this.hsSoundDown.MarkMode = false;
            this.hsSoundDown.Name = "hsSoundDown";
            this.hsSoundDown.NonMarkedText = "";
            this.hsSoundDown.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSoundDown.ShowShortcut = false;
            this.hsSoundDown.Size = new System.Drawing.Size(24, 19);
            this.hsSoundDown.TabIndex = 25;
            this.hsSoundDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsSoundDown.ToolTipActive = false;
            this.hsSoundDown.ToolTipAutomaticDelay = 500;
            this.hsSoundDown.ToolTipAutoPopDelay = 5000;
            this.hsSoundDown.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSoundDown.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSoundDown.ToolTipFor4ContextMenu = true;
            this.hsSoundDown.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSoundDown.ToolTipInitialDelay = 500;
            this.hsSoundDown.ToolTipIsBallon = false;
            this.hsSoundDown.ToolTipOwnerDraw = false;
            this.hsSoundDown.ToolTipReshowDelay = 100;
            this.hsSoundDown.ToolTipShowAlways = false;
            this.hsSoundDown.ToolTipText = "";
            this.hsSoundDown.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSoundDown.ToolTipTitle = "";
            this.hsSoundDown.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSoundDown.UseVisualStyleBackColor = false;
            this.hsSoundDown.Click += new System.EventHandler(this.hsSoundDown_Click);
            // 
            // hsSoundUp
            // 
            this.hsSoundUp.BackColor = System.Drawing.Color.Transparent;
            this.hsSoundUp.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSoundUp.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSoundUp.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSoundUp.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSoundUp.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSoundUp.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSoundUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsSoundUp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsSoundUp.FlatAppearance.BorderSize = 0;
            this.hsSoundUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSoundUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSoundUp.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSoundUp.Image = global::SENotesNET.Properties.Resources.go_up_blue22x;
            this.hsSoundUp.ImageHover = global::SENotesNET.Properties.Resources.go_up_gn22x;
            this.hsSoundUp.ImageToggleOnSelect = false;
            this.hsSoundUp.Location = new System.Drawing.Point(3, 16);
            this.hsSoundUp.Marked = false;
            this.hsSoundUp.MarkedColor = System.Drawing.Color.Teal;
            this.hsSoundUp.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSoundUp.MarkedText = "";
            this.hsSoundUp.MarkMode = false;
            this.hsSoundUp.Name = "hsSoundUp";
            this.hsSoundUp.NonMarkedText = "";
            this.hsSoundUp.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSoundUp.ShowShortcut = false;
            this.hsSoundUp.Size = new System.Drawing.Size(24, 19);
            this.hsSoundUp.TabIndex = 24;
            this.hsSoundUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsSoundUp.ToolTipActive = false;
            this.hsSoundUp.ToolTipAutomaticDelay = 500;
            this.hsSoundUp.ToolTipAutoPopDelay = 5000;
            this.hsSoundUp.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSoundUp.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSoundUp.ToolTipFor4ContextMenu = true;
            this.hsSoundUp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSoundUp.ToolTipInitialDelay = 500;
            this.hsSoundUp.ToolTipIsBallon = false;
            this.hsSoundUp.ToolTipOwnerDraw = false;
            this.hsSoundUp.ToolTipReshowDelay = 100;
            this.hsSoundUp.ToolTipShowAlways = false;
            this.hsSoundUp.ToolTipText = "";
            this.hsSoundUp.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSoundUp.ToolTipTitle = "";
            this.hsSoundUp.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSoundUp.UseVisualStyleBackColor = false;
            this.hsSoundUp.Click += new System.EventHandler(this.hsSoundUp_Click);
            // 
            // hsStartMetronom
            // 
            this.hsStartMetronom.BackColor = System.Drawing.Color.Transparent;
            this.hsStartMetronom.BackColorHover = System.Drawing.Color.Transparent;
            this.hsStartMetronom.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsStartMetronom.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsStartMetronom.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsStartMetronom.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsStartMetronom.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsStartMetronom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsStartMetronom.FlatAppearance.BorderSize = 0;
            this.hsStartMetronom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsStartMetronom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsStartMetronom.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsStartMetronom.Image = global::SENotesNET.Properties.Resources.appointment_new_24;
            this.hsStartMetronom.ImageHover = global::SENotesNET.Properties.Resources.appointment_remove_x24;
            this.hsStartMetronom.ImageToggleOnSelect = false;
            this.hsStartMetronom.Location = new System.Drawing.Point(85, 9);
            this.hsStartMetronom.Marked = false;
            this.hsStartMetronom.MarkedColor = System.Drawing.Color.Teal;
            this.hsStartMetronom.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsStartMetronom.MarkedText = "";
            this.hsStartMetronom.MarkMode = false;
            this.hsStartMetronom.Name = "hsStartMetronom";
            this.hsStartMetronom.NonMarkedText = "";
            this.hsStartMetronom.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsStartMetronom.ShowShortcut = false;
            this.hsStartMetronom.Size = new System.Drawing.Size(31, 27);
            this.hsStartMetronom.TabIndex = 26;
            this.hsStartMetronom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsStartMetronom.ToolTipActive = false;
            this.hsStartMetronom.ToolTipAutomaticDelay = 500;
            this.hsStartMetronom.ToolTipAutoPopDelay = 5000;
            this.hsStartMetronom.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsStartMetronom.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsStartMetronom.ToolTipFor4ContextMenu = true;
            this.hsStartMetronom.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsStartMetronom.ToolTipInitialDelay = 500;
            this.hsStartMetronom.ToolTipIsBallon = false;
            this.hsStartMetronom.ToolTipOwnerDraw = false;
            this.hsStartMetronom.ToolTipReshowDelay = 100;
            this.hsStartMetronom.ToolTipShowAlways = false;
            this.hsStartMetronom.ToolTipText = "";
            this.hsStartMetronom.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsStartMetronom.ToolTipTitle = "";
            this.hsStartMetronom.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsStartMetronom.UseVisualStyleBackColor = false;
            this.hsStartMetronom.Click += new System.EventHandler(this.hsStartMetronom_Click);
            // 
            // hsStopSong
            // 
            this.hsStopSong.BackColor = System.Drawing.Color.Transparent;
            this.hsStopSong.BackColorHover = System.Drawing.Color.Transparent;
            this.hsStopSong.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsStopSong.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsStopSong.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsStopSong.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsStopSong.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsStopSong.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsStopSong.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsStopSong.FlatAppearance.BorderSize = 0;
            this.hsStopSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsStopSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsStopSong.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsStopSong.Image = global::SENotesNET.Properties.Resources.Stop_bl_x24;
            this.hsStopSong.ImageHover = global::SENotesNET.Properties.Resources.Stop_gr_x24;
            this.hsStopSong.ImageToggleOnSelect = false;
            this.hsStopSong.Location = new System.Drawing.Point(51, 16);
            this.hsStopSong.Marked = false;
            this.hsStopSong.MarkedColor = System.Drawing.Color.Teal;
            this.hsStopSong.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsStopSong.MarkedText = "";
            this.hsStopSong.MarkMode = false;
            this.hsStopSong.Name = "hsStopSong";
            this.hsStopSong.NonMarkedText = "";
            this.hsStopSong.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsStopSong.ShowShortcut = false;
            this.hsStopSong.Size = new System.Drawing.Size(24, 21);
            this.hsStopSong.TabIndex = 25;
            this.hsStopSong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsStopSong.ToolTipActive = false;
            this.hsStopSong.ToolTipAutomaticDelay = 500;
            this.hsStopSong.ToolTipAutoPopDelay = 5000;
            this.hsStopSong.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsStopSong.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsStopSong.ToolTipFor4ContextMenu = true;
            this.hsStopSong.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsStopSong.ToolTipInitialDelay = 500;
            this.hsStopSong.ToolTipIsBallon = false;
            this.hsStopSong.ToolTipOwnerDraw = false;
            this.hsStopSong.ToolTipReshowDelay = 100;
            this.hsStopSong.ToolTipShowAlways = false;
            this.hsStopSong.ToolTipText = "";
            this.hsStopSong.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsStopSong.ToolTipTitle = "";
            this.hsStopSong.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsStopSong.UseVisualStyleBackColor = false;
            this.hsStopSong.Click += new System.EventHandler(this.hsStopSong_Click);
            // 
            // hsPauseSong
            // 
            this.hsPauseSong.BackColor = System.Drawing.Color.Transparent;
            this.hsPauseSong.BackColorHover = System.Drawing.Color.Transparent;
            this.hsPauseSong.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsPauseSong.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsPauseSong.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsPauseSong.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsPauseSong.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsPauseSong.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsPauseSong.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsPauseSong.FlatAppearance.BorderSize = 0;
            this.hsPauseSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsPauseSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsPauseSong.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsPauseSong.Image = global::SENotesNET.Properties.Resources.Pause_bl_x24;
            this.hsPauseSong.ImageHover = global::SENotesNET.Properties.Resources.Pause_gr_x24;
            this.hsPauseSong.ImageToggleOnSelect = false;
            this.hsPauseSong.Location = new System.Drawing.Point(27, 16);
            this.hsPauseSong.Marked = false;
            this.hsPauseSong.MarkedColor = System.Drawing.Color.Teal;
            this.hsPauseSong.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsPauseSong.MarkedText = "";
            this.hsPauseSong.MarkMode = false;
            this.hsPauseSong.Name = "hsPauseSong";
            this.hsPauseSong.NonMarkedText = "";
            this.hsPauseSong.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsPauseSong.ShowShortcut = false;
            this.hsPauseSong.Size = new System.Drawing.Size(24, 21);
            this.hsPauseSong.TabIndex = 24;
            this.hsPauseSong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsPauseSong.ToolTipActive = false;
            this.hsPauseSong.ToolTipAutomaticDelay = 500;
            this.hsPauseSong.ToolTipAutoPopDelay = 5000;
            this.hsPauseSong.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsPauseSong.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsPauseSong.ToolTipFor4ContextMenu = true;
            this.hsPauseSong.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsPauseSong.ToolTipInitialDelay = 500;
            this.hsPauseSong.ToolTipIsBallon = false;
            this.hsPauseSong.ToolTipOwnerDraw = false;
            this.hsPauseSong.ToolTipReshowDelay = 100;
            this.hsPauseSong.ToolTipShowAlways = false;
            this.hsPauseSong.ToolTipText = "";
            this.hsPauseSong.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsPauseSong.ToolTipTitle = "";
            this.hsPauseSong.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsPauseSong.UseVisualStyleBackColor = false;
            this.hsPauseSong.Click += new System.EventHandler(this.hsPauseSong_Click);
            // 
            // hsPlaySong
            // 
            this.hsPlaySong.BackColor = System.Drawing.Color.Transparent;
            this.hsPlaySong.BackColorHover = System.Drawing.Color.Transparent;
            this.hsPlaySong.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsPlaySong.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsPlaySong.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsPlaySong.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsPlaySong.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsPlaySong.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsPlaySong.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsPlaySong.FlatAppearance.BorderSize = 0;
            this.hsPlaySong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsPlaySong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsPlaySong.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsPlaySong.Image = global::SENotesNET.Properties.Resources.Play_bl_x24;
            this.hsPlaySong.ImageHover = global::SENotesNET.Properties.Resources.Play_gr_x24;
            this.hsPlaySong.ImageToggleOnSelect = false;
            this.hsPlaySong.Location = new System.Drawing.Point(3, 16);
            this.hsPlaySong.Marked = false;
            this.hsPlaySong.MarkedColor = System.Drawing.Color.Teal;
            this.hsPlaySong.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsPlaySong.MarkedText = "";
            this.hsPlaySong.MarkMode = false;
            this.hsPlaySong.Name = "hsPlaySong";
            this.hsPlaySong.NonMarkedText = "";
            this.hsPlaySong.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsPlaySong.ShowShortcut = false;
            this.hsPlaySong.Size = new System.Drawing.Size(24, 21);
            this.hsPlaySong.TabIndex = 23;
            this.hsPlaySong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsPlaySong.ToolTipActive = false;
            this.hsPlaySong.ToolTipAutomaticDelay = 500;
            this.hsPlaySong.ToolTipAutoPopDelay = 5000;
            this.hsPlaySong.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsPlaySong.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsPlaySong.ToolTipFor4ContextMenu = true;
            this.hsPlaySong.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsPlaySong.ToolTipInitialDelay = 500;
            this.hsPlaySong.ToolTipIsBallon = false;
            this.hsPlaySong.ToolTipOwnerDraw = false;
            this.hsPlaySong.ToolTipReshowDelay = 100;
            this.hsPlaySong.ToolTipShowAlways = false;
            this.hsPlaySong.ToolTipText = "";
            this.hsPlaySong.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsPlaySong.ToolTipTitle = "";
            this.hsPlaySong.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsPlaySong.UseVisualStyleBackColor = false;
            this.hsPlaySong.Click += new System.EventHandler(this.hsPlaySong_Click);
            // 
            // hsAutoStep
            // 
            this.hsAutoStep.BackColor = System.Drawing.Color.Transparent;
            this.hsAutoStep.BackColorHover = System.Drawing.Color.Transparent;
            this.hsAutoStep.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsAutoStep.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsAutoStep.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsAutoStep.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsAutoStep.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsAutoStep.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsAutoStep.FlatAppearance.BorderSize = 0;
            this.hsAutoStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsAutoStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsAutoStep.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsAutoStep.Image = global::SENotesNET.Properties.Resources.appointment_new_24;
            this.hsAutoStep.ImageHover = global::SENotesNET.Properties.Resources.appointment_remove_x24;
            this.hsAutoStep.ImageToggleOnSelect = false;
            this.hsAutoStep.Location = new System.Drawing.Point(43, 10);
            this.hsAutoStep.Marked = false;
            this.hsAutoStep.MarkedColor = System.Drawing.Color.Teal;
            this.hsAutoStep.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsAutoStep.MarkedText = "";
            this.hsAutoStep.MarkMode = false;
            this.hsAutoStep.Name = "hsAutoStep";
            this.hsAutoStep.NonMarkedText = "";
            this.hsAutoStep.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsAutoStep.ShowShortcut = false;
            this.hsAutoStep.Size = new System.Drawing.Size(31, 27);
            this.hsAutoStep.TabIndex = 27;
            this.hsAutoStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsAutoStep.ToolTipActive = false;
            this.hsAutoStep.ToolTipAutomaticDelay = 500;
            this.hsAutoStep.ToolTipAutoPopDelay = 5000;
            this.hsAutoStep.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsAutoStep.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsAutoStep.ToolTipFor4ContextMenu = true;
            this.hsAutoStep.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsAutoStep.ToolTipInitialDelay = 500;
            this.hsAutoStep.ToolTipIsBallon = false;
            this.hsAutoStep.ToolTipOwnerDraw = false;
            this.hsAutoStep.ToolTipReshowDelay = 100;
            this.hsAutoStep.ToolTipShowAlways = false;
            this.hsAutoStep.ToolTipText = "";
            this.hsAutoStep.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsAutoStep.ToolTipTitle = "";
            this.hsAutoStep.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsAutoStep.UseVisualStyleBackColor = false;
            this.hsAutoStep.Click += new System.EventHandler(this.hsAutoStep_Click);
            // 
            // hsRefresh
            // 
            this.hsRefresh.BackColor = System.Drawing.Color.Transparent;
            this.hsRefresh.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefresh.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefresh.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefresh.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefresh.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefresh.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsRefresh.FlatAppearance.BorderSize = 0;
            this.hsRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRefresh.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefresh.Image = global::SENotesNET.Properties.Resources.view_refresh_24x;
            this.hsRefresh.ImageHover = global::SENotesNET.Properties.Resources.view_refresh_2_24x;
            this.hsRefresh.ImageToggleOnSelect = false;
            this.hsRefresh.Location = new System.Drawing.Point(1398, 13);
            this.hsRefresh.Marked = false;
            this.hsRefresh.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefresh.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefresh.MarkedText = "";
            this.hsRefresh.MarkMode = false;
            this.hsRefresh.Name = "hsRefresh";
            this.hsRefresh.NonMarkedText = "";
            this.hsRefresh.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefresh.ShowShortcut = false;
            this.hsRefresh.Size = new System.Drawing.Size(24, 21);
            this.hsRefresh.TabIndex = 27;
            this.hsRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsRefresh.ToolTipActive = false;
            this.hsRefresh.ToolTipAutomaticDelay = 500;
            this.hsRefresh.ToolTipAutoPopDelay = 5000;
            this.hsRefresh.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefresh.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefresh.ToolTipFor4ContextMenu = true;
            this.hsRefresh.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefresh.ToolTipInitialDelay = 500;
            this.hsRefresh.ToolTipIsBallon = false;
            this.hsRefresh.ToolTipOwnerDraw = false;
            this.hsRefresh.ToolTipReshowDelay = 100;
            this.hsRefresh.ToolTipShowAlways = false;
            this.hsRefresh.ToolTipText = "";
            this.hsRefresh.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefresh.ToolTipTitle = "";
            this.hsRefresh.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefresh.UseVisualStyleBackColor = false;
            this.hsRefresh.Click += new System.EventHandler(this.hsRefresh_Click);
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 390);
            this.Controls.Add(this.pnlSheets);
            this.Controls.Add(this.pnlUpper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "NotesForm";
            this.Text = "NotesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotesForm_FormClosing);
            this.Load += new System.EventHandler(this.NotesForm_Load);
            this.Resize += new System.EventHandler(this.NotesForm_Resize);
            this.pnlUpper.ResumeLayout(false);
            this.gbPagePosition.ResumeLayout(false);
            this.gbVolume.ResumeLayout(false);
            this.gbMetronom.ResumeLayout(false);
            this.gbMetronom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMetronom)).EndInit();
            this.gbSongPlayer.ResumeLayout(false);
            this.gbSongPlayer.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown nPicHeightFactor;
        private System.Windows.Forms.NumericUpDown nPicWidth;
        private System.Windows.Forms.Label lblPicWidth;
        private System.Windows.Forms.Label lblPicHeightFactor;
        private System.Windows.Forms.NumericUpDown nPicStep;
        private System.Windows.Forms.Label lblPicStep;
        private System.Windows.Forms.NumericUpDown nAutoStep;
        private System.Windows.Forms.Timer timerAutoStep;
        private System.Windows.Forms.NumericUpDown nPicShowCount;
        private System.Windows.Forms.Label lblShowCount;
        private System.Windows.Forms.ProgressBar pbShownPages;
        private System.Windows.Forms.Timer tmSoundPlayer;
        private System.Windows.Forms.ProgressBar pbPlayMedia;
        private System.Windows.Forms.GroupBox gbSongPlayer;
        private System.Windows.Forms.GroupBox gbAutoStep;
        private System.Windows.Forms.GroupBox gbAttributes;
        private System.Windows.Forms.Label lblSoundPlayer;
        private System.Windows.Forms.GroupBox gbMetronom;
        private System.Windows.Forms.NumericUpDown nMetronom;
        private System.Windows.Forms.Label lblMetronomTempo;
        private System.Windows.Forms.Timer tmMetronom;
        private System.Windows.Forms.GroupBox gbVolume;
        private System.Windows.Forms.GroupBox gbPagePosition;
        private System.Windows.Forms.ProgressBar pbAutoStep;
        private SeControlsLib.HotSpot hsPlaySong;
        private SeControlsLib.HotSpot hsStopSong;
        private SeControlsLib.HotSpot hsPauseSong;
        private SeControlsLib.HotSpot hsClose;
        private SeControlsLib.HotSpot hsSoundUp;
        private SeControlsLib.HotSpot hsSoundDown;
        private SeControlsLib.HotSpot hsStartMetronom;
        private SeControlsLib.HotSpot hsAutoStep;
        private SeControlsLib.HotSpot hsSaveAttributes;
        private SeControlsLib.HotSpot hsDefaultSize;
        private SeControlsLib.HotSpot hsRefresh;
    }
}