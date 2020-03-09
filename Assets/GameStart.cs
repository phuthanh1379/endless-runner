using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    public Text guideText;
    public int spd = 1;

    private void Update() {
        // if (Input.GetMouseButtonDown(0)) {
        //     SceneManager.LoadScene(1);
        // }

        guideText.color = new Color(guideText.color.r, guideText.color.g, guideText.color.b, 
            // Mathf.Sin(Time.time * spd));
            Mathf.PingPong(Time.time * spd, 1.0f));
            // Mathf.Round(Mathf.PingPong(Time.time * spd, 1.0f)));
    }

    public void StartGame() {
        SceneManager.LoadScene(1);
    }
}
