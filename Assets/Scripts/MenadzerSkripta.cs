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
        RedniBrojDana++;
        Sunce.transform.rotation = Quaternion.identity;
        Sunce.transform.Rotate(new Vector3(0f, (float)(-RedniBrojDana * 0.98), 0f));
        LabelaDatum.text = Dan + "." + Mesec + ".";
    }
}
