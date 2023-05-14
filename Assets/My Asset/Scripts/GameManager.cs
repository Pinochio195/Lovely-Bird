using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Data;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [HeaderTextColor(0.2f, 1, 1, headerText = "Bird")]
    public Player_Component Bird;
    [Space(10)]
    [HeaderTextColor(0.2f, 1, 1, headerText = "Music")]
    public MusicGame musicGame;

    [Space(10)] [HeaderTextColor(0.2f, 1, 1, headerText = "GameOver")]
    public GameOver gameOver;
    [Space(10)] [HeaderTextColor(0.2f, 1, 1, headerText = "Point")]
    public Core hightCore;
    [Space(10)] [HeaderTextColor(0.2f, 1, 1, headerText = "Tap To Play")]
    public PlayGame playGame;
    public bool isCheck;
    public List<GameObject> list_EnableToPlay;
    private void Awake()
    {
        Instance = this;
        list_EnableToPlay.ForEach(item=>item.SetActive(false));
    }

    private void Start()
    {
        Time.timeScale = 1;
        hightCore.txt_HightPoint.text = "Hight Core : "+PlayerPrefs.GetInt(hightCore.playerPrefs_Coin, 0);
        hightCore.txt_Point.text = "0";
        hightCore.Point = 0;
        Bird.rigidbody.isKinematic = true;
        isCheck = false;
    }

    public void PlayGame()
    {
        playGame.GO_TapToPlay.SetActive(false);
        Bird.rigidbody.isKinematic = false;
        list_EnableToPlay.ForEach(item=>item.SetActive(true));
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    public void GameOver()
    {
        GameManager.Instance.musicGame.Hit.Play();
        Time.timeScale = 0;
        gameOver.GO_GameOver.SetActive(true);
        hightCore.txt_Point.text = hightCore.Point.ToString();
        PlayerPrefs.SetInt(hightCore.playerPrefs_Coin, Int32.Parse(hightCore.txt_Point.text));
    }
}
