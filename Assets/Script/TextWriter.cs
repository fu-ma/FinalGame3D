using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextWriter : MonoBehaviour
{
    public UIText uitext;

    private PlayerInputSystem inputAction_;

    // Start is called before the first frame update
    void Start()
    {
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();
    }

    IEnumerator Skip()
    {
        while (uitext.playing) yield return 0;
        while (!uitext.IsClicked()) yield return 0;
    }

    IEnumerator Cotest()
    {
        //uitext.DrawText("�i���[�V�����������炱�̂܂܏�����OK");
        //yield return StartCoroutine("Skip");

        uitext.DrawText("���O", "�l���b���̂Ȃ炱��Ȋ���");
        yield return StartCoroutine("Skip");

        uitext.DrawText("��l��", "����ɂ���");
        yield return StartCoroutine("Skip");
    }

    IEnumerator Syabetarou()
    {
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
            StartCoroutine("Cotest");
        }
        if(inputAction_.Player.MoveRight.triggered)
        {
            StartCoroutine("Syabetarou");
        }
    }
}
