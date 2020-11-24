using BasicClassLibrary;
using Enums;
using LiteDB;
using LiteDB.Engine;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SENotesNET
{
    public enum eDifficulty
    {
        [EnumDescription("none")]
        none = 0,
        [EnumDescription("beginners")]
        beginners = 1,
        [EnumDescription("easy")]
        easy = 2,
        [EnumDescription("intermediate")]
        intermediate = 3,
        [EnumDescription("advanced")]
        advanced = 4,
        [EnumDescription("difficult")]
        difficult = 5,
        [EnumDescription("professional")]
        professional = 6,
        [EnumDescription("experimental")]
        experimental = 7
    }
    public enum eDBSaveState { insert = 0, update = 1, delete = 2 }

    public static class MinMaxAttributes
    {
        public const int MinAutostepTime = 0;
        public const int MaxAutostepTime = 120;
        public const int MinMetronomSpeed = 30;
        public const int MaxMetronomSpeed = 240;
        public const int MinPicHeightFactor = 10;
        public const int MaxPicHeightFactor = 100;
        public const int MinPicShowCount = 1;
        public const int MaxPicShowCount = 8;
        public const int MinPicWidth = 10;
        public const int MaxPicWidth = 1000;
        public const int MinPicStep = 1;
        public const int MaxPicStep = 8;
    }

    public static class DefaultAttributes
    {
        public const int DefaultAutostepTime = 30;
        public const int DefaultPicWidth = 700;
        public const int DefaultPicHeightFactor = 30;
        public const int DefaultPicStep = 4;
        public const int DefaultPicShowCount = 4;
        public const int DefaultRating = 0;
        public const int DefaultMetronomsSpeed = 90;
    }
    public enum eDBFileSaveState
    {
        [EnumDescription("NONE")]
        none = 0,
        [EnumDescription("Image changed")]
        imagechanged = 1,
        [EnumDescription("State changed")]
        statuschanged = 2,
        [EnumDescription("Removed")]
        removed = 3,
        [EnumDescription("Added")]
        added = 4,
        [EnumDescription("Index changed")]
        indexchanged = 5
    }

    public enum eDBSongFileType
    {
        [EnumDescription("NONE")]
        none = 0,
        [EnumDescription("Song File")]
        songimage = 1,
        [EnumDescription("MuseScore File")]
        musecorefile = 2,
        [EnumDescription("PDF File")]
        pdffile = 3,
        [EnumDescription("Text Info File")]
        textfile = 4,
        [EnumDescription("MP3 Audio File")]
        mp3file = 5
    };

    enum FileListColumnInx { sortindex = 0, originfilename = 1, fileid = 2, changed = 3, filetype = 4 }

    public class DBFiles : IEquatable<DBFiles>, IComparable<DBFiles>
    {
        public string FilesID { get; set; }
        public string FilesName { get; set; }
        public int SortIndex { get; set; }
        public eDBSongFileType FileType { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            DBFiles objAsPart = obj as DBFiles;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public bool Equals(DBFiles other)
        {
            if (other == null) return false;
            return (this.SortIndex.Equals(other.SortIndex));
        }

        public int CompareTo(DBFiles comparePart)
        {
            // A null value means that this object is greater.
            if (comparePart == null)
                return 1;

            else
                return this.SortIndex.CompareTo(comparePart.SortIndex);
        }

        public override string ToString()
        {
            return SortIndex.ToString();
        }

        private eDBFileSaveState ischanged = eDBFileSaveState.none;

        public eDBFileSaveState GetStatus()
        {
            return ischanged;
        }
        public string GetStatusDescription()
        {
            return EnumHelper.GetDescription(ischanged);
        }
        public void SetImageChanged()
        {
            ischanged = eDBFileSaveState.imagechanged;
        }
        public void SetIndexChanged()
        {
            ischanged = eDBFileSaveState.indexchanged;
        }
        public void SetStateChanged()
        {
            ischanged = eDBFileSaveState.statuschanged;
        }
        public void SetRemoved()
        {
            ischanged = eDBFileSaveState.removed;
        }

        public void SetAdded()
        {
            ischanged = eDBFileSaveState.added;
        }
        public void SetUnchanged()
        {
            ischanged = eDBFileSaveState.none;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(DBFiles left, DBFiles right)
        {
            if (ReferenceEquals(left, null))
            {
                return ReferenceEquals(right, null);
            }

            return left.Equals(right);
        }

        public static bool operator !=(DBFiles left, DBFiles right)
        {
            return !(left == right);
        }

        public static bool operator <(DBFiles left, DBFiles right)
        {
            return ReferenceEquals(left, null) ? !ReferenceEquals(right, null) : left.CompareTo(right) < 0;
        }

        public static bool operator <=(DBFiles left, DBFiles right)
        {
            return ReferenceEquals(left, null) || left.CompareTo(right) <= 0;
        }

        public static bool operator >(DBFiles left, DBFiles right)
        {
            return !ReferenceEquals(left, null) && left.CompareTo(right) > 0;
        }

        public static bool operator >=(DBFiles left, DBFiles right)
        {
            return ReferenceEquals(left, null) ? ReferenceEquals(right, null) : left.CompareTo(right) >= 0;
        }
    }
    public class NotesAttributes
    {
        public decimal PicHeightFactor { get; set; }
        public decimal PicWidth { get; set; }
        public decimal PicStep { get; set; }
        public decimal PicShowCount { get; set; }
        public decimal PicAutoStepTime { get; set; }
    }
    public class Notes
    {
        public Notes()
        {
            NotesAtt = new NotesAttributes();
        }
        public Guid Id { get; set; }
        public DateTime Stamp { get; set; }
        public string SongName { get; set; }
        public string Variant { get; set; }
        public string Interpret { get; set; }
        public string Instrument { get; set; }
        public string Origin { get; set; }
        public eDifficulty Difficulty { get; set; }
        public DBFiles[] SongFiles { get; set; }
        public NotesAttributes NotesAtt { get; set; }
        public int Rating { get; set; }
        public int MetronomSpeed { get; set; }
        public string Group { get; set; }
        public override string ToString()
        {
            return $@"{SongName} {Stamp.ToLongDateString()} {Stamp.ToLongTimeString()}";
        }
    }

    public class Instruments
    {
        public Instruments()
        {
        }
        public Guid Id { get; set; }
        public DateTime Stamp { get; set; }
        public string Instrument { get; set; }
    }

    public class Variants
    {
        public Variants()
        {
        }
        public Guid Id { get; set; }
        public DateTime Stamp { get; set; }
        public string Variant { get; set; }
    }

    public class Groups
    {
        public Groups()
        {
        }
        public Guid Id { get; set; }
        public DateTime Stamp { get; set; }
        public string Group { get; set; }
    }

    public class Origins
    {
        public Origins()
        {
        }
        public Guid Id { get; set; }
        public DateTime Stamp { get; set; }
        public string Origin { get; set; }
    }

    public class Interprets
    {
        public Interprets()
        {
        }
        public Guid Id { get; set; }
        public DateTime Stamp { get; set; }
        public string Interpret { get; set; }
    }
    

    public class DBMaintain
    {
        public NotifiesClass nf = new NotifiesClass();
        public void CopyDB(string oldDatabasePath, string newDatabasePath, string exportpath)
        {
            nf.AddToINFO($@"############################ START #################################{Environment.NewLine}");
            nf.AddToINFO($@"Copy Instruments from {oldDatabasePath} to {newDatabasePath}{Environment.NewLine}");
            DBInstrumentsClass dbi = new DBInstrumentsClass();
            dbi.nf = nf;
            dbi.DatabasePath = oldDatabasePath;
            dbi.CopyDB(newDatabasePath);

            nf.AddToINFO($@"{Environment.NewLine}####################################################################");
            nf.AddToINFO($@"Copy Varianten from {oldDatabasePath} to {newDatabasePath}{Environment.NewLine}");
            DBVariantsClass dbv = new DBVariantsClass();
            dbv.nf = nf;
            dbv.DatabasePath = oldDatabasePath;
            dbv.CopyDB(newDatabasePath);

            nf.AddToINFO($@"{Environment.NewLine}####################################################################");
            nf.AddToINFO($@"Copy Herkünfte from {oldDatabasePath} to {newDatabasePath}{Environment.NewLine}");
            DBOriginClass dbh = new DBOriginClass();
            dbh.nf = nf;
            dbh.DatabasePath = oldDatabasePath;
            dbh.CopyDB(newDatabasePath);

            nf.AddToINFO($@"{Environment.NewLine}####################################################################");
            nf.AddToINFO($@"Copy Interpreten from {oldDatabasePath} to {newDatabasePath}{Environment.NewLine}");
            DBInterpretsClass dbn = new DBInterpretsClass();
            dbn.nf = nf;
            dbn.DatabasePath = oldDatabasePath;
            dbn.CopyDB(newDatabasePath);

            nf.AddToINFO($@"{Environment.NewLine}####################################################################");
            nf.AddToINFO($@"Copy Noten und Songfiles from {oldDatabasePath} to {newDatabasePath}{Environment.NewLine}");
            DBClass dbc = new DBClass();
            dbc.nf = nf;
            dbc.DatabasePath = oldDatabasePath;
            dbc.CopyDB(newDatabasePath, exportpath);

            nf.AddToINFO($@"{Environment.NewLine}########################## END #####################################");
        }
    }

    public class ifile
    {
        public string filename;
        public string id;
    }

    public class DBBasicClass
    {
        public NotifiesClass nf = new NotifiesClass();
        public string NotesSchema = "notesdata";
        
        public MemoryStream ActMemoryStream;

        public string DatabasePath = $@"{Application.StartupPath}\data\MyData.db";
    }

    

    public class DBClass : DBBasicClass
    {
        
        
        public List<Notes> GetByID(Guid key)
        {
            var list = new List<Notes>();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<Notes>(NotesSchema);
                foreach (Notes _id in col.Find(x => x.Id == key).OrderByDescending(x => x.Rating))
                {
                    list.Add(_id);
                }
            }
            return list;
        }

        public List<Notes> GetAll(bool sort)
        {
            return GetAll(this.DatabasePath,sort);
        }
        public List<Notes> GetAll(string databasePath, bool sort)
        {
            var list = new List<Notes>();
            using (var db = new LiteDatabase(databasePath))
            {
                var col = db.GetCollection<Notes>(NotesSchema);
                try
                {
                    if (sort)
                    {
                        foreach (Notes _id in col.FindAll().OrderByDescending(x => x.Rating))
                        {
                            try
                            {
                                list.Add(_id);
                            }
                            catch
                            {
                                Console.WriteLine($@"ID:{_id} not found");
                            }
                        }
                    }
                    else
                    {
                        foreach (Notes _id in col.FindAll())
                        {
                            try
                            {
                                list.Add(_id);
                            }
                            catch
                            {
                                Console.WriteLine($@"ID:{_id} not found");
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine($@"{ex.Message}");
                }
            }
            return list;
        }

        public void rebuild()
        {
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<Notes>(NotesSchema);
                RebuildOptions ro = new RebuildOptions();
                
                db.Rebuild();
            }
        }
        private List<Notes> GetFilter(string songname, string interpret, string group)
        {
            var list = new List<Notes>();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<Notes>(NotesSchema);

                if (!string.IsNullOrEmpty(songname) && !string.IsNullOrEmpty(interpret))
                {
                    foreach (Notes _id in col.Find(x => x.SongName.ToUpper().Contains(songname.ToUpper()) && x.Interpret.ToUpper().Contains(interpret.ToUpper())).OrderByDescending(x=>x.Rating))
                    {
                        list.Add(_id);
                    }
                }
                else if (!string.IsNullOrEmpty(songname))
                {
                    foreach (Notes _id in col.Find(x => x.SongName.ToUpper().Contains(songname.ToUpper())))
                    {
                        list.Add(_id);
                    }
                }
                else if (!string.IsNullOrEmpty(interpret))
                {
                    foreach (Notes _id in col.Find(x => x.Interpret.ToUpper().Contains(interpret.ToUpper())))
                    {
                        list.Add(_id);
                    }
                }
                else if (!string.IsNullOrEmpty(group))
                {
                    foreach (Notes _id in col.Find(x => x.Group.ToUpper().Contains(group.ToUpper())))
                    {
                        list.Add(_id);
                    }
                }
            }
            return list;
        }

        public Notes GetFirst(string key)
        {
            var list = new Notes();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<Notes>(NotesSchema);
                if (string.IsNullOrEmpty(key))
                {
                    foreach (Notes _id in col.FindAll())
                    {
                        list = _id;
                    }
                }
                else
                {
                    foreach (Notes _id in col.Find(x => x.SongName == key))
                    {
                        list = _id;
                    }
                }
            }
            return list;
        }
        public List<Notes> DisplayPresetData(string databasePath, bool sort)
        {
            this.DatabasePath = databasePath;
            return GetAll(sort);
        }

        
        public void CopyDB(string databasePath, string exportpath)
        {
            List<Notes> source = GetAll(false);
            foreach(Notes data in source)
            {
                if(data.Id.ToString().Contains("0000-0000"))
                {
                    continue;
                }
                List<ifile> imagefilelist = new List<ifile>();
                foreach (DBFiles dbFile in data.SongFiles)
                {
                    ifile imagefile = GlobalFunctionsClass.Instance().GetWriteTemp2(this, dbFile.FilesID,dbFile.FilesName, exportpath);
                    imagefilelist.Add(imagefile);
                }
                DBInsert2(data, databasePath, false, imagefilelist);
            }
        }
        public List<Notes> DisplayFilteredData(string songname, string interpret,string group, string databasePath)
        {
            this.DatabasePath = databasePath;
            return GetFilter(songname,interpret,group);
        }
        public Notes DisplayFirstPresetData()
        {
            return GetFirst("");
        }

        public bool DBInsert(Notes datas)
        {
            return DBInsert(datas,this.DatabasePath, true);
        }
        public bool DBInsert(Notes datas, string databasePath, bool createID)
        {
            string connectionStr = databasePath;
            try
            {
                using (var db = new LiteDatabase(connectionStr))
                {
                    // Get customer collection
                    var notes = db.GetCollection<Notes>(NotesSchema);

                    notes.EnsureIndex(x => x.SongName);
                    notes.EnsureIndex(x => x.Stamp);

                    // Insert (Id will be auto-incremented)
                    if(createID) datas.Id = Guid.NewGuid();
                    string gstr = datas.Id.ToString();
                    //Falls eintrag als removed geennzeichnte -> entfernen
                    List<DBFiles> dbf = new List<DBFiles>();
                    foreach (var data in datas.SongFiles)
                    {
                        if (data.GetStatus() != eDBFileSaveState.removed)
                        {
                            dbf.Add(data);
                        }
                    }

                    datas.SongFiles = dbf.ToArray();
                    db.BeginTrans();
                    BsonValue bv = notes.Insert(datas);
                    if ((bv.ToString().Contains("0000-0000")) || !(bv.ToString().Contains(gstr)))
                    {
                        MessageBox.Show($@"new id:{gstr} is not id after insert {bv}", "ERROR Insert Notes");
                        db.Rollback();
                        
                    }
                    else
                    { 
                        // Storing a file stream inside database
                        foreach (var imagePath in datas.SongFiles)
                        {
                            if ((imagePath.GetStatus() == eDBFileSaveState.added) || (imagePath.GetStatus() == eDBFileSaveState.imagechanged))
                            {
                                FileStream stream = new FileStream($@"{imagePath.FilesName}", FileMode.Open, FileAccess.ReadWrite);
                                db.FileStorage.Upload(imagePath.FilesID, $@"{imagePath.FilesName}", stream);
                                stream.Close();
                            }
                        }
                        db.Commit();
                        if(debug) MessageBox.Show($@"Insert done new id:{datas.Id}", "Insert Notes");
                    }
                    return true;
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }
        public bool DBInsert2(Notes datas, string databasePath, bool createID, List<ifile> imagefilelist)
        {
            string connectionStr = databasePath;
            try
            {
                using (var db = new LiteDatabase(connectionStr))
                {
                    // Get customer collection
                    var notes = db.GetCollection<Notes>(NotesSchema);

                    notes.EnsureIndex(x => x.SongName);
                    notes.EnsureIndex(x => x.Stamp);

                    // Insert (Id will be auto-incremented)
                    if (createID) datas.Id = Guid.NewGuid();
                    string gstr = datas.Id.ToString();
                    //Falls eintrag als removed geennzeichnte -> entfernen
                    List<DBFiles> dbf = new List<DBFiles>();
                    foreach (var data in datas.SongFiles)
                    {
                        if (data.GetStatus() != eDBFileSaveState.removed)
                        {
                            dbf.Add(data);
                        }
                    }

                    datas.SongFiles = dbf.ToArray();
                    db.BeginTrans();
                    BsonValue bv = notes.Insert(datas);
                    
                    if ((bv.ToString().Contains("0000-0000")) || !(bv.ToString().Contains(gstr)))
                    {
                        nf.AddToERROR($@"new id:{gstr} is not id after insert {bv}");
                        db.Rollback();
                    }
                    else
                    {
                        // Storing a file stream inside database
                        nf.AddToINFO($@"Inserted Song:{bv.ToString()}->{datas.SongName}");
                        foreach (var imagePath in datas.SongFiles)
                        {
                            ifile ifl = imagefilelist.Find(x => x.id == imagePath.FilesID);
                            if (ifl != null)
                            {
                                FileStream stream = new FileStream($@"{ifl.filename}", FileMode.Open, FileAccess.ReadWrite);
                                nf.AddToINFO($@"Upload:{imagePath.FilesName}");
                                var list = db.FileStorage.Upload(imagePath.FilesID, $@"{ifl.filename}", stream);
                                nf.AddToINFO($@"Uploaded:{ list.Length}");
                                stream.Close();
                            }
                        }
                        db.Commit();
                        if (debug) MessageBox.Show($@"Insert done new id:{datas.Id}", "Insert Notes");
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                nf.AddToERROR($@"{ex.Message}");
                Debug.WriteLine(ex.Message);
            }
            return false;
        }
        public bool debug = false;
        public bool DBDelete(Notes datas)
        {
            string connectionStr = DatabasePath;
            try
            {
                using (var db = new LiteDatabase(connectionStr))
                {
                    // Get customer collection
                    var notes = db.GetCollection<Notes>(NotesSchema);

                    //Notenblätter löschen
                    foreach (var imagePath in datas.SongFiles)
                    {
                        if (imagePath.GetStatus() == eDBFileSaveState.removed)
                        {
                            FileStream stream = new FileStream($@"{imagePath.FilesName}", FileMode.Open, FileAccess.ReadWrite);
                            db.FileStorage.Delete(imagePath.FilesID);
                            stream.Close();
                        }
                    }
                    bool ok = notes.Delete(datas.Id);
                    return ok;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }

        public bool DBUpdate(Notes datas)
        {
            var lf = Application.StartupPath;
            string connectionStr = DatabasePath;
            using (var db = new LiteDatabase(connectionStr))
            {
                var notes = db.GetCollection<Notes>(NotesSchema);
                notes.EnsureIndex(x => x.SongName);
                notes.EnsureIndex(x => x.Stamp);

                //Löschen eines Notenblatts Images 
                foreach (var imagePath in datas.SongFiles)
                {
                    if (imagePath.GetStatus() == eDBFileSaveState.removed)
                    {
                        db.FileStorage.Delete(imagePath.FilesID);
                    }
                }
                //Entfernen des gelöschten Eintrages
                List<DBFiles> dbf = new List<DBFiles>();
                foreach (var data in datas.SongFiles)
                {
                    if (data.GetStatus() != eDBFileSaveState.removed)
                    {
                        dbf.Add(data);
                    }
                }

                datas.SongFiles = dbf.ToArray();
                notes.Update(datas);

                //Bei veränderten File oder neu zugefügten Eintrag Notenimage hochladen
                foreach (var imagePath in datas.SongFiles)
                {
                    if (imagePath.GetStatus()== eDBFileSaveState.imagechanged)
                    {
                        //Reload
                        FileStream stream = new FileStream($@"{imagePath.FilesName}", FileMode.Open, FileAccess.ReadWrite);
                        db.FileStorage.Delete(imagePath.FilesID);
                        db.FileStorage.Upload(imagePath.FilesID, $@"{imagePath.FilesName}", stream);
                        
                        stream.Close();
                    }
                    else if (imagePath.GetStatus() == eDBFileSaveState.added)
                    {
                        //Add
                        FileStream stream = new FileStream($@"{imagePath.FilesName}", FileMode.Open, FileAccess.ReadWrite);
                        db.FileStorage.Upload(imagePath.FilesID, $@"{imagePath.FilesName}", stream);
                        stream.Close();
                    }
                }
                return true;
            }
        }

        public bool DBUpdateSongFile(Notes datas, string SongFileID)
        {
            var lf = Application.StartupPath;
            string connectionStr = DatabasePath;
            using (var db = new LiteDatabase(connectionStr))
            {
                var notes = db.GetCollection<Notes>(NotesSchema);
                notes.EnsureIndex(x => x.SongName);
                notes.EnsureIndex(x => x.Stamp);
                notes.Update(datas);
                
                foreach (var imagePath in datas.SongFiles)
                {
                    if ((SongFileID == imagePath.FilesID)&&(imagePath.GetStatus()== eDBFileSaveState.imagechanged))
                    {
                        FileStream stream = new FileStream($@"{imagePath.FilesName}", FileMode.Open, FileAccess.ReadWrite);
                        db.FileStorage.Delete(imagePath.FilesID);
                        db.FileStorage.Upload(imagePath.FilesID, $@"{imagePath.FilesName}", stream);
                        stream.Close();
                    }
                }
                return true;
            }
        }
        
        public bool DBUpdateBasicDatas(Notes datas)
        {
            var lf = Application.StartupPath;
            string connectionStr = DatabasePath;
            using (var db = new LiteDatabase(connectionStr))
            {
                var notes = db.GetCollection<Notes>(NotesSchema);
                notes.EnsureIndex(x => x.SongName);
                notes.EnsureIndex(x => x.Stamp);
                notes.Update(datas);
                
                return true;
            }
        }

        public static object GetDynamicSortProperty(object item, string propName)
        {
            //Use reflection to get order type
            return item.GetType().GetProperty(propName).GetValue(item, null);
        }
        public static List<T> Sort_List<T>(string sortDirection, string sortExpression, List<T> data)
        {
            List<T> data_sorted = new List<T>();
            if (sortDirection == "Ascending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) ascending
                               select n).ToList();
            }
            else if (sortDirection == "Descending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) descending
                               select n).ToList();
            }
            return data_sorted;
        }

        public LiteFileInfo<string> GetImage(string guid)
        {
            string connectionStr = DatabasePath;
            using (var db = new LiteDatabase(connectionStr))
            {
                ActMemoryStream = new MemoryStream();
                LiteFileInfo<string> files = new LiteFileInfo<string>();
                try
                {
                    files = db.FileStorage.Download(guid, ActMemoryStream);
                }
                catch
                {

                }
                return files;
            }
        }

        public string GetAndWriteMemoryStreamToFile(string guid, string filename)
        {
            string connectionStr = DatabasePath;
            using (var db = new LiteDatabase(connectionStr))
            {
                ActMemoryStream = new MemoryStream();

                string tempfile = filename;
                
                FileStream filestream = new FileStream(tempfile, FileMode.Create);
                LiteFileInfo<string> files = new LiteFileInfo<string>();
                try
                {
                    files = db.FileStorage.Download(guid, ActMemoryStream);
                    files.CopyTo(filestream);
                    string data = string.Empty;
                    using (StreamReader sr = new StreamReader(filestream))
                    {
                        data = sr.ReadToEnd();
                        sr.Close();
                    }
                }
                catch
                {

                }
                filestream.Close();
                return tempfile;
            }
        }
    }

    class DBInstrumentsClass : DBBasicClass
    {
        string AttributesSchema = "instrumentsdata";
        public List<Instruments> GetByID(Guid key)
        {
            var list = new List<Instruments>();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<Instruments>(AttributesSchema);
                foreach (Instruments _id in col.Find(x => x.Id == key))
                {
                    list.Add(_id);
                }
            }
            return list;
        }
        public List<Instruments> GetAll()
        {
            var list = new List<Instruments>();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<Instruments>(AttributesSchema);
                foreach (Instruments _id in col.FindAll())
                {
                    list.Add(_id);
                }
            }
            return list;
        }

        public Instruments GetFirst(string key)
        {
            var list = new Instruments();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<Instruments>(AttributesSchema);
                if (string.IsNullOrEmpty(key))
                {
                    foreach (Instruments _id in col.FindAll())
                    {
                        list = _id;
                    }
                }
                else
                {
                    foreach (Instruments _id in col.Find(x => x.Instrument == key))
                    {
                        list = _id;
                    }
                }
            }
            return list;
        }

        public void CopyDB(string databasePath)
        {
            List<Instruments> source = GetAll();
            foreach (Instruments data in source)
            {
                if (data.Id.ToString().Contains("0000-0000"))
                {
                    continue;
                }
                
                bool ok = DBInsert(data, databasePath, false);
                nf.AddToINFO($@"Copy Instrument:{data.Instrument}->{ok}");
            }
        }

        public bool DBInsert(Instruments datas)
        {
            return DBInsert(datas, this.DatabasePath, true);
        }
        public bool DBInsert(Instruments datas, string databasePath, bool newID)
        {
            string connectionStr = databasePath;
            try
            {
                using (var db = new LiteDatabase(connectionStr))
                {
                    // Get customer collection
                    var notes = db.GetCollection<Instruments>(AttributesSchema);

                    notes.EnsureIndex(x => x.Instrument);
                    notes.EnsureIndex(x => x.Stamp);

                    // Insert (Id will be auto-incremented) if id == Guid.empty
                    if(newID) datas.Id = Guid.NewGuid();
                    BsonValue bv = notes.Insert(datas);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }

        public bool DBDelete(Instruments datas)
        {
            string connectionStr = DatabasePath;
            try
            {
                using (var db = new LiteDatabase(connectionStr))
                {
                    // Get customer collection
                    var notes = db.GetCollection<Instruments>(AttributesSchema);

                    notes.Delete(datas.Id);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }

        public bool DBUpdate(Notes datas)
        {
            var lf = Application.StartupPath;
            string connectionStr = DatabasePath;
            using (var db = new LiteDatabase(connectionStr))
            {
                var notes = db.GetCollection<Notes>(AttributesSchema);
                notes.EnsureIndex(x => x.SongName);
                notes.EnsureIndex(x => x.Stamp);
                notes.Update(datas);
                foreach (var imagePath in datas.SongFiles)
                {
                    FileStream stream = new FileStream($@"{imagePath.FilesName}", FileMode.Open, FileAccess.ReadWrite);
                    db.FileStorage.Upload(imagePath.FilesID, $@"{imagePath.FilesName}", stream);
                    stream.Close();
                }
                return true;
            }
        }

        public static object GetDynamicSortProperty(object item, string propName)
        {
            //Use reflection to get order type
            return item.GetType().GetProperty(propName).GetValue(item, null);
        }
        public static List<T> Sort_List<T>(string sortDirection, string sortExpression, List<T> data)
        {
            List<T> data_sorted = new List<T>();
            if (sortDirection == "Ascending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) ascending
                               select n).ToList();
            }
            else if (sortDirection == "Descending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) descending
                               select n).ToList();

            }
            return data_sorted;
        }
        public LiteFileInfo<string> GetImage(string guid)
        {
            string connectionStr = DatabasePath;
            using (var db = new LiteDatabase(connectionStr))
            {
                ActMemoryStream = new MemoryStream();
                var files = db.FileStorage.Download(guid, ActMemoryStream);
                return files;
            }
        }
    }
    class DBVariantsClass : DBBasicClass
    {
        string AttributesSchema = "variantsdata";
        public List<Variants> GetByID(Guid key)
        {
            var list = new List<Variants>();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<Variants>(AttributesSchema);
                foreach (Variants _id in col.Find(x => x.Id == key))
                {
                    list.Add(_id);
                }
            }
            return list;
        }
        public List<Variants> GetAll()
        {
            var list = new List<Variants>();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<Variants>(AttributesSchema);
                foreach (Variants _id in col.FindAll())
                {
                    list.Add(_id);
                }
            }
            return list;
        }

        public Variants GetFirst(string key)
        {
            var list = new Variants();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<Variants>(AttributesSchema);
                if (string.IsNullOrEmpty(key))
                {
                    foreach (Variants _id in col.FindAll())
                    {
                        list = _id;
                    }
                }
                else
                {
                    foreach (Variants _id in col.Find(x => x.Variant == key))
                    {
                        list = _id;
                    }
                }
            }
            return list;
        }


        public void CopyDB(string databasePath)
        {
            List<Variants> source = GetAll();
            foreach (Variants data in source)
            {
                if (data.Id.ToString().Contains("0000-0000"))
                {
                    continue;
                }
                bool ok = DBInsert(data, databasePath, false);
                nf.AddToINFO($@"Copy Varianten:{data.Variant}->{ok}");
            }
        }

        public bool DBInsert(Variants datas)
        {
            return DBInsert(datas, this.DatabasePath, true);
        }

        public bool DBInsert(Variants datas, string databasePath, bool newID)
        {
            string connectionStr = databasePath;
            try
            {
                using (var db = new LiteDatabase(connectionStr))
                {
                    // Get customer collection
                    var notes = db.GetCollection<Variants>(AttributesSchema);

                    notes.EnsureIndex(x => x.Variant);
                    notes.EnsureIndex(x => x.Stamp);

                    if(newID) datas.Id = Guid.NewGuid();
                    BsonValue bv = notes.Insert(datas);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                nf.AddToERROR($@"Insert variant {datas.Variant} {ex.Message}");
            }
            return false;
        }

        public bool DBDelete(Variants datas)
        {
            string connectionStr = DatabasePath;
            try
            {
                using (var db = new LiteDatabase(connectionStr))
                {
                    // Get customer collection
                    var notes = db.GetCollection<Variants>(AttributesSchema);

                    notes.Delete(datas.Id);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                nf.AddToERROR($@"Delete variant {datas.Variant} {ex.Message}");
            }
            return false;
        }

        public bool DBUpdate(Variants datas)
        {
            var lf = Application.StartupPath;
            string connectionStr = DatabasePath;
            using (var db = new LiteDatabase(connectionStr))
            {
                var notes = db.GetCollection<Variants>(AttributesSchema);
                notes.EnsureIndex(x => x.Variant);
                notes.EnsureIndex(x => x.Stamp);
                try
                {
                    notes.Update(datas);
                    return true;
                }
                catch(Exception ex)
                {
                    nf.AddToERROR($@"Update variant {datas.Variant} {ex.Message}");
                }
                return false;
            }
        }
        public static object GetDynamicSortProperty(object item, string propName)
        {
            //Use reflection to get order type
            return item.GetType().GetProperty(propName).GetValue(item, null);
        }
        public static List<T> Sort_List<T>(string sortDirection, string sortExpression, List<T> data)
        {
            List<T> data_sorted = new List<T>();
            if (sortDirection == "Ascending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) ascending
                               select n).ToList();
            }
            else if (sortDirection == "Descending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) descending
                               select n).ToList();

            }
            return data_sorted;
        }
    }

    class DBGroupsClass : DBBasicClass
    {
        string AttributesSchema = "groupdata";
        public List<Groups> GetByID(Guid key)
        {
            var list = new List<Groups>();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<Groups>(AttributesSchema);
                foreach (Groups _id in col.Find(x => x.Id == key))
                {
                    list.Add(_id);
                }
            }
            return list;
        }
        public List<Groups> GetAll()
        {
            var list = new List<Groups>();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<Groups>(AttributesSchema);
                foreach (Groups _id in col.FindAll())
                {
                    list.Add(_id);
                }
            }
            return list;
        }

        public Groups GetFirst(string key)
        {
            var list = new Groups();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<Groups>(AttributesSchema);
                if (string.IsNullOrEmpty(key))
                {
                    foreach (Groups _id in col.FindAll())
                    {
                        list = _id;
                    }
                }
                else
                {
                    foreach (Groups _id in col.Find(x => x.Group == key))
                    {
                        list = _id;
                    }
                }
            }
            return list;
        }


        public void CopyDB(string databasePath)
        {
            List<Groups> source = GetAll();
            foreach (Groups data in source)
            {
                if (data.Id.ToString().Contains("0000-0000"))
                {
                    continue;
                }
                bool ok = DBInsert(data, databasePath, false);
                nf.AddToINFO($@"Copy Varianten:{data.Group}->{ok}");
            }
        }

        public bool DBInsert(Groups datas)
        {
            return DBInsert(datas, this.DatabasePath, true);
        }

        public bool DBInsert(Groups datas, string databasePath, bool newID)
        {
            string connectionStr = databasePath;
            try
            {
                using (var db = new LiteDatabase(connectionStr))
                {
                    // Get customer collection
                    var notes = db.GetCollection<Groups>(AttributesSchema);

                    notes.EnsureIndex(x => x.Group);
                    notes.EnsureIndex(x => x.Stamp);

                    if (newID) datas.Id = Guid.NewGuid();
                    BsonValue bv = notes.Insert(datas);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                nf.AddToERROR($@"Insert variant {datas.Group} {ex.Message}");
            }
            return false;
        }

        public bool DBDelete(Groups datas)
        {
            string connectionStr = DatabasePath;
            try
            {
                using (var db = new LiteDatabase(connectionStr))
                {
                    // Get customer collection
                    var notes = db.GetCollection<Groups>(AttributesSchema);

                    notes.Delete(datas.Id);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                nf.AddToERROR($@"Delete variant {datas.Group} {ex.Message}");
            }
            return false;
        }

        public bool DBUpdate(Groups datas)
        {
            var lf = Application.StartupPath;
            string connectionStr = DatabasePath;
            using (var db = new LiteDatabase(connectionStr))
            {
                var notes = db.GetCollection<Groups>(AttributesSchema);
                notes.EnsureIndex(x => x.Group);
                notes.EnsureIndex(x => x.Stamp);
                try
                {
                    notes.Update(datas);
                    return true;
                }
                catch (Exception ex)
                {
                    nf.AddToERROR($@"Update variant {datas.Group} {ex.Message}");
                }
                return false;
            }
        }
        public static object GetDynamicSortProperty(object item, string propName)
        {
            //Use reflection to get order type
            return item.GetType().GetProperty(propName).GetValue(item, null);
        }
        public static List<T> Sort_List<T>(string sortDirection, string sortExpression, List<T> data)
        {
            List<T> data_sorted = new List<T>();
            if (sortDirection == "Ascending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) ascending
                               select n).ToList();
            }
            else if (sortDirection == "Descending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) descending
                               select n).ToList();

            }
            return data_sorted;
        }
    }
    class DBOriginClass : DBBasicClass
    {
        string AttributesSchema = "originsdata";
        public List<Origins> GetByID(Guid key)
        {
            var list = new List<Origins>();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<Origins>(AttributesSchema);
                foreach (Origins _id in col.Find(x => x.Id == key))
                {
                    list.Add(_id);
                }
            }
            return list;
        }
        public List<Origins> GetAll()
        {
            var list = new List<Origins>();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<Origins>(AttributesSchema);
                foreach (Origins _id in col.FindAll())
                {
                    list.Add(_id);
                }
            }
            return list;
        }

        public Origins GetFirst(string key)
        {
            var list = new Origins();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<Origins>(AttributesSchema);
                if (string.IsNullOrEmpty(key))
                {
                    foreach (Origins _id in col.FindAll())
                    {
                        list = _id;
                    }
                }
                else
                {
                    foreach (Origins _id in col.Find(x => x.Origin == key))
                    {
                        list = _id;
                    }
                }
            }
            return list;
        }

        public void CopyDB(string databasePath)
        {
            List<Origins> source = GetAll();
            foreach (Origins data in source)
            {
                if (data.Id.ToString().Contains("0000-0000"))
                {
                    continue;
                }
                bool ok = DBInsert(data, databasePath, false);
                nf.AddToINFO($@"Copy Herkunft:{data.Origin}->{ok}");
            }
        }


        public bool DBInsert(Origins datas)
        {
            return DBInsert(datas, this.DatabasePath, true);
        }
        public bool DBInsert(Origins datas, string databasePath, bool newID)
        {
            string connectionStr = databasePath;
            try
            {
                using (var db = new LiteDatabase(connectionStr))
                {
                    // Get customer collection
                    var notes = db.GetCollection<Origins>(AttributesSchema);

                    notes.EnsureIndex(x => x.Origin);
                    notes.EnsureIndex(x => x.Stamp);

                    
                    if(newID) datas.Id = Guid.NewGuid();
                    BsonValue bv = notes.Insert(datas);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                nf.AddToERROR($@"Insert origin {datas.Origin} {ex.Message}");
            }
            return false;
        }

        public bool DBDelete(Origins datas)
        {
            string connectionStr = DatabasePath;
            try
            {
                using (var db = new LiteDatabase(connectionStr))
                {
                    // Get customer collection
                    var notes = db.GetCollection<Origins>(AttributesSchema);

                    notes.Delete(datas.Id);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                nf.AddToERROR($@"Delete origin {datas.Origin} {ex.Message}");
            }
            return false;
        }

        public bool DBUpdate(Origins datas)
        {
            var lf = Application.StartupPath;
            string connectionStr = DatabasePath;
            using (var db = new LiteDatabase(connectionStr))
            {
                var notes = db.GetCollection<Origins>(AttributesSchema);
                notes.EnsureIndex(x => x.Origin);
                notes.EnsureIndex(x => x.Stamp);
                try
                {
                    notes.Update(datas);
                }
                catch(Exception ex)
                {
                    nf.AddToERROR($@"Update origin {datas.Origin} {ex.Message}");
                }
                return true;
            }
        }

        public static object GetDynamicSortProperty(object item, string propName)
        {
            //Use reflection to get order type
            return item.GetType().GetProperty(propName).GetValue(item, null);
        }
        public static List<T> Sort_List<T>(string sortDirection, string sortExpression, List<T> data)
        {
            List<T> data_sorted = new List<T>();
            if (sortDirection == "Ascending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) ascending
                               select n).ToList();
            }
            else if (sortDirection == "Descending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) descending
                               select n).ToList();

            }
            return data_sorted;
        }
    }
    class DBInterpretsClass : DBBasicClass
    {
        string AttributesSchema = "interpretsdata";
        public List<Interprets> GetByID(Guid key)
        {
            var list = new List<Interprets>();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<Interprets>(AttributesSchema);
                foreach (Interprets _id in col.Find(x => x.Id == key))
                {
                    list.Add(_id);
                }
            }
            return list;
        }
        public List<Interprets> GetAll()
        {
            var list = new List<Interprets>();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<Interprets>(AttributesSchema);
                foreach (Interprets _id in col.FindAll())
                {
                    list.Add(_id);
                }
            }
            return list;
        }

        public Interprets GetFirst(string key)
        {
            var list = new Interprets();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<Interprets>(AttributesSchema);
                if (string.IsNullOrEmpty(key))
                {
                    foreach (Interprets _id in col.FindAll())
                    {
                        list = _id;
                    }
                }
                else
                {
                    foreach (Interprets _id in col.Find(x => x.Interpret == key))
                    {
                        list = _id;
                    }
                }
            }
            return list;
        }


        public void CopyDB(string databasePath)
        {
            List<Interprets> source = GetAll();
            foreach (Interprets data in source)
            {
                if (data.Id.ToString().Contains("0000-0000"))
                {
                    continue;
                }
                bool ok = DBInsert(data, databasePath, false);
                nf.AddToINFO($@"Copy Interpret:{data.Interpret}->{ok}");
            }
        }


        public bool DBInsert(Interprets datas)
        {
            return DBInsert(datas, this.DatabasePath, true);
        }
        public bool DBInsert(Interprets datas, string databasePath, bool newID)
        {
            string connectionStr = databasePath;
            try
            {
                using (var db = new LiteDatabase(connectionStr))
                {
                    // Get customer collection
                    var notes = db.GetCollection<Interprets>(AttributesSchema);

                    notes.EnsureIndex(x => x.Interpret);
                    notes.EnsureIndex(x => x.Stamp);

                    datas.Id = Guid.NewGuid();
                    BsonValue bv = notes.Insert(datas);
                }
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                nf.AddToERROR($@"Insert interpret {datas.Interpret} {ex.Message}");
            }
            return false;
        }

        public bool DBDelete(Interprets datas)
        {
            string connectionStr = DatabasePath;
            try
            {
                using (var db = new LiteDatabase(connectionStr))
                {
                    // Get customer collection
                    var notes = db.GetCollection<Interprets>(AttributesSchema);
                    notes.Delete(datas.Id);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                nf.AddToERROR($@"Delete interpret {datas.Interpret} {ex.Message}");
            }
            return false;
        }

        public bool DBUpdate(Interprets datas)
        {
            var lf = Application.StartupPath;
            string connectionStr = DatabasePath;
            using (var db = new LiteDatabase(connectionStr))
            {
                var notes = db.GetCollection<Interprets>(AttributesSchema);
                notes.EnsureIndex(x => x.Interpret);
                notes.EnsureIndex(x => x.Stamp);
                try
                {
                    notes.Update(datas);
                }
                catch (Exception ex)
                {
                    nf.AddToERROR($@"Update interpret {datas.Interpret} {ex.Message}");
                }
                return true;
            }
        }
        public static object GetDynamicSortProperty(object item, string propName)
        {
            //Use reflection to get order type
            return item.GetType().GetProperty(propName).GetValue(item, null);
        }
        public static List<T> Sort_List<T>(string sortDirection, string sortExpression, List<T> data)
        {
            List<T> data_sorted = new List<T>();
            if (sortDirection == "Ascending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) ascending
                               select n).ToList();
            }
            else if (sortDirection == "Descending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) descending
                               select n).ToList();

            }
            return data_sorted;
        }
    }
}
