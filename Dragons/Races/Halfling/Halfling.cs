using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class Halfling : Character
    {
        public void HalflingNameGen()
        {
            string[] maleNames = { "Alton", "Ander", "Garrett", "Cade", "Corrin", "Lyle", "Lindal", "Milo", "Merrick", "Osborne", "Perrin",
                "Reed", "Roscoe", "Wellby", "Finnan", "Eldon", "Arry" };
            string[] femaleNames = { "Bree", "Vani", "Verna", "Jillian", "Kitri", "Cora", "Callie", "Lavinia", "Lidda", "Merla", "Nedda",
                "Paela", "Portia", "Serafina", "Trim", "Shaena", "Andrew", "Euphemia" };
            string[] surnames = { "Upsidown", "Highhill", "Pebblethrower", "Goodbarrel", "Greenflask", "Bushcoll", "Meadowarc", "Underbranch", "Burdock", "Tealeaf" };

            Random rand = new Random();
            if (male == true)
                name = maleNames[rand.Next(0, maleNames.Length)];
            else name = femaleNames[rand.Next(0, femaleNames.Length)];
            surname = surnames[rand.Next(0, surnames.Length)];
        }

        // ОСОБЕННОСТИ ПОЛУРОСЛИКОВ
        // Рост около 90 сантиметров.
        // Весят от от 18 до 20 килограмм.
        // Кожа у полуросликов встречается от смуглой до бледной, с румянцем.
        // Волосы обычно коричневые или рыже-коричневые, вьющиеся.
        // Глаза полуросликов карие или ореховые.
        // Значение Ловкости повышается на 2.
        // Полурослики достигают зрелости к 20 годам, и обычно живут до 150 лет.
        // Большинство полуросликов законно-добрые.
        // Размер — Маленький.
        // Базовая скорость передвижения составляет 25 футов.
        // Везучий. Если при броске атаки, проверке характеристики или спасброске у вас выпало «1»,
        // вы можете перебросить кость, и должны использовать новый результат.
        // Храбрый. Вы совершаете с преимуществом спасброски от испуга.
        // Проворство полуросликов. Вы можете проходить сквозь пространство, занятое существами, чей размер больше вашего. 
        // Языки.Вы можете говорить, читать и писать на Общем и языке Полуросликов.
    }
}
