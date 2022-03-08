using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Quaternion = System.Numerics.Quaternion;

public class SphereGameObject : MonoBehaviour
{

    public CollisionShape data;
    // Use this for initialization
    void Start()
    {
        // Quaternion qua = Quaternion.Euler(transform.eulerAngles);

    }

    // Update is called once per frame
    void Update()
    {
        data.UpdateShape(MathHelper.ConvertVector3(transform.position), MathHelper.ConvertVector3(transform.localScale), Quaternion.Identity);

    }
}
