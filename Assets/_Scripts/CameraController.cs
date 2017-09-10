using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public int speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
	{
		if(Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 25)
		{
			transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -25)
		{
			transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.DownArrow) && transform.position.z >= -30)
		{
			transform.Translate(new Vector3(0, -speed * Time.deltaTime * 0.6f , -speed * Time.deltaTime));
		}
		if(Input.GetKey(KeyCode.UpArrow) && transform.position.z <= -5)
		{
			transform.Translate(new Vector3(0, speed * Time.deltaTime * 0.6f, speed * Time.deltaTime));
		}
		if (Input.GetKey("escape"))
			Application.Quit();
	}
}
