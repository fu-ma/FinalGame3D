using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    //public Image fadeIn;
    private Color fadeColor;
    private PlayerInputSystem inputAction_;
    public bool fadeFlag;

    // Start is called before the first frame update
    void Start()
    {
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();

        fadeColor = this.gameObject.GetComponent<Image>().color;
        fadeFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if(inputAction_.Player.Talk.triggered)
        //{
        //    fadeFlag = true;
        //}

        if(fadeFlag==true)
        {
            fadeColor.a -= 0.015f;
            this.gameObject.GetComponent<Image>().color = fadeColor;
            if (fadeColor.a <= 0)
            {
                fadeFlag = false;
                fadeColor.a = 1;
            }
        }

    }
}
