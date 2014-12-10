using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenadzerSkripta : MonoBehaviour
{
    public static MenadzerSkripta menadzerSkripta;
    public Text LabelaDatum;
    public GameObject Sunce;
    public float brzina = 1f;
    public int Dan = 1;
    public int Mesec = 1;
    public int RedniBrojDana = 1;

    private float Brojac = 0f;
    void Start()
    {
        Dan = 1;
        Mesec = 1;
        RedniBrojDana = 1;
        menadzerSkripta = this;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Brojac=(Brojac+1)*brzina;
        if(Brojac>=35)
        {
            RedniBrojDana++;
            Brojac = 0;
            Sunce.transform.rotation = Quaternion.identity;
            Sunce.transform.Rotate(new Vector3(0f, (float)(-RedniBrojDana * 0.98), 0f));
            Converter();
            LabelaDatum.text = Dan + "." + Mesec + ".";
        }
        else
        {
            Sunce.transform.Rotate(new Vector3(0f, -0.029f, 0f));
        }
      
        
    }

    public void Converter()
    {
        if (RedniBrojDana >= 1 && RedniBrojDana <= 31)
        {
            Mesec = 1;
            Dan = RedniBrojDana;
        }

        if (RedniBrojDana >= 32 && RedniBrojDana <= 59)
        {
            Mesec = 2;
            Dan = RedniBrojDana - 31;
        }

        if (RedniBrojDana >= 60 && RedniBrojDana <= 90)
        {
            Mesec = 3;
            Dan = RedniBrojDana - 59;
        }

        if (RedniBrojDana >= 91 && RedniBrojDana <= 120)
        {
            Mesec = 4;
            Dan = RedniBrojDana - 90;
        }

        if (RedniBrojDana >= 121 && RedniBrojDana <= 151)
        {
            Mesec = 5;
            Dan = RedniBrojDana - 120;
        }

        if (RedniBrojDana >= 152 && RedniBrojDana <= 181)
        {
            Mesec = 6;
            Dan = RedniBrojDana - 151;
        }

        if (RedniBrojDana >= 182 && RedniBrojDana <= 212)
        {
            Mesec = 7;
            Dan = RedniBrojDana - 181;
        }

        if (RedniBrojDana >= 213 && RedniBrojDana <= 243)
        {
            Mesec = 8;
            Dan = RedniBrojDana - 212;
        }

        if (RedniBrojDana >= 243 && RedniBrojDana <= 272)
        {
            Mesec = 9;
            Dan = RedniBrojDana - 242;
        }

        if (RedniBrojDana >= 273 && RedniBrojDana <= 303)
        {
            Mesec = 10;
            Dan = RedniBrojDana - 272;
        }

        if (RedniBrojDana >= 304 && RedniBrojDana <= 333)
        {
            Mesec = 11;
            Dan = RedniBrojDana - 303;
        }

        if (RedniBrojDana >= 334 && RedniBrojDana <= 364)
        {
            Mesec = 12;
            Dan = RedniBrojDana - 333;
        }

    }
}
