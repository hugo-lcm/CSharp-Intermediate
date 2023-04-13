using _3_3_exercicios;
using System.Diagnostics.Metrics;

/*
considerando a clasee:
public class Par
{
    public T Var1 { get; set; }
    public U Var2 { get; set; }

    public Par(T var1, U var2)
    {
        this.Var1 = var1;
        this.Var2 = var2;
    }

    public override String ToString()
    {
        return "(" + Var1 + ", " + Var2 + ")";
    }
}

crie dois métodos genéricos, um que itera arrays de objetos desta classe, e outro 
que troca os valores das propriedades.
 */

//testando o iterator
var array = new Par<int, string>[] {
            new Par<int, string>(1, "c#"),
            new Par<int, string>(2, "vb.net"),
            new Par<int, string>(3, "java"),
            new Par<int, string>(4, "php")

};

Iterator(array);
Console.WriteLine("\n\n");

//testando a troca de valores das propriedades
var obj = new Par<int, int>(10, 20);
Console.WriteLine($"o valor original do objeto:\n{obj}");

Swap(obj);
Console.WriteLine($"o valor trocado do objeto:\n{obj}");

//iterando o array da classe
static void Iterator<T, U>(Par<T, U>[] array)
{
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }
}

//trocando os valores das propriedades
//para nao dar erro, obriga o objeto a ter as duas propriedades ao mesmo tempo
static void Swap<T>(Par<T, T> obj)
{
    T aux;
    aux = obj.Var1;
    obj.Var1 = obj.Var2;
    obj.Var2 = aux;
}
