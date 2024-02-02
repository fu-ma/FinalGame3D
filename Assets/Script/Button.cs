using UnityEngine;

public class Button : MonoBehaviour
{
    public bool redButtonPushed;
    public bool blueButtonPushed;
    public bool greenButtonPushed;
    public bool yellowButtonPushed;
    public bool isReset;

    private bool trueButtonPas;
    private int buttonScore;

    // Start is called before the first frame update
    void Start()
    {
        redButtonPushed = false;
        blueButtonPushed = false;
        greenButtonPushed = false;
        yellowButtonPushed = false;
        trueButtonPas = false;
        isReset = false;
        buttonScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (redButtonPushed == true && blueButtonPushed == false &&
            greenButtonPushed == false && yellowButtonPushed == false && buttonScore == 0)
        {
            buttonScore += 1;
        }
        if (redButtonPushed == true && blueButtonPushed == true &&
            greenButtonPushed == false && yellowButtonPushed == false && buttonScore == 1)
        {
            buttonScore += 1;
        }
        if (redButtonPushed == true && blueButtonPushed == true &&
            greenButtonPushed == true && yellowButtonPushed == false && buttonScore == 2)
        {
            buttonScore += 1;
        }
        if (redButtonPushed == true && blueButtonPushed == true &&
           greenButtonPushed == true && yellowButtonPushed == false && buttonScore == 3)
        {
            buttonScore += 1;
        }
        if (buttonScore == 4)
        {
            trueButtonPas = true;
        }
        if (isReset == true)
        {
            redButtonPushed = false;
            blueButtonPushed = false;
            greenButtonPushed = false;
            yellowButtonPushed = false;
            trueButtonPas = false;
            buttonScore = 0;
            isReset = false;
        }
    }
}
