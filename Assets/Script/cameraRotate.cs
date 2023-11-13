using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cameraRotate : MonoBehaviour
{
    int leftNum = 0;
    int rightNum = 0;
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
        Vector3 angle = this.transform.eulerAngles;
        if (Input.GetKeyDown(KeyCode.R))
        {
            angle.x = 0;
            angle.y = 0;
            angle.z = 0;
            leftNum = 0;
            rightNum = 0;
            this.transform.eulerAngles = angle;
        }
        //if (inputAction_.Player.RotateLeft.triggered)
        //{
        //    leftNum++;
        //    angle.y += 45;
        //    this.transform.eulerAngles = angle;
        //}
        //if (inputAction_.Player.RotateRight.triggered)
        //{
        //    rightNum++;
        //    angle.y -= 45;
        //    this.transform.eulerAngles = angle;
        //}

        if (leftNum == 2)
        {
            angle.y -= 90;
            this.transform.eulerAngles = angle;
            leftNum = 0;
        }
        if (rightNum == 2)
        {
            angle.y += 90;
            this.transform.eulerAngles = angle;
            rightNum = 0;
        }
    }
}
