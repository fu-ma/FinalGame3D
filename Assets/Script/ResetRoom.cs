using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ResetRoom : MonoBehaviour
{
    public bool gameStart;
    public bool resetButtonPushed;
    public bool isReset;
    public GameObject soraRoom;
    public GameObject hakariRoom;
    private GameObject soraRoomFirst;
    private GameObject hakariRoomFirst;
    // Start is called before the first frame update
    void Start()
    {
        gameStart = true;
        isReset = false;
        resetButtonPushed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStart == true)
        {
            hakariRoomFirst = hakariRoom;
            soraRoomFirst = soraRoom;
            gameStart = false;
        }
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
            soraRoom = soraRoomFirst;
            hakariRoom = hakariRoomFirst;
            resetButtonPushed = false;
        }
    }
}
