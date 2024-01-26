using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    private HPSpriteChange hpSprite;
    private PlayerInputSystem inputAction_;
    public GameObject damageEffect;
    private Color hpAlphaColor;
    private int damageTimer;
    private bool damageFlag;

    public bool isDamage;

    // Start is called before the first frame update
    void Start()
    {
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();
        hpSprite = GameObject.Find("HP").GetComponent<HPSpriteChange>();

        hpAlphaColor = damageEffect.GetComponent<Image>().color;

        damageFlag = false;
        damageTimer = 0;
        isDamage = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDamage == true)
        {
            if (hpSprite.HP > 0)
            {
                hpSprite.HP--;
                damageTimer = 0;
            }
            if(hpSprite.HP == 0)
            {
                SceneManager.LoadScene("GameOverScene");
            }
            damageFlag = true;
        }
        if(damageFlag == true)
        {
            isDamage = false;
            if (damageTimer == 0)
            {
                damageEffect.SetActive(true);
            }
            damageTimer++;
            hpAlphaColor.a -= 0.015f;
            if(damageTimer > 60)
            {
                damageEffect.SetActive(false);
                damageTimer = 0;
                hpAlphaColor.a = 1;
                damageFlag = false;
            }
            damageEffect.GetComponent<Image>().color = hpAlphaColor;
        }
    }
}
