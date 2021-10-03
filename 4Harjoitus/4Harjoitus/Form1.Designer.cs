
namespace _4Harjoitus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ValitsePVM = new System.Windows.Forms.DateTimePicker();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.VuosiLB = new System.Windows.Forms.Label();
            this.KuukausiLB = new System.Windows.Forms.Label();
            this.PaivinaLB = new System.Windows.Forms.Label();
            this.TunteinaLB = new System.Windows.Forms.Label();
            this.MinuuttiLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValitsePVM
            // 
            this.ValitsePVM.Location = new System.Drawing.Point(104, 102);
            this.ValitsePVM.Name = "ValitsePVM";
            this.ValitsePVM.Size = new System.Drawing.Size(200, 23);
            this.ValitsePVM.TabIndex = 0;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Location = new System.Drawing.Point(440, 102);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(75, 23);
            this.LaskeBT.TabIndex = 1;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // VuosiLB
            // 
            this.VuosiLB.AutoSize = true;
            this.VuosiLB.Location = new System.Drawing.Point(104, 128);
            this.VuosiLB.Name = "VuosiLB";
            this.VuosiLB.Size = new System.Drawing.Size(38, 15);
            this.VuosiLB.TabIndex = 2;
            this.VuosiLB.Text = "label1";
            this.VuosiLB.Visible = false;
            // 
            // KuukausiLB
            // 
            this.KuukausiLB.AutoSize = true;
            this.KuukausiLB.Location = new System.Drawing.Point(104, 143);
            this.KuukausiLB.Name = "KuukausiLB";
            this.KuukausiLB.Size = new System.Drawing.Size(38, 15);
            this.KuukausiLB.TabIndex = 3;
            this.KuukausiLB.Text = "label1";
            this.KuukausiLB.Visible = false;
            // 
            // PaivinaLB
            // 
            this.PaivinaLB.AutoSize = true;
            this.PaivinaLB.Location = new System.Drawing.Point(104, 158);
            this.PaivinaLB.Name = "PaivinaLB";
            this.PaivinaLB.Size = new System.Drawing.Size(38, 15);
            this.PaivinaLB.TabIndex = 4;
            this.PaivinaLB.Text = "label1";
            this.PaivinaLB.Visible = false;
            // 
            // TunteinaLB
            // 
            this.TunteinaLB.AutoSize = true;
            this.TunteinaLB.Location = new System.Drawing.Point(104, 173);
            this.TunteinaLB.Name = "TunteinaLB";
            this.TunteinaLB.Size = new System.Drawing.Size(38, 15);
            this.TunteinaLB.TabIndex = 5;
            this.TunteinaLB.Text = "label1";
            this.TunteinaLB.Visible = false;
            // 
            // MinuuttiLB
            // 
            this.MinuuttiLB.AutoSize = true;
            this.MinuuttiLB.Location = new System.Drawing.Point(104, 188);
            this.MinuuttiLB.Name = "MinuuttiLB";
            this.MinuuttiLB.Size = new System.Drawing.Size(38, 15);
            this.MinuuttiLB.TabIndex = 6;
            this.MinuuttiLB.Text = "label1";
            this.MinuuttiLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MinuuttiLB);
            this.Controls.Add(this.TunteinaLB);
            this.Controls.Add(this.PaivinaLB);
            this.Controls.Add(this.KuukausiLB);
            this.Controls.Add(this.VuosiLB);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.ValitsePVM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ValitsePVM;
        private System.Windows.Forms.Button LaskeBT;
        private System.Windows.Forms.Label VuosiLB;
        private System.Windows.Forms.Label KuukausiLB;
        private System.Windows.Forms.Label PaivinaLB;
        private System.Windows.Forms.Label TunteinaLB;
        private System.Windows.Forms.Label MinuuttiLB;
    }
}

