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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Место");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Заявки");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Журнал событий");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Парковка");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Парковка", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
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
            treeNode1.Name = "Place";
            treeNode1.Text = "Место";
            treeNode2.Name = "Application";
            treeNode2.Text = "Заявки";
            treeNode3.Name = "Log";
            treeNode3.Text = "Журнал событий";
            treeNode4.Name = "Parking";
            treeNode4.Text = "Парковка";
            treeNode5.Name = "MainNode";
            treeNode5.Text = "Парковка";
            this.Tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.Tree.Size = new System.Drawing.Size(139, 373);
            this.Tree.TabIndex = 0;
            this.Tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tree_AfterSelect);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 373);
            this.Controls.Add(this.splitContainer);
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView Tree;
    }
}