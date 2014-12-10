using UnityEngine;
using System.Collections;

public class SlajderDani : MonoBehaviour
{
    
   public void PromenaDana(float x)
    {
        MenadzerSkripta.menadzerSkripta.RedniBrojDana = (int)x;
    }
}
