using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  
using UnityEngine.UI;  

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;  // Panel Game Over yang akan ditampilkan

    // Panggil fungsi ini untuk menampilkan panel Game Over
    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
    }

    // Fungsi untuk mengulang permainan
    public void RestartGame()
    {
        // Memuat ulang scene yang sedang aktif
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Fungsi untuk kembali ke main menu
    public void TombolKembali()
    {
        SceneManager.LoadScene(0);
    }
}

