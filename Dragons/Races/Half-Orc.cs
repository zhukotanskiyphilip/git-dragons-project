using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class Half_Orc : Character
    {
        // ОСОБЕННОСТИ ПОЛУОРКОВ

        // Увеличение характеристик. Значение Силы увеличивается на 2, а значение Телосложения увеличивается на 1.
        // Возраст. Становятся взрослыми в районе 14 лет. Живут до 75 лет.
        // Мировоззрение. Хаотичные.
        // Размер. Средний.
        // Рост. 183 - 213 сантиметров.
        // Вес. 80 - 113 килограмм.
        // Скорость. 30 футов.
        // Языки. Общий и Орочий.

        // Тёмное зрение. Благодаря орочьей крови, вы обладаете превосходным зрением в темноте и при тусклом освещении.
        // На расстоянии в 60 футов вы при тусклом освещении можете видеть так, как будто это яркое освещение, и в темноте так,
        // как будто это тусклое освещение. В темноте вы не можете различать цвета, только оттенки серого.
        // Угрожающий вид. Вы владеете навыком Запугивание.
        // Непоколебимая стойкость. Если ваши хиты опустились до нуля, но вы при этом не убиты, ваши хиты вместо этого опускаются до 1.
        // Вы не можете использовать эту способность снова, пока не завершите длительный отдых.
        // Свирепые атаки. Если вы совершили критическое попадание рукопашной атакой оружием, вы можете добавить к урону ещё одну кость урона оружия.

        // ВНЕШНОСТЬ ПОЛУОРКОВ

        // Кожа. Оттенки серого и зелёного.
        string[] allowedSkinColor = { "Gray", "Green" };
        // Волосы. Любые, черные или седые.
        string[] allowedHair = { "None", "Short", "Long" };
        string[] allowedHairColor = { "Black", "Gray" };
        // Глаза. Зелёные, желтые, карие.
        string[] allowedEyeColor = { "Green", "Yellow", "Black" };
        // Бороды. Любые.
        string[] allowedBeard = { "None", "Short", "Long" };
        // Усы. Любые.
        string[] allowedMustache = { "None", "Short", "Long" };


        // ИМЕНА ПОЛУОРКОВ

        string[] maleNames = { "Dench", "Feng", "Gell", "Henk", "Holg", "Imsh", "Keth", "Krusk", "Mhurren", "Ront", "Shump", "Thokk" };
        string[] femaleNames = { "Baggi", "Emen", "Engong", "Kansif", "Myev", "Neega", "Ovak", "Ownka", "Shautha", "Sutha", "Vola", "Volen", "Yevelda" };
        string[] surnames = { "Skull Thrasher", "The Unsightly", "Pest Splitter", "Kennelmaster", "Stragborne" };

        public Half_Orc(bool male)
        {
            this.male = male;

            ageMin = 14;
            ageMax = 75;

            alignmentMin = 6;
            alignmentMax = 8;

            size = Size.Medium;

            heightMin = 183;
            heightMax = 213;

            weightMin = 80;
            weightMax = 113;

            speed = 30;

            RandomCharGen();

            strength += 2;
            constitution++;

            RandomNameGen(maleNames, femaleNames, surnames);

            RandomAppearanceGen(male, allowedSkinColor, allowedHairColor, allowedEyeColor, allowedHair, allowedBeard, allowedMustache);
        }
    }
}
