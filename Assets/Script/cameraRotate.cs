using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotate : MonoBehaviour
{
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
            transform.eulerAngles = angle;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            angle.y -= 45;
            transform.eulerAngles = angle;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            angle.y += 45;
            transform.eulerAngles = angle;
        }
    }
}
