using UnityEngine;
using System.Collections;

public class Okretanje : MonoBehaviour
{
    public float BrzinaRotacije = 10f;

    private float brzina = 1f;

    void FixedUpdate()
    {
        if (MenadzerSkripta.menadzerSkripta == true)
            brzina = MenadzerSkripta.menadzerSkripta.brzina;
        transform.Rotate(new Vector3(0, -1, 0) * BrzinaRotacije * brzina);
    }
}
