using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerGetItem : MonoBehaviour
{
    private PlayerInputSystem inputAction_;
    // Start is called before the first frame update
    void Start()
    {
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerStay(Collider other)
    {
        if (inputAction_.Player.GetItem.triggered)
        {
            if (other.gameObject.tag == "Item")
            {
                other.GetComponent<Item>().ItemGet();
            }
        }
    }
}
