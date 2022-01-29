using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class Elf : Character
    {
        // ОСОБЕННОСТИ ЭЛЬФОВ

        // Увеличение характеристик. Значение Ловкости увеличивается на 2. 
        // Возраст. Получает статус взрослого и взрослое имя в возрасте 100 лет, и может прожить до 750 лет.
        // Мировоззрение. Относятся к добрым аспектам хаоса.
        // Размер — Средний.
        // Рост. Колеблется между 152 и 183 сантиметрами.
        // Вес. Они стройнее людей, и весят от 45 до 65 килограмм.
        // Скорость. 30 футов.
        // Языки. Общий и Эльфийский.

        // Тёмное зрение. Привыкнув к сумраку леса и ночному небу, вы обладаете превосходным зрением в темноте и при тусклом освещении.
        // На расстоянии в 60 футов вы при тусклом освещении можете видеть так, как будто это яркое освещение, и в темноте так, как будто это тусклое освещение.
        // В темноте вы не можете различать цвета, только оттенки серого. 
        // Обострённые чувства. Вы владеете навыком Внимательность. 
        // Наследие фей. Вы совершаете с преимуществом спасброски от очарования, и вас невозможно магически усыпить.
        // Транс. Эльфы не спят. Вместо этого они погружаются в глубокую медитацию, находясь в полубессознательном состоянии до 4 часов в сутки
        // (обычно такую медитацию называют трансом). Во время этой медитации вы можете грезить о разных вещах. 
        // Некоторые из этих грёз являются ментальными упражнениями, выработанными за годы тренировок.
        // После такого отдыха вы получаете все преимущества, которые получает человек после 8 часов сна.

        // ВНЕШНОСТЬ ЭЛЬФОВ

        // Волосы.
        string[] allowedHair = { "None", "Short", "Long" };
        // Бороды. 
        string[] allowedBeard = { "None" };
        // Усы.
        string[] allowedMustache = { "None" };

        // ИМЕНА ЭЛЬФОВ

        string[] childhoodNames = { "Ara", "Bryn", "Del", "Eryn", "Faen", "Innil", "Lael", "Mella", "Naill", "Naeris",
            "Phann", "Rael", "Rinn", "Sai", "Syllin", "Thia", "Vall" };
        string[] maleNames = { "Adran", "Aelar", "Aramil", "Arannis", "Aust", "Beiro", "Berrian", "Carric", "Enialis",
            "Erdan", "Erevan", "Galinndan", "Hadarai", "Heian", "Himo", "Immeral", "Ivellios", "Laucian", "Mindartis",
            "Paelias", "Peren", "Quarion", "Riardon", "Rolen", "Soveliss", "Thamior", "Tharivol", "Theren", "Varis" };
        string[] femaleNames = { "Adrie", "Althaea", "Anastrianna", "Andraste", "Antinua", "Bethrynna", "Birel", "Caelynn",
            "Drusilia", "Enna", "Felosial", "Ielenia", "Jelenneth", "Keyleth", "Leshanna", "Lia", "Meriele", "Mialee",
            "Naivara", "Quelenna", "Quillathe", "Sariel", "Shanairra", "Shava", "Silaqui", "Theirastra", "Thia", "Vadania" };
        string[] surnames = { "Amakiir", "Gemflower", "Amastacia", "Starflower", "Galanodel", "Moonwhisper", "Holimion",
            "Diamonddew", "Ilphelkiir", "Gemblossom", "Liadon", "Silverfrond", "Meliamne", "Oakenheel", "Nailo", "Nightbreeze",
            "Siannodel", "Moonbrook", "Xiloscient", "Goldpetal" };

        // ПОДРАСЫ ЭЛЬФОВ

        // Высшие эльфы

        // Кожа. Бронзовая.
        string[] highElfSkinColor = { "Bronze" };
        // Волосы. Медные, черные, золотистые, блонд.
        string[] highElfHairColor = { "Copper", "Black", "Golden", "Blond" };
        // Глаза. Золотые, серебрянные, чёрные.
        string[] highElfEyeColor = { "Golden", "Silver", "Black" };

        // Увеличение характеристик. Значение вашего Интеллекта увеличивается на 1.
        // Владение эльфийским оружием. Вы владеете длинным мечом, коротким мечом, коротким и длинным луками.
        // Заговор. Вы знаете один заговор из списка заклинаний волшебника. Базовой характеристикой для его использования является Интеллект.
        // Дополнительный язык. Вы можете говорить, читать и писать на ещё одном языке, на ваш выбор.

        // Лесные эльфы

        // Кожа. Бронзовая, зелёная.
        string[] woodElfSkinColor = { "Copper", "Green" };
        // Волосы. Медные, черные, коричневые, блонд.
        string[] woodElfHairColor = { "Brown", "Black", "Blond", "Copper" };
        // Глаза. Зеленые, коричневые, ореховые.
        string[] woodElfEyeColor = { "Green", "Brown", "Hazel" };

        // Увеличение характеристик. Значение вашей Мудрости увеличивается на 1. 
        // Владение эльфийским оружием. Вы владеете длинным мечом, коротким мечом, коротким и длинным луками. 
        // Быстрые ноги. Ваша базовая скорость перемещения увеличивается до 35 футов.
        // Маскировка в дикой местности. Вы можете предпринять попытку спрятаться, даже если вы слабо заслонены листвой,
        // сильным дождём, снегопадом, туманом или другими природными явлениями.

        // Тёмные эльфы

        // Кожа. Чёрная.
        string[] darkElfSkinColor = { "Black" };
        // Волосы. Белые.
        string[] darkElfHairColor = { "White" };
        // Глаза. Сиреневые, серебряные, розовые, красные, синие.
        string[] darkElfEyeColor = { "Lilac", "Silver", "Pink", "Red", "Blue" };

        // Мировоззрение. Относятся к злым.
        // Увеличение характеристик. Значение вашей Харизмы увеличивается на 1. 
        // Превосходное тёмное зрение. Ваше тёмное зрение имеет радиус 120 футов.
        // Чувствительность к солнцу. Вы совершаете с помехой броски атаки и проверки Мудрости (Внимательность),
        // основанные на зрении, если вы, цель вашей атаки или изучаемый предмет расположены на прямом солнечном свете.
        // Магия дроу. Вы знаете заклинание пляшущие огоньки.
        // Когда вы достигаете 3 уровня, вы можете один раз в день использовать заклинание огонь фей.
        // При достижении 5 уровня вы также сможете раз в день использовать заклинание тьма. 
        // «Раз в день» означает, что вы должны окончить продолжительный отдых,
        // прежде чем сможете наложить это заклинание ещё раз посредством данного умения.
        // Базовой характеристикой для их использования является Харизма.
        // Владение оружием дроу. Вы владеете рапирой, коротким мечом и ручным арбалетом.

        public Elf(bool male, string subrace)
        {

            this.male = male;

            ageMin = 20;
            ageMax = 750;

            alignmentMin = 6;
            alignmentMax = 6;

            size = Size.Medium;

            heightMin = 152;
            heightMax = 183;

            weightMin = 45;
            weightMax = 65;

            speed = 30;

            RandomCharGen();

            agility += 2;

            RandomNameGen(maleNames, femaleNames, surnames, childhoodNames, 100);

            switch (subrace)
            {
                case "High Elf":
                    intelligence++;
                    RandomAppearanceGen(male, highElfSkinColor, highElfHairColor, highElfEyeColor, allowedHair, allowedBeard, allowedMustache);
                    break;
                case "Wood Elf":
                    wisdom++;
                    speed = 35;
                    RandomAppearanceGen(male, woodElfSkinColor, woodElfHairColor, woodElfEyeColor, allowedHair, allowedBeard, allowedMustache);
                    break;
                case "Dark Elf":
                    charisma++;
                    alignment = Alignment.Chaotic_Evil;
                    RandomAppearanceGen(male, darkElfSkinColor, darkElfHairColor, darkElfEyeColor, allowedHair, allowedBeard, allowedMustache);
                    break;
            }
        }
    }
}
