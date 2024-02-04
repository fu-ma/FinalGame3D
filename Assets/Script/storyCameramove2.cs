using UnityEngine;

public class storyCameramove2 : MonoBehaviour
{
    public bool effectFlag;
    public GameObject mainCamera;
    public GameObject subCamera;
    public Transform boyTransform;
    public Transform girlTransform;
    private FadeIn fadeIn;
    private GameObject fadeInObj;

    public Sprite newSprite;
    private SpriteRenderer image;

    // Start is called before the first frame update
    void Start()
    {
        effectFlag = false;
        //mainCamera = GameObject.Find("Main Camera");
        //subCamera = GameObject.Find("Sub Camera");
        fadeInObj = GameObject.Find("fadeIn");
        fadeIn = fadeInObj.GetComponent<FadeIn>();
        image = GameObject.Find("boy").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (effectFlag == true)
        {
            boyTransform.position = new Vector3(-15.3f, 2.17f, 109.5f);
            girlTransform.position = new Vector3(-14.16f, 1.03f, 108.38f);
            fadeIn.fadeOutFlag = false;
            fadeIn.fadeFlag = true;

            image.sprite = newSprite;
            mainCamera.SetActive(!mainCamera.activeSelf);
            subCamera.SetActive(!subCamera.activeSelf);
            effectFlag = false;
        }
    }
}
