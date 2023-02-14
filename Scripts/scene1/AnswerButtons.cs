using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    public GameObject answerAbackGreen;  // waiting
    public GameObject answerAbackBlue;  // correct
    public GameObject answerAbackRed;  // Wrong 

    public GameObject answerBbackGreen;  // waiting for the next
    public GameObject answerBbackBlue;  // correct
    public GameObject answerBbackRed;  // Wrong 

    public GameObject answerCbackGreen;  // waiting for the next
    public GameObject answerCbackBlue;  // correct
    public GameObject answerCbackRed;  // Wrong 

    public GameObject answerDbackGreen;  // waiting for the next
    public GameObject answerDbackBlue;  // correct
    public GameObject answerDbackRed;  // Wrong 

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    public AudioSource correctSx;
    public AudioSource wrongSx;

    public GameObject currentScore;
    public int scoreValue;
    public int bestScore;
    public GameObject bestDisplay;

    void Start() // loading the score
    {
        bestScore = PlayerPrefs.GetInt("BestScoreGame");
        bestDisplay.GetComponent<Text>().text = "BEST: " + bestScore;
    }
    
    void Update()
    {
        currentScore.GetComponent<Text>().text = "SCORE: " + scoreValue;
    }

    public void AnswerA()
    {
        if (QuestionGenerator.actualAnswer == "A")
        {
            answerAbackBlue.SetActive(true);
            answerAbackGreen.SetActive(false);
            correctSx.Play();
            scoreValue += 10;
            
        }
        else
        {
            answerAbackRed.SetActive(true);
            answerAbackGreen.SetActive(false);
            wrongSx.Play();
            scoreValue -= 10;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        
        StartCoroutine(NextQuestion());
        
    }
    public void AnswerB()
    {
        if (QuestionGenerator.actualAnswer == "B")
        {
            answerBbackBlue.SetActive(true);
            answerBbackGreen.SetActive(false);
            correctSx.Play();
            scoreValue += 10;
        }
        else
        {
            answerBbackRed.SetActive(true);
            answerBbackGreen.SetActive(false);
            wrongSx.Play();
            scoreValue -= 10;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;

        StartCoroutine(NextQuestion());
    }

    public void AnswerC()
    {
        if (QuestionGenerator.actualAnswer == "C")
        {
            answerCbackBlue.SetActive(true);
            answerCbackGreen.SetActive(false);
            correctSx.Play();
            scoreValue += 10;
        }
        else
        {
            answerCbackRed.SetActive(true);
            answerCbackGreen.SetActive(false);
            wrongSx.Play();
            scoreValue -= 10;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;

        StartCoroutine(NextQuestion());
    }

    public void AnswerD()
    {
        if (QuestionGenerator.actualAnswer == "D")
        {
            answerDbackBlue.SetActive(true);
            answerDbackGreen.SetActive(false);
            correctSx.Play();
            scoreValue += 10;
        }
        else
        {
            answerDbackRed.SetActive(true);
            answerDbackGreen.SetActive(false);
            wrongSx.Play();
            scoreValue -= 10;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false; 

        StartCoroutine(NextQuestion());
    }

    IEnumerator NextQuestion()
    {
        if(bestScore < scoreValue)
        {
            PlayerPrefs.SetInt("BestScoreGame", scoreValue); 
            bestDisplay.GetComponent<Text>().text = "BEST - " + scoreValue;
        }
        yield return new WaitForSeconds(4);


        answerAbackBlue.SetActive(false);
        answerBbackBlue.SetActive(false);
        answerCbackBlue.SetActive(false);
        answerDbackBlue.SetActive(false);

        answerAbackRed.SetActive(false);
        answerBbackRed.SetActive(false);
        answerCbackRed.SetActive(false);
        answerDbackRed.SetActive(false);

        answerAbackGreen.SetActive(true);
        answerBbackGreen.SetActive(true);
        answerCbackGreen.SetActive(true);
        answerDbackGreen.SetActive(true);

        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;
        QuestionGenerator.displayingQuestion = false;
    }
}
