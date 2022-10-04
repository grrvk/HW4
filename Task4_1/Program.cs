using System;

namespace Task4_1
{
    abstract class GeoObject
    {
        public double CooX;
        public double CooY;
        public string? Name;
        public string? Description;
        public virtual void getObjInfo() {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("Coordinates: {0},{1}", CooX, CooY);
            Console.WriteLine($"Description: {Description}");
        }
        public void setInfo(double x, double y, string name, string description)
        {
            CooX = x;
            CooY = y;
            Name = name;
            Description = description;
        }
    }

    class River : GeoObject
    {
        public double Speed;
        public double Length;
        public override void getObjInfo()
        {
            base.getObjInfo();
            Console.WriteLine("Speed: {0} cm/s", Speed);
            Console.WriteLine("Length: {0} km\n", Length);
        }
        public void setInfo(double x, double y, string name, string description,
                            double speed, double length)
        {
            CooX = x;
            CooY = y;
            Name = name;
            Description = description;
            Speed = speed;
            Length = length;
        }
    }

    class Mountain : GeoObject
    {
        public double HighestPoint;
        public override void getObjInfo()
        {
            base.getObjInfo();
            Console.WriteLine("Highest point: {0}m\n", HighestPoint);
        }
        public void setInfo(double x, double y, string name, string description,
                            double point)
        {
            CooX = x;
            CooY = y;
            Name = name;
            Description = description;
            HighestPoint = point;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            River Dnipro = new River();
            Dnipro.setInfo(0, 0, "Дніпро", "Pічка з найдовшою течією в Україні", 80, 2201);
            Dnipro.getObjInfo();
            Mountain MountEverest = new Mountain();
            MountEverest.setInfo(1, 1, "Еверест", "Найвища вершина земної кулі", 8849);
            MountEverest.getObjInfo();
            
        }
    }
}