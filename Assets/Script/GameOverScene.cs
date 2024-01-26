using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour
{
    private PlayerInputSystem inputAction_;
    // Start is called before the first frame update
    void Start()
    {
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (inputAction_.Player.Talk.triggered)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
