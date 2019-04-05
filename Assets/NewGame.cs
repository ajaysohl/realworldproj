using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour {

    public Button newGamebutton;

    public string votingGame;

    public void newGame(string votingGame)
    {
        SceneManager.LoadScene(votingGame);
    }
}