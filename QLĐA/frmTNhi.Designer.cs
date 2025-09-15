namespace QLĐA
{
    partial class frmTNhi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            this.btnend = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(248, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC 2";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(65, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "a=";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(119, 124);
            this.txta.Multiline = true;
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(126, 44);
            this.txta.TabIndex = 2;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(399, 127);
            this.txtb.Multiline = true;
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(134, 41);
            this.txtb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(336, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "b=";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(673, 127);
            this.txtc.Multiline = true;
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(140, 41);
            this.txtc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(610, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "c=";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkq.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblkq.Location = new System.Drawing.Point(150, 294);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(95, 29);
            this.lblkq.TabIndex = 7;
            this.lblkq.Text = "Kết quả";
            this.lblkq.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnend
            // 
            this.btnend.BackColor = System.Drawing.Color.PeachPuff;
            this.btnend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnend.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnend.Location = new System.Drawing.Point(768, 423);
            this.btnend.Name = "btnend";
            this.btnend.Size = new System.Drawing.Size(116, 32);
            this.btnend.TabIndex = 8;
            this.btnend.Text = "Kết Thúc";
            this.btnend.UseVisualStyleBackColor = false;
            this.btnend.Click += new System.EventHandler(this.btnend_Click);
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.MistyRose;
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnok.Location = new System.Drawing.Point(433, 217);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(81, 34);
            this.btnok.TabIndex = 9;
            this.btnok.Text = "Giải";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // frmTNhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 486);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btnend);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTNhi";
            this.Text = "frmTNhi";
            this.Load += new System.EventHandler(this.frmTNhi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.Button btnend;
        private System.Windows.Forms.Button btnok;
    }
}