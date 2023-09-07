//La operacion completa incluye crear un origen de datos, definir la expresion de consulta
//y ejecutar la consulta en una instruccion foreach
class where_ejercicio2
{
    static void Main()
    {
        int[] scores = { 90, 71, 82, 93, 75, 82 };
        var consultas_De_Numeros =
            from numero in scores
            where numero > 80
            orderby numero descending
            select numero;

       
        foreach (var num2 in consultas_De_Numeros)  
        {
           

            Console.WriteLine("Su resultado es:" + num2.ToString());
        }
    }
}
// Josue Bryan Hernandez Zelaya