using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisplay1 : MonoBehaviour
{
    public GameObject ScreenQuestion;
    public GameObject AnswerA;
    public GameObject AnswerB;
    public GameObject AnswerC;
    public GameObject AnswerD;
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
            StartCoroutine(PushQuestion());
        }
        
    }

    IEnumerator PushQuestion()
    {
        yield return new WaitForSeconds(0.25f);
        ScreenQuestion.GetComponent<Text>().text = newQuestion;
        AnswerA.GetComponent<Text>().text = newA;
        AnswerB.GetComponent<Text>().text = newB;
        AnswerC.GetComponent<Text>().text = newC;
        AnswerD.GetComponent<Text>().text = newD;
    }
}
