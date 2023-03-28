using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadButton : MonoBehaviour
{
    // Start is called before the first frame update
	//Create global variable
	public AudioSource myFx;
	public AudioClip clickFx;


	//create function
	public void ClickSound()
	{
		myFx.PlayOneShot(clickFx);
	}
}
