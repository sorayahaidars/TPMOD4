using System;
public class KodePos
{
    public string GetKodePos(string kelurahan)
    {
        string[] kelurahanArray = new string[]
        {
            "Batununggal",
            "Kujangsari",
            "Mengger",
            "Wates",
            "Cijaura",
            "Jatisari",
            "Margasari",
            "Sekejati",
            "Kebonwaru",
            "Maleer",
            "Samoja"
        };

        string[] kodePosArray = new string[]
        {
            "40266",
            "40287",
            "40267",
            "40256",
            "40287",
            "40286",
            "40286",
            "40286",
            "40272",
            "40274",
            "40273"
        };

        for (int i = 0; i < kelurahanArray.Length; i++)
        {
            if (kelurahan.Equals(kelurahanArray[i]))
            {
                return kodePosArray[i];
            }
        }

        return "Kelurahan tidak ditemukan";
    }
}

public enum DoorState
{
    Locked,
    Open
}

public class DoorMachine
{
    private DoorState state = DoorState.Locked;

    public void LockDoor()
    {
        state = DoorState.Locked;
        Console.WriteLine("Pintu terkunci");
    }

    public void OpenDoor()
    {
        if (state == DoorState.Locked)
        {
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            Console.WriteLine("Pintu terkunci");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();

        Console.WriteLine("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();

        string kodePosnya = kodePos.GetKodePos(kelurahan);

        Console.WriteLine($"Kode pos untuk kelurahan {kelurahan} adalah {kodePosnya}");

        DoorMachine doorMachine = new DoorMachine();

        doorMachine.LockDoor();  
        doorMachine.OpenDoor();
    }
}


