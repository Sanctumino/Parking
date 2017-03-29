namespace ParkingSystem
{
    partial class AddCarForm
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
            this.MakeLabel = new System.Windows.Forms.Label();
            this.MakeTB = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelTB = new System.Windows.Forms.TextBox();
            this.CarNumberLabel = new System.Windows.Forms.Label();
            this.CarNumberTB = new System.Windows.Forms.TextBox();
            this.AddCarSaveButton = new System.Windows.Forms.Button();
            this.AddCarCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MakeLabel
            // 
            this.MakeLabel.AutoSize = true;
            this.MakeLabel.Location = new System.Drawing.Point(13, 29);
            this.MakeLabel.Name = "MakeLabel";
            this.MakeLabel.Size = new System.Drawing.Size(40, 13);
            this.MakeLabel.TabIndex = 0;
            this.MakeLabel.Text = "Марка";
            // 
            // MakeTB
            // 
            this.MakeTB.Location = new System.Drawing.Point(16, 45);
            this.MakeTB.Name = "MakeTB";
            this.MakeTB.Size = new System.Drawing.Size(133, 20);
            this.MakeTB.TabIndex = 1;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(16, 96);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(46, 13);
            this.ModelLabel.TabIndex = 2;
            this.ModelLabel.Text = "Модель";
            // 
            // ModelTB
            // 
            this.ModelTB.Location = new System.Drawing.Point(16, 112);
            this.ModelTB.Name = "ModelTB";
            this.ModelTB.Size = new System.Drawing.Size(133, 20);
            this.ModelTB.TabIndex = 3;
            // 
            // CarNumberLabel
            // 
            this.CarNumberLabel.AutoSize = true;
            this.CarNumberLabel.Location = new System.Drawing.Point(16, 163);
            this.CarNumberLabel.Name = "CarNumberLabel";
            this.CarNumberLabel.Size = new System.Drawing.Size(133, 13);
            this.CarNumberLabel.TabIndex = 4;
            this.CarNumberLabel.Text = "Регистрационный номер";
            // 
            // CarNumberTB
            // 
            this.CarNumberTB.Location = new System.Drawing.Point(16, 179);
            this.CarNumberTB.Name = "CarNumberTB";
            this.CarNumberTB.Size = new System.Drawing.Size(133, 20);
            this.CarNumberTB.TabIndex = 5;
            // 
            // AddCarSaveButton
            // 
            this.AddCarSaveButton.Location = new System.Drawing.Point(16, 227);
            this.AddCarSaveButton.Name = "AddCarSaveButton";
            this.AddCarSaveButton.Size = new System.Drawing.Size(75, 23);
            this.AddCarSaveButton.TabIndex = 6;
            this.AddCarSaveButton.Text = "Сохранить";
            this.AddCarSaveButton.UseVisualStyleBackColor = true;
            this.AddCarSaveButton.Click += new System.EventHandler(this.AddCarSaveButton_Click);
            // 
            // AddCarCancelButton
            // 
            this.AddCarCancelButton.Location = new System.Drawing.Point(157, 227);
            this.AddCarCancelButton.Name = "AddCarCancelButton";
            this.AddCarCancelButton.Size = new System.Drawing.Size(75, 23);
            this.AddCarCancelButton.TabIndex = 7;
            this.AddCarCancelButton.Text = "Отмена";
            this.AddCarCancelButton.UseVisualStyleBackColor = true;
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.AddCarCancelButton);
            this.Controls.Add(this.AddCarSaveButton);
            this.Controls.Add(this.CarNumberTB);
            this.Controls.Add(this.CarNumberLabel);
            this.Controls.Add(this.ModelTB);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.MakeTB);
            this.Controls.Add(this.MakeLabel);
            this.Name = "AddCarForm";
            this.Text = "Добавить машину";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MakeLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label CarNumberLabel;
        private System.Windows.Forms.Button AddCarSaveButton;
        private System.Windows.Forms.Button AddCarCancelButton;
        public System.Windows.Forms.TextBox MakeTB;
        public System.Windows.Forms.TextBox ModelTB;
        public System.Windows.Forms.TextBox CarNumberTB;
    }
}