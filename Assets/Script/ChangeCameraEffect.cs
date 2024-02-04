using UnityEngine;

public class ChangeCameraEffect : MonoBehaviour
{
    public GameObject PlayerCameraEffect1;
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
        //プレイヤーカメラ
        if (isPlayerCameraEffect == true)
        {
            PlayerCameraEffect1.SetActive(true);
        }
        else
        {
            PlayerCameraEffect1.SetActive(false);
        }
        //ボーイカメラ
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
