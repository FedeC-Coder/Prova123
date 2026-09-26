public class Program // Definizione della classe
{
    // Metodo di esecuzione dl codice (simile a java)
    public static void Main()
    {
        Console.WriteLine("Ciao utente");

        int costoSpedizione = 5;
        costoSpedizione = 10;
        int numeroPacchiComprati = 2;

        string tipoConsegna = "Standard";

        int costoTotale = numeroPacchiComprati * costoSpedizione;

        Console.WriteLine(tipoConsegna);
        Console.WriteLine(costoTotale);

    }
}   