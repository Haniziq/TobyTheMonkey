using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answer: MonoBehaviour
{
	public GameObject feed_betul, feed_salah;

	//public Text text_skor;

	//int skor=0;

    // Start is called before the first frame update
    void Start()
    {
		
    }

	public void jawapan(bool answer)
	{
		if(answer)
		{
			feed_betul.SetActive(false);
			feed_betul.SetActive(true);
			int skor = PlayerPrefs.GetInt("skor") +20;
			PlayerPrefs.SetInt("skor", skor);
			//skor+=10;
		}
		else
		{
			feed_salah.SetActive(false);
			feed_salah.SetActive(true);
		}
		// load the next question
		gameObject.SetActive(false);
		transform.parent.GetChild(gameObject.transform.GetSiblingIndex()+1).gameObject.SetActive(true);
	}

    // Update is called once per frame
    void Update()
    {
		//GetComponent<Text>().text = PlayerPrefs.GetInt("skor").ToString();
		//text_skor.text = skor.ToString();
    }
}
