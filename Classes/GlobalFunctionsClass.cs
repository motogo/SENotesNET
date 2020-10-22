using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SENotesNET
{
    class GlobalFunctionsClass
    {
        private static readonly object _lock_this = new object();
        static private volatile GlobalFunctionsClass instance;
        static public GlobalFunctionsClass Instance()
        {
            if (instance == null)
            {
                lock (_lock_this)
                {
                    instance = new GlobalFunctionsClass();
                }
            }
            return (instance);
        }

        public string GetTempFile(eDBSongFileType filetype)
        {
            string tempfile = string.Empty;
            if (filetype == eDBSongFileType.musecorefile)
            {
                tempfile = $@"{Application.StartupPath}\temp\senotes.mscz";
            }
            else if (filetype == eDBSongFileType.pdffile)
            {
                tempfile = $@"{Application.StartupPath}\temp\senotes.pdf";
            }
            else if (filetype == eDBSongFileType.mp3file)
            {
                tempfile = $@"{Application.StartupPath}\temp\senotes.mp3";
            }
            else if (filetype == eDBSongFileType.textfile)
            {
                tempfile = $@"{Application.StartupPath}\temp\senotes.txt";
            }
            else if (filetype == eDBSongFileType.songimage)
            {
                tempfile = $@"{Application.StartupPath}\temp\image.png";
            }
            return tempfile;
        }

        public void GetWriteTemp(DBClass db, Guid key, string filekey, string filename, eDBSongFileType filetype)
        {
            db.DatabasePath = PfadClass.Instance().DatabasePfad;
            var data = db.GetByID(key);
            Notes actData = data[0];
            foreach (var fls in actData.SongFiles)
            {
                string guid = fls.FilesID.ToString();
                if (guid == filekey.ToString())
                {
                    db.GetAndWriteMemoryStreamToFile(guid, filename);
                }
            }
        }

        public ifile GetWriteTemp2(DBClass db, string fileid,string filename,  string path)
        {
            
           
            FileInfo fi = new FileInfo(filename);
            string fn = fi.Name;
            ifile ifl = new ifile();
            ifl.filename = db.GetAndWriteMemoryStreamToFile(fileid, $@"{path}\{fn}");
            ifl.id = fileid;
            return ifl;
        }

        public eDBSongFileType SongType(string name)
        {
            string nn = name.ToUpper();
            if ((nn.EndsWith(".PNG")) || (nn.EndsWith(".GIF")) || (nn.EndsWith(".JPG")) || (nn.EndsWith(".JPEG")) || (nn.EndsWith(".BMP")))
            {
                return eDBSongFileType.songimage;
            }
            else if ((nn.EndsWith(".MSC")) || (nn.EndsWith(".MSCZ")))
            {
                return eDBSongFileType.musecorefile;
            }
            else if (nn.EndsWith(".PDF"))
            {
                return eDBSongFileType.pdffile;
            }
            else if (nn.EndsWith(".MP3"))
            {
                return eDBSongFileType.mp3file;
            }
            else if (nn.EndsWith(".TXT"))
            {
                return eDBSongFileType.textfile;
            }
            return eDBSongFileType.none;
        }
    }
}
