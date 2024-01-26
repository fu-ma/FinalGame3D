using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ChangeCameraEffect : MonoBehaviour
{
    public GameObject PlayerCameraEffect1;
    public GameObject PlayerCameraEffect2;
    public GameObject BoyCameraEffect1;
    public GameObject BoyCameraEffect2;

    public bool isPlayerCameraEffect;
    public bool isBoyCameraEffect;
    // Start is called before the first frame update
    void Start()
    {
        isPlayerCameraEffect = false;
        isBoyCameraEffect = false;
    }

    // Update is called once per frame
    void Update()
    {
        //�v���C���[�J����
        if (isPlayerCameraEffect == true)
        {
            PlayerCameraEffect1.SetActive(true);
            PlayerCameraEffect2.SetActive(true);
        }
        else
        {
            PlayerCameraEffect1.SetActive(false);
            PlayerCameraEffect2.SetActive(false);
        }
        //�{�[�C�J����
        if (isBoyCameraEffect == true)
        {
            BoyCameraEffect1.SetActive(true);
            BoyCameraEffect2.SetActive(true);
        }
        else
        {
            BoyCameraEffect1.SetActive(false);
            BoyCameraEffect2.SetActive(false);
        }
    }
}
