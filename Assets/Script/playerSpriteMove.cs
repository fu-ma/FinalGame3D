using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerSpriteMove : MonoBehaviour
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
            //anim.SetBool("move", true);
            anim.Play("playerLeftAnimation");
        }
        else if(inputAction_.Player.MoveDown.IsPressed())
        {
            anim.enabled = true;
            //anim.SetBool("move", true);
            anim.Play("playerFowordAnimation");
        }
        else if(inputAction_.Player.MoveRight.IsPressed())
        {
            anim.enabled = true;
            anim.Play("playerRightAnimation");
        }
        else if(inputAction_.Player.MoveUp.IsPressed())
        {
            anim.enabled = true;
            anim.Play("playerDownAnimation");
        }
        else
        {
            anim.enabled = false;
        }
    }
}
