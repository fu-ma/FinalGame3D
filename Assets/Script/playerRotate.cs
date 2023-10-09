using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRotate : MonoBehaviour
{
    int leftNum = 0;
    int rightNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        
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
            leftNum = 0;
            rightNum = 0;
            transform.eulerAngles = angle;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            leftNum++;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightNum++;
        }

        if(leftNum == 2)
        {
            angle.y -= 90;
            transform.eulerAngles = angle;
            leftNum = 0;
        }
        if (rightNum == 2)
        {
            angle.y += 90;
            transform.eulerAngles = angle;
            rightNum = 0;
        }
    }
}
