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
    private boyTeleport boyTeleport;

    public bool statueFlag;
    public bool chairFlag;
    public bool blueRoomFlag;
    public bool blueStatueFlag;
    public bool blueChairFlag;

    public int lastButtonCount;
    public bool lastButtonFlag;

    private bool firstRoomWarpFlag;
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
        boyTeleport = GameObject.Find("boyObject").GetComponent<boyTeleport>();

        statueFlag = false;
        chairFlag = false;
        blueRoomFlag = false;
        blueStatueFlag = false;
        blueChairFlag = false;
        firstRoomWarpFlag = false;

        lastButtonCount = 0;
        lastButtonFlag = false;
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

            if (collision.gameObject.tag == "1-1goDoor")
            {
                boyTeleport.SetPosition(-64, 39.5f);
            }
            if (collision.gameObject.tag == "2-1goDoor")
            {
                boyTeleport.SetPosition(83.5f, 39);
            }
            if (collision.gameObject.tag == "entrancegoDoor1")
            {
                boyTeleport.SetPosition(-17.2f, 38.85f);
            }
            if (collision.gameObject.tag == "entrancegoDoor2")
            {
                boyTeleport.SetPosition(27.1f, 38.85f);
            }

            if (collision.gameObject.tag == "1-2goDoor")
            {
                boyTeleport.SetPosition(-76.1f, 99.3f);
            }

            if (collision.gameObject.tag == "2-2goDoor")
            {
                boyTeleport.SetPosition(96.35f, 99.3f);
            }
            if (collision.gameObject.tag == "1-3goDoor")
            {
                boyTeleport.SetPosition(-76.1f, 159.3f);
            }
            if (collision.gameObject.tag == "2-3goDoor")
            {
                boyTeleport.SetPosition(96.35f, 159.3f);
            }
            if (collision.gameObject.tag == "1-1leftGoDoor")
            {
                boyTeleport.SetPosition(-76.1f, 39.3f);
            }
            if (collision.gameObject.tag == "2-1leftGoDoor")
            {
                boyTeleport.SetPosition(96.35f, 39.3f);
            }
            if (collision.gameObject.tag == "operoomGoDoor")
            {
                boyTeleport.SetPosition(-9.52f, 101.8f);
            }
            if (collision.gameObject.tag == "entrancetoOpeGoDoor")
            {
                boyTeleport.SetPosition(-9.52f, 48.7f);
            }
            if (collision.gameObject.tag == "room4goDoor")
            {
                boyTeleport.SetPosition(37, 98.8f);
            }
            if (collision.gameObject.tag == "entrancetoRoom4Door")
            {
                boyTeleport.SetPosition(19.36f, 48.51f);
            }
            if (collision.gameObject.tag == "room6goDoor")
            {
                boyTeleport.SetPosition(-6.25f, 158.93f);
            }
            if (collision.gameObject.tag == "room4toRoom6Door")
            {
                boyTeleport.SetPosition(28.85f, 113.63f);
            }
            if (collision.gameObject.tag == "room0goDoor")
            {
                boyTeleport.SetPosition(36.26f, 157.14f);
            }
            if (collision.gameObject.tag == "undergroundgoDoor")
            {
                boyTeleport.SetPosition(-9.89f, 219.28f);
            }
            if (collision.gameObject.tag == "room6toRoom0Door")
            {
                boyTeleport.SetPosition(-8.23f, 174.86f);
            }
            if (collision.gameObject.tag == "room6toUndergroundDoor")
            {
                boyTeleport.SetPosition(-13.63f, 172.86f);
            }
            if (collision.gameObject.tag == "balanceroomGoDoor")
            {
                boyTeleport.SetPosition(-70.17f, 219.09f);
            }
            if (collision.gameObject.tag == "undergroundtobalanceDoor")
            {
                boyTeleport.SetPosition(-10.08f, 232.28f);
            }
            if (collision.gameObject.tag == "soraRoomGoDoor1")
            {
                boyTeleport.SetPosition(-123.8f, 106f);
            }
            if (collision.gameObject.tag == "soraRoomGoDoor2")
            {
                boyTeleport.SetPosition(-183.98f, 106f);
            }
            if (collision.gameObject.tag == "soraRoomGoDoor3")
            {
                boyTeleport.SetPosition(-135f, 106f);
            }
            if (collision.gameObject.tag == "operoomtoEquilibriumDoor")
            {
                boyTeleport.SetPosition(-15.73f, 107.07f);
            }
            if (collision.gameObject.tag == "teacherRoomGoDoor")
            {
                boyTeleport.SetPosition(-135.62f, 36.03f);
            }
            if (collision.gameObject.tag == "classRoom1ToTeacherRoom")
            {
                boyTeleport.SetPosition(-66.21f, 52.02f);
            }
            if(collision.gameObject.tag == "roomWarp" && inputAction_.Player.Talk.triggered)
            {
                if(firstRoomWarpFlag == true)
                {
                    //ˆÚ“®ˆ—‚ð‘‚­
                    boyTeleport.SetPosition(33.12f, 219.48f);
                }
                if (firstRoomWarpFlag == false)
                {
                    textWriter.TextNum = 172;
                    firstRoomWarpFlag = true;
                }
            }
            if(collision.gameObject.tag == "lastRoomBook" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 174;
            }
            if (collision.gameObject.tag == "mainRoomWarp" && inputAction_.Player.Talk.triggered)
            {
                boyTeleport.SetPosition(5, 34.12f);
            }
            if(collision.gameObject.tag == "lamp" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 176;
            }

            if(collision.gameObject.tag == "lastButton1" && inputAction_.Player.Talk.triggered)
            {
                if(lastButtonCount != 0)
                {
                    lastButtonFlag = true;
                }
                textWriter.TextNum = 178;
            }
            if (collision.gameObject.tag == "lastButton2" && inputAction_.Player.Talk.triggered)
            {
                if (lastButtonCount != 1)
                {
                    lastButtonFlag = true;
                }
                textWriter.TextNum = 178;
            }
            if (collision.gameObject.tag == "lastButton3" && inputAction_.Player.Talk.triggered)
            {
                if (lastButtonCount != 2)
                {
                    lastButtonFlag = true;
                }
                textWriter.TextNum = 178;
            }
            if (collision.gameObject.tag == "lastButton4" && inputAction_.Player.Talk.triggered)
            {
                if (lastButtonCount != 3)
                {
                    lastButtonFlag = true;
                }
                textWriter.TextNum = 178;
            }

            if(lastButtonCount >= 4 && lastButtonFlag == false)
            {
                textWriter.TextNum = 180;
            }

            if (lastButtonCount >= 4 && lastButtonFlag == true)
            {
                textWriter.TextNum = 182;
            }

            if(collision.gameObject.tag == "goLaboDoor")
            {
                boyTeleport.SetPosition(89.72f, 235.34f);
            }
            if(collision.gameObject.tag == "goEntranceToLaboDoor")
            {
                boyTeleport.SetPosition(25.24f, 30.13f);
            }
            if (collision.gameObject.tag == "laboObject" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 184;
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
