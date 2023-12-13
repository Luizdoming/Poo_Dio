using System;
using System.Reflection.Emit;
public abstract class SmartFhone
{
    //Criando as propriedades
    public string Numero { get; set; }
    private string Modelo { get; set; }
    private string IMEI { get; set; }
    private int Memoria { get; set; }


    //Construtor padrão
    public SmartFhone() { }

    //Criando Construtor para erança
    public SmartFhone(string numero, string modelo, string imei, int memoria)
    {
        this.Numero = numero;
        this.Modelo = modelo;
        this.IMEI = imei;
        this.Memoria = memoria;
    }


    public void Ligar()
    {
        Console.WriteLine("Realizando Chamada...");
    }


    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo Ligação...");
    }

    //Metodo Abstrato
    public abstract void InstalarAplicativo(string nome);

}
