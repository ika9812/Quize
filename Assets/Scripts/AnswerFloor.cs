using UnityEngine;

public class AnswerFloor : MonoBehaviour
{
    [SerializeField] private QuizManager quizManager;

    [Tooltip("0 = A, 1 = B")]
    [SerializeField] private int answerIndex;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        quizManager.CheckAnswer(answerIndex);
    }
}