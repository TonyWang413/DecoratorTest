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
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            d1.SetComponent(c);
            d2.SetComponent(d1);
            d2.Operation();

            Console.Read();
        }
    }

    public abstract class Component
    {
        public abstract void Operation();
    }

    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具體物件的操作");
        }
    }

    public abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }

    public class ConcreteDecoratorA : Decorator
    {
        private string addedState;
        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            Console.WriteLine("具體裝飾物件A的操作");
        }
    }

    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("具體裝飾物件B的操作");
        }

        private void AddedBehavior()
        {
        }
    }
}
