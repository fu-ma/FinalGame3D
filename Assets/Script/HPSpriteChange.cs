using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPSpriteChange : MonoBehaviour
{
    public Sprite HP5Sprite;
    public Sprite HP4Sprite;
    public Sprite HP3Sprite;
    public Sprite HP2Sprite;
    public Sprite HP1Sprite;

    private Image image;
    public int HP;
    // Start is called before the first frame update
    void Start()
    {
        HP = 5;
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(HP == 5)
        {
            image.sprite = HP5Sprite;
        }
        else if(HP == 4)
        {
            image.sprite = HP4Sprite;
        }
        else if(HP == 3)
        {
            image.sprite = HP3Sprite;
        }
        else if(HP == 2)
        {
            image.sprite = HP2Sprite;
        }
        else if(HP == 1)
        {
            image.sprite = HP1Sprite;
        }
        else if(HP == 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
