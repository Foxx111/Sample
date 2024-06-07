using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    private float xRotate = 0f;
    public float xSenstivity = 30f;
    private float ySenstivity = 30f;

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        xRotate -= (mouseY * Time.deltaTime) * ySenstivity;
        xRotate = Mathf.Clamp(xRotate, -80f, 80f);
        cam.transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);

        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSenstivity);
    }
}
