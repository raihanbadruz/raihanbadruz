namespace TugasPBO_PR
{
}

class Ban
{
    public string merk;

    public Ban(string merk)
    {
        this.merk = merk;
    }
}

class Michelin : Ban
{
    public Michelin() : base("Michelin")
    {
    }
}

class Bridgestone : Ban
{
    public Bridgestone() : base("Bridgestone")
    {
    }
}



class Mobil
{
    public string merk;
    public string tipe;
    public Ban ban;

    public Mobil(string merk, string tipe)
    {
        this.merk = merk;
        this.tipe = tipe;
    }

    public void NyalakanMesin()
    {
        Console.WriteLine($"Mesin mobil {this.merk} bertipe {this.tipe} menyala");
    }

    public void MatikanMesin()
    {
        Console.WriteLine($"Mesin mobil {this.merk} bertipe {this.tipe} mati");
    }

}

class Honda : Mobil
{
    public Honda(string tipe) : base("Honda", tipe)
    {
    }
}

class Civic : Honda
{
    public Civic() : base("Civic")
    {
    }

    public void VtecKickedIn()
    {
        Console.WriteLine($"Ngeeeng Wooosh");
    }
}

class Brio : Honda
{
    public Brio() : base("Brio")
    {
    }
}


class Daihatsu : Mobil
{
    public Daihatsu(string tipe) : base("Daihatsu", tipe)
    {
    }
}

class Ayla : Daihatsu
{
    public Ayla() : base("Ayla")
    {
    }
}

class Xenia : Daihatsu
{
    public Xenia() : base("Xenia")
    {
    }
}

class Toyota : Mobil
{
    public Toyota(string tipe) : base("Toyota", tipe)
    {
    }
}

class Agya : Toyota
{
    public Agya() : base("Agya")
    {
    }
}

class Innova : Toyota
{
    public Innova() : base("Innova")
    {
    }
}

class Avanza : Toyota
{
    public Avanza() : base("Avanza")
    {
    }

    public void NyalakanLampu()
    {
        Console.WriteLine($"Lampu mobil {this.merk} bertipe {this.tipe} menyala");
    }

    internal class Program
    {

        private static void Main(string[] args)
        {
            Mobil mobil1 = new Agya();
            mobil1.ban = new Michelin();
            mobil1.NyalakanMesin();
            mobil1.MatikanMesin();
            Mobil mobil2 = new Avanza();
            mobil2.ban = new Bridgestone();
            //mobil2.NyalakanLampu(); //Error karena NyalakanLampu() tidak ada pada class Mobil
            Civic civic1 = new Civic();
            civic1.VtecKickedIn();
            civic1.ban = new Bridgestone();
        }
    }
}