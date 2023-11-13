using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    private Transform playerPos;
    // Start is called before the first frame update
    void Start()
    {
        playerPos = GameObject.Find("player").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPosition(float x,float y)
    {
        playerPos.position = new Vector3(x, 1, y);
    }
}
