
namespace CarDealer
{
    partial class CikisYapFrm
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
            this.lblCikis = new System.Windows.Forms.Label();
            this.btnEvet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikis.ForeColor = System.Drawing.Color.White;
            this.lblCikis.Location = new System.Drawing.Point(41, 42);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(260, 54);
            this.lblCikis.TabIndex = 0;
            this.lblCikis.Text = "Çıkış yapmak istediğine\r\nemin misin?";
            this.lblCikis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEvet
            // 
            this.btnEvet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(96)))), ((int)(((byte)(254)))));
            this.btnEvet.FlatAppearance.BorderSize = 2;
            this.btnEvet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvet.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEvet.ForeColor = System.Drawing.Color.White;
            this.btnEvet.Location = new System.Drawing.Point(46, 126);
            this.btnEvet.Name = "btnEvet";
            this.btnEvet.Size = new System.Drawing.Size(94, 51);
            this.btnEvet.TabIndex = 1;
            this.btnEvet.Text = "Evet";
            this.btnEvet.UseVisualStyleBackColor = false;
            this.btnEvet.Click += new System.EventHandler(this.btnEvet_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(96)))), ((int)(((byte)(254)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(186, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hayır";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CikisYapFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(96)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(336, 205);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEvet);
            this.Controls.Add(this.lblCikis);
            this.Name = "CikisYapFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CikisYapFrm";
            this.Load += new System.EventHandler(this.CikisYapFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Button btnEvet;
        private System.Windows.Forms.Button button1;
    }
}