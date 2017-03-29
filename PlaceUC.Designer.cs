namespace ParkingSystem
{
    partial class PlaceUC
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlaceNumberLabel = new System.Windows.Forms.Label();
            this.PlaceStatusLabel = new System.Windows.Forms.Label();
            this.DateFromLabel = new System.Windows.Forms.Label();
            this.DateToLabel = new System.Windows.Forms.Label();
            this.AbandonPlaceButton = new System.Windows.Forms.Button();
            this.TempReleasePlaceButton = new System.Windows.Forms.Button();
            this.PlaceManageGroupBox = new System.Windows.Forms.GroupBox();
            this.CarManageGroupBox = new System.Windows.Forms.GroupBox();
            this.CarDGV = new System.Windows.Forms.DataGridView();
            this.DeleteCarButton = new System.Windows.Forms.Button();
            this.EditCarButton = new System.Windows.Forms.Button();
            this.AddCarButton = new System.Windows.Forms.Button();
            this.PlaceManageGroupBox.SuspendLayout();
            this.CarManageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PlaceNumberLabel
            // 
            this.PlaceNumberLabel.AutoSize = true;
            this.PlaceNumberLabel.Location = new System.Drawing.Point(15, 34);
            this.PlaceNumberLabel.Name = "PlaceNumberLabel";
            this.PlaceNumberLabel.Size = new System.Drawing.Size(42, 13);
            this.PlaceNumberLabel.TabIndex = 0;
            this.PlaceNumberLabel.Text = "Место:";
            // 
            // PlaceStatusLabel
            // 
            this.PlaceStatusLabel.AutoSize = true;
            this.PlaceStatusLabel.Location = new System.Drawing.Point(129, 34);
            this.PlaceStatusLabel.Name = "PlaceStatusLabel";
            this.PlaceStatusLabel.Size = new System.Drawing.Size(44, 13);
            this.PlaceStatusLabel.TabIndex = 1;
            this.PlaceStatusLabel.Text = "Статус:";
            // 
            // DateFromLabel
            // 
            this.DateFromLabel.AutoSize = true;
            this.DateFromLabel.Location = new System.Drawing.Point(250, 34);
            this.DateFromLabel.Name = "DateFromLabel";
            this.DateFromLabel.Size = new System.Drawing.Size(51, 13);
            this.DateFromLabel.TabIndex = 2;
            this.DateFromLabel.Text = "Дата по:";
            // 
            // DateToLabel
            // 
            this.DateToLabel.AutoSize = true;
            this.DateToLabel.Location = new System.Drawing.Point(370, 34);
            this.DateToLabel.Name = "DateToLabel";
            this.DateToLabel.Size = new System.Drawing.Size(0, 13);
            this.DateToLabel.TabIndex = 3;
            // 
            // AbandonPlaceButton
            // 
            this.AbandonPlaceButton.Location = new System.Drawing.Point(18, 69);
            this.AbandonPlaceButton.Name = "AbandonPlaceButton";
            this.AbandonPlaceButton.Size = new System.Drawing.Size(75, 23);
            this.AbandonPlaceButton.TabIndex = 4;
            this.AbandonPlaceButton.Text = "Отказаться";
            this.AbandonPlaceButton.UseVisualStyleBackColor = true;
            this.AbandonPlaceButton.Click += new System.EventHandler(this.AbandonPlaceButton_Click);
            // 
            // TempReleasePlaceButton
            // 
            this.TempReleasePlaceButton.Location = new System.Drawing.Point(115, 69);
            this.TempReleasePlaceButton.Name = "TempReleasePlaceButton";
            this.TempReleasePlaceButton.Size = new System.Drawing.Size(128, 23);
            this.TempReleasePlaceButton.TabIndex = 6;
            this.TempReleasePlaceButton.Text = "Временно освободить";
            this.TempReleasePlaceButton.UseVisualStyleBackColor = true;
            this.TempReleasePlaceButton.Click += new System.EventHandler(this.TempReleasePlaceButton_Click);
            // 
            // PlaceManageGroupBox
            // 
            this.PlaceManageGroupBox.Controls.Add(this.TempReleasePlaceButton);
            this.PlaceManageGroupBox.Controls.Add(this.DateToLabel);
            this.PlaceManageGroupBox.Controls.Add(this.DateFromLabel);
            this.PlaceManageGroupBox.Controls.Add(this.AbandonPlaceButton);
            this.PlaceManageGroupBox.Controls.Add(this.PlaceStatusLabel);
            this.PlaceManageGroupBox.Controls.Add(this.PlaceNumberLabel);
            this.PlaceManageGroupBox.Location = new System.Drawing.Point(3, 3);
            this.PlaceManageGroupBox.Name = "PlaceManageGroupBox";
            this.PlaceManageGroupBox.Size = new System.Drawing.Size(547, 108);
            this.PlaceManageGroupBox.TabIndex = 7;
            this.PlaceManageGroupBox.TabStop = false;
            this.PlaceManageGroupBox.Text = "Управление парковочным местом";
            // 
            // CarManageGroupBox
            // 
            this.CarManageGroupBox.Controls.Add(this.CarDGV);
            this.CarManageGroupBox.Controls.Add(this.DeleteCarButton);
            this.CarManageGroupBox.Controls.Add(this.EditCarButton);
            this.CarManageGroupBox.Controls.Add(this.AddCarButton);
            this.CarManageGroupBox.Location = new System.Drawing.Point(4, 117);
            this.CarManageGroupBox.Name = "CarManageGroupBox";
            this.CarManageGroupBox.Size = new System.Drawing.Size(546, 253);
            this.CarManageGroupBox.TabIndex = 8;
            this.CarManageGroupBox.TabStop = false;
            this.CarManageGroupBox.Text = "Управление машинами";
            // 
            // CarDGV
            // 
            this.CarDGV.AllowUserToAddRows = false;
            this.CarDGV.AllowUserToDeleteRows = false;
            this.CarDGV.AllowUserToResizeColumns = false;
            this.CarDGV.AllowUserToResizeRows = false;
            this.CarDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarDGV.Location = new System.Drawing.Point(7, 50);
            this.CarDGV.MultiSelect = false;
            this.CarDGV.Name = "CarDGV";
            this.CarDGV.ReadOnly = true;
            this.CarDGV.RowHeadersVisible = false;
            this.CarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarDGV.Size = new System.Drawing.Size(533, 197);
            this.CarDGV.TabIndex = 3;
            // 
            // DeleteCarButton
            // 
            this.DeleteCarButton.Location = new System.Drawing.Point(215, 20);
            this.DeleteCarButton.Name = "DeleteCarButton";
            this.DeleteCarButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCarButton.TabIndex = 2;
            this.DeleteCarButton.Text = "Удалить";
            this.DeleteCarButton.UseVisualStyleBackColor = true;
            this.DeleteCarButton.Click += new System.EventHandler(this.DeleteCarButton_Click);
            // 
            // EditCarButton
            // 
            this.EditCarButton.Location = new System.Drawing.Point(101, 20);
            this.EditCarButton.Name = "EditCarButton";
            this.EditCarButton.Size = new System.Drawing.Size(98, 23);
            this.EditCarButton.TabIndex = 1;
            this.EditCarButton.Text = "Редактировать";
            this.EditCarButton.UseVisualStyleBackColor = true;
            this.EditCarButton.Click += new System.EventHandler(this.EditCarButton_Click);
            // 
            // AddCarButton
            // 
            this.AddCarButton.Location = new System.Drawing.Point(7, 20);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(75, 23);
            this.AddCarButton.TabIndex = 0;
            this.AddCarButton.Text = "Добавить";
            this.AddCarButton.UseVisualStyleBackColor = true;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // PlaceUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.CarManageGroupBox);
            this.Controls.Add(this.PlaceManageGroupBox);
            this.Name = "PlaceUC";
            this.Size = new System.Drawing.Size(553, 373);
            this.PlaceManageGroupBox.ResumeLayout(false);
            this.PlaceManageGroupBox.PerformLayout();
            this.CarManageGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CarDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AbandonPlaceButton;
        private System.Windows.Forms.Button TempReleasePlaceButton;
        public System.Windows.Forms.Label PlaceNumberLabel;
        public System.Windows.Forms.Label PlaceStatusLabel;
        public System.Windows.Forms.Label DateFromLabel;
        public System.Windows.Forms.Label DateToLabel;
        private System.Windows.Forms.GroupBox PlaceManageGroupBox;
        private System.Windows.Forms.GroupBox CarManageGroupBox;
        private System.Windows.Forms.Button DeleteCarButton;
        private System.Windows.Forms.Button EditCarButton;
        private System.Windows.Forms.Button AddCarButton;
        public System.Windows.Forms.DataGridView CarDGV;
    }
}
