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
        //uitext.DrawText("ナレーションだったらこのまま書けばOK");
        //yield return StartCoroutine("Skip");
        boy.SetActive(false);
        girl.SetActive(true);
        uitext.DrawText("少女", "あれ...?");
        yield return StartCoroutine("Skip");
        uitext.DrawText( "気が付くと、見知らぬ場所に倒れていた。");
        yield return StartCoroutine("Skip");
        uitext.DrawText( "周りを見渡してみるも真っ暗で、ぼんやりと光る電飾だけが、頭上から辺りをうっすら照らしている。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("数メートル先の暗闇に微かに柵が見えた。");
        yield return StartCoroutine("Skip");
        fadeIn.fadeFlag = true;
        uitext.DrawText("少女", "何してたんだっけ...");
        yield return StartCoroutine("Skip");
        uitext.DrawText("どうやら、ここに来るまでの記憶が抜け落ちているみたいだ。");
        yield return StartCoroutine("Skip");


        uitext.DrawText("主人公", "こんにちは");
        yield return StartCoroutine("Skip");
    }

    IEnumerator Syabetarou()
    {
        girl.SetActive(false);
        boy.SetActive(true);
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
            StartCoroutine("RooftopStory");
        }
        if(inputAction_.Player.MoveRight.triggered)
        {
            StartCoroutine("Syabetarou");
        }
    }
}
