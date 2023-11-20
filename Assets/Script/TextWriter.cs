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
        //uitext.DrawText("ナレーションだったらこのまま書けばOK");
        //yield return StartCoroutine("Skip");
        Canbus.SetActive(true);
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
        Canbus.SetActive(false);
    }

    IEnumerator RooftopStory2()
    {
        Canbus.SetActive(true);
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
        Canbus.SetActive(false);
    }
    IEnumerator doorStory1()
    {
        Canbus.SetActive(true);
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
        Canbus.SetActive(false);
    }

    IEnumerator fenceStory1()
    {
        Canbus.SetActive(true);
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
        Canbus.SetActive(false);
    }

    IEnumerator doorStory2()
    {
        Canbus.SetActive(true);
        girl.SetActive(false);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        uitext.DrawText("ドアが開いている。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("中に入ろう。");
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
        uitext.DrawText("少女", "え…………?");
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
        uitext.DrawText("目の前に広がっているのは、病院のエントランスだろうか。");
        yield return StartCoroutine("Skip");
        hospital.backFlag = true;
        uitext.DrawText("しかし後ろを振り向けば、ドアの先には屋上が広がっている。");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(true);
        uitext.DrawText("少女","どうなってるの…");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(false);
        uitext.DrawText("バタン！！！！");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(true);
        uitext.DrawText("少女", "っ……");
        yield return StartCoroutine("Skip");
        hospital.backFlag = false;
        uitext.DrawText("少女", "先に進むしかない…よね…");
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
        uitext.DrawText("ドアは閉まっている。");
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
        uitext.DrawText("手術室と書かれている。");
        yield return StartCoroutine("Skip");
        fadeIn.fadeOutFlag = true;
        uitext.DrawText("少女", "いや！");
        yield return StartCoroutine("Skip");
        uitext.DrawText("少女", "だめっ！");
        yield return StartCoroutine("Skip");
        uitext.DrawText("少女", "死なないでっ！！");
        yield return StartCoroutine("Skip");
        uitext.DrawText("少女", "置いてかないで……");
        yield return StartCoroutine("Skip");
        fadeIn.fadeFlag = true;
        girl_fear.SetActive(true);
        uitext.DrawText("少女", "うっ…頭痛い…");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(true);
        uitext.DrawText("少女", "それに何か…大切な…");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(true);
        uitext.DrawText("少女", "思い出せない…");
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
        uitext.DrawText("鉄柵のゲートだ。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("更に奥にはドアが見える。");
        yield return StartCoroutine("Skip");
        girl.SetActive(true);
        uitext.DrawText("少女", "この鉄柵、アイツの身長なら登れたかな。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("少女", "…あれ、アイツって…誰のことだろう…");
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
        uitext.DrawText("少女", "今度は…学校？");
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
        uitext.DrawText("少女", "あれ？さっきとおなじ？");
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
        uitext.DrawText("机の中に何か入っている。");
        yield return StartCoroutine("Skip");
        girl.SetActive(true);
        uitext.DrawText("少女", "これは…裁縫道具…？");
        yield return StartCoroutine("Skip");
        uitext.DrawText("少女", "これがあればお人形を治せるかも。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);
        sewing.SetActive(true);
        uitext.DrawText("裁縫道具を手に入れた。");
        yield return StartCoroutine("Skip");
        //ここにsowingGetをtrueにする文を書く
        playergetitem.sowingGet = true;

        sewing.SetActive(false);
        uitext.DrawText("※アイテム欄から”裁縫道具”を使用すると、HPを全回復することが出来ます。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("一度使用した裁縫道具は失われます。");
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
        uitext.DrawText("少女", "今度は…学校？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeOutFlag = true;
        girl.SetActive(true);
        uitext.DrawText("少女", "何…アレ…");
        yield return StartCoroutine("Skip");
        fadeIn.fadeFlag = true;
        girl.SetActive(false);
        uitext.DrawText("黒い人影は教室内を徘徊している様だ。");
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
        uitext.DrawText("少女", "！！！！！");
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
        uitext.DrawText("綺麗な黒板だ。");
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
        uitext.DrawText("少女", "チョークの数？");
        yield return StartCoroutine("Skip");
        uitext.DrawText("少女", "でもここにチョークは無いよね。");
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
        uitext.DrawText("少女","痛っ！");
        yield return StartCoroutine("Skip");

        uitext.DrawText("少女", "間違ったってこと…？");
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
        uitext.DrawText("少女", "ん？何か落ちたような…");
        yield return StartCoroutine("Skip");

        uitext.DrawText("少女", "これ…鍵だ。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        opeKey.SetActive(true);
        uitext.DrawText("手術室の鍵を入手しました。");
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
        //入口のストーリー
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
        //ダメージを受けたときの処理
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
