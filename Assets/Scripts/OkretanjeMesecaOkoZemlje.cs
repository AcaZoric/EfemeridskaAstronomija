using UnityEngine;
using System.Collections;

public class OkretanjeMesecaOkoZemlje : MonoBehaviour 
{
    public float BrzinaOkretanja = 1f;
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, -1, 0)*BrzinaOkretanja);
    }
}
