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
    public GameObject rooftopEffect;
    private GameObject fadeInObj;
    private FadeIn fadeIn;

    private storyCameramove1 cameraMove1;

    private publicFlag gameStop;

    private PlayerDamage playerDamage;

    private PlayerTeleport playerTeleport;

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

        TextNum = 0;
        fenceStoryFlag = false;

        Canbus.SetActive(true);
        HP.SetActive(false);
        doll.SetActive(false);
        rooftopEffect.SetActive(true);

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
    }

    IEnumerator RooftopStory2()
    {
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
    }
    IEnumerator doorStory1()
    {
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
    }

    IEnumerator fenceStory1()
    {
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
    }

    IEnumerator doorStory2()
    {
        girl.SetActive(false);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        uitext.DrawText("�h�A���J���Ă���B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("���ɓ��낤�B");
        yield return StartCoroutine("Skip");
        gameStop.stopFlag = false;
        playerTeleport.SetPosition(5, 30);
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
        if(inputAction_.Player.MoveRight.triggered)
        {
            //StartCoroutine("Syabetarou");
        }

        if (gameStop.stopFlag == false)
        {
            Canbus.SetActive(false);
        }
        if (gameStop.stopFlag == true)
        {
            Canbus.SetActive(true);
        }
    }
}
