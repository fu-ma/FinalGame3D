using UnityEngine;

public class EnemyTargetMove : MonoBehaviour
{
    public float time;
    public float EnemySpeed;
    public bool moveFlag;
    public bool FirstFlag;
    public bool StoryFlag;
    private publicFlag gameStop;

    Transform Target;
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.Find("player").GetComponent<Transform>();
        moveFlag = false;
        FirstFlag = false;
        StoryFlag = false;
        EnemySpeed = 0.05f;
        gameStop = GameObject.Find("GameManager").GetComponent<publicFlag>();
    }

    // Update is called once per frame
    void Update()
    {
        if(moveFlag == false && FirstFlag == false)
        {
            this.transform.position = new Vector3(18.31f, 1.47f, 157.42f);
        }
        if(moveFlag == false && FirstFlag == true)
        {
            this.transform.position = new Vector3(29, 1.47f, 157.42f);
        }
        if(moveFlag == true && FirstFlag == false && StoryFlag == false)
        {
            this.transform.position += new Vector3(0.07f, 0, 0);
            if(this.transform.position.x >= 29)
            {
                StoryFlag = true;
            }
        }
        if (moveFlag == true && FirstFlag == true)
        {
            if (gameStop.stopFlag == false)
            {
                var speed = Vector3.zero;
                speed.z = EnemySpeed;

                transform.LookAt(Target);

                this.transform.Translate(speed);
            }
        }
    }
}
