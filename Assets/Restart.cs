using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public Text finalScore;
    public GameObject scoreManager;

    private void OnEnable() {
        finalScore.text = "Final Score: " + scoreManager.GetComponent<ScoreManager>().score.ToString();
    }
    // private void Update() {
    //     if (Input.GetMouseButtonDown(0)) {
    //         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //     }
    // }

    public void BackToMenu() {
        SceneManager.LoadScene(0);
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
