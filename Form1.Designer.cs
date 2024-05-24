namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.musicButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.changeprod = new System.Windows.Forms.Button();
            this.Delprod = new System.Windows.Forms.Button();
            this.Addprod = new System.Windows.Forms.Button();
            this.research = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.minimalizeButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sortProd = new System.Windows.Forms.Button();
            this.listOfAll = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfAll)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(9)))), ((int)(((byte)(26)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.musicButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.changeprod);
            this.panel1.Controls.Add(this.Delprod);
            this.panel1.Controls.Add(this.Addprod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 560);
            this.panel1.TabIndex = 0;
            // 
            // musicButton
            // 
            this.musicButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(138)))), ((int)(((byte)(15)))));
            this.musicButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.e77a3f8f5809d2fbda84d9164262903b;
            this.musicButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.musicButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musicButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.musicButton.FlatAppearance.BorderSize = 0;
            this.musicButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.musicButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.musicButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.musicButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.musicButton.ForeColor = System.Drawing.Color.White;
            this.musicButton.Location = new System.Drawing.Point(40, 370);
            this.musicButton.Name = "musicButton";
            this.musicButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.musicButton.Size = new System.Drawing.Size(182, 53);
            this.musicButton.TabIndex = 8;
            this.musicButton.Text = "Настройки фоновой \r\nмузыки";
            this.musicButton.UseVisualStyleBackColor = false;
            this.musicButton.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 72);
            this.label1.TabIndex = 7;
            this.label1.Text = "HOZ\r\nTORG";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.logofinish;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(18, 41);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(119, 69);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
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
            this.exit.Location = new System.Drawing.Point(40, 477);
            this.exit.Name = "exit";
            this.exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exit.Size = new System.Drawing.Size(182, 53);
            this.exit.TabIndex = 5;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
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
            this.changeprod.Location = new System.Drawing.Point(40, 290);
            this.changeprod.Name = "changeprod";
            this.changeprod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.changeprod.Size = new System.Drawing.Size(182, 53);
            this.changeprod.TabIndex = 4;
            this.changeprod.Text = "Редактировать товар";
            this.changeprod.UseVisualStyleBackColor = false;
            this.changeprod.Click += new System.EventHandler(this.changeprod_Click);
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
            this.Delprod.Location = new System.Drawing.Point(40, 210);
            this.Delprod.Name = "Delprod";
            this.Delprod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Delprod.Size = new System.Drawing.Size(182, 53);
            this.Delprod.TabIndex = 3;
            this.Delprod.Text = "Удалить товар";
            this.Delprod.UseVisualStyleBackColor = false;
            this.Delprod.Click += new System.EventHandler(this.Delprod_Click);
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
            this.Addprod.Location = new System.Drawing.Point(40, 130);
            this.Addprod.Name = "Addprod";
            this.Addprod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Addprod.Size = new System.Drawing.Size(182, 53);
            this.Addprod.TabIndex = 2;
            this.Addprod.Text = "Добавить товар";
            this.Addprod.UseVisualStyleBackColor = false;
            this.Addprod.Click += new System.EventHandler(this.Addprod_Click);
            // 
            // research
            // 
            this.research.BackColor = System.Drawing.Color.Transparent;
            this.research.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.thelupa2;
            this.research.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.research.Cursor = System.Windows.Forms.Cursors.Hand;
            this.research.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.research.Location = new System.Drawing.Point(347, 60);
            this.research.Name = "research";
            this.research.Size = new System.Drawing.Size(40, 40);
            this.research.TabIndex = 4;
            this.research.UseVisualStyleBackColor = false;
            this.research.Click += new System.EventHandler(this.research_Click);
            // 
            // searchText
            // 
            this.searchText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.searchText.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchText.Location = new System.Drawing.Point(388, 60);
            this.searchText.Multiline = true;
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(856, 40);
            this.searchText.TabIndex = 5;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.Black;
            this.exportButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.e77a3f8f5809d2fbda84d9164262903b;
            this.exportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.exportButton.FlatAppearance.BorderSize = 0;
            this.exportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.exportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.ForeColor = System.Drawing.Color.White;
            this.exportButton.Location = new System.Drawing.Point(936, 449);
            this.exportButton.Name = "exportButton";
            this.exportButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exportButton.Size = new System.Drawing.Size(182, 53);
            this.exportButton.TabIndex = 54;
            this.exportButton.Text = "Общий отчет";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel2.Controls.Add(this.minimalizeButton);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 25);
            this.panel2.TabIndex = 59;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
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
            this.button3.Location = new System.Drawing.Point(1235, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 25);
            this.button3.TabIndex = 40;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sortProd
            // 
            this.sortProd.BackColor = System.Drawing.Color.Black;
            this.sortProd.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.e77a3f8f5809d2fbda84d9164262903b;
            this.sortProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sortProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.sortProd.FlatAppearance.BorderSize = 0;
            this.sortProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.sortProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.sortProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sortProd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortProd.ForeColor = System.Drawing.Color.White;
            this.sortProd.Location = new System.Drawing.Point(415, 449);
            this.sortProd.Name = "sortProd";
            this.sortProd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sortProd.Size = new System.Drawing.Size(234, 53);
            this.sortProd.TabIndex = 60;
            this.sortProd.Text = "Сортировка";
            this.sortProd.UseVisualStyleBackColor = false;
            this.sortProd.Click += new System.EventHandler(this.sortProd_Click_1);
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
            this.listOfAll.Location = new System.Drawing.Point(347, 99);
            this.listOfAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listOfAll.Name = "listOfAll";
            this.listOfAll.RowHeadersWidth = 31;
            this.listOfAll.RowTemplate.Height = 24;
            this.listOfAll.Size = new System.Drawing.Size(897, 324);
            this.listOfAll.TabIndex = 61;
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
            // categoryButton
            // 
            this.categoryButton.BackColor = System.Drawing.Color.Black;
            this.categoryButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.e77a3f8f5809d2fbda84d9164262903b;
            this.categoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.categoryButton.FlatAppearance.BorderSize = 0;
            this.categoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.categoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.categoryButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryButton.ForeColor = System.Drawing.Color.White;
            this.categoryButton.Location = new System.Drawing.Point(738, 449);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoryButton.Size = new System.Drawing.Size(182, 53);
            this.categoryButton.TabIndex = 62;
            this.categoryButton.Text = "Отчет по категории";
            this.categoryButton.UseVisualStyleBackColor = false;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fonosn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 560);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.listOfAll);
            this.Controls.Add(this.sortProd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.research);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOZTORG Главная";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listOfAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Addprod;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button changeprod;
        private System.Windows.Forms.Button Delprod;
        private System.Windows.Forms.Button research;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button minimalizeButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button sortProd;
        private System.Windows.Forms.Button musicButton;
        private System.Windows.Forms.DataGridView listOfAll;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
    }
}

