using System;

namespace Polymorphism
{
    public class PolymorphismExample
    {
        static void Main2(string[] args)
        {
            // Создаём объект Sapper, наследующий абстрактный Human и реализующий ISoldier.
            // Через sapper доступны:
            // 1. Все собственные методы Sapper
            // 2. Реализации абстрактных методов Human (обязательные для Sapper)
            // 3. Методы интерфейса ISoldier (реализованные в Sapper)
            // 4. Унаследованные неабстрактные методы Human
            Sapper sapper = new Sapper("Сидоров");

            // Мы можем привести экземпляр объекта Sapper к типу ISoldier.
            // Через эту переменную доступны ТОЛЬКО методы, объявленные в интерфейсе ISoldier:
            // 1. Если метод реализован в интерфейсе и в классе Sapper и помечен internal/private (в классе),
            //    то будет вызвана реализация из интерфейса
            // 2. Если метод реализован в интерфейсе и в классе Sapper и помечен public (в классе),
            //    то будет вызвана реализация из класса
            // 3. Если метод не реализован в классе, но есть реализация по умолчанию в интерфейсе - 
            //    будет вызвана она
            // 4. Если метод не реализован ни в классе, ни в интерфейсе - возникнет ошибка компиляции
            // При этом методы класса Sapper, не объявленные в интерфейсе, через эту переменную недоступны
            ISoldier isoldier = new Sapper("Сидоров");
            ISoldier isoldier2 = sapper;

            isoldier.SubmitRapport();
            isoldier.ToDo();

            // Приводим объект Sapper к базовому типу Human
            // Теперь доступны только:
            // 1. Методы, определённые в классе Human (включая абстраные)
            // 2. Если метод virtual переопределён в Sapper, то вызывается переопределённая версия
            //    из Sapper, даже если обращение идёт через переменную типа Human
            // 3. Если метод virtual не переопределён в Sapper, то вызывается базовая реализация из Human
            // Методы самого Sapper и интерфейсов через human недоступны,
            // хотя фактически объект остаётся экземпляром Sapper.
            Human human = sapper;
            Human human2 = new Sapper("Петров");

            // такому объкту доступны только методы из класса Human
            human2.JustGo();
            human2.VirtulMethod();

            // а вот так сделать не можем: требуется явное приведение типов
            // Sapper sapper2 = human2;
        }
    }
    
    public interface ISoldier
    {
        public void ToDo();

        public void SubmitRapport()
        {
            Console.WriteLine("Солдат сдал раппорт!");
        }
    }

    public abstract class Human
    {
        private string name;
        abstract public void JustGo();
        public string GetName()
        {
            return this.name;
        }

        public virtual void VirtulMethod()
        {
            Console.WriteLine("Я метод из базового класса");
        }

        public Human(string name)
        {
            this.name = name;
        }
    }

    public class Sapper : Human, ISoldier
    {
        public Sapper(string name) : base(name)
        {
        }

        public override void JustGo()
        {
            Console.WriteLine("Пробираюсь по миному полю!");
        }

        public void SubmitRapport()
        {
            Console.Write($"Сапер {this.GetName()} сдал раппорт!");
        }

        public void ToDo()
        {
            Console.WriteLine("Явно обезвредить мину!");
        }

        public void DigGround()
        {
            //todo
        }

        public override void VirtulMethod()
        {
            Console.WriteLine("Я метод из класса сапер");
        }
    }
}