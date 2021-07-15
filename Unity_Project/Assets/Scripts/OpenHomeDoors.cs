using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class OpenHomeDoors : MonoBehaviour
{
    bool isClosed = true;
    Vector3 from;
    Vector3 to;
    private void Start()
    {
        from = transform.rotation.eulerAngles;
        to = from + new Vector3(0, 90f, 0);
    }
    public void OpenDoors()
    {
        transform.DORotate(to, 1f).SetEase(Ease.InOutSine);
        isClosed = false;
    }

    public void CloseDoors()
    {
        transform.DORotate(from, 1f).SetEase(Ease.InOutSine);
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
