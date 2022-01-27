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
        // Размер - Средний.
        // Рост - 152 - 183 сантиметра.
        // Вес - 60 - 112 килограмм.
        // Скорость - 30 футов.
        // Языки. Общий и ещё один на выбор.

        // АЛЬТЕРНАТИВНЫЕ ОСОБЕННОСТИ ЛЮДЕЙ

        // Вместо указанного выше стандартного увеличения характеристик:
        // Увеличение характеристик. Значение двух характеристик на ваш выбор увеличивается на 1. 
        // Навыки. Вы получаете владение одним навыком на ваш выбор. 
        // Черта. Вы получаете одну черту на ваш выбор.

        // ВНЕШНОСТЬ
        // Волосы - любые.
        public string[] allowedHair = { "None", "Short", "Long" };
        // Бороды - любые.
        public string[] allowedBeard = { "None", "Short", "Long" };
        // Усы - любые.
        public string[] allowedMustache = { "None", "Short", "Long" };

        // ПОДРАСЫ

        // Дамарец / Damaran
        // Кожа варьируется от смуглого до светлого.
        public string[] damaranSkinColor = { "Dark", "Light" };
        // Волосы обычно коричневые или чёрные.
        public string[] damaranHairColor = { "Brown", "Black" };
        // Цвет глаз - карие.
        public string[] damaranEyeColor = { "Brown" };

        string[] maleDamaranNames = { "Ivor", "Bor", "Glair", "Grigor", "Egan", "Kozef", "Mival", "Eagle", "Pavel", "Sergor", "Faudel" };
        string[] femaleDamaranNames = { "Aletra", "Zora", "Kara", "Katernin", "Mara", "Natalie", "Olma", "Tana" };
        string[] surnamesDamaran = { "Bersk", "Dotsk", "Kulenov", "Marsk", "German", "Starag", "Chernin", "Shemov" };

        // Иллусканец / Illuskan
        // Кожа - светлая.
        public string[] illuskanSkinColor = { "Light" };
        // У большинства чёрные волосы цвета вороньего крыла, иногда светлые, рыжие или светло-русые волосы.
        public string[] illuskanHairColor = { "Black", "Blond", "Red", "Light Blond" };
        // Глаза - голубые или серые со стальным оттенком.
        public string[] illuskanEyeColor = { "Blue", "Gray" };

        string[] maleIlluskanNames = { "Blas", "Bran", "Get", "Lander", "Lute", "Mulser", "Stor", "Taman", "Urt", "Frat", "Ender" };
        string[] femaleIlluskanNames = { "Amafrey", "Betkha", "Vestra", "Ketra", "Mara", "Olga", "Silifrey", "Cefrey" };
        string[] surnamesIlluskan = { "Brightwood", "Winddriver", "Luckman", "Helder", "Hornraven", "Stormwind" };

        // Калишит / Calishite
        // Кожа - смугло-коричневая.
        public string[] сalishiteSkinColor = { "Dark Brown" };
        // Волосы - коричневые.
        public string[] сalishiteHairColor = { "Brown" };
        // Глаза - коричневые.
        public string[] сalishiteEyeColor = { "Brown" };

        string[] maleCalishiteNames = { "Aseir", "Bardeid", "Zasheir", "Khemed", "Mehmen", "Sudeiman", "Haseid" };
        string[] femaleCalishiteNames = { "Atala", "Jasmal", "Zasheida", "Meilil", "Seydil", "Seipora", "Ham", "Yasheira" };
        string[] surnamesCalishite = { "Basha", "Jassan", "Dumein", "Khalid", "Mostana", "Pashar", "Rein" };

        // Мулан / Mulan
        // Кожа - цвета янтаря.
        public string[] mulanSkinColor = { "Amber" };
        // Волосы - от чёрного до тёмно-коричневого оттенков.
        public string[] mulanHairColor = { "Black", "Dark Brown" };
        // Глаза - карие или светло-коричневые.
        public string[] mulanEyeColor = { "Brown", "Light Brown" };
        
        string[] maleMulanNames = { "Aot", "Bareris", "Ketoth", "Mu med", "Ramas", "So - Kehur", "Thazar - De", "Urkhur", "Ehput Ki" };
        string[] femaleMulanNames = { "Arizima", "Zolis", "Muriti", "Nefis", "Nulara", "Sefris", "Tola", "Umar", "Chathi" };
        string[] surnamesMulan = { "Ankhalab", "Anskuld", "Natandem", "Serpet", "Uutrakt", "Fezim", "Hahpet" };

        // Рашеми / Rashemi
        // Кожа - тёмная.
        public string[] rashemiSkinColor = { "Dark" };
        // Волосы - чёрные.
        public string[] rashemiHairColor = { "Black" };
        // Глаза - чёрные.
        public string[] rashemiEyeColor = { "Black" };

        string[] maleRashemiNames = { "Borivik", "Vladislak", "Jandar", "Kanitar", "Madislak", "Ralmevik", "Faur Gar", "Shaumar" };
        string[] femaleRashemiNames = { "Imsel", "Immit", "Navarra", "Tammit", "Fayvarra", "Hulmarra", "Shevarra", "Yuldra" };
        string[] surnamesRashemi = { "Dairinina", "Iltaziara", "Murnitara", "Stayanoga", "Ulmokina", "Chergoba" };

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
        string[] femaleTuramiNames = { "Balama", "Vonda", "Jalana", "Dona", "Kuara", "Louise", "Martha", "Selise", "Faila" };
        string[] surnamesTurami = { "Agosto", "Astorio", "Domine", "Calabra", "Marivaldi", "Pisacar", "Ramondo", "Falone" };

        // Чондатанец / Chondathan
        // Кожа - смуглая.
        public string[] chondathanSkinColor = { "Dark" };
        // Волосы - от светлых до почти чёрных.
        public string[] chondathanHairColor = { "Blond", "Black" };
        // Глаза - зелёные или карие.
        public string[] chondathanEyeColor = { "Green", "Brown" };

        string[] maleChondathanNames = { "Gorstag", "Grim", "Darvin", "Dorn", "Malark", "Morn", "Randal", "Stedd", "Helm", "Evendur" };
        string[] femaleChondathanNames = { "Arvin", "Jessail", "Kerry", "Lurin", "Miri", "Rowan", "Tessele", "Shandry", "Esvel" };
        string[] surnamesChondathan = { "Buckman", "Graycastle", "Dundragon", "Tolstag", "Evenwood", "Emblecrown" };

        // Шу / Shou
        // Кожа - желтовато-бронзовая.
        public string[] shouSkinColor = { "Yellowish-Bronze" };
        // Волосы - тёмные.
        public string[] shouHairColor = { "Dark" };
        // Глаза - чёрные.
        public string[] shouEyeColor = { "Black" };

        string[] maleShouNames = { "An", "Wen", "Long", "Lian", "Meng", "On", "Fai", "Jiong", "Jian", "Chen", "Chi", "Shan", "Shui" };
        string[] femaleShouNames = { "Bai", "Xiao", "Lei", "Mei", "Tai", "Jia", "Chao", "Shui" };
        string[] surnamesShou = { "Wan", "Kao", "Kung", "Lao", "Ling", "Mei", "Ping", "Sum", "Tan", "Huang", "Chien", "Shin" };

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
