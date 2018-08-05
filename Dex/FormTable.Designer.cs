namespace Dex
{
    partial class FormTable
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destroyTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insert1RowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insert5RowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insert10RowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(260, 194);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 26);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.rowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(260, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createColumnToolStripMenuItem,
            this.destroyTableToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // createColumnToolStripMenuItem
            // 
            this.createColumnToolStripMenuItem.Name = "createColumnToolStripMenuItem";
            this.createColumnToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.createColumnToolStripMenuItem.Text = "Create Column";
            this.createColumnToolStripMenuItem.Click += new System.EventHandler(this.createColumnToolStripMenuItem_Click);
            // 
            // destroyTableToolStripMenuItem
            // 
            this.destroyTableToolStripMenuItem.Name = "destroyTableToolStripMenuItem";
            this.destroyTableToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.destroyTableToolStripMenuItem.Text = "Destroy Table";
            // 
            // rowToolStripMenuItem
            // 
            this.rowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insert1RowToolStripMenuItem,
            this.insert5RowToolStripMenuItem,
            this.insert10RowToolStripMenuItem});
            this.rowToolStripMenuItem.Name = "rowToolStripMenuItem";
            this.rowToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.rowToolStripMenuItem.Text = "Row";
            // 
            // insert1RowToolStripMenuItem
            // 
            this.insert1RowToolStripMenuItem.Name = "insert1RowToolStripMenuItem";
            this.insert1RowToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.insert1RowToolStripMenuItem.Text = "Insert 1 Row";
            this.insert1RowToolStripMenuItem.Click += new System.EventHandler(this.insert1RowToolStripMenuItem_Click);
            // 
            // insert5RowToolStripMenuItem
            // 
            this.insert5RowToolStripMenuItem.Name = "insert5RowToolStripMenuItem";
            this.insert5RowToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.insert5RowToolStripMenuItem.Text = "Insert 5 Row";
            this.insert5RowToolStripMenuItem.Click += new System.EventHandler(this.insert5RowToolStripMenuItem_Click);
            // 
            // insert10RowToolStripMenuItem
            // 
            this.insert10RowToolStripMenuItem.Name = "insert10RowToolStripMenuItem";
            this.insert10RowToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.insert10RowToolStripMenuItem.Text = "Insert 10 Row";
            this.insert10RowToolStripMenuItem.Click += new System.EventHandler(this.insert10RowToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteColumnToolStripMenuItem,
            this.renameColumnToolStripMenuItem,
            this.configToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(155, 70);
            // 
            // deleteColumnToolStripMenuItem
            // 
            this.deleteColumnToolStripMenuItem.Name = "deleteColumnToolStripMenuItem";
            this.deleteColumnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteColumnToolStripMenuItem.Text = "Delete Column";
            this.deleteColumnToolStripMenuItem.Click += new System.EventHandler(this.deleteColumnToolStripMenuItem_Click);
            // 
            // renameColumnToolStripMenuItem
            // 
            this.renameColumnToolStripMenuItem.Name = "renameColumnToolStripMenuItem";
            this.renameColumnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.renameColumnToolStripMenuItem.Text = "Rename Column";
            this.renameColumnToolStripMenuItem.Click += new System.EventHandler(this.renameColumnToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configToolStripMenuItem.Text = "Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 218);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormTable";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destroyTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insert1RowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insert5RowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insert10RowToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem deleteColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
    }
}