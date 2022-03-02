using BasicClassLibrary;
using Enums;
using SENotesNET.Classes;
using SharedStorages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SENotesNET
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetupKeyboardHooks();
            AppSingelton.Instance().debugMode = false;
            AppSingelton.Instance().nf.Register4Info(InfoRaised);
        }
        private GlobalKeyboardHook _globalKeyboardHook;
        readonly DBClass db = new DBClass();
        Notes ActData;
        DBFiles ActFileData;
        eDBSaveState DBSaveState = eDBSaveState.insert;

        [Serializable]
        class MerkeWerte
        {
            public Guid LastSongID;
            public string InterpretFilter;
            public string GroupFilter;
        };

        private void LoadUserDesign()
        {
            try
            {
                SharedStorage ss = new SharedStorage();
                ss.SharedFolder = Application.LocalUserAppDataPath;
                ss.StorageName = $@"{this.Name}";
                ss.DestroyWhenDisposed = false;
                var mw2 = (MerkeWerte)ss["ComboBoxIds"];
                if (mw2 != null)
                {
                    //mw = mw2;
                    LastSongID = mw2.LastSongID;
                    cbInterpretFilter.Text = mw2.InterpretFilter;
                    cbGroupFilter.Text = mw2.GroupFilter;
                }
            }
            catch (Exception ex)
            {
               // SendMessageClass.Instance.SendAllMessages($@"{ex.Message}", $@"{this.Name}->LoadUserDesign()", eLevel.error);
            }
        }

        public void SaveUserDesign()
        {
            SharedStorage ss = new SharedStorage();
            ss.DestroyWhenDisposed = false;
            var mw = new MerkeWerte();
            if (ActData != null)
            {
                mw.LastSongID = ActData.Id;
                mw.InterpretFilter = cbInterpretFilter.Text;
                mw.GroupFilter = cbGroupFilter.Text;
            }
            ss.SharedFolder = Application.LocalUserAppDataPath;
            ss.StorageName = $@"{this.Name}";
            ss.AddOrUpdate("ComboBoxIds", mw);
        }

        void InfoRaised(object sender, MessageEventArgs k)
        {
            if (k.Key.ToString() == "debugmode")
            {
                db.debug = AppSingelton.Instance().DebugMode;
                RefreshData();
            }
        }

        public void SetupKeyboardHooks()
        {
            _globalKeyboardHook = new GlobalKeyboardHook
            {
                AutoHandled = false
            };
            _globalKeyboardHook.AddAllowedKey((int) BasicClassLibrary.Shortcut.ShiftRightArrow);
            _globalKeyboardHook.AddAllowedKey((int)BasicClassLibrary.Shortcut.ESC);
            _globalKeyboardHook.KeyboardPressed += OnKeyPressed;
        }

        
        private void OnKeyPressed(object sender, GlobalKeyboardHookEventArgs e)
        {
            if (AppSingelton.Instance().GlobalKeys) return;
            if (!_globalKeyboardHook.IsThisForm(this)) return;

            int vc = _globalKeyboardHook.KeyCode;
            if (vc == (int)BasicClassLibrary.Shortcut.ShiftRightArrow)
            {
                dgvSongs.Select();
                
                //Debug.WriteLine("ShiftRight");
                e.Handled = true;
            }
            else if(vc == (int)BasicClassLibrary.Shortcut.ESC)
            {
                e.Handled = true;
                Application.Exit();
            }

        }
        
        private static DataTable MakeParentTable()
        {
            // Create a new DataTable.
            System.Data.DataTable table = new DataTable("Notes");
            // Declare variables for DataColumn and DataRow objects.
            DataColumn column;


            // Create new DataColumn, set DataType,
            // ColumnName and add to DataTable.
            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "colID",
                Caption = "ID",
                ReadOnly = true,
                Unique = true
            };
            table.Columns.Add(column);




            // Create second column.
            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "colSongName",
                AutoIncrement = false,
                Caption = "Song Name",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "colInterpret",
                AutoIncrement = false,
                Caption = "Interpret",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "colGroup",
                AutoIncrement = false,
                Caption = "Group",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.DateTime"),
                ColumnName = "colStamp",
                AutoIncrement = false,
                Caption = "Stamp",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "colInstrument",
                AutoIncrement = false,
                Caption = "Instrument",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "colOrigin",
                AutoIncrement = false,
                Caption = "Origin",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.Int32"),
                ColumnName = "colRating",
                AutoIncrement = false,
                Caption = "Rating",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "colVariant",
                AutoIncrement = false,
                Caption = "Variante",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "colDifficulty",
                AutoIncrement = false,
                Caption = "Difficulty",
                ReadOnly = false,
                Unique = false
            };

            table.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.Object"),
                ColumnName = "colData",
                AutoIncrement = false,
                Caption = "Data",
                ReadOnly = true,
                Unique = false
            };
            table.Columns.Add(column);

            // Make the ID column the primary key column.
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = table.Columns["colID"];
            table.PrimaryKey = PrimaryKeyColumns;

            // Instantiate the DataSet variable.
            return table;
        }
        BindingSource bs;
        private void RefreshData()
        {
            ClearEdit();
            ClearPosEdit();
            GetInstrumentData();
            GetInterpretData();
            GetVarianteData();
            GetOriginData();
            GetGroupData();

            DataSet ds = new DataSet();
            
            DataTable dtab = MakeParentTable();
            ds.Tables.Add(dtab);
            
            var data = (string.IsNullOrEmpty(txtFilterSongName.Text) && string.IsNullOrEmpty(cbInterpretFilter.Text) && string.IsNullOrEmpty(cbGroupFilter.Text) ) ? db.DisplayPresetData(PfadClass.Instance().DatabasePfad, ckSortRating.Checked) : db.DisplayFilteredData(txtFilterSongName.Text, cbInterpretFilter.Text,cbGroupFilter.Text, PfadClass.Instance().DatabasePfad);
            foreach (var dt in data)
            {
                DataRow row = dtab.NewRow();

                row["colID"] = dt.Id.ToString();
                row["colSongName"] = dt.SongName;
                row["colInterpret"] = dt.Interpret;
                row["colStamp"] = dt.Stamp;
                row["colDifficulty"] = EnumHelper.GetDescription(dt.Difficulty);
                row["colVariant"] = dt.Variant;
                row["colInstrument"] = dt.Instrument;
                row["colOrigin"] = dt.Origin;
                row["colGroup"] = dt.Group;
                row["colRating"] = dt.Rating;
                row["colData"] = dt;
                try
                {
                    dtab.Rows.Add(row);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            bs = new BindingSource(ds, ds.Tables[0].TableName);
            bs.CurrentItemChanged += Bs_CurrentItemChanged;
            
            dgvSongs.DataSource = bs;

            dgvSongs.Columns["colID"].HeaderText                   = "ID";
            dgvSongs.Columns["colSongName"].HeaderText             = "Song Name";
            dgvSongs.Columns["colInterpret"].HeaderText            = "Interpret";
            dgvSongs.Columns["colStamp"].HeaderText = "Stamp";
            dgvSongs.Columns["colDifficulty"].HeaderText                = "Level";
            dgvSongs.Columns["colVariant"].HeaderText = "Variante";
            dgvSongs.Columns["colInstrument"].HeaderText = "Instrument";
            dgvSongs.Columns["colOrigin"].HeaderText             = "Origin";
            dgvSongs.Columns["colGroup"].HeaderText = "Group";
            dgvSongs.Columns["colRating"].HeaderText = "Rating";
            dgvSongs.Columns["colData"].HeaderText = "Data";


            dgvSongs.Columns["colStamp"].DefaultCellStyle.Format = "dd.MM.yyyy hh:mm:ss";
            dgvSongs.Columns["colID"].Visible      = AppSingelton.Instance().DebugMode;
            dgvSongs.Columns["colData"].Visible    = AppSingelton.Instance().DebugMode;
            gbSongGrid.Text = $@"Count:{bs.Count}";
            
            SelectID();
            
        }
        private void Bs_CurrentItemChanged(object sender, EventArgs e)
        {
            SelectID();
        }
        private void SelectID()
        {
            DataRowView ob = (DataRowView)  bs.Current;
            if (ob != null)
            {
                object data = ob.Row["colData"];
                if ( data.GetType().ToString() != "System.DBNull")
                {
                    ActData = (Notes)data;
                    DataToEdit();
                    DBSaveState = eDBSaveState.update;
                    hsSaveNewIndex.Enabled = false;
                    txtSortIndex.Enabled = (DBSaveState != eDBSaveState.insert);
                }
            }
        }

        Guid LastSongID;

        public bool SelectSongID(Guid SongID)
        {

            bs.Position = 0;
            while (bs.Position < bs.Count - 1)
            {
                DataRowView ob = (DataRowView)bs.Current;
                if (ob != null)
                {
                    object data = ob.Row["colData"];
                    if (data.GetType().ToString() != "System.DBNull")
                    {
                        ActData = (Notes)data;
                        if(ActData.Id == SongID)
                        {
                            return true;
                        }
                    }
                }
                bs.Position++;
            }
            bs.Position = 0;
            return false;
        }

        public void ClearEdit()
        {
            txtSongName.Text            = string.Empty;
            cbInterpret.Text            = string.Empty;
            cbInterpret.SelectedIndex   = -1;
            cbVariante.Text             = string.Empty;
            cbVariante.SelectedIndex    = -1;
            cbGroup.Text = string.Empty;
            cbGroup.SelectedIndex = -1;
            cbOrigin.Text             = string.Empty;
            cbOrigin.SelectedIndex    = -1;
            cbInstrument.Text           = string.Empty;
            cbInstrument.SelectedIndex  = -1;
            txtPageStep.Text            = $"{DefaultAttributes.DefaultPicStep}";
            txtSheetHeightFactor.Text   = $"{DefaultAttributes.DefaultPicHeightFactor}";
            txtSheetWidth.Text          = $"{DefaultAttributes.DefaultPicWidth}";
            txtPageShowCount.Text       = $"{DefaultAttributes.DefaultPicShowCount}";
            txtAutoStepTime.Text        = $"{DefaultAttributes.DefaultAutostepTime}";
            txtMetronomsSpeed.Text      = $"{DefaultAttributes.DefaultMetronomsSpeed}";

            lvFileList.Items.Clear();

            rbEasy.Checked          = false;
            rbBeginners.Checked     = false;
            rbIntermediate.Checked  = false;
            rbAdvanced.Checked      = false;
            rbDifficulty.Checked    = false;
            rbExperimantal.Checked  = false;
            Application.DoEvents();
        }
        public void ClearPosEdit()
        {
            txtSortIndex.Text = "1";
        }
        public void DataToEdit()
        {
            if (ActData != null)
            {
                txtSongName.Text            = ActData.SongName;
                cbInterpret.Text            = ActData.Interpret;
                cbVariante.Text             = ActData.Variant;
                cbInstrument.Text           = ActData.Instrument;
                cbOrigin.Text               = ActData.Origin;
                cbGroup.Text                = ActData.Group;
                txtRating.Text              = ActData.Rating.ToString();
                txtMetronomsSpeed.Text      = ActData.MetronomSpeed.ToString();
                txtSheetWidth.Text          = ActData.NotesAtt.PicWidth.ToString();
                txtSheetHeightFactor.Text   = ActData.NotesAtt.PicHeightFactor.ToString();
                txtPageStep.Text            = ActData.NotesAtt.PicStep.ToString();
                txtAutoStepTime.Text        = ActData.NotesAtt.PicAutoStepTime.ToString();
                txtPageShowCount.Text       = ActData.NotesAtt.PicShowCount.ToString();
                txtAutoStepTime.Text        = ActData.NotesAtt.PicAutoStepTime.ToString();
                
                switch (ActData.Difficulty)
                {
                    case eDifficulty.easy:          rbEasy.Checked = true; break;
                    case eDifficulty.beginners:     rbBeginners.Checked = true; break;
                    case eDifficulty.intermediate:  rbIntermediate.Checked = true; break;
                    case eDifficulty.advanced:      rbAdvanced.Checked = true; break;
                    case eDifficulty.difficult:     rbDifficulty.Checked = true; break;
                    case eDifficulty.professional:  rbProfessional.Checked = true; break;
                    case eDifficulty.experimental:  rbExperimantal.Checked = true; break;
                }
                RefreshPosData();
            }
        }
        public void EditToData()
        {
            if (ActData == null) ActData = new Notes();
            ActData.SongName   = txtSongName.Text;
            ActData.Interpret  = cbInterpret.Text;
            ActData.Variant    = cbVariante.Text;
            ActData.Instrument = cbInstrument.Text;
            ActData.Origin     = cbOrigin.Text;
            ActData.Group      = cbGroup.Text;
            ActData.Stamp      = DateTime.Now;
            ActData.Rating                      = StaticFunctionsClass.ToIntDef(txtRating.Text,  DefaultAttributes.DefaultRating);
            ActData.MetronomSpeed               = StaticFunctionsClass.ToIntDef(txtMetronomsSpeed.Text, DefaultAttributes.DefaultMetronomsSpeed);
            ActData.NotesAtt.PicWidth           = StaticFunctionsClass.ToDecimalDef(txtSheetWidth.Text, DefaultAttributes.DefaultPicWidth);
            ActData.NotesAtt.PicHeightFactor    = StaticFunctionsClass.ToDecimalDef(txtSheetHeightFactor.Text, DefaultAttributes.DefaultPicHeightFactor);
            ActData.NotesAtt.PicStep            = StaticFunctionsClass.ToDecimalDef(txtPageStep.Text, DefaultAttributes.DefaultPicStep);
            ActData.NotesAtt.PicShowCount       = StaticFunctionsClass.ToDecimalDef(txtPageShowCount.Text, DefaultAttributes.DefaultPicShowCount);
            ActData.NotesAtt.PicAutoStepTime    = StaticFunctionsClass.ToDecimalDef(txtAutoStepTime.Text, DefaultAttributes.DefaultAutostepTime);

            if (rbBeginners.Checked)
            {
                ActData.Difficulty = eDifficulty.beginners;
            }
            else if (rbEasy.Checked)
            {
                ActData.Difficulty = eDifficulty.easy;
            }
            else if (rbIntermediate.Checked)
            {
                ActData.Difficulty = eDifficulty.intermediate;
            }
            else if (rbAdvanced.Checked)
            {
                ActData.Difficulty = eDifficulty.advanced;
            }
            else if (rbDifficulty.Checked)
            {
                ActData.Difficulty = eDifficulty.difficult;
            }
            else if (rbProfessional.Checked)
            {
                ActData.Difficulty = eDifficulty.professional;
            }
            else if (rbExperimantal.Checked)
            {
                ActData.Difficulty = eDifficulty.experimental;
            }
            else
            {
                ActData.Difficulty = eDifficulty.none;
            }

            ActData.SongFiles = new DBFiles[lvFileList.Items.Count];
            int n = 0;
            foreach (ListViewItem lvi in lvFileList.Items)
            {
                ActData.SongFiles[n++] = (DBFiles)lvi.Tag;
            }
        }
        public void RefreshPosData()
        {
            var SFiles = new List<DBFiles>();
            lvFileList.Items.Clear();
            if (ActData.SongFiles != null)
            {
                SFiles.AddRange(ActData.SongFiles);
                SFiles.Sort();
                ActData.SongFiles = SFiles.ToArray();
                
                foreach (var fn in ActData.SongFiles)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { fn.SortIndex.ToString(), fn.FilesName, fn.FilesID, fn.GetStatusDescription(), EnumHelper.GetDescription(fn.FileType) })
                    {
                        Tag = fn
                    };
                    lvFileList.Items.Add(lvi);
                }
            }
            else
            {
                Console.WriteLine($@"SongName hat kein File: ID:{ActData.Id} SongName:{ActData.SongName}");
            }
            lvFileList.Columns["fileID"].Width = AppSingelton.Instance().DebugMode ? 250 : 0;
        }
        public void PosDataToEdit()
        {
            if (ActFileData != null)
            {
                txtSortIndex.Text = ActFileData.SortIndex.ToString();
                hsSaveNewIndex.Enabled = false;
            }
        }
        public void SetNewIndexToSongFiles()
        {
            if (ActFileData != null)
            {
                int inx = StaticFunctionsClass.ToIntDef(txtSortIndex.Text, -1);
                if (inx < 0) return;
                ActFileData.SortIndex = inx;
                for (int i = 0; i < ActData.SongFiles.Length; i++)
                {
                    if (ActFileData.FilesID == ActData.SongFiles[i].FilesID)
                    {
                        ActData.SongFiles[i].SortIndex = ActFileData.SortIndex;
                    }
                }
            }
        }
        private void InsertData()
        {
            EditToData();
            db.DBInsert(ActData);
            RefreshData();
        }
        private void GetInstrumentData()
        {
            cbInstrument.Items.Clear();
            DBInstrumentsClass DBInstruments = new DBInstrumentsClass();
            var instr = DBInstruments.GetAll();
            var i = DBInstrumentsClass.Sort_List("Ascending", "Instrument", instr);
            foreach (var inst in i)
            {
                cbInstrument.Items.Add(inst.Instrument);
            }
        }
        private void GetVarianteData()
        {
            cbVariante.Items.Clear();
            DBVariantsClass DBVarianten = new DBVariantsClass();
            var instr = DBVarianten.GetAll();
            var i = DBVariantsClass.Sort_List("Ascending", "Variant", instr);
            foreach (var inst in i)
            {
              cbVariante.Items.Add(inst.Variant);
            }
        }

        private void GetGroupData()
        {
       
            cbGroup.Items.Clear();
       
            DBGroupsClass DBGroups = new DBGroupsClass();
            var instr = DBGroups.GetAll();
            var i = DBVariantsClass.Sort_List("Ascending", "Group", instr);
            foreach (var inst in i)
            {
                cbGroup.Items.Add(inst.Group);
  
            }
          
        }
        private void GetGroupFilterData()
        {
            int ginx = cbGroupFilter.SelectedIndex;
            
            cbGroupFilter.Items.Clear();
            DBGroupsClass DBGroups = new DBGroupsClass();
            var instr = DBGroups.GetAll();
            var i = DBVariantsClass.Sort_List("Ascending", "Group", instr);
            foreach (var inst in i)
            {
                cbGroupFilter.Items.Add(inst.Group);
            }
            cbGroupFilter.SelectedIndex = ginx;
        }


        private void GetOriginData()
        {
            cbOrigin.Items.Clear();
            DBOriginClass DBHerkunfte = new DBOriginClass();
            var instr = DBHerkunfte.GetAll();
            var i = DBOriginClass.Sort_List("Ascending", "Origin", instr);
            foreach (var inst in i)
            {
                if (inst.Origin != null)
                {
                    cbOrigin.Items.Add(inst.Origin);
                }
            }
        }
        private void GetInterpretData()
        {
            cbInterpret.Items.Clear();
            var DB = new DBInterpretsClass();
            var instr = DB.GetAll();
            var i = DBInterpretsClass.Sort_List("Ascending", "Interpret", instr);
            foreach (var inst in i)
            {
              cbInterpret.Items.Add(inst.Interpret);
            }
        }

        private void GetInterpretFilterData()
        {
            int ginx = cbInterpretFilter.SelectedIndex;
            cbInterpretFilter.Items.Clear();
            var DB = new DBInterpretsClass();
            var instr = DB.GetAll();
            var i = DBInterpretsClass.Sort_List("Ascending", "Interpret", instr);
            foreach (var inst in i)
            {
                cbInterpretFilter.Items.Add(inst.Interpret);
            }
            cbInterpretFilter.SelectedIndex = ginx;
        }
        private void InsertInstrumentData()
        {
            if (string.IsNullOrEmpty(cbInstrument.Text)) return;
            DBInstrumentsClass DBInstruments = new DBInstrumentsClass();
            Instruments instr = DBInstruments.GetFirst(cbInstrument.Text);
            if (string.IsNullOrEmpty(instr.Instrument))
            {
                Instruments data = new Instruments
                {
                    Instrument = cbInstrument.Text,
                    Stamp = DateTime.Now
                };
                DBInstruments.DBInsert(data);
            }
        }
        private void InsertVarianteData()
        {
            if (string.IsNullOrEmpty(cbVariante.Text)) return;
            DBVariantsClass DBVarianten = new DBVariantsClass();
            Variants instr = DBVarianten.GetFirst(cbVariante.Text);
            if (string.IsNullOrEmpty(instr.Variant))
            {
                Variants data = new Variants
                {
                    Variant = cbVariante.Text,
                    Stamp = DateTime.Now
                };
                DBVarianten.DBInsert(data);
            }
        }
        private void InsertOriginData()
        {
            if (string.IsNullOrEmpty(cbOrigin.Text)) return;
            DBOriginClass DBHerkunfte = new DBOriginClass();
            Origins instr = DBHerkunfte.GetFirst(cbOrigin.Text);
            if (string.IsNullOrEmpty(instr.Origin))
            {
                Origins data = new Origins
                {
                    Origin = cbOrigin.Text,
                    Stamp = DateTime.Now
                };
                DBHerkunfte.DBInsert(data);
            }
        }

        private void InsertGroupsData()
        {
            if (string.IsNullOrEmpty(cbOrigin.Text)) return;
            DBGroupsClass DBHerkunfte = new DBGroupsClass();
            Groups instr = DBHerkunfte.GetFirst(cbGroup.Text);
            if (string.IsNullOrEmpty(instr.Group))
            {
                Groups data = new Groups
                {
                    Group = cbGroup.Text,
                    Stamp = DateTime.Now
                };
                DBHerkunfte.DBInsert(data);
            }
        }
        private void InsertInterpretData()
        {
            if (string.IsNullOrEmpty(cbInterpret.Text)) return;
            var DB = new DBInterpretsClass();
            Interprets instr = DB.GetFirst(cbInterpret.Text);
            if (string.IsNullOrEmpty(instr.Interpret))
            {
                var data = new Interprets
                {
                    Interpret = cbInterpret.Text,
                    Stamp = DateTime.Now
                };
                DB.DBInsert(data);
            }
        }
        private void DeleteInstrumentData()
        {
            if (string.IsNullOrEmpty(cbInstrument.Text)) return;
            var DB = new DBInstrumentsClass();
            Instruments instr = DB.GetFirst(cbInstrument.Text);
            if (!string.IsNullOrEmpty(instr.Instrument))
            {
                DB.DBDelete(instr);
            }
        }
        private void DeleteVarianteData()
        {
            if (string.IsNullOrEmpty(cbVariante.Text)) return;
            var DB = new DBVariantsClass();
            Variants instr = DB.GetFirst(cbVariante.Text);
            if (!string.IsNullOrEmpty(instr.Variant))
            {
                DB.DBDelete(instr);
            }
        }

        private void DeleteGroupsData()
        {
            if (string.IsNullOrEmpty(cbGroup.Text)) return;
            var DB = new DBGroupsClass();
            Groups instr = DB.GetFirst(cbGroup.Text);
            if (!string.IsNullOrEmpty(instr.Group))
            {
                DB.DBDelete(instr);
            }
        }


        private void DeleteOriginData()
        {
            if (string.IsNullOrEmpty(cbOrigin.Text)) return;
            var DB = new DBOriginClass();
            Origins instr = DB.GetFirst(cbOrigin.Text);
            if (!string.IsNullOrEmpty(instr.Origin))
            {
                DB.DBDelete(instr);
            }
        }
        private void DeleteInterpretData()
        {
            if (string.IsNullOrEmpty(cbInterpret.Text)) return;
            var DB = new DBInterpretsClass();
            Interprets instr = DB.GetFirst(cbInterpret.Text);
            if (!string.IsNullOrEmpty(instr.Interpret))
            {
                DB.DBDelete(instr);
            }
        }
        private void DeleteData()
        {
            EditToData();
            db.DBDelete(ActData);
            RefreshData();
        }
        private void UpdateData()
        {
            EditToData();
            ListViewItem lvi = (lvFileList.SelectedItems.Count > 0) ? lvFileList.SelectedItems[0] : null;
            db.DBUpdate(ActData);
            int pos = bs.Position;
            RefreshData();
            bs.Position = pos;
            if ((lvi == null) || (lvFileList.Items.Count < 1)) return;
            foreach (ListViewItem lvi2 in lvFileList.Items)
            {
                var data2 = (DBFiles)lvi2.Tag;
                var data = (DBFiles)lvi.Tag;
                if(data.FilesID == data2.FilesID)
                {
                    lvi2.Selected = true;
                }
            }
        }

        private void ShowNotes()
        {
            if (ActData != null)
            {
                int pos = bs.Position;
                this.Hide();
                var notes = ActData;
                var nf = new NotesForm();
                nf.LoadData(notes.Id);
                nf.ShowDialog();
                if (nf.BasicDatasUpdated)
                {
                    nf.BasicDatasUpdated = false;
                    RefreshData();
                }
                this.Show();
                dgvSongs.Select();
                bs.Position = pos;
            }
        }


        private void NewSong()
        {
            DBSaveState = eDBSaveState.insert;
            ActFileData = new DBFiles();
            
            ActData = new Notes();
            ActFileData = new DBFiles();
            ClearEdit();
            ClearPosEdit();
            txtSongName.Select();
        }
        private void SavePosData()
        {
            if (DBSaveState == eDBSaveState.update)
            {
                SetNewIndexToSongFiles();
                UpdateData();
                RefreshPosData();
                hsSaveNewIndex.Enabled = false;
            }
        }
        public void SortIndexChanged()
        {
            hsSaveNewIndex.Enabled = true;
        }
 
        private void UpdateSong()
        {
            if (DBSaveState == eDBSaveState.insert)
            {
                InsertData();
                DBSaveState = eDBSaveState.update;
            }
            else
            {
                int pos = bs.Position;
                int scrollpos = dgvSongs.FirstDisplayedScrollingRowIndex;
                UpdateData();
                dgvSongs.FirstDisplayedScrollingRowIndex = scrollpos;
                bs.Position = pos;
            }
        }

        private void AddFile()
        {
            var fd = new OpenFileDialog();
            if (lvFileList.SelectedItems.Count > 0)
            {
                string fn = lvFileList.SelectedItems[0].SubItems[(int)FileListColumnInx.originfilename].Text;
                FileInfo fi = new FileInfo(fn);
                if (fi.Directory.Exists)
                {
                    fd.InitialDirectory = fi.Directory.FullName;
                }
            }
            
            fd.Multiselect = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                int LastIndex = 0;
                foreach (ListViewItem lvi in lvFileList.Items)
                {
                    var fls = (DBFiles)lvi.Tag;
                    if (LastIndex < fls.SortIndex) LastIndex = fls.SortIndex;
                }
                int n = LastIndex;

                foreach (var filename in fd.FileNames)
                {
                    var dbf = new DBFiles
                    {
                        FilesName = filename,
                        SortIndex = ++n,
                        FilesID = Guid.NewGuid().ToString(),

                        FileType = GlobalFunctionsClass.Instance().SongType(filename)
                    };
                    dbf.SetAdded();
                    ListViewItem lvi = new ListViewItem(new string[] { dbf.SortIndex.ToString(), dbf.FilesName, dbf.FilesID, dbf.GetStatusDescription(), EnumHelper.GetDescription(dbf.FileType) })
                    {
                        Tag = dbf
                    };
                    lvFileList.Items.Add(lvi);
                }

                txtSortIndex.Enabled = (DBSaveState != eDBSaveState.insert);
                hsSaveNewIndex.Enabled = (DBSaveState != eDBSaveState.insert);
                hsUpdateSong.Enabled = (txtSongName.Text.Length > 0 && lvFileList.Items.Count > 0);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string cfile = $@"{Application.StartupPath}\data\SENotesConfig.XML";
            if (!File.Exists(cfile))
            {
                PfadClass.Instance().CreateDefault(cfile);
                PfadClass.Instance().SerializeCurrent();
            }

            PfadClass.Instance().Deserialize(cfile);
            hsRemoveFile.Enabled = false;
            ckSortRating.Checked = true;
            
            UpdateUI();
            GetInterpretFilterData();
            GetGroupFilterData();
            LoadUserDesign();
            RefreshData();
            
            SelectSongID(LastSongID);
            dgvSongs.Select();
        }

        public void UpdateUI()
        {
            this.Text = $@"SENotes DB:{PfadClass.Instance().DatabasePfad}";
        }
        private void lvFileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFileList.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvFileList.SelectedItems[0];
                ActFileData = (DBFiles)lvi.Tag;
                tsmiExportMuseScore2PDF.Enabled = (ActFileData.FileType == eDBSongFileType.musecorefile);
                tsmiExportMuseScore2MP3.Enabled = (ActFileData.FileType == eDBSongFileType.musecorefile);
                PosDataToEdit();
                DBSaveState = eDBSaveState.update;
                txtSortIndex.Enabled = true;
                hsSaveNewIndex.Enabled = false;
                hsUpdateSong.Enabled = (txtSongName.Text.Length > 0 && lvFileList.Items.Count > 0);
                hsRemoveFile.Enabled = true;
            }

            tsmiReloadFile.Enabled = (lvFileList.SelectedItems.Count > 0);
        }
        private void RemoveFile()
        {
            if (lvFileList.SelectedItems.Count > 0)
            {
                lvFileList.SelectedItems[0].SubItems[(int)FileListColumnInx.changed].Text = eDBFileSaveState.removed.ToString();
                ((DBFiles)lvFileList.SelectedItems[0].Tag).SetRemoved();
            }
        }

        private void txtSortIndex_TextChanged(object sender, EventArgs e)
        {
            SortIndexChanged();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SaveUserDesign();
            if(_globalKeyboardHook != null)
            {
                _globalKeyboardHook.KeyboardPressed  -= OnKeyPressed;
                _globalKeyboardHook?.Dispose();
            }
            this.Text = $@"SENotes DB:{PfadClass.Instance().DatabasePfad}";
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            cmsSongFiles.Close();
            if (e.ClickedItem == tsmiReloadFile)
            {
                string fn = lvFileList.SelectedItems[0].SubItems[(int)FileListColumnInx.originfilename].Text;
                var fd = new OpenFileDialog();
                FileInfo fi = new FileInfo(fn);
                if (fi.Directory.Exists)
                {
                    fd.InitialDirectory = fi.Directory.FullName;
                }

                fd.Multiselect = false;
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    lvFileList.SelectedItems[0].SubItems[(int)FileListColumnInx.changed].Text = $@"{eDBFileSaveState.imagechanged}";
                    lvFileList.SelectedItems[0].SubItems[(int)FileListColumnInx.originfilename].Text = fd.FileName;
                    ListViewItem lvi2 = lvFileList.SelectedItems[0];
                    ((DBFiles)lvi2.Tag).FilesName = fd.FileName;
                    ((DBFiles)lvi2.Tag).SetImageChanged();
                }
            }
            else if (e.ClickedItem == tsmiSongFileDown)
            {
                ListViewItem lvi = lvFileList.SelectedItems[0];
                ((DBFiles)lvi.Tag).SortIndex++;
                ((DBFiles)lvi.Tag).SetIndexChanged();
                lvFileList.SelectedItems[0].SubItems[(int)FileListColumnInx.changed].Text = $@"{eDBFileSaveState.indexchanged}";
                lvFileList.SelectedItems[0].SubItems[(int)FileListColumnInx.sortindex].Text = ((DBFiles)lvi.Tag).SortIndex.ToString();
            }
            else if (e.ClickedItem == tsmiSongFilesUp)
            {
                ListViewItem lvi = lvFileList.SelectedItems[0];
                ((DBFiles)lvi.Tag).SortIndex--;
                ((DBFiles)lvi.Tag).SetIndexChanged();
                lvFileList.SelectedItems[0].SubItems[(int)FileListColumnInx.changed].Text = $@"{eDBFileSaveState.indexchanged}";
                lvFileList.SelectedItems[0].SubItems[(int)FileListColumnInx.sortindex].Text = ((DBFiles)lvi.Tag).SortIndex.ToString();

            }
            else if (e.ClickedItem == tsmiExecuteMusicFile)
            {
                if (ActData != null)
                {
                    cmsSongFiles.Close();

                    ListViewItem lvi2 = lvFileList.SelectedItems[0];
                    var files = (DBFiles)lvi2.Tag;
                    var notes = ActData;

                    GlobalFunctionsClass.Instance().GetWriteTemp(db, notes.Id, files.FilesID, GlobalFunctionsClass.Instance().GetTempFile(files.FileType), files.FileType);
                    Process pc = new Process();

                    string pcstext = string.Empty;
                    string pcsargs = string.Empty;
                    if (files.FileType == eDBSongFileType.musecorefile)
                    {
                        pcstext = "\"" + PfadClass.Instance().MuseScoreExecute + "\"";
                        pcsargs = "\"" + GlobalFunctionsClass.Instance().GetTempFile(files.FileType) + "\"";
                    }
                    else if (files.FileType == eDBSongFileType.pdffile)
                    {
                        FileInfo fi = new FileInfo(GlobalFunctionsClass.Instance().GetTempFile(files.FileType));
                        if (fi.Exists)
                        {
                            //pcstext = fi.FullName.Replace("\\","/");
                            pcstext = "\"" + PfadClass.Instance().PDFExecute + "\"";
                            pcsargs = "\"" + fi.FullName + "\"";
                            pc.StartInfo.UseShellExecute = true;
                        }
                        else
                        {
                            MessageBox.Show(fi.FullName + " konnte nicht geöffnet werden", "Dokument öffnen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (files.FileType == eDBSongFileType.mp3file)
                    {

                        FileInfo fi = new FileInfo(GlobalFunctionsClass.Instance().GetTempFile(files.FileType));
                        if (fi.Exists)
                        {
                            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer
                            {
                                URL = fi.FullName
                            };
                            wplayer.controls.play();
                            ShowNotes();
                            return;
                            //pc.StartInfo.UseShellExecute = true;
                        }
                        else
                        {
                            MessageBox.Show(fi.FullName + " konnte nicht geöffnet werden", "Dokument öffnen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (files.FileType == eDBSongFileType.textfile)
                    {
                        pcstext = "\"" + PfadClass.Instance().TXTExecute + "\"";
                        pcsargs = "\"" + GlobalFunctionsClass.Instance().GetTempFile(files.FileType) + "\"";
                    }
                    else if (files.FileType == eDBSongFileType.songimage)
                    {
                        pcstext = "\"" + PfadClass.Instance().IMAGEExecute + "\"";
                        pcsargs = "\"" + GlobalFunctionsClass.Instance().GetTempFile(files.FileType) + "\"";
                    }

                    ProcessStartInfo pci = new ProcessStartInfo(pcstext, pcsargs);
                    pc.StartInfo = pci;

                    try
                    {
                        pc.Start();
                    }
                    catch
                    {
                        MessageBox.Show(pcsargs, pcstext);
                    }
                }
            }
            else if (e.ClickedItem == tsmiExportMuseScore2PDF)
            {
                if (ActData != null)
                {
                    ListViewItem lvi2 = lvFileList.SelectedItems[0];
                    var files = (DBFiles)lvi2.Tag;
                    var notes = ActData;

                    if (files.FileType == eDBSongFileType.musecorefile)
                    {
                        if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                        {
                            FileInfo fi = new FileInfo(files.FilesName);
                            string newfilename = fi.Name;
                            if (newfilename.EndsWith(fi.Extension)) newfilename = newfilename.Substring(0, newfilename.Length - fi.Extension.Length);
                            newfilename = newfilename.Replace(".", "_") + ".pdf";
                            GlobalFunctionsClass.Instance().GetWriteTemp(db, notes.Id, files.FilesID, GlobalFunctionsClass.Instance().GetTempFile(files.FileType), files.FileType);
                            FileInfo fitemp = new FileInfo(folderBrowserDialog1.SelectedPath + "\\" + fi.Name);
                            if (fitemp.Exists)
                            {
                                Process pc = new Process();

                                string pcstext = "\"" + PfadClass.Instance().MuseScoreExecute + "\"";
                                string pcsargs = "\"" + GlobalFunctionsClass.Instance().GetTempFile(files.FileType) + "\"" + " -o " + "\"" + folderBrowserDialog1.SelectedPath + "\\" + newfilename + "\"";

                                ProcessStartInfo pci = new ProcessStartInfo(pcstext, pcsargs);
                                pc.StartInfo = pci;

                                try
                                {
                                    Cursor.Current = Cursors.WaitCursor;
                                    Application.DoEvents();
                                    pc.Start();
                                    pc.WaitForExit();
                                }
                                catch
                                {
                                    MessageBox.Show(pcsargs, pcstext);
                                }
                                Cursor.Current = Cursors.Default;
                                FileInfo fipdf = new FileInfo(folderBrowserDialog1.SelectedPath + "\\" + newfilename);
                                if (fipdf.Exists)
                                {
                                    MessageBox.Show(fipdf.FullName, "PDF File created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show(fipdf.FullName, "PDF File not exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                MessageBox.Show(fitemp.FullName, "Temp File not exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
            }
            else if (e.ClickedItem == tsmiExportMuseScore2MP3)
            {
                if (ActData != null)
                {
                    ListViewItem lvi2 = lvFileList.SelectedItems[0];
                    var files = (DBFiles)lvi2.Tag;
                    var notes = ActData;

                    if (files.FileType == eDBSongFileType.musecorefile)
                    {
                        if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                        {
                            FileInfo fi = new FileInfo(files.FilesName);
                            string newfilename = fi.Name;
                            if (newfilename.EndsWith(fi.Extension)) newfilename = newfilename.Substring(0, newfilename.Length - fi.Extension.Length);
                            newfilename = newfilename.Replace(".", "_") + ".mp3";
                            GlobalFunctionsClass.Instance().GetWriteTemp(db, notes.Id, files.FilesID, GlobalFunctionsClass.Instance().GetTempFile(files.FileType), files.FileType);
                            FileInfo fitemp = new FileInfo(folderBrowserDialog1.SelectedPath + "\\" + fi.Name);
                            if (fitemp.Exists)
                            {
                                Process pc = new Process();

                                string pcstext = "\"" + PfadClass.Instance().MuseScoreExecute + "\"";
                                string pcsargs = "\"" + GlobalFunctionsClass.Instance().GetTempFile(files.FileType) + "\"" + " -o " + "\"" + folderBrowserDialog1.SelectedPath + "\\" + newfilename + "\"";

                                ProcessStartInfo pci = new ProcessStartInfo(pcstext, pcsargs);
                                pc.StartInfo = pci;

                                try
                                {
                                    Cursor.Current = Cursors.WaitCursor;
                                    Application.DoEvents();
                                    pc.Start();
                                    pc.WaitForExit();
                                }
                                catch
                                {
                                    MessageBox.Show(pcsargs, pcstext);
                                }
                                Cursor.Current = Cursors.Default;
                                FileInfo fipdf = new FileInfo(folderBrowserDialog1.SelectedPath + "\\" + newfilename);
                                if (fipdf.Exists)
                                {
                                    MessageBox.Show(fipdf.FullName, "MP3 File created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show(fipdf.FullName, "MP3 File not exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                MessageBox.Show(fitemp.FullName, "Temp File not exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
            }
            else if (e.ClickedItem == tsmiSetFileTypeSongfile)
            {
                foreach (ListViewItem lv in lvFileList.SelectedItems)
                {
                    lv.SubItems[(int)FileListColumnInx.changed].Text = EnumHelper.GetDescription(eDBFileSaveState.statuschanged);
                    lv.SubItems[(int)FileListColumnInx.filetype].Text = EnumHelper.GetDescription(eDBSongFileType.songimage);
                    ListViewItem lvi2 = lv;
                    ((DBFiles)lvi2.Tag).FileType = eDBSongFileType.songimage;
                    ((DBFiles)lvi2.Tag).SetStateChanged();
                }

            }
            else if (e.ClickedItem == tsmiSetFileTypeMuseScore)
            {
                foreach (ListViewItem lv in lvFileList.SelectedItems)
                {
                    lv.SubItems[(int)FileListColumnInx.changed].Text = EnumHelper.GetDescription(eDBFileSaveState.statuschanged);
                    lv.SubItems[(int)FileListColumnInx.filetype].Text = EnumHelper.GetDescription(eDBSongFileType.musecorefile);
                    ListViewItem lvi2 = lv;
                    ((DBFiles)lvi2.Tag).FileType = eDBSongFileType.musecorefile;
                    ((DBFiles)lvi2.Tag).SetStateChanged();
                }
            }
            else if (e.ClickedItem == tsmiSetFilePDFfile)
            {
                foreach (ListViewItem lv in lvFileList.SelectedItems)
                {
                    lv.SubItems[(int)FileListColumnInx.changed].Text = EnumHelper.GetDescription(eDBFileSaveState.statuschanged);
                    lv.SubItems[(int)FileListColumnInx.filetype].Text = EnumHelper.GetDescription(eDBSongFileType.pdffile);
                    ListViewItem lvi2 = lv;
                    ((DBFiles)lvi2.Tag).FileType = eDBSongFileType.pdffile;
                    ((DBFiles)lvi2.Tag).SetStateChanged();
                }
            }
            else if (e.ClickedItem == tsmiSetFileMP3)
            {
                foreach (ListViewItem lv in lvFileList.SelectedItems)
                {
                    lv.SubItems[(int)FileListColumnInx.changed].Text = EnumHelper.GetDescription(eDBFileSaveState.statuschanged);
                    lv.SubItems[(int)FileListColumnInx.filetype].Text = EnumHelper.GetDescription(eDBSongFileType.mp3file);
                    ListViewItem lvi2 = lv;
                    ((DBFiles)lvi2.Tag).FileType = eDBSongFileType.mp3file;
                    ((DBFiles)lvi2.Tag).SetStateChanged();
                }
            }
            else if (e.ClickedItem == tsmiSetFileText)
            {
                foreach (ListViewItem lv in lvFileList.SelectedItems)
                {
                    lv.SubItems[(int)FileListColumnInx.changed].Text = EnumHelper.GetDescription(eDBFileSaveState.statuschanged);
                    lv.SubItems[(int)FileListColumnInx.filetype].Text = EnumHelper.GetDescription(eDBSongFileType.textfile);
                    ListViewItem lvi2 = lv;
                    ((DBFiles)lvi2.Tag).FileType = eDBSongFileType.textfile;
                    ((DBFiles)lvi2.Tag).SetStateChanged();
                }
            }
        }
        private void dataChanged(object sender, EventArgs e)
        {
            DataChanged();
        }
        private void contextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem == tsmiAddNewSong)
            {
                NewSong();
            }
            else if(e.ClickedItem == tsmiDeleteSong)
            {
                DeleteData();
            }
        }
        private void lvFileList_Click(object sender, EventArgs e)
        {
            tsmiReloadFile.Enabled = (lvFileList.SelectedItems.Count > 0);
        }
        private void lvFileList_Enter(object sender, EventArgs e)
        {
            tsmiReloadFile.Enabled = (lvFileList.SelectedItems.Count > 0);
        }

        void DataChanged()
        {
            hsUpdateSong.Enabled = (txtSheetWidth.Text.Length > 0) &&
                                (txtPageStep.Text.Length > 0) &&
                                (txtSheetHeightFactor.Text.Length > 0) &&
                                (txtPageShowCount.Text.Length > 0) &&
                                (txtSongName.Text.Length > 0) &&
                                (lvFileList.Items.Count > 0);
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowNotes();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                int pos = bs.Position;
                ShowNotes();
                bs.Position = pos-1;
            }
            else if (e.KeyCode == Keys.Space)
            {
                ShowNotes();
            }
        }

        private void txtFilterInterpret_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                RefreshData();
                dgvSongs.Select();
            }
        }

        private void txtFilterSongName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                RefreshData();
                dgvSongs.Select();
            }
        }

 
        private void ckSortRating_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
            dgvSongs.Select();
        }

        private void hsMaintain_Click(object sender, EventArgs e)
        {
            MaintainanceForm mf = new MaintainanceForm(db);
            mf.ShowDialog();
            db.DatabasePath = PfadClass.Instance().DatabasePfad;
            UpdateUI();
            RefreshData();
            dgvSongs.Select();
        }

        private void hsShowNotes_Click(object sender, EventArgs e)
        {
            ShowNotes();
        }

        private void hsClose_Click_1(object sender, EventArgs e)
        {
            SaveUserDesign();
            Close();
        }

        private void hsRefresh_Click(object sender, EventArgs e)
        {
            int pos = bs.Position;
            int scrollpos = dgvSongs.FirstDisplayedScrollingRowIndex;
            RefreshData();
            dgvSongs.FirstDisplayedScrollingRowIndex = scrollpos;
            bs.Position = pos;
            dgvSongs.Select();
        }

        private void hsClearRefresh_Click(object sender, EventArgs e)
        {
            int pos = bs.Position;
            int scrollpos = dgvSongs.FirstDisplayedScrollingRowIndex;
            cbInterpretFilter.Text  = string.Empty;
            cbGroupFilter.Text      = string.Empty;
            txtFilterSongName.Text  = string.Empty;
            RefreshData();
            dgvSongs.FirstDisplayedScrollingRowIndex = scrollpos;
            bs.Position = pos;
            dgvSongs.Select();
        }

        private void hsNewSong_Click(object sender, EventArgs e)
        {
            AddFile();
        }

        private void hsRemoveFile_Click(object sender, EventArgs e)
        {
            RemoveFile();
        }

        private void hsSaveNewIndex_Click(object sender, EventArgs e)
        {
            SavePosData();
        }

        private void hsNewSong_Click_1(object sender, EventArgs e)
        {
            NewSong();
        }

        private void hotSpot2_Click(object sender, EventArgs e)
        {
            UpdateSong();
        }

        private void hsDeleteInterpret_Click(object sender, EventArgs e)
        {
            DeleteInterpretData();
            GetInterpretData();
        }

        private void hsSaveInterpret_Click(object sender, EventArgs e)
        {
            InsertInterpretData();
            GetInterpretData();
        }

        private void hsDeleteInstrument_Click(object sender, EventArgs e)
        {
            DeleteInstrumentData();
            GetInstrumentData();
        }

        private void hsInsertInstrument_Click(object sender, EventArgs e)
        {
            InsertInstrumentData();
            GetInstrumentData();
        }

        private void hsDeleteVariant_Click(object sender, EventArgs e)
        {
            DeleteVarianteData();
            GetVarianteData();
        }

        private void hsInsertVariant_Click(object sender, EventArgs e)
        {
            InsertVarianteData();
            GetVarianteData();
        }

        private void hsDeleteOrigin_Click(object sender, EventArgs e)
        {
            DeleteOriginData();
            GetOriginData();
        }

        private void hsInsertOrigin_Click(object sender, EventArgs e)
        {
            InsertOriginData();
            GetOriginData();
        }

        private void dgvSongs_SelectionChanged(object sender, EventArgs e)
        {
            hsUpdateSong.Enabled = false;
        }

        private void hsInsertGroup_Click(object sender, EventArgs e)
        {
            InsertGroupsData();
            GetGroupData();
        }

        private void hsDeleteGroup_Click(object sender, EventArgs e)
        {
            DeleteGroupsData();
            GetGroupData();
        }

        private void cbGroupFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
            dgvSongs.Select();
        }

        private void cbGroupFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                RefreshData();
                dgvSongs.Select();
            }
        }

        private void cbInterpretFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                RefreshData();
                dgvSongs.Select();
            
        }

        private void cbInterpretFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                RefreshData();
                dgvSongs.Select();
            }
        }
    }
}
