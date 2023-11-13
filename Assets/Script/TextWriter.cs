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

    //人形を持っているか
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
        //uitext.DrawText("ナレーションだったらこのまま書けばOK");
        //yield return StartCoroutine("Skip");
        boy.SetActive(false);
        girl.SetActive(true);
        uitext.DrawText("少女", "あれ...?");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);
        uitext.DrawText( "気が付くと、見知らぬ場所に倒れていた。");
        yield return StartCoroutine("Skip");
        uitext.DrawText( "周りを見渡してみるも真っ暗で、ぼんやりと光る電飾だけが、頭上から辺りをうっすら照らしている。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("数メートル先の暗闇に微かに柵が見えた。");
        yield return StartCoroutine("Skip");
        fadeIn.fadeFlag = true;
        girl.SetActive(true);
        uitext.DrawText("少女", "何してたんだっけ...");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);
        uitext.DrawText("どうやら、ここに来るまでの記憶が抜け落ちているみたいだ。");
        yield return StartCoroutine("Skip");
        cameraMove1.effectFlag = true;
    }

    IEnumerator RooftopStory2()
    {
        girl.SetActive(false);
        girl_fear.SetActive(true);
        uitext.DrawText("少女", "！");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(false);
        girl.SetActive(false);
        uitext.DrawText("確かに今、人が飛び降りた。黒くて影の様な。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("一瞬でも見えた”ソレ”は形容しがたく、憎悪を固めた様な、そんな存在感に吐き気がした。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);
        girl_fear.SetActive(true);
        uitext.DrawText("少女", "あっ…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);
        girl_fear.SetActive(false);
        uitext.DrawText("掠れた様に声を漏らし、しかしながら強く食いしばる。");
        yield return StartCoroutine("Skip");
        girl.SetActive(true);
        uitext.DrawText("少女", "ここに居たままじゃまずい。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);
        uitext.DrawText("そう感じたのは危機感か、本能か。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("あの言いようのない事象が、現実ではないことだけを確かに肯定する。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("そんな恐怖に竦んだ足を真っ先に動かしたのは、ほんの少しの好奇心だった。");
        yield return StartCoroutine("Skip");
        cameraMove1.effectFlag = false;
        gameStop.stopFlag = false;
    }
    IEnumerator doorStory1()
    {
        girl.SetActive(false);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        uitext.DrawText("ドアは閉まっている。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("ドアの近くに、何処か既視感のある人形が置いてある。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("持っているととても安心する様だ。");
        yield return StartCoroutine("Skip");
        doll.SetActive(true);
        uitext.DrawText("人形を手に入れた。");
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
        uitext.DrawText("下をのぞくと黒い影がバラバラになって散らばっている。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("その光景を見た瞬間に恐怖と吐き気に襲われた。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("しかし、不意に人形を抱きしめたら不安は薄れていった。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("それと同時に人形の右腕が無くなっている事に気づいた。");
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
        uitext.DrawText("ドアが開いている。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("中に入ろう。");
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
        //ドアに触れたとき
        if (TextNum == 3)
        {
            gameStop.stopFlag = true;
            StartCoroutine("doorStory1");
            TextNum = 4;
        }
        //柵に触れたとき
        if(TextNum == 5)
        {
            gameStop.stopFlag = true;
            StartCoroutine("fenceStory1");
            TextNum = 6;
        }
        //ドアに触れたとき２
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
