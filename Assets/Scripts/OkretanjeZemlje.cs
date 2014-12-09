using UnityEngine;
using System.Collections;

public class OkretanjeZemlje : MonoBehaviour
{
    public float BrzinaRotacije = 10f;

	void FixedUpdate () 
    {
        transform.Rotate(new Vector3(0, -1, 0)*BrzinaRotacije);
	}
}
