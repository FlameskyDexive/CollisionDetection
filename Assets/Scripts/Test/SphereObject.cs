using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereObject : MonoBehaviour
{

    public CollisionShape data;
    // Use this for initialization
    void Start()
    {
        data = new SphereShape();
    }

    // Update is called once per frame
    void Update()
    {
        data.UpdateShape(transform.position, transform.localScale, Quaternion.identity);

    }
}
