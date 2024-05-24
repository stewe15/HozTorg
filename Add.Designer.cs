namespace WindowsFormsApp1
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.nametext = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.valuetext = new System.Windows.Forms.TextBox();
            this.value = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.Label();
            this.cashtext = new System.Windows.Forms.TextBox();
            this.massText = new System.Windows.Forms.TextBox();
            this.cash = new System.Windows.Forms.Label();
            this.mass = new System.Windows.Forms.Label();
            this.AddLabelMenu = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.AddBox = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Delprod = new System.Windows.Forms.Button();
            this.changeprod = new System.Windows.Forms.Button();
            this.materialBox = new System.Windows.Forms.ComboBox();
            this.crest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimalizeButton = new System.Windows.Forms.Button();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nametext
            // 
            this.nametext.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nametext.Location = new System.Drawing.Point(111, 194);
            this.nametext.Multiline = true;
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(336, 39);
            this.nametext.TabIndex = 7;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.Color.Gainsboro;
            this.name.Location = new System.Drawing.Point(105, 155);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(175, 36);
            this.name.TabIndex = 12;
            this.name.Text = "Наименование";
            // 
            // valuetext
            // 
            this.valuetext.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valuetext.Location = new System.Drawing.Point(111, 305);
            this.valuetext.Multiline = true;
            this.valuetext.Name = "valuetext";
            this.valuetext.Size = new System.Drawing.Size(336, 39);
            this.valuetext.TabIndex = 13;
            this.valuetext.TextChanged += new System.EventHandler(this.valuetext_TextChanged);
            // 
            // value
            // 
            this.value.AutoSize = true;
            this.value.BackColor = System.Drawing.Color.Transparent;
            this.value.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.value.ForeColor = System.Drawing.Color.Gainsboro;
            this.value.Location = new System.Drawing.Point(105, 266);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(135, 36);
            this.value.TabIndex = 15;
            this.value.Text = "Количество";
            // 
            // material
            // 
            this.material.AutoSize = true;
            this.material.BackColor = System.Drawing.Color.Transparent;
            this.material.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.material.ForeColor = System.Drawing.Color.Gainsboro;
            this.material.Location = new System.Drawing.Point(497, 266);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(118, 36);
            this.material.TabIndex = 16;
            this.material.Text = "Материал";
            // 
            // cashtext
            // 
            this.cashtext.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashtext.Location = new System.Drawing.Point(111, 412);
            this.cashtext.Multiline = true;
            this.cashtext.Name = "cashtext";
            this.cashtext.Size = new System.Drawing.Size(336, 39);
            this.cashtext.TabIndex = 17;
            // 
            // massText
            // 
            this.massText.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.massText.Location = new System.Drawing.Point(503, 409);
            this.massText.Multiline = true;
            this.massText.Name = "massText";
            this.massText.Size = new System.Drawing.Size(336, 40);
            this.massText.TabIndex = 36;
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.BackColor = System.Drawing.Color.Transparent;
            this.cash.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash.ForeColor = System.Drawing.Color.Gainsboro;
            this.cash.Location = new System.Drawing.Point(105, 373);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(130, 36);
            this.cash.TabIndex = 37;
            this.cash.Text = "Цена (руб.)";
            // 
            // mass
            // 
            this.mass.AutoSize = true;
            this.mass.BackColor = System.Drawing.Color.Transparent;
            this.mass.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mass.ForeColor = System.Drawing.Color.Gainsboro;
            this.mass.Location = new System.Drawing.Point(497, 373);
            this.mass.Name = "mass";
            this.mass.Size = new System.Drawing.Size(200, 36);
            this.mass.TabIndex = 38;
            this.mass.Text = "Масса (1 шт. в кг)";
            // 
            // AddLabelMenu
            // 
            this.AddLabelMenu.AutoSize = true;
            this.AddLabelMenu.BackColor = System.Drawing.Color.Transparent;
            this.AddLabelMenu.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddLabelMenu.ForeColor = System.Drawing.Color.White;
            this.AddLabelMenu.Location = new System.Drawing.Point(258, 76);
            this.AddLabelMenu.Name = "AddLabelMenu";
            this.AddLabelMenu.Size = new System.Drawing.Size(234, 50);
            this.AddLabelMenu.TabIndex = 52;
            this.AddLabelMenu.Text = "Добавление ";
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(138)))), ((int)(((byte)(15)))));
            this.addbutton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.e77a3f8f5809d2fbda84d9164262903b;
            this.addbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.addbutton.FlatAppearance.BorderSize = 0;
            this.addbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.addbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbutton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(938, 390);
            this.addbutton.Name = "addbutton";
            this.addbutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addbutton.Size = new System.Drawing.Size(171, 53);
            this.addbutton.TabIndex = 41;
            this.addbutton.Text = "Добавить";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // AddBox
            // 
            this.AddBox.BackColor = System.Drawing.Color.Transparent;
            this.AddBox.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_коробка_96;
            this.AddBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddBox.Location = new System.Drawing.Point(938, 219);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(150, 150);
            this.AddBox.TabIndex = 42;
            this.AddBox.TabStop = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(138)))), ((int)(((byte)(15)))));
            this.exit.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.e77a3f8f5809d2fbda84d9164262903b;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(621, 474);
            this.exit.Name = "exit";
            this.exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exit.Size = new System.Drawing.Size(182, 53);
            this.exit.TabIndex = 5;
            this.exit.Text = "Назад";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.backAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.logofinish;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(71, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 88);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Delprod
            // 
            this.Delprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(138)))), ((int)(((byte)(15)))));
            this.Delprod.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.e77a3f8f5809d2fbda84d9164262903b;
            this.Delprod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delprod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Delprod.FlatAppearance.BorderSize = 0;
            this.Delprod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.Delprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.Delprod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delprod.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delprod.ForeColor = System.Drawing.Color.White;
            this.Delprod.Location = new System.Drawing.Point(130, 474);
            this.Delprod.Name = "Delprod";
            this.Delprod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Delprod.Size = new System.Drawing.Size(182, 53);
            this.Delprod.TabIndex = 6;
            this.Delprod.Text = "Удалить товар";
            this.Delprod.UseVisualStyleBackColor = false;
            this.Delprod.Click += new System.EventHandler(this.Delprod_Click);
            // 
            // changeprod
            // 
            this.changeprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(138)))), ((int)(((byte)(15)))));
            this.changeprod.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.e77a3f8f5809d2fbda84d9164262903b;
            this.changeprod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeprod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.changeprod.FlatAppearance.BorderSize = 0;
            this.changeprod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.changeprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.changeprod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeprod.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeprod.ForeColor = System.Drawing.Color.White;
            this.changeprod.Location = new System.Drawing.Point(353, 474);
            this.changeprod.Name = "changeprod";
            this.changeprod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.changeprod.Size = new System.Drawing.Size(182, 53);
            this.changeprod.TabIndex = 7;
            this.changeprod.Text = "Редактировать";
            this.changeprod.UseVisualStyleBackColor = false;
            this.changeprod.Click += new System.EventHandler(this.changeprod_Click);
            // 
            // materialBox
            // 
            this.materialBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialBox.FormattingEnabled = true;
            this.materialBox.Location = new System.Drawing.Point(502, 304);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(337, 40);
            this.materialBox.TabIndex = 54;
            this.materialBox.SelectedIndexChanged += new System.EventHandler(this.materialBox_SelectedIndexChanged);
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
            this.crest.Location = new System.Drawing.Point(1235, 0);
            this.crest.Name = "crest";
            this.crest.Size = new System.Drawing.Size(45, 25);
            this.crest.TabIndex = 40;
            this.crest.UseVisualStyleBackColor = false;
            this.crest.Click += new System.EventHandler(this.crest_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.minimalizeButton);
            this.panel1.Controls.Add(this.crest);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 25);
            this.panel1.TabIndex = 55;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
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
            this.minimalizeButton.Click += new System.EventHandler(this.minimalizeButton_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(503, 193);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(337, 40);
            this.categoryBox.TabIndex = 56;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.categoryBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(496, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 36);
            this.label1.TabIndex = 57;
            this.label1.Text = "Категория";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fonosn1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.changeprod);
            this.Controls.Add(this.AddLabelMenu);
            this.Controls.Add(this.Delprod);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.mass);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.massText);
            this.Controls.Add(this.cashtext);
            this.Controls.Add(this.material);
            this.Controls.Add(this.value);
            this.Controls.Add(this.valuetext);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nametext);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOZTORG Добавление";
            this.Load += new System.EventHandler(this.Add_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Add_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Add_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Add_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.AddBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox valuetext;
        private System.Windows.Forms.Label value;
        private System.Windows.Forms.Label material;
        private System.Windows.Forms.TextBox cashtext;
        private System.Windows.Forms.TextBox massText;
        private System.Windows.Forms.Label cash;
        private System.Windows.Forms.Label mass;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.PictureBox AddBox;
        private System.Windows.Forms.Label AddLabelMenu;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Delprod;
        private System.Windows.Forms.Button changeprod;
        private System.Windows.Forms.ComboBox materialBox;
        private System.Windows.Forms.Button crest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimalizeButton;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label label1;
    }
}