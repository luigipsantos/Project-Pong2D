using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botões : MonoBehaviour {

    public void BotãoPvP()
    {
        SceneManager.LoadScene("GameScenePvP");
    }

    public void BotãoVsAI()
    {
        SceneManager.LoadScene("GameSceneVsAI");
    }

    public void Botão3P()
    {
        SceneManager.LoadScene("GameScene3P");
    }

    public void BotãoMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void BotãoExit()
    {
        Application.Quit();
    }
}
