using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public bool have1AKey;
    public playerGetItem pgi;
    // Start is called before the first frame update
    void Start()
    {
        have1AKey = false;
        pgi = GetComponent<playerGetItem>();
    }

    // Update is called once per frame

    void Update()
    {

    }
}
