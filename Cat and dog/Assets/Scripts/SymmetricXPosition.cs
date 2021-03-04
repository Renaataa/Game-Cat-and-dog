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

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("setNewPositions", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = Time.time - startTime;
        transform.position = Vector3.Slerp(currentPosition, targetPosition, currentTime);
    }

    void setNewPositions(){
        currentPosition = transform.position;
        targetPosition = new Vector3 (Mathf.Abs(hero.transform.position.x), transform.position.y, transform.position.z);
        startTime = Time.time;
    }
}
