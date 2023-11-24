using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Password : MonoBehaviour
{
    private AudioSource audiosource;
    private PlayerDamage playerDamage;
    private publicFlag gameStop;

    public AudioClip daiyaruSE;
    public AudioClip missSE;

    [SerializeField] Sprite passwordPanel;
    [SerializeField] Sprite numberPhoto0;
    [SerializeField] Sprite numberPhoto1;
    [SerializeField] Sprite numberPhoto2;
    [SerializeField] Sprite numberPhoto3;
    [SerializeField] Sprite numberPhoto4;
    [SerializeField] Sprite numberPhoto5;
    [SerializeField] Sprite numberPhoto6;
    [SerializeField] Sprite numberPhoto7;
    [SerializeField] Sprite numberPhoto8;
    [SerializeField] Sprite numberPhoto9;
    [SerializeField] Sprite spriteCirsol;
    [SerializeField] Image imagePasswordPanel;
    [SerializeField] Image imageNumber100;
    [SerializeField] Image imageNumber10;
    [SerializeField] Image imageNumber1;
    [SerializeField] Image imageCirsol100;
    [SerializeField] Image imageCirsol10;
    [SerializeField] Image imageCirsol1;
    public bool isCommand = false;
    public bool answerPass = false;
    public bool isGetOpeKey = false;
    public bool isGetKeyStory = false;
    public bool dontObject = false;
    public bool isMiss = false;
    public int numberPass100 = 0;
    public int numberPass10 = 0;
    public int numberPass1 = 0;
    public int changePass = 0;
    private PlayerInputSystem inputAction;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        playerDamage = GameObject.Find("player").GetComponent<PlayerDamage>();
        gameStop = GameObject.Find("GameManager").GetComponent<publicFlag>();

        inputAction = new PlayerInputSystem();
        inputAction.Enable();
        imagePasswordPanel = GameObject.Find("blackBord").GetComponent<Image>();
        imageNumber100 = GameObject.Find("number100").GetComponent<Image>();
        imageNumber10 = GameObject.Find("number10").GetComponent<Image>();
        imageNumber1 = GameObject.Find("number1").GetComponent<Image>();
        imageCirsol100 = GameObject.Find("NowPanel100").GetComponent<Image>();
        imageCirsol10 = GameObject.Find("NowPanel10").GetComponent<Image>();
        imageCirsol1 = GameObject.Find("NowPanel1").GetComponent<Image>();
        imagePasswordPanel.enabled = false;
        imageNumber100.enabled = false;
        imageNumber10.enabled = false;
        imageNumber1.enabled = false;
        imageCirsol100.enabled = false;
        imageCirsol10.enabled = false;
        imageCirsol1.enabled = false;
        isCommand = false;
        dontObject = false;
        isGetKeyStory = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCommand == true)
        {
            imagePasswordPanel.enabled = true;
            imagePasswordPanel.sprite = passwordPanel;
            if (inputAction.Player.MoveLeft.triggered && changePass > 0)
            {
                changePass--;
                audiosource.PlayOneShot(daiyaruSE);
            }
            else if (inputAction.Player.MoveRight.triggered && changePass < 2)
            {
                changePass++;
                audiosource.PlayOneShot(daiyaruSE);
            }
            if (changePass == 0)
            {
                imageCirsol100.enabled = true;
                imageCirsol10.enabled = false;
                imageCirsol1.enabled = false;
                imageCirsol100.sprite = spriteCirsol;
                if (inputAction.Player.MoveUp.triggered && numberPass100 < 9)
                {
                    numberPass100++;
                    audiosource.PlayOneShot(daiyaruSE);
                }
                else if (inputAction.Player.MoveUp.triggered && numberPass100 == 9)
                {
                    numberPass100 = 0;
                    audiosource.PlayOneShot(daiyaruSE);
                }
                if (inputAction.Player.MoveDown.triggered && numberPass100 > 0)
                {
                    numberPass100--;
                    audiosource.PlayOneShot(daiyaruSE);
                }
                else if (inputAction.Player.MoveDown.triggered && numberPass100 == 0)
                {
                    numberPass100 = 9;
                    audiosource.PlayOneShot(daiyaruSE);
                }
            }
            if (changePass == 1)
            {
                imageCirsol100.enabled = false;
                imageCirsol10.enabled = true;
                imageCirsol1.enabled = false;
                imageCirsol10.sprite = spriteCirsol;
                if (inputAction.Player.MoveUp.triggered && numberPass10 < 9)
                {
                    numberPass10++;
                    audiosource.PlayOneShot(daiyaruSE);
                }
                else if (inputAction.Player.MoveUp.triggered && numberPass10 == 9)
                {
                    numberPass10 = 0;
                    audiosource.PlayOneShot(daiyaruSE);
                }
                if (inputAction.Player.MoveDown.triggered && numberPass10 > 0)
                {
                    numberPass10--;
                    audiosource.PlayOneShot(daiyaruSE);
                }
                else if (inputAction.Player.MoveDown.triggered && numberPass10 == 0)
                {
                    numberPass10 = 9;
                    audiosource.PlayOneShot(daiyaruSE);
                }
            }
            if (changePass == 2)
            {
                imageCirsol100.enabled = false;
                imageCirsol10.enabled = false;
                imageCirsol1.enabled = true;
                imageCirsol1.sprite = spriteCirsol;
                if (inputAction.Player.MoveUp.triggered && numberPass1 < 9)
                {
                    numberPass1++;
                    audiosource.PlayOneShot(daiyaruSE);
                }
                else if (inputAction.Player.MoveUp.triggered && numberPass1 == 9)
                {
                    numberPass1 = 0;
                    audiosource.PlayOneShot(daiyaruSE);
                }
                if (inputAction.Player.MoveDown.triggered && numberPass1 > 0)
                {
                    numberPass1--;
                    audiosource.PlayOneShot(daiyaruSE);
                }
                else if (inputAction.Player.MoveDown.triggered && numberPass1 == 0)
                {
                    numberPass1 = 9;
                    audiosource.PlayOneShot(daiyaruSE);
                }
            }
            if (numberPass100 == 0)
            {
                imageNumber100.enabled = true;
                imageNumber100.sprite = numberPhoto0;
            }
            else if (numberPass100 == 1)
            {
                imageNumber100.enabled = true;
                imageNumber100.sprite = numberPhoto1;
            }
            else if (numberPass100 == 2)
            {
                imageNumber100.enabled = true;
                imageNumber100.sprite = numberPhoto2;
            }
            else if (numberPass100 == 3)
            {
                imageNumber100.enabled = true;
                imageNumber100.sprite = numberPhoto3;
            }
            else if (numberPass100 == 4)
            {
                imageNumber100.enabled = true;
                imageNumber100.sprite = numberPhoto4;
            }
            else if (numberPass100 == 5)
            {
                imageNumber100.enabled = true;
                imageNumber100.sprite = numberPhoto5;
            }
            else if (numberPass100 == 6)
            {
                imageNumber100.enabled = true;
                imageNumber100.sprite = numberPhoto6;
            }
            else if (numberPass100 == 7)
            {
                imageNumber100.enabled = true;
                imageNumber100.sprite = numberPhoto7;
            }
            else if (numberPass100 == 8)
            {
                imageNumber100.enabled = true;
                imageNumber100.sprite = numberPhoto8;
            }
            else if (numberPass100 == 9)
            {
                imageNumber100.enabled = true;
                imageNumber100.sprite = numberPhoto9;
            }
            if (numberPass10 == 0)
            {
                imageNumber10.enabled = true;
                imageNumber10.sprite = numberPhoto0;
            }
            else if (numberPass10 == 1)
            {
                imageNumber10.enabled = true;
                imageNumber10.sprite = numberPhoto1;
            }
            else if (numberPass10 == 2)
            {
                imageNumber10.enabled = true;
                imageNumber10.sprite = numberPhoto2;
            }
            else if (numberPass10 == 3)
            {
                imageNumber10.enabled = true;
                imageNumber10.sprite = numberPhoto3;
            }
            else if (numberPass10 == 4)
            {
                imageNumber10.enabled = true;
                imageNumber10.sprite = numberPhoto4;
            }
            else if (numberPass10 == 5)
            {
                imageNumber10.enabled = true;
                imageNumber10.sprite = numberPhoto5;
            }
            else if (numberPass10 == 6)
            {
                imageNumber10.enabled = true;
                imageNumber10.sprite = numberPhoto6;
            }
            else if (numberPass10 == 7)
            {
                imageNumber10.enabled = true;
                imageNumber10.sprite = numberPhoto7;
            }
            else if (numberPass10 == 8)
            {
                imageNumber10.enabled = true;
                imageNumber10.sprite = numberPhoto8;
            }
            else if (numberPass10 == 9)
            {
                imageNumber10.enabled = true;
                imageNumber10.sprite = numberPhoto9;
            }
            if (numberPass1 == 0)
            {
                imageNumber1.enabled = true;
                imageNumber1.sprite = numberPhoto0;
            }
            else if (numberPass1 == 1)
            {
                imageNumber1.enabled = true;
                imageNumber1.sprite = numberPhoto1;
            }
            else if (numberPass1 == 2)
            {
                imageNumber1.enabled = true;
                imageNumber1.sprite = numberPhoto2;
            }
            else if (numberPass1 == 3)
            {
                imageNumber1.enabled = true;
                imageNumber1.sprite = numberPhoto3;
            }
            else if (numberPass1 == 4)
            {
                imageNumber1.enabled = true;
                imageNumber1.sprite = numberPhoto4;
            }
            else if (numberPass1 == 5)
            {
                imageNumber1.enabled = true;
                imageNumber1.sprite = numberPhoto5;
            }
            else if (numberPass1 == 6)
            {
                imageNumber1.enabled = true;
                imageNumber1.sprite = numberPhoto6;
            }
            else if (numberPass1 == 7)
            {
                imageNumber1.enabled = true;
                imageNumber1.sprite = numberPhoto7;
            }
            else if (numberPass1 == 8)
            {
                imageNumber1.enabled = true;
                imageNumber1.sprite = numberPhoto8;
            }
            else if (numberPass1 == 9)
            {
                imageNumber1.enabled = true;
                imageNumber1.sprite = numberPhoto9;
            }
            if (inputAction.Player.PassChange.triggered)
            {
                if (numberPass100 == 2 && numberPass10 == 4 && numberPass1 == 2)
                {
                    isGetOpeKey = true;
                    isGetKeyStory = true;
                    gameStop.stopFlag = false;
                    isCommand = false;
                    dontObject = true;
                }
                else 
                {
                    isMiss = true;
                }
            }
            if (isMiss == true)
            {
                playerDamage.isDamage = true;
                audiosource.PlayOneShot(missSE);
                //isMiss = false;
                isCommand = false;
            }
        }
        else
        {
            imagePasswordPanel.enabled = false;
            imageNumber100.enabled = false;
            imageNumber10.enabled = false;
            imageNumber1.enabled = false;
            imageCirsol100.enabled = false;
            imageCirsol10.enabled = false;
            imageCirsol1.enabled = false;
        }

    }
}
