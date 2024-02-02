using UnityEngine;

public class RotaCameraAnimation : MonoBehaviour
{
    public bool isRotaAnimation;
    private int animationTimer; 
    Vector3 rotaPos = new Vector3(0, 45, 0); 
    // Start is called before the first frame update
    void Start()
    {
        animationTimer = 0;
        isRotaAnimation = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Œã‚ÅÁ‚·
        //isRotaAnimation = true;
        animationTimer++;
        if (isRotaAnimation == true)
        {
            if (animationTimer > 0 && 120 > animationTimer)
            {
                rotaPos.y += 0.25f;
            }
            if (animationTimer > 120 && 480 > animationTimer)
            {
                rotaPos.y -= 0.25f;
            }
            if (animationTimer > 480 && 600 > animationTimer)
            {
                rotaPos.y += -0.25f;
            }
            this.gameObject.transform.eulerAngles = rotaPos;
            if (animationTimer > 600)
            {
                isRotaAnimation = false;
                animationTimer = 0;
            }
            //‚±‚±‚Éˆ—‚ğ•`‚­
        }
    }
}
