/*
A questo punto volete avere delle statistiche sulla vostra classe, pertanto vi si chiede di fornire tramite 
funzioni le seguenti cose:
una funzione calcolaEtaMediaClasse che vi restituisca l'età media della classe.
una funzione EtaPiuGiovane che vi restituisce l'età dell'alunno più giovane in classe.
una funzione EtàPiuVecchio che vi restituisce l'età dell'alunno più vecchio.
Testate le vostre funzioni di statistiche, per esempio aggiungendo l'opzione "statistiche" per l'utente,
che una volta scritto a console "statistiche" vi stampi i risultati delle funzioni appena dichiarate.
 */




int postiMax = 2;
int numeroPartecipanti = 0;
string[] arrayCognomi = new string[postiMax];
int[] arrayEta = new int[postiMax];
string[] arrayNomi = new string[postiMax];
bool input;
// -------------------- MAIN ------------------------

Console.WriteLine("Il numero di posti disponibili in classe è " + postiMax);
Console.WriteLine("Nella tua classe sono presenti i seguenti alunni:");


while (true)
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
            input = false;
            break;
        
    }
    stampaArray(arrayNomi);
    stampaArray(arrayCognomi);
    stampaArrayEta(arrayEta);
    int media =calcolaEtaMediaClass(arrayEta);
    Console.WriteLine("la media della classe è:" +media);

    int alunnoGiovane = EtaPiuGiovane(arrayEta);
    Console.WriteLine("il più piccolo è:" +alunnoGiovane);
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

int calcolaEtaMediaClass (int[] array)
{
    int somma = 0;
    int media = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
            somma += array[i];
        
    }
    media = somma/arrayEta.Length;
    return media;

}

int EtaPiuGiovane (int[] array)
{
    int minore = 0;
    for (int i = 0; i < array.Length; i++)
    {

        minore = Math.Min(minore, array[i]);

    }
    return minore;
}