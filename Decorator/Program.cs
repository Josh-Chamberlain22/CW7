//Name: Joshua Chamberlain
//Date: 02-17-2022
//Description: Uses the decorater design pattern to add layers to a Text Field
using System;

namespace Decorator
{
   
    //Contains interface Widget, allowing subclasses to draw. Tests different objects.
    class DecoratorDemo
    {

        interface Widget
        {
            void draw();
        }
        static void Main(string[] args)
        {
            TextField A = new TextField(100, 100);
            BorderDecorator BD = new BorderDecorator(A);
            ScrollDecorator SD = new ScrollDecorator(BD);
            StateDecorator StateD = new StateDecorator(SD);
            Console.WriteLine("Testing BorderDecorator");
            BD.draw();
            Console.WriteLine("Testing ScrollDecorator");
            SD.draw();
            Console.WriteLine("Testing StateDecorator");
            StateD.draw();
        }
        //Allows a Widget to be created.
        abstract class Decorator : Widget
        {
            private Widget wid;
            //Constructor for decorator.
            public Decorator(Widget w)
            {
                wid = w;
            }
            //The base draw for every widget and subclasses.
            public virtual void draw()
            {
                wid.draw();
            }

        }
        //Allows the creation of text field and provides proof of it being called with draw.
        class TextField : Widget
        {
            private int width;
            private int height;
            //Constructor for TextField. Sets width and height.
            public TextField(int w, int h)
            {
                width = w;
                height = h;
            }
            public virtual void draw()
            {
                Console.WriteLine("I am a TextField with width " + width + " and height " + height);
            }
        }
        //Allows a border decorator to call the base constructor.
        class BorderDecorator : Decorator
        {
            //Constructor for BorderDecorator. Uses base constructor.
            public BorderDecorator(Widget w) : base(w)
            {

            }
            //Prints text for testing.
            public override void draw()
            {
                Console.WriteLine("I am a BorderDecorator holding a: ");
                base.draw();
            }
        }
        //Allows a scroll decorator to call the base constructor.
        class ScrollDecorator : Decorator
        {
            //Constructor for ScrollDecorator. Uses base constructor.
            public ScrollDecorator(Widget w) : base(w)
            {
                
            }
            //Prints text for testing
            public override void draw()
            {
                Console.WriteLine("I am a Scroll Decorator holding a: ");
                base.draw();
            }
        }
        //Allows a state decorator to call the base constructor.
        class StateDecorator : Decorator
        {
            //Constructor for StateDecorater. Uses base constructor.
            public StateDecorator(Widget w) : base(w)
            {

            }
            //Prints text for testing.
            public override void draw()
            {
                Console.WriteLine("I am a StateDecorator holding a: ");
                base.draw();
            }
        }
    }
}
