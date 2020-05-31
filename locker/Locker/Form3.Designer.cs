namespace Locker
{
    partial class LockerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockerView));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPassChange = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.btnNewDir = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnMoveFile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Black;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.FullRowSelect = true;
            this.treeView1.HideSelection = false;
            this.treeView1.ItemHeight = 25;
            this.treeView1.LineColor = System.Drawing.Color.Purple;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(679, 561);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick_1);
            this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.btnMoveFile);
            this.panel1.Controls.Add(this.btnPassChange);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.btnEmpty);
            this.panel1.Controls.Add(this.btnNewDir);
            this.panel1.Controls.Add(this.btnCollapse);
            this.panel1.Controls.Add(this.btnExpand);
            this.panel1.Controls.Add(this.btnGetFile);
            this.panel1.Controls.Add(this.btnAddFile);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnRename);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(679, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 561);
            this.panel1.TabIndex = 2;
            // 
            // btnPassChange
            // 
            this.btnPassChange.BackColor = System.Drawing.Color.Black;
            this.btnPassChange.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPassChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnPassChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnPassChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassChange.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassChange.ForeColor = System.Drawing.Color.White;
            this.btnPassChange.Location = new System.Drawing.Point(2, 441);
            this.btnPassChange.Name = "btnPassChange";
            this.btnPassChange.Size = new System.Drawing.Size(100, 30);
            this.btnPassChange.TabIndex = 23;
            this.btnPassChange.Text = "Password";
            this.btnPassChange.UseVisualStyleBackColor = false;
            this.btnPassChange.Click += new System.EventHandler(this.btnPassChange_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Black;
            this.btnAbout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(2, 513);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 30);
            this.btnAbout.TabIndex = 25;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Black;
            this.btnHelp.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(2, 477);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 30);
            this.btnHelp.TabIndex = 24;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.BackColor = System.Drawing.Color.Black;
            this.btnEmpty.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEmpty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnEmpty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpty.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpty.ForeColor = System.Drawing.Color.White;
            this.btnEmpty.Location = new System.Drawing.Point(2, 405);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(100, 30);
            this.btnEmpty.TabIndex = 22;
            this.btnEmpty.Text = "Empty";
            this.btnEmpty.UseVisualStyleBackColor = false;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // btnNewDir
            // 
            this.btnNewDir.BackColor = System.Drawing.Color.Black;
            this.btnNewDir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNewDir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnNewDir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnNewDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDir.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDir.ForeColor = System.Drawing.Color.White;
            this.btnNewDir.Location = new System.Drawing.Point(2, 212);
            this.btnNewDir.Name = "btnNewDir";
            this.btnNewDir.Size = new System.Drawing.Size(100, 30);
            this.btnNewDir.TabIndex = 18;
            this.btnNewDir.Text = "New Folder";
            this.btnNewDir.UseVisualStyleBackColor = false;
            this.btnNewDir.Click += new System.EventHandler(this.btnNewDir_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.Color.Black;
            this.btnCollapse.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCollapse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnCollapse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollapse.ForeColor = System.Drawing.Color.White;
            this.btnCollapse.Location = new System.Drawing.Point(2, 369);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(100, 30);
            this.btnCollapse.TabIndex = 21;
            this.btnCollapse.Text = "Collapse All";
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.Color.Black;
            this.btnExpand.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExpand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnExpand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpand.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpand.ForeColor = System.Drawing.Color.White;
            this.btnExpand.Location = new System.Drawing.Point(2, 333);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(100, 30);
            this.btnExpand.TabIndex = 20;
            this.btnExpand.Text = "Expand All";
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnGetFile
            // 
            this.btnGetFile.BackColor = System.Drawing.Color.Black;
            this.btnGetFile.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGetFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnGetFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnGetFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetFile.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetFile.ForeColor = System.Drawing.Color.White;
            this.btnGetFile.Location = new System.Drawing.Point(2, 140);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(100, 30);
            this.btnGetFile.TabIndex = 16;
            this.btnGetFile.Text = "Save File";
            this.btnGetFile.UseVisualStyleBackColor = false;
            this.btnGetFile.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.BackColor = System.Drawing.Color.Black;
            this.btnAddFile.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnAddFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFile.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFile.ForeColor = System.Drawing.Color.White;
            this.btnAddFile.Location = new System.Drawing.Point(2, 297);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(100, 30);
            this.btnAddFile.TabIndex = 19;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = false;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(2, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRename
            // 
            this.btnRename.BackColor = System.Drawing.Color.Black;
            this.btnRename.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRename.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnRename.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRename.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.ForeColor = System.Drawing.Color.White;
            this.btnRename.Location = new System.Drawing.Point(2, 68);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(100, 30);
            this.btnRename.TabIndex = 14;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = false;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Black;
            this.btnOpen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(2, 32);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 30);
            this.btnOpen.TabIndex = 13;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Locker Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Options";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Select a file to add to Locker...";
            // 
            // btnMoveFile
            // 
            this.btnMoveFile.BackColor = System.Drawing.Color.Black;
            this.btnMoveFile.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMoveFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnMoveFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnMoveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveFile.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveFile.ForeColor = System.Drawing.Color.White;
            this.btnMoveFile.Location = new System.Drawing.Point(2, 176);
            this.btnMoveFile.Name = "btnMoveFile";
            this.btnMoveFile.Size = new System.Drawing.Size(100, 30);
            this.btnMoveFile.TabIndex = 17;
            this.btnMoveFile.Text = "Move To";
            this.btnMoveFile.UseVisualStyleBackColor = false;
            this.btnMoveFile.Click += new System.EventHandler(this.btnMoveFile_Click);
            // 
            // LockerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 417);
            this.Name = "LockerView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Locker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LockerView_FormClosed);
            this.Load += new System.EventHandler(this.LockerView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnGetFile;
        private System.Windows.Forms.Button btnPassChange;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnNewDir;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnMoveFile;
    }
}