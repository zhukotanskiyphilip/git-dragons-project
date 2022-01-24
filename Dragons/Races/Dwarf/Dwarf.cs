using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class Dwarf : Character
    {
        public void DwarfNameGen()
        {
            string[] maleNames = {"Adrik", "Alberich", "Barend", "Baern", "Brottor", "Bruenor", "Vondal", "Waite", "Gardain", "Dain",
            "Darrak", "Delg", "Kildrak", "Morgran", "Orsik", "Oscar", "Rangrim", "Rurik", "Taklinn", "Toradin", "Tordek", "Thorin",
            "Trawok", "Traubon", "Ulfgar", "Fargrim", "Flint", "Harbeck", "Eberk", "Einkil" };
            string[] femaleNames = { "Artin", "Bardrin", "Wistra", "Gunnloda", "Gurdis", "Dagnal", "Dieza", "Ilde", "Katra", "Kristid", "Liftrasa",
                "Mardred", "Odhild", "Risvin", "Sunnl", "Torbera", "Torgga", "Falkrunn", "Finellen", "Helja", "Hlin", "Eldeth", "Ember" };
            string[] clanNames = { "Balderk", "Warhammer", "Gorunn", "Dankil", "Ironfist", "Stout Anvil", "Icebeard", "Loderr", "Lütger", "Fireforge",
                "Ramnaheim", "Strakeln", "Thorunn", "Ungart", "Holderheck" };

            Random rand = new Random();
            if (male == true)
                name = maleNames[rand.Next(0, maleNames.Length)];
            else name = femaleNames[rand.Next(0, femaleNames.Length)];
            surname = clanNames[rand.Next(0, clanNames.Length)];
        }

        // ОСОБЕННОСТИ ДВАРФОВ
        // Телосложение увеличивается на 2.
        // Живут до 500 лет.
        // Считаются юными, пока не достигнут пятидесятилетнего возраста.
        // Большинство дварфов законопослушные.
        // Рост дварфов находится между 122 и 152 сантиметрами, и весят они около 68 килограмм. 
        // Размер — Средний.
        // Базовая скорость перемещения — 25 футов. 
        // Ношение тяжёлых доспехов не снижает скорость.
        // Тёмное зрение. На расстоянии в 60 футов тусклое освещение считается ярким, темнота - тусклым.
        // Дварфская устойчивость. Спасброски от яда совершаются с преимуществом.
        // Имеют сопротивление к урону ядом.
        // Дварфская боевая тренировка. Владеют боевым топором, ручным топором, лёгким и боевым молотами.
        // Владение инструментами кузнеца, пивовара или каменщика.
        // Знание камня. Проверки Интеллекта(История), связанные с происхождением работы по камню, имеют удвоенный бонус мастерства вместо обычного.
        // Разговаривают, читают и пишут на Общем и Дварфском языках.
    }
}
