using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DorOpener : MonoBehaviour
{
    public Transform[] doors;


    bool isClosed = true;

    public void OpenDoors()
    {
        foreach (Transform childs in doors)
        {
            childs.DORotate(new Vector3(-90f, 0f, 0f), 3f).SetEase(Ease.InOutSine);
        }
        isClosed = false;
    }

    public void CloseDoors()
    {
        foreach (Transform childs in doors)
        {
            childs.DORotate(new Vector3(0f, 0f, 0f), 3f).SetEase(Ease.InOutSine);
        }
        isClosed = true;
    }
    public void OnClick()
    {
        if (isClosed)
        {
            OpenDoors();
        }
        else
        {
            CloseDoors();
        }
    }
}
