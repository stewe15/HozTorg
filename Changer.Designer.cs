namespace WindowsFormsApp1
{
    partial class Changer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Changer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fieldForRedaction = new System.Windows.Forms.ComboBox();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldRedaction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.idEditText = new System.Windows.Forms.TextBox();
            this.SortLabelMenu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.redactionButton = new System.Windows.Forms.Button();
            this.backReductButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.crest = new System.Windows.Forms.Button();
            this.minimalizeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.logofinish;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 88);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AddBox
            // 
            this.AddBox.BackColor = System.Drawing.Color.Transparent;
            this.AddBox.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_коробка_96;
            this.AddBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddBox.Location = new System.Drawing.Point(428, 176);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(150, 150);
            this.AddBox.TabIndex = 44;
            this.AddBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_карандаш_128;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(533, 281);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // fieldForRedaction
            // 
            this.fieldForRedaction.DisplayMember = "ID";
            this.fieldForRedaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldForRedaction.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldForRedaction.FormattingEnabled = true;
            this.fieldForRedaction.Location = new System.Drawing.Point(96, 285);
            this.fieldForRedaction.Name = "fieldForRedaction";
            this.fieldForRedaction.Size = new System.Drawing.Size(246, 42);
            this.fieldForRedaction.TabIndex = 46;
            this.fieldForRedaction.SelectedIndexChanged += new System.EventHandler(this.fieldForRedaction_SelectedIndexChanged);
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataSource = typeof(WindowsFormsApp1.Form1.Tovar);
            // 
            // fieldRedaction
            // 
            this.fieldRedaction.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldRedaction.Location = new System.Drawing.Point(96, 384);
            this.fieldRedaction.Multiline = true;
            this.fieldRedaction.Name = "fieldRedaction";
            this.fieldRedaction.Size = new System.Drawing.Size(374, 42);
            this.fieldRedaction.TabIndex = 47;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 36);
            this.label1.TabIndex = 50;
            this.label1.Text = "Поле редактирования";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID.ForeColor = System.Drawing.Color.Gainsboro;
            this.ID.Location = new System.Drawing.Point(91, 151);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(173, 29);
            this.ID.TabIndex = 52;
            this.ID.Text = "Введите ID товара";
            // 
            // idEditText
            // 
            this.idEditText.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idEditText.Location = new System.Drawing.Point(95, 183);
            this.idEditText.Multiline = true;
            this.idEditText.Name = "idEditText";
            this.idEditText.Size = new System.Drawing.Size(247, 39);
            this.idEditText.TabIndex = 51;
            this.idEditText.TextChanged += new System.EventHandler(this.idEditText_TextChanged);
            // 
            // SortLabelMenu
            // 
            this.SortLabelMenu.AutoSize = true;
            this.SortLabelMenu.BackColor = System.Drawing.Color.Transparent;
            this.SortLabelMenu.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortLabelMenu.ForeColor = System.Drawing.Color.White;
            this.SortLabelMenu.Location = new System.Drawing.Point(202, 45);
            this.SortLabelMenu.Name = "SortLabelMenu";
            this.SortLabelMenu.Size = new System.Drawing.Size(305, 50);
            this.SortLabelMenu.TabIndex = 53;
            this.SortLabelMenu.Text = "Редактирование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 36);
            this.label2.TabIndex = 54;
            this.label2.Text = "Выберите поле для редакции";
            // 
            // redactionButton
            // 
            this.redactionButton.BackColor = System.Drawing.Color.Black;
            this.redactionButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.e77a3f8f5809d2fbda84d9164262903b;
            this.redactionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redactionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redactionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.redactionButton.FlatAppearance.BorderSize = 0;
            this.redactionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.redactionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.redactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.redactionButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redactionButton.ForeColor = System.Drawing.Color.White;
            this.redactionButton.Location = new System.Drawing.Point(471, 384);
            this.redactionButton.Name = "redactionButton";
            this.redactionButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.redactionButton.Size = new System.Drawing.Size(182, 42);
            this.redactionButton.TabIndex = 56;
            this.redactionButton.Text = "Редактировать";
            this.redactionButton.UseVisualStyleBackColor = false;
            this.redactionButton.Click += new System.EventHandler(this.redactionButton_Click);
            // 
            // backReductButton
            // 
            this.backReductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(138)))), ((int)(((byte)(15)))));
            this.backReductButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.e77a3f8f5809d2fbda84d9164262903b;
            this.backReductButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backReductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backReductButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.backReductButton.FlatAppearance.BorderSize = 0;
            this.backReductButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.backReductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.backReductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backReductButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backReductButton.ForeColor = System.Drawing.Color.White;
            this.backReductButton.Location = new System.Drawing.Point(276, 455);
            this.backReductButton.Name = "backReductButton";
            this.backReductButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.backReductButton.Size = new System.Drawing.Size(182, 53);
            this.backReductButton.TabIndex = 57;
            this.backReductButton.Text = "Назад";
            this.backReductButton.UseVisualStyleBackColor = false;
            this.backReductButton.Click += new System.EventHandler(this.backReductButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.crest);
            this.panel1.Controls.Add(this.minimalizeButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 25);
            this.panel1.TabIndex = 58;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(630, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 25);
            this.button2.TabIndex = 59;
            this.button2.Text = "−";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // crest
            // 
            this.crest.BackColor = System.Drawing.SystemColors.ControlText;
            this.crest.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.rightcrest2;
            this.crest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crest.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.crest.FlatAppearance.BorderSize = 0;
            this.crest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crest.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.crest.ForeColor = System.Drawing.Color.Red;
            this.crest.Location = new System.Drawing.Point(675, 0);
            this.crest.Name = "crest";
            this.crest.Size = new System.Drawing.Size(45, 25);
            this.crest.TabIndex = 59;
            this.crest.UseVisualStyleBackColor = false;
            this.crest.Click += new System.EventHandler(this.crest_Click_1);
            // 
            // minimalizeButton
            // 
            this.minimalizeButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.minimalizeButton.FlatAppearance.BorderSize = 0;
            this.minimalizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimalizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimalizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimalizeButton.ForeColor = System.Drawing.Color.Red;
            this.minimalizeButton.Location = new System.Drawing.Point(1190, 0);
            this.minimalizeButton.Name = "minimalizeButton";
            this.minimalizeButton.Size = new System.Drawing.Size(45, 25);
            this.minimalizeButton.TabIndex = 56;
            this.minimalizeButton.Text = "−";
            this.minimalizeButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.rightcrest2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1235, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 25);
            this.button1.TabIndex = 40;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Changer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fonosn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backReductButton);
            this.Controls.Add(this.redactionButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SortLabelMenu);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.idEditText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fieldRedaction);
            this.Controls.Add(this.fieldForRedaction);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Changer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOZTORG Редактирование";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Changer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Changer_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Changer_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox AddBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox fieldForRedaction;
        private System.Windows.Forms.TextBox fieldRedaction;
        public System.Windows.Forms.BindingSource tovarBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox idEditText;
        private System.Windows.Forms.Label SortLabelMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button redactionButton;
        private System.Windows.Forms.Button backReductButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimalizeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button crest;
        private System.Windows.Forms.Button button2;
    }
}