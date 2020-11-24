namespace SENotesNET
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cmsSongs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddNewSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteSong = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gbSongName = new System.Windows.Forms.GroupBox();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.gbFileList = new System.Windows.Forms.GroupBox();
            this.lvFileList = new System.Windows.Forms.ListView();
            this.SortIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FiIeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Changed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsSongFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiReloadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExecuteMusicFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExportMuseScore2PDF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExportMuseScore2MP3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSetFileTypeSongfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetFileTypeMuseScore = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetFilePDFfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetFileText = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetFileMP3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSongFilesUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSongFileDown = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlEditFiles = new System.Windows.Forms.Panel();
            this.hsRemoveFile = new SeControlsLib.HotSpot();
            this.gbSortIndex = new System.Windows.Forms.GroupBox();
            this.hsSaveNewIndex = new SeControlsLib.HotSpot();
            this.txtSortIndex = new System.Windows.Forms.TextBox();
            this.hsAddSongFile = new SeControlsLib.HotSpot();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlEditSongLower = new System.Windows.Forms.Panel();
            this.gbGroup = new System.Windows.Forms.GroupBox();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.hsDeleteGroup = new SeControlsLib.HotSpot();
            this.hsInsertGroup = new SeControlsLib.HotSpot();
            this.gbOtherAttributes = new System.Windows.Forms.GroupBox();
            this.lblMetronomSpeed = new System.Windows.Forms.Label();
            this.txtMetronomsSpeed = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.gbOrigin = new System.Windows.Forms.GroupBox();
            this.cbOrigin = new System.Windows.Forms.ComboBox();
            this.hsDeleteOrigin = new SeControlsLib.HotSpot();
            this.hsInsertOrigin = new SeControlsLib.HotSpot();
            this.gbVariante = new System.Windows.Forms.GroupBox();
            this.cbVariante = new System.Windows.Forms.ComboBox();
            this.hsDeleteVariant = new SeControlsLib.HotSpot();
            this.hsInsertVariant = new SeControlsLib.HotSpot();
            this.gbSheetAttributes = new System.Windows.Forms.GroupBox();
            this.txtAutoStepTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPageShowCount = new System.Windows.Forms.TextBox();
            this.lblSheetShowCount = new System.Windows.Forms.Label();
            this.txtPageStep = new System.Windows.Forms.TextBox();
            this.lblSheetPages = new System.Windows.Forms.Label();
            this.txtSheetHeightFactor = new System.Windows.Forms.TextBox();
            this.lblSheetHeight = new System.Windows.Forms.Label();
            this.txtSheetWidth = new System.Windows.Forms.TextBox();
            this.lblSheetWidth = new System.Windows.Forms.Label();
            this.gbInstrument = new System.Windows.Forms.GroupBox();
            this.cbInstrument = new System.Windows.Forms.ComboBox();
            this.hsDeleteInstrument = new SeControlsLib.HotSpot();
            this.hsInsertInstrument = new SeControlsLib.HotSpot();
            this.gbClassification = new System.Windows.Forms.GroupBox();
            this.rbProfessional = new System.Windows.Forms.RadioButton();
            this.rbBeginners = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.rbIntermediate = new System.Windows.Forms.RadioButton();
            this.rbAdvanced = new System.Windows.Forms.RadioButton();
            this.rbDifficulty = new System.Windows.Forms.RadioButton();
            this.rbExperimantal = new System.Windows.Forms.RadioButton();
            this.gbInterpret = new System.Windows.Forms.GroupBox();
            this.cbInterpret = new System.Windows.Forms.ComboBox();
            this.hsDeleteInterpret = new SeControlsLib.HotSpot();
            this.hsSaveInterpret = new SeControlsLib.HotSpot();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hsNewSong = new SeControlsLib.HotSpot();
            this.hsUpdateSong = new SeControlsLib.HotSpot();
            this.gbSongGrid = new System.Windows.Forms.GroupBox();
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.hsRefresh = new SeControlsLib.HotSpot();
            this.hsClearRefresh = new SeControlsLib.HotSpot();
            this.gbFilterSongName = new System.Windows.Forms.GroupBox();
            this.txtFilterSongName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbInterpretFilter = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGroupFilter = new System.Windows.Forms.ComboBox();
            this.ckSortRating = new System.Windows.Forms.CheckBox();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.hsClose = new SeControlsLib.HotSpot();
            this.hsShowNotes = new SeControlsLib.HotSpot();
            this.hsMaintain = new SeControlsLib.HotSpot();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdDB = new System.Windows.Forms.OpenFileDialog();
            this.cmsSongs.SuspendLayout();
            this.gbSongName.SuspendLayout();
            this.gbFileList.SuspendLayout();
            this.cmsSongFiles.SuspendLayout();
            this.gbSortIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlEditSongLower.SuspendLayout();
            this.gbGroup.SuspendLayout();
            this.gbOtherAttributes.SuspendLayout();
            this.gbOrigin.SuspendLayout();
            this.gbVariante.SuspendLayout();
            this.gbSheetAttributes.SuspendLayout();
            this.gbInstrument.SuspendLayout();
            this.gbClassification.SuspendLayout();
            this.gbInterpret.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbSongGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.gbFilterSongName.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.upperPanel.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsSongs
            // 
            this.cmsSongs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddNewSong,
            this.tsmiDeleteSong});
            this.cmsSongs.Name = "contextMenuStrip1";
            this.cmsSongs.Size = new System.Drawing.Size(152, 48);
            this.cmsSongs.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip2_ItemClicked);
            // 
            // tsmiAddNewSong
            // 
            this.tsmiAddNewSong.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddNewSong.Image")));
            this.tsmiAddNewSong.Name = "tsmiAddNewSong";
            this.tsmiAddNewSong.Size = new System.Drawing.Size(151, 22);
            this.tsmiAddNewSong.Text = "Add new Song";
            // 
            // tsmiDeleteSong
            // 
            this.tsmiDeleteSong.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDeleteSong.Image")));
            this.tsmiDeleteSong.Name = "tsmiDeleteSong";
            this.tsmiDeleteSong.Size = new System.Drawing.Size(151, 22);
            this.tsmiDeleteSong.Text = "Delete Song";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "help_about_gn_x32.png");
            this.imageList1.Images.SetKeyName(1, "go_previous32x.png");
            this.imageList1.Images.SetKeyName(2, "floppy_x32.png");
            this.imageList1.Images.SetKeyName(3, "plus_gn32x.png");
            this.imageList1.Images.SetKeyName(4, "minus_rt32x.png");
            this.imageList1.Images.SetKeyName(5, "view_refresh32x.png");
            this.imageList1.Images.SetKeyName(6, "achtel_note_black.png");
            this.imageList1.Images.SetKeyName(7, "ok_gn32x.png");
            this.imageList1.Images.SetKeyName(8, "system_log_out_blue_32x.png");
            this.imageList1.Images.SetKeyName(9, "sweep_ge24x.png");
            this.imageList1.Images.SetKeyName(10, "database_arrow_r_x24.png");
            this.imageList1.Images.SetKeyName(11, "database_replication_x24.png");
            // 
            // gbSongName
            // 
            this.gbSongName.Controls.Add(this.txtSongName);
            this.gbSongName.Location = new System.Drawing.Point(10, 17);
            this.gbSongName.Name = "gbSongName";
            this.gbSongName.Size = new System.Drawing.Size(237, 41);
            this.gbSongName.TabIndex = 4;
            this.gbSongName.TabStop = false;
            this.gbSongName.Text = "Songname ";
            // 
            // txtSongName
            // 
            this.txtSongName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSongName.Location = new System.Drawing.Point(3, 16);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(231, 20);
            this.txtSongName.TabIndex = 0;
            this.txtSongName.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // gbFileList
            // 
            this.gbFileList.Controls.Add(this.lvFileList);
            this.gbFileList.Controls.Add(this.pnlEditFiles);
            this.gbFileList.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFileList.Location = new System.Drawing.Point(0, 45);
            this.gbFileList.Name = "gbFileList";
            this.gbFileList.Size = new System.Drawing.Size(807, 278);
            this.gbFileList.TabIndex = 5;
            this.gbFileList.TabStop = false;
            this.gbFileList.Text = "Filelist";
            // 
            // lvFileList
            // 
            this.lvFileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SortIndex,
            this.FiIeName,
            this.FileID,
            this.Changed,
            this.FileType});
            this.lvFileList.ContextMenuStrip = this.cmsSongFiles;
            this.lvFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFileList.FullRowSelect = true;
            this.lvFileList.HideSelection = false;
            this.lvFileList.Location = new System.Drawing.Point(3, 26);
            this.lvFileList.Name = "lvFileList";
            this.lvFileList.Size = new System.Drawing.Size(801, 249);
            this.lvFileList.TabIndex = 0;
            this.lvFileList.UseCompatibleStateImageBehavior = false;
            this.lvFileList.View = System.Windows.Forms.View.Details;
            this.lvFileList.SelectedIndexChanged += new System.EventHandler(this.lvFileList_SelectedIndexChanged);
            this.lvFileList.Click += new System.EventHandler(this.lvFileList_Click);
            this.lvFileList.Enter += new System.EventHandler(this.lvFileList_Enter);
            // 
            // SortIndex
            // 
            this.SortIndex.Name = "SortIndex";
            this.SortIndex.Text = "Nr";
            this.SortIndex.Width = 30;
            // 
            // FiIeName
            // 
            this.FiIeName.Name = "FiIeName";
            this.FiIeName.Text = "Orgin FiIe Name";
            this.FiIeName.Width = 450;
            // 
            // FileID
            // 
            this.FileID.Name = "FileID";
            this.FileID.Text = "FileID";
            this.FileID.Width = 250;
            // 
            // Changed
            // 
            this.Changed.Name = "Changed";
            this.Changed.Text = "Changed";
            // 
            // FileType
            // 
            this.FileType.Name = "FileType";
            this.FileType.Text = "File Type";
            this.FileType.Width = 120;
            // 
            // cmsSongFiles
            // 
            this.cmsSongFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReloadFile,
            this.toolStripSeparator2,
            this.tsmiExecuteMusicFile,
            this.tsmiExportMuseScore2PDF,
            this.tsmiExportMuseScore2MP3,
            this.toolStripSeparator1,
            this.tsmiSetFileTypeSongfile,
            this.tsmiSetFileTypeMuseScore,
            this.tsmiSetFilePDFfile,
            this.tsmiSetFileText,
            this.tsmiSetFileMP3,
            this.toolStripSeparator3,
            this.tsmiSongFilesUp,
            this.tsmiSongFileDown});
            this.cmsSongFiles.Name = "contextMenuStrip1";
            this.cmsSongFiles.Size = new System.Drawing.Size(208, 264);
            this.cmsSongFiles.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // tsmiReloadFile
            // 
            this.tsmiReloadFile.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReloadFile.Image")));
            this.tsmiReloadFile.Name = "tsmiReloadFile";
            this.tsmiReloadFile.Size = new System.Drawing.Size(207, 22);
            this.tsmiReloadFile.Text = "Reload file";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // tsmiExecuteMusicFile
            // 
            this.tsmiExecuteMusicFile.Image = ((System.Drawing.Image)(resources.GetObject("tsmiExecuteMusicFile.Image")));
            this.tsmiExecuteMusicFile.Name = "tsmiExecuteMusicFile";
            this.tsmiExecuteMusicFile.Size = new System.Drawing.Size(207, 22);
            this.tsmiExecuteMusicFile.Text = "Execute";
            // 
            // tsmiExportMuseScore2PDF
            // 
            this.tsmiExportMuseScore2PDF.Image = ((System.Drawing.Image)(resources.GetObject("tsmiExportMuseScore2PDF.Image")));
            this.tsmiExportMuseScore2PDF.Name = "tsmiExportMuseScore2PDF";
            this.tsmiExportMuseScore2PDF.Size = new System.Drawing.Size(207, 22);
            this.tsmiExportMuseScore2PDF.Text = "Export MuseScore to PDF";
            // 
            // tsmiExportMuseScore2MP3
            // 
            this.tsmiExportMuseScore2MP3.Image = ((System.Drawing.Image)(resources.GetObject("tsmiExportMuseScore2MP3.Image")));
            this.tsmiExportMuseScore2MP3.Name = "tsmiExportMuseScore2MP3";
            this.tsmiExportMuseScore2MP3.Size = new System.Drawing.Size(207, 22);
            this.tsmiExportMuseScore2MP3.Text = "Export to MP3";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // tsmiSetFileTypeSongfile
            // 
            this.tsmiSetFileTypeSongfile.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSetFileTypeSongfile.Image")));
            this.tsmiSetFileTypeSongfile.Name = "tsmiSetFileTypeSongfile";
            this.tsmiSetFileTypeSongfile.Size = new System.Drawing.Size(207, 22);
            this.tsmiSetFileTypeSongfile.Text = "Set to Songfile";
            // 
            // tsmiSetFileTypeMuseScore
            // 
            this.tsmiSetFileTypeMuseScore.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSetFileTypeMuseScore.Image")));
            this.tsmiSetFileTypeMuseScore.Name = "tsmiSetFileTypeMuseScore";
            this.tsmiSetFileTypeMuseScore.Size = new System.Drawing.Size(207, 22);
            this.tsmiSetFileTypeMuseScore.Text = "Set to MuseScore";
            // 
            // tsmiSetFilePDFfile
            // 
            this.tsmiSetFilePDFfile.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSetFilePDFfile.Image")));
            this.tsmiSetFilePDFfile.Name = "tsmiSetFilePDFfile";
            this.tsmiSetFilePDFfile.Size = new System.Drawing.Size(207, 22);
            this.tsmiSetFilePDFfile.Text = "Set to PDF File";
            // 
            // tsmiSetFileText
            // 
            this.tsmiSetFileText.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSetFileText.Image")));
            this.tsmiSetFileText.Name = "tsmiSetFileText";
            this.tsmiSetFileText.Size = new System.Drawing.Size(207, 22);
            this.tsmiSetFileText.Text = "Set to Info Text";
            // 
            // tsmiSetFileMP3
            // 
            this.tsmiSetFileMP3.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSetFileMP3.Image")));
            this.tsmiSetFileMP3.Name = "tsmiSetFileMP3";
            this.tsmiSetFileMP3.Size = new System.Drawing.Size(207, 22);
            this.tsmiSetFileMP3.Text = "Set to MP3 Audio";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(204, 6);
            // 
            // tsmiSongFilesUp
            // 
            this.tsmiSongFilesUp.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSongFilesUp.Image")));
            this.tsmiSongFilesUp.Name = "tsmiSongFilesUp";
            this.tsmiSongFilesUp.Size = new System.Drawing.Size(207, 22);
            this.tsmiSongFilesUp.Text = "Up";
            // 
            // tsmiSongFileDown
            // 
            this.tsmiSongFileDown.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSongFileDown.Image")));
            this.tsmiSongFileDown.Name = "tsmiSongFileDown";
            this.tsmiSongFileDown.Size = new System.Drawing.Size(207, 22);
            this.tsmiSongFileDown.Text = "Down";
            // 
            // pnlEditFiles
            // 
            this.pnlEditFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEditFiles.Location = new System.Drawing.Point(3, 16);
            this.pnlEditFiles.Name = "pnlEditFiles";
            this.pnlEditFiles.Size = new System.Drawing.Size(801, 10);
            this.pnlEditFiles.TabIndex = 2;
            // 
            // hsRemoveFile
            // 
            this.hsRemoveFile.BackColor = System.Drawing.Color.Transparent;
            this.hsRemoveFile.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRemoveFile.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRemoveFile.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRemoveFile.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRemoveFile.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRemoveFile.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRemoveFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsRemoveFile.FlatAppearance.BorderSize = 0;
            this.hsRemoveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRemoveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRemoveFile.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRemoveFile.Image = global::SENotesNET.Properties.Resources.minus_rt24x;
            this.hsRemoveFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsRemoveFile.ImageHover = global::SENotesNET.Properties.Resources.minus_blue24x;
            this.hsRemoveFile.ImageToggleOnSelect = false;
            this.hsRemoveFile.Location = new System.Drawing.Point(291, 3);
            this.hsRemoveFile.Marked = false;
            this.hsRemoveFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsRemoveFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRemoveFile.MarkedText = "";
            this.hsRemoveFile.MarkMode = false;
            this.hsRemoveFile.Name = "hsRemoveFile";
            this.hsRemoveFile.NonMarkedText = "";
            this.hsRemoveFile.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRemoveFile.ShowShortcut = false;
            this.hsRemoveFile.Size = new System.Drawing.Size(100, 36);
            this.hsRemoveFile.TabIndex = 14;
            this.hsRemoveFile.Text = "Remove file";
            this.hsRemoveFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsRemoveFile.ToolTipActive = false;
            this.hsRemoveFile.ToolTipAutomaticDelay = 500;
            this.hsRemoveFile.ToolTipAutoPopDelay = 5000;
            this.hsRemoveFile.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRemoveFile.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRemoveFile.ToolTipFor4ContextMenu = true;
            this.hsRemoveFile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRemoveFile.ToolTipInitialDelay = 500;
            this.hsRemoveFile.ToolTipIsBallon = false;
            this.hsRemoveFile.ToolTipOwnerDraw = false;
            this.hsRemoveFile.ToolTipReshowDelay = 100;
            this.hsRemoveFile.ToolTipShowAlways = false;
            this.hsRemoveFile.ToolTipText = "";
            this.hsRemoveFile.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRemoveFile.ToolTipTitle = "";
            this.hsRemoveFile.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRemoveFile.UseVisualStyleBackColor = false;
            this.hsRemoveFile.Click += new System.EventHandler(this.hsRemoveFile_Click);
            // 
            // gbSortIndex
            // 
            this.gbSortIndex.Controls.Add(this.hsSaveNewIndex);
            this.gbSortIndex.Controls.Add(this.txtSortIndex);
            this.gbSortIndex.Location = new System.Drawing.Point(397, 3);
            this.gbSortIndex.Name = "gbSortIndex";
            this.gbSortIndex.Size = new System.Drawing.Size(107, 42);
            this.gbSortIndex.TabIndex = 4;
            this.gbSortIndex.TabStop = false;
            this.gbSortIndex.Text = "Sort Index";
            // 
            // hsSaveNewIndex
            // 
            this.hsSaveNewIndex.BackColor = System.Drawing.Color.Transparent;
            this.hsSaveNewIndex.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSaveNewIndex.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSaveNewIndex.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSaveNewIndex.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSaveNewIndex.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSaveNewIndex.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSaveNewIndex.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsSaveNewIndex.FlatAppearance.BorderSize = 0;
            this.hsSaveNewIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSaveNewIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSaveNewIndex.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveNewIndex.Image = global::SENotesNET.Properties.Resources.ok_gn_24x;
            this.hsSaveNewIndex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsSaveNewIndex.ImageHover = global::SENotesNET.Properties.Resources.ok_blue_24x;
            this.hsSaveNewIndex.ImageToggleOnSelect = false;
            this.hsSaveNewIndex.Location = new System.Drawing.Point(70, 16);
            this.hsSaveNewIndex.Marked = false;
            this.hsSaveNewIndex.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveNewIndex.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveNewIndex.MarkedText = "";
            this.hsSaveNewIndex.MarkMode = false;
            this.hsSaveNewIndex.Name = "hsSaveNewIndex";
            this.hsSaveNewIndex.NonMarkedText = "";
            this.hsSaveNewIndex.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSaveNewIndex.ShowShortcut = false;
            this.hsSaveNewIndex.Size = new System.Drawing.Size(30, 21);
            this.hsSaveNewIndex.TabIndex = 15;
            this.hsSaveNewIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsSaveNewIndex.ToolTipActive = false;
            this.hsSaveNewIndex.ToolTipAutomaticDelay = 500;
            this.hsSaveNewIndex.ToolTipAutoPopDelay = 5000;
            this.hsSaveNewIndex.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSaveNewIndex.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSaveNewIndex.ToolTipFor4ContextMenu = true;
            this.hsSaveNewIndex.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSaveNewIndex.ToolTipInitialDelay = 500;
            this.hsSaveNewIndex.ToolTipIsBallon = false;
            this.hsSaveNewIndex.ToolTipOwnerDraw = false;
            this.hsSaveNewIndex.ToolTipReshowDelay = 100;
            this.hsSaveNewIndex.ToolTipShowAlways = false;
            this.hsSaveNewIndex.ToolTipText = "";
            this.hsSaveNewIndex.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSaveNewIndex.ToolTipTitle = "";
            this.hsSaveNewIndex.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSaveNewIndex.UseVisualStyleBackColor = false;
            this.hsSaveNewIndex.Click += new System.EventHandler(this.hsSaveNewIndex_Click);
            // 
            // txtSortIndex
            // 
            this.txtSortIndex.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSortIndex.Location = new System.Drawing.Point(3, 16);
            this.txtSortIndex.Name = "txtSortIndex";
            this.txtSortIndex.Size = new System.Drawing.Size(61, 20);
            this.txtSortIndex.TabIndex = 0;
            this.txtSortIndex.TextChanged += new System.EventHandler(this.txtSortIndex_TextChanged);
            // 
            // hsAddSongFile
            // 
            this.hsAddSongFile.BackColor = System.Drawing.Color.Transparent;
            this.hsAddSongFile.BackColorHover = System.Drawing.Color.Transparent;
            this.hsAddSongFile.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsAddSongFile.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsAddSongFile.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsAddSongFile.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsAddSongFile.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsAddSongFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsAddSongFile.FlatAppearance.BorderSize = 0;
            this.hsAddSongFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsAddSongFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsAddSongFile.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsAddSongFile.Image = global::SENotesNET.Properties.Resources.plus_gn_24x;
            this.hsAddSongFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsAddSongFile.ImageHover = global::SENotesNET.Properties.Resources.plus_blue_24x;
            this.hsAddSongFile.ImageToggleOnSelect = false;
            this.hsAddSongFile.Location = new System.Drawing.Point(197, 3);
            this.hsAddSongFile.Marked = false;
            this.hsAddSongFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsAddSongFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsAddSongFile.MarkedText = "";
            this.hsAddSongFile.MarkMode = false;
            this.hsAddSongFile.Name = "hsAddSongFile";
            this.hsAddSongFile.NonMarkedText = "";
            this.hsAddSongFile.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsAddSongFile.ShowShortcut = false;
            this.hsAddSongFile.Size = new System.Drawing.Size(88, 37);
            this.hsAddSongFile.TabIndex = 13;
            this.hsAddSongFile.Text = "Add file";
            this.hsAddSongFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsAddSongFile.ToolTipActive = false;
            this.hsAddSongFile.ToolTipAutomaticDelay = 500;
            this.hsAddSongFile.ToolTipAutoPopDelay = 5000;
            this.hsAddSongFile.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsAddSongFile.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsAddSongFile.ToolTipFor4ContextMenu = true;
            this.hsAddSongFile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsAddSongFile.ToolTipInitialDelay = 500;
            this.hsAddSongFile.ToolTipIsBallon = false;
            this.hsAddSongFile.ToolTipOwnerDraw = false;
            this.hsAddSongFile.ToolTipReshowDelay = 100;
            this.hsAddSongFile.ToolTipShowAlways = false;
            this.hsAddSongFile.ToolTipText = "";
            this.hsAddSongFile.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsAddSongFile.ToolTipTitle = "";
            this.hsAddSongFile.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsAddSongFile.UseVisualStyleBackColor = false;
            this.hsAddSongFile.Click += new System.EventHandler(this.hsNewSong_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 65);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlEditSongLower);
            this.splitContainer1.Panel1.Controls.Add(this.gbFileList);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbSongGrid);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(1852, 774);
            this.splitContainer1.SplitterDistance = 807;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 7;
            // 
            // pnlEditSongLower
            // 
            this.pnlEditSongLower.Controls.Add(this.gbGroup);
            this.pnlEditSongLower.Controls.Add(this.gbOtherAttributes);
            this.pnlEditSongLower.Controls.Add(this.gbOrigin);
            this.pnlEditSongLower.Controls.Add(this.gbVariante);
            this.pnlEditSongLower.Controls.Add(this.gbSheetAttributes);
            this.pnlEditSongLower.Controls.Add(this.gbInstrument);
            this.pnlEditSongLower.Controls.Add(this.gbSongName);
            this.pnlEditSongLower.Controls.Add(this.gbClassification);
            this.pnlEditSongLower.Controls.Add(this.gbInterpret);
            this.pnlEditSongLower.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEditSongLower.Location = new System.Drawing.Point(0, 323);
            this.pnlEditSongLower.Name = "pnlEditSongLower";
            this.pnlEditSongLower.Size = new System.Drawing.Size(807, 309);
            this.pnlEditSongLower.TabIndex = 7;
            // 
            // gbGroup
            // 
            this.gbGroup.Controls.Add(this.cbGroup);
            this.gbGroup.Controls.Add(this.hsDeleteGroup);
            this.gbGroup.Controls.Add(this.hsInsertGroup);
            this.gbGroup.Location = new System.Drawing.Point(9, 251);
            this.gbGroup.Name = "gbGroup";
            this.gbGroup.Size = new System.Drawing.Size(237, 41);
            this.gbGroup.TabIndex = 11;
            this.gbGroup.TabStop = false;
            this.gbGroup.Text = "Group";
            // 
            // cbGroup
            // 
            this.cbGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Items.AddRange(new object[] {
            "Akkordeon",
            "Piano",
            "Harp"});
            this.cbGroup.Location = new System.Drawing.Point(3, 16);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(183, 21);
            this.cbGroup.TabIndex = 8;
            this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.dataChanged);
            this.cbGroup.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // hsDeleteGroup
            // 
            this.hsDeleteGroup.BackColor = System.Drawing.Color.Transparent;
            this.hsDeleteGroup.BackColorHover = System.Drawing.Color.Transparent;
            this.hsDeleteGroup.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsDeleteGroup.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsDeleteGroup.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsDeleteGroup.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsDeleteGroup.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsDeleteGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsDeleteGroup.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsDeleteGroup.FlatAppearance.BorderSize = 0;
            this.hsDeleteGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsDeleteGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsDeleteGroup.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsDeleteGroup.Image = global::SENotesNET.Properties.Resources.minus_rt24x;
            this.hsDeleteGroup.ImageHover = global::SENotesNET.Properties.Resources.minus_blue24x;
            this.hsDeleteGroup.ImageToggleOnSelect = false;
            this.hsDeleteGroup.Location = new System.Drawing.Point(186, 16);
            this.hsDeleteGroup.Marked = false;
            this.hsDeleteGroup.MarkedColor = System.Drawing.Color.Teal;
            this.hsDeleteGroup.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDeleteGroup.MarkedText = "";
            this.hsDeleteGroup.MarkMode = false;
            this.hsDeleteGroup.Name = "hsDeleteGroup";
            this.hsDeleteGroup.NonMarkedText = "";
            this.hsDeleteGroup.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsDeleteGroup.ShowShortcut = false;
            this.hsDeleteGroup.Size = new System.Drawing.Size(24, 22);
            this.hsDeleteGroup.TabIndex = 18;
            this.hsDeleteGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsDeleteGroup.ToolTipActive = false;
            this.hsDeleteGroup.ToolTipAutomaticDelay = 500;
            this.hsDeleteGroup.ToolTipAutoPopDelay = 5000;
            this.hsDeleteGroup.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsDeleteGroup.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsDeleteGroup.ToolTipFor4ContextMenu = true;
            this.hsDeleteGroup.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsDeleteGroup.ToolTipInitialDelay = 500;
            this.hsDeleteGroup.ToolTipIsBallon = false;
            this.hsDeleteGroup.ToolTipOwnerDraw = false;
            this.hsDeleteGroup.ToolTipReshowDelay = 100;
            this.hsDeleteGroup.ToolTipShowAlways = false;
            this.hsDeleteGroup.ToolTipText = "";
            this.hsDeleteGroup.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsDeleteGroup.ToolTipTitle = "";
            this.hsDeleteGroup.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsDeleteGroup.UseVisualStyleBackColor = false;
            this.hsDeleteGroup.Click += new System.EventHandler(this.hsDeleteGroup_Click);
            // 
            // hsInsertGroup
            // 
            this.hsInsertGroup.BackColor = System.Drawing.Color.Transparent;
            this.hsInsertGroup.BackColorHover = System.Drawing.Color.Transparent;
            this.hsInsertGroup.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsInsertGroup.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsInsertGroup.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsInsertGroup.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsInsertGroup.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsInsertGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsInsertGroup.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsInsertGroup.FlatAppearance.BorderSize = 0;
            this.hsInsertGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsInsertGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsInsertGroup.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsInsertGroup.Image = global::SENotesNET.Properties.Resources.plus_gn_24x;
            this.hsInsertGroup.ImageHover = global::SENotesNET.Properties.Resources.plus_blue_24x;
            this.hsInsertGroup.ImageToggleOnSelect = false;
            this.hsInsertGroup.Location = new System.Drawing.Point(210, 16);
            this.hsInsertGroup.Marked = false;
            this.hsInsertGroup.MarkedColor = System.Drawing.Color.Teal;
            this.hsInsertGroup.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsInsertGroup.MarkedText = "";
            this.hsInsertGroup.MarkMode = false;
            this.hsInsertGroup.Name = "hsInsertGroup";
            this.hsInsertGroup.NonMarkedText = "";
            this.hsInsertGroup.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsInsertGroup.ShowShortcut = false;
            this.hsInsertGroup.Size = new System.Drawing.Size(24, 22);
            this.hsInsertGroup.TabIndex = 17;
            this.hsInsertGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsInsertGroup.ToolTipActive = false;
            this.hsInsertGroup.ToolTipAutomaticDelay = 500;
            this.hsInsertGroup.ToolTipAutoPopDelay = 5000;
            this.hsInsertGroup.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsInsertGroup.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsInsertGroup.ToolTipFor4ContextMenu = true;
            this.hsInsertGroup.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsInsertGroup.ToolTipInitialDelay = 500;
            this.hsInsertGroup.ToolTipIsBallon = false;
            this.hsInsertGroup.ToolTipOwnerDraw = false;
            this.hsInsertGroup.ToolTipReshowDelay = 100;
            this.hsInsertGroup.ToolTipShowAlways = false;
            this.hsInsertGroup.ToolTipText = "";
            this.hsInsertGroup.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsInsertGroup.ToolTipTitle = "";
            this.hsInsertGroup.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsInsertGroup.UseVisualStyleBackColor = false;
            this.hsInsertGroup.Click += new System.EventHandler(this.hsInsertGroup_Click);
            // 
            // gbOtherAttributes
            // 
            this.gbOtherAttributes.Controls.Add(this.lblMetronomSpeed);
            this.gbOtherAttributes.Controls.Add(this.txtMetronomsSpeed);
            this.gbOtherAttributes.Controls.Add(this.lblRating);
            this.gbOtherAttributes.Controls.Add(this.txtRating);
            this.gbOtherAttributes.Location = new System.Drawing.Point(379, 198);
            this.gbOtherAttributes.Name = "gbOtherAttributes";
            this.gbOtherAttributes.Size = new System.Drawing.Size(163, 81);
            this.gbOtherAttributes.TabIndex = 10;
            this.gbOtherAttributes.TabStop = false;
            this.gbOtherAttributes.Text = "Other Attributes";
            // 
            // lblMetronomSpeed
            // 
            this.lblMetronomSpeed.AutoSize = true;
            this.lblMetronomSpeed.Location = new System.Drawing.Point(6, 49);
            this.lblMetronomSpeed.Name = "lblMetronomSpeed";
            this.lblMetronomSpeed.Size = new System.Drawing.Size(88, 13);
            this.lblMetronomSpeed.TabIndex = 2;
            this.lblMetronomSpeed.Text = "Metronom Speed";
            // 
            // txtMetronomsSpeed
            // 
            this.txtMetronomsSpeed.Location = new System.Drawing.Point(101, 49);
            this.txtMetronomsSpeed.Name = "txtMetronomsSpeed";
            this.txtMetronomsSpeed.Size = new System.Drawing.Size(52, 20);
            this.txtMetronomsSpeed.TabIndex = 0;
            this.txtMetronomsSpeed.Text = "90";
            this.txtMetronomsSpeed.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(5, 19);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 1;
            this.lblRating.Text = "Rating";
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(101, 21);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(52, 20);
            this.txtRating.TabIndex = 0;
            this.txtRating.Text = "0";
            this.txtRating.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // gbOrigin
            // 
            this.gbOrigin.Controls.Add(this.cbOrigin);
            this.gbOrigin.Controls.Add(this.hsDeleteOrigin);
            this.gbOrigin.Controls.Add(this.hsInsertOrigin);
            this.gbOrigin.Location = new System.Drawing.Point(9, 203);
            this.gbOrigin.Name = "gbOrigin";
            this.gbOrigin.Size = new System.Drawing.Size(237, 41);
            this.gbOrigin.TabIndex = 9;
            this.gbOrigin.TabStop = false;
            this.gbOrigin.Text = "Origin";
            // 
            // cbOrigin
            // 
            this.cbOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbOrigin.FormattingEnabled = true;
            this.cbOrigin.Items.AddRange(new object[] {
            "Akkordeon",
            "Piano",
            "Harp"});
            this.cbOrigin.Location = new System.Drawing.Point(3, 16);
            this.cbOrigin.Name = "cbOrigin";
            this.cbOrigin.Size = new System.Drawing.Size(183, 21);
            this.cbOrigin.TabIndex = 8;
            this.cbOrigin.SelectedIndexChanged += new System.EventHandler(this.dataChanged);
            this.cbOrigin.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // hsDeleteOrigin
            // 
            this.hsDeleteOrigin.BackColor = System.Drawing.Color.Transparent;
            this.hsDeleteOrigin.BackColorHover = System.Drawing.Color.Transparent;
            this.hsDeleteOrigin.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsDeleteOrigin.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsDeleteOrigin.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsDeleteOrigin.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsDeleteOrigin.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsDeleteOrigin.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsDeleteOrigin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsDeleteOrigin.FlatAppearance.BorderSize = 0;
            this.hsDeleteOrigin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsDeleteOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsDeleteOrigin.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsDeleteOrigin.Image = global::SENotesNET.Properties.Resources.minus_rt24x;
            this.hsDeleteOrigin.ImageHover = global::SENotesNET.Properties.Resources.minus_blue24x;
            this.hsDeleteOrigin.ImageToggleOnSelect = false;
            this.hsDeleteOrigin.Location = new System.Drawing.Point(186, 16);
            this.hsDeleteOrigin.Marked = false;
            this.hsDeleteOrigin.MarkedColor = System.Drawing.Color.Teal;
            this.hsDeleteOrigin.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDeleteOrigin.MarkedText = "";
            this.hsDeleteOrigin.MarkMode = false;
            this.hsDeleteOrigin.Name = "hsDeleteOrigin";
            this.hsDeleteOrigin.NonMarkedText = "";
            this.hsDeleteOrigin.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsDeleteOrigin.ShowShortcut = false;
            this.hsDeleteOrigin.Size = new System.Drawing.Size(24, 22);
            this.hsDeleteOrigin.TabIndex = 18;
            this.hsDeleteOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsDeleteOrigin.ToolTipActive = false;
            this.hsDeleteOrigin.ToolTipAutomaticDelay = 500;
            this.hsDeleteOrigin.ToolTipAutoPopDelay = 5000;
            this.hsDeleteOrigin.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsDeleteOrigin.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsDeleteOrigin.ToolTipFor4ContextMenu = true;
            this.hsDeleteOrigin.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsDeleteOrigin.ToolTipInitialDelay = 500;
            this.hsDeleteOrigin.ToolTipIsBallon = false;
            this.hsDeleteOrigin.ToolTipOwnerDraw = false;
            this.hsDeleteOrigin.ToolTipReshowDelay = 100;
            this.hsDeleteOrigin.ToolTipShowAlways = false;
            this.hsDeleteOrigin.ToolTipText = "";
            this.hsDeleteOrigin.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsDeleteOrigin.ToolTipTitle = "";
            this.hsDeleteOrigin.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsDeleteOrigin.UseVisualStyleBackColor = false;
            this.hsDeleteOrigin.Click += new System.EventHandler(this.hsDeleteOrigin_Click);
            // 
            // hsInsertOrigin
            // 
            this.hsInsertOrigin.BackColor = System.Drawing.Color.Transparent;
            this.hsInsertOrigin.BackColorHover = System.Drawing.Color.Transparent;
            this.hsInsertOrigin.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsInsertOrigin.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsInsertOrigin.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsInsertOrigin.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsInsertOrigin.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsInsertOrigin.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsInsertOrigin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsInsertOrigin.FlatAppearance.BorderSize = 0;
            this.hsInsertOrigin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsInsertOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsInsertOrigin.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsInsertOrigin.Image = global::SENotesNET.Properties.Resources.plus_gn_24x;
            this.hsInsertOrigin.ImageHover = global::SENotesNET.Properties.Resources.plus_blue_24x;
            this.hsInsertOrigin.ImageToggleOnSelect = false;
            this.hsInsertOrigin.Location = new System.Drawing.Point(210, 16);
            this.hsInsertOrigin.Marked = false;
            this.hsInsertOrigin.MarkedColor = System.Drawing.Color.Teal;
            this.hsInsertOrigin.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsInsertOrigin.MarkedText = "";
            this.hsInsertOrigin.MarkMode = false;
            this.hsInsertOrigin.Name = "hsInsertOrigin";
            this.hsInsertOrigin.NonMarkedText = "";
            this.hsInsertOrigin.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsInsertOrigin.ShowShortcut = false;
            this.hsInsertOrigin.Size = new System.Drawing.Size(24, 22);
            this.hsInsertOrigin.TabIndex = 17;
            this.hsInsertOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsInsertOrigin.ToolTipActive = false;
            this.hsInsertOrigin.ToolTipAutomaticDelay = 500;
            this.hsInsertOrigin.ToolTipAutoPopDelay = 5000;
            this.hsInsertOrigin.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsInsertOrigin.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsInsertOrigin.ToolTipFor4ContextMenu = true;
            this.hsInsertOrigin.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsInsertOrigin.ToolTipInitialDelay = 500;
            this.hsInsertOrigin.ToolTipIsBallon = false;
            this.hsInsertOrigin.ToolTipOwnerDraw = false;
            this.hsInsertOrigin.ToolTipReshowDelay = 100;
            this.hsInsertOrigin.ToolTipShowAlways = false;
            this.hsInsertOrigin.ToolTipText = "";
            this.hsInsertOrigin.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsInsertOrigin.ToolTipTitle = "";
            this.hsInsertOrigin.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsInsertOrigin.UseVisualStyleBackColor = false;
            this.hsInsertOrigin.Click += new System.EventHandler(this.hsInsertOrigin_Click);
            // 
            // gbVariante
            // 
            this.gbVariante.Controls.Add(this.cbVariante);
            this.gbVariante.Controls.Add(this.hsDeleteVariant);
            this.gbVariante.Controls.Add(this.hsInsertVariant);
            this.gbVariante.Location = new System.Drawing.Point(10, 156);
            this.gbVariante.Name = "gbVariante";
            this.gbVariante.Size = new System.Drawing.Size(237, 41);
            this.gbVariante.TabIndex = 8;
            this.gbVariante.TabStop = false;
            this.gbVariante.Text = "Variante";
            // 
            // cbVariante
            // 
            this.cbVariante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbVariante.FormattingEnabled = true;
            this.cbVariante.Items.AddRange(new object[] {
            "Akkordeon",
            "Piano",
            "Harp"});
            this.cbVariante.Location = new System.Drawing.Point(3, 16);
            this.cbVariante.Name = "cbVariante";
            this.cbVariante.Size = new System.Drawing.Size(183, 21);
            this.cbVariante.TabIndex = 8;
            this.cbVariante.SelectedIndexChanged += new System.EventHandler(this.dataChanged);
            this.cbVariante.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // hsDeleteVariant
            // 
            this.hsDeleteVariant.BackColor = System.Drawing.Color.Transparent;
            this.hsDeleteVariant.BackColorHover = System.Drawing.Color.Transparent;
            this.hsDeleteVariant.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsDeleteVariant.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsDeleteVariant.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsDeleteVariant.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsDeleteVariant.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsDeleteVariant.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsDeleteVariant.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsDeleteVariant.FlatAppearance.BorderSize = 0;
            this.hsDeleteVariant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsDeleteVariant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsDeleteVariant.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsDeleteVariant.Image = global::SENotesNET.Properties.Resources.minus_rt24x;
            this.hsDeleteVariant.ImageHover = global::SENotesNET.Properties.Resources.minus_blue24x;
            this.hsDeleteVariant.ImageToggleOnSelect = false;
            this.hsDeleteVariant.Location = new System.Drawing.Point(186, 16);
            this.hsDeleteVariant.Marked = false;
            this.hsDeleteVariant.MarkedColor = System.Drawing.Color.Teal;
            this.hsDeleteVariant.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDeleteVariant.MarkedText = "";
            this.hsDeleteVariant.MarkMode = false;
            this.hsDeleteVariant.Name = "hsDeleteVariant";
            this.hsDeleteVariant.NonMarkedText = "";
            this.hsDeleteVariant.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsDeleteVariant.ShowShortcut = false;
            this.hsDeleteVariant.Size = new System.Drawing.Size(24, 22);
            this.hsDeleteVariant.TabIndex = 18;
            this.hsDeleteVariant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsDeleteVariant.ToolTipActive = false;
            this.hsDeleteVariant.ToolTipAutomaticDelay = 500;
            this.hsDeleteVariant.ToolTipAutoPopDelay = 5000;
            this.hsDeleteVariant.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsDeleteVariant.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsDeleteVariant.ToolTipFor4ContextMenu = true;
            this.hsDeleteVariant.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsDeleteVariant.ToolTipInitialDelay = 500;
            this.hsDeleteVariant.ToolTipIsBallon = false;
            this.hsDeleteVariant.ToolTipOwnerDraw = false;
            this.hsDeleteVariant.ToolTipReshowDelay = 100;
            this.hsDeleteVariant.ToolTipShowAlways = false;
            this.hsDeleteVariant.ToolTipText = "";
            this.hsDeleteVariant.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsDeleteVariant.ToolTipTitle = "";
            this.hsDeleteVariant.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsDeleteVariant.UseVisualStyleBackColor = false;
            this.hsDeleteVariant.Click += new System.EventHandler(this.hsDeleteVariant_Click);
            // 
            // hsInsertVariant
            // 
            this.hsInsertVariant.BackColor = System.Drawing.Color.Transparent;
            this.hsInsertVariant.BackColorHover = System.Drawing.Color.Transparent;
            this.hsInsertVariant.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsInsertVariant.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsInsertVariant.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsInsertVariant.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsInsertVariant.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsInsertVariant.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsInsertVariant.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsInsertVariant.FlatAppearance.BorderSize = 0;
            this.hsInsertVariant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsInsertVariant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsInsertVariant.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsInsertVariant.Image = global::SENotesNET.Properties.Resources.plus_gn_24x;
            this.hsInsertVariant.ImageHover = global::SENotesNET.Properties.Resources.plus_blue_24x;
            this.hsInsertVariant.ImageToggleOnSelect = false;
            this.hsInsertVariant.Location = new System.Drawing.Point(210, 16);
            this.hsInsertVariant.Marked = false;
            this.hsInsertVariant.MarkedColor = System.Drawing.Color.Teal;
            this.hsInsertVariant.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsInsertVariant.MarkedText = "";
            this.hsInsertVariant.MarkMode = false;
            this.hsInsertVariant.Name = "hsInsertVariant";
            this.hsInsertVariant.NonMarkedText = "";
            this.hsInsertVariant.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsInsertVariant.ShowShortcut = false;
            this.hsInsertVariant.Size = new System.Drawing.Size(24, 22);
            this.hsInsertVariant.TabIndex = 17;
            this.hsInsertVariant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsInsertVariant.ToolTipActive = false;
            this.hsInsertVariant.ToolTipAutomaticDelay = 500;
            this.hsInsertVariant.ToolTipAutoPopDelay = 5000;
            this.hsInsertVariant.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsInsertVariant.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsInsertVariant.ToolTipFor4ContextMenu = true;
            this.hsInsertVariant.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsInsertVariant.ToolTipInitialDelay = 500;
            this.hsInsertVariant.ToolTipIsBallon = false;
            this.hsInsertVariant.ToolTipOwnerDraw = false;
            this.hsInsertVariant.ToolTipReshowDelay = 100;
            this.hsInsertVariant.ToolTipShowAlways = false;
            this.hsInsertVariant.ToolTipText = "";
            this.hsInsertVariant.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsInsertVariant.ToolTipTitle = "";
            this.hsInsertVariant.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsInsertVariant.UseVisualStyleBackColor = false;
            this.hsInsertVariant.Click += new System.EventHandler(this.hsInsertVariant_Click);
            // 
            // gbSheetAttributes
            // 
            this.gbSheetAttributes.Controls.Add(this.txtAutoStepTime);
            this.gbSheetAttributes.Controls.Add(this.label1);
            this.gbSheetAttributes.Controls.Add(this.txtPageShowCount);
            this.gbSheetAttributes.Controls.Add(this.lblSheetShowCount);
            this.gbSheetAttributes.Controls.Add(this.txtPageStep);
            this.gbSheetAttributes.Controls.Add(this.lblSheetPages);
            this.gbSheetAttributes.Controls.Add(this.txtSheetHeightFactor);
            this.gbSheetAttributes.Controls.Add(this.lblSheetHeight);
            this.gbSheetAttributes.Controls.Add(this.txtSheetWidth);
            this.gbSheetAttributes.Controls.Add(this.lblSheetWidth);
            this.gbSheetAttributes.Location = new System.Drawing.Point(379, 17);
            this.gbSheetAttributes.Name = "gbSheetAttributes";
            this.gbSheetAttributes.Size = new System.Drawing.Size(163, 175);
            this.gbSheetAttributes.TabIndex = 7;
            this.gbSheetAttributes.TabStop = false;
            this.gbSheetAttributes.Text = "Sheet Attributes";
            // 
            // txtAutoStepTime
            // 
            this.txtAutoStepTime.Location = new System.Drawing.Point(101, 140);
            this.txtAutoStepTime.Name = "txtAutoStepTime";
            this.txtAutoStepTime.Size = new System.Drawing.Size(52, 20);
            this.txtAutoStepTime.TabIndex = 5;
            this.txtAutoStepTime.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Autostep Time (s)";
            // 
            // txtPageShowCount
            // 
            this.txtPageShowCount.Location = new System.Drawing.Point(101, 112);
            this.txtPageShowCount.Name = "txtPageShowCount";
            this.txtPageShowCount.Size = new System.Drawing.Size(52, 20);
            this.txtPageShowCount.TabIndex = 3;
            this.txtPageShowCount.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // lblSheetShowCount
            // 
            this.lblSheetShowCount.AutoSize = true;
            this.lblSheetShowCount.Location = new System.Drawing.Point(5, 114);
            this.lblSheetShowCount.Name = "lblSheetShowCount";
            this.lblSheetShowCount.Size = new System.Drawing.Size(98, 13);
            this.lblSheetShowCount.TabIndex = 2;
            this.lblSheetShowCount.Text = "Sheet Show Pages";
            // 
            // txtPageStep
            // 
            this.txtPageStep.Location = new System.Drawing.Point(101, 81);
            this.txtPageStep.Name = "txtPageStep";
            this.txtPageStep.Size = new System.Drawing.Size(52, 20);
            this.txtPageStep.TabIndex = 1;
            this.txtPageStep.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // lblSheetPages
            // 
            this.lblSheetPages.AutoSize = true;
            this.lblSheetPages.Location = new System.Drawing.Point(5, 84);
            this.lblSheetPages.Name = "lblSheetPages";
            this.lblSheetPages.Size = new System.Drawing.Size(93, 13);
            this.lblSheetPages.TabIndex = 0;
            this.lblSheetPages.Text = "Sheet Step Pages";
            // 
            // txtSheetHeightFactor
            // 
            this.txtSheetHeightFactor.Location = new System.Drawing.Point(101, 52);
            this.txtSheetHeightFactor.Name = "txtSheetHeightFactor";
            this.txtSheetHeightFactor.Size = new System.Drawing.Size(52, 20);
            this.txtSheetHeightFactor.TabIndex = 1;
            this.txtSheetHeightFactor.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // lblSheetHeight
            // 
            this.lblSheetHeight.AutoSize = true;
            this.lblSheetHeight.Location = new System.Drawing.Point(5, 55);
            this.lblSheetHeight.Name = "lblSheetHeight";
            this.lblSheetHeight.Size = new System.Drawing.Size(69, 13);
            this.lblSheetHeight.TabIndex = 0;
            this.lblSheetHeight.Text = "Sheet Height";
            // 
            // txtSheetWidth
            // 
            this.txtSheetWidth.Location = new System.Drawing.Point(101, 23);
            this.txtSheetWidth.Name = "txtSheetWidth";
            this.txtSheetWidth.Size = new System.Drawing.Size(52, 20);
            this.txtSheetWidth.TabIndex = 1;
            this.txtSheetWidth.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // lblSheetWidth
            // 
            this.lblSheetWidth.AutoSize = true;
            this.lblSheetWidth.Location = new System.Drawing.Point(5, 25);
            this.lblSheetWidth.Name = "lblSheetWidth";
            this.lblSheetWidth.Size = new System.Drawing.Size(66, 13);
            this.lblSheetWidth.TabIndex = 0;
            this.lblSheetWidth.Text = "Sheet Width";
            // 
            // gbInstrument
            // 
            this.gbInstrument.Controls.Add(this.cbInstrument);
            this.gbInstrument.Controls.Add(this.hsDeleteInstrument);
            this.gbInstrument.Controls.Add(this.hsInsertInstrument);
            this.gbInstrument.Location = new System.Drawing.Point(10, 109);
            this.gbInstrument.Name = "gbInstrument";
            this.gbInstrument.Size = new System.Drawing.Size(237, 41);
            this.gbInstrument.TabIndex = 4;
            this.gbInstrument.TabStop = false;
            this.gbInstrument.Text = "Instrument";
            // 
            // cbInstrument
            // 
            this.cbInstrument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbInstrument.FormattingEnabled = true;
            this.cbInstrument.Items.AddRange(new object[] {
            "Akkordeon",
            "Piano",
            "Harp"});
            this.cbInstrument.Location = new System.Drawing.Point(3, 16);
            this.cbInstrument.Name = "cbInstrument";
            this.cbInstrument.Size = new System.Drawing.Size(183, 21);
            this.cbInstrument.TabIndex = 8;
            this.cbInstrument.SelectedIndexChanged += new System.EventHandler(this.dataChanged);
            this.cbInstrument.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // hsDeleteInstrument
            // 
            this.hsDeleteInstrument.BackColor = System.Drawing.Color.Transparent;
            this.hsDeleteInstrument.BackColorHover = System.Drawing.Color.Transparent;
            this.hsDeleteInstrument.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsDeleteInstrument.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsDeleteInstrument.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsDeleteInstrument.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsDeleteInstrument.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsDeleteInstrument.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsDeleteInstrument.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsDeleteInstrument.FlatAppearance.BorderSize = 0;
            this.hsDeleteInstrument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsDeleteInstrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsDeleteInstrument.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsDeleteInstrument.Image = global::SENotesNET.Properties.Resources.minus_rt24x;
            this.hsDeleteInstrument.ImageHover = global::SENotesNET.Properties.Resources.minus_blue24x;
            this.hsDeleteInstrument.ImageToggleOnSelect = false;
            this.hsDeleteInstrument.Location = new System.Drawing.Point(186, 16);
            this.hsDeleteInstrument.Marked = false;
            this.hsDeleteInstrument.MarkedColor = System.Drawing.Color.Teal;
            this.hsDeleteInstrument.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDeleteInstrument.MarkedText = "";
            this.hsDeleteInstrument.MarkMode = false;
            this.hsDeleteInstrument.Name = "hsDeleteInstrument";
            this.hsDeleteInstrument.NonMarkedText = "";
            this.hsDeleteInstrument.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsDeleteInstrument.ShowShortcut = false;
            this.hsDeleteInstrument.Size = new System.Drawing.Size(24, 22);
            this.hsDeleteInstrument.TabIndex = 18;
            this.hsDeleteInstrument.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsDeleteInstrument.ToolTipActive = false;
            this.hsDeleteInstrument.ToolTipAutomaticDelay = 500;
            this.hsDeleteInstrument.ToolTipAutoPopDelay = 5000;
            this.hsDeleteInstrument.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsDeleteInstrument.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsDeleteInstrument.ToolTipFor4ContextMenu = true;
            this.hsDeleteInstrument.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsDeleteInstrument.ToolTipInitialDelay = 500;
            this.hsDeleteInstrument.ToolTipIsBallon = false;
            this.hsDeleteInstrument.ToolTipOwnerDraw = false;
            this.hsDeleteInstrument.ToolTipReshowDelay = 100;
            this.hsDeleteInstrument.ToolTipShowAlways = false;
            this.hsDeleteInstrument.ToolTipText = "";
            this.hsDeleteInstrument.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsDeleteInstrument.ToolTipTitle = "";
            this.hsDeleteInstrument.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsDeleteInstrument.UseVisualStyleBackColor = false;
            this.hsDeleteInstrument.Click += new System.EventHandler(this.hsDeleteInstrument_Click);
            // 
            // hsInsertInstrument
            // 
            this.hsInsertInstrument.BackColor = System.Drawing.Color.Transparent;
            this.hsInsertInstrument.BackColorHover = System.Drawing.Color.Transparent;
            this.hsInsertInstrument.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsInsertInstrument.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsInsertInstrument.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsInsertInstrument.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsInsertInstrument.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsInsertInstrument.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsInsertInstrument.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsInsertInstrument.FlatAppearance.BorderSize = 0;
            this.hsInsertInstrument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsInsertInstrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsInsertInstrument.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsInsertInstrument.Image = global::SENotesNET.Properties.Resources.plus_gn_24x;
            this.hsInsertInstrument.ImageHover = global::SENotesNET.Properties.Resources.plus_blue_24x;
            this.hsInsertInstrument.ImageToggleOnSelect = false;
            this.hsInsertInstrument.Location = new System.Drawing.Point(210, 16);
            this.hsInsertInstrument.Marked = false;
            this.hsInsertInstrument.MarkedColor = System.Drawing.Color.Teal;
            this.hsInsertInstrument.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsInsertInstrument.MarkedText = "";
            this.hsInsertInstrument.MarkMode = false;
            this.hsInsertInstrument.Name = "hsInsertInstrument";
            this.hsInsertInstrument.NonMarkedText = "";
            this.hsInsertInstrument.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsInsertInstrument.ShowShortcut = false;
            this.hsInsertInstrument.Size = new System.Drawing.Size(24, 22);
            this.hsInsertInstrument.TabIndex = 17;
            this.hsInsertInstrument.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsInsertInstrument.ToolTipActive = false;
            this.hsInsertInstrument.ToolTipAutomaticDelay = 500;
            this.hsInsertInstrument.ToolTipAutoPopDelay = 5000;
            this.hsInsertInstrument.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsInsertInstrument.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsInsertInstrument.ToolTipFor4ContextMenu = true;
            this.hsInsertInstrument.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsInsertInstrument.ToolTipInitialDelay = 500;
            this.hsInsertInstrument.ToolTipIsBallon = false;
            this.hsInsertInstrument.ToolTipOwnerDraw = false;
            this.hsInsertInstrument.ToolTipReshowDelay = 100;
            this.hsInsertInstrument.ToolTipShowAlways = false;
            this.hsInsertInstrument.ToolTipText = "";
            this.hsInsertInstrument.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsInsertInstrument.ToolTipTitle = "";
            this.hsInsertInstrument.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsInsertInstrument.UseVisualStyleBackColor = false;
            this.hsInsertInstrument.Click += new System.EventHandler(this.hsInsertInstrument_Click);
            // 
            // gbClassification
            // 
            this.gbClassification.Controls.Add(this.rbProfessional);
            this.gbClassification.Controls.Add(this.rbBeginners);
            this.gbClassification.Controls.Add(this.rbEasy);
            this.gbClassification.Controls.Add(this.rbIntermediate);
            this.gbClassification.Controls.Add(this.rbAdvanced);
            this.gbClassification.Controls.Add(this.rbDifficulty);
            this.gbClassification.Controls.Add(this.rbExperimantal);
            this.gbClassification.Location = new System.Drawing.Point(254, 17);
            this.gbClassification.Name = "gbClassification";
            this.gbClassification.Size = new System.Drawing.Size(119, 175);
            this.gbClassification.TabIndex = 6;
            this.gbClassification.TabStop = false;
            this.gbClassification.Text = "Level";
            // 
            // rbProfessional
            // 
            this.rbProfessional.AutoSize = true;
            this.rbProfessional.Location = new System.Drawing.Point(5, 126);
            this.rbProfessional.Name = "rbProfessional";
            this.rbProfessional.Size = new System.Drawing.Size(82, 17);
            this.rbProfessional.TabIndex = 0;
            this.rbProfessional.Text = "Professional";
            this.rbProfessional.UseVisualStyleBackColor = true;
            this.rbProfessional.CheckedChanged += new System.EventHandler(this.dataChanged);
            // 
            // rbBeginners
            // 
            this.rbBeginners.AutoSize = true;
            this.rbBeginners.Location = new System.Drawing.Point(5, 17);
            this.rbBeginners.Name = "rbBeginners";
            this.rbBeginners.Size = new System.Drawing.Size(72, 17);
            this.rbBeginners.TabIndex = 0;
            this.rbBeginners.Text = "Beginners";
            this.rbBeginners.UseVisualStyleBackColor = true;
            this.rbBeginners.CheckedChanged += new System.EventHandler(this.dataChanged);
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Checked = true;
            this.rbEasy.Location = new System.Drawing.Point(5, 39);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(48, 17);
            this.rbEasy.TabIndex = 0;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            this.rbEasy.CheckedChanged += new System.EventHandler(this.dataChanged);
            // 
            // rbIntermediate
            // 
            this.rbIntermediate.AutoSize = true;
            this.rbIntermediate.Location = new System.Drawing.Point(5, 61);
            this.rbIntermediate.Name = "rbIntermediate";
            this.rbIntermediate.Size = new System.Drawing.Size(83, 17);
            this.rbIntermediate.TabIndex = 0;
            this.rbIntermediate.Text = "Intermediate";
            this.rbIntermediate.UseVisualStyleBackColor = true;
            this.rbIntermediate.CheckedChanged += new System.EventHandler(this.dataChanged);
            // 
            // rbAdvanced
            // 
            this.rbAdvanced.AutoSize = true;
            this.rbAdvanced.Location = new System.Drawing.Point(5, 82);
            this.rbAdvanced.Name = "rbAdvanced";
            this.rbAdvanced.Size = new System.Drawing.Size(74, 17);
            this.rbAdvanced.TabIndex = 0;
            this.rbAdvanced.Text = "Advanced";
            this.rbAdvanced.UseVisualStyleBackColor = true;
            this.rbAdvanced.CheckedChanged += new System.EventHandler(this.dataChanged);
            // 
            // rbDifficulty
            // 
            this.rbDifficulty.AutoSize = true;
            this.rbDifficulty.Location = new System.Drawing.Point(5, 104);
            this.rbDifficulty.Name = "rbDifficulty";
            this.rbDifficulty.Size = new System.Drawing.Size(65, 17);
            this.rbDifficulty.TabIndex = 0;
            this.rbDifficulty.Text = "Difficulty";
            this.rbDifficulty.UseVisualStyleBackColor = true;
            this.rbDifficulty.CheckedChanged += new System.EventHandler(this.dataChanged);
            // 
            // rbExperimantal
            // 
            this.rbExperimantal.AutoSize = true;
            this.rbExperimantal.Location = new System.Drawing.Point(5, 147);
            this.rbExperimantal.Name = "rbExperimantal";
            this.rbExperimantal.Size = new System.Drawing.Size(85, 17);
            this.rbExperimantal.TabIndex = 0;
            this.rbExperimantal.Text = "Experimental";
            this.rbExperimantal.UseVisualStyleBackColor = true;
            this.rbExperimantal.CheckedChanged += new System.EventHandler(this.dataChanged);
            // 
            // gbInterpret
            // 
            this.gbInterpret.Controls.Add(this.cbInterpret);
            this.gbInterpret.Controls.Add(this.hsDeleteInterpret);
            this.gbInterpret.Controls.Add(this.hsSaveInterpret);
            this.gbInterpret.Location = new System.Drawing.Point(10, 63);
            this.gbInterpret.Name = "gbInterpret";
            this.gbInterpret.Size = new System.Drawing.Size(237, 41);
            this.gbInterpret.TabIndex = 4;
            this.gbInterpret.TabStop = false;
            this.gbInterpret.Text = "Interpret";
            // 
            // cbInterpret
            // 
            this.cbInterpret.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbInterpret.FormattingEnabled = true;
            this.cbInterpret.Location = new System.Drawing.Point(3, 16);
            this.cbInterpret.Name = "cbInterpret";
            this.cbInterpret.Size = new System.Drawing.Size(183, 21);
            this.cbInterpret.TabIndex = 5;
            this.cbInterpret.SelectedIndexChanged += new System.EventHandler(this.dataChanged);
            this.cbInterpret.TextChanged += new System.EventHandler(this.dataChanged);
            // 
            // hsDeleteInterpret
            // 
            this.hsDeleteInterpret.BackColor = System.Drawing.Color.Transparent;
            this.hsDeleteInterpret.BackColorHover = System.Drawing.Color.Transparent;
            this.hsDeleteInterpret.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsDeleteInterpret.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsDeleteInterpret.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsDeleteInterpret.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsDeleteInterpret.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsDeleteInterpret.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsDeleteInterpret.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsDeleteInterpret.FlatAppearance.BorderSize = 0;
            this.hsDeleteInterpret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsDeleteInterpret.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsDeleteInterpret.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsDeleteInterpret.Image = global::SENotesNET.Properties.Resources.minus_rt24x;
            this.hsDeleteInterpret.ImageHover = global::SENotesNET.Properties.Resources.minus_blue24x;
            this.hsDeleteInterpret.ImageToggleOnSelect = false;
            this.hsDeleteInterpret.Location = new System.Drawing.Point(186, 16);
            this.hsDeleteInterpret.Marked = false;
            this.hsDeleteInterpret.MarkedColor = System.Drawing.Color.Teal;
            this.hsDeleteInterpret.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsDeleteInterpret.MarkedText = "";
            this.hsDeleteInterpret.MarkMode = false;
            this.hsDeleteInterpret.Name = "hsDeleteInterpret";
            this.hsDeleteInterpret.NonMarkedText = "";
            this.hsDeleteInterpret.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsDeleteInterpret.ShowShortcut = false;
            this.hsDeleteInterpret.Size = new System.Drawing.Size(24, 22);
            this.hsDeleteInterpret.TabIndex = 18;
            this.hsDeleteInterpret.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsDeleteInterpret.ToolTipActive = false;
            this.hsDeleteInterpret.ToolTipAutomaticDelay = 500;
            this.hsDeleteInterpret.ToolTipAutoPopDelay = 5000;
            this.hsDeleteInterpret.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsDeleteInterpret.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsDeleteInterpret.ToolTipFor4ContextMenu = true;
            this.hsDeleteInterpret.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsDeleteInterpret.ToolTipInitialDelay = 500;
            this.hsDeleteInterpret.ToolTipIsBallon = false;
            this.hsDeleteInterpret.ToolTipOwnerDraw = false;
            this.hsDeleteInterpret.ToolTipReshowDelay = 100;
            this.hsDeleteInterpret.ToolTipShowAlways = false;
            this.hsDeleteInterpret.ToolTipText = "";
            this.hsDeleteInterpret.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsDeleteInterpret.ToolTipTitle = "";
            this.hsDeleteInterpret.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsDeleteInterpret.UseVisualStyleBackColor = false;
            this.hsDeleteInterpret.Click += new System.EventHandler(this.hsDeleteInterpret_Click);
            // 
            // hsSaveInterpret
            // 
            this.hsSaveInterpret.BackColor = System.Drawing.Color.Transparent;
            this.hsSaveInterpret.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSaveInterpret.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSaveInterpret.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSaveInterpret.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSaveInterpret.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSaveInterpret.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSaveInterpret.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsSaveInterpret.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsSaveInterpret.FlatAppearance.BorderSize = 0;
            this.hsSaveInterpret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSaveInterpret.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSaveInterpret.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveInterpret.Image = global::SENotesNET.Properties.Resources.plus_gn_24x;
            this.hsSaveInterpret.ImageHover = global::SENotesNET.Properties.Resources.plus_blue_24x;
            this.hsSaveInterpret.ImageToggleOnSelect = false;
            this.hsSaveInterpret.Location = new System.Drawing.Point(210, 16);
            this.hsSaveInterpret.Marked = false;
            this.hsSaveInterpret.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveInterpret.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveInterpret.MarkedText = "";
            this.hsSaveInterpret.MarkMode = false;
            this.hsSaveInterpret.Name = "hsSaveInterpret";
            this.hsSaveInterpret.NonMarkedText = "";
            this.hsSaveInterpret.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSaveInterpret.ShowShortcut = false;
            this.hsSaveInterpret.Size = new System.Drawing.Size(24, 22);
            this.hsSaveInterpret.TabIndex = 17;
            this.hsSaveInterpret.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsSaveInterpret.ToolTipActive = false;
            this.hsSaveInterpret.ToolTipAutomaticDelay = 500;
            this.hsSaveInterpret.ToolTipAutoPopDelay = 5000;
            this.hsSaveInterpret.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSaveInterpret.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSaveInterpret.ToolTipFor4ContextMenu = true;
            this.hsSaveInterpret.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSaveInterpret.ToolTipInitialDelay = 500;
            this.hsSaveInterpret.ToolTipIsBallon = false;
            this.hsSaveInterpret.ToolTipOwnerDraw = false;
            this.hsSaveInterpret.ToolTipReshowDelay = 100;
            this.hsSaveInterpret.ToolTipShowAlways = false;
            this.hsSaveInterpret.ToolTipText = "";
            this.hsSaveInterpret.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSaveInterpret.ToolTipTitle = "";
            this.hsSaveInterpret.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSaveInterpret.UseVisualStyleBackColor = false;
            this.hsSaveInterpret.Click += new System.EventHandler(this.hsSaveInterpret_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.hsNewSong);
            this.flowLayoutPanel1.Controls.Add(this.hsUpdateSong);
            this.flowLayoutPanel1.Controls.Add(this.hsAddSongFile);
            this.flowLayoutPanel1.Controls.Add(this.hsRemoveFile);
            this.flowLayoutPanel1.Controls.Add(this.gbSortIndex);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(807, 45);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // hsNewSong
            // 
            this.hsNewSong.BackColor = System.Drawing.Color.Transparent;
            this.hsNewSong.BackColorHover = System.Drawing.Color.Transparent;
            this.hsNewSong.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsNewSong.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsNewSong.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsNewSong.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsNewSong.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsNewSong.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsNewSong.FlatAppearance.BorderSize = 0;
            this.hsNewSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsNewSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsNewSong.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsNewSong.Image = global::SENotesNET.Properties.Resources.help_about_gn_x24;
            this.hsNewSong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsNewSong.ImageHover = global::SENotesNET.Properties.Resources.help_about_blue_x24;
            this.hsNewSong.ImageToggleOnSelect = false;
            this.hsNewSong.Location = new System.Drawing.Point(3, 3);
            this.hsNewSong.Marked = false;
            this.hsNewSong.MarkedColor = System.Drawing.Color.Teal;
            this.hsNewSong.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsNewSong.MarkedText = "";
            this.hsNewSong.MarkMode = false;
            this.hsNewSong.Name = "hsNewSong";
            this.hsNewSong.NonMarkedText = "";
            this.hsNewSong.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsNewSong.ShowShortcut = false;
            this.hsNewSong.Size = new System.Drawing.Size(88, 37);
            this.hsNewSong.TabIndex = 14;
            this.hsNewSong.Text = "New Song";
            this.hsNewSong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsNewSong.ToolTipActive = false;
            this.hsNewSong.ToolTipAutomaticDelay = 500;
            this.hsNewSong.ToolTipAutoPopDelay = 5000;
            this.hsNewSong.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsNewSong.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsNewSong.ToolTipFor4ContextMenu = true;
            this.hsNewSong.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsNewSong.ToolTipInitialDelay = 500;
            this.hsNewSong.ToolTipIsBallon = false;
            this.hsNewSong.ToolTipOwnerDraw = false;
            this.hsNewSong.ToolTipReshowDelay = 100;
            this.hsNewSong.ToolTipShowAlways = false;
            this.hsNewSong.ToolTipText = "";
            this.hsNewSong.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsNewSong.ToolTipTitle = "";
            this.hsNewSong.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsNewSong.UseVisualStyleBackColor = false;
            this.hsNewSong.Click += new System.EventHandler(this.hsNewSong_Click_1);
            // 
            // hsUpdateSong
            // 
            this.hsUpdateSong.BackColor = System.Drawing.Color.Transparent;
            this.hsUpdateSong.BackColorHover = System.Drawing.Color.Transparent;
            this.hsUpdateSong.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsUpdateSong.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsUpdateSong.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsUpdateSong.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsUpdateSong.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsUpdateSong.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsUpdateSong.FlatAppearance.BorderSize = 0;
            this.hsUpdateSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsUpdateSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsUpdateSong.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsUpdateSong.Image = global::SENotesNET.Properties.Resources.floppy_x24;
            this.hsUpdateSong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsUpdateSong.ImageHover = global::SENotesNET.Properties.Resources.floppy2_x24;
            this.hsUpdateSong.ImageToggleOnSelect = false;
            this.hsUpdateSong.Location = new System.Drawing.Point(97, 3);
            this.hsUpdateSong.Marked = false;
            this.hsUpdateSong.MarkedColor = System.Drawing.Color.Teal;
            this.hsUpdateSong.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsUpdateSong.MarkedText = "";
            this.hsUpdateSong.MarkMode = false;
            this.hsUpdateSong.Name = "hsUpdateSong";
            this.hsUpdateSong.NonMarkedText = "";
            this.hsUpdateSong.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsUpdateSong.ShowShortcut = false;
            this.hsUpdateSong.Size = new System.Drawing.Size(94, 37);
            this.hsUpdateSong.TabIndex = 15;
            this.hsUpdateSong.Text = "Save Song";
            this.hsUpdateSong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsUpdateSong.ToolTipActive = false;
            this.hsUpdateSong.ToolTipAutomaticDelay = 500;
            this.hsUpdateSong.ToolTipAutoPopDelay = 5000;
            this.hsUpdateSong.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsUpdateSong.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsUpdateSong.ToolTipFor4ContextMenu = true;
            this.hsUpdateSong.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsUpdateSong.ToolTipInitialDelay = 500;
            this.hsUpdateSong.ToolTipIsBallon = false;
            this.hsUpdateSong.ToolTipOwnerDraw = false;
            this.hsUpdateSong.ToolTipReshowDelay = 100;
            this.hsUpdateSong.ToolTipShowAlways = false;
            this.hsUpdateSong.ToolTipText = "";
            this.hsUpdateSong.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsUpdateSong.ToolTipTitle = "";
            this.hsUpdateSong.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsUpdateSong.UseVisualStyleBackColor = false;
            this.hsUpdateSong.Click += new System.EventHandler(this.hotSpot2_Click);
            // 
            // gbSongGrid
            // 
            this.gbSongGrid.Controls.Add(this.dgvSongs);
            this.gbSongGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSongGrid.Location = new System.Drawing.Point(0, 45);
            this.gbSongGrid.Name = "gbSongGrid";
            this.gbSongGrid.Size = new System.Drawing.Size(1042, 729);
            this.gbSongGrid.TabIndex = 12;
            this.gbSongGrid.TabStop = false;
            this.gbSongGrid.Text = "Songs (0)";
            // 
            // dgvSongs
            // 
            this.dgvSongs.AllowUserToOrderColumns = true;
            this.dgvSongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.ContextMenuStrip = this.cmsSongs;
            this.dgvSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSongs.Location = new System.Drawing.Point(3, 16);
            this.dgvSongs.MultiSelect = false;
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.ReadOnly = true;
            this.dgvSongs.RowHeadersVisible = false;
            this.dgvSongs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSongs.Size = new System.Drawing.Size(1036, 710);
            this.dgvSongs.TabIndex = 11;
            this.dgvSongs.SelectionChanged += new System.EventHandler(this.dgvSongs_SelectionChanged);
            this.dgvSongs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dgvSongs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.hsRefresh);
            this.flowLayoutPanel2.Controls.Add(this.hsClearRefresh);
            this.flowLayoutPanel2.Controls.Add(this.gbFilterSongName);
            this.flowLayoutPanel2.Controls.Add(this.groupBox2);
            this.flowLayoutPanel2.Controls.Add(this.groupBox1);
            this.flowLayoutPanel2.Controls.Add(this.ckSortRating);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1042, 45);
            this.flowLayoutPanel2.TabIndex = 2;
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
            this.hsRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsRefresh.ImageHover = global::SENotesNET.Properties.Resources.view_refresh_2_24x1;
            this.hsRefresh.ImageToggleOnSelect = false;
            this.hsRefresh.Location = new System.Drawing.Point(3, 3);
            this.hsRefresh.Marked = false;
            this.hsRefresh.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefresh.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefresh.MarkedText = "";
            this.hsRefresh.MarkMode = false;
            this.hsRefresh.Name = "hsRefresh";
            this.hsRefresh.NonMarkedText = "";
            this.hsRefresh.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefresh.ShowShortcut = false;
            this.hsRefresh.Size = new System.Drawing.Size(78, 37);
            this.hsRefresh.TabIndex = 13;
            this.hsRefresh.Text = "Refresh";
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
            // hsClearRefresh
            // 
            this.hsClearRefresh.BackColor = System.Drawing.Color.Transparent;
            this.hsClearRefresh.BackColorHover = System.Drawing.Color.Transparent;
            this.hsClearRefresh.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsClearRefresh.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsClearRefresh.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsClearRefresh.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsClearRefresh.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsClearRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsClearRefresh.FlatAppearance.BorderSize = 0;
            this.hsClearRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsClearRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsClearRefresh.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsClearRefresh.Image = global::SENotesNET.Properties.Resources.view_refresh_24x;
            this.hsClearRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsClearRefresh.ImageHover = global::SENotesNET.Properties.Resources.view_refresh_2_24x1;
            this.hsClearRefresh.ImageToggleOnSelect = false;
            this.hsClearRefresh.Location = new System.Drawing.Point(87, 3);
            this.hsClearRefresh.Marked = false;
            this.hsClearRefresh.MarkedColor = System.Drawing.Color.Teal;
            this.hsClearRefresh.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClearRefresh.MarkedText = "";
            this.hsClearRefresh.MarkMode = false;
            this.hsClearRefresh.Name = "hsClearRefresh";
            this.hsClearRefresh.NonMarkedText = "";
            this.hsClearRefresh.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsClearRefresh.ShowShortcut = false;
            this.hsClearRefresh.Size = new System.Drawing.Size(115, 37);
            this.hsClearRefresh.TabIndex = 14;
            this.hsClearRefresh.Text = "Clear->Refresh";
            this.hsClearRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsClearRefresh.ToolTipActive = false;
            this.hsClearRefresh.ToolTipAutomaticDelay = 500;
            this.hsClearRefresh.ToolTipAutoPopDelay = 5000;
            this.hsClearRefresh.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsClearRefresh.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsClearRefresh.ToolTipFor4ContextMenu = true;
            this.hsClearRefresh.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsClearRefresh.ToolTipInitialDelay = 500;
            this.hsClearRefresh.ToolTipIsBallon = false;
            this.hsClearRefresh.ToolTipOwnerDraw = false;
            this.hsClearRefresh.ToolTipReshowDelay = 100;
            this.hsClearRefresh.ToolTipShowAlways = false;
            this.hsClearRefresh.ToolTipText = "";
            this.hsClearRefresh.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsClearRefresh.ToolTipTitle = "";
            this.hsClearRefresh.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsClearRefresh.UseVisualStyleBackColor = false;
            this.hsClearRefresh.Click += new System.EventHandler(this.hsClearRefresh_Click);
            // 
            // gbFilterSongName
            // 
            this.gbFilterSongName.Controls.Add(this.txtFilterSongName);
            this.gbFilterSongName.Location = new System.Drawing.Point(208, 3);
            this.gbFilterSongName.Name = "gbFilterSongName";
            this.gbFilterSongName.Size = new System.Drawing.Size(171, 42);
            this.gbFilterSongName.TabIndex = 2;
            this.gbFilterSongName.TabStop = false;
            this.gbFilterSongName.Text = "Filter Song Name";
            // 
            // txtFilterSongName
            // 
            this.txtFilterSongName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilterSongName.Location = new System.Drawing.Point(3, 16);
            this.txtFilterSongName.Name = "txtFilterSongName";
            this.txtFilterSongName.Size = new System.Drawing.Size(165, 20);
            this.txtFilterSongName.TabIndex = 0;
            this.txtFilterSongName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilterSongName_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbInterpretFilter);
            this.groupBox2.Location = new System.Drawing.Point(385, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 41);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter Interpret";
            // 
            // cbInterpretFilter
            // 
            this.cbInterpretFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbInterpretFilter.FormattingEnabled = true;
            this.cbInterpretFilter.Location = new System.Drawing.Point(3, 16);
            this.cbInterpretFilter.Name = "cbInterpretFilter";
            this.cbInterpretFilter.Size = new System.Drawing.Size(231, 21);
            this.cbInterpretFilter.TabIndex = 5;
            this.cbInterpretFilter.SelectedIndexChanged += new System.EventHandler(this.cbInterpretFilter_SelectedIndexChanged);
            this.cbInterpretFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbInterpretFilter_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGroupFilter);
            this.groupBox1.Location = new System.Drawing.Point(628, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 41);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Group";
            // 
            // cbGroupFilter
            // 
            this.cbGroupFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbGroupFilter.FormattingEnabled = true;
            this.cbGroupFilter.Items.AddRange(new object[] {
            "Akkordeon",
            "Piano",
            "Harp"});
            this.cbGroupFilter.Location = new System.Drawing.Point(3, 16);
            this.cbGroupFilter.Name = "cbGroupFilter";
            this.cbGroupFilter.Size = new System.Drawing.Size(174, 21);
            this.cbGroupFilter.TabIndex = 8;
            this.cbGroupFilter.SelectedIndexChanged += new System.EventHandler(this.cbGroupFilter_SelectedIndexChanged);
            this.cbGroupFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbGroupFilter_KeyDown);
            // 
            // ckSortRating
            // 
            this.ckSortRating.AutoSize = true;
            this.ckSortRating.Dock = System.Windows.Forms.DockStyle.Right;
            this.ckSortRating.Location = new System.Drawing.Point(814, 3);
            this.ckSortRating.Name = "ckSortRating";
            this.ckSortRating.Size = new System.Drawing.Size(79, 42);
            this.ckSortRating.TabIndex = 6;
            this.ckSortRating.Text = "Sort Rating";
            this.ckSortRating.UseVisualStyleBackColor = true;
            this.ckSortRating.CheckedChanged += new System.EventHandler(this.ckSortRating_CheckedChanged);
            // 
            // upperPanel
            // 
            this.upperPanel.Controls.Add(this.flowLayoutPanel3);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1852, 65);
            this.upperPanel.TabIndex = 8;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.hsClose);
            this.flowLayoutPanel3.Controls.Add(this.hsShowNotes);
            this.flowLayoutPanel3.Controls.Add(this.hsMaintain);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(531, 65);
            this.flowLayoutPanel3.TabIndex = 5;
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
            this.hsClose.Location = new System.Drawing.Point(3, 3);
            this.hsClose.Marked = false;
            this.hsClose.MarkedColor = System.Drawing.Color.Teal;
            this.hsClose.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsClose.MarkedText = "";
            this.hsClose.MarkMode = false;
            this.hsClose.Name = "hsClose";
            this.hsClose.NonMarkedText = "";
            this.hsClose.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsClose.ShowShortcut = false;
            this.hsClose.Size = new System.Drawing.Size(69, 56);
            this.hsClose.TabIndex = 12;
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
            this.hsClose.Click += new System.EventHandler(this.hsClose_Click_1);
            // 
            // hsShowNotes
            // 
            this.hsShowNotes.BackColor = System.Drawing.Color.Transparent;
            this.hsShowNotes.BackColorHover = System.Drawing.Color.Transparent;
            this.hsShowNotes.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsShowNotes.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsShowNotes.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsShowNotes.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsShowNotes.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsShowNotes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsShowNotes.FlatAppearance.BorderSize = 0;
            this.hsShowNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsShowNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsShowNotes.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsShowNotes.Image = global::SENotesNET.Properties.Resources.achtel_note_black_32x;
            this.hsShowNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsShowNotes.ImageHover = global::SENotesNET.Properties.Resources.achtel_note_black_gr_x32;
            this.hsShowNotes.ImageToggleOnSelect = false;
            this.hsShowNotes.Location = new System.Drawing.Point(78, 3);
            this.hsShowNotes.Marked = false;
            this.hsShowNotes.MarkedColor = System.Drawing.Color.Teal;
            this.hsShowNotes.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsShowNotes.MarkedText = "";
            this.hsShowNotes.MarkMode = false;
            this.hsShowNotes.Name = "hsShowNotes";
            this.hsShowNotes.NonMarkedText = "";
            this.hsShowNotes.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsShowNotes.ShowShortcut = false;
            this.hsShowNotes.Size = new System.Drawing.Size(106, 56);
            this.hsShowNotes.TabIndex = 11;
            this.hsShowNotes.Text = "Show Notes";
            this.hsShowNotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsShowNotes.ToolTipActive = false;
            this.hsShowNotes.ToolTipAutomaticDelay = 500;
            this.hsShowNotes.ToolTipAutoPopDelay = 5000;
            this.hsShowNotes.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsShowNotes.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsShowNotes.ToolTipFor4ContextMenu = true;
            this.hsShowNotes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsShowNotes.ToolTipInitialDelay = 500;
            this.hsShowNotes.ToolTipIsBallon = false;
            this.hsShowNotes.ToolTipOwnerDraw = false;
            this.hsShowNotes.ToolTipReshowDelay = 100;
            this.hsShowNotes.ToolTipShowAlways = false;
            this.hsShowNotes.ToolTipText = "";
            this.hsShowNotes.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsShowNotes.ToolTipTitle = "";
            this.hsShowNotes.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsShowNotes.UseVisualStyleBackColor = false;
            this.hsShowNotes.Click += new System.EventHandler(this.hsShowNotes_Click);
            // 
            // hsMaintain
            // 
            this.hsMaintain.BackColor = System.Drawing.Color.Transparent;
            this.hsMaintain.BackColorHover = System.Drawing.Color.Transparent;
            this.hsMaintain.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsMaintain.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsMaintain.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsMaintain.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsMaintain.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsMaintain.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsMaintain.FlatAppearance.BorderSize = 0;
            this.hsMaintain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsMaintain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsMaintain.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsMaintain.Image = global::SENotesNET.Properties.Resources.database_maintain;
            this.hsMaintain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsMaintain.ImageHover = global::SENotesNET.Properties.Resources.database_maintain_2_32x;
            this.hsMaintain.ImageToggleOnSelect = false;
            this.hsMaintain.Location = new System.Drawing.Point(190, 3);
            this.hsMaintain.Marked = false;
            this.hsMaintain.MarkedColor = System.Drawing.Color.Teal;
            this.hsMaintain.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsMaintain.MarkedText = "";
            this.hsMaintain.MarkMode = false;
            this.hsMaintain.Name = "hsMaintain";
            this.hsMaintain.NonMarkedText = "";
            this.hsMaintain.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsMaintain.ShowShortcut = false;
            this.hsMaintain.Size = new System.Drawing.Size(134, 56);
            this.hsMaintain.TabIndex = 10;
            this.hsMaintain.Text = "Maintainance";
            this.hsMaintain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsMaintain.ToolTipActive = false;
            this.hsMaintain.ToolTipAutomaticDelay = 500;
            this.hsMaintain.ToolTipAutoPopDelay = 5000;
            this.hsMaintain.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsMaintain.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsMaintain.ToolTipFor4ContextMenu = true;
            this.hsMaintain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsMaintain.ToolTipInitialDelay = 500;
            this.hsMaintain.ToolTipIsBallon = false;
            this.hsMaintain.ToolTipOwnerDraw = false;
            this.hsMaintain.ToolTipReshowDelay = 100;
            this.hsMaintain.ToolTipShowAlways = false;
            this.hsMaintain.ToolTipText = "";
            this.hsMaintain.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsMaintain.ToolTipTitle = "";
            this.hsMaintain.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsMaintain.UseVisualStyleBackColor = false;
            this.hsMaintain.Click += new System.EventHandler(this.hsMaintain_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            // 
            // ofdDB
            // 
            this.ofdDB.FileName = "MyData.DB";
            this.ofdDB.Filter = "LiteDB|*.db|All|*.*";
            this.ofdDB.ShowReadOnly = true;
            this.ofdDB.Title = "Open DB";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1852, 839);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.upperPanel);
            this.Name = "MainForm";
            this.Text = "SENotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsSongs.ResumeLayout(false);
            this.gbSongName.ResumeLayout(false);
            this.gbSongName.PerformLayout();
            this.gbFileList.ResumeLayout(false);
            this.cmsSongFiles.ResumeLayout(false);
            this.gbSortIndex.ResumeLayout(false);
            this.gbSortIndex.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlEditSongLower.ResumeLayout(false);
            this.gbGroup.ResumeLayout(false);
            this.gbOtherAttributes.ResumeLayout(false);
            this.gbOtherAttributes.PerformLayout();
            this.gbOrigin.ResumeLayout(false);
            this.gbVariante.ResumeLayout(false);
            this.gbSheetAttributes.ResumeLayout(false);
            this.gbSheetAttributes.PerformLayout();
            this.gbInstrument.ResumeLayout(false);
            this.gbClassification.ResumeLayout(false);
            this.gbClassification.PerformLayout();
            this.gbInterpret.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gbSongGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.gbFilterSongName.ResumeLayout(false);
            this.gbFilterSongName.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.upperPanel.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox gbSongName;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.GroupBox gbFileList;
        private System.Windows.Forms.ListView lvFileList;
        private System.Windows.Forms.ColumnHeader SortIndex;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox gbClassification;
        private System.Windows.Forms.RadioButton rbExperimantal;
        private System.Windows.Forms.RadioButton rbDifficulty;
        private System.Windows.Forms.RadioButton rbAdvanced;
        private System.Windows.Forms.RadioButton rbIntermediate;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.RadioButton rbBeginners;
        private System.Windows.Forms.GroupBox gbInterpret;
        private System.Windows.Forms.ColumnHeader FiIeName;
        private System.Windows.Forms.ColumnHeader FileID;
        private System.Windows.Forms.GroupBox gbSortIndex;
        private System.Windows.Forms.TextBox txtSortIndex;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlEditFiles;
        private System.Windows.Forms.Panel pnlEditSongLower;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton rbProfessional;
        
        private System.Windows.Forms.GroupBox gbInstrument;
        
        
        private System.Windows.Forms.GroupBox gbSheetAttributes;
        private System.Windows.Forms.TextBox txtSheetWidth;
        private System.Windows.Forms.Label lblSheetWidth;
        private System.Windows.Forms.TextBox txtPageStep;
        private System.Windows.Forms.Label lblSheetPages;
        private System.Windows.Forms.TextBox txtSheetHeightFactor;
        private System.Windows.Forms.Label lblSheetHeight;
        private System.Windows.Forms.GroupBox gbFilterSongName;
        private System.Windows.Forms.TextBox txtFilterSongName;
        private System.Windows.Forms.ComboBox cbInstrument;
        private System.Windows.Forms.ComboBox cbInterpret;
        private System.Windows.Forms.ContextMenuStrip cmsSongFiles;
        private System.Windows.Forms.ToolStripMenuItem tsmiReloadFile;
        private System.Windows.Forms.ColumnHeader Changed;
        private System.Windows.Forms.ContextMenuStrip cmsSongs;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteSong;
        private System.Windows.Forms.GroupBox gbVariante;
        private System.Windows.Forms.ComboBox cbVariante;
        private System.Windows.Forms.GroupBox gbOrigin;
        private System.Windows.Forms.ComboBox cbOrigin;
        private System.Windows.Forms.ToolStripMenuItem tsmiExecuteMusicFile;
        private System.Windows.Forms.ColumnHeader FileType;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetFileTypeSongfile;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetFileTypeMuseScore;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetFilePDFfile;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetFileText;
        private System.Windows.Forms.TextBox txtPageShowCount;
        private System.Windows.Forms.Label lblSheetShowCount;
        private System.Windows.Forms.TextBox txtAutoStepTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExportMuseScore2PDF;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExportMuseScore2MP3;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetFileMP3;
        private System.Windows.Forms.GroupBox gbOtherAttributes;
        private System.Windows.Forms.TextBox txtRating;
        
        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.TextBox txtMetronomsSpeed;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblMetronomSpeed;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiSongFileDown;
        private System.Windows.Forms.ToolStripMenuItem tsmiSongFilesUp;
        private System.Windows.Forms.OpenFileDialog ofdDB;
        private System.Windows.Forms.CheckBox ckSortRating;
        private SeControlsLib.HotSpot hsMaintain;
        private SeControlsLib.HotSpot hsShowNotes;
        private SeControlsLib.HotSpot hsClose;
        private SeControlsLib.HotSpot hsRefresh;
        private SeControlsLib.HotSpot hsClearRefresh;
        private System.Windows.Forms.GroupBox gbSongGrid;
        private SeControlsLib.HotSpot hsAddSongFile;
        private SeControlsLib.HotSpot hsRemoveFile;
        private SeControlsLib.HotSpot hsSaveNewIndex;
        private SeControlsLib.HotSpot hsNewSong;
        private SeControlsLib.HotSpot hsUpdateSong;
        private SeControlsLib.HotSpot hsDeleteInterpret;
        private SeControlsLib.HotSpot hsSaveInterpret;
        private SeControlsLib.HotSpot hsDeleteInstrument;
        private SeControlsLib.HotSpot hsInsertInstrument;
        private SeControlsLib.HotSpot hsDeleteVariant;
        private SeControlsLib.HotSpot hsInsertVariant;
        private SeControlsLib.HotSpot hsDeleteOrigin;
        private SeControlsLib.HotSpot hsInsertOrigin;
        private System.Windows.Forms.GroupBox gbGroup;
        private System.Windows.Forms.ComboBox cbGroup;
        private SeControlsLib.HotSpot hsDeleteGroup;
        private SeControlsLib.HotSpot hsInsertGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbGroupFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbInterpretFilter;
    }
}

