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

    //人形を持っているか
    public bool dollGetFlag;
    public bool fenceStoryFlag;

    public int TextNum;

    //room0を一回でも通ったことがあるか
    public bool room0FirstFlag;

    //カメラ回転
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
        uitext.DrawText("ドアは閉まっている。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("ドアの近くに、何処か既視感のある人形が置いてある。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("持っているととても安心する様だ。");
        yield return StartCoroutine("Skip");
        doll.SetActive(true);
        soundMan.isGetItem = true;
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
        soundMan.isDoorClose = true;
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
        soundMan.isGetItem = true;
        uitext.DrawText("裁縫道具を手に入れた。");
        yield return StartCoroutine("Skip");
        //ここにsowingGetをtrueにする文を書く
        playergetitem.sowingGet1 = true;

        deskEffect.SetActive(false);
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
        uitext.DrawText("少女", "何…アレ…");
        yield return StartCoroutine("Skip");
        fadeIn.fadeFlag = true;

        girl_fear.SetActive(false);
        uitext.DrawText("黒い人影は教室内を徘徊している様だ。");
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
        uitext.DrawText("少女", "！！！！！");
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
        boy.SetActive(false);
        girl.SetActive(false);
        girl_fear.SetActive(true);
        soundMan.isDamage = true;
        uitext.DrawText("少女","痛っ！");
        yield return StartCoroutine("Skip");

        uitext.DrawText("少女", "間違ったってこと…？");
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
        uitext.DrawText("少女", "ん？何か落ちたような…");
        yield return StartCoroutine("Skip");

        uitext.DrawText("少女", "これ…鍵だ。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        opeKey.SetActive(true);
        soundMan.isGetItem = true;
        uitext.DrawText("手術室の鍵を入手しました。");
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
        uitext.DrawText("ドアが開いた様だ。");
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

        uitext.DrawText("医師", "最善は…尽くしましたが………");
        yield return StartCoroutine("Skip");

        girl_fear.SetActive(true);
        uitext.DrawText("少女", "彼が…");
        yield return StartCoroutine("Skip");
        uitext.DrawText("少女", "私を庇って……");
        yield return StartCoroutine("Skip");
        uitext.DrawText("少女", "私だけ生きて………");
        yield return StartCoroutine("Skip");
        uitext.DrawText("少女", "どうして…");
        yield return StartCoroutine("Skip");
        uitext.DrawText("少女", "どうして……");
        yield return StartCoroutine("Skip");

        girl_fear.SetActive(false);
        uitext.DrawText("？？", "…い……");
        yield return StartCoroutine("Skip");

        girl_fear.SetActive(true);
        uitext.DrawText("少女", "どうして………");
        yield return StartCoroutine("Skip");

        girl_fear.SetActive(false);
        uitext.DrawText("？？", "だ……ぶか…");
        yield return StartCoroutine("Skip");

        fadeIn.fadeFlag = true;

        boy.SetActive(true);
        uitext.DrawText("少年", "おい！");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "！！！！");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "あいや、ビビらせるつもりは無かったんだが。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("少年", "随分と、思い悩んでたっつーか。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("少年", "危険な感じしたからよ…その、大丈夫か？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("少年が心配そうにしている。");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("少女", "すみません……大丈夫…です。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "…そうか。なんだ、お前も起きたらここに居た口か？それとも…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "！！");
        yield return StartCoroutine("Skip");
        uitext.DrawText("少女", "あ、あなたもそうなんですか！？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "おぉ、やっぱりそうなのか。なんか同じ匂いしたからよ。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("少年", "あや、匂いっつーか気配的な、さ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        fadeIn.fadeOutFlag = true;

        uitext.DrawText("少女は少し安堵したように微笑んだ。");
        yield return StartCoroutine("Skip");
        playerTeleport.SetPosition(-9.52f, 48.7f);
        fadeIn.fadeFlag = true;


        girl.SetActive(true);
        uitext.DrawText("少女", "ということはつまり、あなたも起きたらここに居て、どうにか道を進んで来たら手術室に着いたんですね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "おう、そうだな。そしたらお前がパ二クってる所に出くわしたって訳だ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "すみません。見苦しいところを。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "あやっ…いや、どうってことないぜ(？)");
        yield return StartCoroutine("Skip");
        uitext.DrawText("少年", "それでどーするよ。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("少年", "俺も探してここまで来たわけだが、こっち側の部屋をお前が探索しきったってんなら他に進む道は無いよな…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "あ、それなら。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("少女", "向こうの教室の、高くて手が届かない場所に何かあるみたいなんです。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "なるほどね、それが鍵とかならサイコーだな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("※ここからは少年が共に行動してくれます。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("以前探索した場所を少年に助けてもらうことで、新たな手掛かりが見つかるかもしれません。");
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
        uitext.DrawText("少女", "ところで、私が探索した限り他に行ける場所が無いように思えたのですが、何処から来たんですか？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "あぁ、ここをよじ登ってきたんだ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "な、なるほど。");
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
        uitext.DrawText("少年", "あーここか。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "？！ここには一度来てたんですかっ");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "あーいや、なんでもねー。忘れてくれ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "え………そうですか…");
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

        uitext.DrawText("黒板の上に何か光るものが見える");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("少女", "高くて取れないな…");
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
        uitext.DrawText("少女", "ここです。この黒板の上に、何かありませんか？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "あー、なんか見えるなぁ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("そういって少年は大きく手を伸ばす。");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        soundMan.isGetItem = true;
        uitext.DrawText("少年", "おぉ、鍵だ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        ironKey.SetActive(true);
        uitext.DrawText("鉄柵の鍵を手に入れた。");
        yield return StartCoroutine("Skip");
        ironKey.SetActive(false);
        playergetitem.haveIronKey = true;
        ironKeyEffect.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "取り合えずこれで俺が来た方と繋がったって所か。");
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
        uitext.DrawText("鉄柵の扉が開いた。");
        yield return StartCoroutine("Skip");

        playerTeleport.SetPosition(19.36f, 48.51f);

        boy.SetActive(true);
        uitext.DrawText("少年", "そーいや、俺がこっちに来るまでの部屋に小さい抜け道があったんだけどよ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "いかんせん俺じゃ通れなくてな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "お前の背格好なら通れたりしねぇか？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "次は私が活躍する番ってことですね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "んぁ、そうだな。助かるぜ。");
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
        uitext.DrawText("少女", "長い通路、ですね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "そうなんだよな。なんでか俺が来た方の場所はどこも通路ばっかりなんだよ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "部屋だったのなんて地下室くらいだったかな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "地下室…ですか？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "んぁ、俺が最初に居たとこ。お前も屋上に居たんだろ？似たようなモンじゃね？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "それは…そうなんですけど。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "あれ、私屋上って言いましたっけ？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "あ？あーー、言ってたー。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "そうでしたか……");
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
        uitext.DrawText("少女", "随分長い廊下ですね…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "そうだな、しかもなんつーか、ちょっと迷いそうになる。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "少し複雑に感じますもんね。");
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
        uitext.DrawText("少年", "ここが俺の初期スポーンってとこだな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "初期スポーン？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "お前で言う屋上ってこと。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "あぁ、最初に居たところって話ですか。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "てか、さっきから思ってたんですが、お前って呼び方やめてください。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "んぁ？あー、でも俺お前の名前知らねぇからな…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "じゃあ聞いてください。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "あぁ…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "………");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "？……");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "……名前……あや、俺は、ハカリ…お前は？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "それ…苗字ですか？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "名前の方だよ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "そうなんですね…ハカリさん……");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "で？お前は？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "ソラです……");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ソラって、実は男…？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "失礼ですねぶっ飛ばしますよ？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "お前も似たようなモンだろ……");
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
        uitext.DrawText("少年", "ここだここ、この小せぇ通路、お前なら通れないか？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "うぇ、ここ通れっていうんですか……");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "あや、まぁ、無理にとは言わねーが。如何せんここ以外は探索済みなんだよな…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("少女", "うー……後でもいいですか……");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("少年", "おー、無理はすんな。");
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
        uitext.DrawText("ソラ", "頑張って、入ってみます…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "何かあったらすぐ戻って来いよ。俺は一緒に行けないが、ここで待機してるからよ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ハカリさんは楽でいいですね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "………");
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

        uitext.DrawText("三桁のダイヤル");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("ソラ", "またダイヤルですか…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "このダイヤルは最初っから見つけては居たんだが、それらしい番号はどこにも無いんだよな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "確かに、随分殺風景な廊下で、それらしいものは見ませんでしたね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "だろ？だからまぁ、あそこに入るしかねぇかなって。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "わかりましたよ…");
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

        uitext.DrawText("ソラ", "痛っ！");
        yield return StartCoroutine("Skip");

        uitext.DrawText("ソラ", "間違ったってこと…？");
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
        uitext.DrawText("ハカリ", "おいおい、この部屋にまだ先があったのかよ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "今度こそ進展って感じですね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ソラのお手柄だな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "行きましょう。");
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
        uitext.DrawText("ソラ", "ここは…？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "趣のある所だな…書斎か？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        fadeIn.fadeOutFlag = true;

        girl.SetActive(true);
        uitext.DrawText("ソラ", "あ、机に何かあります。それとメモ書きみたいなのも。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);
        playerTeleport.SetPosition(-70, 223);
        fadeIn.fadeFlag = true;

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "えぇっと…？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("これは”願いの天秤”。何かを願えば、この天秤が叶えてくれる。");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "願いの…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "天秤…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "………");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "難しく考えんな…要は俺らの願いを叶えてくれるんだろ？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "そう書いてありますけど、そんなただ願いを叶えてくれるものなんてあるんでしょうか。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ん～～？難しいことはわかんねぇけど、躊躇する気持ちはわかる。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "取り合えずあんま大きな要求はしない方が良い。って所か。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "そうですね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeOutFlag = true;

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "試すに丁度いいくらいの願い…か。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);
        playerTeleport.SetPosition(-70, 227.46f);
        fadeIn.fadeFlag = true;

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ここから出るのが俺らの目的だとして。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "まぁ、なんだ？この部屋で行ける場所は全部行った訳だしな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "そうですね。なら、このくらいで試してみましょうか。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "進むべき道を教えて下さい。");
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
        uitext.DrawText("ソラ", "入れましたよぉーっ…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ここもまた長い通路って感じです。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "おぉ、どうだ、そこに何か番号の手掛かりがあればいいんだがな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "探してみますね。");
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
        uitext.DrawText("ソラ", "ハカリさん不味いかも。");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "！どうした？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl_fear.SetActive(true);
        uitext.DrawText("ソラ", "生きてたらまた後で会いましょ…");
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

        uitext.DrawText("お前は忘れている。");
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

        uitext.DrawText("お前は死に損ない。");
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

        uitext.DrawText("お前のせいだ。");
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

        uitext.DrawText("お前が居るから。");
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

        uitext.DrawText("床の色。");
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
        uitext.DrawText("裁縫道具を手に入れた。");
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

        uitext.DrawText("部屋の形。");
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

        uitext.DrawText("反転。");
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
        uitext.DrawText("ハカリ", "大丈夫かっ？！");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl_fear.SetActive(true);
        uitext.DrawText("ソラ", "はぁ、はぁ、はぁ、はぁ。");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "……なんとか……");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "全部じゃないかもしれませんが…いくつか手掛かりなど、見つけました…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeOutFlag = true;

        uitext.DrawText("ソラの呼吸が落ち着くまで、ハカリは背中をさすったー。");
        yield return StartCoroutine("Skip");
        fadeIn.fadeFlag = true;

        girl.SetActive(true);
        uitext.DrawText("ソラ", "落ち着いてきました。もう大丈夫です。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ありがとうな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "そうですね。もっと感謝してください。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "あぁ、ソラが居てくれて助かった。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "そしたら、ここからは番号を導く謎解きって所ですかね。");
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

            //あとで消す
            //fadeIn.fadeFlag = true;
            //playerTeleport.SetPosition(-9.89f, 219.28f);
            //TextNum = 53;
        }
        if (TextNum == 1 && cameraMove1.endFlag == true)
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


        //ダメージを受けたときの処理
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
