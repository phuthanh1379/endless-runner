using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePattern;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    // IEnumerator Delay(float time) {
    //     yield return new WaitForSeconds(time);
    // }

    private void Update() {
        if (timeBtwSpawn <= 0) {
            int rand = Random.Range(0, obstaclePattern.Length);
            GameObject spawnedPattern = (GameObject)Instantiate(obstaclePattern[rand], transform.position, Quaternion.identity);
            // StartCoroutine(Delay(.1f));
            Destroy(spawnedPattern, 0.5f);

            timeBtwSpawn = startTimeBtwSpawn;

            if (startTimeBtwSpawn > minTime) {
                startTimeBtwSpawn -= decreaseTime;
            }
        }
        else {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
