using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffLights : MonoBehaviour
{
    public GameObject[] lights;
    public void OnClick()
    {
        foreach (GameObject child in lights)
        {
            child.SetActive(!child.activeSelf);
        }
    }
}
