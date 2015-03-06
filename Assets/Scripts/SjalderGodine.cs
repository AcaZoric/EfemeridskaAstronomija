using UnityEngine;
using System.Collections;

public class SjalderGodine : MonoBehaviour
{

    public void PromenaDana(float x)
    {
        MenadzerPrecesija.menadzerSkripta.RedniBrojGodine = (int)x;
        MenadzerPrecesija.menadzerSkripta.Zemlja.transform.rotation = Quaternion.identity;
        MenadzerPrecesija.menadzerSkripta.Zemlja.transform.Rotate(new Vector3(0f, (float)(x * 0.013846), 0f));
    }
}
