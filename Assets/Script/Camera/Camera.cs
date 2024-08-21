using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float Sensx;
    public float Sensy;

    public Transform Orientasi;

    float xRotation;
    float yRotatiion;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * Sensx;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * Sensy;

        yRotatiion += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotatiion, 0);

        Orientasi.rotation = Quaternion.Euler(0, yRotatiion, 0);
    }
    
}
