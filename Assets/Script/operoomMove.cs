using UnityEngine;

public class operoomMove : MonoBehaviour
{
    private bool moveFlag2;
    private FadeIn fadeIn;
    private GameObject fadeInObj;
    private TextWriter textwriter;
    private publicFlag gameStop;
    private Animator anim;

    public bool moveFlag;
    public Transform boyTransform;
    public Transform descTransfrom;

    // Start is called before the first frame update
    void Start()
    {
        moveFlag = false;
        moveFlag2 = false;
        gameStop = GameObject.Find("GameManager").GetComponent<publicFlag>();
        fadeInObj = GameObject.Find("fadeIn");
        fadeIn = fadeInObj.GetComponent<FadeIn>();
        textwriter = GameObject.Find("Canvas").GetComponent<TextWriter>();
        anim = GameObject.Find("boy").GetComponent<Animator>();

        boyTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(moveFlag)
        {
            if (moveFlag2 == false)
            {
                gameStop.stopFlag = true;
                boyTransform.position = new Vector3(-15.3f, 2.17f, 109.5f);
                anim.enabled = true;
                anim.SetFloat("Speed", 0.4f);
                //anim.SetBool("move", true);
                anim.Play("boyLeftAnimation");

                moveFlag2 = true;
            }
            if (moveFlag2 == true)
            {
                boyTransform.position -= new Vector3(0, 0, 0.01f);
                descTransfrom.position -= new Vector3(0, 0, 0.01f);

                if(boyTransform.position.z <= 105)
                {
                    moveFlag2 = false;
                    moveFlag = false;
                    anim.enabled = false;

                    gameStop.stopFlag = false;
                    textwriter.TextNum = 88;
                }
            }
        }
    }
}
