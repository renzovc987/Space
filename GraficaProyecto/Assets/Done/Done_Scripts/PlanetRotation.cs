using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public float xAngle, yAngle, zAngle;
    public GameObject cube1;
    void Start()
    {
        cube1.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
   

    }

    // Update is called once per frame
    void Update()
    {
        cube1.transform.Rotate(xAngle*0.5f * Time.deltaTime, yAngle*0.5f * Time.deltaTime, zAngle, Space.Self);
    }
}
