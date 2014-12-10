using UnityEngine;
using System.Collections;

public class ObradjivanjePodataka : MonoBehaviour
{
    public float mesec;
    public float dan;
    public void converter(float redniBroj)
    {
        if (redniBroj >= 1 && redniBroj <= 31)
        {
            mesec = 1;
            dan = redniBroj;
        }

        if (redniBroj >= 32 && redniBroj <= 59)
        {
            mesec = 2;
            dan = redniBroj - 31;
        }

        if (redniBroj >= 60 && redniBroj <= 90)
        {
            mesec = 3;
            dan = redniBroj - 59;
        }

        if (redniBroj >= 91 && redniBroj <= 120)
        {
            mesec = 4;
            dan = redniBroj - 90;
        }

        if (redniBroj >= 121 && redniBroj <= 151)
        {
            mesec = 5;
            dan = redniBroj - 120;
        }

        if (redniBroj >= 152 && redniBroj <= 181)
        {
            mesec = 6;
            dan = redniBroj - 151;
        }

        if (redniBroj >= 182 && redniBroj <= 212)
        {
            mesec = 7;
            dan = redniBroj - 181;
        }

        if (redniBroj >= 213 && redniBroj <= 243)
        {
            mesec = 8;
            dan = redniBroj - 212;
        }

        if (redniBroj >= 243 && redniBroj <= 272)
        {
            mesec = 9;
            dan = redniBroj - 242;
        }

        if (redniBroj >= 273 && redniBroj <= 303)
        {
            mesec = 10;
            dan = redniBroj - 272;
        }

        if (redniBroj >= 304 && redniBroj <= 333)
        {
            mesec = 11;
            dan = redniBroj - 303;
        }

        if (redniBroj >= 334 && redniBroj <= 364)
        {
            mesec = 12;
            dan = redniBroj - 333;
        }

    }


}
