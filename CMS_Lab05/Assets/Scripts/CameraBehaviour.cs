using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Transform player;
    float yRotation = 0f;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * 500 * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * 500 * Time.deltaTime;
        yRotation -= mouseY;
        transform.localRotation = Quaternion.Euler(yRotation, 0f, 0f);
        yRotation = Mathf.Clamp(yRotation, -90f, 90f);
        player.Rotate(Vector3.up * mouseX);
    }
}
