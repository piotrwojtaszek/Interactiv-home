using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[System.Serializable]
public class IInteraction
{
    public KeyCode interactionKey;
    public UnityEvent onClick;
    public string description;
}
