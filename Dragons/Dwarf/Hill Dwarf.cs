using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class Hill_Dwarf : Dwarf
    {
        // Особенности холмовых дварфов
        // Значение Мудрости увеличивается на 1.
        // Дварфская выдержка. Максимальное значение хитов увеличивается на 1, получают 1 дополнительный хит с каждым новым уровнем.

        public Hill_Dwarf(bool male)
        {
            race = "Dwarf";
            this.male = male;
            DwarfNameGen();
            RandomCharGen();
            // Базовый бонус дварфов
            constitution += 2;
            // Базовый бонус холмовых дварфов
            wisdom += 1;
        }
    }
}
