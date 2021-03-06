using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class Gnome : Character
    {
        // ОСОБЕННОСТИ ГНОМОВ

        // Увеличение характеристик. Значение Интеллекта увеличивается на 2.
        // Возраст. Достигают зрелости к 40 годам. Они способны прожить от 350 до почти 500 лет.
        // Мировоззрение. Гномы чаще всего добры.
        // Размер. Маленький.
        // Рост. 91 - 122 сантиметра.
        // Вес. 15 - 20 килограмм.
        // Скорость. 25 футов.
        // Языки. Общий и Гномий.

        // Тёмное зрение. Привыкнув к жизни под землёй, вы обладаете превосходным зрением в темноте и при тусклом освещении.
        // На расстоянии в 60 футов вы при тусклом освещении можете видеть так, как будто это яркое освещение, и в темноте так,
        // как будто это тусклое освещение. В темноте вы не можете различать цвета, только оттенки серого.
        // Гномья хитрость. Вы совершаете с преимуществом спасброски Интеллекта, Мудрости и Харизмы против магии.

        // ВНЕШНОСТЬ ГНОМОВ

        // Кожа. От рыжевато-коричневого до древесно-коричневого или каменисто-серого.
        string[] allowedSkinColor = { "Ruddy-Tan", "Woody-Brown", "Rocky-Gray" };
        // Волосы. Любые. Белые, коричневые, блонд, оранжевые или зелёные.
        string[] allowedHair = { "None", "Short", "Long" };
        string[] allowedHairColor = { "Blond", "Brown", "White", "Orange","Green" };
        // Глаза. Чёрные, синие.
        string[] allowedEyeColor = { "Black", "Blue" };
        // Бороды. Короткие.
        string[] allowedBeard = { "None", "Short" };
        // Усы. Короткие.
        string[] allowedMustache = { "None", "Short" };


        // ИМЕНА ГНОМОВ

        string[] maleNames = { "Alston", "Alvyn", "Boddynock", "Brocc", "Burgell", "Dimble", "Eldon", "Erky", "Fonkin", "Frug",
            "Gerbo", "Gimble", "Glim", "Jebeddo", "Kellen", "Namfoodle", "Orryn", "Roondar", "Seebo", "Sindri", "Warryn", "Wrenn", "Zook" };
        string[] femaleNames = { "Bimpnottin", "Breena", "Caramip", "Carlin", "Donella", "Duvamil", "Ella", "Ellyjobell", "Ellywick",
            "Lilli", "Loopmottin", "Lorilla", "Mardnab", "Nissa", "Nyx", "Oda", "Orla", "Roywyn", "Shamil", "Tana", "Waywocket", "Zanna" };
        string[] surnames = { "Beren", "Daergel", "Folkor", "Garrick", "Nackle", "Murnig", "Ningel", "Raulnor", "Scheppen", "Timbers", "Turen" };

        // ПОДРАСЫ

        // Лесной гном / Forest Gnome

        // Увеличение характеристик. Значение Ловкости увеличивается на 1. 
        // Природная иллюзия. Вы знаете заклинание малая иллюзия. Базовой характеристикой для его использования является Интеллект.
        // Общение с маленькими зверями. С помощью звуков и жестов вы можете передавать простые понятия Маленьким или ещё меньшим зверям.

        // Скальный гном / Rock Gnome

        // Увеличение характеристик. Значение Телосложения увеличивается на 1. 
        // Ремесленные знания. При совершении проверки Интеллекта (История) применительно к магическому, алхимическому
        // или технологическому объекту, вы можете добавить к проверке удвоенный бонус мастерства вместо обычного.
        // Жестянщик.Вы владеете ремесленными инструментами (инструменты жестянщика).
        // С их помощью вы можете, потратив 1 час времени и материалы на сумму в 10 зм, создать Крошечное механическое устройство (КД 5, 1 хит).
        // Это устройство перестаёт работать через 24 часа(если вы не потратите 1 час на поддержание его работы).
        // Вы можете действием разобрать его; в этом случае вы можете получить обратно использованные материалы.
        // Одновременно вы можете иметь не более трёх таких устройств.

        // При создании устройства выберите один из следующих вариантов:

        // 1) Заводная игрушка. Эта заводная игрушка изображает животное, чудовище или существо,вроде лягушки, мыши, птицы, дракона или солдатика.
        // Поставленная на землю, она проходит 5 футов в случайном направлении за каждый ваш ход, издавая звуки, соответствующие изображаемому существу.
        // 2) Зажигалка. Это устройство производит миниатюрный огонёк, с помощью которого можно зажечь свечу, факел или костёр.
        // Использование этого устройства требует действия.
        // 3) Музыкальная шкатулка. При открытии эта шкатулка проигрывает мелодию средней громкости.
        // Шкатулка перестаёт играть если мелодия закончилась или если шкатулку закрыли.

        public Gnome(bool male, string subrace)
        {

            this.male = male;

            ageMin = 40;
            ageMax = 500;

            alignmentMin = 0;
            alignmentMax = 8;

            size = Size.Small;

            heightMin = 91;
            heightMax = 122;

            weightMin = 15;
            weightMax = 20;

            speed = 25;

            RandomCharGen();

            intelligence += 2;

            RandomNameGen(maleNames, femaleNames, surnames);

            switch (subrace)
            {
                case "Forest Gnome":
                    agility++;
                    break;
                case "Rock Gnome":
                    constitution++;
                    break;
            }

            RandomAppearanceGen(male, allowedSkinColor, allowedHairColor, allowedEyeColor, allowedHair, allowedBeard, allowedMustache);
        }
    }
}
