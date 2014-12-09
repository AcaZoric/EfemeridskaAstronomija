using UnityEngine;
using System.Collections;

public class PseudoKretanjeZemlje : MonoBehaviour 
{
    int x_pomeraj=-15, z_pomeraj=15;
	// Use this for initialization
	
	// Update is called once per frame
    void Update()
    {
        if(transform.position.x < -1400)
        {
            x_pomeraj = +15;
        }
        if (transform.position.x > 1400)
        {
            x_pomeraj = -15;
        }
        if(transform.position.z < -1400)
        {
            z_pomeraj = +15;
        }
        if (transform.position.z > 1400)
        {
            z_pomeraj = -15;
        }
        transform.Translate(new Vector3(x_pomeraj, 0, z_pomeraj));
    }	
}
