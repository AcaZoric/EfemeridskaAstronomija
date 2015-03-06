using UnityEngine;
using System.Collections;

public class SlajderZaBrzinuPrecesije : MonoBehaviour
{
    public void BrzinaSimulacije(float x)
    {
        MenadzerPrecesija.menadzerSkripta.brzina = x;
        MenadzerPrecesija.menadzerSkripta.LabelaBrzina.text = x + "";
    }
}
