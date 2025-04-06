namespace ArtGalleryManagementSystem
{
    partial class ArtGalleryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtGalleryForm));
            this.tbcArtGallery = new System.Windows.Forms.TabControl();
            this.tpArtGallery = new System.Windows.Forms.TabPage();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.gbArtDetails = new System.Windows.Forms.GroupBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.lblDetails = new System.Windows.Forms.Label();
            this.gbArtInfo = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.ImgArt = new System.Windows.Forms.PictureBox();
            this.dtpCreationDate = new System.Windows.Forms.DateTimePicker();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtArtistLName = new System.Windows.Forms.TextBox();
            this.txtArtTitle = new System.Windows.Forms.TextBox();
            this.txtArtistFName = new System.Windows.Forms.TextBox();
            this.txtArtCode = new System.Windows.Forms.TextBox();
            this.gbLabels = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.ckbStaus = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblArtistFName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblArtTitle = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblArtistLName = new System.Windows.Forms.Label();
            this.lblArtCode = new System.Windows.Forms.Label();
            this.gbFooter = new System.Windows.Forms.GroupBox();
            this.lblFooter = new System.Windows.Forms.Label();
            this.gbHeader = new System.Windows.Forms.GroupBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tpArtList = new System.Windows.Forms.TabPage();
            this.dgvArtList = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExhibitionTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExhibitionDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcArtGallery.SuspendLayout();
            this.tpArtGallery.SuspendLayout();
            this.gbArtDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.gbArtInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgArt)).BeginInit();
            this.gbLabels.SuspendLayout();
            this.gbFooter.SuspendLayout();
            this.gbHeader.SuspendLayout();
            this.tpArtList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtList)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcArtGallery
            // 
            this.tbcArtGallery.Controls.Add(this.tpArtGallery);
            this.tbcArtGallery.Controls.Add(this.tpArtList);
            this.tbcArtGallery.Location = new System.Drawing.Point(1, -1);
            this.tbcArtGallery.Name = "tbcArtGallery";
            this.tbcArtGallery.SelectedIndex = 0;
            this.tbcArtGallery.Size = new System.Drawing.Size(989, 468);
            this.tbcArtGallery.TabIndex = 0;
            // 
            // tpArtGallery
            // 
            this.tpArtGallery.Controls.Add(this.gbArtDetails);
            this.tpArtGallery.Controls.Add(this.gbArtInfo);
            this.tpArtGallery.Controls.Add(this.gbFooter);
            this.tpArtGallery.Controls.Add(this.gbHeader);
            this.tpArtGallery.Location = new System.Drawing.Point(4, 25);
            this.tpArtGallery.Name = "tpArtGallery";
            this.tpArtGallery.Padding = new System.Windows.Forms.Padding(3);
            this.tpArtGallery.Size = new System.Drawing.Size(981, 439);
            this.tpArtGallery.TabIndex = 0;
            this.tpArtGallery.Text = "Art Gallery";
            this.tpArtGallery.UseVisualStyleBackColor = true;
            // 
            // btnShowReport
            // 
            this.btnShowReport.BackColor = System.Drawing.Color.Teal;
            this.btnShowReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReport.ForeColor = System.Drawing.Color.White;
            this.btnShowReport.Location = new System.Drawing.Point(0, 248);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(368, 50);
            this.btnShowReport.TabIndex = 7;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.UseVisualStyleBackColor = false;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // gbArtDetails
            // 
            this.gbArtDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbArtDetails.Controls.Add(this.btnShowReport);
            this.gbArtDetails.Controls.Add(this.dgvDetails);
            this.gbArtDetails.Controls.Add(this.lblDetails);
            this.gbArtDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbArtDetails.Location = new System.Drawing.Point(609, 96);
            this.gbArtDetails.Name = "gbArtDetails";
            this.gbArtDetails.Size = new System.Drawing.Size(369, 300);
            this.gbArtDetails.TabIndex = 1;
            this.gbArtDetails.TabStop = false;
            this.gbArtDetails.Text = "Art Details";
            // 
            // dgvDetails
            // 
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetailsId,
            this.ExhibitionTitle,
            this.ExhibitionDuration});
            this.dgvDetails.Location = new System.Drawing.Point(0, 44);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.Size = new System.Drawing.Size(369, 198);
            this.dgvDetails.TabIndex = 2;
            this.dgvDetails.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDetails_UserDeletingRow);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.Black;
            this.lblDetails.Location = new System.Drawing.Point(5, 20);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(286, 16);
            this.lblDetails.TabIndex = 1;
            this.lblDetails.Text = "Please insert details information here . . . . . . . . . .";
            // 
            // gbArtInfo
            // 
            this.gbArtInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbArtInfo.Controls.Add(this.btnCancel);
            this.gbArtInfo.Controls.Add(this.btnUpload);
            this.gbArtInfo.Controls.Add(this.ImgArt);
            this.gbArtInfo.Controls.Add(this.dtpCreationDate);
            this.gbArtInfo.Controls.Add(this.rbtnFemale);
            this.gbArtInfo.Controls.Add(this.rbtnMale);
            this.gbArtInfo.Controls.Add(this.cmbGenre);
            this.gbArtInfo.Controls.Add(this.txtPrice);
            this.gbArtInfo.Controls.Add(this.txtArtistLName);
            this.gbArtInfo.Controls.Add(this.txtArtTitle);
            this.gbArtInfo.Controls.Add(this.txtArtistFName);
            this.gbArtInfo.Controls.Add(this.txtArtCode);
            this.gbArtInfo.Controls.Add(this.gbLabels);
            this.gbArtInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbArtInfo.Location = new System.Drawing.Point(5, 96);
            this.gbArtInfo.Name = "gbArtInfo";
            this.gbArtInfo.Size = new System.Drawing.Size(600, 300);
            this.gbArtInfo.TabIndex = 1;
            this.gbArtInfo.TabStop = false;
            this.gbArtInfo.Text = "Art Info";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(375, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Gray;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(375, 160);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(200, 40);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // ImgArt
            // 
            this.ImgArt.BackColor = System.Drawing.Color.White;
            this.ImgArt.Location = new System.Drawing.Point(375, 30);
            this.ImgArt.Name = "ImgArt";
            this.ImgArt.Size = new System.Drawing.Size(200, 120);
            this.ImgArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgArt.TabIndex = 5;
            this.ImgArt.TabStop = false;
            // 
            // dtpCreationDate
            // 
            this.dtpCreationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCreationDate.Location = new System.Drawing.Point(175, 180);
            this.dtpCreationDate.Name = "dtpCreationDate";
            this.dtpCreationDate.Size = new System.Drawing.Size(150, 22);
            this.dtpCreationDate.TabIndex = 4;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbtnFemale.Location = new System.Drawing.Point(250, 155);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(77, 20);
            this.rbtnFemale.TabIndex = 3;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = false;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbtnMale.Location = new System.Drawing.Point(175, 155);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(59, 20);
            this.rbtnMale.TabIndex = 3;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = false;
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(175, 80);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(150, 24);
            this.cmbGenre.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(175, 205);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(150, 22);
            this.txtPrice.TabIndex = 1;
            // 
            // txtArtistLName
            // 
            this.txtArtistLName.Location = new System.Drawing.Point(175, 130);
            this.txtArtistLName.Name = "txtArtistLName";
            this.txtArtistLName.Size = new System.Drawing.Size(150, 22);
            this.txtArtistLName.TabIndex = 1;
            // 
            // txtArtTitle
            // 
            this.txtArtTitle.Location = new System.Drawing.Point(175, 55);
            this.txtArtTitle.Name = "txtArtTitle";
            this.txtArtTitle.Size = new System.Drawing.Size(150, 22);
            this.txtArtTitle.TabIndex = 1;
            // 
            // txtArtistFName
            // 
            this.txtArtistFName.Location = new System.Drawing.Point(175, 105);
            this.txtArtistFName.Name = "txtArtistFName";
            this.txtArtistFName.Size = new System.Drawing.Size(150, 22);
            this.txtArtistFName.TabIndex = 1;
            // 
            // txtArtCode
            // 
            this.txtArtCode.Location = new System.Drawing.Point(175, 30);
            this.txtArtCode.Name = "txtArtCode";
            this.txtArtCode.Size = new System.Drawing.Size(150, 22);
            this.txtArtCode.TabIndex = 1;
            // 
            // gbLabels
            // 
            this.gbLabels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbLabels.Controls.Add(this.btnReset);
            this.gbLabels.Controls.Add(this.ckbStaus);
            this.gbLabels.Controls.Add(this.lblStatus);
            this.gbLabels.Controls.Add(this.btnSave);
            this.gbLabels.Controls.Add(this.btnDelete);
            this.gbLabels.Controls.Add(this.lblPrice);
            this.gbLabels.Controls.Add(this.lblArtistFName);
            this.gbLabels.Controls.Add(this.lblGender);
            this.gbLabels.Controls.Add(this.lblArtTitle);
            this.gbLabels.Controls.Add(this.lblCreationDate);
            this.gbLabels.Controls.Add(this.lblGenre);
            this.gbLabels.Controls.Add(this.lblArtistLName);
            this.gbLabels.Controls.Add(this.lblArtCode);
            this.gbLabels.Location = new System.Drawing.Point(5, 20);
            this.gbLabels.Name = "gbLabels";
            this.gbLabels.Size = new System.Drawing.Size(350, 275);
            this.gbLabels.TabIndex = 0;
            this.gbLabels.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Teal;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(240, 240);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 36);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ckbStaus
            // 
            this.ckbStaus.AutoSize = true;
            this.ckbStaus.Location = new System.Drawing.Point(170, 210);
            this.ckbStaus.Name = "ckbStaus";
            this.ckbStaus.Size = new System.Drawing.Size(120, 20);
            this.ckbStaus.TabIndex = 1;
            this.ckbStaus.Text = "Is Available ?";
            this.ckbStaus.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(10, 210);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 16);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Sell Staus :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(10, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(125, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 36);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(10, 185);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(51, 16);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price :";
            // 
            // lblArtistFName
            // 
            this.lblArtistFName.AutoSize = true;
            this.lblArtistFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistFName.Location = new System.Drawing.Point(10, 85);
            this.lblArtistFName.Name = "lblArtistFName";
            this.lblArtistFName.Size = new System.Drawing.Size(129, 16);
            this.lblArtistFName.TabIndex = 0;
            this.lblArtistFName.Text = "Artist First Name :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(10, 135);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(66, 16);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender :";
            // 
            // lblArtTitle
            // 
            this.lblArtTitle.AutoSize = true;
            this.lblArtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtTitle.Location = new System.Drawing.Point(10, 35);
            this.lblArtTitle.Name = "lblArtTitle";
            this.lblArtTitle.Size = new System.Drawing.Size(69, 16);
            this.lblArtTitle.TabIndex = 0;
            this.lblArtTitle.Text = "Art Title :";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreationDate.Location = new System.Drawing.Point(10, 160);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(110, 16);
            this.lblCreationDate.TabIndex = 0;
            this.lblCreationDate.Text = "Creation Date :";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(10, 60);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(80, 16);
            this.lblGenre.TabIndex = 0;
            this.lblGenre.Text = "Art Genre :";
            // 
            // lblArtistLName
            // 
            this.lblArtistLName.AutoSize = true;
            this.lblArtistLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistLName.Location = new System.Drawing.Point(10, 110);
            this.lblArtistLName.Name = "lblArtistLName";
            this.lblArtistLName.Size = new System.Drawing.Size(128, 16);
            this.lblArtistLName.TabIndex = 0;
            this.lblArtistLName.Text = "Artist Last Name :";
            // 
            // lblArtCode
            // 
            this.lblArtCode.AutoSize = true;
            this.lblArtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtCode.Location = new System.Drawing.Point(10, 10);
            this.lblArtCode.Name = "lblArtCode";
            this.lblArtCode.Size = new System.Drawing.Size(75, 16);
            this.lblArtCode.TabIndex = 0;
            this.lblArtCode.Text = "Art Code :";
            // 
            // gbFooter
            // 
            this.gbFooter.BackColor = System.Drawing.Color.Gray;
            this.gbFooter.Controls.Add(this.lblFooter);
            this.gbFooter.Location = new System.Drawing.Point(0, 400);
            this.gbFooter.Name = "gbFooter";
            this.gbFooter.Size = new System.Drawing.Size(979, 40);
            this.gbFooter.TabIndex = 0;
            this.gbFooter.TabStop = false;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(350, 15);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(252, 16);
            this.lblFooter.TabIndex = 1;
            this.lblFooter.Text = "Powered By - Md. Abdul Latif Siyam";
            // 
            // gbHeader
            // 
            this.gbHeader.BackColor = System.Drawing.Color.Gray;
            this.gbHeader.Controls.Add(this.lblLogo);
            this.gbHeader.Controls.Add(this.groupBox2);
            this.gbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbHeader.Location = new System.Drawing.Point(2, 2);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(979, 90);
            this.gbHeader.TabIndex = 0;
            this.gbHeader.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblLogo.Location = new System.Drawing.Point(404, 60);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(143, 16);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Management Sytem";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Location = new System.Drawing.Point(444, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(60, 40);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // tpArtList
            // 
            this.tpArtList.Controls.Add(this.dgvArtList);
            this.tpArtList.Location = new System.Drawing.Point(4, 25);
            this.tpArtList.Name = "tpArtList";
            this.tpArtList.Padding = new System.Windows.Forms.Padding(3);
            this.tpArtList.Size = new System.Drawing.Size(981, 439);
            this.tpArtList.TabIndex = 1;
            this.tpArtList.Text = "Art List";
            this.tpArtList.UseVisualStyleBackColor = true;
            // 
            // dgvArtList
            // 
            this.dgvArtList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtList.Location = new System.Drawing.Point(3, 3);
            this.dgvArtList.Name = "dgvArtList";
            this.dgvArtList.Size = new System.Drawing.Size(981, 439);
            this.dgvArtList.TabIndex = 0;
            this.dgvArtList.DoubleClick += new System.EventHandler(this.dgvArtList_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DetailsId
            // 
            this.DetailsId.HeaderText = "Details Id";
            this.DetailsId.Name = "DetailsId";
            this.DetailsId.Visible = false;
            // 
            // ExhibitionTitle
            // 
            this.ExhibitionTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExhibitionTitle.HeaderText = "Exhibition Title";
            this.ExhibitionTitle.Name = "ExhibitionTitle";
            // 
            // ExhibitionDuration
            // 
            this.ExhibitionDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExhibitionDuration.HeaderText = "Days of Duration";
            this.ExhibitionDuration.Name = "ExhibitionDuration";
            // 
            // ArtGalleryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 466);
            this.Controls.Add(this.tbcArtGallery);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ArtGalleryForm";
            this.Text = "Art Gallery Management System";
            this.Load += new System.EventHandler(this.ArtGalleryForm_Load);
            this.tbcArtGallery.ResumeLayout(false);
            this.tpArtGallery.ResumeLayout(false);
            this.gbArtDetails.ResumeLayout(false);
            this.gbArtDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.gbArtInfo.ResumeLayout(false);
            this.gbArtInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgArt)).EndInit();
            this.gbLabels.ResumeLayout(false);
            this.gbLabels.PerformLayout();
            this.gbFooter.ResumeLayout(false);
            this.gbFooter.PerformLayout();
            this.gbHeader.ResumeLayout(false);
            this.gbHeader.PerformLayout();
            this.tpArtList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcArtGallery;
        private System.Windows.Forms.TabPage tpArtGallery;
        private System.Windows.Forms.TabPage tpArtList;
        private System.Windows.Forms.GroupBox gbHeader;
        private System.Windows.Forms.GroupBox gbFooter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblLogo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbArtInfo;
        private System.Windows.Forms.GroupBox gbArtDetails;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtArtistLName;
        private System.Windows.Forms.TextBox txtArtTitle;
        private System.Windows.Forms.TextBox txtArtistFName;
        private System.Windows.Forms.TextBox txtArtCode;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.DateTimePicker dtpCreationDate;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox ImgArt;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.GroupBox gbLabels;
        private System.Windows.Forms.CheckBox ckbStaus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblArtistFName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblArtTitle;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblArtistLName;
        private System.Windows.Forms.Label lblArtCode;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DataGridView dgvArtList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExhibitionTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExhibitionDuration;
    }
}

