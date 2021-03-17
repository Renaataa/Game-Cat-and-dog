using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymmetricXPosition : MonoBehaviour
{
    public GameObject hero;

    Vector3 currentPosition;
    Vector3 targetPosition;

    float startTime;
    private float currentTime;
    public float randomYMax;
    public float randomYMin;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SymmetricXPosition.Start");
        InvokeRepeating("setNewPositions", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("SymmetricXPosition.Update");
        currentTime = Time.time - startTime;
        transform.position = Vector3.Slerp(currentPosition, targetPosition, currentTime);
    }

    void setNewPositions(){
        Debug.Log("SymmetricXPosition.setNewPositions");
        currentPosition = transform.position;
        targetPosition = new Vector3 (Mathf.Abs(hero.transform.position.x), Random.Range(randomYMin, randomYMax), transform.position.z);
        startTime = Time.time;
    }
}
