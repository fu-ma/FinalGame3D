using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject subCamera;
    private PlayerInputSystem inputAction_;
    private playerMove playermove;
    private boySpriteMove1 boySprite1;

    // Start is called before the first frame update
    void Start()
    {
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();

        mainCamera = GameObject.Find("Main Camera");
        subCamera = GameObject.Find("Sub Camera");

        playermove = GameObject.Find("player").GetComponent<playerMove>();
        boySprite1 = GameObject.Find("boy").GetComponent<boySpriteMove1>();

        subCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(inputAction_.Player.Talk.triggered)
        {
            playermove.changeCharaFlag = !playermove.changeCharaFlag;
            boySprite1.moveFlag = !boySprite1.moveFlag;
            mainCamera.SetActive(!mainCamera.activeSelf);
            subCamera.SetActive(!subCamera.activeSelf);
        }
        Debug.Log(playermove.changeCharaFlag);
    }
}
