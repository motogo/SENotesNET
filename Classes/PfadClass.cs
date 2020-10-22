using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;


namespace SENotesNET
{

    public class ApplicationPathClass
    {
        public string MainPfad = System.Environment.CurrentDirectory;
        public string XMLName;
        /// <summary>
        /// Setzt für Pfadsysnonyme die richtigen Pfadteile ein.
        /// z.b. [ApplicationPfad]
        /// </summary>
        /// <param name="orgPath"></param>
        /// <returns></returns>
        /// private string CompletePath(string path)



        public string GetPath(string orgPath)
        {
            //   if (string.IsNullOrEmpty(orgPath)) return "none";
            if (string.IsNullOrEmpty(orgPath)) return "";

            string newpath = orgPath;

            if (newpath.IndexOf("[ProgramFilesFolder]") >= 0)
                newpath = newpath.Replace("[ProgramFilesFolder]", Application.StartupPath.TrimEnd('\\'));
            if (newpath.IndexOf("[ApplicationPath]") >= 0)
                newpath = newpath.Replace("[ApplicationPath]", Application.StartupPath.TrimEnd('\\'));
            if (newpath.IndexOf("[UserAppDataPath]") >= 0)
                newpath = newpath.Replace("[UserAppDataPath]", Application.UserAppDataPath.TrimEnd('\\'));
            if (newpath.IndexOf("[WinTempPath]") >= 0)
                newpath = newpath.Replace("[WinTempPath]", Environment.GetEnvironmentVariable("temp", EnvironmentVariableTarget.Machine).TrimEnd('\\'));
            if (newpath.IndexOf("[LocalTempPath]") >= 0)
                newpath = newpath.Replace("[LocalTempPath]", Environment.GetEnvironmentVariable("temp").TrimEnd('\\'));
            if (newpath.IndexOf("[CommonApplicationData]") >= 0)
                newpath = newpath.Replace("[CommonApplicationData]", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData).TrimEnd('\\'));
            if (newpath.IndexOf("[UserApplicationData]") >= 0)
                newpath = newpath.Replace("[UserApplicationData]", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).TrimEnd('\\'));

            if (newpath.IndexOf("[CommonFilesPath]") >= 0)
                newpath = newpath.Replace("[CommonFilesPath]", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86).TrimEnd('\\'));

            ;

            return (newpath);
        }

        public static string GetFullPath(string orgPath)
        {
            if (string.IsNullOrEmpty(orgPath)) return "";

            string newpath = orgPath;

            if (newpath.IndexOf("[ProgramFilesFolder]") >= 0)
                newpath = newpath.Replace("[ProgramFilesFolder]", Application.StartupPath).TrimEnd('\\');
            if (newpath.IndexOf("[ApplicationPath]") >= 0)
                newpath = newpath.Replace("[ApplicationPath]", Application.StartupPath).TrimEnd('\\');
            if (newpath.IndexOf("[UserAppDataPath]") >= 0)
                newpath = newpath.Replace("[UserAppDataPath]", Application.UserAppDataPath).TrimEnd('\\');
            if (newpath.IndexOf("[WinTempPath]") >= 0)
                newpath = newpath.Replace("[WinTempPath]", Environment.GetEnvironmentVariable("temp", EnvironmentVariableTarget.Machine).TrimEnd('\\'));
            if (newpath.IndexOf("[LocalTempPath]") >= 0)
                newpath = newpath.Replace("[LocalTempPath]", Environment.GetEnvironmentVariable("temp").TrimEnd('\\'));
            if (newpath.IndexOf("[CommonApplicationData]") >= 0)
                newpath = newpath.Replace("[CommonApplicationData]", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData).TrimEnd('\\'));
            if (newpath.IndexOf("[UserApplicationData]") >= 0)
                newpath = newpath.Replace("[UserApplicationData]", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).TrimEnd('\\'));
            if (newpath.IndexOf("[CommonFilesPath]") >= 0)
                newpath = newpath.Replace("[CommonFilesPath]", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86).TrimEnd('\\'));

            return (newpath);
        }

        public bool PathNotNone(string orgPath)
        {
            return ((orgPath != "none") && (orgPath != ""));
        }
        public string GetAppBegriff(string Path)
        {

            string newPath;
            if (Path != null)
            {
                newPath = Path;
                if (newPath.IndexOf(Application.StartupPath.TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Application.StartupPath.TrimEnd('\\'), "[ApplicationPath]");

                if (newPath.IndexOf(Application.UserAppDataPath.TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Application.UserAppDataPath.TrimEnd('\\'), "[UserAppDataPath]");

                if (newPath.IndexOf(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).TrimEnd('\\'), "[UserApplicationData]");

                if (newPath.IndexOf(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData).TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData).TrimEnd('\\'), "[CommonApplicationData]");

                if (newPath.IndexOf(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86).TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86).TrimEnd('\\'), "[CommonFilesPath]");

                if (newPath.IndexOf(Environment.GetEnvironmentVariable("temp").TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Environment.GetEnvironmentVariable("temp").TrimEnd('\\'), "[LocalTempPath]");

                if (newPath.IndexOf(Environment.GetEnvironmentVariable("temp", EnvironmentVariableTarget.Machine).TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Environment.GetEnvironmentVariable("temp", EnvironmentVariableTarget.Machine).TrimEnd('\\'), "[WinTempPath]");

                return (newPath);
            }
            else return (null);

        }

        public static string GetPathCode(string Path)
        {

            string newPath;
            if (Path != null)
            {
                newPath = Path;
                if (newPath.IndexOf(Application.StartupPath.TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Application.StartupPath.TrimEnd('\\'), "[ApplicationPath]");

                if (newPath.IndexOf(Application.UserAppDataPath.TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Application.UserAppDataPath.TrimEnd('\\'), "[UserAppDataPath]");

                if (newPath.IndexOf(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).TrimEnd('\\'), "[UserApplicationData]");

                if (newPath.IndexOf(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData).TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData).TrimEnd('\\'), "[CommonApplicationData]");

                if (newPath.IndexOf(Environment.GetEnvironmentVariable("temp").TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Environment.GetEnvironmentVariable("temp").TrimEnd('\\'), "[LocalTempPath]");

                if (newPath.IndexOf(Environment.GetEnvironmentVariable("temp", EnvironmentVariableTarget.Machine).TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Environment.GetEnvironmentVariable("temp", EnvironmentVariableTarget.Machine).TrimEnd('\\'), "[WinTempPath]");

                return (newPath);
            }
            else return (null);
        }
    }


    public class PfadClass : ApplicationPathClass
    {
        public string DatabasePfad = "";
        public string ExportPfad = "";
        public string MuseScoreExecute = "";
        public string MuseScoreTemp = "";
        public string PDFExecute = "";
        public string TXTExecute = "";
        public string IMAGEExecute = "";
        public string MP3Execute = "WMPLAYER";
        public int LastUserID;
        public string DBUsername="SYSDBA";

        public PfadClass()
        {

        }
        private static readonly object _lock_this = new object(); 
        static private volatile PfadClass instance = null;
        static public PfadClass Instance()
        {
            if (instance == null)
            {
                lock (_lock_this)
                {
                    instance = new PfadClass();
                }
            }
            return (instance);
        }


        public void CreateDefault(string cfile)
        {
            this.DBUsername = "guest";
            this.DatabasePfad = $@"{Application.StartupPath}\data\MyData.db";
            this.LastUserID = 1;
            this.XMLName = cfile;
            this.MuseScoreExecute = "";
            this.PDFExecute = "EXPLORER";
            this.TXTExecute = "NOTEPAD";
            this.IMAGEExecute = "PAINT";
        }
        public void TestParams()
        {
            string error_str = "";
            if (error_str.Length > 0)
                MessageBox.Show(error_str, "Pfade unvollständig !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public bool Deserialize(string FileName)
        {
            bool ok;
            XmlReader reader;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(PfadClass));
                Stream fs = new FileStream(FileName, FileMode.Open);
                reader = new XmlTextReader(fs);
                PfadClass PF = (PfadClass)serializer.Deserialize(reader);
                reader.Close();
                this.XMLName            = FileName;
                this.LastUserID         = PF.LastUserID;
                this.DatabasePfad       = PF.DatabasePfad;
                this.ExportPfad         = PF.ExportPfad;
                this.DBUsername         = PF.DBUsername;
                this.MuseScoreExecute   = PF.MuseScoreExecute;
                this.MuseScoreTemp      = PF.MuseScoreTemp;
                this.PDFExecute         = PF.PDFExecute;
                this.TXTExecute         = PF.TXTExecute;
                this.IMAGEExecute       = PF.IMAGEExecute;
                this.MP3Execute         = PF.MP3Execute;
                TestParams();
                ok = true;
            }
            catch (Exception ex)
            {
                ok = false;
                MessageBox.Show(FileName +" -> "+ ex.Message, "Grundparameter konnten nicht geladen werden.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return (ok);

            }
            finally
            {

            }
            return (ok);
        }
      
        public void SerializeCurrent()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PfadClass));
            XmlQualifiedName q1 = new XmlQualifiedName("", "");
            XmlQualifiedName[] names = { q1 };
            XmlSerializerNamespaces test = new XmlSerializerNamespaces(names);
           
            Stream writer = new FileStream(this.XMLName, FileMode.Create);                                                          
            
            serializer.Serialize(writer, instance, test);
            writer.Close();
        }

    }
}
