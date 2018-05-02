//GameManager
using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance
	{
		get
		{
			if (instance == null) instance = new GameObject ("GameManager").AddComponent<GameManager>(); //create game manager object if required
			return instance;
		}
	}
	
	//Internal reference to single active instance of object - for singleton behaviour
	private static GameManager instance = null;	
	
	void Awake ()
	{	
		//Check if there is an existing instance of this object
		if((instance) && (instance.GetInstanceID() != GetInstanceID()))
			DestroyImmediate(gameObject); //Delete duplicate
		else
		{
			instance = this; //Make this object the only instance
			DontDestroyOnLoad (gameObject); //Set as do not destroy
		}
	}	
}
