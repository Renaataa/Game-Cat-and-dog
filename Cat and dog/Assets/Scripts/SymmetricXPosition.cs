using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymmetricXPosition : MonoBehaviour
{
    public GameObject hero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = new Vector3 ( Mathf.Abs(hero.transform.position.x), transform.position.y, transform.position.z);
    }
}
