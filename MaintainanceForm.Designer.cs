
namespace SENotesNET
{
    partial class MaintainanceForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hsClose = new SeControlsLib.HotSpot();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lclActDatabase = new System.Windows.Forms.Label();
            this.ofdDB = new System.Windows.Forms.OpenFileDialog();
            this.gbLeft = new System.Windows.Forms.GroupBox();
            this.hsExport = new SeControlsLib.HotSpot();
            this.hsChangeDB = new SeControlsLib.HotSpot();
            this.gbCenter = new System.Windows.Forms.GroupBox();
            this.rtLog = new System.Windows.Forms.RichTextBox();
            this.ckDebugMode = new System.Windows.Forms.CheckBox();
            this.ckGlobalKeys = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbLeft.SuspendLayout();
            this.gbCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.hsClose);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1479, 52);
            this.flowLayoutPanel1.TabIndex = 8;
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
            this.hsClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.hsClose.Size = new System.Drawing.Size(49, 40);
            this.hsClose.TabIndex = 9;
            this.hsClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lclActDatabase);
            this.panel1.Location = new System.Drawing.Point(58, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 40);
            this.panel1.TabIndex = 11;
            // 
            // lclActDatabase
            // 
            this.lclActDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lclActDatabase.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclActDatabase.Location = new System.Drawing.Point(0, 0);
            this.lclActDatabase.Name = "lclActDatabase";
            this.lclActDatabase.Size = new System.Drawing.Size(726, 40);
            this.lclActDatabase.TabIndex = 10;
            this.lclActDatabase.Text = "ActDatabase";
            this.lclActDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ofdDB
            // 
            this.ofdDB.FileName = "MyData.DB";
            this.ofdDB.Filter = "LiteDB|*.db|All|*.*";
            this.ofdDB.ShowReadOnly = true;
            this.ofdDB.Title = "Open DB";
            // 
            // gbLeft
            // 
            this.gbLeft.Controls.Add(this.ckGlobalKeys);
            this.gbLeft.Controls.Add(this.hsExport);
            this.gbLeft.Controls.Add(this.hsChangeDB);
            this.gbLeft.Controls.Add(this.ckDebugMode);
            this.gbLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbLeft.Location = new System.Drawing.Point(0, 52);
            this.gbLeft.Name = "gbLeft";
            this.gbLeft.Size = new System.Drawing.Size(137, 541);
            this.gbLeft.TabIndex = 9;
            this.gbLeft.TabStop = false;
            // 
            // hsExport
            // 
            this.hsExport.BackColor = System.Drawing.Color.Transparent;
            this.hsExport.BackColorHover = System.Drawing.Color.Transparent;
            this.hsExport.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsExport.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsExport.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsExport.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsExport.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsExport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsExport.FlatAppearance.BorderSize = 0;
            this.hsExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsExport.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsExport.Image = global::SENotesNET.Properties.Resources.database_arrow_r;
            this.hsExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsExport.ImageHover = global::SENotesNET.Properties.Resources.database_arrow_r_blue;
            this.hsExport.ImageToggleOnSelect = false;
            this.hsExport.Location = new System.Drawing.Point(12, 105);
            this.hsExport.Marked = false;
            this.hsExport.MarkedColor = System.Drawing.Color.Teal;
            this.hsExport.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsExport.MarkedText = "";
            this.hsExport.MarkMode = false;
            this.hsExport.Name = "hsExport";
            this.hsExport.NonMarkedText = "";
            this.hsExport.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsExport.ShowShortcut = false;
            this.hsExport.Size = new System.Drawing.Size(112, 80);
            this.hsExport.TabIndex = 8;
            this.hsExport.Text = "Export DB";
            this.hsExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsExport.ToolTipActive = false;
            this.hsExport.ToolTipAutomaticDelay = 500;
            this.hsExport.ToolTipAutoPopDelay = 5000;
            this.hsExport.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsExport.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsExport.ToolTipFor4ContextMenu = true;
            this.hsExport.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsExport.ToolTipInitialDelay = 500;
            this.hsExport.ToolTipIsBallon = false;
            this.hsExport.ToolTipOwnerDraw = false;
            this.hsExport.ToolTipReshowDelay = 100;
            this.hsExport.ToolTipShowAlways = false;
            this.hsExport.ToolTipText = "";
            this.hsExport.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsExport.ToolTipTitle = "";
            this.hsExport.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsExport.UseVisualStyleBackColor = false;
            this.hsExport.Click += new System.EventHandler(this.hsExport_Click);
            // 
            // hsChangeDB
            // 
            this.hsChangeDB.BackColor = System.Drawing.Color.Transparent;
            this.hsChangeDB.BackColorHover = System.Drawing.Color.Transparent;
            this.hsChangeDB.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsChangeDB.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsChangeDB.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsChangeDB.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsChangeDB.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsChangeDB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsChangeDB.FlatAppearance.BorderSize = 0;
            this.hsChangeDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsChangeDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsChangeDB.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsChangeDB.Image = global::SENotesNET.Properties.Resources.database_replication_x32;
            this.hsChangeDB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsChangeDB.ImageHover = global::SENotesNET.Properties.Resources.database_replication_2_x32;
            this.hsChangeDB.ImageToggleOnSelect = false;
            this.hsChangeDB.Location = new System.Drawing.Point(12, 19);
            this.hsChangeDB.Marked = false;
            this.hsChangeDB.MarkedColor = System.Drawing.Color.Teal;
            this.hsChangeDB.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsChangeDB.MarkedText = "";
            this.hsChangeDB.MarkMode = false;
            this.hsChangeDB.Name = "hsChangeDB";
            this.hsChangeDB.NonMarkedText = "";
            this.hsChangeDB.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsChangeDB.ShowShortcut = false;
            this.hsChangeDB.Size = new System.Drawing.Size(112, 80);
            this.hsChangeDB.TabIndex = 7;
            this.hsChangeDB.Text = "Change DB";
            this.hsChangeDB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsChangeDB.ToolTipActive = false;
            this.hsChangeDB.ToolTipAutomaticDelay = 500;
            this.hsChangeDB.ToolTipAutoPopDelay = 5000;
            this.hsChangeDB.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsChangeDB.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsChangeDB.ToolTipFor4ContextMenu = true;
            this.hsChangeDB.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsChangeDB.ToolTipInitialDelay = 500;
            this.hsChangeDB.ToolTipIsBallon = false;
            this.hsChangeDB.ToolTipOwnerDraw = false;
            this.hsChangeDB.ToolTipReshowDelay = 100;
            this.hsChangeDB.ToolTipShowAlways = false;
            this.hsChangeDB.ToolTipText = "";
            this.hsChangeDB.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsChangeDB.ToolTipTitle = "";
            this.hsChangeDB.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsChangeDB.UseVisualStyleBackColor = false;
            this.hsChangeDB.Click += new System.EventHandler(this.hsChangeDB_Click);
            // 
            // gbCenter
            // 
            this.gbCenter.Controls.Add(this.rtLog);
            this.gbCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCenter.Location = new System.Drawing.Point(137, 52);
            this.gbCenter.Name = "gbCenter";
            this.gbCenter.Size = new System.Drawing.Size(1342, 541);
            this.gbCenter.TabIndex = 10;
            this.gbCenter.TabStop = false;
            this.gbCenter.Text = "Log";
            // 
            // rtLog
            // 
            this.rtLog.DetectUrls = false;
            this.rtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtLog.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtLog.Location = new System.Drawing.Point(3, 16);
            this.rtLog.Name = "rtLog";
            this.rtLog.Size = new System.Drawing.Size(1336, 522);
            this.rtLog.TabIndex = 0;
            this.rtLog.Text = "";
            this.rtLog.WordWrap = false;
            // 
            // ckDebugMode
            // 
            this.ckDebugMode.AutoSize = true;
            this.ckDebugMode.Location = new System.Drawing.Point(36, 240);
            this.ckDebugMode.Name = "ckDebugMode";
            this.ckDebugMode.Size = new System.Drawing.Size(88, 17);
            this.ckDebugMode.TabIndex = 12;
            this.ckDebugMode.Text = "Debug Mode";
            this.ckDebugMode.UseVisualStyleBackColor = true;
            this.ckDebugMode.CheckedChanged += new System.EventHandler(this.ckDebugMode_CheckedChanged);
            // 
            // ckGlobalKeys
            // 
            this.ckGlobalKeys.AutoSize = true;
            this.ckGlobalKeys.Location = new System.Drawing.Point(27, 292);
            this.ckGlobalKeys.Name = "ckGlobalKeys";
            this.ckGlobalKeys.Size = new System.Drawing.Size(82, 17);
            this.ckGlobalKeys.TabIndex = 13;
            this.ckGlobalKeys.Text = "Global Keys";
            this.ckGlobalKeys.UseVisualStyleBackColor = true;
            // 
            // MaintainanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 593);
            this.Controls.Add(this.gbCenter);
            this.Controls.Add(this.gbLeft);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MaintainanceForm";
            this.Text = "MaintainanceForm";
            this.Load += new System.EventHandler(this.MaintainanceForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbLeft.ResumeLayout(false);
            this.gbLeft.PerformLayout();
            this.gbCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private SeControlsLib.HotSpot hsChangeDB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private SeControlsLib.HotSpot hsClose;
        private System.Windows.Forms.OpenFileDialog ofdDB;
        private System.Windows.Forms.GroupBox gbLeft;
        private System.Windows.Forms.GroupBox gbCenter;
        private System.Windows.Forms.RichTextBox rtLog;
        private SeControlsLib.HotSpot hsExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lclActDatabase;
        private System.Windows.Forms.CheckBox ckDebugMode;
        private System.Windows.Forms.CheckBox ckGlobalKeys;
    }
}