
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Vuforia
{
	public class dataTarget : MonoBehaviour
	{
		
		public Transform TextTargetName;
		public Transform ButtonAction;
		public Transform Username;

		public AudioSource soundTarget;
		public AudioClip clipTarget;

		// Use this for initialization
		void Start()
		{
			//add Audio Source as new game object component
			soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();
		}

		// Update is called once per frame
		void Update()
		{
			StateManager sm = TrackerManager.Instance.GetStateManager();
			IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

			foreach (TrackableBehaviour tb in tbs)
			{
				User user = new User();
				string name = tb.TrackableName;
				ImageTarget it = tb.Trackable as ImageTarget;
				Vector2 size = it.GetSize();

				Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

				//Evertime the target found it will show “name of target” on the TextTargetName. Button will visible (active)

				TextTargetName.GetComponent<Text>().text = name;
				ButtonAction.gameObject.SetActive(true);
				Username.gameObject.SetActive(true);



				//If the target name was “Toby_Story” then add listener to ButtonAction with location of the page 1 sound (locate in Resources/sounds folder)

				if(name == "Toby_Story"){
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/test"); });
					Username.GetComponent<Text>().text = user.username;
					TextTargetName.GetComponent<Text>().text = "is reading Toby Story";

				}



				//If the target name was “page 1” then add listener to ButtonAction with location of the unitychan sound (locate in Resources/sounds folder) and set text on TextDescription a description of the unitychan / robot

				if (name == "page1")
				{
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/page1"); });
					Username.GetComponent<Text>().text = user.username;
					TextTargetName.GetComponent<Text>().text = "is reading Page 1";
				}

				if (name == "page2")
				{
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/page2"); });
					Username.GetComponent<Text>().text = user.username;
					TextTargetName.GetComponent<Text>().text = "is reading Page 2";
				}

				if (name == "Page_3")
				{
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Page 3"); });
					Username.GetComponent<Text>().text = user.username;
					TextTargetName.GetComponent<Text>().text = "is reading Page 3";
				}

				if (name == "Page_4")
				{
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/crocodile"); });
					Username.GetComponent<Text>().text = user.username;
					TextTargetName.GetComponent<Text>().text = "is reading Page 4";
				}

				if (name == "Page_5")
				{
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Page 5"); });
					Username.GetComponent<Text>().text = user.username;
					TextTargetName.GetComponent<Text>().text = "is reading Page 5";
				}

				if (name == "Page_6")
				{
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Page 6"); });
					Username.GetComponent<Text>().text = user.username;
					TextTargetName.GetComponent<Text>().text = "is reading Page 6";
				}

				if (name == "Page_7")
				{
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Page 7"); });
					Username.GetComponent<Text>().text = user.username;
					TextTargetName.GetComponent<Text>().text = "is reading Page 7";
				}

				if (name == "Page_8")
				{
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/toucantoby"); });
					Username.GetComponent<Text>().text = user.username;
					TextTargetName.GetComponent<Text>().text = "is reading Page 8";
				}

				if (name == "Page_9")
				{
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Page 9"); });
					Username.GetComponent<Text>().text = user.username;
					TextTargetName.GetComponent<Text>().text = "is reading Page 9";
				}

				if (name == "Page_10")
				{
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Page 10"); });
					Username.GetComponent<Text>().text = user.username;
					TextTargetName.GetComponent<Text>().text = "is reading Page 10";
				}
			}
		}

		//function to play sound
		void playSound(string ss){
			clipTarget = (AudioClip)Resources.Load(ss);
			soundTarget.clip = clipTarget;
			soundTarget.loop = false;
			soundTarget.playOnAwake = false;
			soundTarget.Play();
		}

	}
}
