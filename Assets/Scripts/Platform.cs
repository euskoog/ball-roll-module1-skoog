using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    
    Vector3 pointA = new Vector3(0.1924539f, 4.401073f, -2.341999f);
    Vector3 pointB = new Vector3(5.31f, 8.7f, 6.9f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, (Mathf.PingPong(Time.time, 3)) / 3);
    }
}
