using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Quiz : MonoBehaviour
{
   
   [SerializeField] TextMeshProUGUI questionText;
   [SerializeField] CreateQuestion question;
   [SerializeField] GameObject[] answerButtons;
    void Start()
    {

        questionText.text = question.GetQuestion();

        
        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.GetAnswers(i);
        }
        
    }

}
