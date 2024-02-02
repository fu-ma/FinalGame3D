using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextWriter : MonoBehaviour
{
    public UIText uitext;

    private PlayerInputSystem inputAction_;

    public GameObject girl;
    public GameObject girl_fear;
    public GameObject boy;
    public GameObject boy_fear;
    public GameObject boyObject;
    public GameObject Canbus;
    public GameObject HP;
    public GameObject doll;
    public GameObject sewing;
    public GameObject rooftopEffect;
    public GameObject deskEffect;
    public GameObject opeKey;
    public GameObject ironKey;
    public GameObject operoomDoor;
    public GameObject ironKeyEffect;
    public GameObject room4goDoor;
    public GameObject balanceDoor;
    private GameObject fadeInObj;

    public GameObject kirakira1;
    public GameObject kirakira2;
    public GameObject kirakira3;
    public GameObject kirakira4;
    public GameObject kirakira5;
    public GameObject kirakira6;
    public GameObject kirakira7;
    public GameObject kirakira8;
    public GameObject stage0Enemy;
    public GameObject config;
    public GameObject investigate;
    public GameObject investigate2;
    public GameObject blueRoomDoor1;
    public GameObject blueRoomDoor2;
    public GameObject blueRoomDoor3;
    public GameObject blueRoomDoor4;
    public GameObject blueRoomDoor5;
    public GameObject blueRoomBook;
    public GameObject vase1;
    public GameObject vase2;
    public GameObject classRoom1TeachDeskObj;
    public GameObject classRoom1A;
    public GameObject classRoom1B;
    public GameObject classRoom1C;
    public GameObject classRoom1D;
    public GameObject teacherRoomDoor;
    public GameObject girlObject;

    public StatueCollision statueCollision;
    public ChairCollision chairCollision;

    private bool configFlag;

    public GameObject config2;

    private bool config2Flag;

    private FadeIn fadeIn;

    private storyCameramove1 cameraMove1;
    private storyCameramove2 cameraMove2;

    private publicFlag gameStop;

    private PlayerDamage playerDamage;

    private PlayerTeleport playerTeleport;
    private boyTeleport boyTeleport;
    private boyTarget boyTarget;

    private hospitalPlayerSprite hospital;

    private playerGetItem playergetitem;

    private SoundManager soundMan;

    private Password password;
    private Password2 password2;
    private cameraRotate cameraRot;

    private EnemyTargetMove enemyTarget;

    private operoomMove operoommove;

    private playerMove playermove;
    private boyMove boymove;
    private ResetRoom resetroom;

    private CameraChange playerChange;

    public GameObject mainCamera;
    public GameObject subCamera;

    public Rigidbody blueRoomStatue;
    public Rigidbody blueRoomChair;

    public GameObject whiteMistObject;

    //�l�`�������Ă��邩
    public bool dollGetFlag;
    public bool fenceStoryFlag;

    public int TextNum;

    //room0�����ł��ʂ������Ƃ����邩
    public bool room0FirstFlag;

    public bool underground45Flag;

    public bool operoom45Flag;

    public bool equilibriumGoDoorFlag;

    private bool openBlueRoomFlag;

    private bool A_DeskStoryFlag;
    private bool B_DeskStoryFlag;
    private bool C_DeskStoryFlag;
    private bool D_DeskStoryFlag;
    private bool DeskStoryFlag;

    //�J������]
    public bool cameraRotateFlag;
    private bool cameraRotatedFlag;
    private int cameraRotateTimer;

    private bool gameEndFlag;
    // Start is called before the first frame update
    void Start()
    {
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();

        this.gameObject.SetActive(true);

        fadeInObj = GameObject.Find("fadeIn");
        fadeIn = fadeInObj.GetComponent<FadeIn>();

        cameraMove1 = GameObject.Find("CameraPos").GetComponent<storyCameramove1>();
        cameraMove2 = GameObject.Find("GameManager").GetComponent<storyCameramove2>();

        gameStop = GameObject.Find("GameManager").GetComponent<publicFlag>();

        playerDamage = GameObject.Find("player").GetComponent<PlayerDamage>();

        playerTeleport = GameObject.Find("player").GetComponent<PlayerTeleport>();
        boyTeleport = GameObject.Find("boyObject").GetComponent<boyTeleport>();

        boyTarget = GameObject.Find("boyObject").GetComponent<boyTarget>();
        boyTarget.followFlag2 = false;

        hospital = GameObject.Find("playerShadow").GetComponent<hospitalPlayerSprite>();

        playergetitem = GameObject.Find("player").GetComponent<playerGetItem>();

        password = GameObject.Find("player").GetComponent<Password>();
        password2 = GameObject.Find("player").GetComponent<Password2>();

        cameraRot = GameObject.Find("player").GetComponent<cameraRotate>();

        enemyTarget = GameObject.Find("room0Enemy").GetComponent<EnemyTargetMove>();

        soundMan = GameObject.Find("Canvas").GetComponent<SoundManager>();

        operoommove = GameObject.Find("boyObject").GetComponent<operoomMove>();

        playermove = GameObject.Find("player").GetComponent<playerMove>();
        boymove = GameObject.Find("boyObject").GetComponent<boyMove>();

        resetroom = GameObject.Find("GameManager").GetComponent<ResetRoom>();

        playerChange = GameObject.Find("GameManager").GetComponent<CameraChange>();

        blueRoomStatue.isKinematic = true;
        blueRoomChair.isKinematic = true;

        TextNum = 0;
        fenceStoryFlag = false;
        boy_fear.SetActive(false);
        boyObject.SetActive(false);
        Canbus.SetActive(true);
        HP.SetActive(false);
        doll.SetActive(false);
        sewing.SetActive(false);
        rooftopEffect.SetActive(true);
        deskEffect.SetActive(true);
        opeKey.SetActive(false);
        ironKey.SetActive(false);
        operoomDoor.SetActive(true);
        ironKeyEffect.SetActive(true);
        room4goDoor.SetActive(true);
        balanceDoor.SetActive(true);
        dollGetFlag = false;
        cameraRotateFlag = false;
        cameraRotatedFlag = false;
        cameraRotateTimer = 0;
        room0FirstFlag = false;
        config.SetActive(false);
        configFlag = false;
        config2.SetActive(false);
        config2Flag = false;
        investigate.SetActive(false);
        investigate2.SetActive(false);
        blueRoomDoor1.SetActive(false);
        blueRoomDoor2.SetActive(false);
        blueRoomDoor3.SetActive(false);
        blueRoomDoor4.SetActive(true);
        blueRoomDoor5.SetActive(false);
        blueRoomBook.SetActive(false);
        vase1.SetActive(true);
        vase2.SetActive(false);
        whiteMistObject.SetActive(false);
        classRoom1TeachDeskObj.SetActive(false);
        classRoom1A.SetActive(false);
        classRoom1B.SetActive(false);
        classRoom1C.SetActive(false);
        classRoom1D.SetActive(false);
        teacherRoomDoor.SetActive(true);
        girlObject.SetActive(true);

        kirakira1.SetActive(true);
        kirakira2.SetActive(true);
        kirakira3.SetActive(true);
        kirakira4.SetActive(true);
        kirakira5.SetActive(true);
        kirakira6.SetActive(true);
        kirakira7.SetActive(true);
        kirakira8.SetActive(true);

        gameEndFlag = false;

        underground45Flag = false;
        operoom45Flag = false;
        equilibriumGoDoorFlag = false;
        openBlueRoomFlag = false;
        A_DeskStoryFlag = false;
        B_DeskStoryFlag = false;
        C_DeskStoryFlag = false;
        D_DeskStoryFlag = false;
        DeskStoryFlag = false;
    }

    IEnumerator Skip()
    {
        while (uitext.playing) yield return 0;
        while (!uitext.IsClicked()) yield return 0;
    }

    IEnumerator RooftopStory()
    {
        //uitext.DrawText("�i���[�V�����������炱�̂܂܏�����OK");
        //yield return StartCoroutine("Skip");
        Canbus.SetActive(true);
        boy.SetActive(false);
        girl.SetActive(true);
        investigate.SetActive(false);
        uitext.DrawText("����", "����...?");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);
        uitext.DrawText( "�C���t���ƁA���m��ʏꏊ�ɓ|��Ă����B");
        yield return StartCoroutine("Skip");
        uitext.DrawText( "��������n���Ă݂���^���ÂŁA�ڂ���ƌ���d���������A���ォ��ӂ����������Ƃ炵�Ă���B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("�����[�g����̈Èłɔ����ɍ򂪌������B");
        yield return StartCoroutine("Skip");
        fadeIn.fadeFlag = true;
        girl.SetActive(true);
        uitext.DrawText("����", "�����Ă��񂾂���...");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);
        uitext.DrawText("�ǂ����A�����ɗ���܂ł̋L�������������Ă���݂������B");
        yield return StartCoroutine("Skip");
        cameraMove1.effectFlag = true;
        Canbus.SetActive(false);
    }

    IEnumerator RooftopStory2()
    {
        Canbus.SetActive(true);
        girl.SetActive(false);
        girl_fear.SetActive(true);
        investigate.SetActive(false);

        uitext.DrawText("����", "�I");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(false);
        girl.SetActive(false);
        uitext.DrawText("�m���ɍ��A�l����э~�肽�B�����ĉe�̗l�ȁB");
        yield return StartCoroutine("Skip");
        uitext.DrawText("��u�ł��������h�\���h�͌`�e���������A�������ł߂��l�ȁA����ȑ��݊��ɓf���C�������B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);
        girl_fear.SetActive(true);
        uitext.DrawText("����", "�����c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);
        girl_fear.SetActive(false);
        uitext.DrawText("���ꂽ�l�ɐ���R�炵�A�������Ȃ��狭���H�����΂�B");
        yield return StartCoroutine("Skip");
        girl.SetActive(true);
        uitext.DrawText("����", "�����ɋ����܂܂���܂����B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);
        uitext.DrawText("�����������̂͊�@�����A�{�\���B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("���̌����悤�̂Ȃ����ۂ��A�����ł͂Ȃ����Ƃ������m���ɍm�肷��B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("����ȋ��|��␂񂾑���^����ɓ��������̂́A�ق�̏����̍D��S�������B");
        yield return StartCoroutine("Skip");
        cameraMove1.effectFlag2 = true;

        config.SetActive(true);
        configFlag = true;
        Canbus.SetActive(false);
    }
    IEnumerator doorStory1()
    {
        Canbus.SetActive(true);
        girl.SetActive(false);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("�h�A�͕܂��Ă���B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("�h�A�̋߂��ɁA�������������̂���l�`���u���Ă���B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("�����Ă���ƂƂĂ����S����l���B");
        yield return StartCoroutine("Skip");
        doll.SetActive(true);
        soundMan.isGetItem = true;
        uitext.DrawText("�l�`����ɓ��ꂽ�B");
        yield return StartCoroutine("Skip");
        doll.SetActive(false);
        HP.SetActive(true);
        dollGetFlag = true;
        gameStop.stopFlag = false;
        rooftopEffect.SetActive(false);
        Canbus.SetActive(false);
    }

    IEnumerator fenceStory1()
    {
        Canbus.SetActive(true);
        girl.SetActive(false);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("�����̂����ƍ����e���o���o���ɂȂ��ĎU��΂��Ă���B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("���̌��i�������u�Ԃɋ��|�Ɠf���C�ɏP��ꂽ�B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("�������A�s�ӂɐl�`��������߂���s���͔���Ă������B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("����Ɠ����ɐl�`�̉E�r�������Ȃ��Ă��鎖�ɋC�Â����B");
        yield return StartCoroutine("Skip");
        soundMan.isDoorOpen = true;
        playerDamage.isDamage = true;
        gameStop.stopFlag = false;
        fenceStoryFlag = true;
        Canbus.SetActive(false);
    }

    IEnumerator doorStory2()
    {
        Canbus.SetActive(true);
        girl.SetActive(false);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("�h�A���J���Ă���B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("���ɓ��낤�B");
        yield return StartCoroutine("Skip");
        playerTeleport.SetPosition(5, 30);
        if (boyTarget.followFlag2 == true)
        {
            boyTeleport.SetPosition(7, 30);
        }
        TextNum = 9;
        Canbus.SetActive(false);
    }

    IEnumerator hospitalStory()
    {
        Canbus.SetActive(true);
        girl.SetActive(false);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        girl_fear.SetActive(true);
        investigate.SetActive(false);

        uitext.DrawText("����", "���c�c�c�c?");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(false);

        hospital.Flag = true;
        Canbus.SetActive(false);
    }

    IEnumerator hospitalStory2()
    {
        Canbus.SetActive(true);
        girl.SetActive(false);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("�ڂ̑O�ɍL�����Ă���̂́A�a�@�̃G���g�����X���낤���B");
        yield return StartCoroutine("Skip");
        hospital.backFlag = true;
        uitext.DrawText("����������U������΁A�h�A�̐�ɂ͉��オ�L�����Ă���B");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(true);
        uitext.DrawText("����","�ǂ��Ȃ��Ă�́c");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(false);
        soundMan.isDoorClose = true;
        uitext.DrawText("�o�^���I�I�I�I");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(true);
        uitext.DrawText("����", "���c�c");
        yield return StartCoroutine("Skip");
        hospital.backFlag = false;
        uitext.DrawText("����", "��ɐi�ނ����Ȃ��c��ˁc");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(false);
        gameStop.stopFlag = false;
        Canbus.SetActive(false);
    }

    IEnumerator entranceDoorStory()
    {
        Canbus.SetActive(true);
        girl.SetActive(false);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("�h�A�͕܂��Ă���B");
        yield return StartCoroutine("Skip");
        gameStop.stopFlag = false;
        Canbus.SetActive(false);
    }

    IEnumerator operatingDoorStory()
    {
        Canbus.SetActive(true);
        girl.SetActive(false);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("��p���Ə�����Ă���B");
        yield return StartCoroutine("Skip");
        fadeIn.fadeOutFlag = true;
        uitext.DrawText("����", "����I");
        yield return StartCoroutine("Skip");
        uitext.DrawText("����", "���߂��I");
        yield return StartCoroutine("Skip");
        uitext.DrawText("����", "���ȂȂ��ł��I�I");
        yield return StartCoroutine("Skip");
        uitext.DrawText("����", "�u���Ă��Ȃ��Łc�c");
        yield return StartCoroutine("Skip");
        fadeIn.fadeFlag = true;
        girl_fear.SetActive(true);
        uitext.DrawText("����", "�����c���ɂ��c");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(true);
        uitext.DrawText("����", "����ɉ����c��؂ȁc");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(true);
        uitext.DrawText("����", "�v���o���Ȃ��c");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(false);

        gameStop.stopFlag = false;
        Canbus.SetActive(false);
    }

    IEnumerator ironDoorStory()
    {
        Canbus.SetActive(true);
        girl.SetActive(false);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("�S��̃Q�[�g���B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("�X�ɉ��ɂ̓h�A��������B");
        yield return StartCoroutine("Skip");
        girl.SetActive(true);
        uitext.DrawText("����", "���̓S��A�A�C�c�̐g���Ȃ�o�ꂽ���ȁB");
        yield return StartCoroutine("Skip");
        uitext.DrawText("����", "�c����A�A�C�c���āc�N�̂��Ƃ��낤�c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        gameStop.stopFlag = false;
        Canbus.SetActive(false);
    }

    IEnumerator classroomStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        girl.SetActive(true);
        investigate.SetActive(false);

        uitext.DrawText("����", "���x�́c�w�Z�H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        gameStop.stopFlag = false;
        Canbus.SetActive(false);
    }

    IEnumerator classroomStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        girl.SetActive(true);
        investigate.SetActive(false);

        uitext.DrawText("����", "����H�������Ƃ��Ȃ��H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        gameStop.stopFlag = false;
        Canbus.SetActive(false);
    }

    IEnumerator desk1Story()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("���̒��ɉ��������Ă���B");
        yield return StartCoroutine("Skip");
        girl.SetActive(true);
        uitext.DrawText("����", "����́c�ٖD����c�H");
        yield return StartCoroutine("Skip");
        uitext.DrawText("����", "���ꂪ����΂��l�`�������邩���B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);
        sewing.SetActive(true);
        soundMan.isGetItem = true;
        uitext.DrawText("�ٖD�������ɓ��ꂽ�B");
        yield return StartCoroutine("Skip");
        //������sowingGet��true�ɂ��镶������
        playergetitem.sowingGet1 = true;

        deskEffect.SetActive(false);
        sewing.SetActive(false);
        uitext.DrawText("���A�C�e��������h�ٖD����h���g�p����ƁAHP��S�񕜂��邱�Ƃ��o���܂��B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("��x�g�p�����ٖD����͎����܂��B");
        yield return StartCoroutine("Skip");

        gameStop.stopFlag = false;
        Canbus.SetActive(false);
    }

    IEnumerator classroomStory2_1()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        girl.SetActive(false);
        girl.SetActive(true);
        investigate.SetActive(false);

        uitext.DrawText("����", "���x�́c�w�Z�H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        gameStop.stopFlag = false;
        Canbus.SetActive(false);
    }
    IEnumerator enemyShowStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        fadeIn.fadeOutFlag = true;

        girl_fear.SetActive(true);
        uitext.DrawText("����", "���c�A���c");
        yield return StartCoroutine("Skip");
        fadeIn.fadeFlag = true;

        girl_fear.SetActive(false);
        uitext.DrawText("�����l�e�͋�������p�j���Ă���l���B");
        yield return StartCoroutine("Skip");

        gameStop.stopFlag = false;
        Canbus.SetActive(false);
    }

    IEnumerator EnemyStory()
    {
        Canbus.SetActive(true);
        boy.SetActive(false);
        girl.SetActive(false);
        girl_fear.SetActive(true);
        investigate.SetActive(false);

        uitext.DrawText("����", "�I�I�I�I�I");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(false);
        //playerTeleport.SetPosition(5, 30);

        gameStop.stopFlag = false;
        Canbus.SetActive(false);
    }

    IEnumerator BlackBoardStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("�Y��ȍ����B");
        yield return StartCoroutine("Skip");

        gameStop.stopFlag = false;
        Canbus.SetActive(false);
    }

    IEnumerator BlackBoardStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("How many chalk?");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("����", "�`���[�N�̐��H");
        yield return StartCoroutine("Skip");
        uitext.DrawText("����", "�ł������Ƀ`���[�N�͖�����ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        gameStop.stopFlag = false;
        Canbus.SetActive(false);
    }

    IEnumerator BlackBoardStory3()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("answer the question");
        yield return StartCoroutine("Skip");

        Canbus.SetActive(false);
        password.isCommand = true;
    }

    IEnumerator playerDamageStory()
    {
        Canbus.SetActive(true);
        boy.SetActive(false);
        girl.SetActive(false);
        girl_fear.SetActive(true);
        soundMan.isDamage = true;
        investigate.SetActive(false);

        uitext.DrawText("����","�ɂ��I");
        yield return StartCoroutine("Skip");

        uitext.DrawText("����", "�Ԉ�������Ă��Ɓc�H");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator playerGetKeyStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        girl.SetActive(true);
        soundMan.isDropKey = true;
        investigate.SetActive(false);

        uitext.DrawText("����", "��H�����������悤�ȁc");
        yield return StartCoroutine("Skip");

        uitext.DrawText("����", "����c�����B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        opeKey.SetActive(true);
        soundMan.isGetItem = true;
        uitext.DrawText("��p���̌�����肵�܂����B");
        yield return StartCoroutine("Skip");
        opeKey.SetActive(false);

        playergetitem.haveOpeKey = true;

        Canbus.SetActive(false);
        config2.SetActive(true);
        config2Flag = true;
    }

    IEnumerator openOperoomStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        girl.SetActive(false);
        soundMan.isOpenKey = true;
        investigate.SetActive(false);

        uitext.DrawText("�h�A���J�����l���B");
        yield return StartCoroutine("Skip");

        playerTeleport.SetPosition(-9.52f, 48.7f);
        if (boyTarget.followFlag2 == true)
        {
            boyTeleport.SetPosition(-7.52f, 48.7f);
        }

        operoomDoor.SetActive(false);
        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator operoomStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        fadeIn.fadeOutFlag = true;

        uitext.DrawText("��t", "�őP�́c�s�����܂������c�c�c");
        yield return StartCoroutine("Skip");

        girl_fear.SetActive(true);
        uitext.DrawText("����", "�ނ��c");
        yield return StartCoroutine("Skip");
        uitext.DrawText("����", "����݂��āc�c");
        yield return StartCoroutine("Skip");
        uitext.DrawText("����", "�����������āc�c�c");
        yield return StartCoroutine("Skip");
        uitext.DrawText("����", "�ǂ����āc");
        yield return StartCoroutine("Skip");
        uitext.DrawText("����", "�ǂ����āc�c");
        yield return StartCoroutine("Skip");

        girl_fear.SetActive(false);
        uitext.DrawText("�H�H", "�c���c�c");
        yield return StartCoroutine("Skip");

        girl_fear.SetActive(true);
        uitext.DrawText("����", "�ǂ����āc�c�c");
        yield return StartCoroutine("Skip");

        girl_fear.SetActive(false);
        uitext.DrawText("�H�H", "���c�c�Ԃ��c");
        yield return StartCoroutine("Skip");

        playermove.boyFlag = true;
        boyObject.SetActive(true);

        fadeIn.fadeFlag = true;

        boy.SetActive(true);
        uitext.DrawText("���N", "�����I");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "�I�I�I�I");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "������A�r�r�点�����͖��������񂾂��B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("���N", "�����ƁA�v���Y��ł����[���B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("���N", "�댯�Ȋ������������c���́A���v���H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("���N���S�z�����ɂ��Ă���B");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("����", "���݂܂���c�c���v�c�ł��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "�c�������B�Ȃ񂾁A���O���N�����炱���ɋ��������H����Ƃ��c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "�I�I");
        yield return StartCoroutine("Skip");
        uitext.DrawText("����", "���A���Ȃ��������Ȃ�ł����I�H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "�����A����ς肻���Ȃ̂��B�Ȃ񂩓����������������B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("���N", "����A�������[���C�z�I�ȁA���B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        fadeIn.fadeOutFlag = true;

        uitext.DrawText("�����͏������g�����悤�ɔ��΂񂾁B");
        yield return StartCoroutine("Skip");
        playerTeleport.SetPosition(-9.52f, 48.7f);
        boyTarget.followFlag2 = true;
        boyTeleport.SetPosition(-7.52f, 48.7f);
        fadeIn.fadeFlag = true;


        girl.SetActive(true);
        uitext.DrawText("����", "�Ƃ������Ƃ͂܂�A���Ȃ����N�����炱���ɋ��āA�ǂ��ɂ�����i��ŗ������p���ɒ�������ł��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "�����A�������ȁB�������炨�O���p��N���Ă鏊�ɏo���킵�����Ė󂾁B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "���݂܂���B���ꂵ���Ƃ�����B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "������c����A�ǂ����Ă��ƂȂ���(�H)");
        yield return StartCoroutine("Skip");
        uitext.DrawText("���N", "����łǁ[�����B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("���N", "�����T���Ă����܂ŗ����킯�����A���������̕��������O���T�������������Ă�Ȃ瑼�ɐi�ޓ��͖�����ȁc");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "���A����Ȃ�B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("����", "�������̋����́A�����Ď肪�͂��Ȃ��ꏊ�ɉ�������݂����Ȃ�ł��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "�Ȃ�قǂˁA���ꂪ���Ƃ��Ȃ�T�C�R�[���ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("����������͏��N�����ɍs�����Ă���܂��B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("�ȑO�T�������ꏊ�����N�ɏ����Ă��炤���ƂŁA�V���Ȏ�|���肪�����邩������܂���B");
        yield return StartCoroutine("Skip");
        

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator ironDoorStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "�Ƃ���ŁA�����T���������葼�ɍs����ꏊ�������悤�Ɏv�����̂ł����A�������痈����ł����H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "�����A�������悶�o���Ă����񂾁B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "�ȁA�Ȃ�قǁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator boyClassroom1Story()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "���[�������B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "�H�I�����ɂ͈�x���Ă���ł�����");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "���[����A�Ȃ�ł��ˁ[�B�Y��Ă���B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "���c�c�c�����ł����c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blackBoard1_2Story()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("���̏�ɉ���������̂�������");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("����", "�����Ď��Ȃ��ȁc");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator boyBlackBoard1_2Story()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "�����ł��B���̍��̏�ɁA��������܂��񂩁H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "���[�A�Ȃ񂩌�����Ȃ��B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("���������ď��N�͑傫�����L�΂��B");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        soundMan.isGetItem = true;
        uitext.DrawText("���N", "�����A�����B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        ironKey.SetActive(true);
        uitext.DrawText("�S��̌�����ɓ��ꂽ�B");
        yield return StartCoroutine("Skip");
        ironKey.SetActive(false);
        playergetitem.haveIronKey = true;
        ironKeyEffect.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "��荇��������ŉ����������ƌq���������ď����B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator ironOpenDoorStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        room4goDoor.SetActive(false);
        soundMan.isOpenKey = true;
        uitext.DrawText("�S��̔����J�����B");
        yield return StartCoroutine("Skip");

        playerTeleport.SetPosition(19.36f, 48.51f);
        if (boyTarget.followFlag2 == true)
        {
            boyTeleport.SetPosition(21.36f, 48.51f);
        }

        boy.SetActive(true);
        uitext.DrawText("���N", "���[����A�����������ɗ���܂ł̕����ɏ��������������������񂾂��ǂ�B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "�����񂹂񉴂���ʂ�Ȃ��ĂȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "���O�̔w�i�D�Ȃ�ʂꂽ�肵�˂����H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "���͎������􂷂�Ԃ��Ă��Ƃł��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "�񂟁A�������ȁB�����邺�B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator room4Story()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "�����ʘH�A�ł��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "�����Ȃ񂾂�ȁB�Ȃ�ł������������̏ꏊ�͂ǂ����ʘH�΂�����Ȃ񂾂�B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "�����������̂Ȃ�Ēn�������炢���������ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "�n�����c�ł����H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "�񂟁A�����ŏ��ɋ����Ƃ��B���O������ɋ����񂾂�H�����悤�ȃ�������ˁH");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "����́c�����Ȃ�ł����ǁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "����A��������Č����܂��������H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "���H���[�[�A�����Ă��[�B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "�����ł������c�c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator room6Story()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "���������L���ł��ˁc");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "�������ȁA�������Ȃ�[���A������Ɩ��������ɂȂ�B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "�������G�Ɋ����܂�����ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator undergroundStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "���������̏����X�|�[�����ĂƂ����ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "�����X�|�[���H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "���O�Ō���������Ă��ƁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "�����A�ŏ��ɋ����Ƃ�����Ęb�ł����B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "�Ă��A����������v���Ă���ł����A���O���ČĂѕ���߂Ă��������B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "�񂟁H���[�A�ł������O�̖��O�m��˂�����ȁc");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "���Ⴀ�����Ă��������B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "�����c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "�c�c�c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "�H�c�c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "�c�c���O�c�c����A���́A�n�J���c���O�́H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "����c�c���ł����H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���O�̕�����B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "�����Ȃ�ł��ˁc�n�J������c�c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�ŁH���O�́H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "�\���ł��c�c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�\�����āA���͒j�c�H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "����ł��˂Ԃ���΂��܂���H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���O�������悤�ȃ�������c�c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator upRightStory1()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "�����������A���̏������ʘH�A���O�Ȃ�ʂ�Ȃ����H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "�����A�����ʂ���Ă�����ł����c�c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "����A�܂��A�����ɂƂ͌���ˁ[���B�@�����񂱂��ȊO�͒T���ς݂Ȃ񂾂�ȁc");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("����", "���[�c�c��ł������ł����c�c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("���N", "���[�A�����͂���ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator upRightStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�撣���āA�����Ă݂܂��c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�����������炷���߂��ė�����B���͈ꏏ�ɍs���Ȃ����A�����őҋ@���Ă邩���B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�n�J������͊y�ł����ł��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�c�c�c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);
        boyTarget.followFlag2 = false;
        
        Canbus.SetActive(false);
        gameStop.stopFlag = false;
        playerTeleport.SetPosition(36.26f, 157.14f);
        //boyTeleport.SetPosition(38.26f, 157.14f);

        room0FirstFlag = true;
        TextNum = 63;
    }

    IEnumerator DialStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("�O���̃_�C����");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("�\��", "�܂��_�C�����ł����c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���̃_�C�����͍ŏ������猩���Ă͋����񂾂��A����炵���ԍ��͂ǂ��ɂ������񂾂�ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�m���ɁA�����E���i�ȘL���ŁA����炵�����̂͌��܂���ł����ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "����H������܂��A�������ɓ��邵���˂����Ȃ��āB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�킩��܂�����c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        password2.isIronCommand = true;
    }

    IEnumerator playerDamageStory2()
    {
        Canbus.SetActive(true);
        boy.SetActive(false);
        girl.SetActive(false);
        girl_fear.SetActive(true);
        soundMan.isDamage = true;
        investigate.SetActive(false);

        uitext.DrawText("�\��", "�ɂ��I");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�\��", "�Ԉ�������Ă��Ɓc�H");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator playerGetKeyStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        balanceDoor.SetActive(false);
        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���������A���̕����ɂ܂��悪�������̂���B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���x�����i�W���Ċ����ł��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�\���̂��蕿���ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�s���܂��傤�B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator balanceroomStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����́c�H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "��̂��鏊���ȁc���ւ��H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        fadeIn.fadeOutFlag = true;

        girl.SetActive(true);
        uitext.DrawText("�\��", "���A���ɉ�������܂��B����ƃ��������݂����Ȃ̂��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);
        playerTeleport.SetPosition(-70, 223);
        if (boyTarget.followFlag2 == true)
        {
            boyTeleport.SetPosition(-68, 223);
        }

        fadeIn.fadeFlag = true;

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�������Ɓc�H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("����́h�肢�̓V���h�B�������肦�΁A���̓V���������Ă����B");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�肢�́c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�V���c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�c�c�c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "����l����ȁc�v�͉���̊肢�������Ă����񂾂�H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���������Ă���܂����ǁA����Ȃ����肢�������Ă������̂Ȃ�Ă����ł��傤���B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "��`�`�H������Ƃ͂킩��˂����ǁA�S�O����C�����͂킩��B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "��荇��������ܑ傫�ȗv���͂��Ȃ������ǂ��B���ď����B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����ł��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeOutFlag = true;

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�����ɒ��x�������炢�̊肢�c���B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);
        playerTeleport.SetPosition(-70, 227.46f);
        if (boyTarget.followFlag2 == true)
        {
            boyTeleport.SetPosition(-68, 227.46f);
        }

        fadeIn.fadeFlag = true;

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "��������o��̂�����̖ړI���Ƃ��āB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�܂��A�Ȃ񂾁H���̕����ōs����ꏊ�͑S���s�����󂾂��ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����ł��ˁB�Ȃ�A���̂��炢�Ŏ����Ă݂܂��傤���B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�V������A�ǂ����i�ނׂ����������ĉ������B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeInOutFlag = true;
        cameraRotateFlag = true;
        Canbus.SetActive(false);

        underground45Flag = true;
        operoom45Flag = true;
        gameStop.stopFlag = false;
        //gameEndFlag = true;
    }

    IEnumerator room0Story1()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        hospital.behindFlag = true;

        girl.SetActive(true);
        uitext.DrawText("�\��", "����܂����悧�[���c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�������܂������ʘH���Ċ����ł��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�����A�ǂ����A�����ɉ����ԍ��̎�|���肪����΂����񂾂��ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�T���Ă݂܂��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        enemyTarget.moveFlag = true;
        Canbus.SetActive(false);
        gameStop.stopFlag = false;
        gameStop.playerDontMoveFlag = true;
    }

    IEnumerator room0Story2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        hospital.leftFlag = true;

        girl_fear.SetActive(true);
        uitext.DrawText("�\��", "�n�J������s���������B");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�I�ǂ������H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl_fear.SetActive(true);
        uitext.DrawText("�\��", "�����Ă���܂���ŉ�܂���c");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(false);

        enemyTarget.FirstFlag = true;
        Canbus.SetActive(false);
        gameStop.stopFlag = false;
        gameStop.playerDontMoveFlag = false;
    }

    IEnumerator wallStory1()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("���O�͖Y��Ă���B");
        yield return StartCoroutine("Skip");
        Canbus.SetActive(false);
        gameStop.stopFlag = false;
        kirakira1.SetActive(false);
    }

    IEnumerator wallStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("���O�͎��ɑ��Ȃ��B");
        yield return StartCoroutine("Skip");
        Canbus.SetActive(false);
        gameStop.stopFlag = false;
        kirakira2.SetActive(false);
    }

    IEnumerator wallStory3()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("���O�̂������B");
        yield return StartCoroutine("Skip");
        Canbus.SetActive(false);
        gameStop.stopFlag = false;
        kirakira3.SetActive(false);
    }

    IEnumerator wallStory4()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("���O�����邩��B");
        yield return StartCoroutine("Skip");
        Canbus.SetActive(false);
        gameStop.stopFlag = false;
        kirakira4.SetActive(false);
    }

    IEnumerator wallStory5()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("���̐F�B");
        yield return StartCoroutine("Skip");
        Canbus.SetActive(false);
        gameStop.stopFlag = false;
        kirakira5.SetActive(false);
    }

    IEnumerator wallStory6()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        sewing.SetActive(true);
        soundMan.isGetItem = true;
        uitext.DrawText("�ٖD�������ɓ��ꂽ�B");
        yield return StartCoroutine("Skip");
        sewing.SetActive(false);

        playergetitem.sowingGet1 = true;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
        kirakira6.SetActive(false);
    }

    IEnumerator wallStory7()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("�����̌`�B");
        yield return StartCoroutine("Skip");
        Canbus.SetActive(false);
        gameStop.stopFlag = false;
        kirakira7.SetActive(false);
    }

    IEnumerator wallStory8()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("���]�B");
        yield return StartCoroutine("Skip");
        Canbus.SetActive(false);
        gameStop.stopFlag = false;
        kirakira8.SetActive(false);
    }

    IEnumerator room0backHomeStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);
        boyTarget.followFlag2 = true;
        stage0Enemy.SetActive(false);

        enemyTarget.moveFlag = false;

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���v�����H�I");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl_fear.SetActive(true);
        uitext.DrawText("�\��", "�͂��A�͂��A�͂��A�͂��B");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�c�c�Ȃ�Ƃ��c�c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�S������Ȃ���������܂��񂪁c��������|����ȂǁA�����܂����c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeOutFlag = true;

        uitext.DrawText("�\���̌ċz�����������܂ŁA�n�J���͔w�������������[�B");
        yield return StartCoroutine("Skip");
        fadeIn.fadeFlag = true;

        girl.SetActive(true);
        uitext.DrawText("�\��", "���������Ă��܂����B�������v�ł��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���肪�Ƃ��ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����ł��ˁB�����Ɗ��ӂ��Ă��������B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�����A�\�������Ă���ď��������B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "��������A��������͔ԍ��𓱂���������ď��ł����ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
        gameStop.playerDontMoveFlag = false;
    }

    IEnumerator undergroundStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�E�@�E�@�E");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�@�E�@�E�@�E�@");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�Ȃ񂩁c�����ω�����������ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����A�ł��ˁB�������̃Z���t���p�������������Ă��܂����B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�܁A�܂��ق�A������犐���Ȃ�Ă��Ǝ��̕��ʂ͂�����������ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���琏�����������̕ςȋ�Ԃɋ��邩�炿�Ɗ��҂����܂����Ȃ�");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�悵���A�܂����Ă˂��ꏊ���邩�����B�T���ɍsk�c�c�H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�n�J������c�s�v�c�ł��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�ǂ������H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�n�J��������Ă������܂Ŏ��̌��ɋ��܂�����ˁH");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���c�����c�c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�I");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���A���̍��ɋ��܂��񂩁c�H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�ςȂ��Ƃ������Ă��鎩�o�͂���܂��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����ɕω��͖����ł����A���������������肵�Ă܂���B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�ł��m���ɁA�n�J�����񂪂������ƈႤ�ꏊ�ɋ�����Ďv����ł��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�c�{�����B�����\�����E�ɃY�����l�Ɋ�����B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����{���ɂ��肢���������āA��������̌��ʂ𔭊������̂�������܂���B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�������o���[���A������k�����ꂽ�悤�ȁc");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����̊O�ɏo�Ă݂܂��傤�B�����Ɖ����V��������������͂��ł��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���[���ȁB�s���Ă݂邵���˂��ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator operoom45Story()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        fadeIn.fadeOutFlag = true;
        girl.SetActive(true);
        uitext.DrawText("�\��", "���c�����A�����Ƀh�A�Ȃ�Ă���܂������H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        cameraMove2.effectFlag = true;
        boyTarget.followFlag2 = false;

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���������n�Y�c�c����c�����ĂȂ������̂��c�H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���p���������Č����̂��A�ςȊ������ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "������ƁA���߂Ă������َ��ȋ�ԂȂ񂾂ȂƊ����܂����B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�������ȁc");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "������Ƒ҂��Ă��B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        operoommove.moveFlag = true;

        Canbus.SetActive(false);
    }

    IEnumerator operoom45Story2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�悵�B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���΂ł����A����ɂȂ�܂��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�܁A���̘J���΂������Ă�����ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���d����ς�������ł��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boyTarget.followFlag2 = true;
        cameraMove2.effectFlag = true;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator operoom45Story3()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���͂������Ė����݂����ł��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeOutFlag = true;
        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�Ȃ�A�����Ă݂邩�B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        playerTeleport.SetPosition(-123.8f, 106f);
        if (boyTarget.followFlag2 == true)
        {
            boyTeleport.SetPosition(-121.8f, 106f);
        }
        fadeIn.fadeFlag = true;
        Canbus.SetActive(false);

        TextNum = 92;
    }

    IEnumerator blueButtonRoom()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���c�c�c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����c�c���̕����ł��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�i���̎q�̕������߂ē������c�j");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�ȂɃ{�[���Ƃ��Ă��ł����n�J������B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����������̏ꏊ����Ȃ����Ƃ͕������Ă܂��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����i�݂܂���B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���A�ꉞ�A�N���[�[�b�g�͐�ΊJ���Ȃ��ł��������ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���A�����B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�i�����Ă͗ǂ��̂��c�j");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueButtonRoomStory1()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���ւ��A�܂��ł����B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���[�A�����݂������ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�n�J�����񂿂���Ə΂��Ă܂���H�H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "����H��");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("�\���̓n�J���̑��𓥂݂���");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�����I���[�[�B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�s���Ă��܂��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���A�����c�C�����Ăȁc�c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);
        boyTarget.followFlag2 = false;
        boyTeleport.SetPosition(-123.8f, 106f);

        playerTeleport.SetPosition(-183.98f, 106f);

        Canbus.SetActive(false);
        TextNum = 96;
    }

    IEnumerator blueButtonRoomStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����c�c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���v���H�I");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���v�c�Ȃ�ł����ǁA�ǂ���瓯���悤�ȕ����ł��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�����悤�ȁH");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�͂��B�������̕����Ɠ������̎����ł��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�ł��Ȃ񂾂��A����������a���Ƃ������c�c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        soundMan.isDoorClose = true;
        uitext.DrawText("�o�^���I");
        yield return StartCoroutine("Skip");

        blueRoomDoor1.SetActive(true);
        blueRoomDoor2.SetActive(true);
        blueRoomDoor3.SetActive(true);
        blueRoomDoor4.SetActive(false);
        blueRoomDoor5.SetActive(true);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�H�I");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�ʘH���ǂ��ꂽ�H�I");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�n�J��������I");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�n�J��������H�I");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�Ԏ����Ȃ��c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�ǂ��ɂ���������o�Ȃ��Ɓc");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        blueRoomStatue.isKinematic = false;
        blueRoomChair.isKinematic = false;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomDeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�s���R�ȐՂ�����");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomBedStory1()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�s���R�ȏ��͖���");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomBedStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�s���R�ȏ��͖������");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomBedStory3()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�s���R�ȏ��͖����c��c�H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomBedStory4()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        fadeIn.fadeOutFlag = true;
        girl.SetActive(true);
        uitext.DrawText("�\��", "�悭������x�b�h�̉��Ɂc�m�[�g�H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        blueRoomBook.SetActive(true);
        playermove.blueRoomFlag = true;

        fadeIn.fadeFlag = true;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomBedStory5()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�s���R�ȏ��͖���");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomBookShefStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�w�̍����{�I����");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomLeverStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("�T���E�m�L���R�E���^���e");
        yield return StartCoroutine("Skip");

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomChairStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�s���R�ȏ��͖���");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomRoundDeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�s���R�ȏ��͖���");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomStatueStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�s���R�ȏ��͖���");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoom2RoundDeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�s���R�ȐՂ�����");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoom2BedStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�s���R�ȏ��͖���");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoom2LeverStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        fadeIn.fadeOutFlag = true;
        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�c�߂����H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);
        boyTeleport.SetPosition(-123.8f, 106f);

        resetroom.resetButtonPushed = true;
        vase1.SetActive(true);
        vase2.SetActive(false);
        statueCollision.Init();
        chairCollision.Init();
        playermove.blueRoomBedCount = 0;
        blueRoomBook.SetActive(false);
        playermove.blueRoomFlag = false;
        boymove.blueChairFlag = false;
        boymove.blueStatueFlag = false;
        boymove.blueRoomFlag = false;

        fadeIn.fadeFlag = true;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoom2StatueStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�񂟁A���ꓮ������̂��c�������c�c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoom2ChairStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "����������Ȃ�");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoom2DeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�s���R�ȏ��͖���");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }
    IEnumerator blueRoom2BookShefStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�ł������{�I���ȁc");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���ł��㕔�Ɏ肪�͂��˂�");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoom2StatueStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�����ł����̂��c�H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boymove.blueStatueFlag = true;
        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoom2ChairStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        fadeIn.fadeOutFlag = true;
        boy.SetActive(true);
        uitext.DrawText("�n�J��", "����œ͂����c�H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);
        vase1.SetActive(false);
        vase2.SetActive(true);

        boymove.blueChairFlag = true;

        fadeIn.fadeFlag = true;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator openBlueRoomStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        fadeIn.fadeOutFlag = true;
        uitext.DrawText("�K�`�����I");
        yield return StartCoroutine("Skip");
        blueRoomDoor1.SetActive(false);
        blueRoomDoor2.SetActive(false);
        blueRoomDoor3.SetActive(false);
        blueRoomDoor4.SetActive(false);
        blueRoomDoor5.SetActive(false);

        boyTarget.followFlag2 = true;

        playermove.changeCharaFlag = false;
        mainCamera.SetActive(true);
        subCamera.SetActive(false);

        playerTeleport.SetPosition(-123.8f, 106f);
        if (boyTarget.followFlag2 == true)
        {
            boyTeleport.SetPosition(-121.8f, 106f);
        }

        fadeIn.fadeFlag = true;

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�\���I�������������H�I");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�ǂ������I�n�J������������ł��˂�");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�ɂ��Ă��c��������ȕ�����������");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�ł��A�ǂ��ɂ���ɐi�߂����ł���");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        whiteMistObject.SetActive(true);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator whiteMistStory1()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);
        investigate2.SetActive(false);

        uitext.DrawText("��������", "�₟�A����l����B������Ƃ������ȁH");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("�\��", "�ӂ����A�ȁA�Ȃ�ł����c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("��������", "���݂������Ƃ�����񂾂��ǂ��肢�o���Ȃ����ȁH");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���O�́c�l�A�Ȃ̂��H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("��������", "�����A���H�ǂ����낤�ˁB����܂�o���Ă��Ȃ��񂾁B");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�f���̒m��Ȃ��z�̗��݂͂Ȃ��c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�n�J������A�G�ӂ͖����悤�Ɋ�����̂ŁA�����Ă����܂��񂩁H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�񂟁A�܂��ǂ����B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("��������", "���肪�Ƃ��B����łˁB");
        yield return StartCoroutine("Skip");

        uitext.DrawText("��������", "���͂ǂ����A�ƂĂ���؂Ȃ��Ƃ�Y��Ă���݂����łˁB");
        yield return StartCoroutine("Skip");

        uitext.DrawText("��������", "�N���Ɉ��������������Ă��Ƃ����͕������Ă���񂾂��ǁA���̐l�̖��O���A����ǂ��납�����̖��O������Y��Ă��܂��ĂˁB");
        yield return StartCoroutine("Skip");

        uitext.DrawText("��������", "�������Ȃ��玄�͂��̎�p�����瓮���Ȃ��݂����Ȃ񂾁B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("��������", "������N�����ɂ���`���𗊂񂾂񂾁B");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�n����I�Ȋ������H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("��������", "�����Ȃ̂��ȁH�悭�킩��Ȃ���B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("��������", "����łˁA�����̊��ɕK�v�ȕ��������Ă�Ǝv������B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("��������", "�����ɏ����Ă�����𗊂�ɖl�����҂Ȃ̂��T���ė~�����񂾁B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("��������", "�������������Ă��C�ɂ��Ȃ����炳�A�ܘ_����������B");
        yield return StartCoroutine("Skip");

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator whiteMistStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("��������", "���͂ǂ����A�ƂĂ���؂Ȃ��Ƃ�Y��Ă���݂����łˁB");
        yield return StartCoroutine("Skip");

        uitext.DrawText("��������", "�N���Ɉ��������������Ă��Ƃ����͕������Ă���񂾂��ǁA���̐l�̖��O���A����ǂ��납�����̖��O������Y��Ă��܂��ĂˁB");
        yield return StartCoroutine("Skip");

        uitext.DrawText("��������", "�������Ȃ��玄�͂��̎�p�����瓮���Ȃ��݂����Ȃ񂾁B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("��������", "������N�����ɂ���`���𗊂񂾂񂾁B");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�n����I�Ȋ������H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("��������", "�����Ȃ̂��ȁH�悭�킩��Ȃ���B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("��������", "����łˁA�����̊��ɕK�v�ȕ��������Ă�Ǝv������B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("��������", "�����ɏ����Ă�����𗊂�ɖl�����҂Ȃ̂��T���ė~�����񂾁B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("��������", "�������������Ă��C�ɂ��Ȃ����炳�A�ܘ_����������B");
        yield return StartCoroutine("Skip");

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator opeRoomDeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "����A�w���؂��H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����݂����ł��ˁB���O�́c���h�肳��Ă�݂����ł��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "A-1�H������̃N���X�Ƃ����H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�Ƃ������Ƃ́A��x�����ɖ߂��Ă݂��ق��������ł��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        playermove.classRoom1StoryFlag = true;
        classRoom1TeachDeskObj.SetActive(true);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator classRoom1MisteryStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���[�A������A-1�������̂��B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���A�e�ɂ͏\�����ӂ��Ă��������ˁH");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator classRoom1MisteryStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����߂Ɋւ��钲���c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���������A�Ȃ񂾂��ł��[�������ȁc");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("A-1�S�C�����̂����ߒ�������");
        yield return StartCoroutine("Skip");

        uitext.DrawText("A�F�uC�N�͉R��t���Ă��܂��B�v");
        yield return StartCoroutine("Skip");

        uitext.DrawText("B�F�uA����͖{���̂��Ƃ������Ă��܂��B�v");
        yield return StartCoroutine("Skip");

        uitext.DrawText("C�F�u���̃N���X�ɂ����߂͖����Ǝv���܂��B�v");
        yield return StartCoroutine("Skip");

        uitext.DrawText("D�F�uC�N�������߂Ă��錻���ڌ����܂����B�v");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�{�l�͔۔F���Ă��邪�AC�������߂����Ă����\���͔��ɍ����Ǝv���B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("C�ɂ͑R��ׂ��������l���悤�B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�������Ȃ���A���̒S������N���X�ł��̗l�Ȏ��Ԃ͋����������B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("���N���X�̒S�������Ƀo����ƐF�X�ƌ����������邾�낤�B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("���̘b�͎��̓ƒf�ŉ��������������􂩁[�B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("���ꂮ������̂��Ƃ��o���Ȃ��l�Ɏ��̃f�X�N�Ɂc�A");
        yield return StartCoroutine("Skip");

        uitext.DrawText("����A�E�����ł͐l�ڂɕt���߂��邩�H");
        yield return StartCoroutine("Skip");

        uitext.DrawText("����ʂ̉B���ꏊ��T���Ƃ��āA��U�͈����o���ɉB�����������c�B");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�����炳�܂ɁA����C���Ă̂��Ɛl�Ȃ̂��H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�F���񂻂�ȕ��ɏ،����Ă��܂��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�ɂ��Ă��Ӗ��[�ȃ������Ȃ����B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���̐搶�͉������B���Ă�݂��������B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�c���̂����ߒ������������ł͏�񂪏��Ȃ����܂��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���ȁB���ɂ������������A�G�Ȃ����ׂ邵���˂��ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        classRoom1A.SetActive(true);
        classRoom1B.SetActive(true);
        classRoom1C.SetActive(true);
        classRoom1D.SetActive(true);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator A_DeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("����A�̌��t�����ꍞ��ł���");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�uC�N�͂������F�̐l�C�ҁB�v");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�u���������āA�����d���ו����^��ł鎞�A�������킸�ɕς���Ă��ꂽ�́B�v");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "����A����A���Ă������̏،��̐l����ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "C�͗ǂ���ł͂������݂ā[���ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        A_DeskStoryFlag = true;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator B_DeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("����B�̌��t�����ꍞ��ł���");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�uC�N���Đ�����ˁB�Ȃ�Č������A���������H�v");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�u���`���������Ă�����������ˁB����ŗǂ��搶�ƌ��_���Ă邱�Ƃ����邯�ǁB�v");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�搶�ƌ��_���`�A�����̂͌����������Ȃ��B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���O�͂���Ȗ����킩��ˁ[�̂����Ăǂ₳��Ă�B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���w�Z�ʂ��Ė�����������d���˂�������Č����Ă��Â������Č����񂾂��H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���Ȃ�Ɋ撣���Ă��񂾂��ǂȂ��B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�n�J�����񏬊w�Z�s���Ė���������ł����H����c�����Ȃ������ǂ����Ƃ�����܂���ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�C�ɂ���ȁH���������A������������e�ɗǂ��v���Ė����ĂȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "10�˂̎��ɂ΂������Ɉ�������Ă�������񂾁B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "������������ł��ˁc");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        B_DeskStoryFlag = true;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator C_DeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("����C�̌��t�����ꍞ��ł���");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�u���̑O�������q���獐�������ꂽ�񂾁B�v");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�u�ܘ_�f�������ǁA�܂����[�����ɓ{���邩�ȁB�v");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�񂟁H�Ȃ񂾂��������b����˂����B�����B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�n�J��������Ă��������ă��e�Ȃ���ł����H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�c���邹���B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        C_DeskStoryFlag = true;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator D_DeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("����D�̌��t�����ꍞ��ł���");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�u���̑O�A�����Ȃ�搶�ɉ����|����āc�B�v");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�u���̎�C�N���ٕςɋC�t���Ă���Ȃ������玄�c�B�v");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���A��ׂ��搶�����B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "C���~�������Ă��Ƃ��c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����ł��ˁc");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�Ȃ�[����A����C���Ɛl���Ƃ��Ă��B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���̔�Q�ґ��������΂˂��񂾂�ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "������O�����ǁA�����߂��Ă͔̂�Q�҂����ď��߂Đ��藧��ȁc");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        D_DeskStoryFlag = true;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator DeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�e�����ׂ����H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����c�ł��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�ł��A�ǂ�����̔���������������Ɋւ�����Ȃ̂�������܂���ˁc");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�\���̓A�C�c�̂��Ɓh����������������h���ČĂ�ł�̂���");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�J���C�[�Ƃ�����̂Ȃ�");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�I");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "��A�����ł������I�H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "����c���ǂ��񂾂��ǁc��������");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "����Ȃ��Ƃǁ[�ł������ł�����B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "������|�����T���Đ�ɐi�݂܂���m���f������B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�����������āc�B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "��Łc�c�A�ǁ[�������B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����ł��ˁB���߂Ė��O�Ƃ���������΁c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���������΁A�E�����ɉB���Ƃ������Ă���܂�����ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�������₻���������ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "��ł��A�E�������A�q�����Ă����ȏꏊ���B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���܂Ō��Ă�����������������ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���܂Ō��Ă�������͂����ł����ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�ł��A���̓V���̗͂��A��������ς���Ă�\���͍����ł��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�T���������A���c�B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���C�o���Ă��������n�J�������");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�������̐��E���琶���ċA�鎖���o�������l�Ŕ����������ł��H�ׂɍs���܂��傤�I");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�͂͂��c�B�����ċA�ꂽ��ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        teacherRoomDoor.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator teacherRoomStory1()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "������I�܂�������ȏꏊ�����Ă��̂��c�B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���āA�����܂��ɐE�����c���H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����݂����ł����");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�Ȃ�̃q���g�������ɐV�����ꏊ�T���͍̂����܂ꂽ�ȁc");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator teacherDeskStory1()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("�ǂ����ڂ��ꂽ�Y��ȃf�X�N���B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�����o���̒��̓t�@�C���Ŗ��܂��Ă���B");
        yield return StartCoroutine("Skip");

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator teacherDeskStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("���G�ɕ����u����Ă���B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�����o���̒��������Ⴎ���Ⴞ�B");
        yield return StartCoroutine("Skip");

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator teacherDeskStory3()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("���X�ɉ��ꂪ�ڗ������ڂ���Ă���B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�����o���̒��̓t�@�C���Ŗ��܂��Ă���B");
        yield return StartCoroutine("Skip");

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator teacherDeskStory4()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("�ꌩ���ڂ���Ă���悤�Ɍ����邪�A���̕��Ɏ��������Ⴎ����ɋl�ߍ��܂�Ă���B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�����o���̒��́c�Ȃ񂾂������o���������B");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�񂟁H�c�Ȃ��\���B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�����̈����o�������A�����ꂪ�󂭂˂����H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�{���ł��ˁB�����~�X���A�^���Â��Ƃ��ł����H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���A���[��[�̂͑��c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "����ς�A��d�ꂾ�B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�I");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����ł��ˁI�Ȃ�ł킩������ł����H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "��܂��A�������̂̉f��Ƃ��ł悭�g���Ă��@�Ȃ񂾂�ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�f���Ɋ֐S���܂��B�@���͈����̂ɂ��������̋C�t�����ł��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���邹���B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���ꂪ�c���̐搶���B���������Ă������̂ł����c���āH�I");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�c���I�n�J�����񌩂Ȃ��ł����������I");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�񂥁A�Ȃ�Łc");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "����A���B�ʐ^�ł��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�c����ς�ׂ��搶�����B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�Ȃ̂Ńn�J������͂���ǂ�łĂ��������B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�񂧁B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�������ƁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("���ɋ��t�̌��t�����ꍞ��ł���");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�u�L�^�~ �A�c�g�A�����͉��̂���Ȃɂ����q���k����l�C�Ȃ̂������ł���B�v");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�u�m���ɑ����炪�ǂ��̂����m��񂪁c�������B�v");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�u�����͉����Ǝ��̎�̎ז�������B�`�N���Ă��Ȃ��̂����߂Ă��̋~�����B�v");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�u�ǂ��ɂ�������r���o����΁A���̃N���X�͎��̍D���ɏo����̂����ȁB�v");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�u�ӂށA�����ߒ����A���P�[�g�̎��{���A�܂��ʓ|�Ȃ��Ƃ��B�v");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�u����A�������I���ꂾ���I�v");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�u���̂����ߒ����𗘗p���Ă������ׂ�Ă�낤�B�v");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�u�ז�������Ȃ���Ύ��́c�v");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�H�ǂ����܂����H�ǂ߂܂����H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�񂟁A�����A�ǂ܂Ȃ��Ă��ǂ߂��B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        fadeIn.fadeOutFlag = true;

        girl.SetActive(true);
        uitext.DrawText("�\��", "�ǂ��������Ƃł����B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeFlag = true;

        girl.SetActive(true);
        uitext.DrawText("�\��", "�Ȃ�قǁBC�̖��O�̓L�^�~ �A�c�g���Č�����ł��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�����B��ŁA���̐��E�Ŗ��O�����ꂽ�L�^�~���Ă����(��������)�ŊԈႢ�����񂶂�˂����H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�c�H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "������񌾂��Ă�����Ă��ǂ��ł����H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�񂦁c������L�^�~���Ă���h�ށh�Ȃ񂶂�˂��̂��āB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�n�J������c�c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�ǂ����āc�h�ށh�Ȃ�ł����H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���������̐l�Ƃ��Ă̊O���͕�����Ȃ����A������l�̂́h���h�ł�����ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���ʂȂ玄�Ƃ�����l�̂Ŋw���Ȃ�T�ˏ�����z������Ǝv���̂ł����B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���[�[�A���ꂾ��B��������ꂽ�񂾂��āB���́c�A�c�g���Ēj�������O�o�Ă˂����炳�B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "��荇�����A�߂��ĕ����Ă݂悤���H���̖��O�Ɋo���͖��������Ă��B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "��U�߂�܂��B�ł��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�n�J������͐�Ή������B���Ă��܂��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���ɂ́c�n�J�����񂪈����l�ɂ͌����Ȃ��̂ŁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "��Ő�΁A�b���Ă��������ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�B�����́c���܂�D������Ȃ��ł��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�c�c�����B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator whiteMistStory3()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�߂�܂����B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("��������", "�₟�A����l����B�����l�B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("��������", "�������͓���ꂽ�����H");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����ƁA�L�^�~ �A�c�g������ĕ��̖��O������܂����B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("��������", "�A�c�g�c�A�A�c�g�B");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("�\��", "��͂�A�M���̖��O�ł͖����ł���ˁc");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("��������", "�c�c�c�����B");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("�\��", "���H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("��������", "����A�l���B�A�c�g�͖l�̖��O����B");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("�A�c�g", "���肪�Ƃ��B�܂��A�N������Ȃ�����ǁA�m���ɖl�̓A�c�g���B");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("�\��", "������������ł��˂��B�����ƁA���������͋M���������ɔ����Ă��闝�R��������΁c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("�A�c�g", "�������ˁc");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "��������\���A�܂��T���ɍs�����H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����ł��ˁB���͂ǂ���T���܂��傤���c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("�A�c�g", "�c�c�\���c�c�c�H");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("�\��", "�H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("�A�c�g", "�\���c�c�A�������B�����������񂾂ˁB");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("�\��", "�H�H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("�A�c�g", "�����������񂾂ˁc�c�B");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("�\��", "���H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("�A�c�g", "������A���߂�ˁB�������̘b�B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�A�c�g", "�ł��A����œ�l���܂��T���ɍs���K�v�͖����Ȃ�������B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�A�c�g", "���肪�Ƃ��ˁA����������A�����Ɩ��ɗ���B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�����̃������󂯎�����B");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����ƁA�ǂ��������Ƃł����H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("�A�c�g", "�������߂�B�C�ɂ��Ȃ��ŁB�����l�̖ړI���B������āA�l�͖����ɐ����o�������Ȃ񂾁B");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�A�c�g", "���ꂩ�炳�A�l�͂��������������Ⴄ�Ǝv���񂾂��ǂˁB");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�A�c�g", "���ꂾ�������Ă��������ȁB");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("�\��", "�H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeOutFlag = true;
        uitext.DrawText("�A�c�g", "�Ō�ɂ܂���Ċ�������B���Ⴀ�ˁB���[�����B");
        yield return StartCoroutine("Skip");

        whiteMistObject.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�I");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeFlag = true;

        uitext.DrawText("���������͂��������Ȃ��B");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�c�c�c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�\���c�H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�I");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�n�J������c�c�ǂ����Ă��v���o���Ȃ���ł��A");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�v���o���Ă������Ȃ���ł����ǁc");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���̂����܂��~�܂�Ȃ���ł��c�c�c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeOutFlag = true;

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�c�c�c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        fadeIn.fadeFlag = true;

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�������v�Ȃ̂��c�H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�͂��c�������v�ł��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�c�c���X�C�Â��Ă͋�����ł��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����Ǝ��͂������̋L���������Ă��܂��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�L���������āA���̂������ɋ��܂��c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�i�݂܂��傤�B�����ɋ��Ă��n�܂�Ȃ��ł�����B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�����c���ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����������������ł��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("�[�[�[�V���ɂ��Ă̌��������[�[�[");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�u���̓V���A�������������Ǝv���Ă��񂾁B�ǂ���炱�̓V���͊肢��������Ή���v�����Ă���B�v");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�u�Ԉ���Ă����ґh���Ȃ�Ė]�ނ񂶂�Ȃ��A�N�������ʂ��ƂɂȂ�B�v");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("�\��", "����ς�c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���̓V���Ɏ������������B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�V�����ꏊ�ɍs����l�ɂȂ����Ή��Ƃ��āA�O�ɍs�����ꏊ�ɍs���Ȃ���ł��ˁc");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�Ȃ�قǂȂ��c�A�ł��Ȃ�ł���͓V���Ȃ񂾁H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�V�����ā[�ƁA���E�ɒu�������̂̏d�����ׂ���̂���B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����ł��ˁB�����������炻�ꂪ�Ή���v�����Ă���Ӗ��Ȃ̂����m��Ȃ��ł��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�H�H�H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�[���͎����킩��܂���B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�e�Ɋp�A��ɐi�ނɂ��뎟�ɏo����藧�Ă������Ȃ����Ⴂ�܂����ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�����Ȃ邤���͂�����x�V�����c�c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�c�c�c�����ł��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�ǂ�ȑΉ���v������邩���O�ɂ͕�����܂��񂪁A���Ȃ��Ƃ��Γ��Ȃ��̂�v�����Ă���l�Ɋ����܂��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�O��Ɠ����悤�ɁA��������Ȃ��A�����̕ω���]�߂�l�ȁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "���̂��炢�̂��肢�����ɁA�s���Ă݂邵�������ł��ˁB");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeOutFlag = true;
        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�s�������B�V���̂����������B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        playerTeleport.SetPosition(-70.17f, 219.09f);
        boyTeleport.SetPosition(-68.17f, 219.09f);

        fadeIn.fadeFlag = true;

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���ĂƁc�c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "��������̂Ȃ��肢���˂��c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        fadeIn.fadeOutFlag = true;

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�ǂ�����H�\���B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�����ł��ˁc�c�c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�c�c�c");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�񂟁`�A����ܓ���l����ȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���O�̗����Ȉӌ��ł����B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�킩��c�c�܂����B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeFlag = true;
        
        girl.SetActive(true);
        uitext.DrawText("�\��", "���܂Ō����Ă����ꏊ���A�܂������Ȃ��Ȃ����Ƃ��Ă��B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("�\��", "�������́c�c�c��ɐi�݂����B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        fadeIn.fadeInOutFlag = true;
        cameraRotateFlag = true;
        Canbus.SetActive(true);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�������ȁc�c�c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);
        fadeIn.fadeOutFlag = true;


        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�������͐�ɐi�ނ����˂��B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boyTarget.followFlag2 = false;
        playerChange.moveFlag = true;

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�s���\���A�\���B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girlObject.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�c�\���H");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);


        fadeIn.fadeFlag = true;

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "������������V���c�c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�c�c�c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "����c�\���̑��݂��������܂����\���͒Ⴂ�B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�V���̗v������Ή����Γ��ȕ����Ƃ��āB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�\���̑��݂�������قǂ̗v�����������͂��Ă��Ȃ��B");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�����������ł͂Ȃ��\�������������Ƃ��l����Ɓc");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���݂����A�����Ȃ��Ȃ��Ă���\�����������c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�������A�\���c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�����ł��Ă���c�c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        fadeIn.fadeOutFlag = true;

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���O�̉ߋ����ɂ݂������c�c�c");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        fadeIn.fadeFlag = true;

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "�\���ׂ̈ɂ��A�����E�o�̎����������˂��ƂȁB");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("�n�J��", "���ĂƁA���ɍs����ꏊ�͂ǂ����`");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (TextNum == 0)
        {
            gameStop.stopFlag = true;
            StartCoroutine("RooftopStory");
            TextNum = 1;

            //���Ƃŏ���
            //fadeIn.fadeFlag = true;
            //playerTeleport.SetPosition(-6.25f, 156.93f);
            //boyTeleport.SetPosition(-4.25f, 156.93f);
        }
        if (TextNum == 1 && cameraMove1.endFlag == true)
        {
            StartCoroutine("RooftopStory2");
            TextNum = 2;
        }
        //�h�A�ɐG�ꂽ�Ƃ�
        if (TextNum == 3)
        {
            gameStop.stopFlag = true;
            StartCoroutine("doorStory1");
            TextNum = 4;
        }
        //��ɐG�ꂽ�Ƃ�
        if(TextNum == 5)
        {
            gameStop.stopFlag = true;
            StartCoroutine("fenceStory1");
            TextNum = 6;
        }
        //�h�A�ɐG�ꂽ�Ƃ��Q
        if(TextNum == 7)
        {
            gameStop.stopFlag = true;
            StartCoroutine("doorStory2");
            TextNum = 8;
        }
        //�����̃X�g�[���[
        if(TextNum == 9)
        {
            gameStop.stopFlag = true;
            StartCoroutine("hospitalStory");
            TextNum = 10;
        }
        if(TextNum == 11)
        {
            gameStop.stopFlag = true;
            StartCoroutine("hospitalStory2");
            TextNum = 12;
        }
        if(TextNum == 13)
        {
            gameStop.stopFlag = true;
            StartCoroutine("entranceDoorStory");
            TextNum = 14;
        }
        if(TextNum == 15)
        {
            gameStop.stopFlag = true;
            StartCoroutine("operatingDoorStory");
            TextNum = 16;
        }
        if(TextNum == 17)
        {
            gameStop.stopFlag = true;
            StartCoroutine("ironDoorStory");
            TextNum = 18;
        }
        if(TextNum == 19)
        {
            gameStop.stopFlag = true;
            StartCoroutine("classroomStory");
            TextNum = 20;
        }
        if(TextNum == 21)
        {
            gameStop.stopFlag = true;
            StartCoroutine("classroomStory2");
            TextNum = 22;
        }
        if(TextNum == 23)
        {
            gameStop.stopFlag = true;
            StartCoroutine("desk1Story");
            TextNum = 24;
        }
        if(TextNum == 25)
        {
            gameStop.stopFlag = true;
            StartCoroutine("classroomStory2_1");
            TextNum = 26;
        }
        if(TextNum == 26)
        {
            gameStop.stopFlag = true;
            StartCoroutine("enemyShowStory");
            TextNum = 1000000000;
        }
        if(TextNum == 27)
        {
            gameStop.stopFlag = true;
            StartCoroutine("EnemyStory");
            TextNum = 28;
        }
        if(TextNum == 29)
        {
            gameStop.stopFlag = true;
            StartCoroutine("BlackBoardStory");
            TextNum = 30;
        }
        if(TextNum == 31)
        {
            gameStop.stopFlag = true;
            StartCoroutine("BlackBoardStory2");
            TextNum = 32;
        }
        if (TextNum == 33)
        {
            gameStop.stopFlag = true;
            StartCoroutine("BlackBoardStory3");
            TextNum = 34;
        }
        if(TextNum == 35)
        {
            gameStop.stopFlag = true;
            StartCoroutine("openOperoomStory");
            TextNum = 36;
        }
        if(TextNum == 37)
        {
            gameStop.stopFlag = true;
            StartCoroutine("operoomStory");
            TextNum = 38;
        }
        if(TextNum == 39)
        {
            gameStop.stopFlag = true;
            StartCoroutine("ironDoorStory2");
            TextNum = 40;
        }
        if(TextNum == 41)
        {
            gameStop.stopFlag = true;
            StartCoroutine("boyClassroom1Story");
            TextNum = 42;
        }
        if(TextNum == 43)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blackBoard1_2Story");
            TextNum = 44;
        }
        if(TextNum == 45)
        {
            gameStop.stopFlag = true;
            StartCoroutine("boyBlackBoard1_2Story");
            TextNum = 46;
        }
        if(TextNum == 47)
        {
            gameStop.stopFlag = true;
            StartCoroutine("ironOpenDoorStory");
            TextNum = 48;
        }
        if(TextNum == 49)
        {
            gameStop.stopFlag = true;
            StartCoroutine("room4Story");
            TextNum = 50;
        }
        if (TextNum == 51)
        {
            gameStop.stopFlag = true;
            StartCoroutine("room6Story");
            TextNum = 52;
        }
        if (TextNum == 53)
        {
            gameStop.stopFlag = true;
            StartCoroutine("undergroundStory");
            TextNum = 54;
        }
        if(TextNum == 55)
        {
            gameStop.stopFlag = true;
            StartCoroutine("upRightStory1");
            TextNum = 56;
        }
        if(TextNum == 57)
        {
            gameStop.stopFlag = true;
            StartCoroutine("upRightStory2");
            TextNum = 58;
        }
        if(TextNum == 59)
        {
            gameStop.stopFlag = true;
            StartCoroutine("DialStory");
            TextNum = 60;
        }
        if(TextNum == 61)
        {
            gameStop.stopFlag = true;
            StartCoroutine("balanceroomStory");
            TextNum = 62;
        }
        if(TextNum == 63)
        {
            gameStop.stopFlag = true;
            StartCoroutine("room0Story1");
            TextNum = 64;
        }

        if(enemyTarget.StoryFlag == true && TextNum == 64)
        {
            gameStop.stopFlag = true;
            StartCoroutine("room0Story2");
            enemyTarget.StoryFlag = false;
            TextNum = 65;
        }

        if(TextNum == 66)
        {
            gameStop.stopFlag = true;
            StartCoroutine("wallStory1");
            TextNum = 67;
        }

        if (TextNum == 68)
        {
            gameStop.stopFlag = true;
            StartCoroutine("wallStory2");
            TextNum = 69;
        }

        if (TextNum == 70)
        {
            gameStop.stopFlag = true;
            StartCoroutine("wallStory3");
            TextNum = 71;
        }

        if (TextNum == 72)
        {
            gameStop.stopFlag = true;
            StartCoroutine("wallStory4");
            TextNum = 73;
        }

        if (TextNum == 74)
        {
            gameStop.stopFlag = true;
            StartCoroutine("wallStory5");
            TextNum = 75;
        }

        if (TextNum == 76)
        {
            gameStop.stopFlag = true;
            StartCoroutine("wallStory6");
            TextNum = 77;
        }

        if (TextNum == 78)
        {
            gameStop.stopFlag = true;
            StartCoroutine("wallStory7");
            TextNum = 79;
        }

        if (TextNum == 80)
        {
            gameStop.stopFlag = true;
            StartCoroutine("wallStory8");
            TextNum = 81;
        }
        if(TextNum == 82)
        {
            gameStop.stopFlag = true;
            StartCoroutine("room0backHomeStory");
            TextNum = 83;
        }
        if(TextNum == 84)
        {
            gameStop.stopFlag = true;
            StartCoroutine("undergroundStory2");
            TextNum = 85;
        }
        if(TextNum == 86)
        {
            gameStop.stopFlag = true;
            StartCoroutine("operoom45Story");
            TextNum = 87;
        }
        if(TextNum == 88)
        {
            gameStop.stopFlag = true;
            StartCoroutine("operoom45Story2");
            TextNum = 89;
        }
        if(TextNum == 90)
        {
            gameStop.stopFlag = true;
            StartCoroutine("operoom45Story3");
            TextNum = 91;
        }
        if(TextNum == 92)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueButtonRoom");
            TextNum = 93;
        }
        if(TextNum == 94)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueButtonRoomStory1");
            TextNum = 95;
        }
        if(TextNum == 96)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueButtonRoomStory2");
            TextNum = 97;
        }
        if(TextNum == 98)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomDeskStory");
            TextNum = 99;
        }
        if(TextNum == 100)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomBedStory1");
            TextNum = 101;
        }
        if (TextNum == 102)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomBedStory2");
            TextNum = 103;
        }
        if (TextNum == 104)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomBedStory3");
            TextNum = 105;
        }
        if (TextNum == 106)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomBedStory4");
            TextNum = 107;
        }
        if (TextNum == 108)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomBedStory5");
            TextNum = 109;
        }
        if(TextNum == 110)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomBookShefStory");
            TextNum = 111;
        }
        if(TextNum == 112)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomLeverStory");
            TextNum = 113;
        }
        if(TextNum == 114)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomChairStory");
            TextNum = 115;
        }
        if(TextNum == 116)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomRoundDeskStory");
            TextNum = 117;
        }
        if(TextNum == 118)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomStatueStory");
            TextNum = 119;
        }
        if (TextNum == 120)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoom2RoundDeskStory");
            TextNum = 121;
        }
        if (TextNum == 122)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoom2BedStory");
            TextNum = 123;
        }
        if (TextNum == 124)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoom2LeverStory");
            TextNum = 125;
        }
        if (TextNum == 126)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoom2StatueStory");
            TextNum = 127;
        }
        if (TextNum == 128)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoom2ChairStory");
            TextNum = 129;
        }
        if (TextNum == 130)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoom2DeskStory");
            TextNum = 131;
        }
        if (TextNum == 132)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoom2BookShefStory");
            TextNum = 133;
        }
        if(TextNum == 134)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoom2StatueStory2");
            TextNum = 135;
        }
        if(TextNum == 136)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoom2ChairStory2");
            TextNum = 137;
        }
        if(TextNum == 138)
        {
            gameStop.stopFlag = true;
            StartCoroutine("openBlueRoomStory");
            TextNum = 139;
        }
        if(TextNum == 140)
        {
            gameStop.stopFlag = true;
            StartCoroutine("whiteMistStory1");
            TextNum = 141;
        }
        if (TextNum == 142)
        {
            gameStop.stopFlag = true;
            StartCoroutine("whiteMistStory2");
            TextNum = 143;
        }
        if(TextNum == 144)
        {
            gameStop.stopFlag = true;
            StartCoroutine("opeRoomDeskStory");
            TextNum = 145;
        }
        if(TextNum == 146)
        {
            gameStop.stopFlag = true;
            StartCoroutine("classRoom1MisteryStory");
            TextNum = 147;
        }
        if(TextNum == 148)
        {
            gameStop.stopFlag = true;
            StartCoroutine("classRoom1MisteryStory2");
            TextNum = 149;
        }
        if(TextNum == 150)
        {
            gameStop.stopFlag = true;
            StartCoroutine("A_DeskStory");
            TextNum = 151;
        }
        if (TextNum == 152)
        {
            gameStop.stopFlag = true;
            StartCoroutine("B_DeskStory");
            TextNum = 153;
        }
        if (TextNum == 154)
        {
            gameStop.stopFlag = true;
            StartCoroutine("C_DeskStory");
            TextNum = 155;
        }
        if (TextNum == 156)
        {
            gameStop.stopFlag = true;
            StartCoroutine("D_DeskStory");
            TextNum = 157;
        }
        if(TextNum == 158)
        {
            gameStop.stopFlag = true;
            StartCoroutine("DeskStory");
            TextNum = 159;
        }
        if(TextNum == 160)
        {
            gameStop.stopFlag = true;
            StartCoroutine("teacherRoomStory1");
            TextNum = 161;
        }
        if(TextNum == 162)
        {
            gameStop.stopFlag = true;
            StartCoroutine("teacherDeskStory1");
            TextNum = 163;
        }
        if (TextNum == 164)
        {
            gameStop.stopFlag = true;
            StartCoroutine("teacherDeskStory2");
            TextNum = 165;
        }
        if (TextNum == 166)
        {
            gameStop.stopFlag = true;
            StartCoroutine("teacherDeskStory3");
            TextNum = 167;
        }
        if (TextNum == 168)
        {
            gameStop.stopFlag = true;
            StartCoroutine("teacherDeskStory4");
            TextNum = 169;
        }
        if(TextNum == 170)
        {
            gameStop.stopFlag = true;
            StartCoroutine("whiteMistStory3");
            TextNum = 171;
        }

        if (A_DeskStoryFlag == true && B_DeskStoryFlag == true && C_DeskStoryFlag == true && D_DeskStoryFlag == true && DeskStoryFlag == false)
        {
            TextNum = 158;
            DeskStoryFlag = true;
        }

        if (playermove.blueRoomFlag == true && boymove.blueRoomFlag == true && openBlueRoomFlag == false)
        {
            TextNum = 138;
            openBlueRoomFlag = true;
        }
        //�_���[�W���󂯂��Ƃ��̏���
        if (password.isMiss == true)
        {
            gameStop.stopFlag = true;
            StartCoroutine("playerDamageStory");
            password.isMiss = false;
        }
        if(password.isGetKeyStory == true)
        {
            gameStop.stopFlag = true;
            StartCoroutine("playerGetKeyStory");
            password.isGetKeyStory = false;
        }

        if (password2.isMiss == true)
        {
            gameStop.stopFlag = true;
            StartCoroutine("playerDamageStory2");
            password2.isMiss = false;
        }
        if (password2.isGetKeyStory == true)
        {
            gameStop.stopFlag = true;
            StartCoroutine("playerGetKeyStory2");
            password2.isGetKeyStory = false;
        }


        if (cameraRotateFlag == true)
        {
            cameraRotateTimer++;
            if(cameraRotateTimer >120)
            {
                cameraRot.moveFlag = true;
                cameraRotatedFlag = true;
                cameraRotateFlag = false;
                cameraRotateTimer = 0;
            }
        }
        if (cameraRot.moveFlag == false && cameraRotatedFlag == true)
        {
            fadeIn.fadeInOutFlag = true;
            cameraRotatedFlag = false;
        }

        if(configFlag == true && inputAction_.Player.Talk.triggered)
        {
            config.SetActive(false);
            gameStop.stopFlag = false;
            configFlag = false;
        }
        if (config2Flag == true && inputAction_.Player.Talk.triggered)
        {
            config2.SetActive(false);
            gameStop.stopFlag = false;
            config2Flag = false;
        }

        //ToBeContinue
        if (gameEndFlag == true && inputAction_.Player.Talk.triggered)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
