namespace ImageResize
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnDownscale = new System.Windows.Forms.Button();
            this.txtScaleFactor = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // btnLoadImage
            this.btnLoadImage.Location = new System.Drawing.Point(12, 12);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(75, 23);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);

            // btnDownscale
            this.btnDownscale.Location = new System.Drawing.Point(93, 12);
            this.btnDownscale.Name = "btnDownscale";
            this.btnDownscale.Size = new System.Drawing.Size(75, 23);
            this.btnDownscale.TabIndex = 1;
            this.btnDownscale.Text = "Downscale";
            this.btnDownscale.UseVisualStyleBackColor = true;
            this.btnDownscale.Click += new System.EventHandler(this.btnDownscale_Click);

            // txtScaleFactor
            this.txtScaleFactor.Location = new System.Drawing.Point(174, 14);
            this.txtScaleFactor.Name = "txtScaleFactor";
            this.txtScaleFactor.Size = new System.Drawing.Size(100, 20);
            this.txtScaleFactor.TabIndex = 2;

            // pictureBox1
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 507);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtScaleFactor);
            this.Controls.Add(this.btnDownscale);
            this.Controls.Add(this.btnLoadImage);
            this.Name = "Form1";
            this.Text = "Image Downscaler";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnDownscale;
        private System.Windows.Forms.TextBox txtScaleFactor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }

}
