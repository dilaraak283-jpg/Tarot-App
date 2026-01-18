using System;
using System.Drawing;
using System.Windows.Forms;

namespace TarotFalApp
{
    // Kalıtım: Artık BaseForm'dan türüyor
    public partial class WelcomeForm : BaseForm
    {
        public WelcomeForm()
        {
            InitializeComponent();
            ApplyProfessionalStyles();

            this.DoubleBuffered = true;

            // Form yüklendiğinde ayarlar butonunu ve merkezi yerleşimi ayarla
            this.Load += (s, e) => {
                CenterMyUI();
                AddSettingsMenu();
            };

            this.Resize += (s, e) => CenterMyUI();
        }

        // POLİMORFİZM: BaseForm'daki metodu override ederek bu sayfaya özel kılıyoruz
        public override void ReturnToHome()
        {
            SoundManager.PlayClickSound();
            MessageBox.Show("Zaten mistik yolculuğun başlangıç noktasındasınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CenterMyUI()
        {
            if (mainContainer != null)
            {
                mainContainer.Left = (this.ClientSize.Width - mainContainer.Width) / 2;
                mainContainer.Top = (this.ClientSize.Height - mainContainer.Height) / 2;
            }
        }

        private void ApplyProfessionalStyles()
        {
            Button[] buttons = { btnClassic, btnFairy };

            foreach (var btn in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.UseVisualStyleBackColor = false;
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.Bisque;
                btn.Cursor = Cursors.Hand;
                btn.Font = new Font("Georgia", 13F, FontStyle.Bold);
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = Color.Bisque;

                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(130, 64, 0, 0);
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 64, 0, 0);

                btn.MouseEnter += (s, e) => { btn.ForeColor = Color.White; };
                btn.MouseLeave += (s, e) => { btn.ForeColor = Color.Bisque; };
            }
        }

        private void btnClassic_Click(object sender, EventArgs e)
        {
            SoundManager.PlayClickSound();
            SelectionForm sel = new SelectionForm("Classic");
            sel.Show();
            this.Hide();
        }

        private void btnFairy_Click(object sender, EventArgs e)
        {
            SoundManager.PlayClickSound();
            SelectionForm sel = new SelectionForm("Fairy");
            sel.Show();
            this.Hide();
        }
    }
}