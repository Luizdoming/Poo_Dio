using System;
public class Nokia : SmartFhone
{

    //Construtor por erança
    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }

    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando Aplicatiovo, {nome}, aguarde...");
    }
}