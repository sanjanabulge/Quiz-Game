using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour 
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
                QuestionDisplay1.newQuestion = "What DNA mutation causes Lukemia?";
                QuestionDisplay1.newA = "A. GATA1 gene";
                QuestionDisplay1.newB = "B. GATA2 gene";
                QuestionDisplay1.newC = "C. GATA3 gene ";
                QuestionDisplay1.newD = "D. GATA4 gene";
                actualAnswer = "B";
            }
            if (questionNumber == 2)
            {
                QuestionDisplay1.newQuestion = "What genes are involved in leukemia???";
                QuestionDisplay1.newA = "A. the PML gene on chromosome 11";
                QuestionDisplay1.newB = "B. the PML gene on chromosome 2 and the RARA gene on chromosome 17";
                QuestionDisplay1.newC = "C. the PML gene on chromosome 10 ";
                QuestionDisplay1.newD = "D. the PML gene on chromosome 15 and the RARA gene on chromosome 17";
                actualAnswer = "D";
            }
            if (questionNumber == 3)
            {
               
                QuestionDisplay1.newQuestion = "What chromosome is leukemia found on???";
                QuestionDisplay1.newA = "A. Chromosome 22";
                QuestionDisplay1.newB = "B. chromosome 33";
                QuestionDisplay1.newC = "C. chromosome 11";
                QuestionDisplay1.newD = "D. chromosome 44";
                actualAnswer = "A";
            }
            if (questionNumber == 4)
            {
                
                QuestionDisplay1.newQuestion = "What gene is mutated in CML(Chronic myeloid leukemia) ??";
                QuestionDisplay1.newA = "A. AML";
                QuestionDisplay1.newB = "B. Y253H/F";
                QuestionDisplay1.newC = "C. E255V/K";
                QuestionDisplay1.newD = "D. BCR-ABL1";
                actualAnswer = "D";
            }
            if (questionNumber == 5)
            {
               
                QuestionDisplay1.newQuestion = "What does BCR-ABL stand for? ??";
                QuestionDisplay1.newA = "A. Polymeric Genes";
                QuestionDisplay1.newB = "B. TypeI, TypeII,and TypeIII";
                QuestionDisplay1.newC = "C. mutation that is formed by the combination of two genes";
                QuestionDisplay1.newD = "D. Philadelphia chromosome";
                actualAnswer = "C";
            }
            
            

            QuestionDisplay1.needToUpdate = false;
        }
    }
}
