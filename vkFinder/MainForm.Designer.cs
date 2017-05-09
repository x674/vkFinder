﻿namespace vkFinder
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.selfName = new System.Windows.Forms.Label();
            this.selfGroups = new System.Windows.Forms.Label();
            this.groupScreenName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minAge = new System.Windows.Forms.NumericUpDown();
            this.maxAge = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.minIntGroups = new System.Windows.Forms.NumericUpDown();
            this.usersCount = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.userProfileUrl = new System.Windows.Forms.LinkLabel();
            this.userPhoto = new System.Windows.Forms.PictureBox();
            this.userListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorization = new System.Windows.Forms.Button();
            this.userProcesser = new System.ComponentModel.BackgroundWorker();
            this.userCheckingProgress = new System.Windows.Forms.ProgressBar();
            this.sexLabel = new System.Windows.Forms.Label();
            this.sexMale = new System.Windows.Forms.RadioButton();
            this.sexFemale = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.minAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minIntGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(12, 270);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(122, 46);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // selfName
            // 
            this.selfName.AutoSize = true;
            this.selfName.Location = new System.Drawing.Point(12, 9);
            this.selfName.Name = "selfName";
            this.selfName.Size = new System.Drawing.Size(29, 13);
            this.selfName.TabIndex = 1;
            this.selfName.Text = "Имя";
            // 
            // selfGroups
            // 
            this.selfGroups.AutoSize = true;
            this.selfGroups.Location = new System.Drawing.Point(12, 34);
            this.selfGroups.Name = "selfGroups";
            this.selfGroups.Size = new System.Drawing.Size(100, 13);
            this.selfGroups.TabIndex = 2;
            this.selfGroups.Text = "Количество групп:";
            // 
            // groupScreenName
            // 
            this.groupScreenName.Location = new System.Drawing.Point(71, 60);
            this.groupScreenName.Name = "groupScreenName";
            this.groupScreenName.Size = new System.Drawing.Size(86, 20);
            this.groupScreenName.TabIndex = 3;
            this.groupScreenName.Text = "ru2ch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Искать в";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Мин. возраст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Макс. возраст";
            // 
            // minAge
            // 
            this.minAge.Cursor = System.Windows.Forms.Cursors.Default;
            this.minAge.Location = new System.Drawing.Point(108, 86);
            this.minAge.Name = "minAge";
            this.minAge.Size = new System.Drawing.Size(63, 20);
            this.minAge.TabIndex = 7;
            this.minAge.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // maxAge
            // 
            this.maxAge.Location = new System.Drawing.Point(108, 112);
            this.maxAge.Name = "maxAge";
            this.maxAge.Size = new System.Drawing.Size(63, 20);
            this.maxAge.TabIndex = 8;
            this.maxAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Мин. кол-во общ. групп";
            // 
            // minIntGroups
            // 
            this.minIntGroups.Location = new System.Drawing.Point(15, 151);
            this.minIntGroups.Name = "minIntGroups";
            this.minIntGroups.Size = new System.Drawing.Size(65, 20);
            this.minIntGroups.TabIndex = 11;
            this.minIntGroups.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // usersCount
            // 
            this.usersCount.AutoSize = true;
            this.usersCount.Location = new System.Drawing.Point(274, 9);
            this.usersCount.Name = "usersCount";
            this.usersCount.Size = new System.Drawing.Size(57, 13);
            this.usersCount.TabIndex = 12;
            this.usersCount.Text = "Найдено: ";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(605, 135);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(0, 13);
            this.userName.TabIndex = 13;
            // 
            // userProfileUrl
            // 
            this.userProfileUrl.AutoSize = true;
            this.userProfileUrl.Location = new System.Drawing.Point(605, 151);
            this.userProfileUrl.Name = "userProfileUrl";
            this.userProfileUrl.Size = new System.Drawing.Size(0, 13);
            this.userProfileUrl.TabIndex = 14;
            this.userProfileUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // userPhoto
            // 
            this.userPhoto.Location = new System.Drawing.Point(608, 25);
            this.userPhoto.Name = "userPhoto";
            this.userPhoto.Size = new System.Drawing.Size(100, 100);
            this.userPhoto.TabIndex = 15;
            this.userPhoto.TabStop = false;
            this.userPhoto.WaitOnLoad = true;
            // 
            // userListView
            // 
            this.userListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.userListView.Location = new System.Drawing.Point(277, 34);
            this.userListView.MultiSelect = false;
            this.userListView.Name = "userListView";
            this.userListView.Size = new System.Drawing.Size(310, 299);
            this.userListView.TabIndex = 16;
            this.userListView.UseCompatibleStateImageBehavior = false;
            this.userListView.View = System.Windows.Forms.View.Details;
            this.userListView.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ссылка";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Фото";
            this.columnHeader3.Width = 70;
            // 
            // authorization
            // 
            this.authorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorization.Location = new System.Drawing.Point(12, 322);
            this.authorization.Name = "authorization";
            this.authorization.Size = new System.Drawing.Size(122, 46);
            this.authorization.TabIndex = 17;
            this.authorization.Text = "Авторизация";
            this.authorization.UseVisualStyleBackColor = true;
            this.authorization.Click += new System.EventHandler(this.Button2_Click);
            // 
            // userProcesser
            // 
            this.userProcesser.WorkerReportsProgress = true;
            this.userProcesser.WorkerSupportsCancellation = true;
            this.userProcesser.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.userProcesser.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
            this.userProcesser.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // userCheckingProgress
            // 
            this.userCheckingProgress.Location = new System.Drawing.Point(277, 339);
            this.userCheckingProgress.Name = "userCheckingProgress";
            this.userCheckingProgress.Size = new System.Drawing.Size(310, 29);
            this.userCheckingProgress.TabIndex = 18;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(12, 177);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(27, 13);
            this.sexLabel.TabIndex = 19;
            this.sexLabel.Text = "Пол";
            // 
            // sexMale
            // 
            this.sexMale.AutoSize = true;
            this.sexMale.Location = new System.Drawing.Point(49, 177);
            this.sexMale.Name = "sexMale";
            this.sexMale.Size = new System.Drawing.Size(63, 17);
            this.sexMale.TabIndex = 21;
            this.sexMale.Text = "Парень";
            this.sexMale.UseVisualStyleBackColor = true;
            // 
            // sexFemale
            // 
            this.sexFemale.AutoSize = true;
            this.sexFemale.Checked = true;
            this.sexFemale.Location = new System.Drawing.Point(49, 200);
            this.sexFemale.Name = "sexFemale";
            this.sexFemale.Size = new System.Drawing.Size(71, 17);
            this.sexFemale.TabIndex = 22;
            this.sexFemale.TabStop = true;
            this.sexFemale.Text = "Девушка";
            this.sexFemale.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 380);
            this.Controls.Add(this.sexFemale);
            this.Controls.Add(this.sexMale);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.authorization);
            this.Controls.Add(this.userListView);
            this.Controls.Add(this.userPhoto);
            this.Controls.Add(this.userProfileUrl);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.usersCount);
            this.Controls.Add(this.minIntGroups);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maxAge);
            this.Controls.Add(this.minAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupScreenName);
            this.Controls.Add(this.selfGroups);
            this.Controls.Add(this.selfName);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.userCheckingProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "FormName";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minIntGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label selfName;
        private System.Windows.Forms.Label selfGroups;
        private System.Windows.Forms.TextBox groupScreenName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown minAge;
        private System.Windows.Forms.NumericUpDown maxAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown minIntGroups;
        private System.Windows.Forms.Label usersCount;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.LinkLabel userProfileUrl;
        private System.Windows.Forms.PictureBox userPhoto;
        private System.Windows.Forms.ListView userListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button authorization;
        private System.ComponentModel.BackgroundWorker userProcesser;
        private System.Windows.Forms.ProgressBar userCheckingProgress;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.RadioButton sexMale;
        private System.Windows.Forms.RadioButton sexFemale;
    }
}
