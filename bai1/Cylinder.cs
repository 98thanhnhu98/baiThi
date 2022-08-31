using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    internal class Cylinder
    {
        public static List<Cylinder> Cylinders = new List<Cylinder>();
        public double Radius { get; set; }
        public double Height { get; set; }
        public double BaseArea { get; set; }
        public double LateralArea { get; set; }
        public double TotalArea { get; set; }
        public double Volume { get; set; }
        public Cylinder() { }
        public Cylinder(double radius,double height,double baseArea,double lateralArea,double totalArea,double volume)
        {
            Radius = radius;
            Height = height;
            BaseArea = baseArea;
            LateralArea = lateralArea;
            TotalArea = totalArea;
            Volume = volume;
        }
        public void Process()
        {
            Console.WriteLine("Nhap Radius");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Height");
            double height = double.Parse(Console.ReadLine());
            double baseArea = radius * radius * Math.PI;
            double lateralArea = 2 * Math.PI * radius * height;
            double totalArea = 2 * Math.PI * radius * (height + radius);
            double volume = Math.PI * radius * radius * height;
            Cylinder cylinder = new Cylinder(radius,height,baseArea,lateralArea,totalArea,volume);
            Cylinders.Add(cylinder);
        }
        public void Result()
        {
            
            Cylinder cylinder = new Cylinder();
            
            foreach(Cylinder cylinder1 in Cylinders)
            {
                Console.WriteLine(cylinder1);
            }
        }
        public override string ToString()
        {
            return "Radius :" + Radius + ", Height : " + Height +"\n" +
           "Base :" + BaseArea + " | Lateral :" + LateralArea + " | Total :" +TotalArea + " | Volume:" + Volume;
        }
        public static void Main(string[] cmd)
        {
            Cylinder cylinder = new Cylinder();
            cylinder.Process();
            cylinder.Result();
        }
        
    }

}
