using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boyTarget : MonoBehaviour
{
    bool followFlag;
    public bool followFlag2;
    Transform Target;
    public float EnemySpeed;
    private PlayerInputSystem inputAction_;
    private boySpriteMove1 boySprite1;
    Vector3 vec;
    private cameraRotate cameraRot;

    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.Find("player").GetComponent<Transform>();
        followFlag = true;
        followFlag2 = true;
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();

        boySprite1 = GameObject.Find("boy").GetComponent<boySpriteMove1>();
        EnemySpeed = 0.04f;

        cameraRot = GameObject.Find("boy").GetComponent<cameraRotate>();

        vec = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(followFlag == true && followFlag2 == true)
        {
            if (inputAction_.Player.SpeedUp.IsPressed())
            {
                EnemySpeed = 0.08f;
            }
            else
            {
                EnemySpeed = 0.04f;
            }
                var speed = Vector3.zero;
            speed.z = EnemySpeed;

            transform.LookAt(Target);

            this.transform.Translate(speed);
        }
        this.transform.eulerAngles = cameraRot.angle;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            followFlag = false;
            boySprite1.moveFlag = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            followFlag = true;
            boySprite1.moveFlag = true;
        }
    }
}
