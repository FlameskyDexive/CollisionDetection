using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBBGameObject : MonoBehaviour {


    public CollisionShape data;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        data.UpdateShape(MathHelper.ConvertVector3(transform.position), MathHelper.ConvertVector3(transform.localScale), MathHelper.ConvertQuaternion(transform.rotation));

    }
}
