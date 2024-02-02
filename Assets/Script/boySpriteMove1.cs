using UnityEngine;

public class boySpriteMove1 : MonoBehaviour
{
    private Animator anim;
    private PlayerInputSystem inputAction_;
    private playerSpriteMove playerSprite;

    public bool moveFlag;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();

        playerSprite = GameObject.Find("playerShadow").GetComponent<playerSpriteMove>();
        moveFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerSprite.leftFlag == true && moveFlag == true)
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
            playerSprite.leftFlag = false;
        }
        else if(playerSprite.rightFlag == true && moveFlag == true)
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
            playerSprite.rightFlag = false;
        }
        else if(playerSprite.backFlag == true && moveFlag == true)
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
            playerSprite.backFlag = false;
        }
        else if(playerSprite.fowordFlag == true && moveFlag == true)
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
            playerSprite.fowordFlag = false;
        }
        else
        {
            anim.enabled = false;
        }
    }
}
