using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Lab6_Es03 : MonoBehaviour
{

    //Creo la stringa da riempire

    public string stringapersonale = ("metti qui la tua frase");
    private string formulazione = ("La stringa deve essere scritta così : (Qui ; Quo; Qua)");

    //Divido la stringa in intestazione e Frase 

    string dividolastringa (string stringapersonale, out string frasefinale)
    {
        if (stringapersonale.IndexOf("(") != -1 && stringapersonale.IndexOf(")") != -1)
        {
            // Creo un array e ci metto dentro le due stringhe
            string[] stringadivisa = stringapersonale.Split(')');

            //tiro fuori due stringhe separate

            frasefinale = stringadivisa[1] ;
            return stringadivisa[0] + ")";
        }
        else
        {
            frasefinale = stringapersonale;
            return stringapersonale;
        }
       
    }

    //Creo La funzione per gli errori (tiro fuori una booleana se ha errore o no, e il messaggio d'errore tramite variabile out string')
   
    bool Controllalintestazione( string s, out string errore)
    {

        //Controllo che la stringa abbia le parentesi 

        // if (s.IndexOf("(") == 0 && s.IndexOf(")") == s.Length - 1)


        if (s.StartsWith("(") && s.EndsWith(")"))
            {
            
                
                //Controllo che la stringa abbia i punto e virgola

                 if (s.IndexOf(";") != -1)
                {
                    errore = ("");
                    return true;
                     
                }

                else
                {

                errore = (formulazione + ": hai scordato i ;");
                return false;
                
                }

            }

            else
            {
            errore = (formulazione + ": controlla le () ");
            return false;
            }

    }

    //Creo La Funzione che stampa le stringhe
    void StampoLaStringa( bool controllostringa, string intestazione , string frasebase, string formulazione)
    {
        if (controllostringa == true)
        {

            //Elimino le parentesi per non stamparle

            string s2 = intestazione.Substring(1, intestazione.Length - 2);


            //Creo un array per dividere la stringa senza le parentesi e lo riempio con i valori fra il puntoevirgola
            string[] strings = s2.Split(';');


            if (strings.Length == 3 || strings.Length == 2)
            {
                //Stampo l'Array in più pezzi
                for (int i = 0; i < strings.Length; i++)
                {

                    Debug.Log(strings[i].Trim());

                }

                //Aggiungo la frase 

                Debug.Log(frasebase);
            }
            else
            {
                Debug.Log("deve avere due o tre elementi separati da ; hai scritto " + strings.Length + " elementi");
            }

        }


        //Ricordo la formulazione esatta 
        else
        {
           // Debug.Log(formulazione);
        }
    }



    // Start is called before the first frame update

    void Start()
    {
        //Controllo che la stringa non sia vuota

        if (!string.IsNullOrWhiteSpace(stringapersonale))
        {

            string intestazione = dividolastringa(stringapersonale, out string frasebase);

            bool miastringa = Controllalintestazione(intestazione, out string formulazione);
            
            StampoLaStringa(miastringa, intestazione, frasebase, formulazione);
        }


        else
        {
            Debug.Log("Serve una stringa da analizzare");
        }
    }
   
    


    // Update is called once per frame
    void Update()
    {
        
    }
}
