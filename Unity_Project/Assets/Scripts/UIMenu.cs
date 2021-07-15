using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class UIMenu : MonoBehaviour
{
    public UnityAction onEnable;
    public UnityAction onDisable;
    CanvasGroup canvasGroup;
    public static UIMenu Instance;
    public float sensivity = 400f;
    public Slider slider;
    private void Awake()
    {
        Instance = this;
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;
        onDisable += () => canvasGroup.alpha = 0;
        onEnable += () => canvasGroup.alpha = 1;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvasGroup.alpha == 1)
            {
                onDisable?.Invoke();
            }
            else
            {
                onEnable?.Invoke();
            }
        }

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResumeGame()
    {
        onDisable?.Invoke();
    }

    public void ChangeSensivity()
    {
        sensivity = slider.value;
    }
}
