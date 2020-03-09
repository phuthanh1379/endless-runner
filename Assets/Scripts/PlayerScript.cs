using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    private Vector2 targetPos;
    public float Xincrement;
    public float speed;
    public float minX;
    public float maxX;
    public int health = 2;
    public GameObject effect;
    public Animator shakyCamAnim;
    public Text healthDisplay;
    public GameObject gameOver;
    public bool screenIsShake = true;

    private void Start() {

    }

    private void Update()
    {
        healthDisplay.text = health.ToString();

        // Restart game if die 
        if (health <= 0) {
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            gameOver.SetActive(true);
            Destroy(this.gameObject);
        }

        // Move the player
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        // if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxX) {
        //     shakyCamAnim.SetTrigger("shakyCam");
        //     GameObject clonedEffect = Instantiate(effect, transform.position, Quaternion.identity);
        //     Destroy(clonedEffect, .5f);
        //     targetPos = new Vector2(transform.position.x + Xincrement, transform.position.y);
        //     // Debug.Log("Right");
        // }
        // else if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minX) {
        //     shakyCamAnim.SetTrigger("shakyCam");
        //     GameObject clonedEffect = Instantiate(effect, transform.position, Quaternion.identity);
        //     Destroy(clonedEffect, .5f);
        //     targetPos = new Vector2(transform.position.x - Xincrement, transform.position.y);
        //     // Debug.Log("Left");
        // }

        // Moving by tapping to the according side of the screen
        if (Input.GetMouseButtonDown(0)) {
            if (Input.mousePosition.x >= 0f && Input.mousePosition.x < (Screen.width / 2)) {
                if (transform.position.x > minX) {
                    if (screenIsShake) {
                        shakyCamAnim.SetTrigger("shakyCam");
                    }
                    GameObject clonedEffect = Instantiate(effect, transform.position, Quaternion.identity);
                    Destroy(clonedEffect, .5f);
                    targetPos = new Vector2(transform.position.x - Xincrement, transform.position.y);
                    // Debug.Log("Left!" + Input.mousePosition.ToString());
                }
            }
            else if (Input.mousePosition.x >= (Screen.width / 2) && Input.mousePosition.x < Screen.width){
                if (transform.position.x < maxX) {
                    if (screenIsShake) {
                        shakyCamAnim.SetTrigger("shakyCam");
                    }
                    GameObject clonedEffect = Instantiate(effect, transform.position, Quaternion.identity);
                    Destroy(clonedEffect, .5f);
                    targetPos = new Vector2(transform.position.x + Xincrement, transform.position.y);
                    // Debug.Log("Right!" + Input.mousePosition.ToString());
                }
            }
        }
    }

    public void ScreenShakeOption(bool newValue) {
        screenIsShake = newValue;
    }
}
