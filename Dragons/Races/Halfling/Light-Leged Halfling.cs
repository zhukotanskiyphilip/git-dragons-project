using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class Light_Leged_Halfling : Halfling
    {
        // ОСОБЕННОСТИ ЛЕГКОНОГИХ ПОЛУРОСЛИКОВ
        // Увеличение характеристик. Значение вашей Харизмы увеличивается на 1.
        // Естественная скрытность.Вы можете предпринять попытку скрыться даже если заслонены только существом,
        // превосходящими вас в размере как минимум на одну категорию.

        public Light_Leged_Halfling(bool male)
        {
            race = "Halfling";
            this.male = male;
            HalflingNameGen();
            RandomCharGen();
            // Базовый бонус полуросликов
            agility += 2;
            // Базовый бонус коренастых полуросликов
            charisma += 1;
        }
    }
}
