using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConversions
{
    public struct Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int w, int h) : this()
        {
            Width = w; Height = h;
        }
    
        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public override string ToString() => ($"Width = {Width}; Height = {Height}");
    }
    public struct Square
    {
        public int Length { get; set; }
        public Square(int l) : this()
        {
            Length = l;
        }
        public void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public override string ToString() => ($"Length = {Length}");
        
        public static explicit operator Square(Rectangle r)
        {
            Square s = new Square { Length = r.Height };
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Conversion *****");

            Rectangle r = new Rectangle(15, 4);
            Console.WriteLine(r.ToString());
            r.Draw();
            Square s = (Square)r;
            Console.WriteLine(s.ToString());
            s.Draw();

            // Преобразовать Rectangle в Square для вызова метода.
            Rectangle rect = new Rectangle(10, 5);
            DrawSquare((Square)rect);
            Console.ReadLine();
        }
        static void DrawSquare(Square sq)
        {
            Console.WriteLine(sq.ToString());
            sq.Draw();
        }
    }
}

   

