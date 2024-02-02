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
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();
        moveFlag = false;
        cameraTransform = GameObject.Find("CameraPos").GetComponent<Transform>();
        playerTransform = GameObject.Find("playerShadow").GetComponent<Transform>();
        boyTransform = GameObject.Find("boyObject").GetComponent<Transform>();
        count = 0;
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
            if(angle.y <= (int)(180) && count == 1)
            {
                angle.y = (int)(180);
                moveFlag = false;
                count = 2;
            }
            if (angle.y <= (int)(-90) && count == 0)
            {
                angle.y = (int)(-90);
                moveFlag = false;
                count = 1;
            }
            playerTransform.eulerAngles = angle;
            cameraTransform.eulerAngles = angle;
            boyTransform.eulerAngles = angle;
            bikkuriTransform.eulerAngles = angle;
            bikkuriTransform2.eulerAngles = angle;
        }
    }
}
