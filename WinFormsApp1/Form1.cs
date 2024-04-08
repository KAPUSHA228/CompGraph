namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap image1, image2;

        public Form1()
        {
            InitializeComponent();
        }


        private void îòêğûòüToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Çàãğóçèòü êàğòèíêó";
            // ofd.Filter = "Image files | *.png *.bmp *.jpg | All files (*.*) | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image1 = image2 = new Bitmap(ofd.FileName);
                pictureBox1.Image = image1;
                pictureBox1.Refresh();
            }
        }
        private void ñîõğàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Ñîõğàíèòü êàğòèíêó";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try { image1.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg); }
                catch { MessageBox.Show("Gavno"); }
            }
        }

        private void èíâåğñèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilter filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(image1, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
                image1 = newImage;

        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image1;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void ğàçìûòèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ãàóññàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ÷áToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ñåïèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void áèíêàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Binarization();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ÿğêîñòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Brightness();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            image1 = image2;
            pictureBox1.Image = image1;
            pictureBox1.Refresh();
        }

        private void ñîáåëÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ğåçêîñòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Sharpness();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void òèñíåíèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new EmbossingFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ìåäèàííûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MedianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void âîëíû1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Wave1();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void âîëíû2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Wave2();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîâîğîòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Rotate();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void øàğğàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharrFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïğşèòòàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new PruitFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void äâèæåíèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MotionBlur();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ñäâèãToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Move();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ñòåêëîToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GlassFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}
