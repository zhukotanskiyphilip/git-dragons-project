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
        // Рост от 152 до 184 сантиметров.
        // Вес от 60 до 112 килограмм.
        // Возраст от 20 до 100 лет.

        // Дамарец / Damaran
        // Кожа варьируется от смуглого до светлого.
        // Волосы обычно коричневые или чёрные.
        // Цвет глаз - карие.

        string[] maleDamaranNames = { "Ivor", "Bor", "Glair", "Grigor", "Egan", "Kozef", "Mival", "Eagle", "Pavel", "Sergor", "Faudel" };
        string[] femaleDamaranNames = { "Aletra", "Zora", "Kara", "Katernin", "Mara", "Natalie", "Olma", "Tana" };
        string[] surnamesDamaran = { "Bersk", "Dotsk", "Kulenov", "Marsk", "German", "Starag", "Chernin", "Shemov" };

        // Иллусканец / Illuskan
        // Кожа - светлая.
        // Глаза - голубые или серые со стальным оттенком. 
        // У большинства чёрные волосы цвета вороньего крыла, иногда светлые, рыжие или светло-русые волосы.

        string[] maleIlluskanNames = { "Blas", "Bran", "Get", "Lander", "Lute", "Mulser", "Stor", "Taman", "Urt", "Frat", "Ender" };
        string[] femaleIlluskanNames = { "Amafrey", "Betkha", "Vestra", "Ketra", "Mara", "Olga", "Silifrey", "Cefrey" };
        string[] surnamesIlluskan = { "Brightwood", "Winddriver", "Luckman", "Helder", "Hornraven", "Stormwind" };

        // Калишит / Calishite
        // Имеют смугло-коричневую кожу, волосы и глаза.

        string[] maleCalishiteNames = { "Aseir", "Bardeid", "Zasheir", "Khemed", "Mehmen", "Sudeiman", "Haseid" };
        string[] femaleCalishiteNames = { "Atala", "Jasmal", "Zasheida", "Meilil", "Seydil", "Seipora", "Ham", "Yasheira" };
        string[] surnamesCalishite = { "Basha", "Jassan", "Dumein", "Khalid", "Mostana", "Pashar", "Rein" };

        // Мулан / Mulan
        // Кожа - цвета янтаря.
        // Глаза - карие или светло-коричневые.
        // Волосы - от чёрного до тёмно-коричневого оттенков.

        string[] maleMulanNames = { "Aot", "Bareris", "Ketoth", "Mu med", "Ramas", "So - Kehur", "Thazar - De", "Urkhur", "Ehput Ki" };
        string[] femaleMulanNames = { "Arizima", "Zolis", "Muriti", "Nefis", "Nulara", "Sefris", "Tola", "Umar", "Chathi" };
        string[] surnamesMulan = { "Ankhalab", "Anskuld", "Natandem", "Serpet", "Uutrakt", "Fezim", "Hahpet" };

        // Рашеми / Rashemi
        // Кожа - тёмная.
        // Глаза - чёрные.
        // Волосы - чёрные.

        string[] maleRashemiNames = { "Borivik", "Vladislak", "Jandar", "Kanitar", "Madislak", "Ralmevik", "Faur Gar", "Shaumar" };
        string[] femaleRashemiNames = { "Imsel", "Immit", "Navarra", "Tammit", "Fayvarra", "Hulmarra", "Shevarra", "Yuldra" };
        string[] surnamesRashemi = { "Dairinina", "Iltaziara", "Murnitara", "Stayanoga", "Ulmokina", "Chergoba" };

        // Тетирец / Tethyrian
        // Кожа - смуглая.
        // Волосы - коричневые.
        // Глаза - голубые.
        // Используют чондатанские имена.

        // Тёрами / Turami
        // Кожа - тёмно-красная.
        // Волосы - чёрные.
        // Глаза - чёрные.

        string[] maleTuramiNames = { "Anton", "Diero", "Marcon", "Pieron", "Rimardo", "Romero", "Salazar", "Umbero" };
        string[] femaleTuramiNames = { "Balama", "Vonda", "Jalana", "Dona", "Kuara", "Louise", "Martha", "Selise", "Faila" };
        string[] surnamesTurami = { "Agosto", "Astorio", "Domine", "Calabra", "Marivaldi", "Pisacar", "Ramondo", "Falone" };

        // Чондатанец /

        // Шу / 

        public Human(bool male, string subrace)
        {
            this.male = male;

            switch (subrace)
            {
                case "Damaran":
                    RandomNameGen(maleDamaranNames, femaleDamaranNames, surnamesDamaran);
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
                    break;
                case "Turami":
                    RandomNameGen(maleTuramiNames, femaleTuramiNames, surnamesTurami);
                    break;
            }
        }
    }
}
