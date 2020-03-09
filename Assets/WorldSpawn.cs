using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSpawn : MonoBehaviour
{
    public GameObject mainBG;

    void Start()
    {
        Instantiate(mainBG, this.transform.position, Quaternion.identity);
    }
}
