using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleCrystals : MonoBehaviour
{
    public LogicScript logic;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = gameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    
         {
            logic.addScore();
}
}
