using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputController : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}
	private void Update()
	{
		if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit)/*If the mouse is pointing at something*/ &&
   Input.GetButton/*Down*/("Fire1")/*If mouse button is down*/)
		{
			if (hit.collider.tag == "Dragable")
			{
				Destroy(hit.collider.gameObject);
			}
			else if (hit.collider.tag == "Button")
			{
				hit.collider.GetComponent<buttonController>().Activate();
			}
		}
		if (Input.GetKeyDown(KeyCode.Escape))
			Application.Quit();
	}
}
