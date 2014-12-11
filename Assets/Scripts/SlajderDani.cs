using UnityEngine;
using System.Collections;

public class SlajderDani : MonoBehaviour
{
    
   public void PromenaDana(float x)
    {
        MenadzerSkripta.menadzerSkripta.RedniBrojDana = (int)x;
        MenadzerSkripta.menadzerSkripta.Sunce.transform.rotation = Quaternion.identity;
        MenadzerSkripta.menadzerSkripta.Sunce.transform.Rotate(new Vector3(0f, (float)(-x * 0.98), 0f));
    }
}
