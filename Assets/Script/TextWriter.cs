using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextWriter : MonoBehaviour
{
    public UIText uitext;

    private PlayerInputSystem inputAction_;

    public GameObject girl;
    public GameObject boy;

    private GameObject fadeInObj;
    private FadeIn fadeIn;
    // Start is called before the first frame update
    void Start()
    {
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();

        fadeInObj = GameObject.Find("fadeIn");
        fadeIn = fadeInObj.GetComponent<FadeIn>();
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
        uitext.DrawText( "�C���t���ƁA���m��ʏꏊ�ɓ|��Ă����B");
        yield return StartCoroutine("Skip");
        uitext.DrawText( "��������n���Ă݂���^���ÂŁA�ڂ���ƌ���d���������A���ォ��ӂ����������Ƃ炵�Ă���B");
        yield return StartCoroutine("Skip");
        uitext.DrawText("�����[�g����̈Èłɔ����ɍ򂪌������B");
        yield return StartCoroutine("Skip");
        fadeIn.fadeFlag = true;
        uitext.DrawText("����", "�����Ă��񂾂���...");
        yield return StartCoroutine("Skip");
        uitext.DrawText("�ǂ����A�����ɗ���܂ł̋L�������������Ă���݂������B");
        yield return StartCoroutine("Skip");


        uitext.DrawText("��l��", "����ɂ���");
        yield return StartCoroutine("Skip");
    }

    IEnumerator Syabetarou()
    {
        girl.SetActive(false);
        boy.SetActive(true);
        uitext.DrawText("�����Y", "���x�������ɁB�킢�͒����Y�� ? help�R�}���h�Ŏg������\�������");
        yield return StartCoroutine("Skip");

        uitext.DrawText("�����Y", "����ɂ���");
        yield return StartCoroutine("Skip");
    }
    // Update is called once per frame
    void Update()
    {
        if(inputAction_.Player.MoveLeft.triggered)
        {
            StartCoroutine("RooftopStory");
        }
        if(inputAction_.Player.MoveRight.triggered)
        {
            StartCoroutine("Syabetarou");
        }
    }
}
