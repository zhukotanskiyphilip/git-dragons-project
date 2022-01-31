using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class Half_Elf : Character
    {
        // ОСОБЕННОСТИ ПОЛУЭЛЬФОВ

        // Увеличение характеристик. Значение Харизмы увеличивается на 2,
        // а значения двух других характеристик на ваш выбор увеличиваются на 1.
        // Возраст. Становятся взрослыми в районе 20 лет. Живут до 180 лет.
        // Мировоззрение. Хаотические.
        // Размер. Средний.
        // Рост. 155 - 183 сантиметра.
        // Вес. 45 - 80 килограмм.
        // Скорость. 30 футов.
        // Языки. Общий, Эльфийский и ещё один на выбор.

        // Тёмное зрение. Благодаря вашей эльфийской крови, вы обладаете превосходным зрением в темноте и при тусклом освещении. 
        // На расстоянии в 60 футов вы при тусклом освещении можете видеть так, как будто это яркое освещение, и в темноте так,
        // как будто это тусклое освещение. В темноте вы не можете различать цвета, только оттенки серого.
        // Наследие фей. Вы совершаете с преимуществом спасброски от очарования, и вас невозможно магически усыпить.
        // Универсальность навыков. Вы получаете владение двумя навыками на ваш выбор.

        // ВНЕШНОСТЬ ПОЛУЭЛЬФОВ

        // Кожа.
        string[] allowedSkinColor = { "White", "Black", "Dark" };
        // Волосы.
        string[] allowedHair = { "None", "Short", "Long" };
        string[] allowedHairColor = { "Black", "Gray", "Brown", "Red" };
        // Глаза.
        string[] allowedEyeColor = { "Brown", "Hazel", "Blue", "Black", "Green" };
        // Бороды.
        string[] allowedBeard = { "None", "Short", "Long" };
        // Усы. Любые.
        string[] allowedMustache = { "None", "Short", "Long" };


        // ИМЕНА ПОЛУЭЛЬФОВ

        string[] maleNames = { "Adran", "Aelar", "Beiro", "Carric", "Erdan", "Gennal", "Heian", "Lucan", "Peren", "Rolen", "Theren", "Varis",
            "Alain", "Alek", "Benn", "Brandis", "Donn", "Drew", "Erik", "Gregg", "John", "Kris", "Marc", "Mikal", "Pieter", "Quinn", "Regdar",
            "Samm", "Thom", "Wil" };
        string[] femaleNames = { "Adrie", "Birel", "Chaedi", "Dara", "Enna", "Faral", "Irann", "Keyleth", "Lia", "Mialee", "Shava", "Thia", "Valna",
            "Ana", "Cassi", "Eliza", "Gwenn", "Jenna", "Kat", "Keira", "Luusi", "Mari", "Mika", "Miri", "Shawna", "Stasi", "Zanne" };
        string[] surnames = { "Bearcharger", "Darksbane", "Duskwalker", "Gentleharp", "Huntinghawk", "Loreweaver", "Moonshadow", "Silentread",
            "Stalkingwolf", "Taletreader", "Treantspatience", "Wolfsbane", "Armorsmith", "Chandler", "Droverson", "Fiedlerson", "Hawklight",
            "Loyalar", "Shieldheart", "Silverkin", "Swordhand", "Urthadar", "Windsailor" };

        public Half_Elf(bool male)
        {

            this.male = male;

            ageMin = 20;
            ageMax = 180;

            alignmentMin = 6;
            alignmentMax = 8;

            size = Size.Medium;

            heightMin = 155;
            heightMax = 183;

            weightMin = 45;
            weightMax = 80;

            speed = 30;

            RandomCharGen();

            charisma += 2;

            for (int i = 0; i < 2; i++)
            {
                Random rand = new Random();

                int randChar = rand.Next(1, 6);

                switch(randChar)
                {
                    case 1:
                        strength++;
                        break;
                    case 2:
                        agility++;
                        break;
                    case 3:
                        constitution++;
                        break;
                    case 4:
                        intelligence++;
                        break;
                    case 5:
                        wisdom++;
                        break;
                    case 6:
                        charisma++;
                        break;
                }
            }

            RandomNameGen(maleNames, femaleNames, surnames);

            RandomAppearanceGen(male, allowedSkinColor, allowedHairColor, allowedEyeColor, allowedHair, allowedBeard, allowedMustache);
        }
    }
}
