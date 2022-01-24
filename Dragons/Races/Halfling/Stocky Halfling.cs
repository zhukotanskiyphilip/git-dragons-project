using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class Stocky_Halfling : Halfling
    {
        // ОСОБЕННОСТИ КОРЕНАСТЫХ ПОЛУРОСЛИКОВ
        // Увеличение характеристик. Значение вашего Телосложения увеличивается на 1. 
        // Устойчивость коренастых.Вы совершаете с преимуществом спасброски от яда,
        // и вы получаете сопротивление к урону ядом.

        public Stocky_Halfling(bool male)
        {
            race = "Halfling";
            this.male = male;
            HalflingNameGen();
            RandomCharGen();
            // Базовый бонус полуросликов
            agility += 2;
            // Базовый бонус коренастых полуросликов
            constitution += 1;
        }
    }
}
