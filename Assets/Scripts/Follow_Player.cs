using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    [SerializeField] GameObject player;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0,2.24f,-4);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Movement();
    }
    void Movement()
    {
        transform.position =  player.transform.position +offset ;
    }
}
