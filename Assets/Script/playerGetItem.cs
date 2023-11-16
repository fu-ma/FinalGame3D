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
    [SerializeField] Image itemPhoto1;
    [SerializeField] Image itemPhoto2;
    [SerializeField] Image menuPhoto;
    public bool have1AKey = false;
    public bool openMenu = false;

    private PlayerInputSystem inputAction;
    // Start is called before the first frame update
    void Start()
    {
        inputAction = new PlayerInputSystem();
        inputAction.Enable();
        itemPhoto1 = GameObject.Find("ImageItemPanel1").GetComponent<Image>();
        itemPhoto2 = GameObject.Find("ImageItemPanel2").GetComponent<Image>();
        menuPhoto = GameObject.Find("menuPanel").GetComponent<Image>();
        itemPhoto1.enabled = false;
        itemPhoto2.enabled = false;
        menuPhoto.enabled = false;
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
                openMenu = false;
            }
            else
            {
                openMenu = true;
            }
        }
        //�A�C�e�����g���Ƃ�
        if (have1AKey == true)
        {
            if (openMenu == true)
            {
                itemPhoto1.enabled = true;
                itemPhoto1.sprite = imageKey;
            }
            else
            {
                itemPhoto1.enabled = false;
            }
            if (inputAction.Player.UseItem.triggered)//if�����₵�č��W���w�肷�鏈����ǉ�������
            {
                Debug.Log("1-A KEY���g����");
                //�A�C�e�����g�������̏����������Ăق���
                have1AKey = false;
                itemPhoto1.enabled = false;
            }
        }
    }

    //�������Ă���E�L�[���������������
    void OnTriggerStay(Collider other)
    {
        //if (inputAction_.Player.GetItem.triggered)
        //{
        if (other.gameObject.layer <= 6)
        {
            other.gameObject.SetActive(false);
            if (other.gameObject.layer == 6)
            {
                have1AKey = true;
                Debug.Log("1-A KEY����肵��");
                //slot0.GetComponent<Image>().sprite = Resources.Load<Sprite>("key");
            }
            //if (this.gameObject.tag == "FirstKey")
            //{
            //    Debug.Log("First Key���g����");
            //    //slot0.GetComponent<Image>().sprite = Resources.Load<Sprite>("key");

            //}
        }
        //}
    }
}