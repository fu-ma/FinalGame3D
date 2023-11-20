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
    public bool fadeOutFlag;
    private publicFlag gameStop;

    // Start is called before the first frame update
    void Start()
    {
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();

        fadeColor = this.gameObject.GetComponent<Image>().color;
        fadeFlag = false;
        fadeOutFlag = false;

        gameStop = GameObject.Find("GameManager").GetComponent<publicFlag>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(inputAction_.Player.Talk.triggered)
        //{
        //    fadeFlag = true;
        //}

        if(fadeFlag == true)
        {
            gameStop.notSkipFlag = true;
            fadeColor.a -= 0.015f;
            this.gameObject.GetComponent<Image>().color = fadeColor;
            if (fadeColor.a <= 0)
            {
                fadeFlag = false;
                gameStop.notSkipFlag = false;
                fadeColor.a = 0;
            }
        }

        if(fadeOutFlag == true)
        {
            gameStop.notSkipFlag = true;
            fadeColor.a += 0.015f;
            this.gameObject.GetComponent<Image>().color = fadeColor;
            if (fadeColor.a >= 1)
            {
                fadeOutFlag = false;
                gameStop.notSkipFlag = false;
                fadeColor.a = 1;
            }
        }

    }
}
