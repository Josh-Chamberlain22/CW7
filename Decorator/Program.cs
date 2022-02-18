using System;

namespace Decorator
{
   
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
        abstract class Decorator : Widget
        {
            private Widget wid;
            public Decorator(Widget w)
            {
                wid = w;
            }
            public virtual void draw()
            {
                wid.draw();
            }

        }
        class TextField : Widget
        {
            private int width;
            private int height;
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
        class BorderDecorator : Decorator
        {
            public BorderDecorator(Widget w) : base(w)
            {

            }
            public override void draw()
            {
                Console.WriteLine("I am a BorderDecorator holding a: ");
                base.draw();
            }
        }
        class ScrollDecorator : Decorator
        {
            public ScrollDecorator(Widget w) : base(w)
            {
                
            }
            public override void draw()
            {
                Console.WriteLine("I am a Scroll Decorator holding a: ");
                base.draw();
            }
        }
        class StateDecorator : Decorator
        {
            public StateDecorator(Widget w) : base(w)
            {

            }
            public override void draw()
            {
                Console.WriteLine("I am a StateDecorator holding a: ");
                base.draw();
            }
        }
    }
}
