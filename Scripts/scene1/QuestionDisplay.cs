using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisplay : MonoBehaviour
{
    public GameObject ScreenQuestion;
    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;
    public static string newQuestion;
    public static string newA;
    public static string newB;
    public static string newC;
    public static string newD;
    public static bool needToUpdate = false;

    void Update()
    {
        if (needToUpdate == false)
        {
            needToUpdate = true;
            StartCoroutine(PushText());
        }
        
    }

    IEnumerator PushText()
    {
        yield return new WaitForSeconds(0.25f);
        ScreenQuestion.GetComponent<Text>().text = newQuestion;
        answerA.GetComponent<Text>().text = newA;
        answerB.GetComponent<Text>().text = newB;
        answerC.GetComponent<Text>().text = newC;
        answerD.GetComponent<Text>().text = newD;
    }
}
