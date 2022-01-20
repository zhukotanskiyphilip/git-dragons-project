using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class Mountain_Dwarf : Dwarf
    {
        // Особенности горных дварфов
        // Высоки и светлокожи
        // Значение Силы увеличивается на 2.
        // Владеют лёгкими и средними доспехами.

        public Mountain_Dwarf(bool male)
        {
            this.male = male;
            DwarfNameGen();
            RandomCharGen();
            // Базовый бонус дварфов
            constitution += 2;
            // Базовый бонус горных дварфов
            strength += 2;
        }
    }
}
