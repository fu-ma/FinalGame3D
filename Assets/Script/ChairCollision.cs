using UnityEngine;

public class ChairCollision : MonoBehaviour
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
        if (collision.gameObject.tag == "chairCollision")
        {
            textWriter.TextNum = 136;
            rig.isKinematic = true;
            boymove.chairFlag = true;
        }
    }

    public void Init()
    {
        rig.isKinematic = false;
        boymove.chairFlag = false;
    }

}
