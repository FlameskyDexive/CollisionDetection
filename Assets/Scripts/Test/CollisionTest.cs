using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{

    [SerializeField]
    BoxObject sourcesTarget;
    

    [SerializeField]
    BoxObject targetOBB;
    // Use this for initialization

    [SerializeField]
    SphereObject sphere;
    [SerializeField]
    SphereObject sphereTarget;
    [SerializeField]
    private bool obbClosion;

    [SerializeField]
    private bool sphereCollsion;
    // Use this for initialization
    void Start()
    {

    }


    [ContextMenu("LogClosePoint")]
    void LogClosePoint()
    {
        var s = BoxShape.ClosestPointTo(new Vector3(10, 10, 10),
            new Vector3(15, 15, 15),
            new Vector3(0.5f, 0.5f, 0.5f),
            new Quaternion(30, 30, 30, 30));

        Debug.Log(s);
    }
    // Update is called once per frame
    void Update()
    {
        
        obbClosion = false;
        if (targetOBB != null)
        {
            obbClosion = sourcesTarget.data.Intersects(targetOBB.data);

        }

        sphereCollsion = false;
        if (sphere != null)
        {
            sphereCollsion = sourcesTarget.data.Intersects(sphere.data);

        }

        //bool col2 = false;
        //if (point != null)
        //{
        //    col2 = data.Contains(point.position);

        //}

        if (obbClosion || sphereCollsion)
        {

            sourcesTarget.GetComponent<MeshRenderer>().materials[0].SetColor("_Color", new Color(1, 0, 0));
        }
        else
        {
            sourcesTarget.GetComponent<MeshRenderer>().materials[0].SetColor("_Color", new Color(1, 1, 1));
        }

        bool sphereVsSphere = sphereTarget.data.Intersects(sphere.data);
        if (sphereVsSphere)
        {

            sphereTarget.GetComponent<MeshRenderer>().materials[0].SetColor("_Color", new Color(1, 0, 0));
        }
        else
        {
            sphereTarget.GetComponent<MeshRenderer>().materials[0].SetColor("_Color", new Color(1, 1, 1));
        }


    }
    
    
}
