using UnityEngine;

public class StatueCollision : MonoBehaviour
{
    private TextWriter textWriter;
    public boyMove boymove;
    public Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        textWriter = GameObject.Find("Canvas").GetComponent<TextWriter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "statueCollision")
        {
            textWriter.TextNum = 134;
            rig.isKinematic = true;
            boymove.statueFlag = true;
        }
    }

    public void Init()
    {
        rig.isKinematic = false;
        boymove.statueFlag = false;
    }
}
