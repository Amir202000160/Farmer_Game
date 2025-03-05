using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour, IMove, IDestoryOff
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moveee();
        DestoryOff();
    }



    public void Moveee()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    public void DestoryOff()
    {
        
        if (transform.position.z < -10)
        {
            Destroy(gameObject);
        }
    }
}
