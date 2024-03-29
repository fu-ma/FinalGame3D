using UnityEngine;

public class Enemymove1 : MonoBehaviour
{
    public int counter = 0;
    float move = 0.025f;
    private publicFlag gameStop;
    Transform responePos;

    // Start is called before the first frame update
    void Start()
    {
        gameStop = GameObject.Find("GameManager").GetComponent<publicFlag>();
        responePos = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStop.stopFlag == false)
        {
            Vector3 p= new Vector3(0,0,move);
            transform.Translate(p);
            counter++;
            if(counter == 1)
            {
                this.transform.position = responePos.position;
            }
            if (counter == 400)
            {
                transform.Rotate(new Vector3(0, 180, 0));
            }

            if (counter == 440)
            {
                transform.Rotate(new Vector3(0, 0, 0));
                counter = 0;
            }
        }
    }
}