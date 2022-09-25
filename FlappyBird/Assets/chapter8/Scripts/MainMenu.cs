using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_Text highscoreCount;


    private void Awake()
    {
        //Playerprefs 는 유니티 내부 저장 데이터
        //int highscore = PlayerPrefs.GetInt("Highscore");
        int highscore = 0;
        highscoreCount.text = highscore.ToString();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ChangeVolume(float value)
    {
        PlayerPrefs.SetFloat("Volume", value);
    }
}
