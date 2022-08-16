using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Upcasting - conversion from a derived class to a base class
// Downcasting - conversion from a base class to a derived clas
/*
 * 
 *Upcasting:

public class Shape
{
}

public class Circle : Shape
{
}

*Upcasting: no conversion required - it's implicit
Circle circle = new Circle();
Shape shape = circle;

*Downcasting:
Circle circle = new Circle();
Shape shape = circle;
Circle anotherCircle = (Circle)Shape;

*The as keyword: - when an object cannot be converted 
 Car car = (Car) obj;
Car car = obj as Car;
if (car != null)
{
    ...
}

*The is keyword:
if (obj is Car) //when obj is a car it can be safely casted into a car
{
    Car car = (Car)obj;
    ...
}
 */

namespace UpcastingAndDowncasting
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Text text = new Text();
            //Shape shape = text; // upcasting -- object shape is pointing to the same spot in the memory as object tex

            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(text.Width); // the result is 100

            //StreamReader reader = new StreamReader(new MemoryStream());

            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add("Poop");
            //list.Add(new Text());

            ////generic list class:
            //var anotherList = new List<Shape>();

            Shape shape = new Text();
            Text text = (Text)shape;
        }
    }
}
