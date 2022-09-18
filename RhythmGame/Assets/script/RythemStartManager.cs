using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RythmStartManager : MonoBehaviour
{
    public bool isGameStart = false;
    public AudioSource myAudioSource;

    public Image Hp;
    public GameObject gameOverText;

    public void BtnStartOn()
    {
        myAudioSource.Play();
        isGameStart = true;
    }
    public void HitPlayer()
    {
        Hp.fillAmount -= 0.1f;

        if(Hp.fillAmount <= 0)
        {
            gameOverText.SetActive(true);
            myAudioSource.Stop();
        }
    }
}
