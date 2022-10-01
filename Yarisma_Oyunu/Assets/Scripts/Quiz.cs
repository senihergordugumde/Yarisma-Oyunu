using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Quiz : MonoBehaviour
{
   
   [SerializeField] TextMeshProUGUI questionText;
   [SerializeField] CreateQuestion question;
    void Start()
    {
        questionText.text = question.GetQuestion();
    }

}
