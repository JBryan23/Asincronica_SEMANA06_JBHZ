//La operacion completa incluye crear un origen de datos, definir la expresion de consulta
//y ejecutar la consulta en una instruccion foreach

class where_ejercicio1
{
    static void Main()
    {
        int[] scores = { 97, 92, 81, 60 };
        var consultas_De_Numeros =
            from numero in scores
            where numero > 80
            select numero;
       
        foreach (var num in consultas_De_Numeros)
        {   
            Console.WriteLine("Su resultado es:" + num.ToString());
        }
    }
}
// Josue Bryan Hernandez Zelaya