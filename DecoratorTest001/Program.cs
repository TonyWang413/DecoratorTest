using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTest001
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小菜");
            TShirts dtx = new TShirts();
            BigTrouser kk = new BigTrouser();

            dtx.Decorate(xc);
            kk.Decorate(dtx);
            kk.Show();

            Console.Read();
        }
    }

    public class Person
    {
        public Person() { }

        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"裝扮的{name}");
        }
    }

    public class Finery : Person
    {
        protected Person component;

        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if (component != null)
            {
                component.Show();
            }
        }
    }

    public class TShirts : Finery
    {
        public override void Show()
        {
            Console.Write("大T恤 ");
            base.Show();
        }
    }

    public class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.Write("垮褲 ");
            base.Show();
        }
    }
}
