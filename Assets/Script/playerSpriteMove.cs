using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerSpriteMove : MonoBehaviour
{
    private Animator anim;
    private PlayerInputSystem inputAction_;
    private publicFlag gameStop;
    public bool fowordFlag;
    public bool backFlag;
    public bool leftFlag;
    public bool rightFlag;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();
        gameStop = GameObject.Find("GameManager").GetComponent<publicFlag>();
        fowordFlag = false;
        backFlag = false;
        leftFlag = false;
        rightFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStop.stopFlag == false && gameStop.playerDontMoveFlag == false)
        {
            if (inputAction_.Player.MoveLeft.IsPressed())
            {
                leftFlag = true;
                anim.enabled = true;
                if (inputAction_.Player.SpeedUp.IsPressed())
                {
                    anim.SetFloat("Speed", 2.0f);
                }
                else
                {
                    anim.SetFloat("Speed", 0.4f);
                }
                //anim.SetBool("move", true);
                anim.Play("playerLeftAnimation");
            }
            else if (inputAction_.Player.MoveRight.IsPressed())
            {
                rightFlag = true;
                anim.enabled = true;
                if (inputAction_.Player.SpeedUp.IsPressed())
                {
                    anim.SetFloat("Speed", 2.0f);
                }
                else
                {
                    anim.SetFloat("Speed", 0.4f);
                }
                anim.Play("playerRightAnimation");
            }
            else if (inputAction_.Player.MoveDown.IsPressed())
            {
                backFlag = true;
                anim.enabled = true;
                if (inputAction_.Player.SpeedUp.IsPressed())
                {
                    anim.SetFloat("Speed", 2.1f);
                }
                else
                {
                    anim.SetFloat("Speed", 0.5f);
                }
                //anim.SetBool("move", true);
                anim.Play("playerFowordAnimation");
            }
            else if (inputAction_.Player.MoveUp.IsPressed())
            {
                fowordFlag = true;
                anim.enabled = true;
                if (inputAction_.Player.SpeedUp.IsPressed())
                {
                    anim.SetFloat("Speed", 2.1f);
                }
                else
                {
                    anim.SetFloat("Speed", 0.5f);
                }
                anim.Play("playerDownAnimation");
            }
            else
            {
                anim.enabled = false;
            }
        }
        else
        {
            anim.enabled = false;
        }
    }
}
