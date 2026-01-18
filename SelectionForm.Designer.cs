namespace TarotFalApp
{
    partial class SelectionForm
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
            
            this.pnlMainFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();

            

            // pnlMainFlow (Scroll çubuğunu gizlemek için AutoScroll kapatıldı veya kontrol altına alındı)
            this.pnlMainFlow.Location = new System.Drawing.Point(50, 110);
            this.pnlMainFlow.Size = new System.Drawing.Size(650, 800);
            this.pnlMainFlow.AutoScroll = true; // İçerik taşarsa çalışsın
            this.pnlMainFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlMainFlow.WrapContents = false;
            this.pnlMainFlow.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0); // Scrollbar üstüne binmesin

            // btnBack
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0; // Geri butonunun çerçevesini sildik, daha şık
            this.btnBack.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.Bisque;
            this.btnBack.Text = "← BACK";
            this.btnBack.Location = new System.Drawing.Point(20, 15);
            this.btnBack.Size = new System.Drawing.Size(140, 45);
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;

            // SelectionForm
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.BackgroundImage = global::TarotFalApp.Properties.Resources.WhatsApp_Image_2025_12_22_at_15_56_58;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Text = "Mystique Tarot - Selection";
            this.ResumeLayout(false);
        }

        
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.FlowLayoutPanel pnlMainFlow;
        private System.Windows.Forms.Button btnBack;
    }
}