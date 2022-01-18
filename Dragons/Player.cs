using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class Player
    {
        public string name;

        public int health;
        public int armorClass;

        public int hitDamage;
        public int biteDamage;

        public int goldCoins;
        public int silverCoins;
        public int bronzeCoins;

        public int strength;

        //Показатель: Природный атлетизм, физическая сила
        //Важна для: Варвар, воин, паладин
        //Расовый бонус: 
        //Горный дварф(+2) Полуорк(+2)
        //Человек(+1) Драконорождённый(+2)
        //Высокое значение Силы соответствует плотному или атлетичному телу, низкое - худому или тучному.

        public int agility;

        //Показатель: Проворство, реакция, равновесие
        //Важна для: Монах, плут, следопыт
        //Расовый бонус: 
        //Эльф(+2) Лесной гном(+1)
        //Полурослик(+2) Человек(+1)
        //Высокое значение Ловкости соответствует гибкому и стройному телу, низкое - долговязому и неуклюжему.

        public int constitution;

        //Показатель: Здоровье, выносливость, жизненная сила
        //Важно для: Все классы
        //Расовый бонус: 
        //Дварф(+2) Каменный гном(+1)
        //Человек(+1) Коренастый полурослик(+1)
        //Полуорк(+1)
        //Высокое значение Телосложения соответствует полному энергии персонажу, низкое - болезненному и хилому.

        public int intelligence;

        //Показатель: Здоровье, выносливость, жизненная сила
        //Важно для: Все классы
        //Расовый бонус: 
        //Дварф(+2) Каменный гном(+1)
        //Человек(+1) Коренастый полурослик(+1)
        //Полуорк(+1)
        //Высокое значение Интеллекта соответствует любознательности и прилежности, низкое - примитивной речи и слабоумию.

        public int wisdom;

        //Показатель: Осведомлённость, интуиция, проницательность
        //Важна для: Друид, жрец
        //Расовый бонус: 
        //Холмовой дварф(+1) Человек(+1)
        //Лесной эльф(+1)
        //Высокое значение Мудрости соответствует рассудительности и сопереживанию, низкое - рассеянности, безрассудству и забывчивости.

        public int charisma;

        //Показатель: Уверенность, красноречие, лидерство
        //Важна для: Бард, колдун, чародей
        //Расовый бонус: 
        //Полуэльф(+2) Драконорождённый(+1)
        //Дроу(+1) Человек(+1)
        //Тифлинг(+2) Легконогий полурослик(+1)
        //Высокое значение Харизмы соответствует уверенности и привлекательности, низкое - раздражающести, неубедительности и робости.

        //ЗНАЧЕНИЯ И МОДИФИКАТОРЫ ХАРАКТЕРИСТИК
        //Знач. Модификатор
        //1     −5 
        //2–3   −4
        //4–5   −3
        //6–7   −2
        //8–9   −1
        //10–11 +0
        //12–13 +1
        //14–15 +2
        //16–17 +3 
        //18–19 +4
        //20–21 +5 
        //22–23 +6 
        //24–25 +7 
        //26–27 +8
        //28–29 +9 
        //30    +10

        //Настройка характеристик:

        //Вариант 1: Случайно
        //Вы генерируете шесть значений характеристик случайно.
        //Бросьте четыре 6-гранных кости и запишите сумму трёх наибольших результатов на листке для заметок.
        //Эта сумма и есть значение выбранной характеристики.

        public void RandomCharGen()
        {
            Console.Clear();

            Random rand = new Random();

            byte min = 0;

            for (int i = 0; i < 4; i++)
            {
                byte random = (byte)rand.Next(1, 6);
                if (min == 0) min = random;
                else
                {
                    strength += Math.Max(min, random);
                    min = Math.Min(min, random);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                byte random = (byte)rand.Next(1, 6);
                if (min == 0) min = random;
                else
                {
                    agility += Math.Max(min, random);
                    min = Math.Min(min, random);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                byte random = (byte)rand.Next(1, 6);
                if (min == 0) min = random;
                else
                {
                    constitution += Math.Max(min, random);
                    min = Math.Min(min, random);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                byte random = (byte)rand.Next(1, 6);
                if (min == 0) min = random;
                else
                {
                    intelligence += Math.Max(min, random);
                    min = Math.Min(min, random);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                byte random = (byte)rand.Next(1, 6);
                if (min == 0) min = random;
                else
                {
                    wisdom += Math.Max(min, random);
                    min = Math.Min(min, random);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                byte random = (byte)rand.Next(1, 6);
                if (min == 0) min = random;
                else
                {
                    charisma += Math.Max(min, random);
                    min = Math.Min(min, random);
                }
            }
        }

        //Вариант 2: Набор
        //Вы можете использовать следующие числа: 15, 14, 13, 12, 10, 8.
        //Назначьте каждой из характеристик одно число из набора.

        public void SetCharGen()
        {
            bool approve;

            for (int i = 0; i < 4; i++)
            {
                Console.Clear();

                approve = false;
                
                while (true)
                {
                    Console.WriteLine($"Pick a stat equal to {15 - i}:\n" +
                        "1. Strength\n" +
                        "2. Agility\n" +
                        "3. Constitution\n" +
                        "4. Intelligence\n" +
                        "5. Wisdom\n" +
                        "6. Charisma\n" +
                        "Please write the number of the selected option.\n");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            if (strength != 0) Console.WriteLine($"This attribute has already been assigned a value {strength}.");
                            else
                            {
                                Console.WriteLine("Your choice is strength? y/n");
                                if (Console.ReadLine() == "y")
                                {
                                    strength = 15 - i;
                                    approve = true;
                                }
                            }
                            break;
                        case "2":
                            if (agility != 0) Console.WriteLine($"This attribute has already been assigned a value {agility}.");
                            else
                            {
                                Console.WriteLine("Your choice is agility? y/n");
                                if (Console.ReadLine() == "y")
                                {
                                    agility = 15 - i;
                                    approve = true;
                                }
                            }
                            break;
                        case "3":
                            if (constitution != 0) Console.WriteLine($"This attribute has already been assigned a value {constitution}.");
                            else
                            {
                                Console.WriteLine("Your choice is constitution? y/n");
                                if (Console.ReadLine() == "y")
                                {
                                    constitution = 15 - i;
                                    approve = true;
                                }
                            }
                            break;
                        case "4":
                            if (intelligence != 0) Console.WriteLine($"This attribute has already been assigned a value {intelligence}.");
                            else
                            {
                                Console.WriteLine("Your choice is intelligence? y/n");
                                if (Console.ReadLine() == "y")
                                {
                                    intelligence = 15 - i;
                                    approve = true;
                                }
                            }
                            break;
                        case "5":
                            if (wisdom != 0) Console.WriteLine($"This attribute has already been assigned a value {wisdom}.");
                            else
                            {
                                Console.WriteLine("Your choice is wisdom? y/n");
                                if (Console.ReadLine() == "y")
                                {
                                    wisdom = 15 - i;
                                    approve = true;
                                }
                            }
                            break;
                        case "6":
                            if (charisma != 0) Console.WriteLine($"This attribute has already been assigned a value {charisma}.");
                            else
                            {
                                Console.WriteLine("Your choice is charisma? y/n");
                                if (Console.ReadLine() == "y")
                                {
                                    charisma = 15 - i;
                                    approve = true;
                                }
                            }
                            break;
                    }

                    if (approve == true) break;
                }
            }

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();

                approve = false;

                while (true)
                {
                    Console.WriteLine($"Pick a stat equal to {10 - (i * 2)}:\n" +
                        "1. Strength\n" +
                        "2. Agility\n" +
                        "3. Constitution\n" +
                        "4. Intelligence\n" +
                        "5. Wisdom\n" +
                        "6. Charisma\n" +
                        "Please write the number of the selected option.\n");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            if (strength != 0) Console.WriteLine($"This attribute has already been assigned a value {strength}.");
                            else
                            {
                                Console.WriteLine("Your choice is strength? y/n");
                                if (Console.ReadLine() == "y")
                                {
                                    strength = 10 - (i * 2);
                                    approve = true;
                                }
                            }
                            break;
                        case "2":
                            if (agility != 0) Console.WriteLine($"This attribute has already been assigned a value {agility}.");
                            else
                            {
                                Console.WriteLine("Your choice is agility? y/n");
                                if (Console.ReadLine() == "y")
                                {
                                    agility = 10 - (i * 2);
                                    approve = true;
                                }
                            }
                            break;
                        case "3":
                            if (constitution != 0) Console.WriteLine($"This attribute has already been assigned a value {constitution}.");
                            else
                            {
                                Console.WriteLine("Your choice is constitution? y/n");
                                if (Console.ReadLine() == "y")
                                {
                                    constitution = 10 - (i * 2);
                                    approve = true;
                                }
                            }
                            break;
                        case "4":
                            if (intelligence != 0) Console.WriteLine($"This attribute has already been assigned a value {intelligence}.");
                            else
                            {
                                Console.WriteLine("Your choice is intelligence? y/n");
                                if (Console.ReadLine() == "y")
                                {
                                    intelligence = 10 - (i * 2);
                                    approve = true;
                                }
                            }
                            break;
                        case "5":
                            if (wisdom != 0) Console.WriteLine($"This attribute has already been assigned a value {wisdom}.");
                            else
                            {
                                Console.WriteLine("Your choice is wisdom? y/n");
                                if (Console.ReadLine() == "y")
                                {
                                    wisdom = 10 - (i * 2);
                                    approve = true;
                                }
                            }
                            break;
                        case "6":
                            if (charisma != 0) Console.WriteLine($"This attribute has already been assigned a value {charisma}.");
                            else
                            {
                                Console.WriteLine("Your choice is charisma? y/n");
                                if (Console.ReadLine() == "y")
                                {
                                    charisma = 10 - (i * 2);
                                    approve = true;
                                }
                            }
                            break;
                    }

                    if (approve == true) break;
                }
            }
        }

        //Вариант 3: Вручную
        //Вы получаете 27 пунктов, которые распределяете между значениями характеристик.
        //Значение характеристики не может быть ниже 8.
        //Значение характеристики не может быть выше 15.

        //ЦЕНА ЗНАЧЕНИЙ ХАРАКТЕРИСТИК
        //Значение Цена
        //8        0 
        //9        1
        //10       2
        //11       3
        //12       4 
        //13       5
        //14       7 
        //15       9

        public void ShowCharacteriscs()
        {
            Console.WriteLine($"Your strength is {strength}\n" +
                $"Your agility is {agility}\n" +
                $"Your constitution is {constitution}\n" +
                $"Your intelligence is {intelligence}\n" +
                $"Your wisdom is {wisdom}\n" +
                $"Your charisma is {charisma}\n");
        }

        public void ResetStats()
        {
            strength = 0;
            agility = 0;
            constitution = 0;
            intelligence = 0;
            wisdom = 0;
            charisma = 0;
        }

        public int experience = 0;

        //РАЗВИТИЕ ПЕРСОНАЖА
        //Опыт   Уровень Бонус мастерства
        //0      1       +2
        //300    2       +2
        //900    3       +2
        //2700   4       +2
        //6500   5       +3
        //14000  6       +3
        //23000  7       +3
        //34000  8       +3
        //48000  9       +4
        //64000  10      +4
        //85000  11      +4
        //100000 12      +4
        //120000 13      +5
        //140000 14      +5
        //165000 15      +5
        //195000 16      +5
        //225000 17      +6
        //265000 18      +6
        //305000 19      +6
        //355000 20      +6

        public Player()
        {
            health = 10;
            armorClass = 0;

            hitDamage = 6;
            biteDamage = 7;

            goldCoins = 0;
            silverCoins = 0;
            bronzeCoins = 0;

            strength = 0;
            agility = 0;
            constitution = 0;
            intelligence = 0;
            wisdom = 0;
            charisma = 0;
        }

        //остановился на стр. 18
    }
}
