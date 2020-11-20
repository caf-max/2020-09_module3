using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public CanvasGroup buttons;
    public CanvasGroup endGame;

    private void Start()
    {
        Utility.SetCanvasGroupEnabled(buttons, true);
        Utility.SetCanvasGroupEnabled(endGame, false);
    }

    public void EndGame()
    {
        Utility.SetCanvasGroupEnabled(buttons, false);
        Utility.SetCanvasGroupEnabled(endGame, true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
