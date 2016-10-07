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
            this.AbandonButton = new System.Windows.Forms.Button();
            this.TempReleaseButton = new System.Windows.Forms.Button();
            this.PlaceManageGroupBox = new System.Windows.Forms.GroupBox();
            this.CarManageGroupBox = new System.Windows.Forms.GroupBox();
            this.CarDGV = new System.Windows.Forms.DataGridView();
            this.DeleteCar = new System.Windows.Forms.Button();
            this.EditCar = new System.Windows.Forms.Button();
            this.AddCar = new System.Windows.Forms.Button();
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
            this.PlaceStatusLabel.Location = new System.Drawing.Point(99, 34);
            this.PlaceStatusLabel.Name = "PlaceStatusLabel";
            this.PlaceStatusLabel.Size = new System.Drawing.Size(44, 13);
            this.PlaceStatusLabel.TabIndex = 1;
            this.PlaceStatusLabel.Text = "Статус:";
            // 
            // DateFromLabel
            // 
            this.DateFromLabel.AutoSize = true;
            this.DateFromLabel.Location = new System.Drawing.Point(246, 34);
            this.DateFromLabel.Name = "DateFromLabel";
            this.DateFromLabel.Size = new System.Drawing.Size(45, 13);
            this.DateFromLabel.TabIndex = 2;
            this.DateFromLabel.Text = "Дата с:";
            // 
            // DateToLabel
            // 
            this.DateToLabel.AutoSize = true;
            this.DateToLabel.Location = new System.Drawing.Point(411, 34);
            this.DateToLabel.Name = "DateToLabel";
            this.DateToLabel.Size = new System.Drawing.Size(51, 13);
            this.DateToLabel.TabIndex = 3;
            this.DateToLabel.Text = "Дата по:";
            // 
            // AbandonButton
            // 
            this.AbandonButton.Location = new System.Drawing.Point(18, 69);
            this.AbandonButton.Name = "AbandonButton";
            this.AbandonButton.Size = new System.Drawing.Size(75, 23);
            this.AbandonButton.TabIndex = 4;
            this.AbandonButton.Text = "Отказаться";
            this.AbandonButton.UseVisualStyleBackColor = true;
            // 
            // TempReleaseButton
            // 
            this.TempReleaseButton.Location = new System.Drawing.Point(115, 69);
            this.TempReleaseButton.Name = "TempReleaseButton";
            this.TempReleaseButton.Size = new System.Drawing.Size(128, 23);
            this.TempReleaseButton.TabIndex = 6;
            this.TempReleaseButton.Text = "Временно освободить";
            this.TempReleaseButton.UseVisualStyleBackColor = true;
            // 
            // PlaceManageGroupBox
            // 
            this.PlaceManageGroupBox.Controls.Add(this.TempReleaseButton);
            this.PlaceManageGroupBox.Controls.Add(this.DateToLabel);
            this.PlaceManageGroupBox.Controls.Add(this.DateFromLabel);
            this.PlaceManageGroupBox.Controls.Add(this.AbandonButton);
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
            this.CarManageGroupBox.Controls.Add(this.DeleteCar);
            this.CarManageGroupBox.Controls.Add(this.EditCar);
            this.CarManageGroupBox.Controls.Add(this.AddCar);
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
            this.CarDGV.Enabled = false;
            this.CarDGV.Location = new System.Drawing.Point(7, 50);
            this.CarDGV.MultiSelect = false;
            this.CarDGV.Name = "CarDGV";
            this.CarDGV.ReadOnly = true;
            this.CarDGV.RowHeadersVisible = false;
            this.CarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarDGV.Size = new System.Drawing.Size(533, 197);
            this.CarDGV.TabIndex = 3;
            // 
            // DeleteCar
            // 
            this.DeleteCar.Location = new System.Drawing.Point(215, 20);
            this.DeleteCar.Name = "DeleteCar";
            this.DeleteCar.Size = new System.Drawing.Size(75, 23);
            this.DeleteCar.TabIndex = 2;
            this.DeleteCar.Text = "Удалить";
            this.DeleteCar.UseVisualStyleBackColor = true;
            // 
            // EditCar
            // 
            this.EditCar.Location = new System.Drawing.Point(101, 20);
            this.EditCar.Name = "EditCar";
            this.EditCar.Size = new System.Drawing.Size(98, 23);
            this.EditCar.TabIndex = 1;
            this.EditCar.Text = "Редактировать";
            this.EditCar.UseVisualStyleBackColor = true;
            // 
            // AddCar
            // 
            this.AddCar.Location = new System.Drawing.Point(7, 20);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(75, 23);
            this.AddCar.TabIndex = 0;
            this.AddCar.Text = "Добавить";
            this.AddCar.UseVisualStyleBackColor = true;
            // 
            // PlaceUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.Button AbandonButton;
        private System.Windows.Forms.Button TempReleaseButton;
        public System.Windows.Forms.Label PlaceNumberLabel;
        public System.Windows.Forms.Label PlaceStatusLabel;
        public System.Windows.Forms.Label DateFromLabel;
        public System.Windows.Forms.Label DateToLabel;
        private System.Windows.Forms.GroupBox PlaceManageGroupBox;
        private System.Windows.Forms.GroupBox CarManageGroupBox;
        private System.Windows.Forms.Button DeleteCar;
        private System.Windows.Forms.Button EditCar;
        private System.Windows.Forms.Button AddCar;
        public System.Windows.Forms.DataGridView CarDGV;
    }
}
