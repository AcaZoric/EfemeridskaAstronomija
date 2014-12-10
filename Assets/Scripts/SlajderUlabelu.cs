using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SlajderUlabelu : MonoBehaviour
{

    //povezuje slajdere i labele tj. menja tekst u labeli prema vrednosti slajdera
    //jos uvek u veoma eksperimentalnoj fazi
    public Slider Slajder;
    private Text vrednost;

    void Start()
    {
        vrednost = this.gameObject.GetComponent<Text>();
    }

    void Update()
    {
        vrednost.text = System.Math.Round(Slajder.value, 1).ToString();
    }

}
