﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class High_Elf : Elf
    {
        // ОСОБЕННОСТИ ВЫСШИХ ЭЛЬФОВ
        // Бронзовая кожа и волосы медного, чёрного или золотистого оттенка. 
        // Золотые, серебристые или чёрные глаза.
        // Значение Интеллекта увеличивается на 1.
        // Владение эльфийским оружием. Владеют длинным мечом, коротким мечом, коротким и длинным луками.
        // Заговор. Знают один заговор из списка заклинаний волшебника. Базовой характеристикой для его использования является Интеллект.
        // Дополнительный язык. Могут говорить, читать и писать на ещё одном языке.

        public High_Elf(bool male)
        {
            race = "Elf";
            this.male = male;
            ElfNameGen();
            RandomCharGen();
            // Базовый бонус эльфов
            agility += 2;
            speed = 30;
            // Базовый бонус высших эльфов
            intelligence += 1;
        }
    }
}