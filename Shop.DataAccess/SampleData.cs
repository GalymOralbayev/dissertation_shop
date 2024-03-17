using Shop.DataAccess.Models;
using System.Collections.Generic;


namespace Shop.DataAccess
{
    public class SampleData
    {
        public static List<Product> GetDefaultProducts()
        {
            var products = new List<Product>();
            // Ноутбуки
            products.Add(new Product
            {
                Name = "Ноутбук ASUS ROG Zephyrus S GX531GX",
                Price = 199990,
                Description = "15.6-дюймовый игровой ноутбук с процессором Intel Core i7, 24 ГБ оперативной памяти и 1 ТБ SSD-накопителем.",
                ImagePath = "https://www.mechta.kz/export/1cbitrix/import_files/74/740bc8c3-79cd-11ed-a250-005056b6dbd7-480.webp"
            });
            products.Add(new Product
            {
                Name = "Ноутбук HP Spectre x360",
                Price = 139990,
                Description = "13.3-дюймовый ноутбук-трансформер с процессором Intel Core i7, 16 ГБ оперативной памяти и 1 ТБ SSD-накопителем.",
                ImagePath = "https://nout.kz/upload/resize_cache/webp/upload/iblock/088/sz6ef7r6r7mqyy37ewry61g33x21dbxq/gpd1rahb9i1.webp"
            });
            products.Add(new Product
            {
                Name = "Ноутбук Dell XPS 13",
                Price = 99990,
                Description = "13.3-дюймовый ноутбук с процессором Intel Core i5, 8 ГБ оперативной памяти и 512 ГБ SSD-накопителем.",
                ImagePath = "https://itmag.kz/upload/iblock/8/15/product_image_12415_1067777.jpg"
            });
            products.Add(new Product
            {
                Name = "Ноутбук Lenovo ThinkPad X1 Carbon",
                Price = 129990,
                Description = "14-дюймовый ноутбук с процессором Intel Core i7, 16 ГБ оперативной памяти и 1 ТБ SSD-накопителем.",
                ImagePath = "https://notik.kz/wp-content/uploads/2022/02/1-1.png"
            });
            products.Add(new Product
            {
                Name = "Ноутбук MSI GS75 Stealth",
                Price = 199990,
                Description = "17.3-дюймовый игровой ноутбук с процессором Intel Core i7, 32 ГБ оперативной памяти и 1 ТБ SSD-накопителем.",
                ImagePath = "https://static.apltech.kz/uploads/products/4/176846/c5d578f0a7583993101e3c3a151ecd8a@500.jpg"
            });

            // Смартфоны (продолжение)
            products.Add(new Product
            {
                Name = "Смартфон Apple iPhone 12",
                Price = 79990,
                Description = "Смартфон с 6.1-дюймовым дисплеем Super Retina XDR, процессором A14 Bionic, 4 ГБ оперативной памяти и 128 ГБ накопителем.",
                ImagePath = "https://object.pscloud.io/cms/cms/Photo/img_0_77_2647_0_1.jpg"
            });
            products.Add(new Product
            {
                Name = "Смартфон Xiaomi Mi 11",
                Price = 59990,
                Description = "Смартфон с 6.81-дюймовым дисплеем, процессором Snapdragon 888, 8 ГБ оперативной памяти и 256 ГБ накопителем.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F253536_1.jpg&w=3840&q=85"
            });
            products.Add(new Product
            {
                Name = "Смартфон OnePlus 9 Pro",
                Price = 79990,
                Description = "Смартфон с 6.7-дюймовым дисплеем, процессором Snapdragon 888, 12 ГБ оперативной памяти и 256 ГБ накопителем.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F255788_1.jpg&w=3840&q=85"
            });
            products.Add(new Product
            {
                Name = "Смартфон Sony Xperia 5 II",
                Price = 73990,
                Description = "Смартфон с 6.1-дюймовым дисплеем, процессором Snapdragon 865, 8 ГБ оперативной памяти и 256 ГБ накопителем.",
                ImagePath = "https://sonycenter.kz/image/cache/catalog/products/old/Xperia-5-II-XQ-AS52-B1RUCX3-%D0%A7%D0%B5%D1%80%D0%BD%D1%8B%D0%B9/Xperia-5-II-XQ-AS52-B1RUCX3-%D0%A7%D0%B5%D1%80%D0%BD%D1%8B%D0%B9-9570-600x600.png"
            });
            products.Add(new Product
            {
                Name = "Смартфон Google Pixel 5",
                Price = 59990,
                Description = "Смартфон с 6-дюймовым дисплеем, процессором Snapdragon 765G, 8 ГБ оперативной памяти и 128 ГБ накопителем.",
                ImagePath = "https://static.insales-cdn.com/r/wO_vyX7DU3A/rs:fit:600:600:1/plain/images/products/1/1401/360457593/1601478066_IMG_1425819.jpg"
            });

            // Планшеты
            products.Add(new Product
            {
                Name = "Планшет Apple iPad Air",
                Price = 58990,
                Description = "10.9-дюймовый планшет с процессором Apple A14 Bionic, 4 ГБ оперативной памяти и 256 ГБ накопителем.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F227297_1.jpg&w=3840&q=85"
            });
            products.Add(new Product
            {
                Name = "Планшет Samsung Galaxy Tab S7+",
                Price = 86990,
                Description = "12.4-дюймовый планшет с процессором Qualcomm Snapdragon 865+, 6 ГБ оперативной памяти и 256 ГБ накопителем.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F221899_1.jpg&w=3840&q=85"
            });
            products.Add(new Product
            {
                Name = "Планшет Huawei MatePad Pro",
                Price = 46990,
                Description = "10.8-дюймовый планшет с процессором Kirin 990, 6 ГБ оперативной памяти и 256 ГБ накопителем.",
                ImagePath = "https://images.satu.kz/175478060_w640_h640_planshet-huawei-matepad.jpg"
            });
            products.Add(new Product
            {
                Name = "Планшет Lenovo Yoga Smart Tab",
                Price = 22990,
                Description = "10.1-дюймовый планшет с процессором Qualcomm Snapdragon 439, 4 ГБ оперативной памяти и 64 ГБ накопителем.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F229642_2.jpg&w=3840&q=85"
            });
            products.Add(new Product
            {
                Name = "Планшет Microsoft Surface Pro 7",
                Price = 79990,
                Description = "12.3-дюймовый планшет-трансформер с процессором Intel Core i5, 8 ГБ оперативной памяти и 256 ГБ накопителем.",
                ImagePath = "https://static.apltech.kz/uploads/products/278/144722/6c02ac389c5699232bd948c9a432bc1e@500.jpg"
            });

            // Наушники
            products.Add(new Product
            {
                Name = "Беспроводные наушники Apple AirPods Pro",
                Price = 21990,
                Description = "Беспроводные наушники с системой активного шумоподавления и долгим временем работы.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F254609_1bvc.jpg&w=3840&q=85"
            });
            products.Add(new Product
            {
                Name = "Беспроводные наушники Sony WF-1000XM3",
                Price = 19990,
                Description = "Беспроводные наушники с системой активного шумоподавления и долгим временем работы.",
                ImagePath = "https://sonycenter.kz/image/cache/catalog/products/old/WF1000XM3S.E/WF1000XM3S.E-9102-600x600.png"
            });
            products.Add(new Product
            {
                Name = "Наушники Bose QuietComfort 35 II",
                Price = 29990,
                Description = "Беспроводные наушники с системой активного шумоподавления и долгим временем работы.",
                ImagePath = "https://api.technodom.kz/f3/api/v1/images/67076_2q.jpg"
            });
            products.Add(new Product
            {
                Name = "Беспроводные наушники Jabra Elite 85t",
                Price = 19990,
                Description = "Беспроводные наушники с системой актив процессором Qualcomm Snapdragon 865 +,6 ГБ оперативной памяти и 256 ГБ накопителем.",
                ImagePath = "https://assets2.jabra.com/5/d/a/1/5da18ab3fed7d29c06b3a845ba7aefe0b2910f10_Jabra_elite85t_gold_beige_01.png?w=700&h=700"
            });
            products.Add(new Product
            {
                Name = "Беспроводные наушники Samsung Galaxy Buds Pro",
                Price = 14990,
                Description = "Беспроводные наушники с системой активного шумоподавления и долгим временем работы.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F233054_2x.jpg&w=3840&q=85"
            });
            products.Add(new Product
            {
                Name = "Наушники Sony WH-1000XM4",
                Price = 29990,
                Description = "Беспроводные наушники с активным шумоподавлением, технологией LDAC и до 30 часовой автономной работы.",
                ImagePath = "https://www.kz.sony.ru/image/5d02da5df552836db894cead8a68f5f3?fmt=pjpeg&wid=330&bgcolor=FFFFFF&bgc=FFFFFF"
            });

            // Телевизоры
            products.Add(new Product
            {
                Name = "Телевизор LG OLED65C1",
                Price = 174990,
                Description = "65-дюймовый телевизор с OLED-дисплеем, процессором α9 Gen4 AI и поддержкой HDR10, HLG и Dolby Vision IQ.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F242458_3.jpg&w=3840&q=85"
            });
            products.Add(new Product
            {
                Name = "Телевизор Samsung QE55QN90AAUXRU",
                Price = 99990,
                Description = "55-дюймовый телевизор с QLED-дисплеем, процессором Quantum Processor 4K и поддержкой HDR10+.",
                ImagePath = "https://treolink.ru/image/catalog/easyphoto/8593/samsung-qe55qn90aauxru-02-png-5.png"
            });
            products.Add(new Product
            {
                Name = "Телевизор Sony KD-75XH9005",
                Price = 219990,
                Description = "75-дюймовый телевизор с LED-дисплеем, процессором X1 4K HDR и поддержкой HDR10, HLG и Dolby Vision.",
                ImagePath = "https://tv-mir.com.ua/image/cache/catalog/import_files/60/6016bedae5eb11eaab5ac4346b7bbf8d_6ddf7f9ef6d111eaab5cc4346b7bbf8d-750x750.jpeg"
            });
            products.Add(new Product
            {
                Name = "Телевизор Philips 58PUS7855",
                Price = 46990,
                Description = "58-дюймовый телевизор с LED-дисплеем, процессором P5 Perfect Picture и поддержкой HDR10+ и Dolby Vision.",
                ImagePath = "https://telepedia.pl/wp-content/uploads/2020/09/Telewizor-Philips-58PUS785512.jpeg"
            });
            products.Add(new Product
            {
                Name = "Телевизор Xiaomi Mi TV Q1 75",
                Price = 149990,
                Description = "75-дюймовый телевизор с QLED-дисплеем, процессором MediaTek MT9611 и поддержкой HDR10+ и Dolby Vision.",
                ImagePath = "https://object.pscloud.io/cms/cms/Photo/img_0_95_2268_1_1.jpg"
            });
            products.Add(new Product
            {
                Name = "Телевизор Philips 58PUS7855",
                Price = 46990,
                Description = "58-дюймовый телевизор с LED-дисплеем, процессором P5 Perfect Picture и поддержкой HDR10+ и Dolby Vision.",
                ImagePath = "https://telepedia.pl/wp-content/uploads/2020/09/Telewizor-Philips-58PUS785512.jpeg"
            });

            products.Add(new Product
            {
                Name = "Смартфон Samsung Galaxy S21",
                Price = 219990,
                Description = "Мощный смартфон с процессором Exynos 2100, тройной камерой и AMOLED-дисплеем.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F263965_1v.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Ноутбук Apple MacBook Pro",
                Price = 549990,
                Description = "Мощный ноутбук с процессором M1, 16 ГБ оперативной памяти и Retina-дисплеем.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F254634_2.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Наушники Sony WH-1000XM4",
                Price = 99990,
                Description = "Беспроводные наушники с активным шумоподавлением и высоким качеством звука.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F221950_3.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Фотоаппарат Canon EOS R6",
                Price = 729990,
                Description = "Полнокадровая беззеркальная камера с разрешением 20.1 МП и возможностью съемки видео 4K.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F222025_2z.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Игровая консоль PlayStation 5",
                Price = 559990,
                Description = "Новое поколение игровой консоли с мощным процессором, быстрой SSD и поддержкой игр в разрешении 4K.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2Figrovaya_konsol_sony_playstation_5_221389_1.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Умные часы Apple Watch Series 6",
                Price = 159990,
                Description = "Умные часы с функцией измерения уровня кислорода в крови, ECG и множеством тренировок.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F227242_2.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Планшет Samsung Galaxy Tab S7+",
                Price = 349990,
                Description = "Мощный планшет с большим Super AMOLED-дисплеем, поддержкой пером S Pen и быстрым процессором.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F235665_3.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Умная колонка Amazon Echo (4-е поколение)",
                Price = 39990,
                Description = "Умная колонка с голосовым помощником Alexa, улучшенным звуком и возможностью управления умным домом.",
                ImagePath = "https://ae04.alicdn.com/kf/S3e3feaacd7114695b06e8db17ed00617U.jpg_640x640.jpg"
            });

            products.Add(new Product
            {
                Name = "Игровой компьютер ASUS ROG Strix G15",
                Price = 569990,
                Description = "Мощный игровой компьютер с процессором Intel Core i7, видеокартой NVIDIA GeForce RTX 3070 и RGB-подсветкой.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F232586_1vc.jpg&w=3840&q=85"
            });
            products.Add(new Product
            {
                Name = "Ноутбук Lenovo ThinkPad X1 Carbon",
                Price = 519990,
                Description = "Легкий и надежный ноутбук с процессором Intel Core i7, 16 ГБ оперативной памяти и SSD-накопителем.",
                ImagePath = "https://nout.kz/upload/resize_cache/webp/iblock/f8b/878981_02.webp"
            });

            products.Add(new Product
            {
                Name = "Наушники AirPods Pro",
                Price = 87990,
                Description = "Беспроводные наушники с активным шумоподавлением, качественным звуком и удобным фирменным дизайном.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F265484_2.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Фотоаппарат Nikon Z6 II",
                Price = 599990,
                Description = "Полнокадровая беззеркальная камера с разрешением 24.5 МП и возможностью съемки видео 4K.",
                ImagePath = "https://pspdf.kz/image/catalog/products/camera/nikon/z6ii/1.jpg"
            });

            products.Add(new Product
            {
                Name = "Игровая консоль Xbox Series X",
                Price = 619990,
                Description = "Мощная игровая консоль нового поколения с процессором AMD Zen 2, быстрым SSD и поддержкой разрешения 4K.",
                ImagePath = "https://object.pscloud.io/cms/cms/Photo/img_0_68_218_3_1.jpg"
            });

            products.Add(new Product
            {
                Name = "Умные часы Garmin Fenix 6",
                Price = 429990,
                Description = "Умные часы для спорта и активного образа жизни с функциями GPS, мониторингом сердечного ритма и многофункциональным дисплеем.",
                ImagePath = "https://images.satu.kz/108089153_chasy-s-gps.jpg"
            });

            products.Add(new Product
            {
                Name = "Планшет iPad Pro",
                Price = 399990,
                Description = "Мощный планшет с дисплеем Liquid Retina XDR, процессором M1 и поддержкой Apple Pencil и Magic Keyboard.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F245543_4.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Монитор Dell UltraSharp U2720Q",
                Price = 299990,
                Description = "27-дюймовый монитор с разрешением 4K, широким цветовым охватом и возможностью настройки положения.",
                ImagePath = "https://images.satu.kz/131776803_w600_h600_131776803.jpg"
            });

            products.Add(new Product
            {
                Name = "Внешний SSD-накопитель Samsung T7",
                Price = 99990,
                Description = "Быстрый и компактный внешний накопитель емкостью 1 ТБ для хранения и передачи данных.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F217455_5.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Беспроводная зарядка Samsung Duo Pad",
                Price = 49990,
                Description = "Беспроводная зарядная площадка с возможностью зарядки двух устройств одновременно, например, смартфона и наушников.",
                ImagePath = "https://www.ixbt.com/img/n1/news/2019/1/3/samsung-charging-duo-pad-amp-wireless-powerbank_large.png"
            });
            products.Add(new Product
            {
                Name = "Ноутбук MacBook Pro 16",
                Price = 899990,
                Description = "Мощный ноутбук с дисплеем Retina, процессором Intel Core i9, 16 ГБ оперативной памяти и SSD-накопителем.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F254631_2.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Умные колонки Google Nest Audio",
                Price = 64990,
                Description = "Беспроводные колонки с голосовым управлением Google Assistant и качественным звуком для домашнего использования.",
                ImagePath = "https://smart-gadget.club/image/cache/catalog/Products/home-gadgets/Google-nest-audio/google-nest-audio-1-800x800.jpg"
            });

            products.Add(new Product
            {
                Name = "Камера GoPro HERO9 Black",
                Price = 349990,
                Description = "Камера экшн с разрешением 5K, устойчивостью к воде и ударопрочным корпусом для съемки приключений.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F229384_3.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Геймпад Xbox Wireless Controller",
                Price = 25990,
                Description = "Беспроводной геймпад для игровой консоли Xbox и ПК с улучшенным дизайном и функциональностью.",
                ImagePath = "https://simg2.marwin.kz/media/catalog/product/c/a/xbox_series_sx_wireless_remote_controller_carbon_black.jpg"
            });

            products.Add(new Product
            {
                Name = "Умный термостат Nest Learning Thermostat",
                Price = 129990,
                Description = "Умный термостат с возможностью программирования и дистанционного управления температурой в помещении.",
                ImagePath = "https://icult.ru/files/item/29613/2_big_nowater.jpg"
            });

            products.Add(new Product
            {
                Name = "Видеокарта NVIDIA GeForce RTX 3080",
                Price = 999990,
                Description = "Мощная видеокарта с поддержкой трассировки лучей и высокой производительностью для игр и графической работы.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F263591_9.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Смартфон Samsung Galaxy S21 Ultra",
                Price = 499990,
                Description = "Многофункциональный смартфон с большим дисплеем, мощным процессором и множеством возможностей для фотографии и видеосъемки.",
                ImagePath = "https://object.pscloud.io/cms/cms/Photo/img_0_77_2798_8_1.jpg"
            });

            products.Add(new Product
            {
                Name = "Фитнес-трекер Fitbit Charge 4",
                Price = 49990,
                Description = "Умный браслет для отслеживания активности, сердечного ритма и сна с встроенным GPS и водозащитой.",
                ImagePath = "https://lap.kz/wp-content/uploads/2021/01/prod1-1.png"
            });

            products.Add(new Product
            {
                Name = "Умные часы Apple Watch Series 7",
                Price = 299990,
                Description = "Современные умные часы с крупным дисплеем, функцией ECG и множеством тренировок и приложений.",
                ImagePath = "https://video-shoper.ru/upload/iblock/bfb/bfb0730d5fb708cf064ef36f5e630285.jpg"
            });

            products.Add(new Product
            {
                Name = "Игровая клавиатура Razer Huntsman Elite",
                Price = 49990,
                Description = "Механическая игровая клавиатура с многоцветной подсветкой и быстрым откликом клавиш.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F255150_1.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Беспроводные наушники Bose QuietComfort 35 II",
                Price = 199990,
                Description = "Комфортные беспроводные наушники с активным шумоподавлением и кристально чистым звуком.",
                ImagePath = "https://object.pscloud.io/cms/cms/Photo/img_0_83_880_3.jpg"
            });

            products.Add(new Product
            {
                Name = "Смарт-часы Samsung Galaxy Watch 4",
                Price = 279990,
                Description = "Умные часы с круглым дисплеем, множеством тренировок и возможностью отслеживания здоровья.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F250513_1.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Мышь Logitech MX Master 3",
                Price = 29990,
                Description = "Беспроводная мышь с премиальным дизайном, высокой точностью и возможностью управления несколькими устройствами.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F244279_1.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Мышь Razer DeathAdder V2",
                Price = 14990,
                Description = "Игровая мышь с высокой скоростью отклика, эргономичным дизайном и точностью движений.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F216913_1.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Мышь SteelSeries Rival 650",
                Price = 22990,
                Description = "Беспроводная игровая мышь с двумя сенсорами, быстрой зарядкой и настраиваемыми кнопками.",
                ImagePath = "https://object.pscloud.io/cms/cms/Photo/img_0_89_498_0.png"
            });

            products.Add(new Product
            {
                Name = "Мышь Corsair Dark Core RGB Pro",
                Price = 19990,
                Description = "Беспроводная игровая мышь с высокой точностью, персонализируемой подсветкой и долгим сроком службы батареи.",
                ImagePath = "https://static.apltech.kz/uploads/products/18/162398/31a9c5ca7b0110a5a5cf5605f499fdf3@500.jpg"
            });

            products.Add(new Product
            {
                Name = "Мышь Microsoft Surface Precision",
                Price = 24990,
                Description = "Профессиональная мышь с высокой точностью, настраиваемыми кнопками и удобной эргономикой.",
                ImagePath = "https://m.media-amazon.com/images/I/61nUB2v0fjL.jpg"
            });

            products.Add(new Product
            {
                Name = "Мышь HP Wireless Mouse 200",
                Price = 4990,
                Description = "Беспроводная мышь с простым и надежным дизайном для повседневного использования.",
                ImagePath = "https://i0.wp.com/westgate.ng/wp-content/uploads/2022/06/HP-Wireless-Mouse-200-Pike-Silver-Westgate-Technologies-Ltd-2.jpg"
            });

            products.Add(new Product
            {
                Name = "Мышь Logitech G502 HERO",
                Price = 14990,
                Description = "Игровая мышь с высокой чувствительностью, настраиваемыми весами и кнопками для макросов.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F212634_1d.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Мышь Apple Magic Mouse 2",
                Price = 14990,
                Description = "Беспроводная мышь с многофункциональной поверхностью касания и интеграцией с macOS.",
                ImagePath = "https://cdn.shoplightspeed.com/shops/662820/files/47558782/800x800x3/apple-apple-magic-mouse-2-besprovodnaja-mysh-dlja.jpg"
            });

            products.Add(new Product
            {
                Name = "Мышь ASUS ROG Gladius III",
                Price = 19990,
                Description = "Игровая мышь с высокой скоростью отклика, персонализируемой подсветкой и настраиваемыми кнопками.",
                ImagePath = "https://static.apltech.kz/uploads/products/18/187066/f3a0c59a334162b429ee1aace78a75d6@500.jpg"
            });

            products.Add(new Product
            {
                Name = "Мышь Dell MS116",
                Price = 3990,
                Description = "Компактная мышь с проводным подключением и простым дизайном для повседневного использования.",
                ImagePath = "https://c.dns-shop.ru/thumb/st4/fit/300/300/b9e1dc2354b4c9f4ca4f5f9dd03d6eb4/c35dc48e1e932e17e902752296a27daf8e1353efcd0c2cd85e53c47c0c2e8708.jpg"
            });

            products.Add(new Product
            {
                Name = "Клавиатура A4Tech KRS-8372",
                Price = 9990,
                Description = "Механическая клавиатура A4Tech KRS-8372 с подсветкой и разъемом USB.",
                ImagePath = "https://c.dns-shop.ru/thumb/st1/fit/300/300/508f0f6ef38bab525223ba51292fdbe8/305adb97a754a9ce5594dab5c8fd723b0db17d0e79aae58e79a2d195b639eb82.jpg"
            });

            products.Add(new Product
            {
                Name = "Клавиатура Logitech G413 Carbon",
                Price = 28990,
                Description = "Механическая игровая клавиатура Logitech G413 Carbon с подсветкой и разъемом USB.",
                ImagePath = "https://static.apltech.kz/uploads/products/18/48251/6795a184f7f180c2001e147e3b601af5@500.jpg"
            });

            products.Add(new Product
            {
                Name = "Клавиатура Razer Huntsman Mini",
                Price = 56990,
                Description = "Механическая игровая клавиатура Razer Huntsman Mini с подсветкой и разъемом USB.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F243623_1.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Клавиатура Corsair K95 RGB Platinum",
                Price = 87990,
                Description = "Механическая игровая клавиатура Corsair K95 RGB Platinum с подсветкой и разъемом USB.",
                ImagePath = "https://static.apltech.kz/uploads/products/18/108238/75ab7ffd534737400834a6e56dd5a313@500.jpg"
            });

            products.Add(new Product
            {
                Name = "Клавиатура HyperX Alloy Elite 2",
                Price = 59990,
                Description = "Механическая игровая клавиатура HyperX Alloy Elite 2 с подсветкой и разъемом USB.",
                ImagePath = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F224418_1.jpg&w=3840&q=85"
            });

            products.Add(new Product
            {
                Name = "Зарядное устройство Xiaomi 18W",
                Price = 2590,
                Description = "Зарядное устройство Xiaomi 18W с быстрой зарядкой и разъемом USB Type-C.",
                ImagePath = "https://mi-shop.kg/wp-content/uploads/2018/11/6956.970.jpgg"
            });

            products.Add(new Product
            {
                Name = "Зарядное устройство Samsung EP-TA20EWE",
                Price = 3990,
                Description = "Зарядное устройство Samsung EP-TA20EWE с быстрой зарядкой и разъемом USB Type-C.",
                ImagePath = "https://tech1.lv/images/product_prod_fancy//upload-files/aza-ext4oc-94-db71-f923cd23-90534jpg.jpg"
            });

            products.Add(new Product
            {
                Name = "Зарядное устройство Apple USB Power Adapter",
                Price = 7990,
                Description = "Зарядное устройство Apple USB Power Adapter с быстрой зарядкой и разъемом USB Type-A.",
                ImagePath = "https://images.satu.kz/141599491_w640_h640_zaryadnoe-ustrojstvo-apple.jpg"
            });

            products.Add(new Product
            {
                Name = "Зарядное устройство Huawei HW-059200E01",
                Price = 2190,
                Description = "Зарядное устройство Huawei HW-059200E01 с быстрой зарядкой и разъемом USB Type-C.",
                ImagePath = "https://ae04.alicdn.com/kf/Hdaa353dcb2024f4183d382cf8460b075f.jpg"
            });

            products.Add(new Product
            {
                Name = "Зарядное устройство Anker PowerPort Speed 5",
                Price = 10990,
                Description = "Зарядное устройство Anker PowerPort Speed 5 с быстрой зарядкой и пятью разъемами USB.",
                ImagePath = "https://flashcom.ru/upload/iblock/d7c/d7c5a8f8056097674649a42c08d39107.jpeg"
            });

            products.Add(new Product
            {
                Name = "USB-кабель Baseus Rapid Series",
                Price = 2490,
                Description = "USB-кабель Baseus Rapid Series с разъемами USB Type-C и Lightning для зарядки и передачи данных.",
                ImagePath = "https://images.satu.kz/161455207_w640_h640_kabel-baseus-halo.jpg"
            });

            products.Add(new Product
            {
                Name = "USB-кабель Remax Armor",
                Price = 1990,
                Description = "USB-кабель Remax Armor с разъемами USB Type-C и Micro USB для зарядки и передачи данных.",
                ImagePath = "https://images.satu.kz/158319863_kabel-remax-armor.jpg"
            });

            products.Add(new Product
            {
                Name = "USB-кабель Apple Type-C - Lightning",
                Price = 1490,
                Description = "USB-кабель Apple Type-C - Type-C с разъемами USB Type-C и Lightning для зарядки и передачи данных.",
                ImagePath = "https://cdn.shoplightspeed.com/shops/662820/files/47558865/800x800x3/apple-apple-lightning-na-usb-c-2-metra-kabel-dlja.jpg"
            });

            products.Add(new Product
            {
                Name = "USB-кабель Samsung EP-DG950CBE",
                Price = 2990,
                Description = "USB-кабель Samsung EP-DG950CBE с разъемами USB Type-C и USB Type-A для зарядки и передачи данных.",
                ImagePath = "https://img.merkandi.com/imgcache/resized/images/offer/2017/10/12//ep-dn930cwe-1507841688-1507841694.jpg"
            });

            products.Add(new Product
            {
                Name = "USB-кабель Xiaomi Micro USB",
                Price = 990,
                Description = "USB-кабель Xiaomi Micro USB для зарядки и передачи данных.",
                ImagePath = "https://dropshop.kz/image/cache/catalog/Products/Aksessuar/USB/Xiaomi%20MicroUsb/xiaomi-micro-usb-cable-500x500.jpg"
            });
            return products;
        }
    }
}