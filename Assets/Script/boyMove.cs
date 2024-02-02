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

    public GameObject playerUI;
    private int hitTime;
    private CameraChange playerChange;
    private TextWriter textWriter;

    public bool statueFlag;
    public bool chairFlag;
    public bool blueRoomFlag;
    public bool blueStatueFlag;
    public bool blueChairFlag;
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

        playerUI.SetActive(false);
        hitTime = 0;
        playerChange = GameObject.Find("GameManager").GetComponent<CameraChange>();
        textWriter = GameObject.Find("Canvas").GetComponent<TextWriter>();

        statueFlag = false;
        chairFlag = false;
        blueRoomFlag = false;
        blueStatueFlag = false;
        blueChairFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(blueChairFlag && blueStatueFlag)
        {
            blueRoomFlag = true;
        }
        if (gameStop.stopFlag == false && gameStop.playerDontMoveFlag == false && playermove.changeCharaFlag == true)
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

            if (gameStop.hitFlag == true)
            {
                hitTime++;
                if (hitTime > 30)
                {
                    gameStop.hitFlag = false;
                    hitTime = 0;
                }
            }
        }
    }

    void OnTriggerStay(Collider collision)
    {
        if (gameStop.hitFlag == false && playermove.changeCharaFlag == true)
        {
            if (collision.gameObject.layer == 8)
            {
                playerUI.SetActive(true);
            }

            if (collision.gameObject.tag == "ChangeButton2" && inputAction_.Player.Talk.triggered)
            {
                playerChange.moveFlag = true;
            }

            if (blueRoomFlag == false)
            {
                if (collision.gameObject.tag == "blueRoomRoundDesk2" && inputAction_.Player.Talk.triggered && chairFlag == false)
                {
                    textWriter.TextNum = 120;
                }

                if (collision.gameObject.tag == "blueRoomBed2" && inputAction_.Player.Talk.triggered && statueFlag == false)
                {
                    textWriter.TextNum = 122;
                }

                if (collision.gameObject.tag == "blueRoomLever2" && inputAction_.Player.Talk.triggered)
                {
                    textWriter.TextNum = 124;
                }

                if (collision.gameObject.tag == "blueRoomStatue2" && inputAction_.Player.Talk.triggered && statueFlag == false)
                {
                    textWriter.TextNum = 126;
                }

                if (collision.gameObject.tag == "blueRoomChair2" && inputAction_.Player.Talk.triggered && chairFlag == false)
                {
                    textWriter.TextNum = 128;
                }

                if (collision.gameObject.tag == "blueRoomDesk2" && inputAction_.Player.Talk.triggered)
                {
                    textWriter.TextNum = 130;
                }

                if (collision.gameObject.tag == "blueRoomBookShef2" && inputAction_.Player.Talk.triggered && chairFlag == false)
                {
                    textWriter.TextNum = 132;
                }

            }
            if (collision.gameObject.layer == 8 && inputAction_.Player.Talk.triggered)
            {
                //soundMan.isCheckUp = true;
                gameStop.hitFlag = true;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            playerUI.SetActive(false);
        }
    }
}
