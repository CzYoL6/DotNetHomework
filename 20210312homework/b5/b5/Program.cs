using System;
using System.Collections.Generic;
using b4;

namespace b5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            
            for(int i = 1; i <= 10; i++)
            {
                int type = r.Next(0, 3);
                
                Shape shape;
                List<double> len = new List<double>();
                string s;
                if(type == 0)
                {
                    s = "square";
                    len.Add(r.Next(1, 11));
                    len.Add(r.Next(1, 11));
                    len.Add(r.Next(1, 11));
                    len.Add(r.Next(1, 11));
                    shape = ShapeFactory<Square>.Instance.createShape(len);
                }
                else if (type == 2)
                {
                    s = "rect";
                    len.Add(r.Next(1, 11));
                    len.Add(r.Next(1, 11));
                    len.Add(r.Next(1, 11));
                    len.Add(r.Next(1, 11));
                    shape = ShapeFactory<Rect>.Instance.createShape(len);
                }
                else
                {
                    s = "triangle";
                    len.Add(r.Next(1, 11));
                    len.Add(r.Next(1, 11));
                    len.Add(r.Next(1, 11));
                    shape = ShapeFactory<Triangle>.Instance.createShape(len);
                }


                Console.WriteLine("A {0} is created.", s);
                Console.Write("Lengths: ");
                foreach(var x in len) Console.Write("{0} ",x);
                Console.WriteLine();

                if (shape.check())
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine(shape.getArea());
                }
                else Console.WriteLine("No");

                Console.WriteLine();
            }
        }
    }

    public class ShapeFactory<T> where T : Shape
    {
        private static ShapeFactory<T> instance;
        public static ShapeFactory<T> Instance {
            get
            {
                if (instance == null) instance = new ShapeFactory<T>();
                return instance;
            }
        }
        public Shape createShape(List<double> lengths)
        {
            T t = (T)Activator.CreateInstance(typeof(T), lengths);

            return t;
        }
    }
}
