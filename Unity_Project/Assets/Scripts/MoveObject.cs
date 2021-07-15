using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MoveObject : MonoBehaviour
{

    public Vector3 endPoint;
    private Vector3 originPoint;
    bool isOrigin;
    Rigidbody rigidbody;
    private void Start()
    {
        originPoint = transform.position;
        endPoint = transform.position + endPoint;
        rigidbody = GetComponent<Rigidbody>();
    }
    public void Move()
    {
        isOrigin = !isOrigin;
        if (isOrigin)
        {
            Sequence sequence = DOTween.Sequence();
            sequence.OnStart(() => rigidbody.velocity = Vector3.zero);
            sequence.Append(transform.DOMove(endPoint, 5f).SetEase(Ease.InOutSine));
            sequence.OnComplete(() => rigidbody.velocity = Vector3.zero);
        }
        else
        {
            Sequence sequence = DOTween.Sequence();
            sequence.OnStart(()=>rigidbody.velocity=Vector3.zero);
            transform.DOMove(originPoint, 5f).SetEase(Ease.InOutSine);
            sequence.OnComplete(() => rigidbody.velocity = Vector3.zero);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position + endPoint, 1f);
    }
}
