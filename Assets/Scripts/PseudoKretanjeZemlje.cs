using UnityEngine;
using System.Collections;

public class PseudoKretanjeZemlje : MonoBehaviour 
{
    public int PocetniMesec = 1;
    public Transform[] putanja;
    public float brzina = 10f;
    public float tacnost = 15f;
    int i,n;
	
    //start funkcija se poziva samo jednom, kad se pokrene/pojavi/osposobi skripta, tu se obicno inicijalizuju podaci
    void Start()
    {
        i = PocetniMesec-1;
        n = putanja.Length;
    }

    void FixedUpdate()
    {
        if ( Vector3.Distance(transform.position, putanja[i].position)<tacnost)
        {
            if (i < n - 1) i++;
            else i = 0;//ako nije posledja tacka putanje idi na sledecu, inace pocni od pocetka
        }

        transform.Translate(Vector3.Normalize(putanja[i].position - transform.position)*brzina*MenadzerSkripta.menadzerSkripta.brzina);
    }	
}
