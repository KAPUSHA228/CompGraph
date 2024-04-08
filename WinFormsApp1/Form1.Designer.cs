namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            фильтрыToolStripMenuItem = new ToolStripMenuItem();
            точечныеToolStripMenuItem = new ToolStripMenuItem();
            инверсияToolStripMenuItem = new ToolStripMenuItem();
            чбToolStripMenuItem = new ToolStripMenuItem();
            сепияToolStripMenuItem = new ToolStripMenuItem();
            бинкаToolStripMenuItem = new ToolStripMenuItem();
            яркостьToolStripMenuItem = new ToolStripMenuItem();
            матричныеToolStripMenuItem = new ToolStripMenuItem();
            размытиеToolStripMenuItem = new ToolStripMenuItem();
            гауссаToolStripMenuItem = new ToolStripMenuItem();
            собеляToolStripMenuItem = new ToolStripMenuItem();
            резкостьToolStripMenuItem = new ToolStripMenuItem();
            тиснениеToolStripMenuItem = new ToolStripMenuItem();
            медианныйToolStripMenuItem = new ToolStripMenuItem();
            волны1ToolStripMenuItem = new ToolStripMenuItem();
            волны2ToolStripMenuItem = new ToolStripMenuItem();
            поворотToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            button2 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            шарраToolStripMenuItem = new ToolStripMenuItem();
            прюиттаToolStripMenuItem = new ToolStripMenuItem();
            движениеToolStripMenuItem = new ToolStripMenuItem();
            сдвигToolStripMenuItem = new ToolStripMenuItem();
            стеклоToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, фильтрыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(164, 26);
            открытьToolStripMenuItem.Text = "открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click_1;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(164, 26);
            сохранитьToolStripMenuItem.Text = "сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // фильтрыToolStripMenuItem
            // 
            фильтрыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { точечныеToolStripMenuItem, матричныеToolStripMenuItem });
            фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            фильтрыToolStripMenuItem.Size = new Size(85, 24);
            фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            точечныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { инверсияToolStripMenuItem, чбToolStripMenuItem, сепияToolStripMenuItem, бинкаToolStripMenuItem, яркостьToolStripMenuItem });
            точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            точечныеToolStripMenuItem.Size = new Size(224, 26);
            точечныеToolStripMenuItem.Text = "точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            инверсияToolStripMenuItem.Size = new Size(186, 26);
            инверсияToolStripMenuItem.Text = "инверсия";
            инверсияToolStripMenuItem.Click += инверсияToolStripMenuItem_Click;
            // 
            // чбToolStripMenuItem
            // 
            чбToolStripMenuItem.Name = "чбToolStripMenuItem";
            чбToolStripMenuItem.Size = new Size(186, 26);
            чбToolStripMenuItem.Text = "чёрно-белый";
            чбToolStripMenuItem.Click += чбToolStripMenuItem_Click;
            // 
            // сепияToolStripMenuItem
            // 
            сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            сепияToolStripMenuItem.Size = new Size(186, 26);
            сепияToolStripMenuItem.Text = "сепия";
            сепияToolStripMenuItem.Click += сепияToolStripMenuItem_Click;
            // 
            // бинкаToolStripMenuItem
            // 
            бинкаToolStripMenuItem.Name = "бинкаToolStripMenuItem";
            бинкаToolStripMenuItem.Size = new Size(186, 26);
            бинкаToolStripMenuItem.Text = "бинаризация";
            бинкаToolStripMenuItem.Click += бинкаToolStripMenuItem_Click;
            // 
            // яркостьToolStripMenuItem
            // 
            яркостьToolStripMenuItem.Name = "яркостьToolStripMenuItem";
            яркостьToolStripMenuItem.Size = new Size(186, 26);
            яркостьToolStripMenuItem.Text = "яркость";
            яркостьToolStripMenuItem.Click += яркостьToolStripMenuItem_Click;
            // 
            // матричныеToolStripMenuItem
            // 
            матричныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { размытиеToolStripMenuItem, гауссаToolStripMenuItem, собеляToolStripMenuItem, резкостьToolStripMenuItem, тиснениеToolStripMenuItem, медианныйToolStripMenuItem, волны1ToolStripMenuItem, волны2ToolStripMenuItem, поворотToolStripMenuItem, шарраToolStripMenuItem, прюиттаToolStripMenuItem, движениеToolStripMenuItem, сдвигToolStripMenuItem, стеклоToolStripMenuItem });
            матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            матричныеToolStripMenuItem.Size = new Size(224, 26);
            матричныеToolStripMenuItem.Text = "матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            размытиеToolStripMenuItem.Size = new Size(224, 26);
            размытиеToolStripMenuItem.Text = "размытие";
            размытиеToolStripMenuItem.Click += размытиеToolStripMenuItem_Click;
            // 
            // гауссаToolStripMenuItem
            // 
            гауссаToolStripMenuItem.Name = "гауссаToolStripMenuItem";
            гауссаToolStripMenuItem.Size = new Size(224, 26);
            гауссаToolStripMenuItem.Text = "Гаусса";
            гауссаToolStripMenuItem.Click += гауссаToolStripMenuItem_Click;
            // 
            // собеляToolStripMenuItem
            // 
            собеляToolStripMenuItem.Name = "собеляToolStripMenuItem";
            собеляToolStripMenuItem.Size = new Size(224, 26);
            собеляToolStripMenuItem.Text = "Собеля";
            собеляToolStripMenuItem.Click += собеляToolStripMenuItem_Click;
            // 
            // резкостьToolStripMenuItem
            // 
            резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            резкостьToolStripMenuItem.Size = new Size(224, 26);
            резкостьToolStripMenuItem.Text = "резкость";
            резкостьToolStripMenuItem.Click += резкостьToolStripMenuItem_Click;
            // 
            // тиснениеToolStripMenuItem
            // 
            тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
            тиснениеToolStripMenuItem.Size = new Size(224, 26);
            тиснениеToolStripMenuItem.Text = "тиснение";
            тиснениеToolStripMenuItem.Click += тиснениеToolStripMenuItem_Click;
            // 
            // медианныйToolStripMenuItem
            // 
            медианныйToolStripMenuItem.Name = "медианныйToolStripMenuItem";
            медианныйToolStripMenuItem.Size = new Size(224, 26);
            медианныйToolStripMenuItem.Text = "медианный";
            медианныйToolStripMenuItem.Click += медианныйToolStripMenuItem_Click;
            // 
            // волны1ToolStripMenuItem
            // 
            волны1ToolStripMenuItem.Name = "волны1ToolStripMenuItem";
            волны1ToolStripMenuItem.Size = new Size(224, 26);
            волны1ToolStripMenuItem.Text = "волны1";
            волны1ToolStripMenuItem.Click += волны1ToolStripMenuItem_Click;
            // 
            // волны2ToolStripMenuItem
            // 
            волны2ToolStripMenuItem.Name = "волны2ToolStripMenuItem";
            волны2ToolStripMenuItem.Size = new Size(224, 26);
            волны2ToolStripMenuItem.Text = "волны2";
            волны2ToolStripMenuItem.Click += волны2ToolStripMenuItem_Click;
            // 
            // поворотToolStripMenuItem
            // 
            поворотToolStripMenuItem.Name = "поворотToolStripMenuItem";
            поворотToolStripMenuItem.Size = new Size(224, 26);
            поворотToolStripMenuItem.Text = "поворот";
            поворотToolStripMenuItem.Click += поворотToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(0, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(635, 388);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Location = new Point(0, 421);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(676, 30);
            progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(681, 366);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.Location = new Point(663, 191);
            button2.Name = "button2";
            button2.Size = new Size(125, 129);
            button2.TabIndex = 4;
            button2.Text = "вернуть исходную картинку";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // шарраToolStripMenuItem
            // 
            шарраToolStripMenuItem.Name = "шарраToolStripMenuItem";
            шарраToolStripMenuItem.Size = new Size(224, 26);
            шарраToolStripMenuItem.Text = "Шарра";
            шарраToolStripMenuItem.Click += шарраToolStripMenuItem_Click;
            // 
            // прюиттаToolStripMenuItem
            // 
            прюиттаToolStripMenuItem.Name = "прюиттаToolStripMenuItem";
            прюиттаToolStripMenuItem.Size = new Size(224, 26);
            прюиттаToolStripMenuItem.Text = "Прюитта";
            прюиттаToolStripMenuItem.Click += прюиттаToolStripMenuItem_Click;
            // 
            // движениеToolStripMenuItem
            // 
            движениеToolStripMenuItem.Name = "движениеToolStripMenuItem";
            движениеToolStripMenuItem.Size = new Size(224, 26);
            движениеToolStripMenuItem.Text = "Движение";
            движениеToolStripMenuItem.Click += движениеToolStripMenuItem_Click;
            // 
            // сдвигToolStripMenuItem
            // 
            сдвигToolStripMenuItem.Name = "сдвигToolStripMenuItem";
            сдвигToolStripMenuItem.Size = new Size(224, 26);
            сдвигToolStripMenuItem.Text = "Сдвиг";
            сдвигToolStripMenuItem.Click += сдвигToolStripMenuItem_Click;
            // 
            // стеклоToolStripMenuItem
            // 
            стеклоToolStripMenuItem.Name = "стеклоToolStripMenuItem";
            стеклоToolStripMenuItem.Size = new Size(224, 26);
            стеклоToolStripMenuItem.Text = "Стекло";
            стеклоToolStripMenuItem.Click += стеклоToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem фильтрыToolStripMenuItem;
        private ToolStripMenuItem точечныеToolStripMenuItem;
        private ToolStripMenuItem матричныеToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem инверсияToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ProgressBar progressBar1;
        private Button button1;
        private ToolStripMenuItem размытиеToolStripMenuItem;
        private ToolStripMenuItem гауссаToolStripMenuItem;
        private ToolStripMenuItem чбToolStripMenuItem;
        private ToolStripMenuItem сепияToolStripMenuItem;
        private ToolStripMenuItem бинкаToolStripMenuItem;
        private ToolStripMenuItem яркостьToolStripMenuItem;
        private Button button2;
        private ToolStripMenuItem собеляToolStripMenuItem;
        private ToolStripMenuItem резкостьToolStripMenuItem;
        private ToolStripMenuItem тиснениеToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem медианныйToolStripMenuItem;
        private ToolStripMenuItem волны1ToolStripMenuItem;
        private ToolStripMenuItem волны2ToolStripMenuItem;
        private ToolStripMenuItem поворотToolStripMenuItem;
        private ToolStripMenuItem шарраToolStripMenuItem;
        private ToolStripMenuItem прюиттаToolStripMenuItem;
        private ToolStripMenuItem движениеToolStripMenuItem;
        private ToolStripMenuItem сдвигToolStripMenuItem;
        private ToolStripMenuItem стеклоToolStripMenuItem;
    }
}
