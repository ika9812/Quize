using UnityEngine;
using UnityEngine.UI;


public class QuizManager : MonoBehaviour
{
    [System.Serializable]
    public class QuizData
    {
        public string question;
        public string answera;
        public string answerb;
        public int correct;//0=a,1=b
    }

    [SerializeField] QuizData[] data;
    [SerializeField] Transform player;
    [SerializeField] Text questontext;
    [SerializeField] Text answertexta;
    [SerializeField] Text answertextb;
    [SerializeField] Transform answerafloor;
    [SerializeField] Transform answerbfloor;

    int index = 0;
    bool answerd;

    void Start()
    {
        ShowQuestion();
    }
    
    void ShowQuestion()
    {
        answerd = false;
        var q = data[index];
        questontext.text = q.question;
        answertexta.text = "A" + q.answera;
        answertextb.text = "B" + q.answerb;
    }

    public void CheckAnswer(int check)
    {
        if (answerd) return;
        answerd = true;
        var q= data[index];
        bool correct = (check==q.correct);
        questontext.text = correct ? "³‰ğ" : "•s³‰ğ";
        Invoke(nameof(NextQuestion), 2f);
    }

    void NextQuestion()
    {
        index ++;
        if(index>=data.Length)
        {
            questontext.text = "‘S‚Ä‚Ì–â‘è‚ªI‚í‚è‚Ü‚µ‚½!";
            answertexta.text = "";
            answertextb.text = "";
        }
        else
        {
            ShowQuestion();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(answerd || other.transform!=player) return;
        if (other.transform.IsChildOf(answerafloor)) CheckAnswer(0);
        if (other.transform.IsChildOf(answerbfloor)) CheckAnswer(1);

    }
}


