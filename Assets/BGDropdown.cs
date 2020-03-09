using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGDropdown : MonoBehaviour
{
    public Dropdown bgDropdown;
    private List<string> bgs = new List<string>() {
            "Green",
            "Navy",
            "PinkAbyss",
            "Violet"
    };

    public List<Sprite> bgSprites = new List<Sprite>();
    public GameObject mainBG;

    void Start()
    {
        // Populate dropdown options
        PopulateBGList();
        
        // Get the current selected background
        // Debug.Log(mainBG.GetComponent<SpriteRenderer>().sprite.name);
        bgDropdown.RefreshShownValue();
        bgDropdown.value = bgs.IndexOf(mainBG.GetComponent<SpriteRenderer>().sprite.name);
    }

    // Background Dropdown 
    private void PopulateBGList() {
        bgDropdown.options.Clear();
        foreach (string option in bgs) {
            bgDropdown.options.Add(new Dropdown.OptionData(option));
        }
    }

    public void OnIndexChanged(int index) {
        mainBG.GetComponent<SpriteRenderer>().sprite = bgSprites[index];
        // Debug.Log("Choose bg#" + index.ToString());
    }
}
