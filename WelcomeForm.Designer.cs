namespace TarotFalApp
{
    partial class WelcomeForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnClassic = new System.Windows.Forms.Button();
            this.btnFairy = new System.Windows.Forms.Button();
            this.picDeckClassic = new System.Windows.Forms.PictureBox();
            this.picDeckFairy = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectedDeck = new System.Windows.Forms.Label();
            // mainContainer'ı artık dışarıda tanımladığımız için 'this' ile çağırıyoruz
            this.mainContainer = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.picDeckClassic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeckFairy)).BeginInit();
            this.SuspendLayout();

            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.Transparent;
            this.mainContainer.Size = new System.Drawing.Size(800, 500);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Controls.Add(this.lblTitle);
            this.mainContainer.Controls.Add(this.label1);
            this.mainContainer.Controls.Add(this.picDeckClassic);
            this.mainContainer.Controls.Add(this.picDeckFairy);
            this.mainContainer.Controls.Add(this.btnClassic);
            this.mainContainer.Controls.Add(this.btnFairy);

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 24F);
            this.lblTitle.ForeColor = System.Drawing.Color.Bisque;
            this.lblTitle.Location = new System.Drawing.Point(0, 20);
            this.lblTitle.Size = new System.Drawing.Size(800, 50);
            this.lblTitle.Text = "✩₊˚.⋆☾⋆⁺₊✧ MYSTIQUE TAROT ✩₊˚.⋆☾⋆⁺₊✧";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = false;
            this.label1.Size = new System.Drawing.Size(800, 40);
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 20F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(0, 85);
            this.label1.Text = "Welcome, please choose a deck for this mystique experience.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // Kartlar ve Butonlar (Senin koordinatlarını korudum)
            this.picDeckClassic.Image = global::TarotFalApp.Properties.Resources._1_;
            this.picDeckClassic.Location = new System.Drawing.Point(150, 150);
            this.picDeckClassic.Size = new System.Drawing.Size(180, 270);
            this.picDeckClassic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.picDeckFairy.Image = global::TarotFalApp.Properties.Resources.back_2_;
            this.picDeckFairy.Location = new System.Drawing.Point(470, 150);
            this.picDeckFairy.Size = new System.Drawing.Size(180, 270);
            this.picDeckFairy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.btnClassic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassic.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.btnClassic.ForeColor = System.Drawing.Color.Bisque;
            this.btnClassic.Location = new System.Drawing.Point(150, 435);
            this.btnClassic.UseVisualStyleBackColor = false;
            this.btnClassic.Size = new System.Drawing.Size(180, 40);
            this.btnClassic.Text = "Classic Tarot";
            this.btnClassic.Click += new System.EventHandler(this.btnClassic_Click);

            this.btnFairy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFairy.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.btnFairy.UseVisualStyleBackColor = false;
            this.btnFairy.ForeColor = System.Drawing.Color.Bisque;
            this.btnFairy.Location = new System.Drawing.Point(470, 435);
            this.btnFairy.Size = new System.Drawing.Size(180, 40);
            this.btnFairy.Text = "Fairy Tarot";
            this.btnFairy.Click += new System.EventHandler(this.btnFairy_Click);

            // WelcomeForm
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.mainContainer); // Paneli forma ekliyoruz
            this.BackgroundImage = global::TarotFalApp.Properties.Resources.WhatsApp_Image_2025_12_22_at_15_56_58;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            ((System.ComponentModel.ISupportInitialize)(this.picDeckClassic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeckFairy)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Buraya mainContainer'ı ekledik
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Button btnClassic;
        private System.Windows.Forms.Button btnFairy;
        private System.Windows.Forms.PictureBox picDeckClassic;
        private System.Windows.Forms.PictureBox picDeckFairy;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelectedDeck;
    }
}