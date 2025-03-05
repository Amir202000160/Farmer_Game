using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour, IMove,IDestoryOff
{
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
        transform.Translate(Vector3.forward * Time.deltaTime * 10f);
    }
    public void DestoryOff()
    {

        if (transform.position.z > 30)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
