using UnityEngine;
using System.Collections;

public class SlajderZaBrzinu : MonoBehaviour {

	public void BrzinaSimulacije(float x)
    {
        Time.timeScale = x;
    }
}
