using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cameraRotate : MonoBehaviour
{
    private PlayerInputSystem inputAction_;
    // Start is called before the first frame update
    void Start()
    {
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 angle = transform.eulerAngles;
        if (Input.GetKeyDown(KeyCode.R))
        {
            angle.x = 0;
            angle.y = 0;
            angle.z = 0;
            transform.eulerAngles = angle;
        }
        if (inputAction_.Player.RotateLeft.triggered)
        {
            angle.y -= 45;
            transform.eulerAngles = angle;
        }
        if (inputAction_.Player.RotateRight.triggered)
        {
            angle.y += 45;
            transform.eulerAngles = angle;
        }
    }
}
