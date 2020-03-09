using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    public Toggle shakyCamToggle;
    public GameObject playerPrefab;
    public GameObject obstaclePrefab;

    private void Start() {
        shakyCamToggle.isOn = playerPrefab.GetComponent<PlayerScript>().screenIsShake;
    }

    // Shaky Cam Toggle
    public void OnShakyCamToggleChanged(bool isToggle) {
        playerPrefab.GetComponent<PlayerScript>().ScreenShakeOption(isToggle);
        obstaclePrefab.GetComponent<ObstacleScript>().ScreenShakeOption(isToggle);
    }

    public void closeSetting() {
        this.gameObject.SetActive(false);
    }

    public void openSetting() {
        this.gameObject.SetActive(true);
    }
}
