using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class OpenCarDoors : MonoBehaviour
{
    bool isClosed = true;
    public Vector3 closedRotation;
    public Vector3 openRotation;
    void OpenDoor()
    {
        transform.DORotate(openRotation, 2f).SetEase(Ease.InOutSine);
    }
    void CloseDoor()
    {
        transform.DORotate(closedRotation, 2f).SetEase(Ease.InOutSine);
    }

    public void OnClick()
    {
        if (isClosed)
        {
            OpenDoor();
        }
        else
        {
            CloseDoor();
        }
        isClosed = !isClosed;
    }
}
