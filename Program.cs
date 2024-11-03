namespace Heritage_3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Device[] devices =
            //{
            //    new Kettle(),
            //    new Microwave(),
            //    new Car(),
            //    new Steamship()
            //};

            //foreach (var dev in devices)
            //{
            //    dev.Show();
            //    dev.Desc(); 
            //    dev.Sound();
            //}

            //Instrument[] devices =
            //{
            //    new Violin(),
            //    new Trombone(),
            //    new Ukulele(),
            //    new Cello()
            //};

            //foreach (var dev in devices)
            //{
            //    dev.Show();
            //    dev.Desc();
            //    dev.Sound();
            //}
            Worker[] devices =
            {
                new President(),
                new Security(),
                new Manager(),
                new Engineer()
            };

            foreach (var dev in devices)
            {
                dev.Print();
            }


        }
        //public abstract class Device 
        //{
        //    public string name;
        //    public string characteristic;

        //    public Device(string name, string characteristic)
        //    {
        //        this.name = name;
        //        this.characteristic = characteristic;
        //    }

        //    public abstract void Sound();
        //    public virtual void Show()
        //    {
        //        Console.WriteLine($"Device name - {name}");
        //    }
        //    public virtual void Desc()
        //    {
        //        Console.WriteLine($"Desc - {characteristic}");
        //    }

        //}

        //public class Kettle : Device
        //{
        //    public Kettle() : base(" kettle ", " for boiling water") { }
        //    public override void Sound()
        //    {
        //        Console.WriteLine(" Shhhshhshshhshsh ");
        //    }
        //}

        //class Microwave : Device
        //{
        //    public Microwave() : base(" microwave ", " for heating food") { }

        //    public override void Sound()
        //    {
        //        Console.WriteLine(" Beebebebeebebeb ");
        //    }

        //}

        //class Car : Device
        //{
        //    public Car() : base("Car", " vehicle for people") { }

        //    public override void Sound()
        //    {
        //        Console.WriteLine("Vroooooom");
        //    }
        //}

        //class Steamship : Device
        //{
        //    public Steamship() : base(" steamship ", " by steam") { }

        //    public override void Sound()
        //    {
        //        Console.WriteLine("Choo choo...");
        //    }
        //}
        public abstract class Instrument
        {
            public string name;
            public string characteristic;

            public Instrument(string name, string characteristic)
            {
                this.name = name;
                this.characteristic = characteristic;
            }

            public abstract void Sound();
            public virtual void Show()
            {
                Console.WriteLine($"Device name - {name}");
            }
            public virtual void Desc()
            {
                Console.WriteLine($"Desc - {characteristic}");
            }

            public abstract void History();
            
        }

        public class Violin : Instrument
        {
            public Violin() : base(" Violin ", " for boiling water") { }
            public override void Sound()
            {
                Console.WriteLine(" Shhhshhshshhshsh ");
            }
            public override void History()
            {
                Console.WriteLine(" ---- 10 century ----");
            }
        }

        class Trombone : Instrument
        {
            public Trombone() : base(" Trombone ", " for heating food") { }

            public override void Sound()
            {
                Console.WriteLine(" Beebebebeebebeb ");
            }
            public override void History()
            {
                Console.WriteLine(" ---- 16 century ----");
            }

        }

        class Ukulele : Instrument
        {
            public Ukulele() : base("Ukulele", " vehicle for people") { }

            public override void Sound()
            {
                Console.WriteLine("Vroooooom");
            }
            public override void History()
            {
                Console.WriteLine(" ---- 13 century ----");
            }
        }

        class Cello : Instrument
        {
            public Cello() : base(" Cello ", " by steam") { }

            public override void Sound()
            {
                Console.WriteLine("Choo choo...");
            }
            public override void History()
            {
                Console.WriteLine(" ---- 14 century ----");
            }
        }

        abstract class Worker
        {
            public string name;
            public int year;

            public Worker(string name, int year)
            {
                this.name = name;
                this.year = year;
            }

            public abstract void Print();
        }
        class President : Worker
        {
            public President() : base(" Djo ", 72) { }

            public override void Print()
            {
                Console.WriteLine($"President: {name} / {year}");
            }
        }
        class Security : Worker
        {
            public Security() : base(" Entony ", 40) { }

            public override void Print()
            {
                Console.WriteLine($"Security: {name} / {year}");
            }
        }
        class Manager : Worker
        {
            public Manager() : base(" Publo ", 56) { }

            public override void Print()
            {
                Console.WriteLine($"Manager: {name} / {year}");
            }
        }
        class Engineer : Worker
        {
            public Engineer() : base(" Rick ", 34) { }

            public override void Print()
            {
                Console.WriteLine($"Engineer: {name} / {year}");
            }
        }
    }
}
