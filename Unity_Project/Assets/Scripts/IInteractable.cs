using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using EPOOutline;
public class IInteractable : MonoBehaviour
{
    public Collider interactionCollider;
    public List<IInteraction> interactions;
    private string description;
    Outlinable outlinable;
    private void Start()
    {
        foreach (IInteraction element in interactions)
        {
            description += element.description + "<br>";
        }
        outlinable = GetComponent<Outlinable>();
        outlinable.enabled = false;
    }
    public void OnHoverEnter()
    {
        UIInteractionCanvas.Instance.EnableCanvas(description);
        outlinable.enabled = true;
    }

    public void OnHoverExit()
    {
        UIInteractionCanvas.Instance.DisableCanvas();
        outlinable.enabled = false;
    }

    public virtual void OnClick()
    {
        foreach (IInteraction element in interactions)
        {
            if (Input.GetKeyDown(element.interactionKey))
            {
                element.onClick?.Invoke();
            }
        }
    }
}
