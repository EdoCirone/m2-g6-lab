using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Lab6_Es03 : MonoBehaviour
{

    //Creo la stringa da riempire

    public string stringapersonale = ("metti qui la tua frase");

    //Divido la stringa in intestazione e Frase 

    string dividolastringa (string stringapersonale, out string frasefinale)
    {
        if (stringapersonale.IndexOf("(") != -1 && stringapersonale.IndexOf(")") != -1)
        {
            string[] stringadivisa = stringapersonale.Split(')');

            frasefinale = stringadivisa[1] ;
            return stringadivisa[0] + ")";
        }
        else
        {
            frasefinale = stringapersonale;
            return stringapersonale;
        }
       
    }

   
    bool Controllalintestazione( string s, out string formulazione)
    {

        //Dichiaro formulzaione anche se vuota perch� � un elemento out

        formulazione = ("");



        //Controllo che la stringa abbia le parentesi 

        // if (s.IndexOf("(") == 0 && s.IndexOf(")") == s.Length - 1)

        if (s.StartsWith("(") && s.EndsWith(")"))
            {
            
                
                //Controllo che la stringa abbia i punto e virgola

                 if (s.IndexOf(";") != -1)
                {
                    
                    return true;
                }

                else
                {

                formulazione = ("La stringa deve essere scritta cos� : (Qui ; Quo; Qua), hai scordato i ;");
                return false;
                
                }

            }

            else
            {
            formulazione = ("La stringa deve essere scritta cos� : (Qui ; Quo; Qua), hai scordato le () ");
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
                //Stampo l'Array in pi� pezzi
                for (int i = 0; i < strings.Length; i++)
                {

                    Debug.Log(strings[i].Trim());

                }

                //Aggiungo la frase di Aragorn

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
            Debug.Log(formulazione);
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
