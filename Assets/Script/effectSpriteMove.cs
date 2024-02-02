using UnityEngine;

public class effectSpriteMove : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
            anim.enabled = true;
            anim.SetFloat("Speed", 0.8f);
            anim.Play("effectAnimation");
    }
}
