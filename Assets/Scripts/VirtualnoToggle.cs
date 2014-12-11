using UnityEngine;
using System.Collections;

public class VirtualnoToggle : MonoBehaviour
{
    public GameObject[] VirtualniObjekti;

    public void PromeniVirtualno(bool x)
    {
        int n= VirtualniObjekti.Length;
        for(int i=0;i<n;i++)
        {
            VirtualniObjekti[i].SetActive(x);
        }
    }
}
