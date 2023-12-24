using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    
    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private AudioClip bgm;
    [SerializeField] private AudioClip death;
    [SerializeField] private AudioClip levelUp;


    
    private AudioSource _audioSource;
   
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

       _audioSource = GetComponent<AudioSource>();
       _audioSource.Play();
        Time.timeScale = 1f;

    }

 

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
        _audioSource.Stop();
        _audioSource.PlayOneShot(death);
    }

    public void ReloadGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
     
    }


}
