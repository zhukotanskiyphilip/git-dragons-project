﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{
    class Player
    {
        public string name;
        public int coins = 0;
        public int health = 10;
        public int damage;
        public int armor;

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

        //Вариант 2: Набор
        //Вы можете использовать следующие числа: 15, 14, 13, 12, 10, 8.
        //Назначьте каждой из характеристик одно число из набора.

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

        //остановился на стр. 18
    }
}