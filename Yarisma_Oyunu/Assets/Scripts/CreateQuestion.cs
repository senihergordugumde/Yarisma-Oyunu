using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Yarisma_Oyunu/CreateQuestion",fileName = "NewQuestion")]

public class CreateQuestion : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField] string question = "Yeni soru";
}