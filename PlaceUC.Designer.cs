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
            this.AddCarButton = new System.Windows.Forms.Button();
            this.TempReleaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlaceNumberLabel
            // 
            this.PlaceNumberLabel.AutoSize = true;
            this.PlaceNumberLabel.Location = new System.Drawing.Point(38, 30);
            this.PlaceNumberLabel.Name = "PlaceNumberLabel";
            this.PlaceNumberLabel.Size = new System.Drawing.Size(42, 13);
            this.PlaceNumberLabel.TabIndex = 0;
            this.PlaceNumberLabel.Text = "Место:";
            // 
            // PlaceStatusLabel
            // 
            this.PlaceStatusLabel.AutoSize = true;
            this.PlaceStatusLabel.Location = new System.Drawing.Point(312, 30);
            this.PlaceStatusLabel.Name = "PlaceStatusLabel";
            this.PlaceStatusLabel.Size = new System.Drawing.Size(44, 13);
            this.PlaceStatusLabel.TabIndex = 1;
            this.PlaceStatusLabel.Text = "Статус:";
            // 
            // DateFromLabel
            // 
            this.DateFromLabel.AutoSize = true;
            this.DateFromLabel.Location = new System.Drawing.Point(312, 52);
            this.DateFromLabel.Name = "DateFromLabel";
            this.DateFromLabel.Size = new System.Drawing.Size(45, 13);
            this.DateFromLabel.TabIndex = 2;
            this.DateFromLabel.Text = "Дата с:";
            // 
            // DateToLabel
            // 
            this.DateToLabel.AutoSize = true;
            this.DateToLabel.Location = new System.Drawing.Point(312, 75);
            this.DateToLabel.Name = "DateToLabel";
            this.DateToLabel.Size = new System.Drawing.Size(51, 13);
            this.DateToLabel.TabIndex = 3;
            this.DateToLabel.Text = "Дата по:";
            // 
            // AbandonButton
            // 
            this.AbandonButton.Location = new System.Drawing.Point(41, 123);
            this.AbandonButton.Name = "AbandonButton";
            this.AbandonButton.Size = new System.Drawing.Size(75, 23);
            this.AbandonButton.TabIndex = 4;
            this.AbandonButton.Text = "Отказаться";
            this.AbandonButton.UseVisualStyleBackColor = true;
            // 
            // AddCarButton
            // 
            this.AddCarButton.Location = new System.Drawing.Point(41, 163);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(109, 23);
            this.AddCarButton.TabIndex = 5;
            this.AddCarButton.Text = "Добавить машину";
            this.AddCarButton.UseVisualStyleBackColor = true;
            // 
            // TempReleaseButton
            // 
            this.TempReleaseButton.Location = new System.Drawing.Point(302, 123);
            this.TempReleaseButton.Name = "TempReleaseButton";
            this.TempReleaseButton.Size = new System.Drawing.Size(128, 23);
            this.TempReleaseButton.TabIndex = 6;
            this.TempReleaseButton.Text = "Временно освободить";
            this.TempReleaseButton.UseVisualStyleBackColor = true;
            // 
            // PlaceUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TempReleaseButton);
            this.Controls.Add(this.AddCarButton);
            this.Controls.Add(this.AbandonButton);
            this.Controls.Add(this.DateToLabel);
            this.Controls.Add(this.DateFromLabel);
            this.Controls.Add(this.PlaceStatusLabel);
            this.Controls.Add(this.PlaceNumberLabel);
            this.Name = "PlaceUC";
            this.Size = new System.Drawing.Size(553, 373);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AbandonButton;
        private System.Windows.Forms.Button AddCarButton;
        private System.Windows.Forms.Button TempReleaseButton;
        public System.Windows.Forms.Label PlaceNumberLabel;
        public System.Windows.Forms.Label PlaceStatusLabel;
        public System.Windows.Forms.Label DateFromLabel;
        public System.Windows.Forms.Label DateToLabel;
    }
}
