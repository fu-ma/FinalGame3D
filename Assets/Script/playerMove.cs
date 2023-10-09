using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    float playerMoveNum;
    bool hitFlag;
    // Start is called before the first frame update
    void Start()
    {
        hitFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            playerMoveNum = 0.00001f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            if(playerMoveNum < 0.005f)
            {
                playerMoveNum += 0.0005f;
            }
            this.transform.position -= transform.right * playerMoveNum;
        }
        if(Input.GetKey(KeyCode.D))
        {
            if (playerMoveNum < 0.005f)
            {
                playerMoveNum += 0.0005f;
            }
            this.transform.position += transform.right * playerMoveNum;
        }
        if(Input.GetKey(KeyCode.W))
        {
            if (playerMoveNum < 0.005f)
            {
                playerMoveNum += 0.0005f;
            }
            this.transform.position += transform.forward * playerMoveNum;
        }
        if (Input.GetKey(KeyCode.S))
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
            playerMoveNum = 0.00001f;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        
    }

}
