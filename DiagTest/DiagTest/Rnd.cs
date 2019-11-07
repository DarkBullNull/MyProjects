using System;
using System.Collections.Generic;
using System.Text;

namespace DiagTest
{
    public class RandomNotRepeat : System.Random
    {
        int _min, _max;
        public Stack<int> list;
        /// <summary>
        /// Инициализирует новый экземпляр класса System.Random с помощью зависимого
        //  от времени начального значения по умолчанию.
        /// </summary>
        /// <param name="min">Включенной нижний предел возвращаемого случайного числа.</param>
        /// <param name="max">Исключенный верхний предел возвращаемого случайного числа. Значение maxValue должно быть больше или равно значению minValue.</param>
        public RandomNotRepeat(int minValue, int maxValue)
        {
            _max = maxValue;
            _min = minValue;
            genList();
        }
        /// <summary>
        /// Генерация списка исключений
        /// </summary>
        protected void genList()
        {
            System.Random rand = new System.Random();
            List<int> temp = new List<int>();
            for (int i = _min; i < _max; i++)
            {
                temp.Add(i);
            }
            list = new Stack<int>();
            while (temp.Count > 0)
            {
                int addInt = temp[rand.Next(0, temp.Count)];
                list.Push(addInt);
                temp.Remove(addInt);
            }
        }
        /// <summary>
        /// Возвращает неотрицательное случайное число.
        /// </summary>
        /// <returns>32-разрядное целое число со знаком большее или равное minValue и меньше, чем maxValue; то есть, диапазон возвращаемого значения включает minValue, не включает maxValue. Если значение параметра minValue равно значению параметра maxValue, то возвращается значение minValue.</returns>
        public override int Next()
        {
            if (list.Count > 0)
            {
                return list.Pop();
            }
            else
            {
                genList();
            }
            return list.Pop();
        }

    }
}