using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Metanit_lessons
{
    class Program
    {

        //Напишите обобщенный класс, который может хранить в массиве объекты любого типа.
        //Кроме того, данный класс должен иметь методы для добавления данных в массив, удаления из массива,
        //получения элемента из массива по индексу и метод, возвращающий длину массива.

        //Для упрощения работы можно пересоздавать массив при каждой операции добавления и удаления


        static void Main(string[] args)
        {
            //Instantiator<int> x = new Instantiator<int>();
            //x.AddObject(12, 2, 1);
            //int y = x.GetElement(1);
            //int a = x.GetLength();
            //x.DeleteObject(1);

            Collection<int> x = new Collection<int>();
            x.Add(5);
            x.Add(7);
            x.Add(8);
            x.Remove(7);

        }
    }

    class Collection<T>
    {
        T[] data; // массив с данными

        public Collection()
        {
            data = new T[0];
        }

        // добавление данных
        public void Add(T item)
        {
            T[] newData = new T[data.Length + 1];
            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[i];
            }

            newData[data.Length] = item;
            data = newData;
        }

        // удаление данных - удаляем первое вхождение элемента при его наличии
        public void Remove(T item)
        {
            // находим индекс элемента
            int index = -1;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }
            // удаляем элемент по индексу
            if (index > -1)
            {
                T[] newData = new T[data.Length - 1];
                for (int i = 0, j = 0; i < data.Length; i++)
                {
                    if (i == index) continue;
                    newData[j] = data[i];
                    j++;
                }
                data = newData;
            }
        }
    }

    ////////////

    class Instantiator<T>
    {
        private T[] MyArray;

        //Добавление в массив
        public void AddObject(T obj, int length, int index)
        {
            MyArray = new T[length];
            MyArray[index] = obj;
        }

        //Удаление из массива
        public void DeleteObject(int index)
        {
            MyArray[index] = default(T);
        }

        //Получение из массива по индексу
        public T GetElement(int index)
        {
            return MyArray[index];
        }

        //Получаем длину массива
        public int GetLength()
        {
            return MyArray.Length;
        }
    }

}
