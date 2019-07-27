using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawer : MonoBehaviour {
    LineRenderer rend;

	// Use this for initialization
	void Start () {
        rend = GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        rend.SetPosition(1, gameObject.transform.position);
	}
}
