using UnityEngine;
using UnityEngine.UI;

public class playerGetItem : MonoBehaviour
{
    public Sprite imageKey;
    [SerializeField] Sprite imageSowing;
    [SerializeField] Sprite imageMenu;
    [SerializeField] Sprite imageMenuImportant;
    [SerializeField] Sprite nowItems;
    public Image itemPhoto1;
    public Image itemPhoto2;
    public Image itemPhoto3;
    public Image itemPhoto4;
    public Image itemPhoto5;
    public Image itemPhoto6;
    public Image itemPhoto7;
    public Image itemPhoto8;
    public Image itemPhoto9;
    public bool haveOpeKey = false;
    public bool haveIronKey = false;
    public bool openMenu = false;
    public bool sowingGet1 = false;
    public bool sowingGet2 = false;
    public bool isUseOpeKey;
    public bool isUseIronKey;
    public bool isUseSowing;
    public int nowItemNumber = 1;
    public int nowMenuNumber = 1;
    private bool isOpenedFlag1;
    private bool isOpenedFlag2;
    private bool isOpenedFlag3;
    private bool isOpenedFlag4;
    private bool isOpenedFlag5;
    private bool isOpenedFlag6;
    private bool isOpenedFlag7;
    private bool isOpenedFlag8;
    private bool isOpenedFlag9;

    [SerializeField] Image menuPhoto;
    [SerializeField] Image itemFrame1;
    [SerializeField] Image itemFrame2;
    [SerializeField] Image itemFrame3;
    [SerializeField] Image itemFrame4;
    [SerializeField] Image itemFrame5;
    [SerializeField] Image itemFrame6;
    [SerializeField] Image itemFrame7;
    [SerializeField] Image itemFrame8;
    [SerializeField] Image itemFrame9;

    private HPSpriteChange hpSprite;

    private publicFlag gameStop;

    private Password password;

    private PlayerInputSystem inputAction;

    private int nowSowing;
    // Start is called before the first frame update
    void Start()
    {
        inputAction = new PlayerInputSystem();
        inputAction.Enable();
        itemPhoto1 = GameObject.Find("ImageItemPanel1").GetComponent<Image>();
        itemPhoto2 = GameObject.Find("ImageItemPanel2").GetComponent<Image>();
        itemPhoto3 = GameObject.Find("ImageItemPanel3").GetComponent<Image>();
        itemPhoto4 = GameObject.Find("ImageItemPanel4").GetComponent<Image>();
        itemPhoto5 = GameObject.Find("ImageItemPanel5").GetComponent<Image>();
        itemPhoto6 = GameObject.Find("ImageItemPanel6").GetComponent<Image>();
        itemPhoto7 = GameObject.Find("ImageItemPanel7").GetComponent<Image>();
        itemPhoto8 = GameObject.Find("ImageItemPanel8").GetComponent<Image>();
        itemPhoto9 = GameObject.Find("ImageItemPanel9").GetComponent<Image>();
        menuPhoto = GameObject.Find("menuPanel").GetComponent<Image>();
        itemFrame1 = GameObject.Find("NowMenu1").GetComponent<Image>();
        itemFrame2 = GameObject.Find("NowMenu2").GetComponent<Image>();
        itemFrame3 = GameObject.Find("NowMenu3").GetComponent<Image>();
        itemFrame4 = GameObject.Find("NowMenu4").GetComponent<Image>();
        itemFrame5 = GameObject.Find("NowMenu5").GetComponent<Image>();
        itemFrame6 = GameObject.Find("NowMenu6").GetComponent<Image>();
        itemFrame7 = GameObject.Find("NowMenu7").GetComponent<Image>();
        itemFrame8 = GameObject.Find("NowMenu8").GetComponent<Image>();
        itemFrame9 = GameObject.Find("NowMenu9").GetComponent<Image>();
        itemFrame1.enabled = false;
        itemFrame2.enabled = false;
        itemFrame3.enabled = false;
        itemFrame4.enabled = false;
        itemFrame5.enabled = false;
        itemFrame6.enabled = false;
        itemFrame7.enabled = false;
        itemFrame8.enabled = false;
        itemFrame9.enabled = false;
        nowItemNumber = 1;
        itemPhoto1.enabled = false;
        itemPhoto2.enabled = false;
        itemPhoto3.enabled = false;
        itemPhoto4.enabled = false;
        itemPhoto5.enabled = false;
        itemPhoto6.enabled = false;
        itemPhoto7.enabled = false;
        itemPhoto8.enabled = false;
        itemPhoto9.enabled = false;
        menuPhoto.enabled = false;
        isOpenedFlag1 = false;
        isOpenedFlag2 = false;
        isOpenedFlag3 = false;
        isUseOpeKey = false;
        isUseIronKey = false;
        isUseSowing = false;
        hpSprite = GameObject.Find("HP").GetComponent<HPSpriteChange>();

        gameStop = GameObject.Find("GameManager").GetComponent<publicFlag>();

        password = GameObject.Find("player").GetComponent<Password>();
        nowSowing = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (inputAction.Player.ChangeMenuScreen.triggered && gameStop.stopFlag == false)
        {
            if (openMenu == false)
            {
                gameStop.stopFlag = true;
                gameStop.hitFlag = true;
                openMenu = true;
            }
        }
        else if (inputAction.Player.ChangeMenuScreen.triggered)
        {
            if (openMenu == true)
            {
                gameStop.stopFlag = false;
                gameStop.hitFlag = false;
                openMenu = false;
            }
        }
        if (openMenu == true)
        {
            if (nowMenuNumber == 1)
            {
                menuPhoto.enabled = true;
                menuPhoto.sprite = imageMenu;
            }
            else if (nowMenuNumber == 2)
            {
                menuPhoto.enabled = true;
                menuPhoto.sprite = imageMenuImportant;
            }
            if (nowItemNumber < 9 && inputAction.Player.MoveRight.triggered)
            {
                nowItemNumber++;
            }
            else if (nowItemNumber == 9 && inputAction.Player.MoveRight.triggered)
            {
                nowItemNumber = 1;
            }
            if (nowItemNumber > 1 && inputAction.Player.MoveLeft.triggered)
            {
                nowItemNumber--;
            }
            else if (nowItemNumber == 1 && inputAction.Player.MoveLeft.triggered)
            {
                nowItemNumber = 9;
            }
            if (nowItemNumber == 1)
            {
                itemFrame1.enabled = true;
                itemFrame1.sprite = nowItems;
                itemFrame2.enabled = false;
                itemFrame3.enabled = false;
                itemFrame4.enabled = false;
                itemFrame5.enabled = false;
                itemFrame6.enabled = false;
                itemFrame7.enabled = false;
                itemFrame8.enabled = false;
                itemFrame9.enabled = false;
            }
            if (nowItemNumber == 2)
            {
                itemFrame1.enabled = false;
                itemFrame2.enabled = true;
                itemFrame2.sprite = nowItems;
                itemFrame3.enabled = false;
                itemFrame4.enabled = false;
                itemFrame5.enabled = false;
                itemFrame6.enabled = false;
                itemFrame7.enabled = false;
                itemFrame8.enabled = false;
                itemFrame9.enabled = false;
            }
            if (nowItemNumber == 3)
            {
                itemFrame1.enabled = false;
                itemFrame2.enabled = false;
                itemFrame3.enabled = true;
                itemFrame3.sprite = nowItems;
                itemFrame4.enabled = false;
                itemFrame5.enabled = false;
                itemFrame6.enabled = false;
                itemFrame7.enabled = false;
                itemFrame8.enabled = false;
                itemFrame9.enabled = false;
            }
            if (nowItemNumber == 4)
            {
                itemFrame1.enabled = false;
                itemFrame2.enabled = false;
                itemFrame3.enabled = false;
                itemFrame4.enabled = true;
                itemFrame4.sprite = nowItems;
                itemFrame5.enabled = false;
                itemFrame6.enabled = false;
                itemFrame7.enabled = false;
                itemFrame8.enabled = false;
                itemFrame9.enabled = false;
            }
            if (nowItemNumber == 5)
            {
                itemFrame1.enabled = false;
                itemFrame2.enabled = false;
                itemFrame3.enabled = false;
                itemFrame4.enabled = false;
                itemFrame5.enabled = true;
                itemFrame5.sprite = nowItems;
                itemFrame6.enabled = false;
                itemFrame7.enabled = false;
                itemFrame8.enabled = false;
                itemFrame9.enabled = false;
            }
            if (nowItemNumber == 6)
            {
                itemFrame1.enabled = false;
                itemFrame2.enabled = false;
                itemFrame3.enabled = false;
                itemFrame4.enabled = false;
                itemFrame5.enabled = false;
                itemFrame6.enabled = true;
                itemFrame6.sprite = nowItems;
                itemFrame7.enabled = false;
                itemFrame8.enabled = false;
                itemFrame9.enabled = false;
            }
            if (nowItemNumber == 7)
            {
                itemFrame1.enabled = false;
                itemFrame2.enabled = false;
                itemFrame3.enabled = false;
                itemFrame4.enabled = false;
                itemFrame5.enabled = false;
                itemFrame6.enabled = false;
                itemFrame7.enabled = true;
                itemFrame7.sprite = nowItems;
                itemFrame8.enabled = false;
                itemFrame9.enabled = false;
            }
            if (nowItemNumber == 8)
            {
                itemFrame1.enabled = false;
                itemFrame2.enabled = false;
                itemFrame3.enabled = false;
                itemFrame4.enabled = false;
                itemFrame5.enabled = false;
                itemFrame6.enabled = false;
                itemFrame7.enabled = false;
                itemFrame8.enabled = true;
                itemFrame8.sprite = nowItems;
                itemFrame9.enabled = false;
            }
            if (nowItemNumber == 9)
            {
                itemFrame1.enabled = false;
                itemFrame2.enabled = false;
                itemFrame3.enabled = false;
                itemFrame4.enabled = false;
                itemFrame5.enabled = false;
                itemFrame6.enabled = false;
                itemFrame7.enabled = false;
                itemFrame8.enabled = false;
                itemFrame9.enabled = true;
                itemFrame9.sprite = nowItems;
            }
        }
        else
        {
            itemFrame1.enabled = false;
            itemFrame2.enabled = false;
            itemFrame3.enabled = false;
            itemFrame4.enabled = false;
            itemFrame5.enabled = false;
            itemFrame6.enabled = false;
            itemFrame7.enabled = false;
            itemFrame8.enabled = false;
            itemFrame9.enabled = false;
            menuPhoto.enabled = false;
        }
        //アイテムを使うとき
        if (nowMenuNumber == 1)
        {
            if (openMenu == true)
            {
                if (inputAction.Player.MoveDown.triggered)
                {
                    nowMenuNumber = 2;
                    nowItemNumber = 1;
                }
            }

            if (haveOpeKey == true)
            {
                if (openMenu == true)
                {
                    if (isOpenedFlag1 == false)
                    {
                        if (itemPhoto1.enabled == false)
                        {
                            itemPhoto1.enabled = true;
                            itemPhoto1.sprite = imageKey;
                        }
                        else if (itemPhoto2.enabled == false)
                        {
                            itemPhoto2.enabled = true;
                            itemPhoto2.sprite = imageKey;
                        }
                        else if (itemPhoto3.enabled == false)
                        {
                            itemPhoto3.enabled = true;
                            itemPhoto3.sprite = imageKey;
                        }
                        else if (itemPhoto4.enabled == false)
                        {
                            itemPhoto4.enabled = true;
                            itemPhoto4.sprite = imageKey;
                        }
                        else if (itemPhoto5.enabled == false)
                        {
                            itemPhoto5.enabled = true;
                            itemPhoto5.sprite = imageKey;
                        }
                        else if (itemPhoto6.enabled == false)
                        {
                            itemPhoto6.enabled = true;
                            itemPhoto6.sprite = imageKey;
                        }
                        else if (itemPhoto7.enabled == false)
                        {
                            itemPhoto7.enabled = true;
                            itemPhoto7.sprite = imageKey;
                        }
                        else if (itemPhoto8.enabled == false)
                        {
                            itemPhoto8.enabled = true;
                            itemPhoto8.sprite = imageKey;
                        }
                        else if (itemPhoto9.enabled == false)
                        {
                            itemPhoto9.enabled = true;
                            itemPhoto9.sprite = imageKey;
                        }
                        isOpenedFlag1 = true;
                    }
                }
                else
                {
                    isOpenedFlag1 = false;
                    itemPhoto1.enabled = false;
                    itemPhoto2.enabled = false;
                    itemPhoto3.enabled = false;
                    itemPhoto4.enabled = false;
                    itemPhoto5.enabled = false;
                    itemPhoto6.enabled = false;
                    itemPhoto7.enabled = false;
                    itemPhoto8.enabled = false;
                    itemPhoto9.enabled = false;
                }
                //if (inputAction.Player.UseItem.triggered)//if文増やして座標を指定する処理を追加したい
                //{
                //    Debug.Log("手術室のカギを使った");
                //    //アイテムを使った時の処理を書いてほしい
                //    haveOpeKey = false;
                //    itemPhoto1.enabled = false;
                //    itemPhoto2.enabled = false;
                //}
            }
            if (haveIronKey == true)
            {
                if (openMenu == true)
                {
                    if (isOpenedFlag2 == false)
                    {
                        if (itemPhoto1.enabled == false)
                        {
                            itemPhoto1.enabled = true;
                            itemPhoto1.sprite = imageKey;
                        }
                        else if (itemPhoto2.enabled == false)
                        {
                            itemPhoto2.enabled = true;
                            itemPhoto2.sprite = imageKey;
                        }
                        else if (itemPhoto3.enabled == false)
                        {
                            itemPhoto3.enabled = true;
                            itemPhoto3.sprite = imageKey;
                        }
                        else if (itemPhoto4.enabled == false)
                        {
                            itemPhoto4.enabled = true;
                            itemPhoto4.sprite = imageKey;
                        }
                        else if (itemPhoto5.enabled == false)
                        {
                            itemPhoto5.enabled = true;
                            itemPhoto5.sprite = imageKey;
                        }
                        else if (itemPhoto6.enabled == false)
                        {
                            itemPhoto6.enabled = true;
                            itemPhoto6.sprite = imageKey;
                        }
                        else if (itemPhoto7.enabled == false)
                        {
                            itemPhoto7.enabled = true;
                            itemPhoto7.sprite = imageKey;
                        }
                        else if (itemPhoto8.enabled == false)
                        {
                            itemPhoto8.enabled = true;
                            itemPhoto8.sprite = imageKey;
                        }
                        else if (itemPhoto9.enabled == false)
                        {
                            itemPhoto9.enabled = true;
                            itemPhoto9.sprite = imageKey;
                        }
                        isOpenedFlag2 = true;
                    }
                }
                else
                {
                    isOpenedFlag2 = false;
                    itemPhoto1.enabled = false;
                    itemPhoto2.enabled = false;
                    itemPhoto3.enabled = false;
                    itemPhoto4.enabled = false;
                    itemPhoto5.enabled = false;
                    itemPhoto6.enabled = false;
                    itemPhoto7.enabled = false;
                    itemPhoto8.enabled = false;
                    itemPhoto9.enabled = false;
                }
                //if (inputAction.Player.UseItem.triggered)//if文増やして座標を指定する処理を追加したい
                //{
                //    Debug.Log("手術室のカギを使った");
                //    //アイテムを使った時の処理を書いてほしい
                //    haveOpeKey = false;
                //    itemPhoto1.enabled = false;
                //    itemPhoto2.enabled = false;
                //}
            }
            if (sowingGet1 == true)
            {
                if (openMenu == true)
                {
                    if (isOpenedFlag3 == false)
                    {
                        if (itemPhoto1.enabled == false)
                        {
                            itemPhoto1.enabled = true;
                            itemPhoto1.sprite = imageSowing;
                        }
                        else if (itemPhoto2.enabled == false)
                        {
                            itemPhoto2.enabled = true;
                            itemPhoto2.sprite = imageSowing;
                        }
                        else if (itemPhoto3.enabled == false)
                        {
                            itemPhoto3.enabled = true;
                            itemPhoto3.sprite = imageSowing;
                        }
                        else if (itemPhoto4.enabled == false)
                        {
                            itemPhoto4.enabled = true;
                            itemPhoto4.sprite = imageSowing;
                        }
                        else if (itemPhoto5.enabled == false)
                        {
                            itemPhoto5.enabled = true;
                            itemPhoto5.sprite = imageSowing;
                        }
                        else if (itemPhoto6.enabled == false)
                        {
                            itemPhoto6.enabled = true;
                            itemPhoto6.sprite = imageSowing;
                        }
                        else if (itemPhoto7.enabled == false)
                        {
                            itemPhoto7.enabled = true;
                            itemPhoto7.sprite = imageSowing;
                        }
                        else if (itemPhoto8.enabled == false)
                        {
                            itemPhoto8.enabled = true;
                            itemPhoto8.sprite = imageSowing;
                        }
                        else if (itemPhoto9.enabled == false)
                        {
                            itemPhoto9.enabled = true;
                            itemPhoto9.sprite = imageSowing;
                        }
                        isOpenedFlag3 = true;
                    }
                    if (inputAction.Player.UseItem.triggered)//if文増やして座標を指定する処理を追加したい
                    {
                        if (isUseSowing == true)
                        {
                            hpSprite.HP = 5;
                            //アイテムを使った時の処理を書いてほしい
                            if (itemPhoto1.sprite == imageSowing)
                            {
                                itemPhoto1.enabled = false;
                            }
                            else if (itemPhoto2.sprite == imageSowing)
                            {
                                itemPhoto2.enabled = false;
                            }
                            else if (itemPhoto3.sprite == imageSowing)
                            {
                                itemPhoto3.enabled = false;
                            }
                            else if (itemPhoto4.sprite == imageSowing)
                            {
                                itemPhoto4.enabled = false;
                            }
                            else if (itemPhoto5.sprite == imageSowing)
                            {
                                itemPhoto5.enabled = false;
                            }
                            else if (itemPhoto6.sprite == imageSowing)
                            {
                                itemPhoto6.enabled = false;
                            }
                            else if (itemPhoto7.sprite == imageSowing)
                            {
                                itemPhoto7.enabled = false;
                            }
                            else if (itemPhoto8.sprite == imageSowing)
                            {
                                itemPhoto8.enabled = false;
                            }
                            else if (itemPhoto9.sprite == imageSowing)
                            {
                                itemPhoto9.enabled = false;
                            }
                            sowingGet1 = false;
                            nowSowing = 2;
                        }
                    }
                }
                else
                {
                    isOpenedFlag3 = false;
                    itemPhoto1.enabled = false;
                    itemPhoto2.enabled = false;
                    itemPhoto3.enabled = false;
                    itemPhoto4.enabled = false;
                    itemPhoto5.enabled = false;
                    itemPhoto6.enabled = false;
                    itemPhoto7.enabled = false;
                    itemPhoto8.enabled = false;
                    itemPhoto9.enabled = false;
                }
            }
        }
        else
        {
            if (openMenu == true)
            {
                if (inputAction.Player.MoveUp.triggered)
                {
                    nowMenuNumber = 1;
                    nowItemNumber = 1;
                }
            }
            isOpenedFlag1 = false;
            isOpenedFlag2 = false;
            isOpenedFlag3 = false;
            isOpenedFlag4 = false;

            itemPhoto1.enabled = false;
            itemPhoto2.enabled = false;
            itemPhoto3.enabled = false;
            itemPhoto4.enabled = false;
            itemPhoto5.enabled = false;
            itemPhoto6.enabled = false;
            itemPhoto7.enabled = false;
            itemPhoto8.enabled = false;
            itemPhoto9.enabled = false;
        }

        if (openMenu == true)
        {
            if (nowItemNumber == 1)
            {
                if (itemPhoto1.sprite == imageKey)
                {
                    isUseOpeKey = true;
                    isUseIronKey = true;
                    isUseSowing = false;
                }
                else if (itemPhoto1.sprite == imageSowing)
                {
                    isUseOpeKey = false;
                    isUseIronKey = false;
                    isUseSowing = true;
                }
                else
                {
                    isUseOpeKey = false;
                    isUseIronKey = false;
                    isUseSowing = false;
                }
            }
            else if (nowItemNumber == 2)
            {
                if (itemPhoto2.sprite == imageKey)
                {
                    isUseOpeKey = true;
                    isUseIronKey = true;
                    isUseSowing = false;
                }
                else if (itemPhoto2.sprite == imageSowing)
                {
                    isUseOpeKey = false;
                    isUseIronKey = false;
                    isUseSowing = true;
                }
                else
                {
                    isUseOpeKey = false;
                    isUseIronKey = false;
                    isUseSowing = false;
                }
            }
            else if (nowItemNumber == 3)
            {
                if (itemPhoto3.sprite == imageKey)
                {
                    isUseOpeKey = true;
                    isUseIronKey = true;
                    isUseSowing = false;
                }
                else if (itemPhoto3.sprite == imageSowing)
                {
                    isUseOpeKey = false;
                    isUseIronKey = false;
                    isUseSowing = true;
                }
                else
                {
                    isUseOpeKey = false;
                    isUseIronKey = false;
                    isUseSowing = false;
                }
            }
            else if (nowItemNumber == 4)
            {
                if (itemPhoto4.sprite == imageKey)
                {
                    isUseOpeKey = true;
                    isUseIronKey = true;
                    isUseSowing = false;
                }
                else if (itemPhoto4.sprite == imageSowing)
                {
                    isUseOpeKey = false;
                    isUseIronKey = false;
                    isUseSowing = true;
                }
                else
                {
                    isUseOpeKey = false;
                    isUseIronKey = false;
                    isUseSowing = false;
                }
            }
            else if (nowItemNumber == 5)
            {
                if (itemPhoto5.sprite == imageKey)
                {
                    isUseOpeKey = true;
                    isUseIronKey = true;
                    isUseSowing = false;
                }
                else if (itemPhoto5.sprite == imageSowing)
                {
                    isUseOpeKey = false;
                    isUseIronKey = false;
                    isUseSowing = true;
                }
                else
                {
                    isUseOpeKey = false;
                    isUseIronKey = false;
                    isUseSowing = false;
                }
            }
            else if (nowItemNumber == 6)
            {
                if (itemPhoto6.sprite == imageKey)
                {
                    isUseOpeKey = true;
                    isUseIronKey = true;
                    isUseSowing = false;
                }
                else if (itemPhoto6.sprite == imageSowing)
                {
                    isUseOpeKey = false;
                    isUseIronKey = false;
                    isUseSowing = true;
                }
                else
                {
                    isUseOpeKey = false;
                    isUseIronKey = false;
                    isUseSowing = false;
                }
            }
            else if (nowItemNumber == 7)
            {
                if (itemPhoto7.sprite == imageKey)
                {
                    isUseOpeKey = true;
                    isUseIronKey = true;
                    isUseSowing = false;
                }
                else if (itemPhoto7.sprite == imageSowing)
                {
                    isUseOpeKey = false;
                    isUseIronKey = false;
                    isUseSowing = true;
                }
                else
                {
                    isUseOpeKey = false;
                    isUseIronKey = false;
                    isUseSowing = false;
                }
            }
            else if (nowItemNumber == 8)
            {
                if (itemPhoto8.sprite == imageKey)
                {
                    isUseOpeKey = true;
                    isUseIronKey = true;
                    isUseSowing = false;
                }
                else if (itemPhoto8.sprite == imageSowing)
                {
                    isUseOpeKey = false;
                    isUseIronKey = false;
                    isUseSowing = true;
                }
                else
                {
                    isUseOpeKey = false;
                    isUseIronKey = false;
                    isUseSowing = false;
                }
            }
            else if (nowItemNumber == 9)
            {
                if (itemPhoto9.sprite == imageKey)
                {
                    isUseOpeKey = true;
                    isUseIronKey = true;
                    isUseSowing = false;
                }
                else if (itemPhoto9.sprite == imageSowing)
                {
                    isUseOpeKey = false;
                    isUseIronKey = false;
                    isUseSowing = true;
                }
                else
                {
                    isUseOpeKey = false;
                    isUseIronKey = false;
                    isUseSowing = false;
                }
            }
        }
    }
}