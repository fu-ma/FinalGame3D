using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cameraRotate : MonoBehaviour
{
    int leftNum = 0;
    int rightNum = 0;
    private PlayerInputSystem inputAction_;
    private Transform playerTransform;
    private Transform cameraTransform;
    private Transform boyTransform;
    public bool moveFlag;
    public Vector3 angle;
    // Start is called before the first frame update
    void Start()
    {
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();
        moveFlag = false;
        cameraTransform = GameObject.Find("CameraPos").GetComponent<Transform>();
        playerTransform = GameObject.Find("playerShadow").GetComponent<Transform>();
        boyTransform = GameObject.Find("boyObject").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if(moveFlag== false)
        {
            angle = playerTransform.eulerAngles;
        }
        if (moveFlag == true)
        {
            angle.y --;
            if(angle.y <= -90)
            {
                moveFlag = false;
                angle.y = -90;
            }
            playerTransform.eulerAngles = angle;
            cameraTransform.eulerAngles = angle;
            boyTransform.eulerAngles = angle;
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

        //if (leftNum == 2)
        //{
        //    angle.y -= 90;
        //    this.transform.eulerAngles = angle;
        //    leftNum = 0;
        //}
        //if (rightNum == 2)
        //{
        //    angle.y += 90;
        //    this.transform.eulerAngles = angle;
        //    rightNum = 0;
        //}
    }
}
