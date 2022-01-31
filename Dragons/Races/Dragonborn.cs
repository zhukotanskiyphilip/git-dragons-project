using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class Dragonborn : Character
    {
        // ОСОБЕННОСТИ ДРАКОНОРОЖДЁННЫХ

        // Увеличение характеристик. Значение Силы увеличивается на 2, а значение Харизмы увеличивается на 1.
        // Возраст. Достигают зрелости к 15 годам, и обычно живут до 80 лет.
        // Мировоззрение. Законно-добрые или законно злые.
        // Размер. Средний.
        // Рост. Около 2 метров.
        // Вес. Около 115 килограмм.
        // Скорость. 30 футов.
        // Языки. Общий и Драконий.

        // Наследие драконов. Вы получаете драконье наследие. Выберите тип дракона из таблицы  «Наследие драконов».
        // Вы получаете оружие дыхания и сопротивление к урону соответствующего вида, как указано в таблице.
        // Оружие дыхания. Вы можете действием выдохнуть разрушительную энергию. 
        // Ваше наследие драконов определяет размер, форму и вид урона вашего выдоха.
        // Когда вы используете оружие дыхания, все существа в зоне выдоха должны совершить спасбросок, вид которого определяется вашим наследием.
        // Сложность этого спасброска равна 8 + ваш модификатор Телосложения + ваш бонус мастерства.
        // Существа получают урона 2к6 в случае проваленного спасброска, или половину этого урона, если спасбросок был успешен.
        // Урон повышается до 3к6 на 6 уровне, до 4к6 на 11, и до 5к6 на 16 уровне.
        // После использования оружия дыхания вы не можете использовать его повторно, пока не завершите короткий либо продолжительный отдых.
        // Сопротивление урону. Вы получаете сопротивление к урону того вида, который указан в вашем наследии драконов.

        // НАСЛЕДИЕ ДРАКОНОВ
        // Дракон Вид урона Оружие дыхания
        // Белый Холод 15-фт.конус(спас.Тел.)
        // Бронзовый Электричество Линия 5 на 30 фт. (спас.Лов.)
        // Зелёный Яд 15-фт.конус(спас.Тел.)
        // Золотой Огонь 15-фт.конус(спас.Лов.)
        // Красный Огонь 15-фт.конус(спас.Лов.)
        // Латунный Огонь Линия 5 на 30 фт. (спас.Лов.)
        // Медный Кислота Линия 5 на 30 фт. (спас.Лов.)
        // Серебряный Холод 15-фт.конус(спас.Тел.)
        // Синий Электричество Линия 5 на 30 фт. (спас.Лов.)
        // Чёрный Кислота Линия 5 на 30 фт. (спас.Лов.)

        // ВНЕШНОСТЬ ДРАКОНОРОЖДЁННЫХ

        // Кожа. Цвета меди или латуни, иногда с алым, золотым, медно-зелёным или рыжим оттенком.
        string[] allowedSkinColor = { "Bronze", "Scarlet", "Rust", "Gold", "Copper-Green" };
        // Волосы. Нет.
        string[] allowedHair = { "None" };
        string[] allowedHairColor = { "None" };
        // Глаза. Красные, золотые.
        string[] allowedEyeColor = { "Red", "Gold" };
        // Бороды. Нет.
        string[] allowedBeard = { "None" };
        // Усы. Нет.
        string[] allowedMustache = { "None" };


        // ИМЕНА ДРАКОНОРОЖДЁННЫХ

        string[] maleNames = { "Arjhan", "Balasar", "Bharash", "Donaar", "Ghesh", "Heskan", "Kriv", "Medrash",
            "Mehen", "Nadarr", "Pandjed", "Patrin", "Rhogar", "Shamash", "Shedinn", "Tarhun", "Torinn" };
        string[] femaleNames = { "Akra", "Biri", "Daar", "Farideh", "Harann", "Havilar", "Jheri", "Kava",
            "Korinn", "Mishann", "Nala", "Perra", "Raiann", "Sora", "Surina", "Thava", "Uadjit" };
        string[] childhoodNames = { "Climber", "Earbender", "Leaper", "Pious", "Shieldbiter", "Zealous" };
        string[] surnames = { "Clethtinthiallor", "Daardendrian", "Delmirev", "Drachedandion", "Fenkenkabradon",
            "Kepeshkmolik", "Kerrhylon", "Kimbatuul", "Linxakasendalor", "Myastan", "Nemmonis", "Norixius",
            "Ophinshtalajiir", "Prexijandilin", "Shestendeliath", "Turnuroth", "Verthisathurgiesh", "Yarjerit" };

        public Dragonborn(bool male)
        {

            this.male = male;

            ageMin = 10;
            ageMax = 80;

            alignmentMin = 0;
            alignmentMax = 8;

            size = Size.Medium;

            heightMin = 190;
            heightMax = 210;

            weightMin = 105;
            weightMax = 125;

            speed = 30;

            RandomCharGen();

            strength += 2;
            charisma++;

            RandomNameGen(maleNames, femaleNames, surnames, childhoodNames, 15);

            RandomAppearanceGen(male, allowedSkinColor, allowedHairColor, allowedEyeColor, allowedHair, allowedBeard, allowedMustache);
        }
    }
}
