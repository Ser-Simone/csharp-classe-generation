/*
  In particolare voi volete tenere traccia dei:
nomi
cognomi
eta
numero di partecipanti attuali nel corso dei vostri alunni.
La classe all'inizio sarà vuota, ma sapete che avrete al massimo 10 sedie, ossia 10 posti nell'aula, pertanto come
ragionato questa mattina pensate bene all'inizializzazione delle vostre variabili globali.

stampaCognomeAlunni: vi permette di stampare tutti i cognomi dei vostri alunni
stampaNomiAlunni: vi permette di stampare i nomi dei vostri alunni
stampaEtaAlunni: vi permette di stampare l'età dei vostri alunni (riciclate stampaArray() 
:faccia_leggermente_sorridente: ).
aggiungiAlunno: che vi permette di aggiungere un alunno alla vostra classe (nome, cognome ed età);
rimuoviUltimoAlunno: che vi "toglie" l'ultimo alunno della classe, ossia "sbianca" gli array nell'ultimo posto 
occupato.
Definite queste funzioni di base, usatele per compilare la vostra ipotetica classe di alunni, provando ad aggiungere 
e rimuovere alunni al bisogno e stampando di volta in volta i risultati delle vostre operazioni sulla classe. 
Chiedete all'utente come fatto questa mattina per la rimessa auto, se vuole aggiungere o rimuovere un alunno dalla
classe e mostrategli ciò che succede.
A questo punto volete avere delle statistiche sulla vostra classe, pertanto vi si chiede di fornire tramite 
funzioni le seguenti cose:
una funzione calcolaEtaMediaClasse che vi restituisca l'età media della classe.
una funzione EtaPiuGiovane che vi restituisce l'età dell'alunno più giovane in classe.
una funzione EtàPiuVecchio che vi restituisce l'età dell'alunno più vecchio.
Testate le vostre funzioni di statistiche, per esempio aggiungendo l'opzione "statistiche" per l'utente,
che una volta scritto a console "statistiche" vi stampi i risultati delle funzioni appena dichiarate.
 */


int postiMax = 10;
int numeroPartecipanti = 0;
string[] cognomi = new string[numeroPartecipanti];
int[] eta;
string[] nomi = new string[numeroPartecipanti];

// -------------------- MAIN ------------------------
Console.WriteLine("Inserisci il Cognome dell'alunno");
cognomi[numeroPartecipanti] = Console.ReadLine();
stampaArray(cognomi);
stampaArray(nomi);

//---------------- FUNZIONI -------------------------
void stampaArray (string[] array)
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
}

void aggiungilunno(string cognomeAlunno, string nomeAlunno, int etaAlunno )
{
    if (numeroPartecipanti < postiMax)
    {

        cognomi[numeroPartecipanti] = cognomeAlunno;
        nomi[numeroPartecipanti] = nomeAlunno;
        eta[numeroPartecipanti] = etaAlunno;
        numeroPartecipanti++;

    }
    else
    {
        Console.WriteLine("Mi dispiace la classe è al completo");
    }
}