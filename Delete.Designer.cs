namespace WindowsFormsApp1
{
    partial class Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.ID = new System.Windows.Forms.Label();
            this.idtext = new System.Windows.Forms.TextBox();
            this.SortLabelMenu = new System.Windows.Forms.Label();
            this.backDelete = new System.Windows.Forms.Button();
            this.changeprod = new System.Windows.Forms.Button();
            this.Addprod = new System.Windows.Forms.Button();
            this.AddBox = new System.Windows.Forms.PictureBox();
            this.delKrest = new System.Windows.Forms.PictureBox();
            this.deletebutton = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimalizeButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listOfAll = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AddBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delKrest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfAll)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID.ForeColor = System.Drawing.Color.Gainsboro;
            this.ID.Location = new System.Drawing.Point(1237, 343);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(173, 29);
            this.ID.TabIndex = 19;
            this.ID.Text = "Введите ID товара";
            // 
            // idtext
            // 
            this.idtext.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idtext.Location = new System.Drawing.Point(1241, 375);
            this.idtext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idtext.Multiline = true;
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(169, 38);
            this.idtext.TabIndex = 18;
            // 
            // SortLabelMenu
            // 
            this.SortLabelMenu.AutoSize = true;
            this.SortLabelMenu.BackColor = System.Drawing.Color.Transparent;
            this.SortLabelMenu.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortLabelMenu.ForeColor = System.Drawing.Color.White;
            this.SortLabelMenu.Location = new System.Drawing.Point(245, 51);
            this.SortLabelMenu.Name = "SortLabelMenu";
            this.SortLabelMenu.Size = new System.Drawing.Size(180, 50);
            this.SortLabelMenu.TabIndex = 52;
            this.SortLabelMenu.Text = "Удаление";
            // 
            // backDelete
            // 
            this.backDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(138)))), ((int)(((byte)(15)))));
            this.backDelete.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.e77a3f8f5809d2fbda84d9164262903b;
            this.backDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.backDelete.FlatAppearance.BorderSize = 0;
            this.backDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.backDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.backDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backDelete.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backDelete.ForeColor = System.Drawing.Color.White;
            this.backDelete.Location = new System.Drawing.Point(899, 506);
            this.backDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backDelete.Name = "backDelete";
            this.backDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.backDelete.Size = new System.Drawing.Size(181, 53);
            this.backDelete.TabIndex = 5;
            this.backDelete.Text = "Назад";
            this.backDelete.UseVisualStyleBackColor = false;
            this.backDelete.Click += new System.EventHandler(this.backDelete_Click);
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
            this.changeprod.Location = new System.Drawing.Point(333, 506);
            this.changeprod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeprod.Name = "changeprod";
            this.changeprod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.changeprod.Size = new System.Drawing.Size(181, 53);
            this.changeprod.TabIndex = 4;
            this.changeprod.Text = "Редактировать";
            this.changeprod.UseVisualStyleBackColor = false;
            this.changeprod.Click += new System.EventHandler(this.changeprod_Click);
            // 
            // Addprod
            // 
            this.Addprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(138)))), ((int)(((byte)(15)))));
            this.Addprod.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.e77a3f8f5809d2fbda84d9164262903b;
            this.Addprod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Addprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Addprod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Addprod.FlatAppearance.BorderSize = 0;
            this.Addprod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.Addprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.Addprod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Addprod.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addprod.ForeColor = System.Drawing.Color.White;
            this.Addprod.Location = new System.Drawing.Point(113, 506);
            this.Addprod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Addprod.Name = "Addprod";
            this.Addprod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Addprod.Size = new System.Drawing.Size(181, 53);
            this.Addprod.TabIndex = 2;
            this.Addprod.Text = "Добавить товар";
            this.Addprod.UseVisualStyleBackColor = false;
            this.Addprod.Click += new System.EventHandler(this.Addprod_Click);
            // 
            // AddBox
            // 
            this.AddBox.BackColor = System.Drawing.Color.Transparent;
            this.AddBox.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_коробка_96;
            this.AddBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddBox.Location = new System.Drawing.Point(1241, 189);
            this.AddBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(149, 150);
            this.AddBox.TabIndex = 43;
            this.AddBox.TabStop = false;
            // 
            // delKrest
            // 
            this.delKrest.BackColor = System.Drawing.Color.Transparent;
            this.delKrest.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pngwing_com__2_;
            this.delKrest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delKrest.Image = global::WindowsFormsApp1.Properties.Resources.pngwing_com__2_;
            this.delKrest.Location = new System.Drawing.Point(1345, 293);
            this.delKrest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delKrest.Name = "delKrest";
            this.delKrest.Size = new System.Drawing.Size(45, 46);
            this.delKrest.TabIndex = 44;
            this.delKrest.TabStop = false;
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(138)))), ((int)(((byte)(15)))));
            this.deletebutton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.e77a3f8f5809d2fbda84d9164262903b;
            this.deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.deletebutton.FlatAppearance.BorderSize = 0;
            this.deletebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.deletebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deletebutton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletebutton.ForeColor = System.Drawing.Color.White;
            this.deletebutton.Location = new System.Drawing.Point(1242, 420);
            this.deletebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deletebutton.Size = new System.Drawing.Size(171, 53);
            this.deletebutton.TabIndex = 45;
            this.deletebutton.Text = "Удалить";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.logofinish;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(72, 31);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(155, 89);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.minimalizeButton);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 25);
            this.panel1.TabIndex = 59;
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
            this.minimalizeButton.Location = new System.Drawing.Point(1410, 0);
            this.minimalizeButton.Name = "minimalizeButton";
            this.minimalizeButton.Size = new System.Drawing.Size(45, 25);
            this.minimalizeButton.TabIndex = 56;
            this.minimalizeButton.Text = "−";
            this.minimalizeButton.UseVisualStyleBackColor = false;
            this.minimalizeButton.Click += new System.EventHandler(this.minimalizeButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlText;
            this.button3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.rightcrest2;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(1455, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 25);
            this.button3.TabIndex = 40;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listOfAll
            // 
            this.listOfAll.BackgroundColor = System.Drawing.Color.White;
            this.listOfAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Category});
            this.listOfAll.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listOfAll.Location = new System.Drawing.Point(35, 143);
            this.listOfAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listOfAll.Name = "listOfAll";
            this.listOfAll.RowHeadersWidth = 31;
            this.listOfAll.RowTemplate.Height = 24;
            this.listOfAll.Size = new System.Drawing.Size(1158, 303);
            this.listOfAll.TabIndex = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 125F;
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 175;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Материал";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Масса";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 75;
            // 
            // Category
            // 
            this.Category.HeaderText = "Категория";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 125;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fonosn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1500, 600);
            this.Controls.Add(this.listOfAll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.SortLabelMenu);
            this.Controls.Add(this.backDelete);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.changeprod);
            this.Controls.Add(this.delKrest);
            this.Controls.Add(this.Addprod);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.idtext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOZTORG Удаление";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Delete_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Delete_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Delete_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.AddBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delKrest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listOfAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.Button backDelete;
        private System.Windows.Forms.Button changeprod;
        private System.Windows.Forms.Button Addprod;
        private System.Windows.Forms.Label SortLabelMenu;
        private System.Windows.Forms.PictureBox AddBox;
        private System.Windows.Forms.PictureBox delKrest;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimalizeButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView listOfAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
    }
}