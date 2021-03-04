using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    public GameObject[] groundPrefabs;
    public float maxHeight;
    public float minHeight;
    
    public float maxStep;
    private float previousGroundY = -2.38f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateNewGround", 0, 2.6f);
    }

    void GenerateNewGround()
    {
        float newY;
        do{
            newY = Random.Range(minHeight, maxHeight);
        } while (newY > maxStep + previousGroundY);

        Vector3 targetPrefabPosition = new Vector3(this.transform.position.x, newY, this.transform.position.z);
        previousGroundY = targetPrefabPosition.y;
        Instantiate(groundPrefabs[Random.Range(0, groundPrefabs.Length)], targetPrefabPosition, Quaternion.identity);
    }
}
