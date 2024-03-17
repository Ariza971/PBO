using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Superclass
public class Laptop
{
    public string Merek;
    public decimal Harga;

    public Laptop(string merek, decimal harga)
    {
        this.Merek = merek;
        this.Harga = harga;
    }

    public virtual void Info()
    {
        Console.WriteLine($"Laptop {Merek}, Harga: {Harga:C}");
    }
}

// Subclass level 1
public class LaptopGaming : Laptop
{
    public string GPU;

    public LaptopGaming(string merek, decimal harga, string gpu) : base(merek, harga)
    {
        this.GPU = gpu;
    }

    public override void Info()
    {
        Console.WriteLine($"Laptop Gaming {Merek}, GPU: {GPU}, Harga: {Harga:C}");
    }
}

public class LaptopCreator : Laptop
{
    public string Layar;

    public LaptopCreator(string merek, decimal harga, string layar) : base(merek, harga)
    {
        this.Layar = layar;
    }
    
    public override void Info()
    {
        Console.WriteLine($"Laptop Creator {Merek}, Layar: {Layar}, Harga: {Harga:C}");
    }
}

public class LaptopBisnis : Laptop
{
    public string Portabilitas;

    public LaptopBisnis(string merek, decimal harga, string portabilitas) : base(merek, harga)
    {
        this.Portabilitas = portabilitas;
    }

    public override void Info()
    {
        Console.WriteLine($"Laptop Bisnis {Merek}, Jumlah Karyawan: {Portabilitas}, Harga: {Harga:C}");
    }
}


// Subclass level 2 Laptop Gaming
public class HighEnd : LaptopGaming
{
    public string CoolSystem;

    public HighEnd(string merek, decimal harga, string gpu, string CoolSystem) : base(merek, harga, gpu)
    {
        this.CoolSystem = CoolSystem; 
    }

    public override void Info()
    {
        Console.WriteLine($"High-End Laptop Gaming {Merek}, GPU: {GPU}, Cooling: {CoolSystem}, Harga: {Harga:C}");
    }
}

public class MidEnd : LaptopGaming
{
    public string Processor; 

    public MidEnd(string merek, decimal harga, string gpu, string processor) : base(merek, harga, gpu)
    {
        Processor = processor;
    }

    public override void Info()
    {
        Console.WriteLine($"Budget Laptop Gaming {Merek}, GPU: {GPU}, Processor: {Processor}, Harga: {Harga:C}");
    }
}

public class Creator4K : LaptopCreator
{
    public string Resolusi;

    public Creator4K(string merek, decimal harga, string layar, string resolusi) : base(merek, harga, layar)
    {
        this.Resolusi = resolusi; 
    }

    public override void Info()
    {
        Console.WriteLine($"42 Laptop Creator {Merek}, Layar: {Layar}, Resolusi: {Resolusi}, Harga: {Harga:C}");
    }
}

public class Creator2K : LaptopCreator
{
    public string RefreshRate; 

    public Creator2K(string merek, decimal harga, string layar, string refreshRate) : base(merek, harga, layar)
    {
        this.RefreshRate = refreshRate;
    }

    public override void Info()
    {
        Console.WriteLine($"1080 Laptop Creator {Merek}, Layar: {Layar}, Refresh Rate: {RefreshRate}, Harga: {Harga:C}");
    }
}

// Subclass level 2 Laptop Bisnis
public class BisnisPremium : LaptopBisnis
{
    public string Keamanan;

    public BisnisPremium(string merek, decimal harga, string portabilitas ,string keamanan) : base(merek, harga, portabilitas)
    {
        this.Keamanan = keamanan;
    }

    public override void Info()
    {
        Console.WriteLine($"Premium Laptop Bisnis {Merek}, Fitur Keamanan: {Keamanan}, Harga: {Harga:C}");
    }
}

public class BisnisStandar : LaptopBisnis
{
    public string BatteryMode;

    public BisnisStandar(string merek, decimal harga ,string portabilitas,string BatteryMode) : base(merek, harga, portabilitas)
    {
        this.BatteryMode = BatteryMode;
    }

    public override void Info()
    {
        Console.WriteLine($"Standard Laptop Bisnis {Merek}, Mode Baterai: {BatteryMode}, Harga: {Harga:C}");
    }
}
