using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class playerGetItem : MonoBehaviour
{
    [SerializeField] Sprite imageKey;
    [SerializeField] Sprite imageItem;
    [SerializeField] Sprite imageMenu;
    public Image itemPhoto1;
    public Image itemPhoto2;
    [SerializeField] Image menuPhoto;
    //[SerializeField] Image itemFrame1;
    //[SerializeField] Image itemFrame2;
    //[SerializeField] Image itemFrame3;
    //[SerializeField] Image itemFrame4;
    //[SerializeField] Image itemFrame5;
    //[SerializeField] Image itemFrame6;
    //[SerializeField] Image itemFrame7;
    //[SerializeField] Image itemFrame8;
    //[SerializeField] Image itemFrame9;
    public bool haveOpeKey = false;
    public bool openMenu = false;
    public bool sowingGet = false;

    private publicFlag gameStop;

    private Password password;

    private PlayerInputSystem inputAction;
    // Start is called before the first frame update
    void Start()
    {
        inputAction = new PlayerInputSystem();
        inputAction.Enable();
        itemPhoto1 = GameObject.Find("ImageItemPanel1").GetComponent<Image>();
        itemPhoto2 = GameObject.Find("ImageItemPanel2").GetComponent<Image>();
        menuPhoto = GameObject.Find("menuPanel").GetComponent<Image>();
        //itemFrame1 = GameObject.Find("ItemFrame1").GetComponent<Image>();
        //itemFrame2 = GameObject.Find("ItemFrame2").GetComponent<Image>();
        //itemFrame3 = GameObject.Find("ItemFrame3").GetComponent<Image>();
        //itemFrame4 = GameObject.Find("ItemFrame4").GetComponent<Image>();
        //itemFrame5 = GameObject.Find("ItemFrame5").GetComponent<Image>();
        //itemFrame6 = GameObject.Find("ItemFrame6").GetComponent<Image>();
        //itemFrame7 = GameObject.Find("ItemFrame7").GetComponent<Image>();
        //itemFrame8 = GameObject.Find("ItemFrame8").GetComponent<Image>();
        //itemFrame9 = GameObject.Find("ItemFrame9").GetComponent<Image>();
        itemPhoto1.enabled = false;
        itemPhoto2.enabled = false;
        menuPhoto.enabled = false;
        //itemFrame1.enabled = false;
        //itemFrame2.enabled = false;
        //itemFrame3.enabled = false;
        //itemFrame4.enabled = false;
        //itemFrame5.enabled = false;
        //itemFrame6.enabled = false;
        //itemFrame7.enabled = false;
        //itemFrame8.enabled = false;
        //itemFrame9.enabled = false;

        gameStop = GameObject.Find("GameManager").GetComponent<publicFlag>();

        password = GameObject.Find("player").GetComponent<Password>();
    }

    // Update is called once per frame
    void Update()
    {
        if (openMenu == true)
        {
            menuPhoto.enabled = true;
            menuPhoto.sprite = imageMenu;
        }
        else
        {
            menuPhoto.enabled = false;
        }
        if (inputAction.Player.ChangeMenuScreen.triggered)
        {
            if (openMenu == true)
            {
                gameStop.stopFlag = false;
                openMenu = false;
            }
            else
            {
                gameStop.stopFlag = true;
                openMenu = true;
            }
        }
        //アイテムを使うとき
        if (haveOpeKey == true)
        {
            if (openMenu == true)
            {
                if (itemPhoto1.enabled == false)
                {
                    itemPhoto1.enabled = true;
                    itemPhoto1.sprite = imageKey;
                }
                else if (itemPhoto1.enabled == false)
                {
                    itemPhoto2.enabled = true;
                    itemPhoto1.sprite = imageKey;
                }
            }
            else
            {
                itemPhoto1.enabled = false;
                itemPhoto2.enabled = false;
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
        if (sowingGet == true)
        {
            if (openMenu == true)
            {
                if (itemPhoto1.enabled == false)
                {
                    itemPhoto1.enabled = true;
                    itemPhoto1.sprite = imageItem;
                }
                else if (itemPhoto1.enabled == false)
                {
                    itemPhoto2.enabled = true;
                    itemPhoto2.sprite = imageItem;
                }
            }
            else
            {
                itemPhoto1.enabled = false;
                itemPhoto2.enabled = false;
            }
            if (inputAction.Player.UseItem.triggered)//if文増やして座標を指定する処理を追加したい
            {
                Debug.Log("裁縫道具を使用した");
                //アイテムを使った時の処理を書いてほしい
                sowingGet = false;
                itemPhoto1.enabled = false;
                itemPhoto2.enabled = false;
            }
        }

        if(password.isGetOpeKey == true)
        {
            haveOpeKey = true;
            password.isGetOpeKey = false;
        }
    }

    //当たっていてEキーをおしたら消える
    //void OnTriggerStay(Collider other)
    //{
    //    //if (inputAction_.Player.GetItem.triggered)
    //    //{
    //    if (other.gameObject.layer <= 6)
    //    {
    //        other.gameObject.SetActive(false);
    //        if (other.gameObject.layer == 6)
    //        {
    //            haveOpeKey = true;
    //            Debug.Log("1-A KEYを入手した");
    //            //slot0.GetComponent<Image>().sprite = Resources.Load<Sprite>("key");
    //        }
    //        //if (this.gameObject.tag == "FirstKey")
    //        //{
    //        //    Debug.Log("First Keyを使った");
    //        //    //slot0.GetComponent<Image>().sprite = Resources.Load<Sprite>("key");

    //        //}
    //    }
    //    //}
    //}
}