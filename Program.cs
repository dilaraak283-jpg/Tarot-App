using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarotFalApp
{
    internal static class Program
    {
        
        /// Uygulamanın ana girdi noktası.
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // --- SES ENTEGRASYONU ---
            // Uygulama henüz hiç form açılmadan arka plan müziğini başlatıyoruz.
            SoundManager.PlayBackgroundMusic();

            // Ana formu başlat
            Application.Run(new WelcomeForm());
        }
    }
}