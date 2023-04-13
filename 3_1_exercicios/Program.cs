/*
crie um método genérico que receba por parâmetro dois valores: uma lista de valores,
e um valor mínimo; e que retorne a quantidade de elementos maior que o valor mínimo 
presente na lista.É importante que o método funcione para lista com valores inteiros, 
fracionários e em formato texto.
*/

//testando com lista de inteiros
var listaInt = new List<int>() { 1, 2, 3, 4, 5, 6 };
var minInteiro = 4;
var result = ContaMaiores(listaInt, minInteiro);
Console.WriteLine($"resultado na lista de inteiros: {result}");

//testando com lista de strings
var listaString = new List<String>() { "1", "2", "3", "4", "5", "6" };
var minString = "4";
result = ContaMaiores(listaString, minString);
Console.WriteLine($"resultado na lista de strings: {result}");

//testando com lista de floats
var listaFloat = new List<float>() { 1.2F, 2.4F, 3.6F, 4.8F, 5.0F, 6.2F };
var minFloat = 4F;
result = ContaMaiores(listaFloat, minFloat);
Console.WriteLine($"resultado na lista de floats: {result}");


static int ContaMaiores<T>(List<T> lista, T min)
{
    //contará a quantidade de elementos mariores que min na lista
    int count = 0;
    try
    {
        //percorrendo a lista
        foreach (var item in lista)
        {
            //como o tipo dos elementos é genérico, todos são convertidos para double para realizar a operação
            double elemento = (double)Convert.ChangeType(item, typeof(double));
            double minimo = (double)Convert.ChangeType(min, typeof(double));

            //comparando
            if (elemento > minimo)
            {
                count++;
            }
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine($"error: {ex.Message}");
    }
    return count;
}