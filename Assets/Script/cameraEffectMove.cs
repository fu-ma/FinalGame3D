using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraEffectMove : MonoBehaviour
{
    public bool moveFlag;
    // Start is called before the first frame update
    void Start()
    {
        moveFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(moveFlag == true && Camera.main.orthographic == false)
        {
            Camera.main.orthographic = true;
            Camera.main.orthographicSize = 5;
            moveFlag = false;
        }
        if(moveFlag == true && Camera.main.orthographic == true)
        {
            Camera.main.orthographic = false;
            Camera.main.fieldOfView = 60.0f;
            moveFlag = false;
        }
    }
}
