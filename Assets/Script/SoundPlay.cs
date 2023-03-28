using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundPlay : MonoBehaviour
{
	public AudioClip bcgMusic;
    // Start is called before the first frame update
    void Start()
    {
		AudioSource.PlayClipAtPoint (bcgMusic, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
