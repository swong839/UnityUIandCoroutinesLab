using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameManager : MonoBehaviour {

    soilPatch soil;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void soilName(GameObject patch)
    {
        soil = patch.GetComponent<soilPatch>();
        soil.harvest();
        //soil = GameObject.Find(patch.name).GetComponent<soilPatch>();
    }

    public void name(string seed)
    {
        if (soil != null)
        {
            soil.startGrow(seed);
        }
    }

    public void goToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
