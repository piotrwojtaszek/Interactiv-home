using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Tree : MonoBehaviour
{
    private int life = 5;
    public void OnClick()
    {

        transform.DOShakeScale(.25f, 3, 5, 90f);
        life -= 1;
        if (life <= 0)
            Die();
    }

    void Die()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DORotate(new Vector3(180f, 0f, 0f), 2f).SetEase(Ease.InOutSine));
        sequence.Append(transform.DOMove(new Vector3(transform.position.x,Random.Range(1f,2f),transform.position.z),1f));
        
        GetComponent<Collider>().enabled = false;
        GetComponent<IInteractable>().enabled = false;

    }
}
