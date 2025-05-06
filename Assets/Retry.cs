using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public void RetryGame()
    {
        Time.timeScale = 1f; // 止めていたゲームを再開
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // 現在のシーンを再読み込み
    }
}

