using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    abstract class Фабрика_смартфонов: IФабрика_смартфонов
    {
        public abstract string GetType();
        public string Модель;
        public int ДиаметрЭкрана;
        public int КоличествоСимкарт;
        public float ОбъемОП;
        public string ТипОС;
        public virtual void ВывестиМодель() { }
        public virtual void ВывестиДиаметрЭкрана() { }
        public virtual void ВывестиКоличествоСимкарт() { }
        public virtual void ВывестиОбъемОП() { }
        public virtual void ВывестиТипОС() { }
        public void ВывестиВсеПоСмартфону()
        {
            ВывестиМодель();
            ВывестиДиаметрЭкрана();
            ВывестиКоличествоСимкарт();
            ВывестиОбъемОП();
            ВывестиТипОС();
        }
    }
    public interface IФабрика_смартфонов
    {
        void ВывестиМодель();
        void ВывестиДиаметрЭкрана();
        void ВывестиКоличествоСимкарт();
        void ВывестиОбъемОП();
        void ВывестиТипОС();
    }
    class HTC : Фабрика_смартфонов, IФабрика_смартфонов
    {
        public override string GetType() { return "HTC"; }
        override public void ВывестиМодель() 
        {
            Модель = "Desire 300";
            Console.WriteLine("Модель HTC {0}", Модель);
            
        }
        override public void ВывестиДиаметрЭкрана()
        {
            ДиаметрЭкрана = 4;
            Console.WriteLine("Диаметр экрана  {0}", ДиаметрЭкрана);
        }
        override public void ВывестиКоличествоСимкарт()
        {
            КоличествоСимкарт = 1;
            Console.WriteLine("Количества SIM-карт {0}", КоличествоСимкарт);
        }
        override public void ВывестиОбъемОП()
        {
            ОбъемОП = 512;
            Console.WriteLine("Количество ОП {0} мб", ОбъемОП);
        }
        override public void ВывестиТипОС()
        {
            ТипОС = "Android";
            Console.WriteLine("Операциооная система {0}", ТипОС);
        }
    }
    class Samsung : Фабрика_смартфонов
    {
        public override string GetType() { return "Samsung"; }
        override public void ВывестиМодель()
        {
            Модель = "j5";
            Console.WriteLine("Модель samsung {0}", Модель);

        }
        override public void ВывестиДиаметрЭкрана()
        {
            ДиаметрЭкрана = 5;
            Console.WriteLine("Диаметр экрана  {0}", ДиаметрЭкрана);
        }
        override public void ВывестиКоличествоСимкарт()
        {
            КоличествоСимкарт = 2;
            Console.WriteLine("Количества SIM-карт {0}", КоличествоСимкарт);
        }
        override public void ВывестиОбъемОП()
        {
            ОбъемОП = 2048;
            Console.WriteLine("Количество ОП {0} мб", ОбъемОП);
        }
        override public void ВывестиТипОС()
        {
            ТипОС = "Android";
            Console.WriteLine("Операциооная система {0}", ТипОС);
        }
    }

    class Lenova : Фабрика_смартфонов
    {
        public override string GetType() { return "Lenova"; }
        override public void ВывестиМодель()
        {
            Модель = "m300";
            Console.WriteLine("Модель lenova {0}", Модель);

        }
        override public void ВывестиДиаметрЭкрана()
        {
            ДиаметрЭкрана = 5;
            Console.WriteLine("Диаметр экрана  {0}", ДиаметрЭкрана);
        }
        override public void ВывестиКоличествоСимкарт()
        {
            КоличествоСимкарт = 1;
            Console.WriteLine("Количества SIM-карт {0}", КоличествоСимкарт);
        }
        override public void ВывестиОбъемОП()
        {
            ОбъемОП = 1512;
            Console.WriteLine("Количество ОП {0} мб", ОбъемОП);
        }
        override public void ВывестиТипОС()
        {
            ТипОС = "Android";
            Console.WriteLine("Операциооная система {0}", ТипОС);
        }
    
}
    class Sony : Фабрика_смартфонов
    {
        public override string GetType() { return "Sony"; }
        override public void ВывестиМодель()
        {
            Модель = "xperia z";
            Console.WriteLine("Модель sony {0}", Модель);

        }
        override public void ВывестиДиаметрЭкрана()
        {
            ДиаметрЭкрана = 4;
            Console.WriteLine("Диаметр экрана  {0}", ДиаметрЭкрана);
        }
        override public void ВывестиКоличествоСимкарт()
        {
            КоличествоСимкарт = 1;
            Console.WriteLine("Количества SIM-карт {0}", КоличествоСимкарт);
        }
        override public void ВывестиОбъемОП()
        {
            ОбъемОП = 1024;
            Console.WriteLine("Количество ОП {0} мб", ОбъемОП);
        }
        override public void ВывестиТипОС()
        {
            ТипОС = "Android";
            Console.WriteLine("Операциооная система {0}", ТипОС);
        }
    }

    abstract class Creator
    {
        public abstract Фабрика_смартфонов FactoryMethod();
    }

    class ConcreteCreatorA : Creator
    {
        public override Фабрика_смартфонов FactoryMethod() { return new HTC();   }
    }

    class ConcreteCreatorB : Creator
    {
        public override Фабрика_смартфонов FactoryMethod() { return new Samsung(); }

    }
    class ConcreteCreatorC : Creator
    {
        public override Фабрика_смартфонов FactoryMethod() { return new Lenova(); }
    }
    class ConcreteCreatorD : Creator
    {
        public override Фабрика_смартфонов FactoryMethod() { return new Sony(); }
    }

    public class MainApp
    {
        public static void Main()
        {
            // an array of creators
            Creator[] creators = { new ConcreteCreatorA(), new ConcreteCreatorB(), new ConcreteCreatorC(), new ConcreteCreatorD() };
            // iterate over creators and create products
            foreach (Creator creator in creators)
            {
                Фабрика_смартфонов product = creator.FactoryMethod();
                Console.WriteLine("Создан {0}", product.GetType());
                product.ВывестиВсеПоСмартфону();
                Console.WriteLine("");


            }
           
            // Wait for user
            Console.Read();
        }
    }
}