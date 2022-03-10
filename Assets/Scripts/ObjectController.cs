using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    int speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;

    }

    // Update is called once per frame
    void Update()
    {
        ChangeShape();
        Movement();
    }
    void ChangeShape()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
            transform.Rotate(0,0,90);
    }
    void Movement()
    {
        transform.Translate(Vector3.forward *speed* Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        Time.timeScale = 0;
    }
    
}
