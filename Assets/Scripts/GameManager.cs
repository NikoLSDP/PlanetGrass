using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject mainMenu;

    public static GameManager instance = null;

    private bool playerActive = false;
    private bool gameStarted = false;
    private bool gameOver = false;

    public bool PlayerActive
    {
        get { return playerActive; }
    }
    public bool GameStarted
    {
        get { return gameStarted; }
    }
    public bool GameOver
    {
        get { return gameOver; }
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        Assert.IsNotNull(mainMenu);
    }
    public void PlayerCollided()
    {
        gameOver = true;
    }
    public void PlayerStartedGame()
    {
        playerActive = true;
    }
    public void EnterGame()
    {
        mainMenu.SetActive(false);
        gameStarted = true;
    }
}
