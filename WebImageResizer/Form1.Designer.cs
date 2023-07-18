namespace WebImageResizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setPNG = new System.Windows.Forms.RadioButton();
            this.setJPG = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.scaleSaveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uploadFolderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uploadFileButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fileQuality = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.keepRatio = new System.Windows.Forms.CheckBox();
            this.orientation = new System.Windows.Forms.CheckBox();
            this.otherRes = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.yRes = new System.Windows.Forms.TextBox();
            this.xRes = new System.Windows.Forms.TextBox();
            this.highRes = new System.Windows.Forms.RadioButton();
            this.mediumRes = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.smallRes = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.filesLoad = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.filesPath = new System.Windows.Forms.Label();
            this.filesCount = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.openFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.switchBox = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.setOpacity = new System.Windows.Forms.ComboBox();
            this.setWatermark = new System.Windows.Forms.CheckBox();
            this.viewPhoto = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.uploadWatermark = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.watermarkPictureBox = new System.Windows.Forms.PictureBox();
            this.lewygor = new System.Windows.Forms.RadioButton();
            this.prawygor = new System.Windows.Forms.RadioButton();
            this.lewydol = new System.Windows.Forms.RadioButton();
            this.prawydol = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.waterLabel = new System.Windows.Forms.Label();
            this.openWatermark = new System.Windows.Forms.OpenFileDialog();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.loadingPanel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watermarkPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.setPNG);
            this.groupBox1.Controls.Add(this.setJPG);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.scaleSaveButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.uploadFolderButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.uploadFileButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plik";
            // 
            // setPNG
            // 
            this.setPNG.AutoSize = true;
            this.setPNG.Location = new System.Drawing.Point(69, 42);
            this.setPNG.Name = "setPNG";
            this.setPNG.Size = new System.Drawing.Size(48, 17);
            this.setPNG.TabIndex = 10;
            this.setPNG.Text = "PNG";
            this.setPNG.UseVisualStyleBackColor = true;
            // 
            // setJPG
            // 
            this.setJPG.AutoSize = true;
            this.setJPG.Checked = true;
            this.setJPG.Location = new System.Drawing.Point(10, 42);
            this.setJPG.Name = "setJPG";
            this.setJPG.Size = new System.Drawing.Size(45, 17);
            this.setJPG.TabIndex = 9;
            this.setJPG.TabStop = true;
            this.setJPG.Text = "JPG";
            this.setJPG.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(6, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "TYP PLIKU";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(3, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "ZAPISZ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(3, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "WCZYTAJ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Zmień rozmiar i zapisz plik(i)";
            // 
            // scaleSaveButton
            // 
            this.scaleSaveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scaleSaveButton.BackgroundImage")));
            this.scaleSaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scaleSaveButton.Location = new System.Drawing.Point(6, 179);
            this.scaleSaveButton.Name = "scaleSaveButton";
            this.scaleSaveButton.Size = new System.Drawing.Size(32, 33);
            this.scaleSaveButton.TabIndex = 4;
            this.scaleSaveButton.UseVisualStyleBackColor = true;
            this.scaleSaveButton.Click += new System.EventHandler(this.scaleSaveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wczytaj folder";
            // 
            // uploadFolderButton
            // 
            this.uploadFolderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uploadFolderButton.BackgroundImage")));
            this.uploadFolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uploadFolderButton.Location = new System.Drawing.Point(6, 125);
            this.uploadFolderButton.Name = "uploadFolderButton";
            this.uploadFolderButton.Size = new System.Drawing.Size(32, 33);
            this.uploadFolderButton.TabIndex = 2;
            this.uploadFolderButton.UseVisualStyleBackColor = true;
            this.uploadFolderButton.Click += new System.EventHandler(this.uploadFolderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wczytaj plik";
            // 
            // uploadFileButton
            // 
            this.uploadFileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uploadFileButton.BackgroundImage")));
            this.uploadFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uploadFileButton.Location = new System.Drawing.Point(6, 88);
            this.uploadFileButton.Name = "uploadFileButton";
            this.uploadFileButton.Size = new System.Drawing.Size(32, 33);
            this.uploadFileButton.TabIndex = 0;
            this.uploadFileButton.UseVisualStyleBackColor = true;
            this.uploadFileButton.Click += new System.EventHandler(this.uploadFileButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(8, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "JAKOŚĆ PLIKU:";
            // 
            // fileQuality
            // 
            this.fileQuality.FormattingEnabled = true;
            this.fileQuality.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.fileQuality.Location = new System.Drawing.Point(11, 210);
            this.fileQuality.Name = "fileQuality";
            this.fileQuality.Size = new System.Drawing.Size(60, 21);
            this.fileQuality.TabIndex = 4;
            this.fileQuality.Text = "50";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.keepRatio);
            this.groupBox2.Controls.Add(this.fileQuality);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.orientation);
            this.groupBox2.Controls.Add(this.otherRes);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.yRes);
            this.groupBox2.Controls.Add(this.xRes);
            this.groupBox2.Controls.Add(this.highRes);
            this.groupBox2.Controls.Add(this.mediumRes);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.smallRes);
            this.groupBox2.Location = new System.Drawing.Point(230, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 239);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ustawienia";
            // 
            // keepRatio
            // 
            this.keepRatio.AutoSize = true;
            this.keepRatio.Location = new System.Drawing.Point(11, 173);
            this.keepRatio.Name = "keepRatio";
            this.keepRatio.Size = new System.Drawing.Size(118, 17);
            this.keepRatio.TabIndex = 11;
            this.keepRatio.Text = "zachowaj proporcje";
            this.keepRatio.UseVisualStyleBackColor = true;
            // 
            // orientation
            // 
            this.orientation.AutoSize = true;
            this.orientation.Location = new System.Drawing.Point(11, 104);
            this.orientation.Name = "orientation";
            this.orientation.Size = new System.Drawing.Size(101, 17);
            this.orientation.TabIndex = 10;
            this.orientation.Text = "zdjęcie w pionie";
            this.orientation.UseVisualStyleBackColor = true;
            // 
            // otherRes
            // 
            this.otherRes.AutoSize = true;
            this.otherRes.Location = new System.Drawing.Point(11, 127);
            this.otherRes.Name = "otherRes";
            this.otherRes.Size = new System.Drawing.Size(100, 17);
            this.otherRes.TabIndex = 9;
            this.otherRes.Text = "niestandardowa";
            this.otherRes.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "x";
            // 
            // yRes
            // 
            this.yRes.Location = new System.Drawing.Point(93, 147);
            this.yRes.Name = "yRes";
            this.yRes.Size = new System.Drawing.Size(33, 20);
            this.yRes.TabIndex = 6;
            this.yRes.Click += new System.EventHandler(this.yRes_Click);
            // 
            // xRes
            // 
            this.xRes.Location = new System.Drawing.Point(38, 147);
            this.xRes.Name = "xRes";
            this.xRes.Size = new System.Drawing.Size(33, 20);
            this.xRes.TabIndex = 5;
            this.xRes.Click += new System.EventHandler(this.xRes_Click);
            // 
            // highRes
            // 
            this.highRes.AutoSize = true;
            this.highRes.Location = new System.Drawing.Point(10, 81);
            this.highRes.Name = "highRes";
            this.highRes.Size = new System.Drawing.Size(72, 17);
            this.highRes.TabIndex = 3;
            this.highRes.Text = "1024x768";
            this.highRes.UseVisualStyleBackColor = true;
            // 
            // mediumRes
            // 
            this.mediumRes.AutoSize = true;
            this.mediumRes.Location = new System.Drawing.Point(10, 59);
            this.mediumRes.Name = "mediumRes";
            this.mediumRes.Size = new System.Drawing.Size(66, 17);
            this.mediumRes.TabIndex = 2;
            this.mediumRes.Text = "800x600";
            this.mediumRes.UseVisualStyleBackColor = true;
            this.mediumRes.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "ROZDZIELCZOŚĆ:";
            // 
            // smallRes
            // 
            this.smallRes.AutoSize = true;
            this.smallRes.Checked = true;
            this.smallRes.Location = new System.Drawing.Point(10, 35);
            this.smallRes.Name = "smallRes";
            this.smallRes.Size = new System.Drawing.Size(66, 17);
            this.smallRes.TabIndex = 0;
            this.smallRes.TabStop = true;
            this.smallRes.Text = "640x480";
            this.smallRes.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.filesLoad);
            this.groupBox3.Location = new System.Drawing.Point(398, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 237);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista wczytanych plików";
            // 
            // filesLoad
            // 
            this.filesLoad.FormattingEnabled = true;
            this.filesLoad.Location = new System.Drawing.Point(7, 20);
            this.filesLoad.Name = "filesLoad";
            this.filesLoad.Size = new System.Drawing.Size(232, 212);
            this.filesLoad.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Ścieżka wczytanych plików/pliku: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Liczba wczytanych plików:";
            // 
            // filesPath
            // 
            this.filesPath.AutoSize = true;
            this.filesPath.Location = new System.Drawing.Point(179, 262);
            this.filesPath.Name = "filesPath";
            this.filesPath.Size = new System.Drawing.Size(28, 13);
            this.filesPath.TabIndex = 5;
            this.filesPath.Text = "brak";
            // 
            // filesCount
            // 
            this.filesCount.AutoSize = true;
            this.filesCount.Location = new System.Drawing.Point(147, 280);
            this.filesCount.Name = "filesCount";
            this.filesCount.Size = new System.Drawing.Size(13, 13);
            this.filesCount.TabIndex = 6;
            this.filesCount.Text = "0";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label12.Location = new System.Drawing.Point(13, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 12);
            this.label12.TabIndex = 7;
            this.label12.Text = "Expedict";
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpButton.Location = new System.Drawing.Point(569, 253);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(68, 22);
            this.helpButton.TabIndex = 8;
            this.helpButton.Text = "POMOC";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(61, 299);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 9);
            this.label14.TabIndex = 9;
            this.label14.Text = "PROG";
            // 
            // loadingPanel
            // 
            this.loadingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadingPanel.Controls.Add(this.infoLabel);
            this.loadingPanel.Location = new System.Drawing.Point(149, 115);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(350, 66);
            this.loadingPanel.TabIndex = 10;
            this.loadingPanel.Visible = false;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel.Location = new System.Drawing.Point(11, 23);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(261, 20);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Zmiana rozdzielczości zdjęcia...";
            // 
            // switchBox
            // 
            this.switchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.switchBox.Location = new System.Drawing.Point(625, 1);
            this.switchBox.Name = "switchBox";
            this.switchBox.Size = new System.Drawing.Size(18, 18);
            this.switchBox.TabIndex = 11;
            this.switchBox.Text = ">";
            this.switchBox.UseVisualStyleBackColor = true;
            this.switchBox.Click += new System.EventHandler(this.switchBox_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.waterLabel);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.prawydol);
            this.groupBox4.Controls.Add(this.lewydol);
            this.groupBox4.Controls.Add(this.prawygor);
            this.groupBox4.Controls.Add(this.lewygor);
            this.groupBox4.Controls.Add(this.watermarkPictureBox);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.uploadWatermark);
            this.groupBox4.Controls.Add(this.setWatermark);
            this.groupBox4.Controls.Add(this.setOpacity);
            this.groupBox4.Location = new System.Drawing.Point(662, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 297);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Znak wodny";
            // 
            // setOpacity
            // 
            this.setOpacity.FormattingEnabled = true;
            this.setOpacity.Items.AddRange(new object[] {
            "100",
            "90",
            "80",
            "70",
            "60",
            "50",
            "40",
            "30",
            "20",
            "10"});
            this.setOpacity.Location = new System.Drawing.Point(6, 103);
            this.setOpacity.Name = "setOpacity";
            this.setOpacity.Size = new System.Drawing.Size(121, 21);
            this.setOpacity.TabIndex = 0;
            this.setOpacity.Text = "100";
            // 
            // setWatermark
            // 
            this.setWatermark.AutoSize = true;
            this.setWatermark.Location = new System.Drawing.Point(6, 20);
            this.setWatermark.Name = "setWatermark";
            this.setWatermark.Size = new System.Drawing.Size(121, 17);
            this.setWatermark.TabIndex = 1;
            this.setWatermark.Text = "Umieść znak wodny";
            this.setWatermark.UseVisualStyleBackColor = true;
            this.setWatermark.CheckedChanged += new System.EventHandler(this.setWatermark_CheckedChanged);
            // 
            // viewPhoto
            // 
            this.viewPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.viewPhoto.Location = new System.Drawing.Point(501, 253);
            this.viewPhoto.Name = "viewPhoto";
            this.viewPhoto.Size = new System.Drawing.Size(62, 22);
            this.viewPhoto.TabIndex = 13;
            this.viewPhoto.Text = "Podgląd";
            this.viewPhoto.UseVisualStyleBackColor = true;
            this.viewPhoto.Click += new System.EventHandler(this.viewPhoto_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(44, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Wczytaj plik znaku wodnego";
            // 
            // uploadWatermark
            // 
            this.uploadWatermark.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uploadWatermark.BackgroundImage")));
            this.uploadWatermark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uploadWatermark.Location = new System.Drawing.Point(6, 43);
            this.uploadWatermark.Name = "uploadWatermark";
            this.uploadWatermark.Size = new System.Drawing.Size(32, 33);
            this.uploadWatermark.TabIndex = 2;
            this.uploadWatermark.UseVisualStyleBackColor = true;
            this.uploadWatermark.Click += new System.EventHandler(this.uploadWatermark_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(6, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 12);
            this.label16.TabIndex = 4;
            this.label16.Text = "PRZEŹROCZYSTOŚĆ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(6, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 12);
            this.label17.TabIndex = 5;
            this.label17.Text = "POŁOŻENIE";
            // 
            // watermarkPictureBox
            // 
            this.watermarkPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("watermarkPictureBox.Image")));
            this.watermarkPictureBox.Location = new System.Drawing.Point(38, 161);
            this.watermarkPictureBox.Name = "watermarkPictureBox";
            this.watermarkPictureBox.Size = new System.Drawing.Size(168, 112);
            this.watermarkPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.watermarkPictureBox.TabIndex = 6;
            this.watermarkPictureBox.TabStop = false;
            this.watermarkPictureBox.WaitOnLoad = true;
            // 
            // lewygor
            // 
            this.lewygor.AutoSize = true;
            this.lewygor.BackColor = System.Drawing.Color.Transparent;
            this.lewygor.Location = new System.Drawing.Point(47, 171);
            this.lewygor.Name = "lewygor";
            this.lewygor.Size = new System.Drawing.Size(14, 13);
            this.lewygor.TabIndex = 7;
            this.lewygor.UseVisualStyleBackColor = false;
            // 
            // prawygor
            // 
            this.prawygor.AutoSize = true;
            this.prawygor.Location = new System.Drawing.Point(182, 172);
            this.prawygor.Name = "prawygor";
            this.prawygor.Size = new System.Drawing.Size(14, 13);
            this.prawygor.TabIndex = 8;
            this.prawygor.UseVisualStyleBackColor = true;
            // 
            // lewydol
            // 
            this.lewydol.AutoSize = true;
            this.lewydol.BackColor = System.Drawing.Color.Transparent;
            this.lewydol.Checked = true;
            this.lewydol.Location = new System.Drawing.Point(47, 247);
            this.lewydol.Name = "lewydol";
            this.lewydol.Size = new System.Drawing.Size(14, 13);
            this.lewydol.TabIndex = 9;
            this.lewydol.TabStop = true;
            this.lewydol.UseVisualStyleBackColor = false;
            // 
            // prawydol
            // 
            this.prawydol.AutoSize = true;
            this.prawydol.Location = new System.Drawing.Point(182, 247);
            this.prawydol.Name = "prawydol";
            this.prawydol.Size = new System.Drawing.Size(14, 13);
            this.prawydol.TabIndex = 10;
            this.prawydol.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(2, 279);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Plik znaku wodnego:";
            // 
            // waterLabel
            // 
            this.waterLabel.AutoSize = true;
            this.waterLabel.Location = new System.Drawing.Point(114, 279);
            this.waterLabel.Name = "waterLabel";
            this.waterLabel.Size = new System.Drawing.Size(28, 13);
            this.waterLabel.TabIndex = 12;
            this.waterLabel.Text = "brak";
            // 
            // openWatermark
            // 
            this.openWatermark.FileName = "openFileDialog1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label19.Location = new System.Drawing.Point(88, 300);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 14;
            this.label19.Text = "2016";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 321);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.viewPhoto);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.switchBox);
            this.Controls.Add(this.loadingPanel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.filesCount);
            this.Controls.Add(this.filesPath);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Image Resizer 1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.loadingPanel.ResumeLayout(false);
            this.loadingPanel.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watermarkPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button uploadFileButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox fileQuality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uploadFolderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button scaleSaveButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox orientation;
        private System.Windows.Forms.RadioButton otherRes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox xRes;
        private System.Windows.Forms.RadioButton highRes;
        private System.Windows.Forms.RadioButton mediumRes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton smallRes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox filesLoad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label filesPath;
        private System.Windows.Forms.Label filesCount;
        public System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.FolderBrowserDialog openFolder;
        private System.Windows.Forms.FolderBrowserDialog saveFolder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox yRes;
        private System.Windows.Forms.CheckBox keepRatio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton setPNG;
        private System.Windows.Forms.RadioButton setJPG;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button switchBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox setOpacity;
        private System.Windows.Forms.CheckBox setWatermark;
        private System.Windows.Forms.Button viewPhoto;
        private System.Windows.Forms.PictureBox watermarkPictureBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button uploadWatermark;
        private System.Windows.Forms.RadioButton prawydol;
        private System.Windows.Forms.RadioButton lewydol;
        private System.Windows.Forms.RadioButton prawygor;
        private System.Windows.Forms.RadioButton lewygor;
        private System.Windows.Forms.Label waterLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.OpenFileDialog openWatermark;
        private System.Windows.Forms.Label label19;
    }
}

