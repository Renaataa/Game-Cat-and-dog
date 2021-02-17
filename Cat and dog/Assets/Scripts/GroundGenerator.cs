using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    public GameObject groundPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateNewGround", 0, 2.6f);
    }

    void GenerateNewGround()
    {
        Instantiate(groundPrefab, this.transform.position, Quaternion.identity);
    }
}
