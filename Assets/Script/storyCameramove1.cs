using UnityEngine;

public class storyCameramove1 : MonoBehaviour
{
    public Transform cameraPos;
    public Transform shadowPos;
    public bool effectFlag;
    public bool effectFlag2;
    Vector3 position2;
    Vector3 shadowPos2;
    Vector3 shadowRot2;
    int timer;
    public bool endFlag;

    // Start is called before the first frame update
    void Start()
    {
        position2 = new Vector3(0, 0, 0);
        cameraPos = GetComponent<Transform>();
        cameraPos.localPosition = new Vector3(0, 0, 0);
        shadowPos = GameObject.Find("shadow1").GetComponent<Transform>();
        shadowPos2 = new Vector3(0,2,-12);
        shadowRot2 = new Vector3(0, 0, 0);
        effectFlag = false;
        effectFlag2 = false;

        endFlag = false;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(effectFlag == true && cameraPos.position.z < -9)
        {

            position2.z += 0.055f;
            cameraPos.localPosition = position2;
        }

        if(cameraPos.position.z >= -9)
        {
            timer++;
            if (timer < 30)
            {
                shadowPos2.z += 0.17f;
                shadowPos2.y -= 0.15f;
            }
            if (timer > 30)
            {
                shadowPos2.y -= 0.25f;
                shadowRot2.x += 1.55f;
                shadowPos.localPosition = shadowPos2;
                shadowPos.localEulerAngles = shadowRot2;
            }
            if(timer > 60)
            {
                timer = 61;
                effectFlag = false;
                endFlag = true;
            }
        }
        if(effectFlag2 == true)
        {
            cameraPos.localPosition = new Vector3(0, 0, 0);
            effectFlag2 = false;
        }
    }
}
