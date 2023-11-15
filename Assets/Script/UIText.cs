using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class UIText : MonoBehaviour
{
    public Text nameText;
    public Text talkText;

    public bool playing = false;
    public float textSpeed = 0.1f;

    private PlayerInputSystem inputAction_;

    //テキストの表示音
    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        inputAction_ = new PlayerInputSystem();
        inputAction_.Enable();
        audioSource = GetComponent<AudioSource>();
    }

    public bool IsClicked()
    {
        if (inputAction_.Player.Talk.triggered)
        {
            audioSource.PlayOneShot(sound1);
            return true;
        }
        return false;
    }

    public void DrawText(string text)
    {
        nameText.text = "";
        StartCoroutine("CoDrawText", text);
    }

    public void DrawText(string name,string text)
    {
        nameText.text = name + "\n「";
        StartCoroutine("CoDrawText", text + "」");
    }

    IEnumerator CoDrawText(string text)
    {
        playing = true;
        float time = 0;
        while(true)
        {
            yield return 0;
            time += Time.deltaTime;
            if (IsClicked()) break;

            int len = Mathf.FloorToInt(time / textSpeed);
            if (len > text.Length) break;
            talkText.text = text.Substring(0, len);
        }
        talkText.text = text;
        yield return 0;
        playing = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
