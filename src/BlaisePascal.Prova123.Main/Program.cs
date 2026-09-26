public class Program // Definizione della classe
{
    // Metodo di esecuzione dl codice (simile a java)
    public static void Main()
    {
        Console.WriteLine("Inserisci il nome del cliente");
        string nomeCliente = Console.ReadLine();
        Console.WriteLine($"Ciao {nomeCliente}");
 
        Console.WriteLine("Inserisci la consegna");
        string tipoConsegna = Console.ReadLine();

        Console.WriteLine("Inserisci il pacchi acquistati");
        int numeroPacchiComprati = int.Parse(Console.ReadLine());

        int costoSpedizione = 5;
        costoSpedizione = 10;

        int costoTotale = numeroPacchiComprati * costoSpedizione;

        Console.WriteLine($"Tipo di consegna: {tipoConsegna}.\nCosto totale: {costoTotale}.");

    }
}   