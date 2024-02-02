using UnityEngine;

public class boyTeleport : MonoBehaviour
{
    private Transform boyPos;
    // Start is called before the first frame update
    void Start()
    {
        boyPos = GameObject.Find("boyObject").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetPosition(float x, float y)
    {
        boyPos.position = new Vector3(x, 2.17f, y);
    }
}
