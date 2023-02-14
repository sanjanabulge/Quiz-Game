using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour 
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;

    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 5);

            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "What is Cancer?";
                QuestionDisplay.newA = "A. Uncontrollable growth of cells in body";
                QuestionDisplay.newB = "B. Lack of oxygen";
                QuestionDisplay.newC = "C. Multiplication of DNA ";
                QuestionDisplay.newD = "D. None";
                actualAnswer = "A";
            }
            if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "Who discovered Cancer??";
                QuestionDisplay.newA = "A. Nelson Mendela";
                QuestionDisplay.newB = "B. Percivall Pott";
                QuestionDisplay.newC = "C. Hippocrates";
                QuestionDisplay.newD = "D. None";
                actualAnswer = "B";
            }
            if (questionNumber == 3)
            {
               
                QuestionDisplay.newQuestion = "Where are cancer cells located in human body??";
                QuestionDisplay.newA = "A. Chest,head";
                QuestionDisplay.newB = "B. Legs,arms";
                QuestionDisplay.newC = "C. Neck,under arms";
                QuestionDisplay.newD = "D. None";
                actualAnswer = "C";
            }
            if (questionNumber == 4)
            {
                
                QuestionDisplay.newQuestion = "Which is the fastest growing cancer in world??";
                QuestionDisplay.newA = "A. Breast Cancer";
                QuestionDisplay.newB = "B. Primary Liver Cancer";
                QuestionDisplay.newC = "C. Lukemia";
                QuestionDisplay.newD = "D. None";
                actualAnswer = "B";
            }
            if (questionNumber == 5)
            {
               
                QuestionDisplay.newQuestion = "What are the 3 cancer genes??";
                QuestionDisplay.newA = "A. Polymeric Genes";
                QuestionDisplay.newB = "B. TypeI, TypeII,and TypeIII";
                QuestionDisplay.newC = "C. None";
                QuestionDisplay.newD = "D. ATM, PALB2, and CHEK2";
                actualAnswer = "D";
            }
            
            

            QuestionDisplay.needToUpdate = false;
        }
    }
}
