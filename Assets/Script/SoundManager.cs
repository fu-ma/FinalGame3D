using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource audioSource;
    public bool isDoorOpen;
    public bool isDoorClose;
    public bool isDoorNotOpen;
    public bool isBlackOut;
    public bool isNotBlackOut;
    public bool isGetItem;
    public bool isOpenKey;
    public bool isDropKey;
    public bool isCheckUp;
    public bool isDamage;
    public AudioClip doorOpenSE;
    public AudioClip doorCloseSE;
    public AudioClip doorNotOpenSE;
    public AudioClip blackOutSE;
    public AudioClip notBlackOutSE;
    public AudioClip GetItemSE;
    public AudioClip OpenKeySE;
    public AudioClip DropKeySE;
    public AudioClip CheckUpSE;
    public AudioClip DamageSE;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        isDoorOpen = false;
        isDoorClose = false;
        isDoorNotOpen = false;
        isBlackOut = false;
        isNotBlackOut = false;
        isGetItem = false;
        isOpenKey = false;
        isDropKey = false;
        isCheckUp = false;
        isDamage = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDoorOpen == true)
        {
            audioSource.PlayOneShot(doorOpenSE);
            isDoorOpen = false;
        }
        if (isDoorClose == true)
        {
            audioSource.PlayOneShot(doorCloseSE);
            isDoorClose = false;
        }
        if (isDoorNotOpen == true)
        {
            audioSource.PlayOneShot(doorNotOpenSE);
            isDoorNotOpen = false;
        }
        if (isBlackOut == true)
        {
            audioSource.PlayOneShot(blackOutSE);
            isBlackOut = false;
        }
        if (isNotBlackOut == true)
        {
            audioSource.PlayOneShot(notBlackOutSE);
            isNotBlackOut = false;
        }
        if (isGetItem == true)
        {
            audioSource.PlayOneShot(GetItemSE);
            isGetItem = false;
        }
        if (isOpenKey == true)
        {
            audioSource.PlayOneShot(OpenKeySE);
            isOpenKey = false;
        }
        if (isDropKey == true)
        {
            audioSource.PlayOneShot(DropKeySE);
            isDropKey = false;
        }
        if (isCheckUp == true)
        {
            audioSource.PlayOneShot(CheckUpSE);
            isCheckUp = false;
        }
        if (isDamage == true)
        {
            audioSource.PlayOneShot(DamageSE);
            isDamage = false;
        }
    }
}
