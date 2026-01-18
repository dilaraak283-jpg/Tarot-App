using System;
using System.Drawing;
using System.Windows.Forms;

namespace TarotFalApp
{
    public class BaseForm : Form
    {
        // Ayarlar panelini ve butonunu her formun kendi içinde yönetebilmesi için tanımlıyoruz
        private Panel pnlSettings;
        private Button btnSettingsToggle;          //aç-kapa

       
        public virtual void ReturnToHome()
        {
            SoundManager.PlayClickSound();

            // Standart davranış: Mevcut formu gizle ve WelcomeForm'u aç.
            WelcomeForm welcome = new WelcomeForm();
            welcome.Show();
            this.Hide();
        }

        // --- AYARLAR ---
        protected void AddSettingsMenu()
        {
            // 1. Ayarları Açma/Kapama Butonu (Dişli Çark)
            btnSettingsToggle = new Button
            {
                Text = "⚙",
                Size = new Size(50, 50),
                Location = new Point(this.ClientSize.Width - 60, 15),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Bisque,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                BackColor = Color.FromArgb(120, 30, 0, 0),
                Cursor = Cursors.Hand
            };
            btnSettingsToggle.FlatAppearance.BorderSize = 1;
            btnSettingsToggle.FlatAppearance.BorderColor = Color.Bisque;

            btnSettingsToggle.Click += (s, e) => {
                SoundManager.PlayClickSound();
                if (pnlSettings != null)
                {
                    pnlSettings.Visible = !pnlSettings.Visible; // Paneli aç-kapat
                    pnlSettings.BringToFront();
                }
            };

            // 2. Ayarlar Paneli (Başlangıçta Gizli)
            pnlSettings = new Panel
            {
                Size = new Size(230, 170),
                Location = new Point(this.ClientSize.Width - 245, 65),
                BackColor = Color.FromArgb(230, 45, 0, 0), 
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false // Kullanıcı dişli çarka basana kadar gizli
            };

            // Panel İçeriğini Oluştur (Müzik, Efekt ve Ana Sayfa Butonları)
            BuildSettingsPanelContent();

            // Kontrolleri forma ekle
            this.Controls.Add(btnSettingsToggle);
            this.Controls.Add(pnlSettings);

            // Her zaman en üstte görünmelerini sağla
            btnSettingsToggle.BringToFront();
            pnlSettings.BringToFront();
        }

        private void BuildSettingsPanelContent()
        {
            // Müzik Aç/Kapat Butonu
            Button btnToggleMusic = CreateSettingsButton(SoundManager.MusicEnabled ? " Müzik: AÇIK" : " Müzik: KAPALI", 10);
            btnToggleMusic.Click += (s, e) => {
                SoundManager.MusicEnabled = !SoundManager.MusicEnabled;
                if (SoundManager.MusicEnabled) SoundManager.PlayBackgroundMusic();
                else SoundManager.StopBackgroundMusic();

                btnToggleMusic.Text = SoundManager.MusicEnabled ? " Müzik: AÇIK" : " Müzik: KAPALI";
                SoundManager.PlayClickSound();
            };

            // Ses Efekti Aç/Kapat Butonu
            Button btnToggleEffects = CreateSettingsButton(SoundManager.EffectsEnabled ? " Efekt: AÇIK" : " Efekt: KAPALI", 60);
            btnToggleEffects.Click += (s, e) => {
                SoundManager.EffectsEnabled = !SoundManager.EffectsEnabled;
                btnToggleEffects.Text = SoundManager.EffectsEnabled ? " Efekt: AÇIK" : " Efekt: KAPALI";
                SoundManager.PlayClickSound();
            };

            // Ana Sayfaya Dön Butonu
            Button btnHome = CreateSettingsButton(" ANA SAYFAYA DÖN", 110);
            btnHome.ForeColor = Color.Gold;
            btnHome.Click += (s, e) => {
                pnlSettings.Visible = false; // Menüyü kapat
                this.ReturnToHome(); // Polimorfik çağrı
            };

            pnlSettings.Controls.Add(btnToggleMusic);
            pnlSettings.Controls.Add(btnToggleEffects);
            pnlSettings.Controls.Add(btnHome);
        }

        // Ortak Buton Tasarımı
        private Button CreateSettingsButton(string text, int y)
        {
            return new Button
            {
                Text = text,
                Location = new Point(15, y),
                Size = new Size(200, 40),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Bisque,
                Font = new Font("Georgia", 9, FontStyle.Bold),
                Cursor = Cursors.Hand,
                BackColor = Color.FromArgb(50, 0, 0, 0)
            };
        }
    }
}