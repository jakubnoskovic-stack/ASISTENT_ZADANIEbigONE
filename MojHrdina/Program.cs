using System;

namespace MojHrdina;

class Hrdina
{
    public string meno;
    public int zdravie = 100;
    public int energia = 50;

    public Boolean Utok(int cena_energie)
    {
        if (cena_energie <= energia)
        {
            energia = energia - cena_energie;
            return true;
        }
        return false;
    }

    public int PrijmiZranenie(int sila)
    {
        if (sila > zdravie)
        {
            zdravie = 0;
            return zdravie;
        }
        else
        {
            zdravie = zdravie - sila;
            return zdravie;
        }
    }

    public int RegenerujEnergiu()
    {
        energia = energia + 5;
        return energia;
    }
    
    public void VypisAktualnyStav()
    {
        Console.WriteLine("Meno: " + meno);
        Console.WriteLine("Zdravie: " + zdravie);
        Console.WriteLine("Energia: " + energia);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hrdina PrvyHrdina = new Hrdina();
        PrvyHrdina.meno = "VajcoPleska";

        Hrdina DruhýHrdina = new Hrdina();
        DruhýHrdina.meno = "Kolobrnda";
        Random GeneratorSiliUtoku = new Random();

        while (PrvyHrdina.zdravie > 0 && DruhýHrdina.zdravie > 0)
        {
            PrvyHrdina.RegenerujEnergiu();
            DruhýHrdina.RegenerujEnergiu();
            
            int silaUtoku1 = GeneratorSiliUtoku.Next(10,30);
            int silaUtoku2 = GeneratorSiliUtoku.Next(10,30);
            
            Boolean MaPrvyHrdinaNaUtok = PrvyHrdina.Utok(silaUtoku1);
            if (MaPrvyHrdinaNaUtok)
            {
                DruhýHrdina.PrijmiZranenie(silaUtoku1);
                Console.WriteLine($"{PrvyHrdina.meno} zaútočil");
            }
            else
            {
                Console.WriteLine($"{PrvyHrdina.meno} si musí odýchnuť");
            }

            if (DruhýHrdina.zdravie == 0) break;

            Boolean MaDruhyHrdinaNaUtok = DruhýHrdina.Utok(silaUtoku2);
            if (MaDruhyHrdinaNaUtok)
            {
                PrvyHrdina.PrijmiZranenie(silaUtoku2);
                Console.WriteLine($"{DruhýHrdina.meno} zaútočil");
            }
            else
            {
                Console.WriteLine($"{DruhýHrdina.meno} si musí odýchnuť");
            }
        }
        
        Console.WriteLine("--- KONIEC BOJA ---");
        PrvyHrdina.VypisAktualnyStav();
        DruhýHrdina.VypisAktualnyStav();
    }
}