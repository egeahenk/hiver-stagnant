using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance { get; private set; }

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

    public GameObject settings;
    public GameObject settingsPanel; 
    public GameObject escSettings;
    public GameObject escMenu;
    
    #region settings
    public void openSettings()
    {
        settingsPanel.SetActive(true);
    }

    public void exitSettings()
    {
        settingsPanel.SetActive(false);
    }
    #endregion

    #region escSettings
    public void openEscSettings()
    {
        escSettings.SetActive(true);
    }

    public void exitEscSettings()
    {
        escSettings.SetActive(false);
    }
    #endregion

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    #region escapeMenu
    public void openEscapeMenu()
    {
        escMenu.SetActive(true);
    }
    public void closeEscapeMenu()
    {
        escMenu.SetActive(false);
    }
    #endregion

    public void ExitGame()
    {
        Application.Quit();
    }


}
