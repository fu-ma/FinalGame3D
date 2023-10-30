using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class boySpriteMove : MonoBehaviour
{
    private Animator anim;
    private PlayerInputSystem inputAction_;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (inputAction_.Player.MoveLeft.IsPressed())
        {
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
            anim.Play("boyLeftAnimation");
        }
        else if(inputAction_.Player.MoveRight.IsPressed())
        {
            anim.enabled = true;
            if (inputAction_.Player.SpeedUp.IsPressed())
            {
                anim.SetFloat("Speed", 2.0f);
            }
            else
            {
                anim.SetFloat("Speed", 0.4f);
            }
            anim.Play("boyRightAnimation");
        }
        else if(inputAction_.Player.MoveDown.IsPressed())
        {
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
            anim.Play("boyFowordAnimation");
        }
        else if(inputAction_.Player.MoveUp.IsPressed())
        {
            anim.enabled = true;
            if (inputAction_.Player.SpeedUp.IsPressed())
            {
                anim.SetFloat("Speed", 2.1f);
            }
            else
            {
                anim.SetFloat("Speed", 0.5f);
            }
            anim.Play("boyDownAnimation");
        }
        else
        {
            anim.enabled = false;
        }
    }
}
