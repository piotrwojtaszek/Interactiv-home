using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    public Transform playerBody;
    private float xRotation = 0f;
    bool isPasued;
    // Start is called before the first frame update
    void Start()
    {
        UIMenu.Instance.onDisable += () => Cursor.lockState = CursorLockMode.Locked;
        UIMenu.Instance.onEnable += () => Cursor.lockState = CursorLockMode.None;
        UIMenu.Instance.onDisable += () => Cursor.visible = false;
        UIMenu.Instance.onEnable += () => Cursor.visible = true;
        UIMenu.Instance.onDisable += () => isPasued = false;
        UIMenu.Instance.onEnable += () => isPasued = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (isPasued)
            return;
        float mouseX = Input.GetAxis("Mouse X") * UIMenu.Instance.sensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * UIMenu.Instance.sensivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
