using System;
using UnityEngine;
using UnityEngine.UI;

namespace Data
{
    [Serializable]
    public class Player_Component
    {
        public Rigidbody2D rigidbody;
        public Animator animator;
    }
    [Serializable]
    public class MusicGame
    {
        public AudioSource Hit;
        public AudioSource Touch;
        public AudioSource Point;
    }
    [Serializable]
    public class GameOver
    {
        public GameObject GO_GameOver;
    }
    [Serializable]
    public class Core
    {
        public Text txt_Point;
        public Text txt_HightPoint;
        public int Point;
        public string playerPrefs_Coin = "Hight_Core";
    }
    [Serializable]
    public class PlayGame
    {
        public GameObject GO_TapToPlay;
        
    }
}