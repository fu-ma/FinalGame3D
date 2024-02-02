using UnityEngine;

public class playerMove : MonoBehaviour
{
    Vector3 moveVelocity;
    public Rigidbody rb;
    public Rigidbody operoomRb;
    public Transform playerTransform;
    public float maxSpeed;
    public float power;
    public GameObject girlObject;
    public GameObject boyObject;
    public bool changeCharaFlag;

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
    private boyTeleport boyTeleport;
    private boyTarget boyTarget;

    private Password password;
    private Password2 password2;

    private playerGetItem getItem;

    private EnemyTargetMove enemyTarget;

    private SoundManager soundMan;

    private Enemymove1 enemyMove1;
    private Enemymove2 enemyMove2;

    private Transform girlTransform;

    private CameraChange playerChange;

    private bool classroomFlag;
    private bool classroomFlag2;

    private bool desk1Flag;

    private bool enemyHitFlag;
    private bool operoomFlag;

    public bool boyFlag;
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
    private bool blueButtonRoomFlag;
    private bool firstWhiteMistFlag;
    private bool firstTeacherRoomFlag;
    private bool firstTeacherDeskFlag;

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

    public GameObject GameOverObj;

    //UI
    public GameObject playerUI;

    private int hitTime;
    private bool GameOverFlag;
    public int blueRoomBedCount;
    public bool blueRoomFlag;
    public bool classRoom1StoryFlag;

    void Start()
    {
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();
        rb = GetComponent<Rigidbody>();
        rb.mass = 10;
        rb.drag = 20;
        rb.angularDrag = 0;
        rb.useGravity = true;
        rb.constraints = RigidbodyConstraints.FreezeRotation;

        operoomRb = GameObject.Find("ading platformrm").GetComponent<Rigidbody>();
        operoomRb.isKinematic = true;

        playerTransform = GetComponent<Transform>();
        playerTransform.position = new Vector3(0, 1, -20);
        //cameraTransform = GetComponent<Transform>();
        Application.targetFrameRate = 60;
        Screen.SetResolution(1280, 720, FullScreenMode.FullScreenWindow, 60);
        girlObject.SetActive(true);
        boyObject.SetActive(true);

        blackBoard1.SetActive(false);
        blackBoard1showFlag = false;
        blackBoard2.SetActive(false);
        blackBoard2showFlag = false;
        blackBoard3.SetActive(false);
        blackBoard3showFlag = false;

        gameStop = GameObject.Find("GameManager").GetComponent<publicFlag>();

        textWriter = GameObject.Find("Canvas").GetComponent<TextWriter>();

        playerTeleport = GameObject.Find("player").GetComponent<PlayerTeleport>();
        boyTeleport = GameObject.Find("boyObject").GetComponent<boyTeleport>();
        boyTarget = GameObject.Find("boyObject").GetComponent<boyTarget>();

        password = GameObject.Find("player").GetComponent<Password>();
        password2 = GameObject.Find("player").GetComponent<Password2>();

        getItem = GameObject.Find("player").GetComponent<playerGetItem>();

        enemyTarget = GameObject.Find("room0Enemy").GetComponent<EnemyTargetMove>();

        soundMan = GameObject.Find("Canvas").GetComponent<SoundManager>();

        enemyMove1 = GameObject.FindGameObjectWithTag("Enemy1").GetComponent<Enemymove1>();
        enemyMove2 = GameObject.FindGameObjectWithTag("Enemy2").GetComponent<Enemymove2>();

        girlTransform = GameObject.Find("playerShadow").GetComponent<Transform>();

        playerChange = GameObject.Find("GameManager").GetComponent<CameraChange>();

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
        blueButtonRoomFlag = false;
        firstWhiteMistFlag = false;
        firstTeacherRoomFlag = false;
        firstTeacherDeskFlag = false;

        kirakira1.SetActive(true);
        kirakira2.SetActive(true);
        kirakira3.SetActive(true);
        kirakira4.SetActive(true);
        kirakira5.SetActive(true);
        kirakira6.SetActive(true);
        kirakira7.SetActive(true);
        kirakira8.SetActive(true);
        stage0Enemy.SetActive(true);
        GameOverObj.SetActive(false);

        playerUI.SetActive(false);
        hitTime = 0;
        GameOverFlag = false;
        changeCharaFlag = false;
        blueRoomBedCount = 0;
        blueRoomFlag = false;
        classRoom1StoryFlag = false;
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
                if (changeCharaFlag == false)
                {
                    rb.AddForce(girlTransform.right * ((maxSpeed - rb.velocity.x) * power), ForceMode.Force);
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
                if (changeCharaFlag == false)
                {
                    rb.AddForce(girlTransform.right * ((maxSpeed - rb.velocity.x) * power), ForceMode.Force);
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
                if (changeCharaFlag == false)
                {
                    rb.AddForce(girlTransform.forward * ((maxSpeed - rb.velocity.z) * power), ForceMode.Force);
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
                if (changeCharaFlag == false)
                {
                    rb.AddForce(girlTransform.forward * ((maxSpeed - rb.velocity.z) * power), ForceMode.Force);
                }
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
        if(GameOverFlag == true)
        {
            GameOverObj.SetActive(true);
            if(inputAction_.Player.Talk.triggered)
            {
                enemyTarget.StoryFlag = false;
                enemyTarget.moveFlag = false;
                enemyTarget.FirstFlag = false;
                playerTeleport.SetPosition(36.26f, 157.14f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(38.26f, 157.14f);
                }
                enemyTarget.moveFlag = false;
                kirakira1.SetActive(true);
                kirakira2.SetActive(true);
                kirakira3.SetActive(true);
                kirakira4.SetActive(true);
                kirakira5.SetActive(true);
                kirakira6.SetActive(true);
                kirakira7.SetActive(true);
                kirakira8.SetActive(true);
                stage0Enemy.SetActive(true);
                textWriter.TextNum = 63;
                GameOverObj.SetActive(false);
                GameOverFlag = false;
            }
        }
    }
    void OnTriggerStay(Collider collision)
    {
        if (gameStop.hitFlag == false && changeCharaFlag == false)
        {
            if(collision.gameObject.layer == 7 && collision.gameObject.tag != "door" && collision.gameObject.tag != "fence")
            {
                playerUI.SetActive(true);
            }
            if (collision.gameObject.tag == "door" && textWriter.dollGetFlag == false)
            {
                playerUI.SetActive(true);
            }
            if (collision.gameObject.tag == "fence" && textWriter.dollGetFlag == true && textWriter.TextNum == 4)
            {
                playerUI.SetActive(true);
            }
            if (collision.gameObject.tag == "door" && textWriter.fenceStoryFlag == true)
            {
                playerUI.SetActive(true);
            }

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
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(-62, 39.5f);
                }
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
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(85.5f, 39);
                }
                enemyMove1.counter = 0;
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
                if(classRoom1StoryFlag == true)
                {
                    textWriter.TextNum = 146;
                    classRoom1StoryFlag = false;
                }

            }
            if (collision.gameObject.tag == "entrancegoDoor1")
            {
                playerTeleport.SetPosition(-17.2f, 38.85f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(-17.2f, 36.85f);
                }
            }
            if (collision.gameObject.tag == "entrancegoDoor2")
            {
                playerTeleport.SetPosition(27.1f, 38.85f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(29.1f, 38.85f);
                }
            }
            //カギを持ってないとき
            if (collision.gameObject.tag == "operatingDoor" && inputAction_.Player.Talk.triggered && getItem.openMenu == false)
            {
                textWriter.TextNum = 15;
            }
            if (collision.gameObject.tag == "ironDoor" && inputAction_.Player.Talk.triggered && boyFlag == false)
            {
                textWriter.TextNum = 17;
            }
            if (collision.gameObject.tag == "ironDoor" && inputAction_.Player.Talk.triggered && boyFlag == true && getItem.openMenu == false)
            {
                textWriter.TextNum = 39;
            }

            if (collision.gameObject.tag == "1-2goDoor")
            {
                playerTeleport.SetPosition(-76.1f, 99.3f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(-74.1f, 99.3f);
                }
                if (classroomFlag2 == false)
                {
                    textWriter.TextNum = 21;
                    classroomFlag2 = true;
                }
            }
            if (collision.gameObject.tag == "2-2goDoor")
            {
                playerTeleport.SetPosition(96.35f, 99.3f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(98.35f, 99.3f);
                }
                enemyMove2.counter = 0;
                if (classroomFlag2 == false)
                {
                    textWriter.TextNum = 21;
                    classroomFlag2 = true;
                }
            }
            if (collision.gameObject.tag == "1-3goDoor")
            {
                playerTeleport.SetPosition(-76.1f, 159.3f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(-74.1f, 159.3f);
                }
            }
            if (collision.gameObject.tag == "2-3goDoor")
            {
                playerTeleport.SetPosition(96.35f, 159.3f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(98.35f, 159.3f);
                }
            }
            if (collision.gameObject.tag == "1-1leftGoDoor")
            {
                playerTeleport.SetPosition(-76.1f, 39.3f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(-74.1f, 39.3f);
                }
            }
            if (collision.gameObject.tag == "2-1leftGoDoor")
            {
                enemyMove1.counter = 0;
                playerTeleport.SetPosition(96.35f, 39.3f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(98.35f, 39.3f);
                }
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
            if ((collision.gameObject.tag == "Enemy1" || collision.gameObject.tag == "Enemy2") && enemyHitFlag == false)
            {
                textWriter.TextNum = 27;
                if(collision.gameObject.tag == "Enemy1")
                {
                    playerTeleport.SetPosition(83.5f, 39);
                    if (boyTarget.followFlag2 == true)
                    {
                        boyTeleport.SetPosition(85.5f, 39);
                    }
                    enemyMove1.counter = 0;
                }
                if (collision.gameObject.tag == "Enemy2")
                {
                    playerTeleport.SetPosition(96.35f, 99.3f);
                    if (boyTarget.followFlag2 == true)
                    {
                        boyTeleport.SetPosition(98.35f, 99.3f);
                    }
                    enemyMove2.counter = 0;
                }
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
                playerTeleport.SetPosition(-9.52f, 101.8f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(-8, 100);
                }
                if (operoomFlag == false)
                {
                    textWriter.TextNum = 37;
                    boyClassroomFlag1 = true;
                    operoomFlag = true;
                }
                if(textWriter.operoom45Flag == true)
                {
                    textWriter.TextNum = 86;
                    textWriter.operoom45Flag = false;
                }
            }
            if (collision.gameObject.tag == "entrancetoOpeGoDoor")
            {
                playerTeleport.SetPosition(-9.52f, 48.7f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(-7.52f, 48.7f);
                }
            }

            if (collision.gameObject.tag == "room4goDoor")
            {
                playerTeleport.SetPosition(37, 98.8f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(37, 96.8f);
                }
                if (room4StoryFlag == false)
                {
                    textWriter.TextNum = 49;
                    room4StoryFlag = true;
                }
            }

            if(collision.gameObject.tag == "entrancetoRoom4Door")
            {
                playerTeleport.SetPosition(19.36f, 48.51f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(21.36f, 48.51f);
                }
            }

            if (collision.gameObject.tag == "room6goDoor")
            {
                playerTeleport.SetPosition(-6.25f, 158.93f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(-6.25f, 156.93f);
                }
                if (room6StoryFlag == false)
                {
                    textWriter.TextNum = 51;
                    room6StoryFlag = true;
                }
            }

            if (collision.gameObject.tag == "room4toRoom6Door")
            {
                playerTeleport.SetPosition(28.85f, 113.63f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(28.85f, 115.63f);
                }
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
                    if (boyTarget.followFlag2 == true)
                    {
                        boyTeleport.SetPosition(36.26f, 155.14f);
                    }
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
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(-7.89f, 219.28f);
                }
                if (undergroundStoryFlag == false)
                {
                    textWriter.TextNum = 53;
                    nameFlag = true;
                    undergroundStoryFlag = true;
                }
            }

            if (collision.gameObject.tag == "room6toRoom0Door")
            {
                playerTeleport.SetPosition(-8.23f, 174.86f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(-6.23f, 174.86f);
                }
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
                playerTeleport.SetPosition(-13.63f, 172.86f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(-13.63f, 174.86f);
                }
            }

            if (collision.gameObject.tag == "balanceroomGoDoor")
            {
                playerTeleport.SetPosition(-70.17f, 219.09f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(-68.17f, 219.09f);
                }
                if (balanceroomStory == false)
                {
                    textWriter.TextNum = 61;
                    balanceroomStory = true;
                }
            }

            if (collision.gameObject.tag == "undergroundtobalanceDoor")
            {
                playerTeleport.SetPosition(-10.08f, 232.28f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(-8.08f, 232.28f);
                }
                if(textWriter.underground45Flag == true)
                {
                    textWriter.TextNum = 84;
                    operoomRb.isKinematic = false;
                    textWriter.underground45Flag = false;
                }
            }

            if(collision.gameObject.tag == "equilibriumGoDoor" && inputAction_.Player.Talk.triggered)
            {
                if (textWriter.equilibriumGoDoorFlag == true)
                {
                    playerTeleport.SetPosition(-123.8f, 106f);
                    if (boyTarget.followFlag2 == true)
                    {
                        boyTeleport.SetPosition(-121.8f, 106f);
                    }
                }
                if(textWriter.equilibriumGoDoorFlag == false)
                {
                    textWriter.TextNum = 90;
                    textWriter.equilibriumGoDoorFlag = true;
                }
            }

            if (collision.gameObject.tag == "equilibriumGoDoor2")
            {
                playerTeleport.SetPosition(-123.8f, 106f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(-121.8f, 106f);
                }
            }

            if(collision.gameObject.tag == "blueButtonRoom2GoDoor" && inputAction_.Player.Talk.triggered && blueButtonRoomFlag == false)
            {
                textWriter.TextNum = 94;
                blueButtonRoomFlag = true;
            }

            if(collision.gameObject.tag == "blueButtonRoom2Go")
            {
                playerTeleport.SetPosition(-183.98f, 106f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(-183.98f, 104f);
                }
            }

            if (collision.gameObject.tag == "blueButtonRoomGo")
            {
                playerTeleport.SetPosition(-135f, 106f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(-137f, 104f);
                }
            }

            if(collision.gameObject.tag == "operoomtoEquilibriumDoor")
            {
                playerTeleport.SetPosition(-15.73f, 107.07f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(-15.73f, 109.07f);
                }
            }

            if(collision.gameObject.tag == "ChangeButton" && inputAction_.Player.Talk.triggered)
            {
                playerChange.moveFlag = true;
            }

            if(collision.gameObject.tag == "blueRoomDesk" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 98;
            }

            if(collision.gameObject.tag == "blueRoomBed" && inputAction_.Player.Talk.triggered)
            {
                if (blueRoomBedCount == 0)
                {
                    textWriter.TextNum = 100;
                }
                if(blueRoomBedCount == 1)
                {
                    textWriter.TextNum = 102;
                }
                if(blueRoomBedCount == 2)
                {
                    textWriter.TextNum = 104;
                }
                if (blueRoomBedCount == 3)
                {
                    textWriter.TextNum = 106;
                }
                if (blueRoomBedCount >= 4)
                {
                    textWriter.TextNum = 108;
                }
                if (blueRoomBedCount < 5)
                {
                    blueRoomBedCount++;
                }
            }

            if (collision.gameObject.tag == "blueRoomBookShef" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 110;
            }

            if (collision.gameObject.tag == "blueRoomLever" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 112;
            }

            if (collision.gameObject.tag == "blueRoomChair1" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 114;
            }

            if (collision.gameObject.tag == "blueRoomRoundDesk" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 116;
            }

            if (collision.gameObject.tag == "blueRoomStatue" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 118;
            }

            if(collision.gameObject.tag == "whiteMist" && inputAction_.Player.Talk.triggered)
            {
                if(firstWhiteMistFlag == true && firstTeacherDeskFlag == false)
                {
                    textWriter.TextNum = 142;
                }
                if (firstWhiteMistFlag == false)
                {
                    textWriter.TextNum = 140;
                    firstWhiteMistFlag = true;
                }
                if(firstTeacherDeskFlag == true)
                {
                    textWriter.TextNum = 170;
                }
            }

            if(collision.gameObject.tag == "opeRoomDesk" && inputAction_.Player.Talk.triggered)
            {
                if (firstWhiteMistFlag == true)
                {
                    textWriter.TextNum = 144;
                }
            }

            if(collision.gameObject.tag == "classRoom1TeacherDesk" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 148;
            }

            if(collision.gameObject.tag == "A_Desk" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 150;
            }
            if (collision.gameObject.tag == "B_Desk" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 152;
            }
            if (collision.gameObject.tag == "C_Desk" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 154;
            }
            if (collision.gameObject.tag == "D_Desk" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 156;
            }

            if(collision.gameObject.tag == "teacherRoomGoDoor")
            {
                playerTeleport.SetPosition(-135.62f, 36.03f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(-137.62f, 36.03f);
                }

                if(firstTeacherRoomFlag == false)
                {
                    textWriter.TextNum = 160;
                    firstTeacherRoomFlag = true;
                }
            }

            if(collision.gameObject.tag == "classRoom1ToTeacherRoom")
            {
                playerTeleport.SetPosition(-66.21f, 52.02f);
                if (boyTarget.followFlag2 == true)
                {
                    boyTeleport.SetPosition(-64.21f, 52.02f);
                }
            }

            if (collision.gameObject.tag == "teacherDesk1" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 162;
            }

            if (collision.gameObject.tag == "teacherDesk2" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 164;
            }

            if (collision.gameObject.tag == "teacherDesk3" && inputAction_.Player.Talk.triggered)
            {
                textWriter.TextNum = 166;
            }

            if (collision.gameObject.tag == "teacherDesk4" && inputAction_.Player.Talk.triggered && firstTeacherDeskFlag == false)
            {
                textWriter.TextNum = 168;
                firstTeacherDeskFlag = true;
            }

            if (collision.gameObject.tag == "Dial" && inputAction_.Player.Talk.triggered && password2.dontObject == false)
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

            if(collision.gameObject.tag == "bigEnemy")
            {
                GameOverFlag = true;
            }
            if (collision.gameObject.layer == 7 && inputAction_.Player.Talk.triggered)
            {
                //soundMan.isCheckUp = true;
                gameStop.hitFlag = true;
            }
        }

        //持ってるとき
        if (collision.gameObject.tag == "operatingDoor" && inputAction_.Player.UseItem.triggered && getItem.openMenu == true && getItem.haveOpeKey == true && getItem.isUseOpeKey == true)
        {
            //アイテムを使った時の処理を書いてほしい
            textWriter.TextNum = 35;
            if (getItem.itemPhoto1.sprite == getItem.imageKey)
            {
                getItem.itemPhoto1.enabled = false;
            }
            if (getItem.itemPhoto2.sprite == getItem.imageKey)
            {
                getItem.itemPhoto2.enabled = false;
            }
            if (getItem.itemPhoto3.sprite == getItem.imageKey)
            {
                getItem.itemPhoto3.enabled = false;
            }
            if (getItem.itemPhoto4.sprite == getItem.imageKey)
            {
                getItem.itemPhoto4.enabled = false;
            }
            if (getItem.itemPhoto5.sprite == getItem.imageKey)
            {
                getItem.itemPhoto5.enabled = false;
            }
            if (getItem.itemPhoto6.sprite == getItem.imageKey)
            {
                getItem.itemPhoto6.enabled = false;
            }
            if (getItem.itemPhoto7.sprite == getItem.imageKey)
            {
                getItem.itemPhoto7.enabled = false;
            }
            if (getItem.itemPhoto8.sprite == getItem.imageKey)
            {
                getItem.itemPhoto8.enabled = false;
            }
            if (getItem.itemPhoto9.sprite == getItem.imageKey)
            {
                getItem.itemPhoto9.enabled = false;
            }
            getItem.haveOpeKey = false;
            getItem.openMenu = false;
        }

        if (collision.gameObject.tag == "ironDoor" && inputAction_.Player.UseItem.triggered && boyFlag == true && getItem.openMenu == true && getItem.haveIronKey == true && getItem.isUseIronKey == true)
        {
            textWriter.TextNum = 47;
            if (getItem.itemPhoto1.sprite == getItem.imageKey)
            {
                getItem.itemPhoto1.enabled = false;
            }
            if (getItem.itemPhoto2.sprite == getItem.imageKey)
            {
                getItem.itemPhoto2.enabled = false;
            }
            if (getItem.itemPhoto3.sprite == getItem.imageKey)
            {
                getItem.itemPhoto3.enabled = false;
            }
            if (getItem.itemPhoto4.sprite == getItem.imageKey)
            {
                getItem.itemPhoto4.enabled = false;
            }
            if (getItem.itemPhoto5.sprite == getItem.imageKey)
            {
                getItem.itemPhoto5.enabled = false;
            }
            if (getItem.itemPhoto6.sprite == getItem.imageKey)
            {
                getItem.itemPhoto6.enabled = false;
            }
            if (getItem.itemPhoto7.sprite == getItem.imageKey)
            {
                getItem.itemPhoto7.enabled = false;
            }
            if (getItem.itemPhoto8.sprite == getItem.imageKey)
            {
                getItem.itemPhoto8.enabled = false;
            }
            if (getItem.itemPhoto9.sprite == getItem.imageKey)
            {
                getItem.itemPhoto9.enabled = false;
            }
            getItem.openMenu = false;
            getItem.haveIronKey = false;
        }

    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.layer == 7)
        {
            playerUI.SetActive(false);
        }
        if(other.gameObject.tag == "Enemy1" || other.gameObject.tag == "Enemy2")
        {
            enemyHitFlag = false;
            enemyMove1.counter = 0;
            enemyMove2.counter = 0;
        }
    }
}
