internal class Program
{
    private static void Main(string[] args)
    {
        //Trabalhando com lista (list)
        //Criando uma lista
        List<string> frutas = new List<string>();

        //Adicionar itens na Lista
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");

        //Imprimir os itens da Lista
        frutas.ForEach(Console.WriteLine);

        Console.WriteLine(); //pula linha em Branco

        //Imprimir elementos na indice especifica
        Console.WriteLine("Fruta na indice 2: " + frutas[2]);

        /* Inserir um elemento no indice especifico*/
        frutas.Insert(1, "Maracujá");

        Console.WriteLine();

        Console.WriteLine("Minha Lista de Frutas: ");
        foreach (string frut in frutas)
        {
            Console.WriteLine(frut);
        }
        /* Alterar um elemento no índice especifico */
        frutas[4] = "Pera";

        Console.WriteLine();

        Console.WriteLine("Minha Lista de Frutas: ");
        foreach (string frut in frutas)
        {
            Console.WriteLine(frut);
        }

        //Remove elemento da lista
        frutas.RemoveAt(3);

        //Remover elemento pelo valor do conteúdo 
        frutas.Remove("morango");

        //Imprimir a lista novamente
        Console.WriteLine();
        Console.WriteLine("Minha lista de fruta");
        foreach (string frut in frutas)
        {
            Console.WriteLine(frut);
        }
        //Apagar todos os elemtos da lista
        frutas.Clear();
    }
}