using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMove : MonoBehaviour
{
    Vector3 moveVelocity;
    public Rigidbody rb;
    public BoxCollider bc;
    public Transform playerTransform;
    public float maxSpeed;
    public float power;
    public GameObject girlObject;
    public GameObject boyObject;

    public GameObject blackBoard1;
    private bool blackBoard1showFlag;

    public GameObject blackBoard2;
    private bool blackBoard2showFlag;

    public GameObject blackBoard3;
    private bool blackBoard3showFlag;

    //public Transform cameraTransform;
    private PlayerInputSystem inputAction_;
    // Start is called before the first frame update
    private publicFlag gameStop;
    private TextWriter textWriter;

    private PlayerTeleport playerTeleport;

    private Password password;
    private Password2 password2;

    private playerGetItem getItem;

    private EnemyTargetMove enemyTarget;

    private bool classroomFlag;
    private bool classroomFlag2;

    private bool desk1Flag;

    private bool enemyHitFlag;
    private bool operoomFlag;

    private bool boyFlag;
    private bool boyClassroomFlag1;
    private bool boyClassroomFlag2;
    private bool room4StoryFlag;
    private bool room6StoryFlag;
    private bool undergroundStoryFlag;
    private bool room0StoryFlag;
    private bool room0StoryFlag2;
    private bool nameFlag;
    private bool balanceroomStory;
    private bool enemyShowFlag;
    private bool room0FirstFlag;
    private bool room0backHomeFlag;

    //キラキラ
    public GameObject kirakira1;
    public GameObject kirakira2;
    public GameObject kirakira3;
    public GameObject kirakira4;
    public GameObject kirakira5;
    public GameObject kirakira6;
    public GameObject kirakira7;
    public GameObject kirakira8;
    public GameObject stage0Enemy;

    private int hitTime;

    void Start()
    {
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();
        rb = GetComponent<Rigidbody>();
        rb.mass = 10;
        rb.drag = 20;
        rb.angularDrag = 0;
        rb.constraints = RigidbodyConstraints.FreezeRotation;

        bc = GetComponent<BoxCollider>();
        bc.size = new Vector3(1, 2.36f, 1);

        playerTransform = GetComponent<Transform>();
        playerTransform.position = new Vector3(0, 1, -20);
        //cameraTransform = GetComponent<Transform>();
        Application.targetFrameRate = 60;
        Screen.SetResolution(1280, 720, FullScreenMode.FullScreenWindow, 60);
        girlObject.SetActive(true);
        boyObject.SetActive(false);

        blackBoard1.SetActive(false);
        blackBoard1showFlag = false;
        blackBoard2.SetActive(false);
        blackBoard2showFlag = false;
        blackBoard3.SetActive(false);
        blackBoard3showFlag = false;

        gameStop = GameObject.Find("GameManager").GetComponent<publicFlag>();

        textWriter = GameObject.Find("Canvas").GetComponent<TextWriter>();

        playerTeleport = GameObject.Find("player").GetComponent<PlayerTeleport>();

        password = GameObject.Find("player").GetComponent<Password>();
        password2 = GameObject.Find("player").GetComponent<Password2>();

        getItem = GameObject.Find("player").GetComponent<playerGetItem>();

        enemyTarget = GameObject.Find("room0Enemy").GetComponent<EnemyTargetMove>();

        classroomFlag = false;
        classroomFlag2 = false;

        desk1Flag = false;
        enemyHitFlag = false;
        operoomFlag = false;
        boyFlag = false;

        boyClassroomFlag1 = false;
        boyClassroomFlag2 = false;

        room4StoryFlag = false;
        room6StoryFlag = false;
        undergroundStoryFlag = false;
        room0StoryFlag = false;
        room0StoryFlag2 = false;
        nameFlag = false;
        balanceroomStory = false;
        enemyShowFlag = false;
        room0FirstFlag = false;
        room0backHomeFlag = false;

        kirakira1.SetActive(true);
        kirakira2.SetActive(true);
        kirakira3.SetActive(true);
        kirakira4.SetActive(true);
        kirakira5.SetActive(true);
        kirakira6.SetActive(true);
        kirakira7.SetActive(true);
        kirakira8.SetActive(true);
        stage0Enemy.SetActive(true);

        hitTime = 0;
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
                rb.AddForce(transform.right * ((maxSpeed - rb.velocity.x) * power), ForceMode.Force);
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
                rb.AddForce(transform.right * ((maxSpeed - rb.velocity.x) * power), ForceMode.Force);
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
                rb.AddForce(transform.forward * ((maxSpeed - rb.velocity.z) * power), ForceMode.Force);
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
                rb.AddForce(transform.forward * ((maxSpeed - rb.velocity.z) * power), ForceMode.Force);
            }
            //キャラクター切り替え
            //if(inputAction_.Player.CharacterChangeGirl.triggered)
            //{
            //    girlObject.SetActive(true);
            //    boyObject.SetActive(false);
            //}
            //if (inputAction_.Player.CharacterChangeBoy.triggered)
            //{
            //    girlObject.SetActive(false);
            //    boyObject.SetActive(true);
            //}

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
        if (inputAction_.Player.Talk.triggered && blackBoard1showFlag == true)
        {
            gameStop.stopFlag = false;
            blackBoard1.SetActive(false);
            blackBoard1showFlag = false;
        }
        if (inputAction_.Player.Talk.triggered && blackBoard2showFlag == true)
        {
            gameStop.stopFlag = false;
            if (boyFlag == false)
            {
                textWriter.TextNum = 43;
            }
            if (boyFlag == true && boyClassroomFlag2 == false)
            {
                textWriter.TextNum = 45;
                boyClassroomFlag2 = true;
            }
            blackBoard2.SetActive(false);
            blackBoard2showFlag = false;
        }
        if (inputAction_.Player.Talk.triggered && blackBoard3showFlag == true)
        {
            gameStop.stopFlag = false;
            blackBoard3.SetActive(false);
            blackBoard3showFlag = false;
        }

    }
    void OnTriggerStay(Collider collision)
    {
        if (gameStop.hitFlag == false)
        {
            if (collision.gameObject.tag == "door" && inputAction_.Player.Talk.triggered && textWriter.dollGetFlag == false)
            {
                textWriter.TextNum = 3;
            }
            if (collision.gameObject.tag == "fence" && inputAction_.Player.Talk.triggered && textWriter.dollGetFlag == true && textWriter.TextNum == 4)
            {
                textWriter.TextNum = 5;
            }
            if (collision.gameObject.tag == "door" && inputAction_.Player.Talk.triggered && textWriter.fenceStoryFlag == true)
            {
                textWriter.TextNum = 7;
            }
            if (collision.gameObject.tag == "entranceDoor" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 13;
            }
            if (collision.gameObject.tag == "1-1goDoor")
            {
                playerTeleport.SetPosition(-64, 39.5f);
                if (classroomFlag == false)
                {
                    textWriter.TextNum = 19;
                    classroomFlag = true;
                }
                if(boyFlag == true && boyClassroomFlag1 == true)
                {
                    textWriter.TextNum = 41;
                    boyClassroomFlag1 = false;
                }
            }
            if (collision.gameObject.tag == "2-1goDoor")
            {
                playerTeleport.SetPosition(83.5f, 39);
                if (classroomFlag == false)
                {
                    textWriter.TextNum = 25;
                    classroomFlag = true;
                }
                if(classroomFlag == true && enemyShowFlag == false)
                {
                    textWriter.TextNum = 26;
                    enemyShowFlag = true;
                }
                if (boyFlag == true && boyClassroomFlag1 == true)
                {
                    textWriter.TextNum = 41;
                    boyClassroomFlag1 = false;
                }

            }
            if (collision.gameObject.tag == "entrancegoDoor1")
            {
                playerTeleport.SetPosition(-17.2f, 38.85f);
            }
            if (collision.gameObject.tag == "entrancegoDoor2")
            {
                playerTeleport.SetPosition(27.1f, 38.85f);
            }
            //カギを持ってないとき
            if (collision.gameObject.tag == "operatingDoor" && inputAction_.Player.Talk.triggered && getItem.openMenu == false)
            {
                textWriter.TextNum = 15;
            }
            //持ってるとき
            if (collision.gameObject.tag == "operatingDoor" && inputAction_.Player.UseItem.triggered && getItem.openMenu == true && getItem.haveOpeKey == true)
            {
                //アイテムを使った時の処理を書いてほしい
                textWriter.TextNum = 35;
                getItem.haveOpeKey = false;
                getItem.itemPhoto1.enabled = false;
                getItem.itemPhoto2.enabled = false;
            }
            if (collision.gameObject.tag == "ironDoor" && inputAction_.Player.Talk.triggered && boyFlag == false)
            {
                textWriter.TextNum = 17;
            }
            if (collision.gameObject.tag == "ironDoor" && inputAction_.Player.Talk.triggered && boyFlag == true && getItem.openMenu == false)
            {
                textWriter.TextNum = 39;
            }
            if (collision.gameObject.tag == "ironDoor" && inputAction_.Player.UseItem.triggered && boyFlag == true && getItem.openMenu == true && getItem.haveIronKey == true)
            {
                textWriter.TextNum = 47;
                getItem.haveIronKey = false;
                getItem.itemPhoto1.enabled = false;
                getItem.itemPhoto2.enabled = false;
            }

            if (collision.gameObject.tag == "1-2goDoor")
            {
                playerTeleport.SetPosition(-76.1f, 99.3f);
                if (classroomFlag2 == false)
                {
                    textWriter.TextNum = 21;
                    classroomFlag2 = true;
                }
            }
            if (collision.gameObject.tag == "2-2goDoor")
            {
                playerTeleport.SetPosition(96.35f, 99.3f);
                if (classroomFlag2 == false)
                {
                    textWriter.TextNum = 21;
                    classroomFlag2 = true;
                }
            }
            if (collision.gameObject.tag == "1-3goDoor")
            {
                playerTeleport.SetPosition(-76.1f, 159.3f);
            }
            if (collision.gameObject.tag == "2-3goDoor")
            {
                playerTeleport.SetPosition(96.35f, 159.3f);
            }
            if (collision.gameObject.tag == "1-1leftGoDoor")
            {
                playerTeleport.SetPosition(-76.1f, 39.3f);
            }
            if (collision.gameObject.tag == "2-1leftGoDoor")
            {
                playerTeleport.SetPosition(96.35f, 39.3f);
            }

            if (collision.gameObject.tag == "1-1desk" && inputAction_.Player.Talk.triggered && desk1Flag == false)
            {
                textWriter.TextNum = 23;
                desk1Flag = true;
            }
            if (collision.gameObject.tag == "1-1blackBoard" && inputAction_.Player.Talk.triggered)
            {
                blackBoard1showFlag = true;
                gameStop.stopFlag = true;
                blackBoard1.SetActive(true);
            }
            if (collision.gameObject.tag == "1-2blackBoard" && inputAction_.Player.Talk.triggered)
            {
                blackBoard2showFlag = true;
                gameStop.stopFlag = true;
                blackBoard2.SetActive(true);
            }
            if (collision.gameObject.tag == "1-3blackBoard" && inputAction_.Player.Talk.triggered)
            {
                blackBoard3showFlag = true;
                gameStop.stopFlag = true;
                blackBoard3.SetActive(true);
            }
            if (collision.gameObject.tag == "Enemy" && enemyHitFlag == false)
            {
                textWriter.TextNum = 27;
                enemyHitFlag = true;
            }
            if (collision.gameObject.tag == "2-1blackBoard" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 29;
            }
            if (collision.gameObject.tag == "2-2blackBoard" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 31;
            }
            if (collision.gameObject.tag == "2-3blackBoard" && inputAction_.Player.Talk.triggered && password.dontObject == false)
            {
                textWriter.TextNum = 33;
            }
            if(collision.gameObject.tag == "operoomGoDoor")
            {
                playerTeleport.SetPosition(-10, 100);
                if (operoomFlag == false)
                {
                    textWriter.TextNum = 37;
                    boyFlag = true;
                    boyClassroomFlag1 = true;
                    operoomFlag = true;
                }
            }
            if (collision.gameObject.tag == "entrancetoOpeGoDoor")
            {
                playerTeleport.SetPosition(-9.52f, 48.7f);
            }

            if(collision.gameObject.tag == "room4goDoor")
            {
                playerTeleport.SetPosition(37, 96.8f);
                if (room4StoryFlag == false)
                {
                    textWriter.TextNum = 49;
                    room4StoryFlag = true;
                }
            }

            if(collision.gameObject.tag == "entrancetoRoom4Door")
            {
                playerTeleport.SetPosition(19.36f, 48.51f);
            }

            if(collision.gameObject.tag == "room6goDoor")
            {
                playerTeleport.SetPosition(-6.25f, 156.93f);
                if (room6StoryFlag == false)
                {
                    textWriter.TextNum = 51;
                    room6StoryFlag = true;
                }
            }

            if (collision.gameObject.tag == "room4toRoom6Door")
            {
                playerTeleport.SetPosition(28.85f, 115.63f);
            }

            if (collision.gameObject.tag == "room0goDoor")
            {
                if(room0StoryFlag == false)
                {
                    textWriter.TextNum = 55;
                    room0StoryFlag = true;
                }
                if(room0StoryFlag2 == true && textWriter.room0FirstFlag == true)
                {
                    playerTeleport.SetPosition(36.26f, 157.14f);
                    enemyTarget.moveFlag = true;
                }
                if (room0StoryFlag == true && nameFlag == true && room0StoryFlag2 == false)
                {
                    textWriter.TextNum = 57;
                    room0StoryFlag2 = true;

                }
            }

            if (collision.gameObject.tag == "undergroundgoDoor")
            {
                playerTeleport.SetPosition(-9.89f, 219.28f);
                if(undergroundStoryFlag == false)
                {
                    textWriter.TextNum = 53;
                    nameFlag = true;
                    undergroundStoryFlag = true;
                }
            }

            if (collision.gameObject.tag == "room6toRoom0Door")
            {
                playerTeleport.SetPosition(-6.23f, 174.86f);
                enemyTarget.moveFlag = false;
                room0FirstFlag = true;
                kirakira1.SetActive(false);
                kirakira2.SetActive(false);
                kirakira3.SetActive(false);
                kirakira4.SetActive(false);
                kirakira5.SetActive(false);
                kirakira6.SetActive(false);
                kirakira7.SetActive(false);
                kirakira8.SetActive(false);
                stage0Enemy.SetActive(false);
                if(room0backHomeFlag == false)
                {
                    textWriter.TextNum = 82;
                    room0backHomeFlag = true;
                }
            }

            if (collision.gameObject.tag == "room6toUndergroundDoor")
            {
                playerTeleport.SetPosition(-13.63f, 174.86f);
            }

            if (collision.gameObject.tag == "balanceroomGoDoor")
            {
                playerTeleport.SetPosition(-70.17f, 219.09f);
                if(balanceroomStory == false)
                {
                    textWriter.TextNum = 61;
                    balanceroomStory = true;
                }
            }

            if (collision.gameObject.tag == "undergroundtobalanceDoor")
            {
                playerTeleport.SetPosition(-10.08f, 232.28f);
            }

            if(collision.gameObject.tag == "Dial" && inputAction_.Player.Talk.triggered && password2.dontObject == false)
            {
                textWriter.TextNum = 59;
            }

            if(collision.gameObject.tag == "kirakira_miss1" && inputAction_.Player.Talk.triggered && room0FirstFlag == false)
            {
                textWriter.TextNum = 66;
            }
            if (collision.gameObject.tag == "kirakira_miss2" && inputAction_.Player.Talk.triggered && room0FirstFlag == false)
            {
                textWriter.TextNum = 68;
            }
            if (collision.gameObject.tag == "kirakira_miss3" && inputAction_.Player.Talk.triggered && room0FirstFlag == false)
            {
                textWriter.TextNum = 70;
            }
            if (collision.gameObject.tag == "kirakira_miss4" && inputAction_.Player.Talk.triggered && room0FirstFlag == false)
            {
                textWriter.TextNum = 72;
            }

            if (collision.gameObject.tag == "kirakira_hit1" && inputAction_.Player.Talk.triggered && room0FirstFlag == false)
            {
                textWriter.TextNum = 74;
            }
            if (collision.gameObject.tag == "kirakira_hit2" && inputAction_.Player.Talk.triggered && room0FirstFlag == false)
            {
                textWriter.TextNum = 76;
            }
            if (collision.gameObject.tag == "kirakira_hit3" && inputAction_.Player.Talk.triggered && room0FirstFlag == false)
            {
                textWriter.TextNum = 78;
            }
            if (collision.gameObject.tag == "kirakira_hit4" && inputAction_.Player.Talk.triggered && room0FirstFlag == false)
            {
                textWriter.TextNum = 80;
            }

            if (collision.gameObject.layer == 7 && inputAction_.Player.Talk.triggered)
            {
                gameStop.hitFlag = true;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        //if(other.gameObject.layer == 7)
        //{
        //    gameStop.hitFlag = false;
        //}
        if(other.gameObject.tag == "Enemy")
        {
            enemyHitFlag = false;
        }
    }
}
