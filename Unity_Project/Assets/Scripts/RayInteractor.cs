using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayInteractor : MonoBehaviour
{
    public float interactionDistance = 3f;

    Transform _selection;
    public string selectableTag;

    // Update is called once per frame
    void Update()
    {
        if (_selection != null)
        {
            _selection.GetComponent<IInteractable>()?.OnHoverExit();
            _selection = null;

        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit,interactionDistance))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                selection.GetComponent<IInteractable>()?.OnHoverEnter();
                selection.GetComponent<IInteractable>()?.OnClick();
            }
            _selection = selection;
        }
    }
}
