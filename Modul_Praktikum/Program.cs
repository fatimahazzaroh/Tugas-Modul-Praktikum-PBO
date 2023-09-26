namespace Modul
{
    class Processor
    {
        public string merk, tipe;
        public Processor(string _merk, string _tipe)
        {
            this.merk = _merk;
            this.tipe = _tipe;
        }
    }
    class Intel : Processor
    {
        public Intel (string _tipe, string _merk = "Intel") : base(_merk, _tipe)
        {

        }

    }
    class AMD : Processor
    {
        public AMD(string _tipe, string _merk = "AMD") : base(_tipe, _merk)
        {

        }
    }
    class Corei3 : Intel
    {
        public Corei3(string _merk, string _tipe = "Core i3") : base(_merk, _tipe)
        {

        }
    }
    class Corei5 : Intel
    {
        public Corei5(string _merk, string _tipe = "Core i5") : base(_merk, _tipe)
        {

        }
    }
    class Corei7 : Intel
    {
        public Corei7(string _merk, string _tipe = "Core i7") : base(_merk, _tipe)
        {

        }
    }

    class Ryzen : AMD
    {
        public Ryzen(string _merk, string _tipe = "Ryzen") : base(_merk, _tipe)
        {

        }
    }
    class Athlon : AMD
    {
        public Athlon(string _merk, string _tipe = "Athlon") : base(_merk, _tipe)
        {

        }
    }
    class Vga
    {
        public string merk;
        public Vga(string _merk)
        {
            this.merk = _merk;
        }
    }
    class Nvidia : Vga
    {
        public Nvidia(string _merk = "Nvidia") : base(_merk)
        {

        }
    }
    class Amd : Vga
    {
        public Amd(string _merk = "AMD") : base(_merk)
        {

        }
    }
    class Laptop
    {
        public string merk, tipe;
        public Vga vga;
        public Processor processor;
        public Laptop (string _merk, string _tipe, Vga _vga, Processor _processor)
        {
            this.merk = _merk; 
            this.tipe = _tipe;
            this.vga = _vga;
            this.processor = _processor;
        }
        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala.");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati.");
        }
    }
    class ASUS : Laptop
    {
        public ASUS( string _tipe, Vga _vga, Processor _processor, string _merk = "ASUS") : base(_merk, _tipe, _vga, _processor)
        {

        }
    }
    class ROG : ASUS
    {
        public ROG(Vga _vga, Processor _processor, string _merk = "ASUS", string _tipe = "ROG") : base(_tipe, _vga, _processor, _merk)
        {

        }
    }
    class Vivobook : ASUS
    {
        public Vivobook(Vga _vga, Processor _processor, string _merk = "ASUS", string _tipe = "Vivobook") : base(_tipe, _vga, _processor, _merk)
        {

        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!!");
        }
    }
    class ACER : Laptop
    {
        public ACER(string _tipe, Vga _vga, Processor _processor, string _merk = "ACER") : base(_merk, _tipe, _vga, _processor)
        {

        }
    }
    class Swift : ACER
    {
        public Swift(Vga _vga, Processor _processor, string _merk = "ACER", string _tipe = "Swift") : base(_tipe, _vga, _processor, _merk)
        {

        }
    }
    class Predator : ACER
    {
        public Predator(Vga _vga, Processor _processor, string _merk = "ACER", string _tipe = "Predator") : base(_tipe, _vga, _processor, _merk)
        {

        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }
    class Lenovo : Laptop
    {
        public Lenovo(string _tipe, Vga _vga, Processor _processor, string _merk = "Lenovo") : base(_merk, _tipe, _vga, _processor)
        {

        }
    }
    class IdeaPad : Lenovo
    {
        public IdeaPad(Vga _vga, Processor _processor, string _merk = "Lenovo", string _tipe = "Ideapad") : base(_tipe, _vga, _processor, _merk)
        {

        }
    }
    class Legion : Lenovo
    {
        public Legion(Vga _vga, Processor _processor, string _merk = "Lenovo", string _tipe = "Legion") : base(_tipe, _vga, _processor, _merk)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook(new Nvidia("Nvidia"), new Corei5("Intel"));
            Laptop laptop2 = new IdeaPad(new Amd("AMD"), new Ryzen("AMD"));
            Predator predator = new Predator(new Amd("AMD"), new Corei7("Intel"));

            //No.1
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            //No.2
            //laptop1.Ngoding();

            //No.3
            Console.WriteLine($"Spesifikasi Laptop1:\nMerk VGA: {laptop1.vga.merk}\nMerk Processor: {laptop1.processor.merk}\nTipe Processor: {laptop1.processor.tipe}");

            //No.4
            predator.BermainGame();

            //No.5
            ACER acer = new Predator(new Amd("AMD"), new Corei7("Intel"));
            //acer.BermainGame();
        }
    }
}