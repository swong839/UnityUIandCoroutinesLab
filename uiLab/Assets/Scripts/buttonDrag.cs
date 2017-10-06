using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonDrag : MonoBehaviour {

    Vector3 mouse;
    RectTransform rt;

	// Use this for initialization
	void Start () {
        mouse = Input.mousePosition;
        rt = GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void drag()
    {
        mouse = Input.mousePosition;
        rt.position = mouse;
    }
}
