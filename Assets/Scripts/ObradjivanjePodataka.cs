using UnityEngine;
using System.Collections;

public class ObradjivanjePodataka : MonoBehaviour
{
    
    public void converter(float RedniBroj)
    {
        MenadzerSkripta.menadzerSkripta.RedniBrojDana = (int)RedniBroj;
        if ((int)RedniBroj >= 1 && (int)RedniBroj <= 31)
        {
             MenadzerSkripta.menadzerSkripta.Mesec = 1;
             MenadzerSkripta.menadzerSkripta.Dan = (int)RedniBroj;
        }

        if ((int)RedniBroj >= 32 && (int)RedniBroj <= 59)
        {
             MenadzerSkripta.menadzerSkripta.Mesec = 2;
             MenadzerSkripta.menadzerSkripta.Dan = (int)RedniBroj - 31;
        }

        if ((int)RedniBroj >= 60 && (int)RedniBroj <= 90)
        {
             MenadzerSkripta.menadzerSkripta.Mesec = 3;
             MenadzerSkripta.menadzerSkripta.Dan = (int)RedniBroj - 59;
        }

        if ((int)RedniBroj >= 91 && (int)RedniBroj <= 120)
        {
             MenadzerSkripta.menadzerSkripta.Mesec = 4;
             MenadzerSkripta.menadzerSkripta.Dan = (int)RedniBroj - 90;
        }

        if ((int)RedniBroj >= 121 && (int)RedniBroj <= 151)
        {
             MenadzerSkripta.menadzerSkripta.Mesec = 5;
             MenadzerSkripta.menadzerSkripta.Dan = (int)RedniBroj - 120;
        }

        if ((int)RedniBroj >= 152 && (int)RedniBroj <= 181)
        {
             MenadzerSkripta.menadzerSkripta.Mesec = 6;
             MenadzerSkripta.menadzerSkripta.Dan = (int)RedniBroj - 151;
        }

        if ((int)RedniBroj >= 182 && (int)RedniBroj <= 212)
        {
             MenadzerSkripta.menadzerSkripta.Mesec = 7;
             MenadzerSkripta.menadzerSkripta.Dan = (int)RedniBroj - 181;
        }

        if ((int)RedniBroj >= 213 && (int)RedniBroj <= 243)
        {
             MenadzerSkripta.menadzerSkripta.Mesec = 8;
             MenadzerSkripta.menadzerSkripta.Dan = (int)RedniBroj - 212;
        }

        if ((int)RedniBroj >= 243 && (int)RedniBroj <= 272)
        {
             MenadzerSkripta.menadzerSkripta.Mesec = 9;
             MenadzerSkripta.menadzerSkripta.Dan = (int)RedniBroj - 242;
        }

        if ((int)RedniBroj >= 273 && (int)RedniBroj <= 303)
        {
             MenadzerSkripta.menadzerSkripta.Mesec = 10;
             MenadzerSkripta.menadzerSkripta.Dan = (int)RedniBroj - 272;
        }

        if ((int)RedniBroj >= 304 && (int)RedniBroj <= 333)
        {
             MenadzerSkripta.menadzerSkripta.Mesec = 11;
             MenadzerSkripta.menadzerSkripta.Dan = (int)RedniBroj - 303;
        }

        if ((int)RedniBroj >= 334 && (int)RedniBroj <= 364)
        {
             MenadzerSkripta.menadzerSkripta.Mesec = 12;
             MenadzerSkripta.menadzerSkripta.Dan = (int)RedniBroj - 333;
        }

    }


}
