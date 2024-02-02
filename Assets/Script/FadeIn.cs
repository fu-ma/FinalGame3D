using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    //public Image fadeIn;
    private Color fadeColor;
    private PlayerInputSystem inputAction_;
    public bool fadeFlag;
    public bool fadeOutFlag;
    public bool fadeInOutFlag;
    private publicFlag gameStop;
    private int fadeCount;
    private cameraEffectMove cameraeffectmove;

    // Start is called before the first frame update
    void Start()
    {
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();

        fadeColor = this.gameObject.GetComponent<Image>().color;
        fadeFlag = false;
        fadeOutFlag = false;
        fadeInOutFlag = false;

        fadeCount = 0;
        cameraeffectmove = GameObject.Find("Main Camera").GetComponent<cameraEffectMove>();
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

        if(fadeInOutFlag == true)
        {
            if(fadeCount == 0)
            {
                gameStop.notSkipFlag = true;
                fadeColor.a += 0.015f;
                if (fadeColor.a >= 1)
                {
                    fadeCount = 1;
                }
            }
            if (fadeCount == 1)
            {
                cameraeffectmove.moveFlag = true;
                fadeCount = 2;
            }
            if(fadeCount == 2)
            {
                fadeColor.a -= 0.015f;
                if (fadeColor.a <= 0)
                {
                    fadeCount = 3;
                }
            }
            if (fadeCount == 3)
            {
                fadeInOutFlag = false;
                gameStop.notSkipFlag = false;
                fadeColor.a = 0;
                fadeCount = 0;
            }
            this.gameObject.GetComponent<Image>().color = fadeColor;
        }

    }
}
