using UnityEngine;
using System.Collections;

public class KameraRotacija : MonoBehaviour
{
    public Transform TackaGledanja;
    public float Udaljenost = 3f;
    public float BrzinaRotiranja = 0.1f;
    public float MinUdaljenost = 1.1f;
        
    void Update()
    {
        transform.LookAt(TackaGledanja);
        //deklaracija i ucitavanje koordinata misa
        float inputV = Input.GetAxis("Horizontal");
        float inputH = Input.GetAxis("Vertical");

        if (Input.GetKeyDown("q"))
            Udaljenost += 0.1f;
        else if (Input.GetKeyDown("e"))
        {
            Udaljenost -= 0.1f;
            if(Udaljenost<MinUdaljenost)
            {
                Udaljenost = MinUdaljenost;
            }
        }


        transform.Translate(new Vector3(inputV,inputH,0)*BrzinaRotiranja);
        transform.position=Vector3.Normalize(transform.position)*Udaljenost;
	}


}
