using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class Character
    {
        // Имя и фамилия

        public string name;

        public string surname;

        // Пол

        public bool male = true;

        // Раса

        public enum Race
        {
            Dwarf,
            Elf,
            Halfling,
            Human,
            Dragonborn,
            Gnome,
            Half_Elf,
            Half_Orc,
            Tiefling
        }

        public Race race;

        // Случайная генерация имени

        public void RandomNameGen(string[] maleNames, string[] femaleNames, string[] surnames, string[] childrenNames = null, int maturity = 0)
        {
            Random rand = new Random();

            if (age > maturity && childrenNames != null)
            {
                if (male == true)
                    name = maleNames[rand.Next(0, maleNames.Length)];
                else name = femaleNames[rand.Next(0, femaleNames.Length)];
            }
            else name = childrenNames[rand.Next(0, childrenNames.Length)];

            surname = surnames[rand.Next(0, surnames.Length)];
        }

        // Возраст

        public int age;

        public int ageMax;

        public int ageMin;

        // Мировоззрение

        public enum Alignment
        {
            Lawful_Good,
            Lawful_Neutral,
            Lawful_Evil,
            Neutral_Good,
            True_Neutral,
            Neutral_Evil,
            Chaotic_Good,
            Chaotic_Neutral,
            Chaotic_Evil
        }

        public Alignment alignment;

        public int alignmentMin;

        public int alignmentMax;

        // Размер

        // Tiny - 2½ by 2½ ft.
        // Small - 5 by 5 ft.
        // Medium - 5 by 5 ft.
        // Large - 10 by 10 ft.
        // Huge - 15 by 15 ft.
        // Gargantuan - 20 by 20 ft.

        public enum Size
        {
            Tiny,
            Small,
            Medium,
            Large,
            Huge,
            Gargantuan
        }

        public Size size;

        // Рост

        public int height;

        public int heightMax;

        public int heightMin;

        // Вес

        public int weight;

        public int weightMax;

        public int weightMin;

        // Скорость

        public int speed;

        // ХАРАКТЕРИСТИКИ

        public int strength;

        // Показатель: Природный атлетизм, физическая сила
        // Высокое значение Силы соответствует плотному или атлетичному телу, низкое - худому или тучному.

        public int agility;

        // Показатель: Проворство, реакция, равновесие
        // Высокое значение Ловкости соответствует гибкому и стройному телу, низкое - долговязому и неуклюжему.

        public int constitution;

        // Показатель: Здоровье, выносливость, жизненная сила
        // Высокое значение Телосложения соответствует полному энергии персонажу, низкое - болезненному и хилому.

        public int intelligence;

        // Показатель: Здоровье, выносливость, жизненная сила
        // Высокое значение Интеллекта соответствует любознательности и прилежности, низкое - примитивной речи и слабоумию.

        public int wisdom;

        // Показатель: Осведомлённость, интуиция, проницательность
        // Высокое значение Мудрости соответствует рассудительности и сопереживанию, низкое - рассеянности, безрассудству и забывчивости.

        public int charisma;

        // Показатель: Уверенность, красноречие, лидерство
        // Высокое значение Харизмы соответствует уверенности и привлекательности, низкое - раздражающести, неубедительности и робости.

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
            int[] characteristics = new int[6];

            // случайная генерация характеристик

            Random rand = new Random();

            age = rand.Next(ageMin, ageMax);
            height = rand.Next(heightMin, heightMax);
            weight = rand.Next(weightMin, weightMax);

            int min = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int random = rand.Next(1, 6);
                    if (min == 0) min = random;
                    else
                    {
                        characteristics[i] += Math.Max(min, random);
                        min = Math.Min(min, random);
                    }
                }
            }

            strength = characteristics[0];
            agility = characteristics[1];
            constitution = characteristics[2];
            intelligence = characteristics[3];
            wisdom = characteristics[4];
            charisma = characteristics[5];
        }

        //Вариант 2: Набор
        //Вы можете использовать следующие числа: 15, 14, 13, 12, 10, 8.
        //Назначьте каждой из характеристик одно число из набора.

        public void SetCharGen()
        {
            bool success;

            int j = 15;

            for (int i = 0; i < 6; i++)
            {
                Console.Clear();

                success = false;

                while (true)
                {
                    Console.WriteLine($"Pick a stat equal to {j}:\n" +
                        $"1. Strength: {strength}\n" +
                        $"2. Agility: {agility}\n" +
                        $"3. Constitution: {constitution}\n" +
                        $"4. Intelligence: {intelligence}\n" +
                        $"5. Wisdom: {wisdom}\n" +
                        $"6. Charisma: {charisma}\n" +
                        $"7. Reset\n" +
                        "Please write the number of the selected option.\n");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            if (strength > j)
                            {
                                Console.Clear();
                                Console.WriteLine($"This attribute has already been assigned a value {strength}.");
                            }
                            else
                            {
                                strength = j;
                                success = true;
                            }
                            break;
                        case "2":
                            if (agility > j)
                            {
                                Console.Clear();
                                Console.WriteLine($"This attribute has already been assigned a value {agility}.");
                            }
                            else
                            {
                                agility = j;
                                success = true;
                            }
                            break;
                        case "3":
                            if (constitution > j)
                            {
                                Console.Clear();
                                Console.WriteLine($"This attribute has already been assigned a value {constitution}.");
                            }
                            else
                            {
                                constitution = j;
                                success = true;
                            }
                            break;
                        case "4":
                            if (intelligence > j)
                            {
                                Console.Clear();
                                Console.WriteLine($"This attribute has already been assigned a value {intelligence}.");
                            }
                            else
                            {

                                intelligence = j;
                                success = true;
                            }
                            break;
                        case "5":
                            if (wisdom > j)
                            {
                                Console.Clear();
                                Console.WriteLine($"This attribute has already been assigned a value {wisdom}.");
                            }
                            else
                            {

                                wisdom = j;
                                success = true;
                            }
                            break;
                        case "6":
                            if (charisma > j)
                            {
                                Console.Clear();
                                Console.WriteLine($"This attribute has already been assigned a value {charisma}.");
                            }
                            else
                            {
                                charisma = j;
                                success = true;
                            }
                            break;
                        case "7":
                            ResetStats();
                            j = 15;
                            i = 0;
                            break;
                    }

                    if (success == true) break;
                }
                if (i < 3) j--;
                else j -= 2;
            }
            Console.Clear();
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

        public void ManualCharGen()
        {
            int skillPoints = 27;

            int strengthCost;
            int agilityCost;
            int constitutionCost;
            int intelligenceCost;
            int wisdomCost;
            int charismaCost;


            while (skillPoints != 0)
            {
                if (strength < 13) strengthCost = 1;
                else strengthCost = 2;

                if (agility < 13) agilityCost = 1;
                else agilityCost = 2;

                if (constitution < 13) constitutionCost = 1;
                else constitutionCost = 2;

                if (intelligence < 13) intelligenceCost = 1;
                else intelligenceCost = 2;

                if (wisdom < 13) wisdomCost = 1;
                else wisdomCost = 2;

                if (charisma < 13) charismaCost = 1;
                else charismaCost = 2;

                Console.WriteLine($"Pick a stat you want to improve:\n" +
                    $"Remaining skill points: {skillPoints}\n" +
                        $"1. Strength: {strength}, increase cost: {strengthCost}\n" +
                        $"2. Agility: {agility}, increase cost: {agilityCost}\n" +
                        $"3. Constitution: {constitution}, increase cost: {constitutionCost}\n" +
                        $"4. Intelligence: {intelligence}, increase cost: {intelligenceCost}\n" +
                        $"5. Wisdom: {wisdom}, increase cost: {wisdomCost}\n" +
                        $"6. Charisma: {charisma}, increase cost: {charismaCost}\n" +
                        $"7. Reset" +
                        $"Please write the number of the selected option.\n");

                switch (Console.ReadLine())
                {
                    case "1":
                        if (strength < 15)
                        {
                            strength++;
                            skillPoints -= strengthCost;
                        }
                        else Console.WriteLine("Сharacteristic has reached its maximum value.");
                        break;
                    case "2":
                        if (agility < 15)
                        {
                            agility++;
                            skillPoints -= agilityCost;
                        }
                        else Console.WriteLine("Сharacteristic has reached its maximum value.");
                        break;
                    case "3":
                        if (constitution < 15)
                        {
                            constitution++;
                            skillPoints -= constitutionCost;
                        }
                        else Console.WriteLine("Сharacteristic has reached its maximum value.");
                        break;
                    case "4":
                        if (intelligence < 15)
                        {
                            intelligence++;
                            skillPoints -= intelligenceCost;
                        }
                        else Console.WriteLine("Сharacteristic has reached its maximum value.");
                        break;
                    case "5":
                        if (wisdom < 15)
                        {
                            wisdom++;
                            skillPoints -= wisdomCost;
                        }
                        else Console.WriteLine("Сharacteristic has reached its maximum value.");
                        break;
                    case "6":
                        if (charisma < 15)
                        {
                            charisma++;
                            skillPoints -= charismaCost;
                        }
                        else Console.WriteLine("Сharacteristic has reached its maximum value.");
                        break;
                    case "7":
                        skillPoints = 27;
                        ResetStats();
                        break;
                }
            }
        }

        public void ShowCharacterics()
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
            strength = 8;
            agility = 8;
            constitution = 8;
            intelligence = 8;
            wisdom = 8;
            charisma = 8;
        }

        // ВНЕШНОСТЬ

        public string skinColor;
        public string hairColor;
        public string eyeColor;
        public string hair;
        public string beard;
        public string mustache;

        public void RandomAppearanceGen(bool male, string[] skinColor, string[] hairColor, string[] eyeColor, string[] hair, string[] beard, string[] mustache)
        {
            Random rand = new Random();

            this.skinColor = skinColor[rand.Next(0, skinColor.Length)];
            this.hairColor = hairColor[rand.Next(0, hairColor.Length)];
            this.eyeColor = eyeColor[rand.Next(0, eyeColor.Length)];
            this.hair = hair[rand.Next(0, hair.Length)];
            if(male == true)
            {
                this.beard = beard[rand.Next(0, beard.Length)];
                this.mustache = mustache[rand.Next(0, mustache.Length)];
            }
        }

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
    }
}
