using UnityEngine;

public class ResetRoom : MonoBehaviour
{
    public bool resetButtonPushed;
    public bool isReset;
    public GameObject soraRoom;
    public GameObject hakariRoom;
    private Vector3 soraRoomFirst;
    private Vector3 hakariRoomFirst;
    // Start is called before the first frame update
    void Start()
    {
        soraRoomFirst = new Vector3();
        hakariRoomFirst = new Vector3();
        hakariRoomFirst = hakariRoom.transform.position;
        soraRoomFirst = soraRoom.transform.position;

        isReset = false;
        resetButtonPushed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (resetButtonPushed == true)
        {
            isReset = true;
        }
        else
        {
            isReset = false;
        }
        if (isReset == true)
        {
            soraRoom.transform.position = soraRoomFirst;
            hakariRoom.transform.position = hakariRoomFirst;
            resetButtonPushed = false;
        }
    }
}
