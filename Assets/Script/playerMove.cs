using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMove : MonoBehaviour
{
    float playerMoveNum;
    private PlayerInputSystem inputAction_;
    bool hitFlag;
    // Start is called before the first frame update
    void Start()
    {
        hitFlag = false;
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            playerMoveNum = 0.00001f;
        }
        if (inputAction_.Player.MoveLeft.IsPressed())
        {
            if(playerMoveNum < 0.005f)
            {
                playerMoveNum += 0.0005f;
            }
            this.transform.position -= transform.right * playerMoveNum;
        }
        if(inputAction_.Player.MoveRight.IsPressed())
        {
            if (playerMoveNum < 0.005f)
            {
                playerMoveNum += 0.0005f;
            }
            this.transform.position += transform.right * playerMoveNum;
        }
        if(inputAction_.Player.MoveUp.IsPressed())
        {
            if (playerMoveNum < 0.005f)
            {
                playerMoveNum += 0.0005f;
            }
            this.transform.position += transform.forward * playerMoveNum;
        }
        if (inputAction_.Player.MoveDown.IsPressed())
        {
            if (playerMoveNum < 0.005f)
            {
                playerMoveNum += 0.0005f;
            }
            this.transform.position -= transform.forward * playerMoveNum;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Stage")
        {
            playerMoveNum = 0.00000f;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        
    }

}
