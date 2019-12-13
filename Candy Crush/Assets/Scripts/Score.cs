using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    public static Score instance;

    public GameObject gameOverPanel;
    public Text yourScoreTxt;
    public Text highScoreTxt;
    public Button Rest;
    public Text scoreTxt;
    public Text moveCounterTxt;

    private int score, moveCounter;

    void Awake()
    {
        instance = GetComponent<Score>();
        moveCounter = 30;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);

        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreTxt.text = "New Best: " + PlayerPrefs.GetInt("HighScore").ToString();
        }
        else
        {
            highScoreTxt.text = "Best: " + PlayerPrefs.GetInt("HighScore").ToString();
        }

        yourScoreTxt.text =  "Score: " + score.ToString();
    }
    public void Resets()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public int ScoreBoard
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
            scoreTxt.text = score.ToString();
        }
    }

    public int MoveCounter
    {
        get
        {
            return moveCounter;
        }

        set
        {
            moveCounter = value;
            if (moveCounter <= 0)
            {
                moveCounter = 0;
                StartCoroutine(WaitForShifting());
            }
            moveCounterTxt.text = moveCounter.ToString();
        }
    }

    private IEnumerator WaitForShifting()
    {
        yield return new WaitUntil(() => !BoardGen.instance.IsShifting);
        yield return new WaitForSeconds(.25f);
        GameOver();
    }
}
