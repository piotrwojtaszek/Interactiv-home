using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material rend;
    public Color[] colors;
    int currentId;
    public void OnClick()
    {
        currentId++;
        if (currentId >= colors.Length)
            currentId = 0;
        rend.color = colors[currentId];
    }
}
