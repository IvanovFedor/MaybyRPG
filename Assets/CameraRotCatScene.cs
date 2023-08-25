using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotCatScene : MonoBehaviour
{
    public GameObject objCam;

    private float RotX;
    private float RotY;

    public GameObject point;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
        objCam.transform.position = point.transform.position;

        RotX += Input.GetAxis("Mouse Y");
        RotY += Input.GetAxis("Mouse X");
        
        RotX = Mathf.Clamp(RotX,-90, 90);

        objCam.transform.rotation = Quaternion.Euler(-RotX, RotY, 0);
    }
}
