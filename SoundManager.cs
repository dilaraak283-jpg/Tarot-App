using System;
using System.IO;
using System.Windows.Media; // PresentationCore ve WindowsBase referansları gereklidir

namespace TarotFalApp
{
    public static class SoundManager
    {
        // İki ayrı kanal: Biri müzik, diğeri efekt için
        private static MediaPlayer bgMusic = new MediaPlayer();
        private static MediaPlayer effectPlayer = new MediaPlayer();

        public static bool MusicEnabled { get; set; } = true;
        public static bool EffectsEnabled { get; set; } = true;

        static SoundManager()
        {
            // Müzik bittiğinde otomatik baştan başlaması için (Loop)
            bgMusic.MediaEnded += (s, e) => {
                bgMusic.Position = TimeSpan.Zero;
                bgMusic.Play();
            };
        }

        public static void PlayBackgroundMusic()
        {
            try
            {
                if (bgMusic.Source == null)
                {
                    // Müziği Resources'tan alıp fiziksel bir dosyaya çıkartıyoruz
                    string musicPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mystic_music.wav");

                    if (!File.Exists(musicPath))
                    {
                        using (var stream = Properties.Resources.mystic_music)
                        {
                            byte[] buffer = new byte[stream.Length];
                            stream.Read(buffer, 0, buffer.Length);
                            File.WriteAllBytes(musicPath, buffer);
                        }
                    }
                    bgMusic.Open(new Uri(musicPath));
                }

                if (MusicEnabled) bgMusic.Play();
            }
            catch { /* Hata bastırma */ }
        }

        public static void StopBackgroundMusic()
        {
            bgMusic.Pause(); // Tamamen durdurmak yerine duraklatıyoruz
        }

        public static void PlayClickSound()
        {
            if (!EffectsEnabled) return;

            try
            {
                // Efekt kanalını bağımsız yönetiyoruz
                string effectPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "click_effect.wav");

                if (!File.Exists(effectPath))
                {
                    using (var stream = Properties.Resources.click_effect)
                    {
                        byte[] buffer = new byte[stream.Length];
                        stream.Read(buffer, 0, buffer.Length);
                        File.WriteAllBytes(effectPath, buffer);
                    }
                }

                // Efekti her seferinde yeniden yüklemek arka plan kanalını bozmaz
                effectPlayer.Open(new Uri(effectPath));
                effectPlayer.Play();
            }
            catch { /* Hata bastırma */ }
        }
    }
}