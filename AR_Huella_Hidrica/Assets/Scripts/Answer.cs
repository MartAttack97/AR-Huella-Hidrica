using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{
    [SerializeField] private string correctAnswer;
    [SerializeField] private Text messageForUsers;

    public void CheckAnswer(string answerFromButton)
    {
        string newMessage = "¡Acertaste!";

        if (!IsAnswerCorrect(answerFromButton))
        {
            newMessage = "¡UPS! Prueba otra vez";
        }

        SendMessageToUsers(newMessage);
    }

    private bool IsAnswerCorrect(string answerFromButton)
    {
        return answerFromButton == correctAnswer;
    }

    private void SendMessageToUsers(string message)
    {
        messageForUsers.text = message;
    }
}
