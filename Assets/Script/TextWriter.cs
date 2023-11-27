using System.Collections;
using System.Collections.Generic;
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

    private bool configFlag;

    public GameObject config2;

    private bool config2Flag;

    private FadeIn fadeIn;

    private storyCameramove1 cameraMove1;

    private publicFlag gameStop;

    private PlayerDamage playerDamage;

    private PlayerTeleport playerTeleport;

    private hospitalPlayerSprite hospital;

    private playerGetItem playergetitem;

    private SoundManager soundMan;

    private Password password;
    private Password2 password2;
    private cameraRotate cameraRot;

    private EnemyTargetMove enemyTarget;

    //�l�`�������Ă��邩
    public bool dollGetFlag;
    public bool fenceStoryFlag;

    public int TextNum;

    //room0�����ł��ʂ������Ƃ����邩
    public bool room0FirstFlag;

    //�J������]
    private bool cameraRotateFlag;
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

        gameStop = GameObject.Find("GameManager").GetComponent<publicFlag>();

        playerDamage = GameObject.Find("player").GetComponent<PlayerDamage>();

        playerTeleport = GameObject.Find("player").GetComponent<PlayerTeleport>();

        hospital = GameObject.Find("playerShadow").GetComponent<hospitalPlayerSprite>();

        playergetitem = GameObject.Find("player").GetComponent<playerGetItem>();

        password = GameObject.Find("player").GetComponent<Password>();
        password2 = GameObject.Find("player").GetComponent<Password2>();

        cameraRot = GameObject.Find("player").GetComponent<cameraRotate>();

        enemyTarget = GameObject.Find("room0Enemy").GetComponent<EnemyTargetMove>();

        soundMan = GameObject.Find("Canvas").GetComponent<SoundManager>();

        TextNum = 0;
        fenceStoryFlag = false;
        boy_fear.SetActive(false);
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

        kirakira1.SetActive(true);
        kirakira2.SetActive(true);
        kirakira3.SetActive(true);
        kirakira4.SetActive(true);
        kirakira5.SetActive(true);
        kirakira6.SetActive(true);
        kirakira7.SetActive(true);
        kirakira8.SetActive(true);

        gameEndFlag = false;
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
        cameraMove1.effectFlag = false;

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
        uitext.DrawText("�h�A���J���Ă���B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("���ɓ��낤�B");
        yield return StartCoroutine("Skip");
        playerTeleport.SetPosition(5, 30);
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
        uitext.DrawText("����", "�I�I�I�I�I");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(false);
        playerTeleport.SetPosition(5, 30);

        gameStop.stopFlag = false;
        Canbus.SetActive(false);
    }

    IEnumerator BlackBoardStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        girl.SetActive(false);
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
        uitext.DrawText("�h�A���J�����l���B");
        yield return StartCoroutine("Skip");

        playerTeleport.SetPosition(-9.52f, 48.7f);

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

        room4goDoor.SetActive(false);
        soundMan.isOpenKey = true;
        uitext.DrawText("�S��̔����J�����B");
        yield return StartCoroutine("Skip");

        playerTeleport.SetPosition(19.36f, 48.51f);

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

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
        playerTeleport.SetPosition(36.26f, 157.14f);
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
        uitext.DrawText("�\��", "�i�ނׂ����������ĉ������B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeInOutFlag = true;
        cameraRotateFlag = true;
        Canbus.SetActive(false);

        //gameStop.stopFlag = false;
        gameEndFlag = true;
    }

    IEnumerator room0Story1()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);

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

        sewing.SetActive(true);
        soundMan.isGetItem = true;
        uitext.DrawText("�ٖD�������ɓ��ꂽ�B");
        yield return StartCoroutine("Skip");
        sewing.SetActive(false);

        playergetitem.sowingGet2 = true;

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

        enemyTarget.FirstFlag = true;
        Canbus.SetActive(false);
        gameStop.stopFlag = false;
        gameStop.playerDontMoveFlag = false;
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
            //playerTeleport.SetPosition(-9.89f, 219.28f);
            //TextNum = 53;
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

        if (inputAction_.Player.MoveRight.triggered)
        {
            //StartCoroutine("Syabetarou");
        }

        //ToBeContinue
        if (gameEndFlag == true && inputAction_.Player.Talk.triggered)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
