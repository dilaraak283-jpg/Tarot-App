using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace TarotFalApp
{
    public partial class SelectionForm : BaseForm
    {
        private List<TarotCard> deck;
        private Random rnd = new Random();
        private string selectedCategory = "";
        private int targetCardCount = 0;

        private FlowLayoutPanel pnlAccordionMenu;
        private Label lblMainTitle;

        public SelectionForm(string deckType)
        {
            InitializeComponent();
            AppState.SelectedDeckType = deckType;

            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;
            this.AutoScroll = false;

            this.Resize += (s, e) => CenterUIElements();

            // Ayarlar menüsünü yükle
            this.Load += (s, e) => AddSettingsMenu();

            InitSelectionUI();
        }

        private void InitSelectionUI()
        {
            this.Controls.Clear();
            this.AutoScroll = false;

            // Sayfa temizlendiği için ayarları tekrar ekle
            AddSettingsMenu();

            lblMainTitle = new Label();
            lblMainTitle.Text = "☆ SELECT CATEGORY ☆";
            lblMainTitle.Font = new Font("Constantia", 26, FontStyle.Bold);
            lblMainTitle.ForeColor = Color.Bisque;
            lblMainTitle.BackColor = Color.Transparent;
            lblMainTitle.AutoSize = true;
            this.Controls.Add(lblMainTitle);

            pnlAccordionMenu = new FlowLayoutPanel();
            pnlAccordionMenu.FlowDirection = FlowDirection.TopDown;
            pnlAccordionMenu.WrapContents = false;
            pnlAccordionMenu.AutoSize = true;
            pnlAccordionMenu.BackColor = Color.Transparent;
            this.Controls.Add(pnlAccordionMenu);

            BuildAccordionMenu();
            CenterUIElements();
        }

        private void CenterUIElements()
        {
            if (pnlAccordionMenu == null || lblMainTitle == null) return;
            lblMainTitle.Location = new Point((this.ClientSize.Width - lblMainTitle.Width) / 2, 60);
            pnlAccordionMenu.Location = new Point((this.ClientSize.Width - 500) / 2, lblMainTitle.Bottom + 40);
        }

        private void BuildAccordionMenu()
        {
            pnlAccordionMenu.Controls.Clear();
            string[] mainCats = { "Aşk", "Kariyer", "Genel" };

            foreach (string cat in mainCats)
            {
                Button btnMain = CreateMysticButton(cat, true);
                btnMain.Click += (s, e) => {
                    SoundManager.PlayClickSound();
                    selectedCategory = (selectedCategory == cat) ? "" : cat;
                    BuildAccordionMenu();
                    CenterUIElements();
                };
                pnlAccordionMenu.Controls.Add(btnMain);

                if (selectedCategory == cat)
                {
                    AddSubOptionsToAccordion(cat);
                }
            }
        }

        private void AddSubOptionsToAccordion(string cat)
        {
            string[] subs;
            if (cat == "Aşk") subs = new string[] { "Tek Kart - Tek Cevap", "Üç Kart", "İlişki Analizi (5 Kart)" };
            else if (cat == "Kariyer") subs = new string[] { "Yol Ayrımı (Tek Kart)", "Karar Açılımı (3 Kart)" };
            else subs = new string[] { "Öngörü (3 Kart)" };

            foreach (string opt in subs)
            {
                Button btnSub = CreateMysticButton(opt, false);
                btnSub.Click += (s, e) => {
                    SoundManager.PlayClickSound();
                    int count = opt.Contains("Tek") ? 1 : (opt.Contains("5") ? 5 : 3);
                    StartManualSelection(count);
                };
                pnlAccordionMenu.Controls.Add(btnSub);
            }
        }

        private Button CreateMysticButton(string text, bool isMain)
        {
            Button btn = new Button();
            btn.Text = (isMain ? "▲ " : "      ○ ") + text;
            btn.Size = new Size(500, isMain ? 70 : 50);
            btn.Margin = new Padding(0, 4, 0, 4);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.Bisque;
            btn.BackColor = Color.FromArgb(190, 50, 0, 0);
            btn.ForeColor = Color.Bisque;
            btn.Font = new Font("Constantia", isMain ? 16 : 12, FontStyle.Bold);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 70, 0, 0);
            return btn;
        }

        private void StartManualSelection(int count)
        {
            this.targetCardCount = count;
            AppState.SelectedCards.Clear();
            this.Controls.Clear();

            // Ayarlar menüsünü kart seçim ekranına ekle
            AddSettingsMenu();

            deck = Cardata.GetShuffledDeck();

            int cardsPerRow = 13;
            int startX = (this.ClientSize.Width - (13 * 95)) / 2;
            int startY = 120;

            for (int i = 0; i < 78; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Image = (AppState.SelectedDeckType == "Fairy") ? Properties.Resources.back_2_ : Properties.Resources._1_;
                pb.Size = new Size(80, 125);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;

                int row = i / cardsPerRow;
                int col = i % cardsPerRow;

                pb.Location = new Point(startX + (col * 95), startY + (row * 50));
                pb.Tag = deck[i];
                pb.Cursor = Cursors.Hand;
                pb.Click += ManualCard_Click;

                pb.MouseEnter += (s, e) => { if (pb.Enabled) pb.Top -= 10; };
                pb.MouseLeave += (s, e) => { if (pb.Enabled) pb.Top += 10; };

                this.Controls.Add(pb);
                pb.BringToFront();
            }
        }

        private void ManualCard_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (!pb.Enabled) return;

            if (AppState.SelectedCards.Count < targetCardCount)
            {
                SoundManager.PlayClickSound();
                TarotCard card = (TarotCard)pb.Tag;
                card.IsReversed = rnd.Next(2) == 0;
                AppState.SelectedCards.Add(card);
                pb.Enabled = false;

                object resObj = Properties.Resources.ResourceManager.GetObject(card.ImageName);
                if (resObj != null)
                {
                    Image img = (Image)resObj;
                    if (card.IsReversed) img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    pb.Width = 10;
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(50);
                    pb.Image = img;
                    pb.Width = 80;
                    pb.BackColor = Color.Gold;
                    pb.Padding = new Padding(2);
                }

                if (AppState.SelectedCards.Count == targetCardCount)
                {
                    Timer t = new Timer { Interval = 1200 };
                    t.Tick += (s, ev) => { t.Stop(); ShowReadingResults(); };
                    t.Start();
                }
            }
        }

        private void ShowReadingResults()
        {
            this.Controls.Clear();
            this.AutoScroll = true;
            AddSettingsMenu();

            Panel resultPnl = new Panel
            {
                Size = new Size(this.ClientSize.Width - 100, 1500),
                Location = new Point(50, 50),
                BackColor = Color.FromArgb(200, 45, 0, 0)
            };
            this.Controls.Add(resultPnl);

            int yOffset = 30;
            foreach (var card in AppState.SelectedCards)
            {
                PictureBox thumb = new PictureBox();
                object resObj = Properties.Resources.ResourceManager.GetObject(card.ImageName);
                if (resObj != null)
                {
                    Image img = (Image)resObj;
                    if (card.IsReversed) img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    thumb.Image = img;
                }
                thumb.Size = new Size(130, 200);
                thumb.SizeMode = PictureBoxSizeMode.StretchImage;
                thumb.Location = new Point(30, yOffset);
                resultPnl.Controls.Add(thumb);

                Label lblMeaning = new Label
                {
                    Text = $"【 {card.Name} - {(card.IsReversed ? "Ters" : "Düz")} 】\n\n{card.GetMeaning(selectedCategory)}",
                    ForeColor = Color.Bisque,
                    Font = new Font("Constantia", 14, FontStyle.Italic),
                    Size = new Size(resultPnl.Width - 250, 200),
                    Location = new Point(180, yOffset)
                };
                resultPnl.Controls.Add(lblMeaning);
                yOffset += 240;
            }

            Button btnRestart = new Button
            {
                Text = "Yeni Fal Bak",
                Size = new Size(200, 50),
                Location = new Point((resultPnl.Width - 200) / 2, yOffset + 50),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Gold,
                Cursor = Cursors.Hand
            };
            btnRestart.Click += (s, e) => { SoundManager.PlayClickSound(); InitSelectionUI(); };
            resultPnl.Controls.Add(btnRestart);
        }
    }
}