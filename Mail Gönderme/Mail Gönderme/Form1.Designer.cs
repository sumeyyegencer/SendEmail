
namespace Mail_Gönderme
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
            this.btn_mailGonder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_mailGonder
            // 
            this.btn_mailGonder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_mailGonder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mailGonder.Location = new System.Drawing.Point(315, 383);
            this.btn_mailGonder.Name = "btn_mailGonder";
            this.btn_mailGonder.Size = new System.Drawing.Size(160, 46);
            this.btn_mailGonder.TabIndex = 0;
            this.btn_mailGonder.Text = "Mail Gönder";
            this.btn_mailGonder.UseVisualStyleBackColor = true;
            this.btn_mailGonder.UseWaitCursor = true;
            this.btn_mailGonder.Click += new System.EventHandler(this.btn_mailGonder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(102, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(89, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlık:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(45, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mesaj İçeriği:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(190, 28);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(277, 22);
            this.txtTo.TabIndex = 4;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(190, 86);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(277, 22);
            this.txtSubject.TabIndex = 5;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(190, 150);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(277, 159);
            this.txtMessage.TabIndex = 6;
            this.txtMessage.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.txtSubject);
            this.groupBox1.Controls.Add(this.txtTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(96, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 330);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_mailGonder);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Gönderme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mailGonder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

