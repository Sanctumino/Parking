namespace ParkingSystem
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Место");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Заявки");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Журнал событий");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Парковка");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Парковка", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.Tree = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.Tree);
            this.splitContainer.Size = new System.Drawing.Size(692, 373);
            this.splitContainer.SplitterDistance = 139;
            this.splitContainer.TabIndex = 0;
            // 
            // Tree
            // 
            this.Tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tree.Location = new System.Drawing.Point(0, 0);
            this.Tree.Name = "Tree";
            treeNode6.Name = "Place";
            treeNode6.Text = "Место";
            treeNode7.Name = "Application";
            treeNode7.Text = "Заявки";
            treeNode8.Name = "Log";
            treeNode8.Text = "Журнал событий";
            treeNode9.Name = "Parking";
            treeNode9.Text = "Парковка";
            treeNode10.Name = "MainNode";
            treeNode10.Text = "Парковка";
            this.Tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.Tree.Size = new System.Drawing.Size(139, 373);
            this.Tree.TabIndex = 0;
            this.Tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tree_AfterSelect);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(692, 373);
            this.Controls.Add(this.splitContainer);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Система парковки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        public System.Windows.Forms.TreeView Tree;
    }
}