using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    public GameObject effect;
    private Animator shakyCamAnim;
    public bool screenIsShake = true;

    private void Start() {
        shakyCamAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }

    private void Update() {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // Destroy if out of screen
        if (transform.position.y <= -4.2f) {
            Destroy(this.gameObject, 0f);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            // spawn particle effect
            if (screenIsShake) {
                shakyCamAnim.SetTrigger("shakyCam");
            }
            Instantiate(effect, transform.position, Quaternion.identity);
            // GameObject clonedEffect = Instantiate(effect, transform.position, Quaternion.identity);
            // Destroy(clonedEffect, 2f);

            // player takes damage
            other.GetComponent<PlayerScript>().health -= damage;
            // Debug.Log(other.GetComponent<PlayerScript>().health);
            Destroy(this.gameObject, 0f);
        }
    }

    public void ScreenShakeOption(bool newValue) {
        screenIsShake = newValue;
    }
}
