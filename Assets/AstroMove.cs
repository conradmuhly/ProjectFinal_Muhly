using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroMove : MonoBehaviour
{
    public Rigidbody2D myRB;
    public float flapStrength;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRB.velocity = Vector2.up * flapStrength;
        }
    }
}
