using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boyMove : MonoBehaviour
{
    public Rigidbody boyrb;
    public Transform boyTransform;

    private PlayerInputSystem inputAction_;
    private publicFlag gameStop;
    public float maxSpeed;
    public float power;
    private playerMove playermove;

    // Start is called before the first frame update
    void Start()
    {
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();

        gameStop = GameObject.Find("GameManager").GetComponent<publicFlag>();
        playermove = GameObject.Find("player").GetComponent<playerMove>();
        boyTransform = GameObject.Find("boy").GetComponent<Transform>();

        boyrb = GetComponent<Rigidbody>();
        boyrb.mass = 10;
        boyrb.drag = 20;
        boyrb.angularDrag = 0;
        boyrb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStop.stopFlag == false && gameStop.playerDontMoveFlag == false)
        {
            if (inputAction_.Player.MoveLeft.IsPressed())
            {
                if (inputAction_.Player.SpeedUp.IsPressed())
                {
                    power = -24.0f;
                    maxSpeed = 48.0f;
                }
                else
                {
                    power = -12.0f;
                    maxSpeed = 24.0f;
                }
                if (playermove.changeCharaFlag == true)
                {
                    boyrb.AddForce(boyTransform.right * ((maxSpeed - boyrb.velocity.x) * power), ForceMode.Force);
                }
            }
            if (inputAction_.Player.MoveRight.IsPressed())
            {
                if (inputAction_.Player.SpeedUp.IsPressed())
                {
                    power = 32.0f;
                    maxSpeed = 48.0f;
                }
                else
                {
                    power = 16.0f;
                    maxSpeed = 24.0f;
                }
                if (playermove.changeCharaFlag == true)
                {
                    boyrb.AddForce(boyTransform.right * ((maxSpeed - boyrb.velocity.x) * power), ForceMode.Force);
                }
            }
            if (inputAction_.Player.MoveUp.IsPressed())
            {
                if (inputAction_.Player.SpeedUp.IsPressed())
                {
                    power = 32.0f;
                    maxSpeed = 48.0f;
                }
                else
                {
                    power = 16.0f;
                    maxSpeed = 24.0f;
                }
                if (playermove.changeCharaFlag == true)
                {
                    boyrb.AddForce(boyTransform.forward * ((maxSpeed - boyrb.velocity.z) * power), ForceMode.Force);
                }
            }
            if (inputAction_.Player.MoveDown.IsPressed())
            {
                if (inputAction_.Player.SpeedUp.IsPressed())
                {
                    power = -24.0f;
                    maxSpeed = 48.0f;
                }
                else
                {
                    power = -12.0f;
                    maxSpeed = 24.0f;
                }
                if (playermove.changeCharaFlag == true)
                {
                    boyrb.AddForce(boyTransform.forward * ((maxSpeed - boyrb.velocity.z) * power), ForceMode.Force);
                }
            }
        }
    }
}
