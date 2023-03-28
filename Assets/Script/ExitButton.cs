using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
	public void ExitThisGame()
	{
		UnityEngine.Debug.LogError ("Exit Game");
		Application.Quit ();
    }
}