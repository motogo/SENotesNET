using BasicClassLibrary;
using SENotesNET.Classes;
using System;
using System.IO;
using System.Windows.Forms;

namespace SENotesNET
{
    public partial class MaintainanceForm : Form
    {

        DBClass db;
        NotifiesClass nf = new NotifiesClass();
        public MaintainanceForm(DBClass DB)
        {
            InitializeComponent();
            db = DB;
            nf.Register4Info(InfoRaised);
            nf.Register4Error(ErrorRaised);
            
        }

        void ErrorRaised(object sender, MessageEventArgs k)
        {
            rtLog.AppendText($@"ERROR:{k.Meldung}");
            rtLog.ScrollToCaret();
            Application.DoEvents();
        }



        void InfoRaised(object sender, MessageEventArgs k)
        {
            rtLog.AppendText($@"{k.Meldung}");
            rtLog.ScrollToCaret();
            Application.DoEvents();
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hsChangeDB_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(db.DatabasePath);
            ofdDB.InitialDirectory = fi.DirectoryName;
            if (ofdDB.ShowDialog() == DialogResult.OK)
            {
                nf.AddToINFO($@"Change Database from {PfadClass.Instance().DatabasePfad} to {ofdDB.FileName}");
                PfadClass.Instance().DatabasePfad = ofdDB.FileName;
                db.DatabasePath = PfadClass.Instance().DatabasePfad;
                
            }
        }

        private void hsExport_Click(object sender, EventArgs e)
        {
            var dbm = new DBMaintain();
            dbm.nf.Register4Info(InfoRaised);
            dbm.nf.Register4Error(ErrorRaised);
            DirectoryInfo di = new DirectoryInfo(PfadClass.Instance().ExportPfad);
            FileInfo[] fii = di.GetFiles();
            if (fii.Length > 0)
            {
                if (MessageBox.Show("Sollen alle ´Daten im Exportpfad gelöscht werden ?", "Exportpfad Daten vorhanden", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (FileInfo f in fii)
                    {
                        try
                        {
                            f.Delete();
                            nf.AddToINFO($@"Delete file:{f.FullName}");
                        }
                        catch
                        {

                        }
                    }
                }
            }
            if (di.Exists)
            {
                FileInfo fi = new FileInfo(db.DatabasePath);
                dbm.CopyDB(db.DatabasePath, $@"{fi.DirectoryName}\NewNotesData_{DateTime.Now.Ticks / 100000}.db", di.FullName);
            }
            else
            {
                MessageBox.Show($@"Der Exportpfad {PfadClass.Instance().ExportPfad} exitstiert nicht.{Environment.NewLine}Datenbank Kopie kann nicht erstellt werden.");
            }
        }

        private void MaintainanceForm_Load(object sender, EventArgs e)
        {
            lclActDatabase.Text = db.DatabasePath;
        }

        private void ckDebugMode_CheckedChanged(object sender, EventArgs e)
        {
            AppSingelton.Instance().DebugMode = ckDebugMode.Checked;
        }
    }
}
