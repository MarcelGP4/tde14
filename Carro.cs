using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Marshalling;

public class Carro : Veiculo , IFreavel , IAceleravel
{

    public Carro(string marca, string modelo)
    :base(marca, modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public override void Ligar()
    {
        Console.WriteLine("O carro está ligado");
    }

    public void Acelerar()
    {
        Console.WriteLine($" O carro {Marca}, {Modelo} está acelerando");
    }

    public void Frear()
    {
        Console.WriteLine($" O carro {Marca}, {Modelo} está freanfo");
    }





}