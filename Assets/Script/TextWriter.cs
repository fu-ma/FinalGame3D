using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextWriter : MonoBehaviour
{
    public UIText uitext;

    private PlayerInputSystem inputAction_;

    public GameObject girl;
    public GameObject girl_fear;
    public GameObject boy;
    public GameObject Canbus;
    public GameObject HP;
    public GameObject doll;
    public GameObject sewing;
    public GameObject rooftopEffect;
    public GameObject opeKey;
    private GameObject fadeInObj;
    private FadeIn fadeIn;

    private storyCameramove1 cameraMove1;

    private publicFlag gameStop;

    private PlayerDamage playerDamage;

    private PlayerTeleport playerTeleport;

    private hospitalPlayerSprite hospital;

    private playerGetItem playergetitem;

    private Password password;

    //�l�`�������Ă��邩
    public bool dollGetFlag;
    public bool fenceStoryFlag;

    public int TextNum;
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

        TextNum = 0;
        fenceStoryFlag = false;

        Canbus.SetActive(true);
        HP.SetActive(false);
        doll.SetActive(false);
        sewing.SetActive(false);
        rooftopEffect.SetActive(true);
        opeKey.SetActive(false);

        dollGetFlag = false;
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
        gameStop.stopFlag = false;
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
        uitext.DrawText("�ٖD�������ɓ��ꂽ�B");
        yield return StartCoroutine("Skip");
        //������sowingGet��true�ɂ��镶������
        playergetitem.sowingGet = true;

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

        fadeIn.fadeOutFlag = true;
        girl.SetActive(true);
        uitext.DrawText("����", "���c�A���c");
        yield return StartCoroutine("Skip");
        fadeIn.fadeFlag = true;
        girl.SetActive(false);
        uitext.DrawText("�����l�e�͋�������p�j���Ă���l���B");
        yield return StartCoroutine("Skip");

        gameStop.stopFlag = false;
        Canbus.SetActive(false);
    }

    IEnumerator EnemyStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        girl.SetActive(false);
        girl.SetActive(true);
        uitext.DrawText("����", "�I�I�I�I�I");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);
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
        girl_fear.SetActive(false);
        boy.SetActive(false);
        girl.SetActive(true);
        uitext.DrawText("����","�ɂ��I");
        yield return StartCoroutine("Skip");

        uitext.DrawText("����", "�Ԉ�������Ă��Ɓc�H");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator playerGetKeyStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        girl.SetActive(true);
        uitext.DrawText("����", "��H�����������悤�ȁc");
        yield return StartCoroutine("Skip");

        uitext.DrawText("����", "����c�����B");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        opeKey.SetActive(true);
        uitext.DrawText("��p���̌�����肵�܂����B");
        yield return StartCoroutine("Skip");
        opeKey.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(TextNum == 0)
        {
            gameStop.stopFlag = true;
            StartCoroutine("RooftopStory");
            TextNum = 1;
        }
        if(TextNum == 1 && cameraMove1.endFlag == true)
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
        //�_���[�W���󂯂��Ƃ��̏���
        if(password.isMiss == true)
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
        if (inputAction_.Player.MoveRight.triggered)
        {
            //StartCoroutine("Syabetarou");
        }
    }
}
