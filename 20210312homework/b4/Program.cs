using System;
using System.Collections;
using System.Collections.Generic;
namespace b4
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle a = new Triangle(new List<double>{3, 4, 5});
            if(a.check()){
                Console.WriteLine("Yes");
                Console.WriteLine(a.getArea());
            }else Console.WriteLine("No");

        }
    }

    abstract public class Shape{
        public static int LengthsCntRequired{get; set;}
        public Shape(List<double> ls){
            lengths.Clear();
            foreach (double x in ls)
            {
                lengths.Add(x);
            }
            
        }
        public List<Double> lengths = new List<Double>();
       public abstract bool check();
        public abstract double getArea();
    }

    public class Rect : Shape{
        static Rect(){
            LengthsCntRequired = 4;
        }
        override public bool check(){
            lengths.Sort((x, y) => x.CompareTo(y));
            if(lengths[0] != lengths[1] || lengths[2] != lengths[3]) return false;
            return true;
        }

        override public double getArea(){
            lengths.Sort((x, y) => x.CompareTo(y));
            return lengths[0] * lengths[2];
        }

        public Rect(List<double> ls):base(ls){
        }
    }

    public class Square : Rect{
        static Square(){
            LengthsCntRequired = 4;
        }
        override public bool check(){
            lengths.Sort((x, y) => x.CompareTo(y));
            if(lengths[0] != lengths[1] || lengths[1] != lengths[2] || lengths[2] != lengths[3]) return false;
            return true;
        }

        public Square(List<double> ls):base(ls){
        }
    }
    
    public class Triangle : Shape{
        static Triangle(){
            LengthsCntRequired = 3;
        }
        public Triangle(List<double> ls):base(ls){
        }
        override public bool check(){
            lengths.Sort((x, y) => x.CompareTo(y));
            if(lengths[0] + lengths[1] <= lengths[2]) return false;
            return true;
        }

        override public double getArea(){
            lengths.Sort((x, y) => x.CompareTo(y));
            double p = (lengths[0] + lengths[1] + lengths[2]) / 2;

            return Math.Sqrt(p * (p - lengths[0]) * (p - lengths[1]) * (p - lengths[2]));
        }
    }


}
