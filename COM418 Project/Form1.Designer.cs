namespace COM418_Project
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFriendsRow = new System.Windows.Forms.Label();
            this.lblFriendsColumn = new System.Windows.Forms.Label();
            this.lblPotentialFriendsRow = new System.Windows.Forms.Label();
            this.lblPotentialFriendsColumn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click to Generate Friends List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblFriendsRow
            // 
            this.lblFriendsRow.AutoSize = true;
            this.lblFriendsRow.Location = new System.Drawing.Point(31, 118);
            this.lblFriendsRow.Name = "lblFriendsRow";
            this.lblFriendsRow.Size = new System.Drawing.Size(0, 13);
            this.lblFriendsRow.TabIndex = 2;
            // 
            // lblFriendsColumn
            // 
            this.lblFriendsColumn.AutoSize = true;
            this.lblFriendsColumn.Location = new System.Drawing.Point(228, 118);
            this.lblFriendsColumn.Name = "lblFriendsColumn";
            this.lblFriendsColumn.Size = new System.Drawing.Size(0, 13);
            this.lblFriendsColumn.TabIndex = 3;
            // 
            // lblPotentialFriendsRow
            // 
            this.lblPotentialFriendsRow.AutoSize = true;
            this.lblPotentialFriendsRow.Location = new System.Drawing.Point(406, 118);
            this.lblPotentialFriendsRow.Name = "lblPotentialFriendsRow";
            this.lblPotentialFriendsRow.Size = new System.Drawing.Size(0, 13);
            this.lblPotentialFriendsRow.TabIndex = 4;
            // 
            // lblPotentialFriendsColumn
            // 
            this.lblPotentialFriendsColumn.AutoSize = true;
            this.lblPotentialFriendsColumn.Location = new System.Drawing.Point(631, 118);
            this.lblPotentialFriendsColumn.Name = "lblPotentialFriendsColumn";
            this.lblPotentialFriendsColumn.Size = new System.Drawing.Size(0, 13);
            this.lblPotentialFriendsColumn.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Friend By Row";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Friend By Column";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Potential Friend By Row";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Potential Friend By Column";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPotentialFriendsColumn);
            this.Controls.Add(this.lblPotentialFriendsRow);
            this.Controls.Add(this.lblFriendsColumn);
            this.Controls.Add(this.lblFriendsRow);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFriendsRow;
        private System.Windows.Forms.Label lblFriendsColumn;
        private System.Windows.Forms.Label lblPotentialFriendsRow;
        private System.Windows.Forms.Label lblPotentialFriendsColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}