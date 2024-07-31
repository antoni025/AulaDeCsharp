namespace TiposDeDadosPorReferencia
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Tipo de dados por referencia
            string texto = "Essa é uma mensagem";
            Console.WriteLine(texto);

            //dados object
            object valor_inteiro = 123;
            object valor_real = 123.321;
            object valor_texto = "esse é um texto";
            object valor_caracter = 'v';
            object valor_logico = true;
        }
    }
}
