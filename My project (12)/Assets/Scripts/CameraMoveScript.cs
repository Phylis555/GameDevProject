using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveScript : MonoBehaviour
{

    public float mouseMove = 100f;
    public Transform playerBody;
    float Xrotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mousX = Input.GetAxis("Mouse X") * mouseMove * Time.deltaTime;
        float mousY = Input.GetAxis("Mouse Y") * mouseMove * Time.deltaTime;

        Xrotation -= mousY;
        Xrotation = Mathf.Clamp(Xrotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(Xrotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mousX);

    }
}
