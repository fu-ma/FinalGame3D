using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hospitalPlayerSprite : MonoBehaviour
{
    public Sprite nowSprite;
    public Sprite leftSprite;
    public Sprite rightSprite;
    public Sprite backSprite;
    private SpriteRenderer image;

    public bool Flag;
    public bool backFlag;
    private int animationTime;

    private TextWriter textWriter;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<SpriteRenderer>();
        Flag = false;
        backFlag = false;
        animationTime = 0;

        textWriter = GameObject.Find("Canvas").GetComponent<TextWriter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (backFlag == true)
        {
            image.sprite = backSprite;
        }

        if (Flag == true)
        {
            animationTime++;
            if (animationTime < 30)
            {
                image.sprite = leftSprite;
            }
            else if(animationTime < 60)
            {
                image.sprite = rightSprite;
            }
            else if(animationTime <90)
            {
                image.sprite = leftSprite;
            }
            else if(animationTime <120)
            {
                image.sprite = rightSprite;
            }
            else
            {
                image.sprite = nowSprite;
                Flag = false;
                textWriter.TextNum = 11;
            }
        }
    }
}
