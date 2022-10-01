using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Yarisma_Oyunu/CreateQuestion",fileName = "NewQuestion")]

public class CreateQuestion : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField] string question = "Yeni soru";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;


    public string GetQuestion()
    {
        return question;
    }

    public string GetAnswers(int Index)
    {
        return answers[Index];
    }

    public int getCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }

}