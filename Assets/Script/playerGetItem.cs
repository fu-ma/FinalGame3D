using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class playerGetItem : MonoBehaviour
{
    public bool have1AKey = false;

    public Image slot0;
    public Image slot1;
    public Image slot2;
    public Image slot3;

    private PlayerInputSystem inputAction;
    // Start is called before the first frame update
    void Start()
    {
        slot0 = GetComponent<Image>();
        slot1 = GetComponent<Image>();
        slot2 = GetComponent<Image>();
        slot3 = GetComponent<Image>();
        inputAction = new PlayerInputSystem();
        inputAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        //�A�C�e�����g���Ƃ�
        if (have1AKey == true)
        {
            if (inputAction.Player.UseItem.triggered)//if�����₵�č��W���w�肷�鏈����ǉ�������
            {
                Debug.Log("1-A KEY���g����");
                //�A�C�e�����g�������̏����������Ăق���
                have1AKey = false;
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