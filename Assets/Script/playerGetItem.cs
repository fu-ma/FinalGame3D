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
        //アイテムを使うとき
        if (have1AKey == true)
        {
            if (inputAction.Player.UseItem.triggered)//if文増やして座標を指定する処理を追加したい
            {
                Debug.Log("1-A KEYを使った");
                //アイテムを使った時の処理を書いてほしい
                have1AKey = false;
            }
        }
    }

    //当たっていてEキーをおしたら消える
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
                Debug.Log("1-A KEYを入手した");
                //slot0.GetComponent<Image>().sprite = Resources.Load<Sprite>("key");
            }
            //if (this.gameObject.tag == "FirstKey")
            //{
            //    Debug.Log("First Keyを使った");
            //    //slot0.GetComponent<Image>().sprite = Resources.Load<Sprite>("key");

            //}
        }
        //}
    }
}