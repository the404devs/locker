namespace Locker
{
    partial class PassChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassChange));
            this.btnDone = new System.Windows.Forms.Button();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.AutoSize = true;
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(62, 112);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(61, 33);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // txtOld
            // 
            this.txtOld.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtOld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOld.ForeColor = System.Drawing.Color.White;
            this.txtOld.Location = new System.Drawing.Point(7, 27);
            this.txtOld.Name = "txtOld";
            this.txtOld.PasswordChar = '●';
            this.txtOld.Size = new System.Drawing.Size(171, 20);
            this.txtOld.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter the old password...";
            // 
            // txtNew
            // 
            this.txtNew.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNew.ForeColor = System.Drawing.Color.White;
            this.txtNew.Location = new System.Drawing.Point(7, 77);
            this.txtNew.Name = "txtNew";
            this.txtNew.PasswordChar = '●';
            this.txtNew.Size = new System.Drawing.Size(171, 20);
            this.txtNew.TabIndex = 11;
            this.txtNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNew_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter the new password...";
            // 
            // PassChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtOld);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PassChange";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Change Password...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        public System.Windows.Forms.TextBox txtOld;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNew;
        public System.Windows.Forms.Label label2;
    }
}