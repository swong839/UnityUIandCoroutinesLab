using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soilPatch : MonoBehaviour {

    public GameObject loadingBar;
    public Text harvested;
    Image bar;
    string type;
    string state;
    float time;
    public Sprite[] plants;
    Image sr;
    Sprite initSprite;
    int num = 0;

	// Use this for initialization
	void Start () {
        sr = GetComponent<Image>();
        initSprite = sr.sprite;
        state = "rest";
        bar = loadingBar.GetComponent<Image>();
        time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator seed()
    {
        bar.color = new Color(75, 195, 45);
        for (time = 0; time < 3f; time += 0.1f)
        {
            bar.fillAmount += 1f / 30f;
            yield return new WaitForSeconds(0.1f);
        }
        time = 0;
        bar.fillAmount = 0;
        sr.sprite = plants[1];
        StartCoroutine("sap");
    }

    IEnumerator sap()
    {
        bar.color = new Color(50, 130, 30);
        for (time = 0; time < 5f; time+= 0.1f)
        {
            bar.fillAmount += 1f / 50f;
            yield return new WaitForSeconds(0.1f);
        }
        time = 0;
        bar.fillAmount = 0;
        sr.sprite = plants[2];
        state = "plant";
        StartCoroutine("plant");
    }

    IEnumerator plant()
    {
        bar.color = new Color(25, 70, 15);
        for (time = 0; time < 5f; time += 0.1f)
        {
            bar.fillAmount += 1f / 50f;
            yield return new WaitForSeconds(0.1f);
        }
        time = 0;
        bar.fillAmount = 0;
        sr.sprite = initSprite;
        state = "rest";
    }

    public void startGrow(string seed)
    {
        if (state == "rest")
        {
            type = seed;
            state = "growing";
            bar.fillAmount = 0;
            sr.sprite = plants[0];
            StartCoroutine("seed");
        }
    }

    public void harvest()
    {
        if (state == "plant")
        {
            num += 1;
            harvested.text = "x" + harvested.GetComponent<Elements>().num();
            state = "rest";
            bar.fillAmount = 0;
            sr.sprite = initSprite;
            StopCoroutine("plant");
        }
    }
}
