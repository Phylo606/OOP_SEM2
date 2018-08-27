using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattPhyland_assessment1
{
    public abstract class Shape
    {
        public string Colour { get; set; }
        public Shape(string colour)
        {
            this.Colour = colour;
        }
    }
    public abstract class Quadrilateral : Shape
    {
        public int Side1Length { get; set; }
        public int Side2Length { get; set; }
        public int Side3Length { get; set; }
        public int Side4Length { get; set; }
        public float GetPerimeter()
        {
            return (Side1Length + Side2Length + Side3Length + Side4Length);
        }
        public Quadrilateral(int side1length, int side2length, int side3length, int side4length, string colour) : base(colour)
        {
            this.Side1Length = side1length;
            this.Side2Length = side2length;
            this.Side3Length = side3length;
            this.Side4Length = side3length;
        }
    }
    public class Square : Quadrilateral
    {
        public float GetArea()
        {
            return (Side1Length * Side1Length);
        }
        public Square(int side1length, int side2length, int side3length, int side4length, string colour) : base(side1length, side2length, side3length, side4length, colour)
        {

        }
    }
    public class Rectangle : Quadrilateral
    {
        public float GetArea()
        {
            return (Side1Length * Side2Length);
        }
        public Rectangle(int side1length, int side2length, int side3length, int side4length, string colour) : base(side1length, side2length, side3length, side4length, colour)
        {

        }
    }
}
