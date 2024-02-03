using System.Collections;
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
    public GameObject boyObject;
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
    public GameObject investigate;
    public GameObject investigate2;
    public GameObject blueRoomDoor1;
    public GameObject blueRoomDoor2;
    public GameObject blueRoomDoor3;
    public GameObject blueRoomDoor4;
    public GameObject blueRoomDoor5;
    public GameObject blueRoomBook;
    public GameObject vase1;
    public GameObject vase2;
    public GameObject classRoom1TeachDeskObj;
    public GameObject classRoom1A;
    public GameObject classRoom1B;
    public GameObject classRoom1C;
    public GameObject classRoom1D;
    public GameObject teacherRoomDoor;
    public GameObject girlObject;
    public GameObject roomWarp;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject desk1;
    public GameObject desk2;
    public GameObject lostObject1;
    public GameObject lostObject2;
    public GameObject lostObject3;
    public GameObject lostObject4;
    public GameObject lostObject5;
    public GameObject lostObject6;
    public GameObject lostObject7;
    public GameObject kirakira10;

    public StatueCollision statueCollision;
    public ChairCollision chairCollision;

    private bool configFlag;

    public GameObject config2;

    private bool config2Flag;

    private FadeIn fadeIn;

    private storyCameramove1 cameraMove1;
    private storyCameramove2 cameraMove2;

    private publicFlag gameStop;

    private PlayerDamage playerDamage;

    private PlayerTeleport playerTeleport;
    private boyTeleport boyTeleport;
    private boyTarget boyTarget;

    private hospitalPlayerSprite hospital;

    private playerGetItem playergetitem;

    private SoundManager soundMan;

    private Password password;
    private Password2 password2;
    private cameraRotate cameraRot;

    private EnemyTargetMove enemyTarget;

    private operoomMove operoommove;

    private playerMove playermove;
    private boyMove boymove;
    private ResetRoom resetroom;

    private CameraChange playerChange;

    public GameObject mainCamera;
    public GameObject subCamera;

    public Rigidbody blueRoomStatue;
    public Rigidbody blueRoomChair;

    public GameObject whiteMistObject;

    //人形を持っているか
    public bool dollGetFlag;
    public bool fenceStoryFlag;

    public int TextNum;

    //room0を一回でも通ったことがあるか
    public bool room0FirstFlag;

    public bool underground45Flag;

    public bool operoom45Flag;

    public bool equilibriumGoDoorFlag;

    private bool openBlueRoomFlag;

    private bool A_DeskStoryFlag;
    private bool B_DeskStoryFlag;
    private bool C_DeskStoryFlag;
    private bool D_DeskStoryFlag;
    private bool DeskStoryFlag;

    //カメラ回転
    public bool cameraRotateFlag;
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
        cameraMove2 = GameObject.Find("GameManager").GetComponent<storyCameramove2>();

        gameStop = GameObject.Find("GameManager").GetComponent<publicFlag>();

        playerDamage = GameObject.Find("player").GetComponent<PlayerDamage>();

        playerTeleport = GameObject.Find("player").GetComponent<PlayerTeleport>();
        boyTeleport = GameObject.Find("boyObject").GetComponent<boyTeleport>();

        boyTarget = GameObject.Find("boyObject").GetComponent<boyTarget>();
        boyTarget.followFlag2 = false;

        hospital = GameObject.Find("playerShadow").GetComponent<hospitalPlayerSprite>();

        playergetitem = GameObject.Find("player").GetComponent<playerGetItem>();

        password = GameObject.Find("player").GetComponent<Password>();
        password2 = GameObject.Find("player").GetComponent<Password2>();

        cameraRot = GameObject.Find("player").GetComponent<cameraRotate>();

        enemyTarget = GameObject.Find("room0Enemy").GetComponent<EnemyTargetMove>();

        soundMan = GameObject.Find("Canvas").GetComponent<SoundManager>();

        operoommove = GameObject.Find("boyObject").GetComponent<operoomMove>();

        playermove = GameObject.Find("player").GetComponent<playerMove>();
        boymove = GameObject.Find("boyObject").GetComponent<boyMove>();

        resetroom = GameObject.Find("GameManager").GetComponent<ResetRoom>();

        playerChange = GameObject.Find("GameManager").GetComponent<CameraChange>();

        blueRoomStatue.isKinematic = true;
        blueRoomChair.isKinematic = true;

        TextNum = 0;
        fenceStoryFlag = false;
        boy_fear.SetActive(false);
        boyObject.SetActive(false);
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
        investigate.SetActive(false);
        investigate2.SetActive(false);
        blueRoomDoor1.SetActive(false);
        blueRoomDoor2.SetActive(false);
        blueRoomDoor3.SetActive(false);
        blueRoomDoor4.SetActive(true);
        blueRoomDoor5.SetActive(false);
        blueRoomBook.SetActive(false);
        vase1.SetActive(true);
        vase2.SetActive(false);
        whiteMistObject.SetActive(false);
        classRoom1TeachDeskObj.SetActive(false);
        classRoom1A.SetActive(false);
        classRoom1B.SetActive(false);
        classRoom1C.SetActive(false);
        classRoom1D.SetActive(false);
        teacherRoomDoor.SetActive(true);
        girlObject.SetActive(true);
        roomWarp.SetActive(false);
        light1.SetActive(false);
        light2.SetActive(false);
        light3.SetActive(false);
        light4.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
        desk1.SetActive(true);
        desk2.SetActive(true);
        lostObject1.SetActive(true);
        lostObject2.SetActive(true);
        lostObject3.SetActive(true);
        lostObject4.SetActive(true);
        lostObject5.SetActive(true);
        lostObject6.SetActive(true);
        lostObject7.SetActive(true);

        kirakira1.SetActive(true);
        kirakira2.SetActive(true);
        kirakira3.SetActive(true);
        kirakira4.SetActive(true);
        kirakira5.SetActive(true);
        kirakira6.SetActive(true);
        kirakira7.SetActive(true);
        kirakira8.SetActive(true);
        kirakira10.SetActive(false);

        gameEndFlag = false;

        underground45Flag = false;
        operoom45Flag = false;
        equilibriumGoDoorFlag = false;
        openBlueRoomFlag = false;
        A_DeskStoryFlag = false;
        B_DeskStoryFlag = false;
        C_DeskStoryFlag = false;
        D_DeskStoryFlag = false;
        DeskStoryFlag = false;
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
        investigate.SetActive(false);
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
        investigate.SetActive(false);

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
        cameraMove1.effectFlag2 = true;

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

        uitext.DrawText("ドアが開いている。");
        yield return StartCoroutine("Skip");
        uitext.DrawText("中に入ろう。");
        yield return StartCoroutine("Skip");
        playerTeleport.SetPosition(5, 30);
        if (boyTarget.followFlag2 == true)
        {
            boyTeleport.SetPosition(7, 30);
        }
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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

        uitext.DrawText("少女", "！！！！！");
        yield return StartCoroutine("Skip");
        girl_fear.SetActive(false);
        //playerTeleport.SetPosition(5, 30);

        gameStop.stopFlag = false;
        Canbus.SetActive(false);
    }

    IEnumerator BlackBoardStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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

        playergetitem.haveOpeKey = true;

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
        investigate.SetActive(false);

        uitext.DrawText("ドアが開いた様だ。");
        yield return StartCoroutine("Skip");

        playerTeleport.SetPosition(-9.52f, 48.7f);
        if (boyTarget.followFlag2 == true)
        {
            boyTeleport.SetPosition(-7.52f, 48.7f);
        }

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
        investigate.SetActive(false);

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

        playermove.boyFlag = true;
        boyObject.SetActive(true);

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
        boyTarget.followFlag2 = true;
        boyTeleport.SetPosition(-7.52f, 48.7f);
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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

        room4goDoor.SetActive(false);
        soundMan.isOpenKey = true;
        uitext.DrawText("鉄柵の扉が開いた。");
        yield return StartCoroutine("Skip");

        playerTeleport.SetPosition(19.36f, 48.51f);
        if (boyTarget.followFlag2 == true)
        {
            boyTeleport.SetPosition(21.36f, 48.51f);
        }

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        boyTarget.followFlag2 = false;
        
        Canbus.SetActive(false);
        gameStop.stopFlag = false;
        playerTeleport.SetPosition(36.26f, 157.14f);
        //boyTeleport.SetPosition(38.26f, 157.14f);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        if (boyTarget.followFlag2 == true)
        {
            boyTeleport.SetPosition(-68, 223);
        }

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
        if (boyTarget.followFlag2 == true)
        {
            boyTeleport.SetPosition(-68, 227.46f);
        }

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
        uitext.DrawText("ソラ", "天秤さん、どうか進むべき道を教えて下さい。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeInOutFlag = true;
        cameraRotateFlag = true;
        Canbus.SetActive(false);

        underground45Flag = true;
        operoom45Flag = true;
        gameStop.stopFlag = false;
        //gameEndFlag = true;
    }

    IEnumerator room0Story1()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

        sewing.SetActive(true);
        soundMan.isGetItem = true;
        uitext.DrawText("裁縫道具を手に入れた。");
        yield return StartCoroutine("Skip");
        sewing.SetActive(false);

        playergetitem.sowingGet1 = true;

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);

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
        investigate.SetActive(false);
        boyTarget.followFlag2 = true;
        stage0Enemy.SetActive(false);

        enemyTarget.moveFlag = false;

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

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
        gameStop.playerDontMoveFlag = false;
    }

    IEnumerator undergroundStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "・　・　・");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "　・　・　・　");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "なんか…何も変化無く感じるな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "そう、ですね。さっきのセリフが恥ずかしく感じてきました。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ま、まぁほら、願ったら叶うなんてこと自体普通はおかしいからな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "俺ら随分長い事この変な空間に居るからちと期待しちまったなｗ");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "よしっ、まだ見てねぇ場所あるかもだ。探しに行k……？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ハカリさん…不思議です。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "どうした？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ハカリさんってさっきまで私の後ろに居ましたよね？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "え…そりゃ……");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "！");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "今、私の左に居ませんか…？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "変なことを言っている自覚はあります。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "部屋に変化は無いですし、私たちも動いたりしてません。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "でも確かに、ハカリさんがさっきと違う場所に居るって思うんです。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "…本当だ。俺もソラが右にズレた様に感じる。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "多分本当にお願い事が叶って、何かしらの効果を発揮したのかもしれません。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "方向感覚っつーか、東西南北がずれたような…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "部屋の外に出てみましょう。きっと何か新しい発見があるはずです。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "そーだな。行ってみるしかねぇな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator operoom45Story()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        fadeIn.fadeOutFlag = true;
        girl.SetActive(true);
        uitext.DrawText("ソラ", "え…ここ、左側にドアなんてありましたか？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        cameraMove2.effectFlag = true;
        boyTarget.followFlag2 = false;

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "無かったハズ……いや…見えてなかったのか…？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "死角だったって言うのか、変な感じだな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ちょっと、改めてここが異質な空間なんだなと感じました。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "そうだな…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ちょっと待ってろよ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        operoommove.moveFlag = true;

        Canbus.SetActive(false);
    }

    IEnumerator operoom45Story2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "よし。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "流石ですっ、頼りになりますね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ま、肉体労働ばっかしてたからな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "お仕事大変だったんですね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boyTarget.followFlag2 = true;
        cameraMove2.effectFlag = true;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator operoom45Story3()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "鍵はかかって無いみたいですね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeOutFlag = true;
        boy.SetActive(true);
        uitext.DrawText("ハカリ", "なら、入ってみるか。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        playerTeleport.SetPosition(-123.8f, 106f);
        if (boyTarget.followFlag2 == true)
        {
            boyTeleport.SetPosition(-121.8f, 106f);
        }
        fadeIn.fadeFlag = true;
        Canbus.SetActive(false);

        TextNum = 92;
    }

    IEnumerator blueButtonRoom()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "え………");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ここ……私の部屋です。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "（女の子の部屋初めて入った…）");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "なにボーっとしてるんですかハカリさん。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ここが現実の場所じゃないことは分かってます。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "早く進みましょ。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "あ、一応、クローゼットは絶対開けないでくださいね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "お、おう。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "（入っては良いのか…）");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueButtonRoomStory1()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "うへぇ、またですか。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "あー、そうみたいだな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ハカリさんちょっと笑ってません？？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "いや？ｗ");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("ソラはハカリの足を踏みつけた");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "いっ！っつーー。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "行ってきます。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "お、おう…気をつけてな……");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);
        boyTarget.followFlag2 = false;
        boyTeleport.SetPosition(-123.8f, 106f);

        playerTeleport.SetPosition(-183.98f, 106f);

        Canbus.SetActive(false);
        TextNum = 96;
    }

    IEnumerator blueButtonRoomStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "えっ……");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "大丈夫か？！");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "大丈夫…なんですけど、どうやら同じような部屋ですね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "同じような？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "はい。そっちの部屋と同じ私の自室です。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "でもなんだか、少しだけ違和感というか……");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        soundMan.isDoorClose = true;
        uitext.DrawText("バタン！");
        yield return StartCoroutine("Skip");

        blueRoomDoor1.SetActive(true);
        blueRoomDoor2.SetActive(true);
        blueRoomDoor3.SetActive(true);
        blueRoomDoor4.SetActive(false);
        blueRoomDoor5.SetActive(true);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "？！");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "通路が塞がれた？！");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ハカリさんっ！");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ハカリさんっ？！");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "返事がない…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "どうにかここから出ないと…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        blueRoomStatue.isKinematic = false;
        blueRoomChair.isKinematic = false;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomDeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "不自然な跡がある");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomBedStory1()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "不自然な所は無い");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomBedStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "不自然な所は無いよね");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomBedStory3()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "不自然な所は無い…ん…？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomBedStory4()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        fadeIn.fadeOutFlag = true;
        girl.SetActive(true);
        uitext.DrawText("ソラ", "よく見たらベッドの下に…ノート？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        blueRoomBook.SetActive(true);
        playermove.blueRoomFlag = true;

        fadeIn.fadeFlag = true;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomBedStory5()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "不自然な所は無い");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomBookShefStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "背の高い本棚だな");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomLeverStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("サユウノキンコウヲタモテ");
        yield return StartCoroutine("Skip");

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomChairStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "不自然な所は無い");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomRoundDeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "不自然な所は無い");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoomStatueStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "不自然な所は無い");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoom2RoundDeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "不自然な跡がある");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoom2BedStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "不自然な所は無い");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoom2LeverStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        fadeIn.fadeOutFlag = true;
        boy.SetActive(true);
        uitext.DrawText("ハカリ", "…戻った？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);
        boyTeleport.SetPosition(-123.8f, 106f);

        resetroom.resetButtonPushed = true;
        vase1.SetActive(true);
        vase2.SetActive(false);
        statueCollision.Init();
        chairCollision.Init();
        playermove.blueRoomBedCount = 0;
        blueRoomBook.SetActive(false);
        playermove.blueRoomFlag = false;
        boymove.blueChairFlag = false;
        boymove.blueStatueFlag = false;
        boymove.blueRoomFlag = false;

        fadeIn.fadeFlag = true;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoom2StatueStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "んぁ、これ動かせんのか…おっも……");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoom2ChairStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "これも動くなぁ");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoom2DeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "不自然な所は無い");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }
    IEnumerator blueRoom2BookShefStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "でっけぇ本棚だな…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "俺でも上部に手が届かねぇ");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoom2StatueStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ここでいいのか…？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boymove.blueStatueFlag = true;
        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator blueRoom2ChairStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        fadeIn.fadeOutFlag = true;
        boy.SetActive(true);
        uitext.DrawText("ハカリ", "これで届くか…？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);
        vase1.SetActive(false);
        vase2.SetActive(true);

        boymove.blueChairFlag = true;

        fadeIn.fadeFlag = true;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator openBlueRoomStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        fadeIn.fadeOutFlag = true;
        uitext.DrawText("ガチャン！");
        yield return StartCoroutine("Skip");
        blueRoomDoor1.SetActive(false);
        blueRoomDoor2.SetActive(false);
        blueRoomDoor3.SetActive(false);
        blueRoomDoor4.SetActive(false);
        blueRoomDoor5.SetActive(false);

        boyTarget.followFlag2 = true;

        playermove.changeCharaFlag = false;
        mainCamera.SetActive(true);
        subCamera.SetActive(false);

        playerTeleport.SetPosition(-123.8f, 106f);
        if (boyTarget.followFlag2 == true)
        {
            boyTeleport.SetPosition(-121.8f, 106f);
        }

        fadeIn.fadeFlag = true;

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ソラ！無事だったか？！");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "良かった！ハカリさんも無事ですねっ");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "にしても…やっかいな部屋だったな");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "でも、どうにか先に進めそうですね");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        whiteMistObject.SetActive(true);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator whiteMistStory1()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);
        investigate2.SetActive(false);

        uitext.DrawText("白いモヤ", "やぁ、お二人さん。ちょっといいかな？");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ふぇっ、な、なんですか…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("白いモヤ", "頼みたいことがあるんだけどお願い出来ないかな？");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "お前は…人、なのか？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("白いモヤ", "あぁ、私？どうだろうね。あんまり覚えていないんだ。");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "素性の知れない奴の頼みはなぁ…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ハカリさん、敵意は無いように感じるので、聞いてあげませんか？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "んぁ、まぁ良いか。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("白いモヤ", "ありがとう。それでね。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("白いモヤ", "私はどうやら、とても大切なことを忘れているみたいでね。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("白いモヤ", "誰かに逢いたかったってことだけは分かっているんだけど、その人の名前も、それどころか自分の名前すらも忘れてしまってね。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("白いモヤ", "しかしながら私はこの手術室から動けないみたいなんだ。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("白いモヤ", "だから君たちにお手伝いを頼んだんだ。");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "地縛霊的な感じか？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("白いモヤ", "そうなのかな？よくわかんないや。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("白いモヤ", "それでね、そこの机に必要な物が入ってると思うから。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("白いモヤ", "そこに書いてある情報を頼りに僕が何者なのか探って欲しいんだ。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("白いモヤ", "もし何も無くても気にしないからさ、勿論お礼もするよ。");
        yield return StartCoroutine("Skip");

        kirakira10.SetActive(true);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator whiteMistStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("白いモヤ", "私はどうやら、とても大切なことを忘れているみたいでね。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("白いモヤ", "誰かに逢いたかったってことだけは分かっているんだけど、その人の名前も、それどころか自分の名前すらも忘れてしまってね。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("白いモヤ", "しかしながら私はこの手術室から動けないみたいなんだ。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("白いモヤ", "だから君たちにお手伝いを頼んだんだ。");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "地縛霊的な感じか？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("白いモヤ", "そうなのかな？よくわかんないや。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("白いモヤ", "それでね、そこの机に必要な物が入ってると思うから。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("白いモヤ", "そこに書いてある情報を頼りに僕が何者なのか探って欲しいんだ。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("白いモヤ", "もし何も無くても気にしないからさ、勿論お礼もするよ。");
        yield return StartCoroutine("Skip");

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator opeRoomDeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "これ、学生証か？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "そうみたいですね。名前は…黒塗りされてるみたいです。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "A-1？持ち主のクラスとかか？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ということは、一度教室に戻ってみたほうがいいですね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        playermove.classRoom1StoryFlag = true;
        classRoom1TeachDeskObj.SetActive(true);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator classRoom1MisteryStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "あー、ここがA-1だったのか。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "か、影には十分注意してくださいね？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator classRoom1MisteryStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "いじめに関する調査…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "おいおい、なんだか闇が深そうだな…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("A-1担任○○のいじめ調査メモ");
        yield return StartCoroutine("Skip");

        uitext.DrawText("A：「C君は嘘を付いています。」");
        yield return StartCoroutine("Skip");

        uitext.DrawText("B：「Aさんは本当のことを言っています。」");
        yield return StartCoroutine("Skip");

        uitext.DrawText("C：「このクラスにいじめは無いと思います。」");
        yield return StartCoroutine("Skip");

        uitext.DrawText("D：「C君がいじめている現場を目撃しました。」");
        yield return StartCoroutine("Skip");

        uitext.DrawText("本人は否認しているが、Cがいじめをしていた可能性は非常に高いと思う。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("Cには然るべき処罰を考えよう。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("しかしながら、私の担当するクラスでこの様な事態は許しがたい。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("他クラスの担当教員にバレると色々と嫌味を言われるだろう。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("この話は私の独断で解決した方が得策かー。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("くれぐれもあのことがバレない様に私のデスクに…、");
        yield return StartCoroutine("Skip");

        uitext.DrawText("いや、職員室では人目に付き過ぎるか？");
        yield return StartCoroutine("Skip");

        uitext.DrawText("後程別の隠し場所を探すとして、一旦は引き出しに隠す他無いか…。");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "あからさまに、このCってのが犯人なのか？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "皆さんそんな風に証言していますね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "にしても意味深なメモだなこりゃ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "この先生は何かを隠してるみたいだし。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "…このいじめ調査メモだけでは情報が少なすぎますね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "だな。他にも何か無いか、隈なく調べるしかねぇな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        classRoom1A.SetActive(true);
        classRoom1B.SetActive(true);
        classRoom1C.SetActive(true);
        classRoom1D.SetActive(true);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator A_DeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("頭にAの言葉が流れ込んでくる");
        yield return StartCoroutine("Skip");

        uitext.DrawText("「C君はいっつも皆の人気者。」");
        yield return StartCoroutine("Skip");

        uitext.DrawText("「今日だって、私が重い荷物を運んでる時、何も言わずに変わってくれたの。」");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "あれ、このAってさっきの証言の人だよな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "Cは良いやつではあったみてーだな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        A_DeskStoryFlag = true;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator B_DeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("頭にBの言葉が流れ込んでくる");
        yield return StartCoroutine("Skip");

        uitext.DrawText("「C君って凄いよね。なんて言うか、文武両道？」");
        yield return StartCoroutine("Skip");

        uitext.DrawText("「正義感もあってかっこいいよね。それで良く先生と口論してることもあるけど。」");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "先生と口論か～、俺も昔は言い合ったなぁ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "お前はこんな問題もわかんねーのかってどやされてよ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "小学校通って無かったから仕方ねぇだろって言っても甘えだって言うんだぜ？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "俺なりに頑張ってたんだけどなぁ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ハカリさん小学校行って無かったんですか？あや…聞かない方が良いこともありますよね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "気にすんな？ただこう、小さい頃から親に良く思われて無くてな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "10才の時にばぁちゃんに引き取ってもらったんだ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "そうだったんですね…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        B_DeskStoryFlag = true;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator C_DeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("頭にCの言葉が流れ込んでくる");
        yield return StartCoroutine("Skip");

        uitext.DrawText("「この前助けた子から告白をされたんだ。」");
        yield return StartCoroutine("Skip");

        uitext.DrawText("「勿論断ったけど、またそーちゃんに怒られるかな。」");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "んぁ？なんだこいつ自慢話じゃねぇか。けっ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ハカリさんってもしかしてモテないんですか？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "…うるせぇ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        C_DeskStoryFlag = true;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator D_DeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("頭にDの言葉が流れ込んでくる");
        yield return StartCoroutine("Skip");

        uitext.DrawText("「この前、いきなり先生に押し倒されて…。」");
        yield return StartCoroutine("Skip");

        uitext.DrawText("「あの時C君が異変に気付いてくれなかったら私…。」");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "げ、やべぇ先生じゃん。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "Cが救ったってことか…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "そうですね…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "なんつーかよ、仮にCが犯人だとしても。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "その被害者像が浮かばねぇんだよな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "当たり前だけど、いじめってのは被害者が居て初めて成り立つよな…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        D_DeskStoryFlag = true;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator DeskStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "粗方調べたか？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "そう…ですね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "でも、どれもあの白いモヤモヤさんに関する情報なのか分かりませんね…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ソラはアイツのこと”白いモヤモヤさん”って呼んでるのかｗ");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "カワイーとこあるのなｗ");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "！");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "わ、悪いですかっ！？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "いや…ｗ良いんだけど…ｗくくｗ");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "そんなことどーでもいいですから。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "早く手掛かりを探して先に進みますよノンデリさん。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "悪かったって…。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "んで……、どーすっか。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "そうですね。せめて名前とかが分かれば…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "そういえば、職員室に隠すとか書いてありましたよね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "そういやそうだったな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "んでも、職員室も、繋がってそうな場所も。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "今まで見てきた感じ無かったよな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "今まで見てきた限りはそうでしたね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "でも、あの天秤の力か、何かしら変わってる可能性は高いです。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "探索し直し、か…。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "元気出してくださいハカリさんっ");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "無事この世界から生きて帰る事が出来たら二人で美味しい物でも食べに行きましょう！");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ははっ…。生きて帰れたらな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        teacherRoomDoor.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator teacherRoomStory1()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "おわっ！まじかこんな場所増えてたのか…。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "って、ここまさに職員室…か？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "そうみたいですよっ");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "なんのヒントも無しに新しい場所探すのは骨が折れたな…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator teacherDeskStory1()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("良く整頓された綺麗なデスクだ。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("引き出しの中はファイルで埋まっている。");
        yield return StartCoroutine("Skip");

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator teacherDeskStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("乱雑に物が置かれている。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("引き出しの中もぐちゃぐちゃだ。");
        yield return StartCoroutine("Skip");

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator teacherDeskStory3()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("所々に汚れが目立つが整頓されている。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("引き出しの中はファイルで埋まっている。");
        yield return StartCoroutine("Skip");

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator teacherDeskStory4()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        uitext.DrawText("一見整頓されているように見えるが、奥の方に紙がぐしゃぐしゃに詰め込まれている。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("引き出しの中は…なんだか引き出しが薄い。");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "んぁ？…なぁソラ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ここの引き出しだけ、随分底が浅くねぇか？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "本当ですね。製造ミスか、型が古いとかですか？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "んや、こーゆーのは大抵…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "やっぱり、二重底だ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "！");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "凄いですね！なんでわかったんですか？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "んまぁ、推理ものの映画とかでよく使われてる手法なんだよな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "素直に関心します。察しは悪いのにこういうの気付けるんですね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "うるせぇ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "これが…あの先生が隠したがっていたものですか…って？！");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "…っ！ハカリさん見ないでくださいっ！");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "んぇ、なんで…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "これ、盗撮写真です。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "…やっぱやべぇ先生じゃん。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "なのでハカリさんはこれ読んでてください。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "んぉ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "えぇっと。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("頭に教師の言葉が流れ込んでくる");
        yield return StartCoroutine("Skip");

        uitext.DrawText("「キタミ アツト、あいつは何故あんなにも女子生徒から人気なのだ理解できん。」");
        yield return StartCoroutine("Skip");

        uitext.DrawText("「確かに多少顔が良いのかも知れんが…くっそ。」");
        yield return StartCoroutine("Skip");

        uitext.DrawText("「あいつは何かと私の趣味の邪魔をする。チクられていないのがせめてもの救いか。」");
        yield return StartCoroutine("Skip");

        uitext.DrawText("「どうにかあいつを排除出来れば、このクラスは私の好きに出来るのだがな。」");
        yield return StartCoroutine("Skip");

        uitext.DrawText("「ふむ、いじめ調査アンケートの実施か、また面倒なことを。」");
        yield return StartCoroutine("Skip");

        uitext.DrawText("「いや、そうか！これだｗ！」");
        yield return StartCoroutine("Skip");

        uitext.DrawText("「このいじめ調査を利用してあいつを陥れてやろう。」");
        yield return StartCoroutine("Skip");

        uitext.DrawText("「邪魔が入らなければ私は…」");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "う…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "？どうしました？読めました？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "んぁ、あぁ、読まなくても読めた。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        fadeIn.fadeOutFlag = true;

        girl.SetActive(true);
        uitext.DrawText("ソラ", "どういうことですか。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeFlag = true;

        girl.SetActive(true);
        uitext.DrawText("ソラ", "なるほど。Cの名前はキタミ アツトって言うんですね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "そう。んで、この世界で名前が割れたキタミってやつが彼(白いモヤ)で間違い無いんじゃねぇか？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "…？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "もう一回言ってもらっても良いですか？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "んえ…だからキタミってやつが”彼”なんじゃねぇのって。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ハカリさん……");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "どうして…”彼”なんですか？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "え？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "白いモヤの人としての外見は分からないし、何より一人称は”私”でしたよね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "普通なら私という一人称で学生なら概ね女性を想像すると思うのですが。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "あーー、あれだよ。引っ張られたんだって。その…アツトって男しか名前出てねぇからさ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "取り合えず、戻って聞いてみようぜ？この名前に覚えは無いかってさ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "一旦戻ります。でも。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ハカリさんは絶対何かを隠しています。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "私には…ハカリさんが悪い人には見えないので。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "後で絶対、話してくださいね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "隠し事は…あまり好きじゃないです。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "……あぁ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator whiteMistStory3()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "戻りました。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("白いモヤ", "やぁ、お二人さん。お疲れ様。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("白いモヤ", "何か情報は得られたかい？");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("ソラ", "えっと、キタミ アツトさんって方の名前がありました。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("白いモヤ", "アツト…、アツト。");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("ソラ", "やはり、貴方の名前では無いですよね…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("白いモヤ", "………私だ。");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("ソラ", "え？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("白いモヤ", "いや、僕だ。アツトは僕の名前だよ。");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("アツト", "ありがとう。まだ、鮮明じゃないけれど、確かに僕はアツトだ。");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("ソラ", "そうだったんですねっ。えっと、そしたら後は貴方がここに縛られている理由が分かれば…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("アツト", "そうだね…");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "そしたらソラ、また探しに行くか？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "そうですね。次はどこを探しましょうか…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("アツト", "……ソラ………？");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("ソラ", "？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("アツト", "ソラ……、そっか。そうだったんだね。");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("ソラ", "？？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("アツト", "無事だったんだね……。");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("ソラ", "え？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("アツト", "いいや、ごめんね。こっちの話。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("アツト", "でも、これで二人がまた探しに行く必要は無くなったよっ。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("アツト", "ありがとうね、そうだこれ、きっと役に立つよ。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("何かのメモを受け取った。");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("ソラ", "えっと、どういうことですか？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("アツト", "あぁごめん。気にしないで。ただ僕の目的が達成されて、僕は無事に成仏出来そうなんだ。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("アツト", "それからさ、僕はもうすぐ消えちゃうと思うんだけどね。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("アツト", "これだけ言ってもいいかな。");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("ソラ", "？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeOutFlag = true;
        uitext.DrawText("アツト", "最後にまた会えて嬉しいよ。じゃあね。そーちゃん。");
        yield return StartCoroutine("Skip");

        whiteMistObject.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "！");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeFlag = true;

        uitext.DrawText("白いモヤはもう見えない。");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "………");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ソラ…？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "！");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ハカリさん……どうしても思い出せないんです、");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "思い出してあげられないんですけど…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "何故だか涙が止まらないんです………");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeOutFlag = true;

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "………");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        fadeIn.fadeFlag = true;

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "もう大丈夫なのか…？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "はい…もう大丈夫です。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "……薄々気づいては居たんです。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "きっと私はいくつかの記憶を失っています。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "記憶を失って、何故かここに居ます…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "進みましょう。ここに居ても始まらないですから。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "そう…だな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "さっきこれを貰ったんです。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("ーーー天秤についての研究メモーーー");
        yield return StartCoroutine("Skip");

        uitext.DrawText("「この天秤、何かおかしいと思ってたんだ。どうやらこの天秤は願いを叶える対価を要求している。」");
        yield return StartCoroutine("Skip");

        uitext.DrawText("「間違っても死者蘇生なんて望むんじゃない、誰かが死ぬことになる。」");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("ソラ", "やっぱり…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "あの天秤に私が願ったから。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "新しい場所に行ける様になった対価として、前に行けた場所に行けないんですね…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "なるほどなぁ…、でもなんであれは天秤なんだ？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "天秤ってーと、左右に置いたものの重さを比べるものだろ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "そうですね。もしかしたらそれが対価を要求している意味なのかも知れないですね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "？？？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "深くは私もわかりません。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "兎に角、先に進むにしろ次に出来る手立てが無くなっちゃいましたね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "かくなるうえはもう一度天秤か……");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "………そうですね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "どんな対価を要求されるか事前には分かりませんが、少なくとも対等なものを要求している様に感じます。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "前回と同じように、当たり障りなく、多少の変化を望める様な。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "そのくらいのお願いをしに、行ってみるしか無いですね。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeOutFlag = true;
        boy.SetActive(true);
        uitext.DrawText("ハカリ", "行くかぁ。天秤のあった部屋。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        playerTeleport.SetPosition(-70.17f, 219.09f);
        boyTeleport.SetPosition(-68.17f, 219.09f);

        fadeIn.fadeFlag = true;

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "さてと……");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "当たり障りのない願い事ねぇ…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        fadeIn.fadeOutFlag = true;

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "どうする？ソラ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "そうですね………");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "………");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "んぁ～、あんま難しく考えんな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "お前の率直な意見でいい。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "わかり……ました。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeFlag = true;
        
        girl.SetActive(true);
        uitext.DrawText("ソラ", "今まで見えていた場所が、また見えなくなったとしても。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "私たちは………先に進みたい。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        Canbus.SetActive(false);
        fadeIn.fadeInOutFlag = true;
        cameraRotateFlag = true;
        Canbus.SetActive(true);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "そうだな………");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);
        fadeIn.fadeOutFlag = true;


        boy.SetActive(true);
        uitext.DrawText("ハカリ", "俺たちは先に進むしかねぇ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boyTarget.followFlag2 = false;
        playerChange.moveFlag = true;

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "行こ―ぜ、ソラ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girlObject.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "…ソラ？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);


        fadeIn.fadeFlag = true;

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "そう来たかよ天秤……");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "………");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "いや…ソラの存在が消えちまった可能性は低い。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "天秤の要求する対価が対等な物だとして。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ソラの存在が消えるほどの要求を俺たちはしていない。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "そもそも俺ではなくソラが消えたことを考えると…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "お互いが、見えなくなっている可能性が高いか…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "くっそ、ソラ…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "無事でいてくれ……");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        fadeIn.fadeOutFlag = true;

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "お前の過去も痛みも俺が………");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        fadeIn.fadeFlag = true;

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ソラの為にも、何か脱出の糸口を見つけねぇとな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "さてと、他に行ける場所はどこだ～");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        roomWarp.SetActive(true);
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
        button4.SetActive(true);
        desk1.SetActive(false);
        desk2.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator lastGimmickRoomStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "んぁ？なんだよこれ…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        fadeIn.fadeOutFlag = true;

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "今度は謎の………");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        //ここに移動処理を書く
        boyTeleport.SetPosition(33.12f, 219.48f);

        fadeIn.fadeFlag = true;

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "んぁ…どうなってんだ…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "どこだよここ………");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator lastRoomBookStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        uitext.DrawText("ーーーとある少女の日記ーーー");
        yield return StartCoroutine("Skip");

        uitext.DrawText("〇月○日");
        yield return StartCoroutine("Skip");

        uitext.DrawText("今日はいつもより早く起きれたから学校も一足先に着いた。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("そしたら先生にお手伝いを頼まれちゃって職員室まで荷物を運んだ。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("授業はいつも通りだったんだけど、アツトが大怪我したって聞いて急いで病院に行った。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("そしたら全然大したこと無くって、心配して損した気分。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("〇月✕日");
        yield return StartCoroutine("Skip");

        uitext.DrawText("今病院に居て、アツトが死んじゃうかもって。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("私を庇ってアツトがトラックにひかれちゃった…。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("やだやだやだ、死なないで。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("お願いします神様。アツトを助けてください。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("・・・・・・・・・・・・・・・");
        yield return StartCoroutine("Skip");

        uitext.DrawText("・・・・・・・・・・・・・・・");
        yield return StartCoroutine("Skip");

        uitext.DrawText("暫くページが白紙のままだ");
        yield return StartCoroutine("Skip");

        uitext.DrawText("✕月✕日");
        yield return StartCoroutine("Skip");

        uitext.DrawText("お母さんお父さん今まで心配かけてごめんなさい。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("やっぱり私にとって、アツトが居ない世界は価値があり得ません。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("だから、アツトに会いに行こうと思います。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("とっても勝手でごめんなさい。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("もう耐えられないみたいなの…。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("ーーーーーーーーーーーーーー");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ソラの日記だ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "やっぱりそうだよな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ソラと俺は釣り合っちまったんだ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "あの天秤によって。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "お互いに。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "苦しさから逃げちまったから…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "でも、こうして俺はソラの辛さも全部抱えて。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ソラはまだ全てを思い出せたわけじゃ無い。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "まだ間に合う。俺がソラを救うんだ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "生かして見せる。アツトの為にも。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator lampStory1()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "このランプはどれも点灯してねぇな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "んぁ？ここに何か書いてあるな…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("ボタンを押せ。正しい順序で灯せ。");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ボタンねぇ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ボタンッて―と、あの時の…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "順序はどうするんだぁ？");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        uitext.DrawText("ここからは各所のボタンを押すことでそれに連動したランプが光ります。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("全て正しい順序で押さないと、四つ目のボタンを押したときにハカリが一言喋ってランプが全て消えます。");
        yield return StartCoroutine("Skip");

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator lastButtonStory1()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        uitext.DrawText("ボタンを押した");
        yield return StartCoroutine("Skip");

        if(boymove.lastButtonCount == 0)
        {
            light1.SetActive(true);
        }
        if (boymove.lastButtonCount == 1)
        {
            light2.SetActive(true);
        }
        if (boymove.lastButtonCount == 2)
        {
            light3.SetActive(true);
        }
        if (boymove.lastButtonCount == 3)
        {
            light4.SetActive(true);
        }

        boymove.lastButtonCount++;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator lastButtonStory2()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        fadeIn.fadeOutFlag = true;

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "…………………………………");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        lostObject1.SetActive(false);
        lostObject2.SetActive(false);
        lostObject3.SetActive(false);
        lostObject4.SetActive(false);
        lostObject5.SetActive(false);
        lostObject6.SetActive(false);
        lostObject7.SetActive(false);

        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);

        boymove.lastButtonCount = 0;

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "これでどうだ…？一旦戻ってみるかぁ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        fadeIn.fadeFlag = true;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator lastButtonStory3()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        fadeIn.fadeOutFlag = true;
        boy.SetActive(true);
        uitext.DrawText("ハカリ", "んぁ？なんかミスった気がすんな…");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);
        fadeIn.fadeFlag = true;

        boymove.lastButtonCount = 0;
        boymove.lastButtonFlag = false;

        light1.SetActive(false);
        light2.SetActive(false);
        light3.SetActive(false);
        light4.SetActive(false);

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
    }

    IEnumerator laboStory()
    {
        Canbus.SetActive(true);
        girl_fear.SetActive(false);
        boy.SetActive(false);
        boy_fear.SetActive(false);
        girl.SetActive(false);
        investigate2.SetActive(false);

        uitext.DrawText("まず一つ正しておこう。あの天秤の名前だが、本当は均衡の天秤というらしい。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("そして、あの天秤には二つのルールがある。一つは願いに釣り合う対価を求めることだ。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("そして二つは対価を先に指定することも出来るということだ。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("勿論それが釣り合っているかを決めるのは天秤だが。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("これが上手く扱えればある程度のリスクは回避できるだろう。");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "そうか………！");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "これなら、ソラを救えるかもしれねぇ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        fadeIn.fadeOutFlag = true;

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ソラか…？！");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girlObject.SetActive(true);
        playerChange.moveFlag = true;
        playerTeleport.SetPosition(-70.17f, 219.09f);
        boyTeleport.SetPosition(-68.17f, 219.09f);

        fadeIn.fadeFlag = true;

        girl.SetActive(true);
        uitext.DrawText("ソラ", "良かったっ！！ハカリさんっ！！！");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "おぉ！無事だったんだなっ");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        fadeIn.fadeOutFlag = true;

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "なるほど。ソラが俺との合流を願ってくれたんだな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        fadeIn.fadeFlag = true;

        girl.SetActive(true);
        uitext.DrawText("ソラ", "はい。その…一人になったとたん足がすくんでしまって。");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "いきなりだったもんなぁ。無理もない。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ごめんなさい。そのせいで探索は全く…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "んぁ、その点は心配すんな。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "脱出の糸口は見つかったからよ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "えっ！本当ですかっ！？");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "おう。だから…もう一度だけ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "今度は俺が、この均衡の天秤を使う。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "安心してくれ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ソラだけは絶対に助けてやる。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "えっ、それってどういう…");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        fadeIn.fadeOutFlag = true;

        uitext.DrawText("束の間、ハカリは半ば強引にソラを部屋の外に追い出し、");
        yield return StartCoroutine("Skip");

        uitext.DrawText("「信じてくれ。」とだけ伝えて扉を閉めました。");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ハカリさんっ？！");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("ソラは嫌な予感を覚えます。");
        yield return StartCoroutine("Skip");

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ハカリさんっ！！！");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("ハカリは呼吸を整えて、決意を固めた様に言いました。");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "本当はもう、とっくのとうに決めてたことなのにな…。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "ハカリさんっ！！ハカリさんっ！！！");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);

        uitext.DrawText("ソラの声が、扉越しのハカリの耳に響く。");
        yield return StartCoroutine("Skip");

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "………");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "均衡の天秤さんよぉ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "俺の命と引き換えだ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        boy.SetActive(true);
        uitext.DrawText("ハカリ", "ソラを元の世界に返してやってくれ。");
        yield return StartCoroutine("Skip");
        boy.SetActive(false);

        girl.SetActive(true);
        uitext.DrawText("ソラ", "……！");
        yield return StartCoroutine("Skip");
        girl.SetActive(false);


        uitext.DrawText("どうやら、ソラの予感は当たった様でした。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("ソラの体が光に溶ける様にこの世界から離れていきます。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("それと同時に、ハカリの存在や記憶全てが、世界から消えていく。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("ソラには確かに、それが分りました。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("ソラの、苦しみを取り除くように。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("二人の存在がその世界から消えさった時、ソラは目を覚まします。");
        yield return StartCoroutine("Skip");

        fadeIn.fadeFlag = true;

        uitext.DrawText("青空が見える。");
        yield return StartCoroutine("Skip");

        uitext.DrawText("そして病院の五階が見えて三階が見えて………");
        yield return StartCoroutine("Skip");

        uitext.DrawText("あれ、私はなんで落ちているんだっけ………");
        yield return StartCoroutine("Skip");

        gameEndFlag = true;

        Canbus.SetActive(false);
        gameStop.stopFlag = false;
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
            //playerTeleport.SetPosition(-6.25f, 156.93f);
            //boyTeleport.SetPosition(-4.25f, 156.93f);
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
        if(TextNum == 84)
        {
            gameStop.stopFlag = true;
            StartCoroutine("undergroundStory2");
            TextNum = 85;
        }
        if(TextNum == 86)
        {
            gameStop.stopFlag = true;
            StartCoroutine("operoom45Story");
            TextNum = 87;
        }
        if(TextNum == 88)
        {
            gameStop.stopFlag = true;
            StartCoroutine("operoom45Story2");
            TextNum = 89;
        }
        if(TextNum == 90)
        {
            gameStop.stopFlag = true;
            StartCoroutine("operoom45Story3");
            TextNum = 91;
        }
        if(TextNum == 92)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueButtonRoom");
            TextNum = 93;
        }
        if(TextNum == 94)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueButtonRoomStory1");
            TextNum = 95;
        }
        if(TextNum == 96)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueButtonRoomStory2");
            TextNum = 97;
        }
        if(TextNum == 98)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomDeskStory");
            TextNum = 99;
        }
        if(TextNum == 100)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomBedStory1");
            TextNum = 101;
        }
        if (TextNum == 102)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomBedStory2");
            TextNum = 103;
        }
        if (TextNum == 104)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomBedStory3");
            TextNum = 105;
        }
        if (TextNum == 106)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomBedStory4");
            TextNum = 107;
        }
        if (TextNum == 108)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomBedStory5");
            TextNum = 109;
        }
        if(TextNum == 110)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomBookShefStory");
            TextNum = 111;
        }
        if(TextNum == 112)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomLeverStory");
            TextNum = 113;
        }
        if(TextNum == 114)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomChairStory");
            TextNum = 115;
        }
        if(TextNum == 116)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomRoundDeskStory");
            TextNum = 117;
        }
        if(TextNum == 118)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoomStatueStory");
            TextNum = 119;
        }
        if (TextNum == 120)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoom2RoundDeskStory");
            TextNum = 121;
        }
        if (TextNum == 122)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoom2BedStory");
            TextNum = 123;
        }
        if (TextNum == 124)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoom2LeverStory");
            TextNum = 125;
        }
        if (TextNum == 126)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoom2StatueStory");
            TextNum = 127;
        }
        if (TextNum == 128)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoom2ChairStory");
            TextNum = 129;
        }
        if (TextNum == 130)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoom2DeskStory");
            TextNum = 131;
        }
        if (TextNum == 132)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoom2BookShefStory");
            TextNum = 133;
        }
        if(TextNum == 134)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoom2StatueStory2");
            TextNum = 135;
        }
        if(TextNum == 136)
        {
            gameStop.stopFlag = true;
            StartCoroutine("blueRoom2ChairStory2");
            TextNum = 137;
        }
        if(TextNum == 138)
        {
            gameStop.stopFlag = true;
            StartCoroutine("openBlueRoomStory");
            TextNum = 139;
        }
        if(TextNum == 140)
        {
            gameStop.stopFlag = true;
            StartCoroutine("whiteMistStory1");
            TextNum = 141;
        }
        if (TextNum == 142)
        {
            gameStop.stopFlag = true;
            StartCoroutine("whiteMistStory2");
            TextNum = 143;
        }
        if(TextNum == 144)
        {
            gameStop.stopFlag = true;
            StartCoroutine("opeRoomDeskStory");
            TextNum = 145;
        }
        if(TextNum == 146)
        {
            gameStop.stopFlag = true;
            StartCoroutine("classRoom1MisteryStory");
            TextNum = 147;
        }
        if(TextNum == 148)
        {
            gameStop.stopFlag = true;
            StartCoroutine("classRoom1MisteryStory2");
            TextNum = 149;
        }
        if(TextNum == 150)
        {
            gameStop.stopFlag = true;
            StartCoroutine("A_DeskStory");
            TextNum = 151;
        }
        if (TextNum == 152)
        {
            gameStop.stopFlag = true;
            StartCoroutine("B_DeskStory");
            TextNum = 153;
        }
        if (TextNum == 154)
        {
            gameStop.stopFlag = true;
            StartCoroutine("C_DeskStory");
            TextNum = 155;
        }
        if (TextNum == 156)
        {
            gameStop.stopFlag = true;
            StartCoroutine("D_DeskStory");
            TextNum = 157;
        }
        if(TextNum == 158)
        {
            gameStop.stopFlag = true;
            StartCoroutine("DeskStory");
            TextNum = 159;
        }
        if(TextNum == 160)
        {
            gameStop.stopFlag = true;
            StartCoroutine("teacherRoomStory1");
            TextNum = 161;
        }
        if(TextNum == 162)
        {
            gameStop.stopFlag = true;
            StartCoroutine("teacherDeskStory1");
            TextNum = 163;
        }
        if (TextNum == 164)
        {
            gameStop.stopFlag = true;
            StartCoroutine("teacherDeskStory2");
            TextNum = 165;
        }
        if (TextNum == 166)
        {
            gameStop.stopFlag = true;
            StartCoroutine("teacherDeskStory3");
            TextNum = 167;
        }
        if (TextNum == 168)
        {
            gameStop.stopFlag = true;
            StartCoroutine("teacherDeskStory4");
            TextNum = 169;
        }
        if(TextNum == 170)
        {
            gameStop.stopFlag = true;
            StartCoroutine("whiteMistStory3");
            TextNum = 171;
        }
        if(TextNum == 172)
        {
            gameStop.stopFlag = true;
            StartCoroutine("lastGimmickRoomStory");
            TextNum = 173;
        }
        if(TextNum == 174)
        {
            gameStop.stopFlag = true;
            StartCoroutine("lastRoomBookStory");
            TextNum = 175;
        }
        if (TextNum == 176)
        {
            gameStop.stopFlag = true;
            StartCoroutine("lampStory1");
            TextNum = 177;
        }
        if(TextNum == 178)
        {
            gameStop.stopFlag = true;
            StartCoroutine("lastButtonStory1");
            TextNum = 179;
        }
        if (TextNum == 180)
        {
            gameStop.stopFlag = true;
            StartCoroutine("lastButtonStory2");
            TextNum = 181;
        }
        if (TextNum == 182)
        {
            gameStop.stopFlag = true;
            StartCoroutine("lastButtonStory3");
            TextNum = 183;
        }
        if (TextNum == 184)
        {
            gameStop.stopFlag = true;
            StartCoroutine("laboStory");
            TextNum = 185;
        }

        if (A_DeskStoryFlag == true && B_DeskStoryFlag == true && C_DeskStoryFlag == true && D_DeskStoryFlag == true && DeskStoryFlag == false)
        {
            TextNum = 158;
            DeskStoryFlag = true;
        }

        if (playermove.blueRoomFlag == true && boymove.blueRoomFlag == true && openBlueRoomFlag == false)
        {
            TextNum = 138;
            openBlueRoomFlag = true;
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

        //ToBeContinue
        if (gameEndFlag == true)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
