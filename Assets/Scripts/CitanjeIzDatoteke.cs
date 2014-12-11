using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class CitanjeIzDatoteke : MonoBehaviour
{

    public void UcitajRazdaljine()
    {
        if (!File.Exists(Application.dataPath + "/Podaci/RazdaljinaZemljaSunce2014.txt"))
        {
            Debug.Log("Fajl ne postoji!!");
            return;
        }
        FileInfo theSourceFile = new FileInfo(Application.dataPath + "/Podaci/RazdaljinaZemljaSunce2014.txt");
        StreamReader reader = theSourceFile.OpenText();
  
        for (int i = 0; i < 365; i++)
        {
            string[] podatak = reader.ReadLine().Split('-');
            MenadzerSkripta.menadzerSkripta.ZemljaSunce[i] = Convert.ToDouble(podatak[2]) * 100000000;
        }
        


    }
}
