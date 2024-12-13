using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;  // Referensi panel Game Over

    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);  // Menampilkan panel Game Over
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
