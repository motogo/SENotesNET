using BasicClassLibrary;
using SENotesNET.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using WMPLib;

namespace SENotesNET
{
    public partial class NotesForm : Form
    {
        public NotesForm()
        {
            InitializeComponent();
            SetupKeyboardHooks();
            SetDefaults();
        }

        readonly DBClass db = new DBClass();
        
        PictureListClass piclist = new PictureListClass();
        Notes actData;
        DBFiles AudioFile;
        int ActPicStart;
        GlobalKeyboardHook _globalKeyboardHook;
        int Step = 4;
        int ShowCount = 2;
        
        public void LoadData(Guid key)
        {

            BasicDatasUpdated = false;
            db.DatabasePath = PfadClass.Instance().DatabasePfad;
            var data = db.GetByID(key);
            
            piclist = new PictureListClass();
            var SFiles = new List<DBFiles>();
            
            actData = data[0];
            DataToEdit();
            EditToData();
            hsPauseSong.Enabled = false;
            hsPlaySong.Enabled = false;
            hsStopSong.Enabled = false;
            gbSongPlayer.Visible = false;
            SongState = ePlaySong.none;
            foreach (var actFl in actData.SongFiles)
            {
                if (GlobalFunctionsClass.Instance().SongType(actFl.FilesName) == eDBSongFileType.songimage)
                {
                    SFiles.Add(actFl);
                }
                else if (GlobalFunctionsClass.Instance().SongType(actFl.FilesName) == eDBSongFileType.mp3file)
                {
                    AudioFile = actFl;
                    if(AudioFile != null)
                    {
                        hsPauseSong.Enabled = false;
                        hsPlaySong.Enabled = true;
                        hsStopSong.Enabled = false;
                        SongState = ePlaySong.none;
                        gbSongPlayer.Visible = true;
                    }
                }
            }
            SFiles.Sort();
            actData.SongFiles = SFiles.ToArray();
            int n = 0;
            foreach (var fls in actData.SongFiles)
            {
                string guid = fls.FilesID.ToString();
                var files = db.GetImage(guid);
                piclist.AddNewPicture(pnlSheets, db.ActMemoryStream);
                n++;
            }
            pbShownPages.Minimum = 0;
            pbShownPages.Maximum = (n <= 1) ? 1 : n-1;
            pbShownPages.Value = (ActPicStart + ShowCount > pbShownPages.Maximum) ? pbShownPages.Maximum : ActPicStart + ShowCount;
        }

        public PictureClass GetSongFileImage(Guid key, string filekey)
        {
            db.DatabasePath = PfadClass.Instance().DatabasePfad;
            var data = db.GetByID(key);
            int n = 0;
            piclist = new PictureListClass();

            actData = data[0];
            
            
            foreach (var fls in actData.SongFiles)
            {
                string guid = fls.FilesID.ToString();
                if (guid == filekey.ToString())
                {
                    var files = db.GetImage(guid);
                    piclist.AddNewPicture(pnlSheets, db.ActMemoryStream);
                    return piclist.pictures[0];
                }
                n++;
            }
            return null;
        }
        public bool BasicDatasUpdated = false;

        public void UpdateData()
        {
            EditToData();
            BasicDatasUpdated = db.DBUpdateBasicDatas(actData);
        }

        private void NotesForm_Resize(object sender, EventArgs e)
        {
            piclist.Resize1();
        }

        public void SetupKeyboardHooks()
        {
            _globalKeyboardHook = new GlobalKeyboardHook();
            _globalKeyboardHook.AddAllowedKey((int)BasicClassLibrary.Shortcut.ShiftF1);
            _globalKeyboardHook.AddAllowedKey((int)BasicClassLibrary.Shortcut.F1);
            _globalKeyboardHook.AddAllowedKey((int)BasicClassLibrary.Shortcut.ShiftF2);
            _globalKeyboardHook.AddAllowedKey((int)BasicClassLibrary.Shortcut.F2);
            _globalKeyboardHook.AddAllowedKey((int)BasicClassLibrary.Shortcut.F5);
            _globalKeyboardHook.AddAllowedKey((int)BasicClassLibrary.Shortcut.ArrowLeft);
            _globalKeyboardHook.AddAllowedKey((int)BasicClassLibrary.Shortcut.ArrowRight);
            _globalKeyboardHook.AddAllowedKey((int)BasicClassLibrary.Shortcut.CtrlLeftArrow);
            _globalKeyboardHook.AddAllowedKey((int)BasicClassLibrary.Shortcut.CtrlRightArrow);
            _globalKeyboardHook.AddAllowedKey((int)BasicClassLibrary.Shortcut.CtrlDownArrow);
            _globalKeyboardHook.AddAllowedKey((int)BasicClassLibrary.Shortcut.CtrlUpArrow);
            _globalKeyboardHook.AddAllowedKey((int)BasicClassLibrary.Shortcut.ESC); 
            _globalKeyboardHook.AddAllowedKey((int)BasicClassLibrary.Shortcut.SPACE);
            _globalKeyboardHook.AddAllowedKey((int)BasicClassLibrary.Shortcut.CtrlM);
            _globalKeyboardHook.AddAllowedKey((int)BasicClassLibrary.Shortcut.CtrlA);

            _globalKeyboardHook.KeyboardPressed += _globalKeyboardHook_KeyboardP;
        }

        public void StepBack()
        {
            ActPicStart = (ActPicStart >= Step) ? ActPicStart - Step : 0;
            SetFact();
            piclist.IncreaseWidth(0);
            piclist.RefreshList(ActPicStart, ActPicStart + ShowCount - 1);
            pbShownPages.Value = (ActPicStart + ShowCount > pbShownPages.Maximum) ? pbShownPages.Maximum : ActPicStart + ShowCount;
        }

        public void StepForward(bool loop)
        {
            if (ActPicStart < piclist.PicCount() - Step)
            {
                ActPicStart += Step;
            }
            else
            {
                if (loop) ActPicStart = 0;
            }
            SetFact();
            piclist.IncreaseWidth(0);
            piclist.RefreshList(ActPicStart, ActPicStart + ShowCount - 1);
            pbShownPages.Value = (ActPicStart + ShowCount > pbShownPages.Maximum) ? pbShownPages.Maximum : ActPicStart + ShowCount;
        }

        private void _globalKeyboardHook_KeyboardP(object sender, GlobalKeyboardHookEventArgs e)
        {
            if (!_globalKeyboardHook.IsThisForm(this)) return;
            int key = _globalKeyboardHook.KeyCode;

            if (key == (int)BasicClassLibrary.Shortcut.ShiftF1)
            {
                nPicHeightFactor.Value--;
            }
            else if (key == (int)BasicClassLibrary.Shortcut.F1)
            {
                nPicHeightFactor.Value++;
            }
            else if (key == (int)BasicClassLibrary.Shortcut.ShiftF2)
            {
                nPicWidth.Value--;
            }
            else if (key == (int)BasicClassLibrary.Shortcut.F2)
            {
                nPicWidth.Value++;
            }
            else if (key == (int)BasicClassLibrary.Shortcut.ESC)
            {
                Close();
            }
            else if (key == (int)BasicClassLibrary.Shortcut.F5)
            {
                SetFact();
                piclist.IncreaseWidth(0);
                piclist.RefreshList(ActPicStart, ActPicStart + ShowCount - 1);
                
            }
            else if (key == (int)BasicClassLibrary.Shortcut.ArrowLeft)
            {
                StepBack();
            }
            else if ((key == (int)BasicClassLibrary.Shortcut.ArrowRight)|| (key == (int)BasicClassLibrary.Shortcut.SPACE))
            {
                StepForward(true);
            }
            else if (key == (int)BasicClassLibrary.Shortcut.CtrlLeftArrow)
            {
                nPicWidth.Value -= 1;
            }
            else if (key == (int)BasicClassLibrary.Shortcut.CtrlRightArrow)
            {
                nPicWidth.Value += 1;
            }
            else if (key == (int)BasicClassLibrary.Shortcut.CtrlDownArrow)
            {
                nPicHeightFactor.Value +=1;
            }
            else if (key == (int)BasicClassLibrary.Shortcut.CtrlUpArrow)
            {
                nPicHeightFactor.Value -= 1;
            }
            else if (key == (int)BasicClassLibrary.Shortcut.ESC)
            {
                e.Handled = true;
                Close();
            }
            else if (key == (int)BasicClassLibrary.Shortcut.CtrlM)
            {
                Metronom();
            }
            else if (key == (int)BasicClassLibrary.Shortcut.CtrlA)
            {
                AutoStep();
            }
            e.Handled = true;
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {
            piclist.SetWidth((int) actData.NotesAtt.PicWidth,  (int)nPicWidth.Minimum);
            piclist.SetFact((int)actData.NotesAtt.PicHeightFactor);
            piclist.ResizeToHeight();
            piclist.RefreshList(ActPicStart, ActPicStart + ShowCount - 1);
            piclist.Resize1();
            nMetronom.Value = actData.MetronomSpeed;
            SetFact();
            pnlSheets.Select();
        }

        public void SetFact()
        {
            piclist.SetFact((int) nPicHeightFactor.Value);
        }

        private void btnClose_click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void nUpDwn_ValueChanged(object sender, EventArgs e)
        {
            SetFact();
            piclist.IncreaseWidth(0);
            piclist.RefreshList(ActPicStart, ActPicStart + ShowCount - 1);
        }

        private void pnlUpper_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                piclist.IncreaseWidth(10);
            }
            else if (e.Button == MouseButtons.Left)
            {
                piclist.IncreaseWidth(-10);
            }            
            else
            {
                Console.WriteLine(e.Delta);
            }
        }
        private void NotesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmMetronom.Stop();
            tmSoundPlayer.Stop();
            timerAutoStep.Stop();
            if (_globalKeyboardHook != null)
            {
                _globalKeyboardHook.KeyboardPressed -= _globalKeyboardHook_KeyboardP;
                _globalKeyboardHook?.Dispose();
            }
        }

        private void nUpSheets_ValueChanged(object sender, EventArgs e)
        {
            Step = (int) nPicStep.Value;
            SetFact();
            piclist.IncreaseWidth(0);
            piclist.RefreshList(ActPicStart, ActPicStart + ShowCount - 1);
            pnlSheets.Select();
        }

        private void nUpWidth_ValueChanged(object sender, EventArgs e)
        {
            piclist.SetWidth((int)nPicWidth.Value, (int)nPicWidth.Minimum);
            piclist.IncreaseWidth(0);
            piclist.RefreshList(ActPicStart, ActPicStart + ShowCount - 1);
            pnlSheets.Select();
        }

        private void EditToData()
        {
            actData.NotesAtt.PicStep         = nPicStep.Value;
            actData.NotesAtt.PicWidth        = nPicWidth.Value;
            actData.NotesAtt.PicHeightFactor = nPicHeightFactor.Value;
            actData.NotesAtt.PicShowCount    = nPicShowCount.Value;
            actData.NotesAtt.PicAutoStepTime = nAutoStep.Value;
            actData.MetronomSpeed            = (int) nMetronom.Value;
        }

        public void SetDefaults()
        {
            
            nAutoStep.Minimum = MinMaxAttributes.MinAutostepTime;
            nAutoStep.Maximum = MinMaxAttributes.MaxAutostepTime;
            nAutoStep.Value = DefaultAttributes.DefaultAutostepTime;

            nMetronom.Minimum = MinMaxAttributes.MinMetronomSpeed;
            nMetronom.Maximum = MinMaxAttributes.MaxMetronomSpeed;
            nMetronom.Value = DefaultAttributes.DefaultMetronomsSpeed;

            nPicHeightFactor.Minimum = MinMaxAttributes.MinPicHeightFactor;
            nPicHeightFactor.Maximum = MinMaxAttributes.MaxPicHeightFactor;
            nPicHeightFactor.Value = DefaultAttributes.DefaultPicHeightFactor;

            nPicShowCount.Minimum = MinMaxAttributes.MinPicShowCount;
            nPicShowCount.Maximum = MinMaxAttributes.MaxPicShowCount;
            nPicShowCount.Value = DefaultAttributes.DefaultPicShowCount;

            nPicWidth.Minimum = MinMaxAttributes.MinPicWidth;
            nPicWidth.Maximum = MinMaxAttributes.MaxPicWidth;
            nPicWidth.Value = DefaultAttributes.DefaultPicWidth;

            nPicStep.Minimum = MinMaxAttributes.MinPicStep;            
            nPicStep.Maximum = MinMaxAttributes.MaxPicStep;
            nPicStep.Value = DefaultAttributes.DefaultPicStep;
        }

        private void DataToEdit()
        {
            nPicStep.Value         = ((nPicStep.Minimum <= actData.NotesAtt.PicStep) && (nPicStep.Maximum >= actData.NotesAtt.PicStep)) ? actData.NotesAtt.PicStep : DefaultAttributes.DefaultPicStep;
            nPicShowCount.Value    = ((nPicShowCount.Minimum <= actData.NotesAtt.PicShowCount) && (nPicShowCount.Maximum >= actData.NotesAtt.PicShowCount)) ? actData.NotesAtt.PicShowCount : DefaultAttributes.DefaultPicShowCount;
            nPicWidth.Value        = ((nPicWidth.Minimum <= actData.NotesAtt.PicWidth) && (nPicWidth.Maximum >= actData.NotesAtt.PicWidth)) ? actData.NotesAtt.PicWidth : DefaultAttributes.DefaultPicWidth;
            nPicHeightFactor.Value = ((nPicHeightFactor.Minimum <= actData.NotesAtt.PicHeightFactor) && (nPicHeightFactor.Maximum >= actData.NotesAtt.PicHeightFactor)) ? actData.NotesAtt.PicHeightFactor : DefaultAttributes.DefaultPicHeightFactor;
            nAutoStep.Value        = ((nAutoStep.Minimum <= actData.NotesAtt.PicAutoStepTime) && (nAutoStep.Maximum >= actData.NotesAtt.PicAutoStepTime)) ? actData.NotesAtt.PicAutoStepTime : DefaultAttributes.DefaultAutostepTime;
            nMetronom.Value        = ((nMetronom.Minimum <= actData.MetronomSpeed) && (nMetronom.Maximum >= actData.MetronomSpeed)) ? actData.MetronomSpeed : DefaultAttributes.DefaultMetronomsSpeed;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDefaultSize_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnDefa(object sender, EventArgs e)
        {
            
        }
        int ActAutostep;
        private void AutoStep()
        {
            if (timerAutoStep.Enabled)
            {
                timerAutoStep.Stop();
                pbAutoStep.Value = 0;
                
            }
            else
            {
                timerAutoStep.Stop();
                ActPicStart = 0;
                StepBack();
                timerAutoStep.Interval = 1000;
                ActAutostep = 0;
                pbAutoStep.Minimum = 0;
                pbAutoStep.Value = 0;
                pbAutoStep.Maximum = (int)nAutoStep.Value;
                timerAutoStep.Start();
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ActAutostep < (int)nAutoStep.Value)
            {
                ActAutostep++;
                pbAutoStep.Value = ActAutostep;
            }
            else
            {
                ActAutostep = 0;
                pbAutoStep.Value = ActAutostep;
                StepForward(true);
            }
        }

        private void nShowCount_ValueChanged(object sender, EventArgs e)
        {
            ShowCount = (int) nPicShowCount.Value;
            SetFact();
            piclist.IncreaseWidth(0);
            piclist.RefreshList(ActPicStart, ActPicStart + ShowCount - 1);
            pnlSheets.Select();
        }
        WMPLib.WindowsMediaPlayer wplayer;

        public void ShowPosition()
        {
            if ((wplayer != null) && (wplayer.enabled))
            {
                pbPlayMedia.Maximum = (int)(wplayer.currentMedia.duration*10);
                pbPlayMedia.Value = (int)(wplayer.controls.currentPosition*10);
                lblSoundPlayer.Text = $@"{wplayer.controls.currentPositionString} ({wplayer.currentMedia.durationString})";
            }
        }

        private void Player_PlayStateChange(int NewState)
        {
            
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            
        }
        
        private void PlaySong()
        {
            if (wplayer != null)
            {
                wplayer.controls.stop();
                wplayer.URL = null;
                wplayer = null;
            }
            

            wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            wplayer.PositionChange += Wplayer_PositionChange;
            wplayer.DurationUnitChange += Wplayer_DurationUnitChange;
            
            FileInfo fi = null;
            
            if(AudioFile != null)
            {
                GlobalFunctionsClass.Instance().GetWriteTemp(db, actData.Id, AudioFile.FilesID, GlobalFunctionsClass.Instance().GetTempFile(AudioFile.FileType), AudioFile.FileType);
                
                fi = new FileInfo(GlobalFunctionsClass.Instance().GetTempFile(AudioFile.FileType));
            }
            
            if (fi == null) return;
            if (fi.Exists)
            {
                wplayer.URL = fi.FullName;
                wplayer.controls.play();
                pbPlayMedia.Minimum = 0;
                pbPlayMedia.Value = 0;
                pbPlayMedia.Maximum = (int)(wplayer.currentMedia.duration * 10);
                tmSoundPlayer.Start();

                hsPlaySong.Enabled = false;
                hsStopSong.Enabled = true;
                hsPauseSong.Enabled = true;
                //ShowPosition();
                //th = new Thread(ShowPosition);
                //th.Start();
            }
        }
        //Thread th = null;
        private void Wplayer_DurationUnitChange(int NewDurationUnit)
        {
          //  textBox1.Text = "Duration "+ NewDurationUnit.ToString();
        }

        private void Wplayer_PositionChange(double oldPosition, double newPosition)
        {
          //  textBox1.Text = newPosition.ToString();
        }

        private void btnStopPlay_Click(object sender, EventArgs e)
        {
            StopPlay();
        }
        private void StopPlay()
        {
            if (wplayer != null)
            {
                tmSoundPlayer.Stop();
                lblSoundPlayer.Text = "0(0)";
                wplayer.controls.stop();
                wplayer.URL = null;
            }
            SongState = ePlaySong.stop;
            hsPlaySong.Enabled = true;
            hsPauseSong.Enabled = false;
            hsStopSong.Enabled = false;
            wplayer = null;
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            PauseSong();
        }

        enum ePlaySong {none=0, play=1,pause=2,stop=3 }
        ePlaySong SongState = ePlaySong.none;
        private void PauseSong()
        {
            if (wplayer != null)
            {
                tmSoundPlayer.Stop();
                wplayer.controls.pause();
                hsPlaySong.Enabled = true;
                hsStopSong.Enabled = true;
                hsPauseSong.Enabled = false;
                SongState = ePlaySong.pause;
            }
        }
        private void btnConinue_Click(object sender, EventArgs e)
        {
            SuspendSong();
        }
        private void SuspendSong()
        {
            if (wplayer != null)
            {
                wplayer.controls.play();
                SongState = ePlaySong.play;
                hsStopSong.Enabled = true;
                hsPlaySong.Enabled = false;
                hsPauseSong.Enabled = true;
                tmSoundPlayer.Start();
            }
        }

        private void tmSoundPlayer_Tick(object sender, EventArgs e)
        {
            ShowPosition();
        }

        private void btnMetronom_Click(object sender, EventArgs e)
        {
            
        }
        private void Metronom()
        {
            if (tmMetronom.Enabled)
            {
                
                tmMetronom.Stop();
            }
            else
            {
                
                tmMetronom.Interval = (int)((1000*60) / nMetronom.Value);
                sb = new SoundPlayer("Data\\click.wav");
                tmMetronom.Start();
            }
        }
        SoundPlayer sb;
        private void tmMetronom_Tick(object sender, EventArgs e)
        {
            sb.Play();
            //SystemSounds.Beep.Play();
           // Console.WriteLine();
        }

        private void btnVolumeUp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSoundDown_Click(object sender, EventArgs e)
        {
            
        }

        private void hsPlaySong_Click(object sender, EventArgs e)
        {
            if (SongState == ePlaySong.pause)
            {
                SuspendSong();
            }
            else
            {
                PlaySong();
            }
        }

        private void hsStopSong_Click(object sender, EventArgs e)
        {
            StopPlay();
        }

        private void hsPauseSong_Click(object sender, EventArgs e)
        {
            PauseSong();
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hsSoundUp_Click(object sender, EventArgs e)
        {
            SystemSoundClass sc = new SystemSoundClass();
            sc.VolumeUP();
        }

        private void hsSoundDown_Click(object sender, EventArgs e)
        {
            SystemSoundClass sc = new SystemSoundClass();
            sc.volumeDOWN();
        }

        private void hsStartMetronom_Click(object sender, EventArgs e)
        {
            if (tmMetronom.Enabled)
            {
                hsStartMetronom.SwitchImages2DefaultImage();
            }
            else
            {
                hsStartMetronom.SwitchImages2HoverImage();
            }
            Metronom();
        }

        private void hsAutoStep_Click(object sender, EventArgs e)
        {
            if (timerAutoStep.Enabled)
            {
                hsAutoStep.SwitchImages2DefaultImage();
            }
            else
            {
                hsAutoStep.SwitchImages2HoverImage();
            }
            AutoStep();
        }

        private void hsSaveAttributes_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void hsDefaultSize_Click(object sender, EventArgs e)
        {
            nPicStep.Value = DefaultAttributes.DefaultPicStep;
            nPicWidth.Value = DefaultAttributes.DefaultPicWidth;
            nPicHeightFactor.Value = DefaultAttributes.DefaultPicHeightFactor;
            nPicShowCount.Value = DefaultAttributes.DefaultPicShowCount;
        }

        private void hsRefresh_Click(object sender, EventArgs e)
        {
            ActPicStart = 0;
            piclist.SetWidth((int)actData.NotesAtt.PicWidth, (int)nPicWidth.Minimum);
            piclist.SetFact((int)actData.NotesAtt.PicHeightFactor);
            piclist.ResizeToHeight();
            piclist.RefreshList(ActPicStart, ActPicStart + ShowCount - 1);
            piclist.Resize1();
            SetFact();
            pnlSheets.Select();
        }
    }
}
