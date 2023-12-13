using System;
public class Iphone : SmartFhone
{

    //Construtor por erança
    public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }

    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando Aplicativo, {nome}, aguarde...");
    }
}