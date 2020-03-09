using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject playerPrefab;
    public Animator shakyCamAnim;
    public Text healthDisplay;
    public GameObject gameOver;

    void Start()
    {
        SpawnPlayer();
    }

    public void SpawnPlayer() {
        GameObject spawnedPlayer = Instantiate(playerPrefab, this.transform.position, Quaternion.identity);
        spawnedPlayer.GetComponent<PlayerScript>().shakyCamAnim = shakyCamAnim;
        spawnedPlayer.GetComponent<PlayerScript>().healthDisplay = healthDisplay;
        spawnedPlayer.GetComponent<PlayerScript>().gameOver = gameOver;
    }
}
