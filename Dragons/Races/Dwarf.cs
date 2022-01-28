using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class Dwarf : Character
    {
        // ОСОБЕННОСТИ ДВАРФОВ

        // Увеличение характеристик. Телосложение увеличивается на 2.
        // Возраст. Становятся взрослыми в районе 50 лет. Живут до 500 лет.
        // Мировоззрение. Большинство дварфов законопослушные.
        // Размер. Средний.
        // Рост. 122 - 152 сантиметра.
        // Вес. 65 - 70 килограмм.
        // Скорость. 25 футов.
        // Языки. Общий и Дварфский.

        // Ношение тяжёлых доспехов не снижает скорость.
        // Тёмное зрение. На расстоянии в 60 футов тусклое освещение считается ярким, темнота - тусклым.
        // Дварфская устойчивость. Спасброски от яда совершаются с преимуществом.
        // Имеют сопротивление к урону ядом.
        // Дварфская боевая тренировка. Владеют боевым топором, ручным топором, лёгким и боевым молотами.
        // Владение инструментами кузнеца, пивовара или каменщика.
        // Знание камня. Проверки Интеллекта(История), связанные с происхождением работы по камню, имеют удвоенный бонус мастерства вместо обычного.

        // ВНЕШНОСТЬ ДВАРФОВ

        // Кожа. От светло-коричневый до темно-коричневого (оттенки земли).
        string[] allowedSkinColor = { "Deep Brown", "Light Brown" };
        // Волосы. Длинные, черные, седые или каштановые, иногда рыжие.
        string[] allowedHair = { "Long" };
        string[] allowedHairColor = { "Black", "Gray", "Brown", "Red" };
        // Глаза. Коричневые, ореховые.
        string[] allowedEyeColor = { "Brown", "Hazel" };
        // Бороды. Длинные.
        string[] allowedBeard = { "Long" };
        // Усы. Длинные.
        string[] allowedMustache = { "Long" };


        // ИМЕНА ДВАРФОВ

        string[] maleNames = { "Adrik", "Alberich", "Baern", "Barendd", "Brottor", "Bruenor", "Dain", "Darrak", "Delg", "Eberk", "Einkil",
            "Fargrim", "Flint", "Gardain", "Harbek", "Kildrak", "Morgran", "Orsik", "Oskar", "Rangrim", "Rurik", "Taklinn", "Thoradin",
            "Thorin", "Tordek", "Traubon", "Travok", "Ulfgar", "Veit", "Vondal" };
        string[] femaleNames = { "Amber", "Artin", "Audhild", "Bardryn", "Dagnal", "Diesa", "Eldeth", "Falkrunn", "Finellen", "Gunnloda",
            "Gurdis", "Helja", "Hlin", "Kathra", "Kristryd", "Ilde", "Liftrasa", "Mardred", "Riswynn", "Sannl", "Torbera", "Torgga", "Vistra" };
        string[] surnames = { "Balderk", "Battlehammer", "Brawnanvil", "Dankil", "Fireforge", "Frostbeard", "Gorunn", "Holderhek", "Ironfist",
            "Loderr", "Lutgehr", "Rumnaheim", "Strakeln", "Torunn", "Ungart" };

        // ПОДРАСЫ

        // Холмовые дварфы

        // Значение Мудрости увеличивается на 1.
        // Дварфская выдержка. Максимальное значение хитов увеличивается на 1, получают 1 дополнительный хит с каждым новым уровнем.

        // Горные дварфы

        // Значение Силы увеличивается на 2.
        // Владеют лёгкими и средними доспехами.

        public Dwarf(bool male, string subrace)
        {

            this.male = male;

            ageMin = 50;
            ageMax = 500;

            alignmentMin = 0;
            alignmentMax = 2;

            size = Size.Medium;

            heightMin = 122;
            heightMax = 152;

            weightMin = 65;
            weightMax = 70;

            speed = 25;

            RandomCharGen();

            constitution += 2;

            RandomNameGen(maleNames, femaleNames, surnames);

            switch (subrace)
            {
                case "Hill Dwarf":
                    wisdom++;
                    break;
                case "Mountain Dwarf":
                    strength += 2;
                    break;
            }

            RandomAppearanceGen(male, allowedSkinColor, allowedHairColor, allowedEyeColor, allowedHair, allowedBeard, allowedMustache);
        }
    }
}
