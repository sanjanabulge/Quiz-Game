using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator2 : MonoBehaviour
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
                QuestionDisplay2.newQuestion = "What genes are affected during cancer?";
                QuestionDisplay2.newA = "A. p22 or TP53";
                QuestionDisplay2.newB = "B. p53 or TP50";
                QuestionDisplay2.newC = "C. p53 or TP53 ";
                QuestionDisplay2.newD = "D. p13 or TP43";
                actualAnswer = "C";
            }
            if (questionNumber == 2)
            {
                QuestionDisplay2.newQuestion = "How many genes are affected by cancer????";
                QuestionDisplay2.newA = "A. Excatly 10";
                QuestionDisplay2.newB = "B. between 5 and 10 in every 100 cancers";
                QuestionDisplay2.newC = "C. between 15 and 20 in every 100 cancers ";
                QuestionDisplay2.newD = "D. None";
                actualAnswer = "B";
            }
            if (questionNumber == 3)
            {
               
                QuestionDisplay2.newQuestion = "Which of the genes when activated in a normal human body can cause cancer ???";
                QuestionDisplay2.newA = "A. DNA";
                QuestionDisplay2.newB = "B. chromosome";
                QuestionDisplay2.newC = "C. CML";
                QuestionDisplay2.newD = "D. Oncogenes";
                actualAnswer = "A";
            }
            if (questionNumber == 4)
            {
                
                QuestionDisplay2.newQuestion = "What gene is mutated in CML??";
                QuestionDisplay2.newA = "A. AML";
                QuestionDisplay2.newB = "B. Y253H/F";
                QuestionDisplay2.newC = "C. E255V/K";
                QuestionDisplay2.newD = "D. BCR-ABL1";
                actualAnswer = "D";
            }
            if (questionNumber == 5)
            {
               
                QuestionDisplay2.newQuestion = "What does BCR-ABL stand for? ??";
                QuestionDisplay2.newA = "A. Polymeric Genes";
                QuestionDisplay2.newB = "B. TypeI, TypeII,and TypeIII";
                QuestionDisplay2.newC = "C. mutation that is formed by the combination of two genes";
                QuestionDisplay2.newD = "D. Philadelphia chromosome";
                actualAnswer = "C";
            }
            
            

            QuestionDisplay2.needToUpdate = false;
        }
    }
}
