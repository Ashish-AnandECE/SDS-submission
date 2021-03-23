using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

    public int score;
    public Text scoreDisplay;
    public Text highScore;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    private void Update()
    {
        scoreDisplay.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        if (score>PlayerPrefs.GetInt("HighScore",0))
        {
        PlayerPrefs.SetInt("HighScore", score);
        highScore.text= score.ToString();
        }
        Destroy(other.gameObject);
    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        highScore.text ="0";
    }
     public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
