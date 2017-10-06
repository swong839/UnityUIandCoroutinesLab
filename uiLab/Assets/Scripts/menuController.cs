using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour {
    public GameObject main;
    GameObject curr;

	// Use this for initialization
	void Start () {
        curr = main;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void goTo(GameObject image)
    {
        curr.SetActive(false);
        image.SetActive(true);
        curr = image;
    }

    public void goToGame()
    {
        SceneManager.LoadScene("altMain");
    }
}
