using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class Halfling : Character
    {
        // ОСОБЕННОСТИ ПОЛУРОСЛИКОВ

        // Увеличение характеристик. Значение Ловкости повышается на 2.
        // Возраст. Достигают зрелости к 20 годам, и обычно живут до 150 лет.
        // Мировоззрение. Большинство полуросликов законно-добрые.
        // Размер. Маленький.
        // Рост. 85 - 95 сантиметров.
        // Вес. 15 - 23 килограмма.
        // Скорость. 25 футов.
        // Языки. Общий и Полуросликов.

        // Везучий. Если при броске атаки, проверке характеристики или спасброске у вас выпало «1»,
        // вы можете перебросить кость, и должны использовать новый результат.
        // Храбрый. Вы совершаете с преимуществом спасброски от испуга.
        // Проворство полуросликов. Вы можете проходить сквозь пространство, занятое существами, чей размер больше вашего.

        // ВНЕШНОСТЬ ПОЛУРОСЛИКОВ

        // Кожа. Смуглый, бледный.
        string[] allowedSkinColor = { "Tan", "Pale" };
        // Волосы. Любые, коичневые или песочные.
        string[] allowedHair = { "None", "Short", "Long" };
        string[] allowedHairColor = { "Brown", "Sandy Brown" };
        // Глаза. Коричневые, ореховые.
        string[] allowedEyeColor = { "Brown", "Hazel" };
        // Бороды. Нет.
        string[] allowedBeard = { "None" };
        // Усы. Нет.
        string[] allowedMustache = { "None" };


        // ИМЕНА ПОЛУРОСЛИКОВ

        string[] maleNames = { "Alton", "Ander", "Cade", "Corrin", "Eldon", "Errich", "Finnan", "Garret", "Lindal",
            "Lyle", "Merric", "Milo", "Osborn", "Perrin", "Reed", "Roscoe", "Wellby" };
        string[] femaleNames = { "Andry", "Bree", "Callie", "Cora", "Euphemia", "Jillian", "Kithri", "Lavinia",
            "Lidda", "Merla", "Nedda", "Paela", "Portia", "Seraphina", "Shaena", "Trym", "Vani", "Verna" };
        string[] surnames = { "Brushgather", "Goodbarrel", "Greenbottle", "High-hill", "Hilltopple", "Leagallow",
            "Tealeaf", "Thorngage", "Tosscobble", "Underbough" };

        // ПОДРАСЫ

        // Легконогий / Lightfoot Halfling

        // Увеличение характеристик. Значение Харизмы увеличивается на 1. 
        // Естественная скрытность. Вы можете предпринять попытку скрыться даже если заслонены только существом,
        // превосходящими вас в размере как минимум на одну категорию.

        // Коренастый / Stout Halfling

        // Увеличение характеристик. Значение Телосложения увеличивается на 1. 
        // Устойчивость коренастых. Вы совершаете с преимуществом спасброски от яда,
        // и вы получаете сопротивление к урону ядом.

        public Halfling(bool male, string subrace)
        {

            this.male = male;

            ageMin = 20;
            ageMax = 150;

            alignmentMin = 0;
            alignmentMax = 0;

            size = Size.Small;

            heightMin = 85;
            heightMax = 95;

            weightMin = 15;
            weightMax = 23;

            speed = 25;

            RandomCharGen();

            agility += 2;

            RandomNameGen(maleNames, femaleNames, surnames);

            switch (subrace)
            {
                case "Lightfoot Halfling":
                    charisma++;
                    break;
                case "Stout Halfling":
                    constitution++;
                    break;
            }

            RandomAppearanceGen(male, allowedSkinColor, allowedHairColor, allowedEyeColor, allowedHair, allowedBeard, allowedMustache);
        }
    }
}
