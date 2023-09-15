using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }



    #region variable



    #region bools

        public bool isKnifeCollected = false;
        public bool isKnifeUsed = false;

        public bool isFrameOpen = false;

    #endregion

    #region GameObject

        public GameObject frame; 
        public GameObject EndGameScreen;

    #endregion

    #endregion


    private void Update()
    {
    }

}
