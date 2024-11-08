using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    public int height = 10;
    public int width = 8;
    public float rotationSpeed = 20f;
    public Color cubeColor = Color.red;
    public Vector3 initialPosition = new Vector3(0, 0, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("height =" + height);
        Debug.Log("width =" + width);
        Debug.Log("rotationspeed =" + rotationSpeed);
        Debug.Log("cube color =" + cubeColor);
        Debug.Log("initial position =" + initialPosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
