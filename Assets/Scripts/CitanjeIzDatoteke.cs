using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class CitanjeIzDatoteke : MonoBehaviour
{

    // Use this for initialization
    public void UcitajRazdaljine()
    {

        Debug.Log("Ucitao Sam!!");
        FileInfo theSourceFile = new FileInfo("RazdaljinaZemljaSunce2014.txt");
        StreamReader reader = theSourceFile.OpenText();

        int i=0;
        string linija;
        do
        {
            linija = reader.ReadLine();
            string[] podatak = linija.Split('-');
           /* if(Convert.ToInt32(podatak[0])==MenadzerSkripta.menadzerSkripta.Mesec)
            {
                if(Convert.ToInt32(podatak[1])==MenadzerSkripta.menadzerSkripta.Dan)
                {
                    MenadzerSkripta.menadzerSkripta.ZemljaSunce=Convert.ToInt32(podatak[2])
                }
            }*/
            MenadzerSkripta.menadzerSkripta.ZemljaSunce[i]=Convert.ToInt32(podatak[2])*100000000;
            i++;
        } while (linija != null);
        


    }
}
