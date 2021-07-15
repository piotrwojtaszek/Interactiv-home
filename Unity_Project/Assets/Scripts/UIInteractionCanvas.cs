using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIInteractionCanvas : MonoBehaviour
{
    public static UIInteractionCanvas Instance;
    public TextMeshProUGUI text;
    public CanvasGroup canvasGroup;
    public CanvasGroup aimCanvas;
    private void Awake()
    {
        Instance = this;
        canvasGroup.alpha = 0;
    }

    public void EnableCanvas(string desctiption)
    {
        text.text = desctiption;
        canvasGroup.alpha = 1;
        aimCanvas.alpha = 0;
    }

    public void DisableCanvas()
    {
        canvasGroup.alpha = 0;
        text.text = "";
        aimCanvas.alpha = 1;
    }


}
