using UnityEngine;

public class publicFlag : MonoBehaviour
{
    public bool stopFlag;
    public bool notSkipFlag;
    public bool playerDontMoveFlag;
    //ìñÇΩÇ¡ÇƒÇ¢ÇÈç≈íÜ
    public bool hitFlag;
    // Start is called before the first frame update
    void Start()
    {
        stopFlag = false;
        notSkipFlag = false;
        hitFlag = false;
        playerDontMoveFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
