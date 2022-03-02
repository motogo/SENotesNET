using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SENotesNET
{
    public class PictureClass
    {
        public PictureBox picture = null;
        public int pcheight = 600;
        public PictureClass NewPicture(Control parent, string file)
        {
            PictureBox pc = new PictureBox();
            pc.Parent = parent;
            pc.Dock = DockStyle.None;
            pc.SizeMode = PictureBoxSizeMode.StretchImage;
            pc.Load(file);
            pcheight = pc.Height;
            picture = pc;
            ResizeToWidth();
            return this;
        }

        public PictureClass NewPicture(Control parent, Stream stream)
        {
            PictureBox pc = new PictureBox();
            pc.Parent = parent;
            pc.Dock = DockStyle.None;
            pc.SizeMode = PictureBoxSizeMode.StretchImage;
            if (stream.Length > 0)
            {
                pc.Image = Image.FromStream(stream);
            }
            else
            {
                pc.Image = SENotesNET.Properties.Resources.close_round_bl_x64;

            }
            pcheight = pc.Height;
            picture = pc;
            ResizeToWidth();
            return this;
        }

        int w = 45;

        public void Save(string filename)
        {
            picture.Image.Save(filename);
        }

        public void SetFact(int n)
        {
            w = n;
        }

        public void ReleasePicture()
        {
            picture.Image = null;
            picture.Invalidate();
            picture.Dispose();
        }

        public void RefreshPicture(PictureClass prev, int leftOffset)
        {
            if (prev != null)
                picture.Left = leftOffset + prev.picture.Left + prev.picture.Width + 4;
            else
                picture.Left = leftOffset;
            picture.Invalidate();
        }
        public void SetVisible(bool vis)
        {

            picture.Visible = vis;
            
        }

        public void ResizeToWidth()
        {
            picture.Width = (picture.Height / w) * 21;
        }
        public void ResizeToHeight()
        {
            picture.Height = (picture.Width / 21) * w;
        }
        public void ResizeNewHeight()
        {
            picture.Height = pcheight;
            picture.Width = (picture.Height / w) * 21;
        }
        public void SetNewHeight()
        {
            pcheight = picture.Height;
        }

        public void SetLeft(int left)
        {
            picture.Left = left;
        }
        public int Width
        {
            get { return picture.Width; }
            set { picture.Width = value; }
        }
        public int Left
        {
            get { return picture.Left; }
            set { picture.Left = value; }
        }
    }

    class PictureListClass
    {
        public List<PictureClass> pictures = new List<PictureClass>();
        int left = 0;
        int width = 700;
        Control Parent = null;
        public void AddNewPicture(Control parent, string filename)
        {
            var pcc = new PictureClass();
            this.Parent = parent;
            pcc.NewPicture(parent, filename);
            pcc.Width = width;
            pcc.SetLeft(left);
            pcc.ResizeToHeight();
            left += pcc.Width + 4;
            pictures.Add(pcc);
        }

        public void AddNewPicture(Control parent, MemoryStream stream)
        {
            var pcc = new PictureClass();
            this.Parent = parent;
            pcc.NewPicture(parent, stream);
            pcc.Width = width;
            pcc.SetLeft(left);
            pcc.ResizeToHeight();
            left += pcc.Width + 4;
            pictures.Add(pcc);
        }

        public void Resize1()
        {
            foreach (var pc in pictures)
            {
                pc.SetNewHeight();
                pc.ResizeToWidth();
            }
        }

        public void SetFact(int n)
        {
            foreach (var pc in pictures)
            {
                pc.SetFact(n);
            }
        }

        private void ResizeToWidth()
        {            
            foreach (var pc in pictures)
            {
                pc.ResizeToWidth();
            }
        }

        private void Release()
        {
            foreach (var pc in pictures)
            {
                pc.ReleasePicture();
            }
        }

        public void RefreshList(int start, int end)
        {
            PictureClass prev = null;
            int n = 0;
            int leftoffset = 0;
           
            if ((pictures.Count < 4)&&(pictures.Count > 0))
            {
                int wd = 0;
                foreach (var pc in pictures)
                {
                    wd += pc.Width;
                }
               
               leftoffset = (Parent.Width - wd) / 2;
                
            }

            foreach (var pc in pictures)
            {
                
                if ((n >= start) && (n <= end))
                {
                    if(n == start) pc.RefreshPicture(prev, leftoffset);
                    else pc.RefreshPicture(prev, 0);
                    pc.SetVisible(true);
                    prev = pc;
                }
                else
                {
                    pc.SetVisible(false);
                }
                n++;
            }
        }

        public int PicCount()
        {
            return pictures.Count;
        }

        public void IncreaseWidth(int n)
        {
            int nn = 0;

            foreach (var pc in pictures)
            {
                if (((pc.Width + n) > 0) && ((pc.Width + n) < Parent.Width))
                {
                    pc.Width += n;
                    pc.Left += n * nn++;
                    pc.ResizeToHeight();
                }
            }
        }

        public void ResizeToHeight()
        {
            foreach (var pc in pictures)
            {
                //if (((pc.Width + n) > 0) && ((pc.Width + n) < Parent.Width))
                {
                    pc.ResizeToHeight();
                }
            }
        }

        public void SetWidth(int n, int minWidth)
        {
            int nn = 0;
            foreach (var pc in pictures)
            {
                if ((pc.Width > 0) && (pc.Width < Parent.Width))
                {
                    pc.Width = n;
                    pc.Left = n * nn++;
                    pc.ResizeToHeight();
                }
            }
        }
    }


}
