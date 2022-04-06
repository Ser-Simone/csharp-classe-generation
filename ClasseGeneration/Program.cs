int postiMax = 2;
int numeroPartecipanti = 0;
string[] arrayCognomi = new string[postiMax];
int[] arrayEta = new int[postiMax];
string[] arrayNomi = new string[postiMax];
bool input = true;
// -------------------- MAIN ------------------------

Console.WriteLine("Il numero di posti disponibili in classe è " + postiMax);

while (input = true)
{
    Console.Write("Vuoi aggiungere o rimuovere un Alunno [aggiungi/rimuovi]? ");
    string risposta = Console.ReadLine();

  switch (risposta)
    {
        case "aggiungi":
            Console.WriteLine("Scrivi il nome dell'alunno: ");
            string nomiAlunni = Console.ReadLine();
            input = true;
            Console.WriteLine("Scrivi il cognome dell'alunno: ");
             string cognomiAlunno = Console.ReadLine();
            
            Console.WriteLine("Scrivi l'età dell'alunno: ");
            int etaAlunno = int.Parse(Console.ReadLine());
           
            aggiungilunno(cognomiAlunno, nomiAlunni, etaAlunno);
            break;
        case "rimuovi":
            decrementaAlunno();
            input = true;
            break;
        case "no":
            Console.WriteLine("scelta non valida");
            input = false;
            break;
        case "statistiche":

            stampaArray(arrayNomi);
            Console.WriteLine("\n");
            stampaArray(arrayCognomi);
            Console.WriteLine("\n");
            stampaArrayEta(arrayEta);
            Console.WriteLine("\n");
            calcolaEtaMediaClass(arrayEta);
            Console.WriteLine("\n");

          
           int indice = alunnoPiuGrande(arrayEta);
            Console.WriteLine( arrayNomi[indice] + arrayCognomi[indice] + "\n");

            int indicepiccolo = EtaPiuGiovane(arrayEta);
            Console.WriteLine(arrayNomi[indicepiccolo] + arrayCognomi[indicepiccolo] + "\n");
            break;
    }
    
}



//---------------- FUNZIONI -------------------------
void stampaArray(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(" ,");
            }
        }
    Console.Write("]");
}
    void stampaArrayEta(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(" ,");
            }
        }
        Console.Write("]");
}
    void aggiungilunno(string cognomeAlunno, string nomeAlunno, int etaAlunno)
    {
        if (numeroPartecipanti < postiMax)
        {

            arrayCognomi[numeroPartecipanti] = cognomeAlunno;
            arrayNomi[numeroPartecipanti] = nomeAlunno; 
            arrayEta[numeroPartecipanti] = etaAlunno;
            numeroPartecipanti++;
        }
        else
        {
            Console.WriteLine("Mi dispiace la classe è al completo");
        }
    }

    void decrementaAlunno()
    {
        if (numeroPartecipanti > 0)
        {
            numeroPartecipanti--;
            arrayCognomi[numeroPartecipanti] = "";
            arrayNomi[numeroPartecipanti] = "";
            arrayEta[numeroPartecipanti] = 0;
        }
        else
        {
            Console.WriteLine("La classe è vuota");
        }
    }

void calcolaEtaMediaClass (int[] array)
{
    int somma = 0;
    double media = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0)
        {
            somma += array[i];
        }
            
        
    }
    media = somma/arrayEta.Length;
    Console.WriteLine("la media è" +media);

}

int alunnoPiuGrande(int[] array)
{
    int j = 0;
    int etàMaggiore = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (etàMaggiore < array[i])
        {
            etàMaggiore = array[i];
            j = i;
        }
    }
    Console.Write("L'alunno piu grande della classe ha: " + etàMaggiore +"anni");
    return j;
}
int EtaPiuGiovane(int[] array)
{
    int j = 0;
    int etaMinore = 1000;
    for (int i = 0; i < array.Length; i++)
    {
        if ( array[i] < etaMinore)
        {
            etaMinore = array[i];
            j = i;
        }
    }
    Console.Write("L'alunno piu piccolo della classe ha: \n" + etaMinore + "anni \n");
    return j;
}