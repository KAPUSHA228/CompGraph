namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap image1, image2;

        public Form1()
        {
            InitializeComponent();
        }


        private void îòêðûòüToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            // ofd.Filter = "Image files | *.png *.bmp *.jpg | All files (*.*) | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image1 = image2 = new Bitmap(ofd.FileName);
                pictureBox1.Image = image1;
                pictureBox1.Refresh();
            }
        }

        private void èíâåðñèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilter filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
            /* Bitmap resultImage = filter.processImage(image2, backgroundWorker1);
              pictureBox1.Image = resultImage;
              pictureBox1.Refresh();*/
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

        private void ðàçìûòèåToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ÿðêîñòüToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ðåçêîñòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Sharpness();
            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}
