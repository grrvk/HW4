using System;

namespace Task4_1
{
    interface GeoObject
    {
        double CooX { get; set; }
        double CooY { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        virtual void getObjInfo()
        { 
        }
        public void setInfo(double x, double y, string name, string description)
        {
        }
    }

    class River : GeoObject
    {
        public double CooX { get; set; }
        public double CooY { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Speed { get; set; }
        public double Length { get; set; }
        public void getObjInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("Coordinates: {0},{1}", CooX, CooY);
            Console.WriteLine($"Description: {Description}");
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
        public double CooX { get; set; }
        public double CooY { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double HighestPoint;
        public void getObjInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("Coordinates: {0},{1}", CooX, CooY);
            Console.WriteLine($"Description: {Description}");
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