/*
declare um delegate genérico que não retornará nenhum valor, mas receberá um parâmetro 
do tipo T. Em seguida declare um método genérico que receberá por parâmetro o delegate 
e um array de T. Dentro do método aplique a função vinculada no delegate a todos os 
elementos do array. 
*/
class Program
{
    delegate void Acao<T>(T[] array);
    static void Main(string[] args)
    {
        var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //mostrando o array original
        Console.WriteLine("array original:");
        foreach (var item in array)
        {
            Console.WriteLine($"{item}, ");
        }

        //aplicando o delegate
        var del = new Acao<int>(DuplicandoElementos);
        del(array);
        Console.WriteLine("\n\n");

        //mostrando o array transformado pelo delegate
        Console.WriteLine("lista após o delegate:");
        foreach (var item in array)
        {
            Console.WriteLine($"{item}, ");
        }
    }

    static void DuplicandoElementos(int[] array)
    {
        //duplicando os elementos do array
        for (int i = 0; i < array.Count(); i++)
        {
            array[i] *= 2;
        }
    }
}
