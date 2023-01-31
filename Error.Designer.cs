using System.Windows.Forms;

namespace MarioLiver
{
    partial class Error
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error));
            this.Face = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Wahoo = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Face)).BeginInit();
            this.SuspendLayout();
            // 
            // Face
            // 
            this.Face.BackgroundImage = global::MarioLiver.Properties.Resources.normal;
            this.Face.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Face.Location = new System.Drawing.Point(10, 17);
            this.Face.Name = "Face";
            this.Face.Size = new System.Drawing.Size(141, 143);
            this.Face.TabIndex = 0;
            this.Face.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(157, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 86);
            this.label1.TabIndex = 1;
            this.label1.Text = "10 minutes until Mario steals your liver!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wahoo
            // 
            this.Wahoo.BackColor = System.Drawing.Color.Lime;
            this.Wahoo.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.Wahoo.ForeColor = System.Drawing.Color.Black;
            this.Wahoo.Location = new System.Drawing.Point(157, 106);
            this.Wahoo.Name = "Wahoo";
            this.Wahoo.Size = new System.Drawing.Size(203, 55);
            this.Wahoo.TabIndex = 2;
            this.Wahoo.Text = "Wahoo!";
            this.Wahoo.UseVisualStyleBackColor = false;
            this.Wahoo.Click += new System.EventHandler(this.Wahoo_Click);
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.BackColor = System.Drawing.Color.Red;
            this.No.Font = new System.Drawing.Font("Segoe UI", 27F);
            this.No.ForeColor = System.Drawing.Color.Black;
            this.No.Location = new System.Drawing.Point(372, 106);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(202, 58);
            this.No.TabIndex = 3;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = false;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(585, 178);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Wahoo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Face);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Error";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mario Error";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Error_FormClosing);
            this.Load += new System.EventHandler(this.Error_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Face)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Face;
        private Label label1;
        private Button Wahoo;
        private Button No;
    }
}