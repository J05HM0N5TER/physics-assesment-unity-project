using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputController : MonoBehaviour
{
	public float pressDelay = 0.5f;
	private float buttonLastPressed = 0;
	// Start is called before the first frame update
	void Start()
	{
		buttonLastPressed = Time.time;
	}
	private void Update()
	{
		if ((Time.time - buttonLastPressed) > pressDelay/*If there has been the correct delay since the button was last pressed*/ &&
			Input.GetButton/*Down*/("Fire1")/*If mouse button is down*/ &&
			Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit)/*If the mouse is pointing at something*/)
		{
			if (hit.collider.tag == "Destroyable")
			{
				Destroy(hit.collider.gameObject);
			}
			else if (hit.collider.tag == "Button")
			{
				hit.collider.GetComponent<buttonController>().Activate();
			}
			buttonLastPressed = Time.time; // Update the time since the button was pressed
		}
		if (Input.GetKeyDown(KeyCode.Escape))
			Application.Quit();
	}
}
