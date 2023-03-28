using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UserName : MonoBehaviour
{
	public Text userName;
	public InputField inputName;

	User user = new User();

	public static string playerName;

	private void Start()
	{
		getName();
	}

	public void onSubmit()
	{
		playerName = inputName.text;
		if(playerName != ""){
		PostToDatabase();
		}
	}

	public void getName(){
		retriveData();
	}

	public void UpdateName()
	{
		userName.text = user.username;
	}

	private void PostToDatabase(){
		User user = new User();
		RestClient.Put("https://ad-story.firebaseio.com/"+ playerName +".json", user);
		SceneManager.LoadScene("Instruction");
		//getName();
	}

	private void retriveData(){
		RestClient.Get<User>("https://ad-story.firebaseio.com/"+ playerName +".json").Then(response =>
			{
				user = response;
				UpdateName();
			});
	}


}
