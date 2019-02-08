namespace Lab5b
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorGroupBox = new System.Windows.Forms.GroupBox();
            this.episodeLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.seriesLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.actorLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.doctorsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.companionsGroupBox = new System.Windows.Forms.GroupBox();
            this.companionsListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.doctorGroupBox.SuspendLayout();
            this.companionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuStripItem,
            this.exitMenuStripItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openMenuStripItem
            // 
            this.openMenuStripItem.Name = "openMenuStripItem";
            this.openMenuStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuStripItem.Size = new System.Drawing.Size(180, 22);
            this.openMenuStripItem.Text = "Open...";
            this.openMenuStripItem.Click += new System.EventHandler(this.openMenuStripItem_Click);
            // 
            // exitMenuStripItem
            // 
            this.exitMenuStripItem.Name = "exitMenuStripItem";
            this.exitMenuStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitMenuStripItem.Size = new System.Drawing.Size(180, 22);
            this.exitMenuStripItem.Text = "Exit";
            this.exitMenuStripItem.Click += new System.EventHandler(this.exitMenuStripItem_Click);
            // 
            // doctorGroupBox
            // 
            this.doctorGroupBox.Controls.Add(this.episodeLabel);
            this.doctorGroupBox.Controls.Add(this.ageLabel);
            this.doctorGroupBox.Controls.Add(this.seriesLabel);
            this.doctorGroupBox.Controls.Add(this.label5);
            this.doctorGroupBox.Controls.Add(this.actorLabel);
            this.doctorGroupBox.Controls.Add(this.label4);
            this.doctorGroupBox.Controls.Add(this.yearLabel);
            this.doctorGroupBox.Controls.Add(this.label3);
            this.doctorGroupBox.Controls.Add(this.label2);
            this.doctorGroupBox.Controls.Add(this.doctorsComboBox);
            this.doctorGroupBox.Controls.Add(this.label1);
            this.doctorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorGroupBox.Location = new System.Drawing.Point(12, 51);
            this.doctorGroupBox.Name = "doctorGroupBox";
            this.doctorGroupBox.Size = new System.Drawing.Size(311, 212);
            this.doctorGroupBox.TabIndex = 1;
            this.doctorGroupBox.TabStop = false;
            this.doctorGroupBox.Text = "The Doctor";
            // 
            // episodeLabel
            // 
            this.episodeLabel.BackColor = System.Drawing.Color.White;
            this.episodeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.episodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodeLabel.Location = new System.Drawing.Point(24, 171);
            this.episodeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.episodeLabel.Name = "episodeLabel";
            this.episodeLabel.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.episodeLabel.Size = new System.Drawing.Size(269, 26);
            this.episodeLabel.TabIndex = 5;
            this.episodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ageLabel
            // 
            this.ageLabel.BackColor = System.Drawing.Color.White;
            this.ageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(242, 110);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Padding = new System.Windows.Forms.Padding(3);
            this.ageLabel.Size = new System.Drawing.Size(51, 26);
            this.ageLabel.TabIndex = 8;
            this.ageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // seriesLabel
            // 
            this.seriesLabel.BackColor = System.Drawing.Color.White;
            this.seriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriesLabel.Location = new System.Drawing.Point(88, 110);
            this.seriesLabel.Margin = new System.Windows.Forms.Padding(3);
            this.seriesLabel.Name = "seriesLabel";
            this.seriesLabel.Padding = new System.Windows.Forms.Padding(3);
            this.seriesLabel.Size = new System.Drawing.Size(37, 26);
            this.seriesLabel.TabIndex = 7;
            this.seriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "First full episode:";
            // 
            // actorLabel
            // 
            this.actorLabel.BackColor = System.Drawing.Color.White;
            this.actorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actorLabel.Location = new System.Drawing.Point(109, 73);
            this.actorLabel.Margin = new System.Windows.Forms.Padding(3);
            this.actorLabel.Name = "actorLabel";
            this.actorLabel.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.actorLabel.Size = new System.Drawing.Size(184, 29);
            this.actorLabel.TabIndex = 6;
            this.actorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Age at start:";
            // 
            // yearLabel
            // 
            this.yearLabel.BackColor = System.Drawing.Color.White;
            this.yearLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(229, 38);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(3);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Padding = new System.Windows.Forms.Padding(3);
            this.yearLabel.Size = new System.Drawing.Size(64, 29);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Series:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Played by:";
            // 
            // doctorsComboBox
            // 
            this.doctorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorsComboBox.FormattingEnabled = true;
            this.doctorsComboBox.Location = new System.Drawing.Point(109, 39);
            this.doctorsComboBox.Name = "doctorsComboBox";
            this.doctorsComboBox.Size = new System.Drawing.Size(96, 28);
            this.doctorsComboBox.TabIndex = 1;
            this.doctorsComboBox.SelectedIndexChanged += new System.EventHandler(this.doctorsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor";
            // 
            // companionsGroupBox
            // 
            this.companionsGroupBox.Controls.Add(this.companionsListBox);
            this.companionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companionsGroupBox.Location = new System.Drawing.Point(340, 51);
            this.companionsGroupBox.Name = "companionsGroupBox";
            this.companionsGroupBox.Size = new System.Drawing.Size(417, 401);
            this.companionsGroupBox.TabIndex = 2;
            this.companionsGroupBox.TabStop = false;
            this.companionsGroupBox.Text = "Companions and their first episode with this Doctor:";
            // 
            // companionsListBox
            // 
            this.companionsListBox.FormattingEnabled = true;
            this.companionsListBox.ItemHeight = 20;
            this.companionsListBox.Location = new System.Drawing.Point(17, 26);
            this.companionsListBox.Name = "companionsListBox";
            this.companionsListBox.Size = new System.Drawing.Size(384, 364);
            this.companionsListBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab5b.Properties.Resources.tardis;
            this.pictureBox1.Location = new System.Drawing.Point(12, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.companionsGroupBox);
            this.Controls.Add(this.doctorGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Doctor and Companions";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.doctorGroupBox.ResumeLayout(false);
            this.doctorGroupBox.PerformLayout();
            this.companionsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuStripItem;
        private System.Windows.Forms.GroupBox doctorGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox doctorsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox companionsGroupBox;
        private System.Windows.Forms.ListBox companionsListBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label episodeLabel;
        private System.Windows.Forms.Label actorLabel;
        private System.Windows.Forms.Label seriesLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

