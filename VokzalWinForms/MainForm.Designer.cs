namespace VokzalWinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.workersButton = new System.Windows.Forms.Button();
            this.trainsButton = new System.Windows.Forms.Button();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.brigadesButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.chooseDbButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // workersButton
            // 
            this.workersButton.Location = new System.Drawing.Point(12, 54);
            this.workersButton.Name = "workersButton";
            this.workersButton.Size = new System.Drawing.Size(150, 30);
            this.workersButton.TabIndex = 1;
            this.workersButton.Text = "Работники";
            this.workersButton.UseVisualStyleBackColor = true;
            this.workersButton.Click += new System.EventHandler(this.workersButton_Click);
            // 
            // trainsButton
            // 
            this.trainsButton.Location = new System.Drawing.Point(168, 55);
            this.trainsButton.Name = "trainsButton";
            this.trainsButton.Size = new System.Drawing.Size(150, 30);
            this.trainsButton.TabIndex = 2;
            this.trainsButton.Text = "Поезда";
            this.trainsButton.UseVisualStyleBackColor = true;
            this.trainsButton.Click += new System.EventHandler(this.trainsButton_Click);
            // 
            // scheduleButton
            // 
            this.scheduleButton.Location = new System.Drawing.Point(324, 55);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(150, 30);
            this.scheduleButton.TabIndex = 3;
            this.scheduleButton.Text = "Расписание";
            this.scheduleButton.UseVisualStyleBackColor = true;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // brigadesButton
            // 
            this.brigadesButton.Location = new System.Drawing.Point(480, 55);
            this.brigadesButton.Name = "brigadesButton";
            this.brigadesButton.Size = new System.Drawing.Size(150, 30);
            this.brigadesButton.TabIndex = 4;
            this.brigadesButton.Text = "Бригады поездов";
            this.brigadesButton.UseVisualStyleBackColor = true;
            this.brigadesButton.Click += new System.EventHandler(this.brigadesButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.Location = new System.Drawing.Point(636, 55);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(150, 30);
            this.salesButton.TabIndex = 5;
            this.salesButton.Text = "Продажа билетов";
            this.salesButton.UseVisualStyleBackColor = true;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(14, 103);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(45, 15);
            this.searchLabel.TabIndex = 6;
            this.searchLabel.Text = "Поиск:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(64, 103);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(260, 23);
            this.searchTextBox.TabIndex = 7;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(337, 98);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 27);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(463, 98);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(120, 27);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(589, 98);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 27);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(715, 98);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(120, 27);
            this.refreshButton.TabIndex = 11;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // chooseDbButton
            // 
            this.chooseDbButton.Location = new System.Drawing.Point(842, 98);
            this.chooseDbButton.Name = "chooseDbButton";
            this.chooseDbButton.Size = new System.Drawing.Size(120, 27);
            this.chooseDbButton.TabIndex = 12;
            this.chooseDbButton.Text = "Выбрать БД";
            this.chooseDbButton.UseVisualStyleBackColor = true;
            this.chooseDbButton.Click += new System.EventHandler(this.chooseDbButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1110, 485);
            this.dataGridView1.TabIndex = 13;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusLabel.Location = new System.Drawing.Point(12, 655);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(1110, 25);
            this.statusLabel.TabIndex = 14;
            this.statusLabel.Text = "База данных не выбрана";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(506, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Информационная система железнодорожного вокзала";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 691);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chooseDbButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.brigadesButton);
            this.Controls.Add(this.scheduleButton);
            this.Controls.Add(this.trainsButton);
            this.Controls.Add(this.workersButton);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1050, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ИС железнодорожного вокзала — вариант 16";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button workersButton;
        private System.Windows.Forms.Button trainsButton;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Button brigadesButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button chooseDbButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}
