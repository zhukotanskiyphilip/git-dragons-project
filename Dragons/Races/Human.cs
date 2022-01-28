using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class Human : Character
    {
        // ОСОБЕННОСТИ ЛЮДЕЙ

        // Увеличение характеристик. Значение всех характеристик увеличивается на 1.
        // Возраст. Люди становятся взрослыми в районе 20 лет, и живут менее столетия. 
        // Мировоззрение. Люди не имеют склонности к определённому мировоззрению.
        // Размер. Средний.
        // Рост. 152 - 183 сантиметра.
        // Вес. 60 - 112 килограмм.
        // Скорость. 30 футов.
        // Языки. Общий и ещё один на выбор.

        // АЛЬТЕРНАТИВНЫЕ ОСОБЕННОСТИ ЛЮДЕЙ

        // Вместо указанного выше стандартного увеличения характеристик:
        // Увеличение характеристик. Значение двух характеристик на ваш выбор увеличивается на 1. 
        // Навыки. Вы получаете владение одним навыком на ваш выбор. 
        // Черта. Вы получаете одну черту на ваш выбор.

        // ВНЕШНОСТЬ
        // Волосы. Любые.
        public string[] allowedHair = { "None", "Short", "Long" };
        // Бороды. Любые.
        public string[] allowedBeard = { "None", "Short", "Long" };
        // Усы. Любые.
        public string[] allowedMustache = { "None", "Short", "Long" };

        // ПОДРАСЫ

        // Дамарец / Damaran
        // Кожа варьируется от смуглого до светлого.
        public string[] damaranSkinColor = { "Dark", "Light" };
        // Волосы обычно коричневые или чёрные.
        public string[] damaranHairColor = { "Brown", "Black" };
        // Цвет глаз - карие.
        public string[] damaranEyeColor = { "Brown" };

        string[] maleDamaranNames = { "Bor", "Fodel", "Glar", "Grigor", "Igan", "Ivor", "Kosef", "Mival", "Orel", "Pavel", "Sergor" };
        string[] femaleDamaranNames = { "Alethra", "Kara", "Katernin", "Mara", "Natali", "Olma", "Tana", "Zora" };
        string[] surnamesDamaran = { "Bersk", "Chernin", "Dotsk", "Kulenov", "Marsk", "Nemetsk", "Shemov", "Starag" };

        // Иллусканец / Illuskan
        // Кожа - светлая.
        public string[] illuskanSkinColor = { "Light" };
        // У большинства чёрные волосы цвета вороньего крыла, иногда светлые, рыжие или светло-русые волосы.
        public string[] illuskanHairColor = { "Black", "Blond", "Red", "Light Blond" };
        // Глаза - голубые или серые со стальным оттенком.
        public string[] illuskanEyeColor = { "Blue", "Gray" };

        string[] maleIlluskanNames = { "Ander", "Blath", "Bran", "Frath", "Geth", "Lander", "Luth", "Malcer", "Stor", "Taman", "Urth" };
        string[] femaleIlluskanNames = { "Amafrey", "Betha", "Cefrey", "Kethra", "Mara", "Olga", "Silifrey", "Westra" };
        string[] surnamesIlluskan = { "Brightwood", "Helder", "Hornraven", "Lackman", "Stormwind", "Windrivver" };

        // Калишит / Calishite
        // Кожа - смугло-коричневая.
        public string[] сalishiteSkinColor = { "Dark Brown" };
        // Волосы - коричневые.
        public string[] сalishiteHairColor = { "Brown" };
        // Глаза - коричневые.
        public string[] сalishiteEyeColor = { "Brown" };

        string[] maleCalishiteNames = { "Aseir", "Bardeid", "Haseid", "Khemed", "Mehmen", "Sudeiman", "Zasheir" };
        string[] femaleCalishiteNames = { "Atala", "Ceidil", "Hama", "Jasmal", "Meilil", "Seipora", "Yasheira", "Zasheida" };
        string[] surnamesCalishite = { "Basha", "Dumein", "Jassan", "Khalid", "Mostana", "Pashar", "Rein" };

        // Мулан / Mulan
        // Кожа - цвета янтаря.
        public string[] mulanSkinColor = { "Amber" };
        // Волосы - от чёрного до тёмно-коричневого оттенков.
        public string[] mulanHairColor = { "Black", "Dark Brown" };
        // Глаза - карие или светло-коричневые.
        public string[] mulanEyeColor = { "Brown", "Light Brown" };
        
        string[] maleMulanNames = { "Aoth", "Bareris", "Ehput-Ki", "Kethoth", "Mumed", "Ramas", "So-Kehur", "Thazar-De", "Urhur" };
        string[] femaleMulanNames = { "Arizima", "Chathi", "Nephis", "Nulara", "Murithi", "Sefris", "Thola", "Umara", "Zolis" };
        string[] surnamesMulan = { "Ankhalab", "Anskuld", "Fezim", "Hahpet", "Nathandem", "Sepret", "Uuthrakt" };

        // Рашеми / Rashemi
        // Кожа - тёмная.
        public string[] rashemiSkinColor = { "Dark" };
        // Волосы - чёрные.
        public string[] rashemiHairColor = { "Black" };
        // Глаза - чёрные.
        public string[] rashemiEyeColor = { "Black" };

        string[] maleRashemiNames = { "Borivik", "Faurgar", "Jandar", "Kanithar", "Madislak", "Ralmevik", "Shaumar", "Vladislak" };
        string[] femaleRashemiNames = { "Fyevarra", "Hulmarra", "Immith", "Imzel", "Navarra", "Shevarra", "Tammith", "Yuldra" };
        string[] surnamesRashemi = { "Chergoba", "Dyernina", "Iltazyara", "Murnyethara", "Stayanoga", "Ulmokina" };

        // Тетирец / Tethyrian
        // Кожа - смуглая.
        public string[] tethyrianSkinColor = { "Dark" };
        // Волосы - коричневые.
        public string[] tethyrianHairColor = { "Brown" };
        // Глаза - голубые.
        public string[] tethyrianEyeColor = { "Blue" };
        // Используют чондатанские имена.

        // Тёрами / Turami
        // Кожа - тёмно-красная.
        public string[] turamiSkinColor = { "Dark Red" };
        // Волосы - чёрные.
        public string[] turamiHairColor = { "Black" };
        // Глаза - чёрные.
        public string[] turamiEyeColor = { "Black" };

        string[] maleTuramiNames = { "Anton", "Diero", "Marcon", "Pieron", "Rimardo", "Romero", "Salazar", "Umbero" };
        string[] femaleTuramiNames = { "Balama", "Dona", "Faila", "Jalana", "Luisa", "Marta", "Quara", "Selise", "Vonda" };
        string[] surnamesTurami = { "Agosto", "Astorio", "Calabra", "Domine", "Falone", "Marivaldi", "Pisacar", "Ramondo" };

        // Чондатанец / Chondathan
        // Кожа - смуглая.
        public string[] chondathanSkinColor = { "Dark" };
        // Волосы - от светлых до почти чёрных.
        public string[] chondathanHairColor = { "Blond", "Black" };
        // Глаза - зелёные или карие.
        public string[] chondathanEyeColor = { "Green", "Brown" };

        string[] maleChondathanNames = { "Darvin", "Dorn", "Evendur", "Gorstag", "Grim", "Helm", "Malark", "Morn", "Randal", "Stedd" };
        string[] femaleChondathanNames = { "Arveene", "Esvele", "Jhessail", "Kerri", "Lureene", "Miri", "Rowan", "Shandri", "Tessele" };
        string[] surnamesChondathan = { "Amblecrown", "Buckman", "Dundragon", "Evenwood", "Greycastle", "Tallstag" };

        // Шу / Shou
        // Кожа - желтовато-бронзовая.
        public string[] shouSkinColor = { "Yellowish-Bronze" };
        // Волосы - тёмные.
        public string[] shouHairColor = { "Dark" };
        // Глаза - чёрные.
        public string[] shouEyeColor = { "Black" };

        string[] maleShouNames = { "An", "Chen", "Chi", "Fai", "Jiang", "Jun", "Lian", "Long", "Meng", "On", "Shan", "Shui", "Wen" };
        string[] femaleShouNames = { "Bai", "Chao", "Jia", "Lei", "Mei", "Qiao", "Shui", "Tai" };
        string[] surnamesShou = { "Chien", "Huang", "Kao", "Kung", "Lao", "Ling", "Mei", "Pin", "Shin", "Sum", "Tan", "Wan" };

        public Human(bool male, string subrace)
        {
            this.male = male;

            race = Race.Human;

            ageMin = 20;
            ageMax = 100;

            alignmentMin = 0;
            alignmentMax = 5;

            size = Size.Medium;

            heightMin = 152;
            heightMax = 183;

            weightMin = 60;
            weightMax = 112;

            speed = 30;

            RandomCharGen();

            strength++;
            agility++;
            constitution++;
            intelligence++;
            wisdom++;
            charisma++;

            switch (subrace)
            {
                case "Damaran":
                    RandomNameGen(maleDamaranNames, femaleDamaranNames, surnamesDamaran);
                    RandomAppearanceGen(male, damaranSkinColor, damaranHairColor, damaranEyeColor, allowedHair, allowedBeard, allowedMustache);
                    break;
                case "Illuskan":
                    RandomNameGen(maleIlluskanNames, femaleIlluskanNames, surnamesIlluskan);
                    break;
                case "Calishite":
                    RandomNameGen(maleCalishiteNames, femaleCalishiteNames, surnamesCalishite);
                    break;
                case "Mulan":
                    RandomNameGen(maleMulanNames, femaleMulanNames, surnamesMulan);
                    break;
                case "Rashemi":
                    RandomNameGen(maleRashemiNames, femaleRashemiNames, surnamesRashemi);
                    break;
                case "Tethyrian":
                    RandomNameGen(maleChondathanNames, femaleChondathanNames, surnamesChondathan);
                    break;
                case "Turami":
                    RandomNameGen(maleTuramiNames, femaleTuramiNames, surnamesTurami);
                    break;
                case "Chondathan":
                    RandomNameGen(maleChondathanNames, femaleChondathanNames, surnamesChondathan);
                    break;
                case "Shou":
                    RandomNameGen(maleShouNames, femaleShouNames, surnamesShou);
                    break;
            }
        }
    }
}
