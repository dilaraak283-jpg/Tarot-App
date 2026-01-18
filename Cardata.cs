using System;
using System.Collections.Generic;

namespace TarotFalApp
{
    public static class Cardata
    {
        public static List<TarotCard> GetAllCards()
        {
            return new List<TarotCard>
            {
                // --- MAJOR ARCANA (BÜYÜK ARKANA) ---

                new TarotCard {
                    Id = 0, Name = "Mecnun (The Fool)", ImageName = "joker_deli_karti",
                    GeneralUpright = "Yeni bir yolculuk ve saf bir enerji kapıda. İç sesine güvenerek adım atma zamanı.",
                    GeneralReversed = "Dikkatsizce atılan adımlar sorun yaratabilir. Risk alırken iki kez düşünmelisin.",
                    LoveUpright = "Yeni ve heyecan verici bir ilişki başlayabilir. Spontane gelişmelere açık olmalısın.",
                    LoveReversed = "Bağlanma korkusu veya sorumsuzluk ilişkide gerginlik yaratabilir. Kararlılık gerekiyor.",
                    CareerUpright = "İş hayatında yaratıcı bir başlangıç veya yeni bir proje fırsatı. Cesur kararlar kazandırır.",
                    CareerReversed = "İş yerinde tecrübesizlikten kaynaklanan hatalar yapabilirsin. Aceleci davranmamalısın."
                },

                new TarotCard {
                    Id = 1, Name = "Büyücü (The Magician)", ImageName = "buyucu_karti",
                    GeneralUpright = "Tüm yeteneklerin parladığı bir dönemdesin. İstediklerini gerçekleştirmek için gerekli güce sahipsin.",
                    GeneralReversed = "Yeteneklerini yanlış yöne kanalize ediyor olabilirsin. Odaklanma sorunu yaşanıyor.",
                    LoveUpright = "Karizmanın yüksek olduğu bir dönem. Partnerinle aranda güçlü bir iletişim ve çekim oluşacak.",
                    LoveReversed = "Duygusal ilişkilerde manipülasyona dikkat etmelisin. Sözlerin yanlış anlaşılabilir.",
                    CareerUpright = "Yaratıcı zekan sayesinde iş yerinde dikkat çekeceksin. Yeni girişimler için en doğru zaman.",
                    CareerReversed = "Elindeki kaynakları verimli kullanamıyorsun. İş hayatında erteleme huyundan vazgeçmelisin."
                },
                new TarotCard {
                    Id = 2, Name = "Azize (The High Priestess)", ImageName = "azize_karti",
                    GeneralUpright = "Sezgilerinin çok güçlü olduğu bir dönem. Bilgi ve gizemler gün yüzüne çıkmak için seni bekliyor.",
                    GeneralReversed = "İç sesini duymakta zorlanıyorsun. Yüzeyel bilgilere aldanıp derinliği gözden kaçırabilirsin.",
                    LoveUpright = "İlişkide derin bir bağ ve sessiz bir anlayış hakim. Gizli bir aşk veya platonik hisler söz konusu olabilir.",
                    LoveReversed = "Partnerinle aranda sırlar veya iletişim kopuklukları olabilir. Duygularını netleştirmelisin.",
                    CareerUpright = "Stratejik düşünme ve gözlem yeteneğin kazandıracak. Bilgi birikimini kullanma zamanı.",
                    CareerReversed = "İş yerinde gizli gündemlere ve dedikodulara dikkat etmelisin. Yanlış kararlar almaya meyillisin."
                },

                new TarotCard {
                    Id = 3, Name = "İmparatoriçe (The Empress)", ImageName = "imparatorice_karti",
                    GeneralUpright = "Bolluk, bereket ve yaratıcılığın zirvesindesin. Doğurganlık ve büyüme enerjisi seni destekliyor.",
                    GeneralReversed = "Yaratıcılığın tıkanmış hissedebilirsin. Kendine ve çevrene karşı aşırı korumacı veya baskıcı olma.",
                    LoveUpright = "Sevgi dolu, besleyici ve huzurlu bir ilişki. Bir bebek haberi veya aile kurma fikri gündeme gelebilir.",
                    LoveReversed = "İlişkide duygusal boşluk veya aşırı bağımlılık sorunu. Öz bakımına ve kendi mutluluğuna odaklanmalısın.",
                    CareerUpright = "Projelerinin meyve verdiği, maddi kazancın arttığı bir dönem. Doğal liderlik yeteneklerin ön planda.",
                    CareerReversed = "İş hayatında finansal zorluklar veya verimsizlik yaşanabilir. Kaynaklarını daha dikkatli yönetmelisin."
                },

                new TarotCard {
                    Id = 4, Name = "İmparator (The Emperor)", ImageName = "imparator_karti",
                    GeneralUpright = "Otorite, disiplin ve yapı kurma zamanı. Mantığınla hareket ederek düzeni sağlayacaksın.",
                    GeneralReversed = "Aşırı kontrolcü veya esneklikten uzak tavırlar sorun yaratabilir. Gücünü kötüye kullanmamalısın.",
                    LoveUpright = "Güven veren, koruyucu ve sağlam temelleri olan bir ilişki. Partnerinle gelecek planları netleşiyor.",
                    LoveReversed = "İlişkide güç savaşları veya baskın karakter sorunu. Duygulara daha fazla yer açmalısın.",
                    CareerUpright = "Liderlik koltuğuna oturma veya önemli bir sorumluluk alma vakti. Disiplinli çalışman ödüllendirilecek.",
                    CareerReversed = "İş yerinde otorite figürleriyle çatışma yaşanabilir. Kurallara uymakta veya koymakta zorlanıyorsun."
                },

                new TarotCard {
                    Id = 5, Name = "Aziz (The Hierophant)", ImageName = "aziz_karti",
                    GeneralUpright = "Geleneklere bağlılık, ruhsal rehberlik ve öğrenme süreci. Toplumsal kurallara uyum sağlamalısın.",
                    GeneralReversed = "Sıra dışı yollar deneme isteği. Katı kurallara başkaldırı ve geleneklerden uzaklaşma söz konusu.",
                    LoveUpright = "Geleneksel bir birliktelik, söz veya nişan gibi resmi adımlar. Değer yargılarınızın uyumu önemli.",
                    LoveReversed = "İlişkide görüş ayrılıkları veya toplumsal baskı. Farklı bakış açılarına açık olmanız gerekiyor.",
                    CareerUpright = "Kurumsal başarı, bir mentordan destek alma veya eğitim süreci. İş ahlakın takdir toplayacak.",
                    CareerReversed = "İş yerinde eski moda yöntemlerle çatışma. Yenilikçi fikirlerin baskılanıyor olabilir."
                },

                new TarotCard {
                    Id = 6, Name = "Aşıklar (The Lovers)", ImageName = "asiklar_karti",
                    GeneralUpright = "Önemli bir seçim ve ruhsal uyum zamanı. Kalbinin ve mantığının ortak bir karara varması gerekiyor.",
                    GeneralReversed = "Kararsızlık ve içsel çatışma. Yanlış değerlere odaklanarak dengeyi bozuyor olabilirsin.",
                    LoveUpright = "Büyük bir tutku, ruh eşi bulma ve derin bağ. İlişkide en uyumlu ve mutlu dönemlerinden biri.",
                    LoveReversed = "Güven sorunları veya duygusal kopukluk. İlişkideki seçimlerini yeniden gözden geçirmelisin.",
                    CareerUpright = "Uyumlu iş ortaklıkları ve değerlerinle örtüşen bir kariyer yolu. Ekip çalışmasında başarı.",
                    CareerReversed = "İş yerinde fikir ayrılıkları ve yanlış ortaklıklar. Karar verirken duygularına yenilme."
                },

                new TarotCard {
                    Id = 7, Name = "Araba (The Chariot)", ImageName = "araba_karti",
                    GeneralUpright = "Azim ve iradeyle gelen zafer. Zorlukların üstesinden gelerek hedefine hızla ilerliyorsun.",
                    GeneralReversed = "Kontrol kaybı ve yön duygusunu yitirme. Öfke veya acelecilik planlarını bozabilir.",
                    LoveUpright = "İlişkideki engelleri birlikte aşma zamanı. Ortak bir hedefe doğru kararlılıkla ilerliyorsunuz.",
                    LoveReversed = "İlişkide rotanın belirsizleşmesi veya ego çatışmaları. Duygularınızı dizginlemeyi öğrenmelisiniz.",
                    CareerUpright = "Hırslı projelerde başarı, seyahatler veya iş yerinde büyük bir ilerleme. Disiplin kazandıracak.",
                    CareerReversed = "İş hayatında odaklanma sorunu ve başarısız girişimler. Gücünü boşa harcamamalısın."
                },

                new TarotCard {
                    Id = 8, Name = "Güç (Strength)", ImageName = "guc_karti_büyükarkana",
                    GeneralUpright = "İçsel güç, sabır ve şefkatle zorlukları yenme. Cesaretin kaba kuvvetten değil, ruhundan geliyor.",
                    GeneralReversed = "Kendine güvensizlik ve korkulara teslim olma. İçsel dengeni kurmakta zorlanıyorsun.",
                    LoveUpright = "Tutkulu ama şefkatli bir ilişki. Partnerini sabırla anlayarak bağı güçlendiriyorsun.",
                    LoveReversed = "İlişkide dürtüsel çıkışlar veya sabırsızlık. Duygularını kontrol altında tutmalısın.",
                    CareerUpright = "Zorlu projelerin altından kalkacak enerjiye sahipsin. Kararlılığın iş yerinde saygı uyandıracak.",
                    CareerReversed = "Özgüven eksikliği nedeniyle fırsatları kaçırabilirsin. Yeteneklerine daha fazla inanmalısın."
                },

                new TarotCard {
                    Id = 9, Name = "Ermiş (The Hermit)", ImageName = "ermis_karti_büyükarkana",
                    GeneralUpright = "İçsel bir yolculuk ve yalnızlık ihtiyacı. Bilgelik arayışı için dış dünyadan uzaklaşma zamanı.",
                    GeneralReversed = "Aşırı izolasyon ve yalnızlaşma. Kendi içine fazla kapanarak gerçeklerden uzaklaşıyorsun.",
                    LoveUpright = "İlişkide olgunluk ve birbirini tanıma süreci. Yalnızlığı paylaşmak ve derinleşmek önemli.",
                    LoveReversed = "Partnerinden uzaklaşma veya duygusal soğukluk. İlişkideki sessizlik sorun yaratabilir.",
                    CareerUpright = "Gözlem yapma, analiz etme ve strateji belirme dönemi. Sessizce çalışmak daha büyük başarı getirir.",
                    CareerReversed = "İş hayatında ekip çalışmasından kopma veya yanlış rehberlik. Fikirlerini paylaşmaya korkma."
                },

                new TarotCard {
                    Id = 10, Name = "Kader Çarkı (Wheel of Fortune)", ImageName = "kader_carki",
                    GeneralUpright = "Hayatın döngüsel değişimi ve şanslı gelişmeler. Kontrolün dışında ama olumlu bir dönüşüm kapıda.",
                    GeneralReversed = "Şanssızlık hissi veya değişime direnme. Döngülerin tersine döndüğünü hissedebilirsin.",
                    LoveUpright = "Kadersel bir karşılaşma veya ilişkide yeni bir aşama. Mutlu tesadüflere hazır olmalısın.",
                    LoveReversed = "İlişkide tekrarlayan sorunlar ve kısır döngüler. Geçmiş hatalardan ders çıkarma vakti.",
                    CareerUpright = "İş hayatında ani ve büyük fırsatlar. Beklenmedik bir terfi veya sektör değişikliği olabilir.",
                    CareerReversed = "İş yerinde belirsizlik ve riskli dönemler. Ani değişimlere uyum sağlamakta zorlanıyorsun."
                },

                new TarotCard {
                    Id = 11, Name = "Adalet (Justice)", ImageName = "adalet_karti",
                    GeneralUpright = "Ektiğini biçme zamanı geldi. Hak yerini bulacak ve denge yeniden sağlanacak.",
                    GeneralReversed = "Haksız suçlamalar veya adaletsiz durumlarla karşılaşabilirsin. Sabırlı ve dürüst kalmalısın.",
                    LoveUpright = "İlişkide dürüstlük ve ciddiyet ön planda. Evlilik veya resmi kararlar gündeme gelebilir.",
                    LoveReversed = "Partnerler arası dengesizlik ve haksız eleştiriler yorucu olabilir. Hakkaniyetli davranmalısın.",
                    CareerUpright = "İş sözleşmeleri, hukuki başarılar ve hak edilen bir terfi kapıda. Emeklerinin karşılığını alıyorsun.",
                    CareerReversed = "İş yerinde haksızlığa uğradığını hissedebilirsin. Yasal konularda dikkatli ve tedbirli olmalısın."
                },
                // --- MAJOR ARCANA GRUBU 3 (ID: 12 - 22) ---

                new TarotCard {
                    Id = 12, Name = "Asılan Adam (The Hanged Man)", ImageName = "asilan_adam_karti",
                    GeneralUpright = "Olaylara farklı bir perspektiften bakma ve fedakarlık zamanı. Beklemede kalarak ruhsal aydınlanma yaşayabilirsin.",
                    GeneralReversed = "Gereksiz yere kendini kurban etme veya kararsızlık. Değişime direnmek sadece süreci uzatır.",
                    LoveUpright = "İlişkide bir duraklama dönemi; acele etmeden duyguları tartmalısın. Bazı şeyleri akışına bırakmak en iyisi.",
                    LoveReversed = "Partnerin için gereğinden fazla ödün veriyorsun. İlişkideki tıkanıklığı aşmak için bakış açını değiştirmelisin.",
                    CareerUpright = "İş hayatında stratejik bir geri çekilme veya eğitim dönemi. Acele kararlar yerine gözlem yapmak kazandırır.",
                    CareerReversed = "Kariyerinde boşa zaman harcadığını hissedebilirsin. Belirsizlikten kurtulmak için harekete geçme vakti."
                },

                new TarotCard {
                    Id = 13, Name = "Ölüm (Death)", ImageName = "olum_karti",
                    GeneralUpright = "Büyük bir dönüşüm ve kaçınılmaz bir son. Yeni bir sayfa açmak için eski olanı geride bırakmalısın.",
                    GeneralReversed = "Değişimden korkma ve geçmişe tutunma. Bitmesi gerekeni zorla sürdürmek sana sadece acı verir.",
                    LoveUpright = "İlişkide köklü bir değişim; ya tam bitiş ya da ilişkinin bambaşka bir boyuta evrilmesi söz konusu.",
                    LoveReversed = "Kötü giden bir ilişkiyi bitirememek veya vedalaşma korkusu. Yeniliğe yer açmak için bırakmalısın.",
                    CareerUpright = "İş hayatında bir devrin kapanışı; yeni bir sektöre geçiş veya mevcut yapının tamamen değişmesi.",
                    CareerReversed = "Kariyerinde işlevini yitirmiş yöntemlere bağlı kalmak. İşten ayrılma korkusu ilerlemeni engelliyor."
                },

                new TarotCard {
                    Id = 14, Name = "Denge (Temperance)", ImageName = "denge_karti",
                    GeneralUpright = "Uyum, sabır ve ölçülü olma zamanı. Zıtlıkları birleştirerek huzuru bulacak ve şifalanacaksın.",
                    GeneralReversed = "Aşırılıklar ve içsel huzursuzluk. Hayatının farklı alanları arasındaki dengeyi yitirmiş olabilirsin.",
                    LoveUpright = "Huzurlu, anlayışlı ve dengeli bir birliktelik. Partnerinle ortak bir orta yol bulma başarısı.",
                    LoveReversed = "İlişkide uyumsuzluk ve sürekli tartışmalar. Duygusal tepkilerinde aşırıya kaçıyor olabilirsin.",
                    CareerUpright = "Ekip çalışmasında uyum ve farklı fikirlerin sentezlenmesi. Sabırlı yaklaşımın meyvelerini verecek.",
                    CareerReversed = "İş yerinde çatışmalar ve odaklanma sorunu. Aceleci tavırlar projelerin dengesini bozuyor."
                },

                new TarotCard {
                    Id = 15, Name = "Şeytan (The Devil)", ImageName = "seytan_karti",
                    GeneralUpright = "Bağımlılıklar, maddi arzular ve seni kısıtlayan alışkanlıklar. Kendi yarattığın hapishanenin farkına varmalısın.",
                    GeneralReversed = "Kötü alışkanlıklardan kurtulma ve özgürleşme. Seni aşağı çeken bağları koparma gücünü buluyorsun.",
                    LoveUpright = "Aşırı tutku, takıntılı sevgi veya toksik bir bağ. Duygulardan ziyade fiziksel çekimin esiri olma riski.",
                    LoveReversed = "Kısıtlayıcı bir ilişkiden kurtulma veya partnerin baskısını kırma. Özgürlüğüne yeniden kavuşuyorsun.",
                    CareerUpright = "Maddi hırsların etik değerlerin önüne geçmesi. Sadece para odaklı düşünmek seni yanlış yollara sokabilir.",
                    CareerReversed = "İş yerindeki baskıcı ortamdan veya manipülatif bir iş arkadaşından uzaklaşma başarısı."
                },

                new TarotCard {
                    Id = 16, Name = "Kule (The Tower)", ImageName = "kule_karti",
                    GeneralUpright = "Ani, sarsıcı ve beklenmedik değişim. Temeli sağlam olmayan yapılar yıkılırken, gerçeklerle yüzleşeceksin.",
                    GeneralReversed = "Büyük bir felaketin eşiğinden dönme veya kaçınılmaz yıkımı erteleme. Gerçekleri görmezden gelmek tehlikelidir.",
                    LoveUpright = "İlişkide ani bir sarsıntı veya gizli sırların açığa çıkması. Yıkıcı olsa da dürüst bir başlangıç için gerekli.",
                    LoveReversed = "Sorunlu bir ilişkinin yıkılmasından kıl payı kurtulma ancak temeldeki çatlaklar hala orada.",
                    CareerUpright = "İş hayatında ani bir kriz, iş değişikliği veya iflas riski. Yıkılanın yerine daha sağlamını inşa edeceksin.",
                    CareerReversed = "İş yerindeki gerginlikten minimum zararla çıkma çabası. Radikal kararlar almaktan korkuyorsun."
                },

                new TarotCard {
                    Id = 17, Name = "Yıldız (The Star)", ImageName = "yildiz_karti",
                    GeneralUpright = "Umut, ilham ve ruhsal şifalanma. Karanlık dönemin ardından gelen huzur ve geleceğe duyulan güven.",
                    GeneralReversed = "Umutsuzluk ve karamsarlık. Hayatın sunduğu fırsatları göremeyecek kadar inancını yitirmiş hissedebilirsin.",
                    LoveUpright = "Yaraların sarıldığı, idealize edilen huzurlu bir ilişki. Partnerinle aranda saf bir bağ oluşuyor.",
                    LoveReversed = "İlişkide hayal kırıklığı veya gerçekçi olmayan beklentiler. Geleceğe dair inancını yitirme hissi.",
                    CareerUpright = "Yaratıcılığın parladığı ve projelerinin takdir topladığı dönem. Parlak bir gelecek seni bekliyor.",
                    CareerReversed = "İş hayatında motivasyon eksikliği ve ilham tıkanıklığı. Hedeflerine olan inancını tazelemelisin."
                },

                new TarotCard {
                    Id = 18, Name = "Ay (The Moon)", ImageName = "ay_karti",
                    GeneralUpright = "Bilinçaltı korkuları, illüzyonlar ve belirsizlik. Göründüğü gibi olmayan durumlara ve sezgilerine dikkat etmelisin.",
                    GeneralReversed = "Gizli kalmış korkuların açığa çıkması ve karmaşanın sona ermesi. Gerçekleri görmeye başlıyorsun.",
                    LoveUpright = "İlişkide kafa karışıklığı ve güvensizlik. Kıskançlıklar veya geçmişin gölgeleri aranıza girebilir.",
                    LoveReversed = "Partnerinle arandaki sırlar açığa çıkıyor. Belirsizliklerin yerini netlik ve dürüstlük alacak.",
                    CareerUpright = "İş yerinde önünü görememe ve belirsiz vaatler. İmza atmadan önce her şeyi iyice araştırmalısın.",
                    CareerReversed = "Kariyerindeki karmaşanın çözülmesi. Yanlış anlaşılmaların düzeldiği ve taşların yerine oturduğu bir dönem."
                },

                new TarotCard {
                    Id = 19, Name = "Güneş (The Sun)", ImageName = "gunes_karti",
                    GeneralUpright = "Mutluluk, başarı, canlılık ve netlik. Her şeyin aydınlandığı, neşe dolu ve bereketli bir dönem.",
                    GeneralReversed = "Aşırı özgüvenin getirdiği hatalar veya geçici moral bozukluğu. Başarı kapıda ama biraz gölgelenmiş olabilir.",
                    LoveUpright = "Sevgi dolu, parlak ve çocuksu bir neşeyle dolu ilişki. Birlikte parlayacağınız bir dönemdesiniz.",
                    LoveReversed = "İlişkideki mutluluğun üzerinde küçük bulutlar. Ego sorunları veya partnerini fazla gölgede bırakma.",
                    CareerUpright = "İş hayatında büyük başarı, terfi ve liderlik. Tüm gözlerin üzerinde olduğu, kazançlı bir süreç.",
                    CareerReversed = "İş yerinde hak edilen başarının gecikmesi. Başarıya ulaşacaksın ama daha mütevazı kalmalısın."
                },

                new TarotCard {
                    Id = 20, Name = "Mahkeme (Judgement)", ImageName = "mahkeme_karti",
                    GeneralUpright = "Uyanış, vicdani hesaplaşma ve yeni bir çağrı. Geçmişten ders çıkararak yeniden doğma zamanı.",
                    GeneralReversed = "Kendini yargılama veya geçmiş hatalara takılıp kalma. Önemli bir kararı vermekte gecikiyorsun.",
                    LoveUpright = "İlişkide yeni bir anlayış seviyesi veya kopan bir bağın yeniden kurulması. Affetmenin gücü.",
                    LoveReversed = "Geçmişteki kalp kırıklıklarını bırakamamak. İlişkideki kronik sorunları görmezden geliyorsun.",
                    CareerUpright = "Kariyerinde önemli bir karar aşaması. Emeklerinin toplu bir değerlendirmesi ve hak edilen sonuç.",
                    CareerReversed = "İş yerinde eleştirilere kapalı olma. Kariyerindeki fırsatları eski korkuların yüzünden kaçırabilirsin."
                },

                new TarotCard {
                    Id = 21, Name = "Dünya (The World)", ImageName = "dunya_karti",
                    GeneralUpright = "Tamamlanma, bütünlük ve başarıyla sona eren yolculuk. Bir döngünün zaferle kapanması.",
                    GeneralReversed = "Bir şeyi bitirmekte zorlanma veya yarım kalan başarılar. Hedefe çok yakınsın ama son adımı atamıyorsun.",
                    LoveUpright = "Ruhsal olarak tam tatmin, evlilik veya uzun süredir aranan huzura kavuşma. Mutlu son.",
                    LoveReversed = "İlişkide bir aşamanın tamamlanamaması. Partnerinle arandaki eksik parçayı bulman gerekiyor.",
                    CareerUpright = "Büyük bir projenin başarıyla bitirilmesi, global fırsatlar veya hayalindeki kariyere ulaşma.",
                    CareerReversed = "İş yerinde hedefe çok yaklaşıp son anda aksilik yaşama. Süreci tamamlamak için çaba göstermelisin."
                },
                new TarotCard {
                    Id = 22, Name = "Kader (The Destiny)", ImageName = "kader_karti",
                    GeneralUpright = "Büyük resmin bir parçası olduğunu fark etme zamanı. Hayat seni gitmen gereken yere doğru nazikçe itiyor.",
                    GeneralReversed = "Kendi kaderine direnme ve akışa karşı gelme çabası. Kontrol edemeyeceğin güçlerle inatlaşmamalısın.",
                    LoveUpright = "Kadersel bir eşleşme veya ruhsal kontratın gereği olan bir buluşma. Aşk hayatında ilahi bir düzen işliyor.",
                    LoveReversed = "İlişkide 'neden bunlar başıma geliyor' sorgulaması. Kadersel dersleri görmezden gelmek döngüyü zorlaştırıyor.",
                    CareerUpright = "Mesleki anlamda tam olarak olman gereken yerdesin. Yeteneklerin kadersel bir fırsatla birleşecek.",
                    CareerReversed = "Kariyer yolunda yanlış bir yöne sapmış olma hissi. İş hayatındaki engeller aslında seni doğru yola sokmak için birer işaret."
                },
                //--- KUPALAR SERİSİ (ID: 23 - 36) ---
                new TarotCard {
                    Id = 23, Name = "As Kupa (Ace of Cups)", ImageName = "kupa_asi_karti",
                    GeneralUpright = "Duygusal bir uyanış ve huzur dönemi. Kalbinin kapılarını yeni mutluluklara açıyorsun.",
                    GeneralReversed = "Duygusal tıkanıklık veya bastırılmış hisler yaşıyorsun. Kendine zaman tanımalısın.",
                    LoveUpright = "Ruh eşini bulma veya mevcut ilişkide derin bir sevgi bağı. Aşkın en saf halini yaşayacaksın.",
                    LoveReversed = "Karşılıksız sevgi veya hayal kırıklığı riski. Duygularını koruma altına almalısın.",
                    CareerUpright = "İş yerinde huzurlu bir ortam ve yaratıcı başarılar. Sevdiğin işi yapma fırsatı doğacak.",
                    CareerReversed = "İş hayatında motivasyon kaybı ve tatminsizlik. Duygusal kararlar işine zarar verebilir."
                },
                new TarotCard {
                    Id = 24, Name = "Kupa İkilisi", ImageName = "kupa_ikilisi_karti",
                    GeneralUpright = "Uyumlu ortaklıklar, karşılıklı anlayış ve iki ruhun birleşimi.",
                    GeneralReversed = "İletişim kopukluğu, dengesiz ilişkiler ve bozulan ortaklıklar.",
                    LoveUpright = "Derin bir çekim, romantik bir teklif ve tam bir duygusal uyum.",
                    LoveReversed = "İlişkide uyumsuzluk, ayrılık sinyalleri veya güven kaybı.",
                    CareerUpright = "Kazançlı iş ortaklıkları ve ekip içinde sevgi dolu bir bağ.",
                    CareerReversed = "İş yerinde yanlış anlaşılmalar ve profesyonellikten uzak çatışmalar."
                },

                new TarotCard {
                    Id = 25, Name = "Kupa Üçlüsü", ImageName = "kupa_uclusu_karti",
                    GeneralUpright = "Kutlama, topluluk, dostluk ve paylaşılan büyük sevinçler.",
                    GeneralReversed = "Sosyal çevreden uzaklaşma veya bir kutlamanın iptal edilmesi.",
                    LoveUpright = "İlişkide neşeli bir dönem; nişan, düğün veya arkadaşlar aracılığıyla tanışma.",
                    LoveReversed = "İlişkiye üçüncü kişilerin müdahalesi veya sosyal çevrenin baskısı.",
                    CareerUpright = "Bir projenin ekipçe başarıyla kutlanması ve destekleyici ortam.",
                    CareerReversed = "İş yerinde gruplaşmalar ve disiplinsizlik nedeniyle gelen aksaklıklar."
                },

                new TarotCard {
                    Id = 26, Name = "Kupa Dörtlüsü", ImageName = "kupa_dortlusu_karti",
                    GeneralUpright = "Memnuniyetsizlik, içe dönüklük ve sunulan fırsatlara karşı ilgisizlik.",
                    GeneralReversed = "Yeni bir farkındalık; ataletten kurtulup hayata yeniden karışma.",
                    LoveUpright = "İlişkide rutinden sıkılma ve partnerinin çabalarını görmezden gelme.",
                    LoveReversed = "Aşka yeniden şans verme ve duygusal uyanış süreci.",
                    CareerUpright = "İş yerinde motivasyon kaybı ve yeni tekliflere kapalı olma hali.",
                    CareerReversed = "Kariyerde yeni ve heyecan verici projelerin farkına varma başarısı."
                },

                new TarotCard {
                    Id = 27, Name = "Kupa Beşlisi", ImageName = "kupa_beslisi_karti",
                    GeneralUpright = "Kayıplara odaklanma, pişmanlık ve geçmişin yasını tutma.",
                    GeneralReversed = "Kabul etme, iyileşme ve yeniden ayağa kalkma gücü bulma.",
                    LoveUpright = "Biten bir aşkın ardından gelen keder ve yalnızlaşma hissi.",
                    LoveReversed = "Eski sevgiliyi veya travmaları geride bırakıp iyileşmeye başlama.",
                    CareerUpright = "Başarısız bir proje veya maddi kayıpların yarattığı moral bozukluğu.",
                    CareerReversed = "İş kaybından sonra gelen çok daha iyi ve yeni fırsatlar."
                },

                new TarotCard {
                    Id = 28, Name = "Kupa Altılısı", ImageName = "kupa_altilisi_karti",
                    GeneralUpright = "Nostalji, masumiyet ve geçmişten gelen mutlu bir haber veya kişi.",
                    GeneralReversed = "Geçmişe aşırı takılıp kalma ve bugünkü gerçeklerden kopma.",
                    LoveUpright = "Eski bir aşkın canlanması veya çok saf, koruyucu bir sevgi bağı.",
                    LoveReversed = "İlişkide olgunlaşamama sorunu ve geçmişteki hataların tekrarı.",
                    CareerUpright = "Eski iş arkadaşlarından gelen teklifler veya tecrübelerin meyve vermesi.",
                    CareerReversed = "Kariyerde yeniliklere direnmek ve sadece geçmiş başarılarla övünmek."
                },

                new TarotCard {
                    Id = 29, Name = "Kupa Yedilisi", ImageName = "kupa_yedilisi_karti",
                    GeneralUpright = "Seçenekler arasında kaybolma, hayaller ve illüzyonlar dünyası.",
                    GeneralReversed = "Zihin karışıklığının bitmesi ve somut bir hedefe odaklanma.",
                    LoveUpright = "Aşk hayatında kafa karışıklığı; gerçek sevgiyi değil fanteziyi sevme.",
                    LoveReversed = "İlişkideki hayallerin yıkılıp gerçeklerle yüzleşildiği netlik dönemi.",
                    CareerUpright = "İş hayatında çok fazla teklif ama odaklanma sorunu yaşanması.",
                    CareerReversed = "Kariyerde nihayet doğru yolu seçme ve dağınık enerjiyi toplama."
                },

                new TarotCard {
                    Id = 30, Name = "Kupa Sekizlisi", ImageName = "kupa_sekizlisi_karti",
                    GeneralUpright = "Duygusal yetersizlik hissiyle bir şeyi terk etme ve ruhsal arayış.",
                    GeneralReversed = "Gidilmesi gereken yerden ayrılamama ve değişime direnme.",
                    LoveUpright = "Huzur vermeyen bir ilişkiyi arkana bakmadan terk etme zamanı.",
                    LoveReversed = "Mutsuz bir bağdan kopamama veya biten ilişkiye dönme çabası.",
                    CareerUpright = "Maddi kazanç olsa da ruhu tatmin etmeyen işten ayrılma kararı.",
                    CareerReversed = "Kariyerde risk almaktan korkma ve mutsuzluğa razı olma."
                },

                new TarotCard {
                    Id = 31, Name = "Kupa Dokuzlusu", ImageName = "kupa_dokuzlusu_karti",
                    GeneralUpright = "Dileklerin kabulü, duygusal tatmin ve hayatın tadını çıkarma.",
                    GeneralReversed = "Doyumsuzluk, aşırı ego ve sahip olduklarına rağmen boşluk hissi.",
                    LoveUpright = "Duygusal zirve; hayalindeki partnerle gelen büyük mutluluk.",
                    LoveReversed = "Yüzeysel mutluluk ve gerçek duygulardan kaçarak kibre kapılma.",
                    CareerUpright = "İş hayatında beklenen başarının ve konforun elde edilmesi.",
                    CareerReversed = "Başarıyı yanlış kullanarak çevrendeki desteği yitirme riski."
                },

                new TarotCard {
                    Id = 32, Name = "Kupa Onlusu", ImageName = "kupa_onlusu_karti",
                    GeneralUpright = "Aile saadeti, tam huzur ve kalıcı duygusal bütünlük.",
                    GeneralReversed = "Aile içi gerginlikler ve evdeki huzurun bozulma eğilimi.",
                    LoveUpright = "Ciddi kararlar, mutlu bir yuva ve ömür boyu sürecek sevgi.",
                    LoveReversed = "İlişkide aile baskısı veya evlilik planlarında yaşanan aksaklıklar.",
                    CareerUpright = "İş yerinde uzun vadeli güvence ve sevildiğin bir çalışma ortamı.",
                    CareerReversed = "Ekip ruhunun dağılması ve beklenen çevresel desteğin gelmemesi."
                },

                new TarotCard {
                    Id = 33, Name = "Kupa Prensi (Uşağı)", ImageName = "kupa_prensi_karti",
                    GeneralUpright = "Duygusal haberler, yaratıcı ilham ve sezgileri güçlü bir genç.",
                    GeneralReversed = "Duygusal dengesizlik ve gerçeklerden kaçma isteği.",
                    LoveUpright = "Yeni bir flört veya samimi, romantik bir mesajın gelişi.",
                    LoveReversed = "Duygusal oyunlar ve karşındaki kişinin tutarsız davranışları.",
                    CareerUpright = "Yaratıcı bir projeye başlama ve sezgilerinle fark yaratma.",
                    CareerReversed = "Profesyonellikten uzak tavırlar nedeniyle somut adım atamama."
                },

                new TarotCard {
                    Id = 34, Name = "Kupa Şövalyesi", ImageName = "kupa_sovalyesi_karti",
                    GeneralUpright = "Romantik teklifler, idealizm ve duyguların peşinden gitme.",
                    GeneralReversed = "Duygusal manipülasyon ve tutulamayan vaatler süreci.",
                    LoveUpright = "Aşk ilanı veya ruhu besleyen çok romantik bir birliktelik.",
                    LoveReversed = "İlişkide istikrarsızlık ve partnerin uçarı, ciddiyetsiz tavırları.",
                    CareerUpright = "İş yerinde diplomasi ve tutkuyla bağlandığın projelerin ilerlemesi.",
                    CareerReversed = "Aşırı duygusal kararların iş süreçlerine zarar vermesi."
                },

                new TarotCard {
                    Id = 35, Name = "Kupa Kraliçesi", ImageName = "kupa_kralicesi_karti",
                    GeneralUpright = "Şefkat, sezgi ve empati; duygusal olarak olgun bir kadın enerjisi.",
                    GeneralReversed = "Aşırı hassasiyet, bağımlılık ve duygusal olarak boğulma hissi.",
                    LoveUpright = "Koşulsuz sevgi ve partnerini ruhsal olarak şifalandırma gücü.",
                    LoveReversed = "İlişkide duygusal şantaj veya aşırı kıskançlık krizleri.",
                    CareerUpright = "İnsan ilişkilerindeki başarı sayesinde gelen kariyer yükselişi.",
                    CareerReversed = "İş yerinde objektif olamama ve kırılganlık nedeniyle hata yapma."
                },

                new TarotCard {
                    Id = 36, Name = "Kupa Kralı", ImageName = "kupa_krali_karti",
                    GeneralUpright = "Duygusal denge, bilgelik ve güvenilir bir figürün desteği.",
                    GeneralReversed = "Duygusal soğukluk ve gücü manipülatif şekilde kullanma.",
                    LoveUpright = "Güven veren, olgun ve koruyucu bir partnerle gelen huzur.",
                    LoveReversed = "Partnerle araya giren soğuk duvarlar ve ilgisizlik sorunu.",
                    CareerUpright = "Diplomasiyle kriz çözme ve duygusal zekayla kazanılan saygınlık.",
                    CareerReversed = "Samimiyetsiz iş ilişkileri ve profesyonel duruşun bozulması."
                },
                // --- DEĞNEKLER SERİSİ (ID: 37 - 50) ---

                new TarotCard {
                    Id = 37, Name = "Değnek Ası", ImageName = "degnek_asi_karti",
                    GeneralUpright = "Yeni bir girişim, yaratıcı potansiyel ve ilham dolu bir başlangıç.",
                    GeneralReversed = "Ertelenen projeler, motivasyon kaybı ve hedefsizlik.",
                    LoveUpright = "Yeni bir çekim, heyecan verici bir tanışma ve tutkulu bir başlangıç.",
                    LoveReversed = "İlişkide heyecanın sönmesi veya beklenen teklifin gelmemesi.",
                    CareerUpright = "İş hayatında yeni bir fırsat, girişimcilik ruhu ve büyük bir atılım.",
                    CareerReversed = "İş yerinde yaratıcılığın tıkanması ve projelerin yarıda kalması."
                },

                new TarotCard {
                    Id = 38, Name = "Değnek İkilisi", ImageName = "degnek_ikilisi_karti",
                    GeneralUpright = "Planlama, gelecek vizyonu ve ilk adımı atmak için hazırlık süreci.",
                    GeneralReversed = "Kararsızlık, korkular nedeniyle yerinde sayma ve yanlış planlama.",
                    LoveUpright = "İlişkide gelecek planları yapma ve ortak bir yol seçme aşaması.",
                    LoveReversed = "Partnerle gelecek hedeflerinin uyuşmaması ve belirsizlik.",
                    CareerUpright = "Yeni iş ortaklıkları, genişleme planları ve global hedefler.",
                    CareerReversed = "İş hayatında risk almaktan korkma ve güvenli bölgede takılı kalma."
                },

                new TarotCard {
                    Id = 39, Name = "Değnek Üçlüsü", ImageName = "degnek_uclusu_karti",
                    GeneralUpright = "Genişleme, ilerleme ve emeklerin karşılığını görmeye başlama.",
                    GeneralReversed = "Bekleyişin uzaması, hayal kırıklığı ve beklenen haberlerin gelmemesi.",
                    LoveUpright = "İlişkide yeni bir evreye geçiş ve uzun vadeli güven inşası.",
                    LoveReversed = "Uzak mesafe ilişkisinde sorunlar veya duygusal beklentilerin karşılanmaması.",
                    CareerUpright = "İşlerin büyümesi, yeni pazarlar ve başarılı ticari girişimler.",
                    CareerReversed = "İş yerinde organizasyon bozukluğu ve hedeflerin uzağında kalma."
                },

                new TarotCard {
                    Id = 40, Name = "Değnek Dörtlüsü", ImageName = "degnek_dortlusu_karti",
                    GeneralUpright = "Kutlama, huzur, eve dönüş ve kazanılan başarının keyfini çıkarma.",
                    GeneralReversed = "Aile içi ufak gerginlikler veya bir başarının buruk kutlanması.",
                    LoveUpright = "Mutlu bir beraberlik, söz, nişan veya ev içinde huzur dönemi.",
                    LoveReversed = "İlişkide istikrarsızlık ve kutlanması gereken anların gölgelenmesi.",
                    CareerUpright = "İş yerinde istikrar, tamamlanan bir projenin başarısı ve ödüller.",
                    CareerReversed = "Kariyerde geçici duraklama ve çalışma ortamındaki huzursuzluk."
                },

                new TarotCard {
                    Id = 41, Name = "Değnek Beşlisi", ImageName = "degnek_beslisi_karti",
                    GeneralUpright = "Rekabet, çatışma ve fikir ayrılıkları nedeniyle yaşanan karmaşa.",
                    GeneralReversed = "Karmaşanın sona ermesi, uzlaşma ve kavgadan kaçınma.",
                    LoveUpright = "İlişkide inatlaşmalar, küçük tartışmalar ve ego savaşları.",
                    LoveReversed = "Sorunların çözülmesi ve partnerle orta yolun bulunması.",
                    CareerUpright = "İş yerinde yoğun rekabet ve projelerde karşılaşılan engeller.",
                    CareerReversed = "İş ortamında gerginliğin bitmesi ve ekip uyumunun tekrar sağlanması."
                },

                new TarotCard {
                    Id = 42, Name = "Değnek Altılısı", ImageName = "degnek_altilisi_karti",
                    GeneralUpright = "Zafer, takdir edilme ve toplum önünde kazanılan büyük başarı.",
                    GeneralReversed = "Başarının gecikmesi, özgüven kaybı ve beklentilerin altında kalma.",
                    LoveUpright = "İlişkide mutlu son, herkes tarafından onaylanan bir birliktelik.",
                    LoveReversed = "Partnerin ilgisinin azalması veya ilişkinin dış baskılardan etkilenmesi.",
                    CareerUpright = "Terfi, liderlik başarısı ve emeklerinin herkesçe görülmesi.",
                    CareerReversed = "İş yerinde hak edilen değerin görülmemesi ve prestij kaybı."
                },

                new TarotCard {
                    Id = 43, Name = "Değnek Yedilisi", ImageName = "degnek_yedilisi_karti",
                    GeneralUpright = "Savunma, azim ve zorluklara karşı duruşunu koruma.",
                    GeneralReversed = "Baskı altında ezilme, pes etme ve savunmasız kalma hissi.",
                    LoveUpright = "İlişkiyi korumak için çaba sarf etme ve engellere göğüs germe.",
                    LoveReversed = "İlişkideki dış müdahalelere karşı güçsüz hissetme ve kararsızlık.",
                    CareerUpright = "İş yerinde pozisyonunu koruma savaşı ve rakipleri geride bırakma.",
                    CareerReversed = "Yoğun iş yükü altında tükenme ve sorumluluklardan kaçma isteği."
                },

                new TarotCard {
                    Id = 44, Name = "Değnek Sekizlisi", ImageName = "degnek_sekizlisi_karti",
                    GeneralUpright = "Hız, ani gelişmeler ve beklenen haberlerin şak diye gelmesi.",
                    GeneralReversed = "Gecikmeler, planların ertelenmesi ve kontrolsüz hareketler.",
                    LoveUpright = "Hızlı gelişen bir aşk, ani seyahatler ve yoğun iletişim.",
                    LoveReversed = "İletişim kopukluğu veya aşkta verilen yanlış, aceleci kararlar.",
                    CareerUpright = "İşlerin hızlanması, beklenen onayın gelmesi ve hareketli dönem.",
                    CareerReversed = "Projelerde aksaklıklar ve iş seyahatlerinde yaşanan sorunlar."
                },

                new TarotCard {
                    Id = 45, Name = "Değnek Dokuzlusu", ImageName = "degnek_dokuzlusu_karti",
                    GeneralUpright = "Dayanıklılık, son bir gayret ve tecrübeyle gelen temkinli duruş.",
                    GeneralReversed = "Tükenmişlik, aşırı şüphecilik ve savunma kalkanlarını indirememe.",
                    LoveUpright = "Geçmiş yaralar nedeniyle temkinli bir aşk; sınırları koruma.",
                    LoveReversed = "İlişkide aşırı savunmacı tavırların partneri uzaklaştırması.",
                    CareerUpright = "Zor bir projenin son aşaması, yorgunluğa rağmen devam etme gücü.",
                    CareerReversed = "İş hayatında tükenmişlik sendromu ve direncin kırılması."
                },

                new TarotCard {
                    Id = 46, Name = "Değnek Onlusu", ImageName = "degnek_onlusu_karti",
                    GeneralUpright = "Aşırı sorumluluk, ağır yükler ve hedefe ulaşmak üzereyken gelen yorgunluk.",
                    GeneralReversed = "Yüklerden kurtulma, yardım isteme veya sorumlulukların altında kalma.",
                    LoveUpright = "İlişkinin tüm yükünü tek başına sırtlanma; duygusal yorgunluk.",
                    LoveReversed = "İlişkideki baskıdan kurtulma ve sorunları paylaşmaya başlama.",
                    CareerUpright = "Çok yoğun çalışma temposu ve iş yükünün zirve yapması.",
                    CareerReversed = "İş hayatında yetki devretme veya ağır stres nedeniyle pes etme."
                },

                new TarotCard {
                    Id = 47, Name = "Değnek Prensi (Uşağı)", ImageName = "degnek_prensi_karti",
                    GeneralUpright = "Yeni bir fikir, macera isteği ve enerjik bir haber taşıyıcısı.",
                    GeneralReversed = "Sabırsızlık, kötü haberler veya çocuksu, tutarsız tavırlar.",
                    LoveUpright = "Heyecan verici bir mesaj, yeni bir flörtün enerjisi.",
                    LoveReversed = "Aşkta ciddiyetsizlik ve hevesin çabuk geçmesi.",
                    CareerUpright = "Kariyerde yeni bir eğitime başlama veya yaratıcı bir fikir bulma.",
                    CareerReversed = "İş hayatında odaklanma sorunu ve disiplinsiz yaklaşımlar."
                },

                new TarotCard {
                    Id = 48, Name = "Değnek Şövalyesi", ImageName = "degnek_sovalyesi_karti",
                    GeneralUpright = "Eylem, cesaret, tutku ve hızlıca harekete geçme enerjisi.",
                    GeneralReversed = "Düşüncesizce hareket etme, öfke patlamaları ve yarıda kalan işler.",
                    LoveUpright = "Maceracı bir partner, hızlı başlayan tutkulu bir ilişki.",
                    LoveReversed = "İlişkide sabırsızlık, kavgalar veya bir anlık hevesle gitmek.",
                    CareerUpright = "İş hayatında risk alma, cesur projeler ve hızlı ilerleme.",
                    CareerReversed = "Aceleci kararların iş hayatında kayıplara yol açması."
                },

                new TarotCard {
                    Id = 49, Name = "Değnek Kraliçesi", ImageName = "degnek_kralicesi_karti",
                    GeneralUpright = "Özgüven, neşe, karizma ve çekici bir liderlik enerjisi.",
                    GeneralReversed = "Kıskançlık, huysuzluk veya bencilce davranma eğilimi.",
                    LoveUpright = "İlişkide güven dolu, canlı ve partnerini etkileyen bir duruş.",
                    LoveReversed = "Aşk hayatında aşırı baskın olma ve kıskançlık krizleri.",
                    CareerUpright = "İş yerinde popülerlik, yaratıcı yöneticilik ve başarı.",
                    CareerReversed = "Kariyerde otorite kurmaya çalışırken sert ve kaba olma."
                },

                new TarotCard {
                    Id = 50, Name = "Değnek Kralı", ImageName = "degnek_krali_karti",
                    GeneralUpright = "Vizyoner liderlik, cesaret ve büyük projeleri yönetme gücü.",
                    GeneralReversed = "Diktatörce tavırlar, sabırsızlık ve acımasız rekabet.",
                    LoveUpright = "Koruyucu, tutkulu ve sadık bir partnerin varlığı.",
                    LoveReversed = "İlişkide dediğim dedik tavırlar ve partneri küçümseme.",
                    CareerUpright = "Kariyerde zirveye oynama, büyük kararlar ve saygınlık.",
                    CareerReversed = "İş hayatında etik olmayan hırslar ve gücü kötüye kullanma."
                },
                // --- KILIÇLAR SERİSİ (ID: 51 - 64) ---

                new TarotCard {
                    Id = 51, Name = "Kılıç Ası", ImageName = "kilic_asi_karti",
                    GeneralUpright = "Zihinsel netlik, yeni bir fikir ve zafer. Gerçekleri görme ve keskin kararlar alma zamanı.",
                    GeneralReversed = "Kafa karışıklığı, yanlış kararlar ve adaletsiz durumlar. Düşüncelerde bulanıklık yaşanıyor.",
                    LoveUpright = "İlişkide dürüstlük ve net bir iletişim. Sorunları mantık çerçevesinde çözme başarısı.",
                    LoveReversed = "Partnerle sert tartışmalar ve kırıcı sözler. Gerçeklerin çarpıtılması aranızda gerginlik yaratabilir.",
                    CareerUpright = "İş hayatında büyük bir başarı, yeni bir strateji ve otorite kazanma. Zekanı kullanarak öne çıkıyorsun.",
                    CareerReversed = "İş yerinde iletişim kazaları ve yetki karmaşası. Planlarının üzerinden tekrar geçmelisin."
                },

                new TarotCard {
                    Id = 52, Name = "Kılıç İkilisi", ImageName = "kilic_ikilisi_karti",
                    GeneralUpright = "Kararsızlık, iki seçenek arasında kalma ve duygularla mantığı dengeleme çabası.",
                    GeneralReversed = "Karar verme zorunluluğu ve gerçeği görme. Artık göz bağını çözüp bir seçim yapmalısın.",
                    LoveUpright = "İlişkideki sorunları görmezden gelme hali. Duygusal bir çıkmazda hissedip geri çekilme.",
                    LoveReversed = "İlişkideki belirsizliğin sona ermesi. Artık saklanamayan gerçeklerin ortaya çıkışı ve seçim yapma.",
                    CareerUpright = "İş yerinde zorlu bir denge kurma süreci. Fikir ayrılıkları arasında tarafsız kalmaya çalışıyorsun.",
                    CareerReversed = "İş hayatında kilitlenen bir sürecin açılması. Karar almanı engelleyen faktörlerin ortadan kalkması."
                },

                new TarotCard {
                    Id = 53, Name = "Kılıç Üçlüsü", ImageName = "kilic_uclusu_karti",
                    GeneralUpright = "Kalp kırıklığı, ayrılık ve hüzün. Gerçeklerin can yakması ama iyileşme için bu acının yaşanması.",
                    GeneralReversed = "Acının hafiflemesi, affetme ve iyileşme sürecine giriş. Eski yaraların kapanmaya başlaması.",
                    LoveUpright = "İlişkide hayal kırıklığı veya üçüncü şahıslardan kaynaklanan sorunlar. Duygusal bir yıkım süreci.",
                    LoveReversed = "Partnerle barışma veya acıyı dindirecek bir konuşma. Kalp kırıklığından ders çıkarıp yoluna devam etme.",
                    CareerUpright = "İş yerinde beklenmedik bir reddedilme veya proje iptali. Maddi kayıptan ziyade moral bozukluğu.",
                    CareerReversed = "İş hayatındaki krizlerin atlatılması. Kaybedilen motivasyonun yavaş yavaş geri kazanılması."
                },

                new TarotCard {
                    Id = 54, Name = "Kılıç Dörtlüsü", ImageName = "kilic_dortlusu_karti",
                    GeneralUpright = "Dinlenme, geri çekilme ve zihinsel olarak toparlanma süreci. Aksiyon yerine sükunet zamanı.",
                    GeneralReversed = "Durgunluğun bitmesi, yeniden harekete geçme ve iyileşmenin tamamlanması.",
                    LoveUpright = "İlişkiye kısa bir mola verme veya partnerle daha sakin bir sürece girme. İçsel huzur arayışı.",
                    LoveReversed = "İlişkideki sessizliğin bozulması. Tekrar iletişime geçme ve sorunları konuşmak için enerji bulma.",
                    CareerUpright = "İş hayatında stresli bir dönemin ardından gelen izin veya dinlenme ihtiyacı. Planlama yapma vakti.",
                    CareerReversed = "Kariyerde durağanlığın sona ermesi. Uzun süren bir bekleme sürecinden sonra tekrar sahneye çıkma."
                },

                new TarotCard {
                    Id = 55, Name = "Kılıç Beşlisi", ImageName = "kilic_beslisi_karti",
                    GeneralUpright = "Bencilce kazanılan zafer, çatışma ve kaybet-kaybet durumu. Haklı olsan da yalnız kalabilirsin.",
                    GeneralReversed = "Anlamsız tartışmaları bırakma, pişmanlık ve barışçıl bir yol arayışı.",
                    LoveUpright = "İlişkide ego savaşları ve partnerin kalbini kırarak üste çıkma çabası. Sonuçsuz kavgalar.",
                    LoveReversed = "Kırılan kalpleri onarma çabası. Gereksiz inatlaşmaların ilişkiye verdiği zararın farkına varma.",
                    CareerUpright = "İş yerinde rakiplerini alt etme ama bu süreçte güven kaybetme. Dedikodu ve etik dışı rekabet.",
                    CareerReversed = "İş ortamındaki düşmanlıkların son bulması. Hataları kabul edip ekip ruhuna dönme isteği."
                },

                new TarotCard {
                    Id = 56, Name = "Kılıç Altılısı", ImageName = "kilic_altilisi_karti",
                    GeneralUpright = "Zor bir dönemden daha huzurlu bir yere geçiş. Sorunları geride bırakıp yeni bir ufka yelken açma.",
                    GeneralReversed = "Geçmişe takılı kalma, değişimden kaçma ve yolculuğun önündeki engeller.",
                    LoveUpright = "İlişkideki fırtınaların dinmesi. Partnerle beraber daha sakin ve anlayışlı bir sürece geçme.",
                    LoveReversed = "İlişkideki sorunları beraberinde taşıma. Değişime direnmek aranızdaki gerginliği sürdürüyor.",
                    CareerUpright = "İş yerinde krizlerin aşılması veya yeni bir çalışma ortamına geçiş. Mental olarak rahatlama.",
                    CareerReversed = "Kariyerde istenilen değişikliğin gerçekleşmemesi. Sorunlu iş ortamından çıkış yolunu bulamama."
                },

                new TarotCard {
                    Id = 57, Name = "Kılıç Yedilisi", ImageName = "kilic_yedilisi_karti",
                    GeneralUpright = "Strateji, gizlilik ve kurnazlık. Bazı şeyleri gizlice halletme veya hırsızlığa/ihanete dikkat etme.",
                    GeneralReversed = "Vicdan azabı, gerçeklerin açığa çıkması ve yapılan hilelerin fark edilmesi.",
                    LoveUpright = "İlişkide partnerden gizlenen durumlar veya güvensizlik. Arkadan iş çevirme riskine dikkat.",
                    LoveReversed = "Partnerle dürüstleşme zamanı. Gizli saklı konuların konuşulması ve güvenin yeniden inşası.",
                    CareerUpright = "İş yerinde diplomatik ama kurnazca adımlar. Rakipleri zekayla atlatma ama etik sınırları zorlama.",
                    CareerReversed = "İş hayatında yapılan yanlışların ortaya çıkması. Dürüst olmayan yöntemlerin başarısızlığa uğraması."
                },

                new TarotCard {
                    Id = 58, Name = "Kılıç Sekizlisi", ImageName = "kilic_sekizlisi_karti",
                    GeneralUpright = "Kısıtlanmış hissetme, kurban psikolojisi ve çaresizlik. Aslında kaçış yolu var ama zihnin seni engelliyor.",
                    GeneralReversed = "Zihinsel hapishaneden kurtulma, farkındalık ve kontrolü ele alma.",
                    LoveUpright = "İlişkide sıkışmışlık hissi ve kendini ifade edememe. Kendi korkuların seni partnerinden uzaklaştırıyor.",
                    LoveReversed = "İlişkideki baskıcı durumdan kurtulma. Özgürleşme ve partnerinle olan sorunları çözme cesareti.",
                    CareerUpright = "İş hayatında çıkmaza girdiğini düşünme. Sorumluluklar altında ezilme ve çözüm görememe.",
                    CareerReversed = "Kariyerindeki engellerin aslında kendi düşüncelerin olduğunu fark etme. Yeni bir iş planı yapma."
                },

                new TarotCard {
                    Id = 59, Name = "Kılıç Dokuzlusu", ImageName = "kilic_dokuzlusu_karti",
                    GeneralUpright = "Uykusuz geceler, kaygı, kabuslar ve aşırı stres. Sorunları zihninde büyütme ve suçluluk hissi.",
                    GeneralReversed = "Korkuların yersiz olduğunu anlama, rahatlama ve karamsarlıktan çıkış.",
                    LoveUpright = "İlişkiyle ilgili aşırı endişe ve uykusuzluk. Partnerinin seni terk edeceği veya aldattığı korkusu.",
                    LoveReversed = "Aşk hayatındaki takıntıların sona ermesi. Zihinsel olarak sakinleşme ve gerçeği kabullenme.",
                    CareerUpright = "İş yerinde büyük baskı ve başarısızlık korkusu. Stresten dolayı sağlığının etkilenmesi.",
                    CareerReversed = "İş hayatındaki en kötü dönemin geride kalması. Sorunlarla yüzleşip çözüm üretmeye başlama."
                },

                new TarotCard {
                    Id = 60, Name = "Kılıç Onlusu", ImageName = "kilic_onlusu_karti",
                    GeneralUpright = "Acı verici bir son, ihanet ve dibe vurma. Artık bundan daha kötüsü olamaz, şimdi yeniden doğma vakti.",
                    GeneralReversed = "Yavaş yavaş toparlanma, yıkımdan kurtulma ve hayatta kalma başarısı.",
                    LoveUpright = "İlişkinin büyük bir yıkımla bitmesi. Ağır bir ihanet veya tam bir duygusal kopuş.",
                    LoveReversed = "İlişkideki en zorlu dönemin geçmesi. Kötü günlerin ardından gelen umut ışığı ve iyileşme.",
                    CareerUpright = "İş yerinde beklenmedik bir işten çıkarılma veya projenin tamamen çökmesi. Büyük bir mağlubiyet.",
                    CareerReversed = "İş hayatındaki krizin dibinden dönme. Yeni bir kariyer yolu için küllerinden doğma hazırlığı."
                },

                new TarotCard {
                    Id = 61, Name = "Kılıç Prensi (Uşağı)", ImageName = "kilic_prensi_karti",
                    GeneralUpright = "Merak, yeni bir haber ve zihinsel uyanış. Tetikte olma ve gözlem yapma zamanı.",
                    GeneralReversed = "Dedikodu, boş laf ve asılsız haberler. Sabırsız ve kaba davranışlar sorun yaratabilir.",
                    LoveUpright = "İlişkide mantıklı konuşmalar veya partnerden gelen bir haber. Meraklı ve flörtöz bir enerji.",
                    LoveReversed = "Partnerle gereksiz tartışmalar ve casusluk yapma isteği. İlişkide dürüstlükten uzaklaşma.",
                    CareerUpright = "İş yerinde yeni fikirler ve araştırma süreci. Keskin zekanla yeni bir fırsatı fark etme.",
                    CareerReversed = "İş hayatında fevri konuşmaların işleri karıştırması. Bilgi kirliliği nedeniyle hata yapma."
                },

                new TarotCard {
                    Id = 62, Name = "Kılıç Şövalyesi", ImageName = "kilic_sovalyesi_karti",
                    GeneralUpright = "Hızlı eylem, kararlılık ve zihinsel hırs. Hedefe kilitlenip engelleri yakıp yıkma enerjisi.",
                    GeneralReversed = "Düşüncesizce atılan adımlar, saldırganlık ve kontrolsüz öfke. Hızın getirdiği felaketler.",
                    LoveUpright = "İlişkide dürüst ve doğrudan bir yaklaşım. Aşkını ilan etmekte aceleci ve tutkulu bir aday.",
                    LoveReversed = "Partnerle sert kavgalar ve kırıcı dürüstlük. İlişkiyi zora sokan sabırsız ve bencil tavırlar.",
                    CareerUpright = "İş hayatında agresif bir büyüme stratejisi. Rakipleri geride bırakan kararlı ve hızlı hamleler.",
                    CareerReversed = "İş yerinde plansız ve aceleci davranmak. Kariyerinde öfke kontrolü yapman gereken bir süreç."
                },

                new TarotCard {
                    Id = 63, Name = "Kılıç Kraliçesi", ImageName = "kilic_kralicesi_karti",
                    GeneralUpright = "Zeka, bağımsızlık ve tarafsızlık. Duygularından ziyade mantığıyla karar veren, bilge bir kadın.",
                    GeneralReversed = "Aşırı eleştirel, soğuk ve acımasız tavırlar. Geçmişteki acıların verdiği sert bir koruma kalkanı.",
                    LoveUpright = "İlişkide dürüstlük ve sınırların korunması. Partnerinle aranda zihinsel bir uyum arayışı.",
                    LoveReversed = "Partnerine karşı aşırı mesafeli ve iğneleyici olma. Duygusal soğukluk aranızdaki bağı koparabilir.",
                    CareerUpright = "İş yerinde objektif kararlar ve profesyonellik. Otoriteni zekanla kurduğun başarılı bir dönem.",
                    CareerReversed = "İş hayatında acımasız rekabet ve sert eleştiriler. Ekip arkadaşlarınla aranda oluşan duvarlar."
                },

                new TarotCard {
                    Id = 64, Name = "Kılıç Kralı", ImageName = "kilic_krali_karti",
                    GeneralUpright = "Disiplin, mantık, adalet ve otorite. Kararlarında net ve sarsılmaz bir liderlik duruşu.",
                    GeneralReversed = "Tiranlık, manipülasyon ve gücü kötüye kullanma. Acımasızca verilen yanlış kararlar.",
                    LoveUpright = "Güvenilir ama duygularını pek göstermeyen bir partner. Mantıklı ve sağlam temelli bir ilişki.",
                    LoveReversed = "İlişkide aşırı kontrolcü ve baskıcı tavırlar. Partnerini duygusal olarak ezme riski.",
                    CareerUpright = "Kariyerde en üst seviye yöneticilik ve stratejik başarı. Yasal konularda kazanılan zafer.",
                    CareerReversed = "İş hayatında katı ve esnemeyen kurallar. Otoriteni korkuyla kurmaya çalışmanın getirdiği sorunlar."
                },
                // --- TILSIMLAR SERİSİ (ID: 65 - 78) ---

                new TarotCard {
                    Id = 65, Name = "Tılsım Ası", ImageName = "tilsim_asi_karti",
                    GeneralUpright = "Maddi bir fırsat, bolluk başlangıcı ve somut başarı. Yeni bir kazanç kapısı aralanıyor.",
                    GeneralReversed = "Kaçırılan fırsatlar, finansal kayıplar ve yanlış yatırımlar. Bereketin tıkanması.",
                    LoveUpright = "Güven veren, sağlam temelli bir ilişkinin başlangıcı. Maddi ve manevi huzur.",
                    LoveReversed = "İlişkide güvensizlik veya partnerle maddi konularda yaşanan gerginlikler.",
                    CareerUpright = "Yeni bir iş teklifi, terfi veya başarılı bir yatırım. Emeklerinin somut karşılığını alma.",
                    CareerReversed = "İş hayatında beklenen desteğin gelmemesi. Projelerin finansal nedenlerle duraklaması."
                },

                new TarotCard {
                    Id = 66, Name = "Tılsım İkilisi", ImageName = "tilsim_ikilisi_karti",
                    GeneralUpright = "Denge kurma, öncelikleri belirleme ve esneklik. Hayatın koşturmacası içinde uyum sağlama.",
                    GeneralReversed = "Dengesizlik, sorumluluklar altında ezilme ve finansal karmaşa.",
                    LoveUpright = "Partnerle beraber hayatın zorluklarına göğüs germe ve zamanı iyi yönetme çabası.",
                    LoveReversed = "İlişkiye gereken zamanı ayıramama. İş ve aşk arasındaki dengenin bozulması.",
                    CareerUpright = "Aynı anda birden fazla projeyi başarıyla yürütme. Finansal akışın devamlılığı.",
                    CareerReversed = "İş hayatında plansızlık ve nakit akışında yaşanan büyük iniş çıkışlar."
                },

                new TarotCard {
                    Id = 67, Name = "Tılsım Üçlüsü", ImageName = "tilsim_uclusu_karti",
                    GeneralUpright = "Ekip çalışması, ustalık ve onaylanma. İşinde uzmanlaşma ve takdir görme zamanı.",
                    GeneralReversed = "Disiplinsizlik, ekip içi uyumsuzluk ve kalitesiz iş yapma.",
                    LoveUpright = "Partnerle ortak bir gelecek inşa etme; ev veya eşya alma gibi somut planlar.",
                    LoveReversed = "İlişkide emek vermekten kaçınma ve ortak hedeflerden uzaklaşma.",
                    CareerUpright = "Mesleki başarı, yeteneklerin fark edilmesi ve profesyonel iş birliği.",
                    CareerReversed = "İş yerinde düşük motivasyon ve yetersiz tecrübe nedeniyle yaşanan aksaklıklar."
                },

                new TarotCard {
                    Id = 68, Name = "Tılsım Dörtlüsü", ImageName = "tilsim_dortlusu_karti",
                    GeneralUpright = "Korumacılık, maddi güvenlik ve sahip olduklarına sıkıca tutunma. İstikrar arayışı.",
                    GeneralReversed = "Cimrilik, değişime direnme veya tam tersi aşırı savurganlık.",
                    LoveUpright = "İlişkide aşırı korumacı tavır ve güven ihtiyacı. Sınırları belirleme dönemi.",
                    LoveReversed = "Partneri kısıtlama veya duygusal olarak kendini kapatma. Paylaşımdan kaçınma.",
                    CareerUpright = "Maddi durumu koruma, garantici adımlar ve birikim yapma başarısı.",
                    CareerReversed = "İş hayatında yeniliklere kapalı olma ve fırsatları aşırı korku nedeniyle kaçırma."
                },

                new TarotCard {
                    Id = 69, Name = "Tılsım Beşlisi", ImageName = "tilsim_beslisi_karti",
                    GeneralUpright = "Maddi zorluklar, dışlanmış hissetme ve geçici darlık. Yardım istemekten çekinmemelisin.",
                    GeneralReversed = "Maddi durumun düzelmeye başlaması ve zor günlerin geride kalması.",
                    LoveUpright = "Birlikte zorluklara göğüs germe veya ilişkide duygusal olarak aç hissetme.",
                    LoveReversed = "İlişkideki krizlerin aşılması ve birbirine yeniden destek olma süreci.",
                    CareerUpright = "İş kaybı veya finansal kriz riski. Elindeki kaynakları çok dikkatli kullanmalısın.",
                    CareerReversed = "Kariyerde yeniden ayağa kalkma ve iş dünyasına geri dönüş başarısı."
                },

                new TarotCard {
                    Id = 70, Name = "Tılsım Altılısı", ImageName = "tilsim_altilisi_karti",
                    GeneralUpright = "Cömertlik, yardımseverlik ve adil paylaşım. Hem verme hem alma dengesinin kurulması.",
                    GeneralReversed = "Bencillik, borçlanma veya yapılan yardımın karşılığını kötü niyetle isteme.",
                    LoveUpright = "Partnerin desteğini görme; hem maddi hem manevi dengeli bir ilişki.",
                    LoveReversed = "İlişkide güç dengesinin bozulması; bir tarafın sürekli vermesi ve yorulması.",
                    CareerUpright = "Yatırım desteği alma, prim veya hak edilen bir ödemeye kavuşma.",
                    CareerReversed = "İş yerinde haksız kazanç veya finansal adaletsizliklerle karşılaşma."
                },

                new TarotCard {
                    Id = 71, Name = "Tılsım Yedilisi", ImageName = "tilsim_yedilisi_karti",
                    GeneralUpright = "Sabır, değerlendirme ve emeklerin meyvesini bekleme. Uzun vadeli planların sonucunu görme.",
                    GeneralReversed = "Sabırsızlık, boşa harcanan emek ve beklenen sonucun gelmemesi.",
                    LoveUpright = "İlişkinin geleceği hakkında düşünme ve yapılan yatırımların karşılığını alma süreci.",
                    LoveReversed = "Partnerle ortak bir gelecek görememe ve verilen emeklerin sorgulanması.",
                    CareerUpright = "İş hayatında büyüme evresi; sabırlı çalışmanın karşılığını almaya başlamak.",
                    CareerReversed = "Kariyerde yanlış strateji nedeniyle zaman kaybetme ve hayal kırıklığı."
                },

                new TarotCard {
                    Id = 72, Name = "Tılsım Sekizlisi", ImageName = "tilsim_sekizlisi_karti",
                    GeneralUpright = "Çalışkanlık, detaylara odaklanma ve zanaatkarlık. Kendini geliştirdiğin verimli bir dönem.",
                    GeneralReversed = "İşten kaçma, dikkatsizlik ve kalite eksikliği. Rutin işlerden sıkılma.",
                    LoveUpright = "İlişkiyi güzelleştirmek için gösterilen yoğun çaba ve sadakat.",
                    LoveReversed = "İlişkiyi ihmal etme ve partnerinle olan bağları geliştirmek için uğraşmama.",
                    CareerUpright = "Yeni bir beceri edinme, titiz çalışma ve mesleki uzmanlık kazanma.",
                    CareerReversed = "İş hayatında özensiz davranışlar nedeniyle prestij kaybı yaşama."
                },

                new TarotCard {
                    Id = 73, Name = "Tılsım Dokuzlusu", ImageName = "tilsim_dokuzlusu_karti",
                    GeneralUpright = "Maddi bağımsızlık, özgüven ve konforlu bir yaşam. Tek başına başarmanın gururu.",
                    GeneralReversed = "Aşırı harcama, dış görünüşe fazla önem verme veya finansal bağımlılık.",
                    LoveUpright = "Kendi değerini bilen, huzurlu ve kaliteli bir beraberlik. Kişisel alanlara saygı.",
                    LoveReversed = "İlişkide lüks tutkusunun sorun yaratması veya partnerden maddi beklentiler.",
                    CareerUpright = "Kariyerde zirveye ulaşma ve finansal özgürlüğün tadını çıkarma.",
                    CareerReversed = "İş hayatında başarıyı koruyamama ve dikkatsizce yapılan harcamalar."
                },

                new TarotCard {
                    Id = 74, Name = "Tılsım Onlusu", ImageName = "tilsim_onlusu_karti",
                    GeneralUpright = "Kalıcı zenginlik, aile mirası ve geleneksel başarı. Uzun vadeli güvence.",
                    GeneralReversed = "Aile içi miras kavgaları, geleneklerin bozulması ve maddi kayıp riski.",
                    LoveUpright = "Aile onaylı, sağlam ve köklü bir ilişki; evlilik veya ortak mülk sahibi olma.",
                    LoveReversed = "İlişkide maddi çıkarların ön plana çıkması veya aile baskısı.",
                    CareerUpright = "Kurumsal başarı, emeklilik güvencesi veya aile şirketinde yükseliş.",
                    CareerReversed = "İş hayatında köklü yapıların sarsılması ve finansal belirsizlikler."
                },

                new TarotCard {
                    Id = 75, Name = "Tılsım Prensi (Uşağı)", ImageName = "tilsim_prensi_karti",
                    GeneralUpright = "Maddi bir haber, yeni bir iş fırsatı veya öğrenmeye açık genç bir enerji.",
                    GeneralReversed = "Fırsatları kaçırma, plansızlık ve gerçeklerden uzak hayaller.",
                    LoveUpright = "İlişkide somut ve ciddi bir adım; gelecek vaat eden bir teklif.",
                    LoveReversed = "Aşkta ciddiyetsizlik ve sorumluluk almaktan kaçan bir partner.",
                    CareerUpright = "Yeni bir eğitim, staj fırsatı veya karlı bir projeye başlama.",
                    CareerReversed = "İş hayatında disiplinsizlik ve pratik zekayı kullanamama."
                },

                new TarotCard {
                    Id = 76, Name = "Tılsım Şövalyesi", ImageName = "tilsim_sovalyesi_karti",
                    GeneralUpright = "Sabır, güvenilirlik, rutin ve azimle çalışma. Hedefe yavaş ama emin adımlarla ilerleme.",
                    GeneralReversed = "Tembellik, aşırı muhafazakarlık ve değişimden korkma. Durağanlık.",
                    LoveUpright = "Sadık, güven veren ve her zaman yanında olan bir partner. Huzurlu rutinler.",
                    LoveReversed = "İlişkide heyecanın tamamen bitmesi ve monotonluğun can sıkıcı hale gelmesi.",
                    CareerUpright = "Sorumluluk sahibi olma, titiz iş takibi ve garantili başarılar.",
                    CareerReversed = "İş hayatında hantallık ve yeniliklere direnerek yerinde sayma."
                },

                new TarotCard {
                    Id = 77, Name = "Tılsım Kraliçesi", ImageName = "tilsim_kralicesi_karti",
                    GeneralUpright = "Pratiklik, cömertlik, anaçlık ve maddi başarı. Bereketli ve huzurlu bir kadın figürü.",
                    GeneralReversed = "İşkoliklik, aşırı maddeci olma veya ev düzeninin bozulması.",
                    LoveUpright = "Besleyici, güven dolu ve partnerine her anlamda destek olan bir sevgi.",
                    LoveReversed = "İlişkide aşırı sahiplenici olma ve duyguları maddeyle ölçme eğilimi.",
                    CareerUpright = "İş hayatında yöneticilik başarısı ve finansal kaynakları akıllıca yönetme.",
                    CareerReversed = "Kariyerde sadece paraya odaklanıp insan ilişkilerini ihmal etme."
                },

                new TarotCard {
                    Id = 78, Name = "Tılsım Kralı", ImageName = "tilsim_krali_karti",
                    GeneralUpright = "Finansal güç, istikrar, disiplin ve zirvede olma. Maddi dünyanın efendisi.",
                    GeneralReversed = "Açgözlülük, katılık ve parayı bir güç silahı olarak kullanma.",
                    LoveUpright = "Evi ve ailesi için her türlü imkanı sağlayan, sadık ve güçlü bir partner.",
                    LoveReversed = "İlişkide her şeyi parayla çözmeye çalışma ve duygusal soğukluk.",
                    CareerUpright = "Büyük iş başarıları, patronluk veya yüksek finansal kazanç dönemi.",
                    CareerReversed = "İş hayatında etik olmayan hırslar ve maddi kayba yol açan kibir."
                },


            };
        }
        public static List<TarotCard> GetShuffledDeck()
        {
            List<TarotCard> deck = GetAllCards();
            Random rnd = new Random();

            // Fisher-Yates Karıştırma Algoritması
            for (int i = deck.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                TarotCard temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
            return deck;
        }
    }
    }
