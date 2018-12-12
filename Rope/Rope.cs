using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour {

    GameObject obj;
    public int howMany=1;
	// Use this for initialization
	void Start () {

        GameObject temp = null;
        for (int i=0;i < howMany; i++)
        {
            obj = transform.GetChild(transform.childCount - 1).gameObject;
            temp = Instantiate(obj, transform) as GameObject;
            temp.GetComponent<HingeJoint>().connectedBody = obj.GetComponent<Rigidbody>();
            temp.name = "rope";
        }

        transform.GetChild(0).GetComponent<HingeJoint>().connectedBody = temp.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		//blabla
	}
}
