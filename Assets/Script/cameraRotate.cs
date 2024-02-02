using UnityEngine;

public class cameraRotate : MonoBehaviour
{
    private PlayerInputSystem inputAction_;
    private Transform playerTransform;
    private Transform cameraTransform;
    private Transform boyTransform;
    public Transform bikkuriTransform;
    public Transform bikkuriTransform2;

    public bool moveFlag;
    public Vector3 angle;
    // Start is called before the first frame update
    void Start()
    {
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();
        moveFlag = false;
        cameraTransform = GameObject.Find("CameraPos").GetComponent<Transform>();
        playerTransform = GameObject.Find("playerShadow").GetComponent<Transform>();
        boyTransform = GameObject.Find("boyObject").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if(moveFlag== false)
        {
            angle = playerTransform.eulerAngles;
        }
        if (moveFlag == true)
        {
            angle.y --;
            if(angle.y <= -90)
            {
                moveFlag = false;
                angle.y = -90;
            }
            playerTransform.eulerAngles = angle;
            cameraTransform.eulerAngles = angle;
            boyTransform.eulerAngles = angle;
            bikkuriTransform.eulerAngles = angle;
            bikkuriTransform2.eulerAngles = angle;
        }
    }
}
