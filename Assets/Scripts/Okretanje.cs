using UnityEngine;
using System.Collections;

public class Okretanje : MonoBehaviour
{
    public float BrzinaRotacije = 10f;

	void FixedUpdate () 
    {
        transform.Rotate(new Vector3(0, -1, 0) * BrzinaRotacije * MenadzerSkripta.menadzerSkripta.brzina);
	}
}
