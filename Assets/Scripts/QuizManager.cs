using UnityEngine;

enum GameState
{
    countdown,
    question,
    anser,
    judgment,
    openscore
}

public class QuizManager : MasterQuize
{
    [SerializeField] private QuizeData data;

    GameState gameState;

    int missCount = 0;
    void Start()
    {
        gameState = GameState.countdown;
    }


    void Update()
    {

        switch (gameState)
        {
            case GameState.countdown:
                CountDown();
                break;
            case GameState.question:
                Question();
                break;
            case GameState.anser:
                Anser();
                break;
            case GameState.judgment:
                Judgment();
                break;
            case GameState.openscore:
                OpenScore();
                break;
        }

    }

    /// <summary>
    /// ゲーム開始時のカウントダウン
    /// </summary>
    void CountDown()
    {
        gameState = GameState.question;
    }
    /// <summary>
    /// 問題文を表示
    /// </summary>

    void Question()
    {
        gameState = GameState.anser;
    }

    /// <summary>
    /// 実際にプレイヤーが動いて回答
    /// </summary>
    void Anser()
    {
        gameState = GameState.judgment;
    }
    /// <summary>
    /// 制誤判定、ゲームオーバー判定
    /// </summary>
    void Judgment()
    {
        if (missCount > 0)
        {
            gameState = GameState.openscore;
        }
        else
        {
            gameState = GameState.question;
        }
    }
    /// <summary>
    /// スコア表示
    /// </summary>
    void OpenScore()
    {

    }
}

