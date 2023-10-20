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
        //uitext.DrawText("ナレーションだったらこのまま書けばOK");
        //yield return StartCoroutine("Skip");

        uitext.DrawText("名前", "人が話すのならこんな感じ");
        yield return StartCoroutine("Skip");

        uitext.DrawText("主人公", "こんにちは");
        yield return StartCoroutine("Skip");
    }

    IEnumerator Syabetarou()
    {
        uitext.DrawText("喋太郎", "毎度おおきに。わいは喋太郎や ? helpコマンドで使い方を表示するで");
        yield return StartCoroutine("Skip");

        uitext.DrawText("喋太郎", "こんにちは");
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
