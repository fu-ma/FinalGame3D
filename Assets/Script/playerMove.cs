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

    private playerGetItem getItem;

    private bool classroomFlag;
    private bool classroomFlag2;

    private bool desk1Flag;

    private bool enemyHitFlag;
    private bool operoomFlag;

    private bool boyFlag;
    private bool boyClassroomFlag1;
    private bool boyClassroomFlag2;

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

        getItem = GameObject.Find("player").GetComponent<playerGetItem>();

        classroomFlag = false;
        classroomFlag2 = false;

        desk1Flag = false;
        enemyHitFlag = false;
        operoomFlag = false;
        boyFlag = false;

        boyClassroomFlag1 = false;
        boyClassroomFlag2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStop.stopFlag == false)
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
                    operoomFlag = true;
                    boyFlag = true;
                    boyClassroomFlag1 = true;
                }
            }
            if (collision.gameObject.tag == "entrancetoOpeGoDoor")
            {
                playerTeleport.SetPosition(-9.52f, 48.7f);
            }

            if (collision.gameObject.layer == 7 && inputAction_.Player.Talk.triggered)
            {
                gameStop.hitFlag = true;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.layer == 7)
        {
            gameStop.hitFlag = false;
        }
        if(other.gameObject.tag == "Enemy")
        {
            enemyHitFlag = false;
        }
    }
}
