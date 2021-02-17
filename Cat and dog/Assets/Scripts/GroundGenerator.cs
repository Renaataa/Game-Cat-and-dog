using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    public GameObject groundPrefab;
    public float maxStep;
    private float previousGroundY = -2.38f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateNewGround", 0, 2.6f);
    }

    void GenerateNewGround()
    {
        Vector3 targetPrefabPosition = new Vector3(this.transform.position.x, Random.Range(-3f, maxStep + previousGroundY), this.transform.position.z);
        previousGroundY = targetPrefabPosition.y;
        Instantiate(groundPrefab, targetPrefabPosition, Quaternion.identity);
    }
}
