using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class Elf : Character
    {
        public void ElfNameGen()
        {
            string[] childrenNames = { "Ara", "Brin", "Val", "Del", "Innil", "Lael", "Mella", "Nail",
                "Naeris", "Rael", "Rynn", "Sai", "Sillin", "Tia", "Fann", "Faen", "Erin" };
            string[] maleNames = {"Adran", "Aramil", "Arannis", "Aust", "Aelar", "Beiro", "Berrian", "Varis", "Galinndan",
                "Ivellios", "Immeral", "Carrick", "Kuarion", "Lausian", "Mindartis", "Paelias", "Peren", "Reardon", "Rolen",
                "Soveliss", "Tamiorn", "Tarivol", "Teren", "Hadaray", "Himo", "Heyan", "Enialis", "Erdan", "Erevan" };
            string[] femaleNames = { "Adrie", "Altea", "Anastri Anna", "Andraste", "Antinua", "Betrinna", "Birel", "Vadania",
                "Valante", "Gelenette", "Drusilia", "Yelenia", "Kaelinn", "Quelenna", "Kvilasi", "Kaylet", "Xanathia",
                "Leshanna", "Leah", "Miali", "Mariel", "Naivara", "Sari El", "Silakvi", "Teirastra", "Tia", "Felosial",
                "Shava", "Shanaira", "Anna" };
            string[] surnames = { "Amakiir", "Sparkling Flower", "Amastasia", "Star Flower", "Galanodel", "Moonwhisper",
                "Ilfelkiir", "Glittering Bud", "Xylocent", "Golden Petal Stock", "Liadon", "Silver Leaf", "Nylo",
                "Night Breeze", "Sianodel", "Moonstream", "Holymion", "Diamond Dew" };

            Random rand = new Random();
            if (age > 100)
            {
                if (male == true)
                    name = maleNames[rand.Next(0, maleNames.Length)];
                else name = femaleNames[rand.Next(0, femaleNames.Length)];
            }
            else name = childrenNames[rand.Next(0, childrenNames.Length)];
            surname = surnames[rand.Next(0, surnames.Length)];
        }

        // ОСОБЕННОСТИ ЭЛЬФОВ
        // Рост от 150 до 185 сантиметров.
        // Вес от 45 до 65 килограмм.
        // Базовая скорость перемещения — 30 футов.
        // Цвета кожи включают в себя все человеческие оттенки, а также цвета с медным, бронзовым и голубовато-белым отливом.
        // Волосы помимо человеческих цветов могут быть зелёными или синими, а глаза приобретать цвет жидкого золота или серебра.
        // Способны жить более 700 лет.
        // Эльфы считаются детьми, пока они не объявят себя взрослыми, где-то вскоре после сотого дня рождения.
        // До этого времени их называют детским именем.
        // Значение Ловкости увеличивается на 2.
        // Хаотическое мировоззрение.
        // Тёмное зрение. На расстоянии в 60 футов тусклое освещение считается ярким, темнота - тусклым.
        // Обострённые чувства. Владеют навыком Внимательность.
        // Наследие фей. Совершают с преимуществом спасброски от очарования, невозможно магически усыпить.
        // Транс. Эльфы не спят. Вместо этого они погружаются в глубокую медитацию, находясь в полубессознательном состоянии до 4 часов в сутки.
        // Языки. Говорят, пишут и читают на Общем и Эльфийском языках.
    }
}
