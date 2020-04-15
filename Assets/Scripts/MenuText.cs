//Youtube video: Displaying UI with OnMouseOver
//Video Link: https://www.youtube.com/watch?v=5BobLzmqhNE

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuText : MonoBehaviour
{
    public string myString;
    public Text myText;
    public float fadeTime;
    public bool displayInfo;

    [SerializeField] public CanvasGroup canvas1;

    [SerializeField] public CanvasGroup canvas2;

    //Use This for initialization
    void Start()
    {
        myText = GameObject.Find("Text").GetComponent<Text>();
        myText.color = Color.clear;
        //Screen.showCursor = false;
        //Screen.lockCursor = true;
    }

    //Update is called once per frame
    void Update()
    {
        FadeText ();

        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    Screen.lockCursor = false;
        //}
    }

    void OnMouseOver()
    {
        displayInfo = true;
    }

    void OnMouseExit()
    {
        displayInfo = false;
    }

    void FadeText()
    {
        //if displayInfo is true, display info
        if (displayInfo)
        {
            myText.text = myString;
            //set the color of the text from clear to black with a fade in
            //canvasGroup.alpha = 0f; //this makes everything transparent
        }
        else
        {
            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
        }
    }
}