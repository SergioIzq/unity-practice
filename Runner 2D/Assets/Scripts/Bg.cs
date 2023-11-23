using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bg : MonoBehaviour
{

    public float speed=5F;
    BoxCollider2D bc;

    private void Start()
    {
        bc= GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if(transform.position.x < -bc.size.x * transform.localScale.x)
        {
            transform.position += Vector3.right * bc.size.x * transform.localScale.x*2;
        }


    }
}
