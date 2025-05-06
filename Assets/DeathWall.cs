using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTrigger : MonoBehaviour
{
    public GameObject gameOverUI;  // UIを表示するためのGameObject

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            if (gameOverUI != null)
            {
                gameOverUI.SetActive(true);  // UIを表示
            }

            other.gameObject.SetActive(false);  // ボールを消す（無効化）
        }
    }
}

