using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Ragdoll : MonoBehaviour
{
	private Animator animator = null;
	public List<Rigidbody> rigidbodies = new List<Rigidbody>();


	public bool RagdollOn 
	{ 
		get
		{ 
			return! animator.enabled; 
		}
		set
		{
			animator.enabled = !value;
			foreach(Rigidbody r in rigidbodies)
				r.isKinematic = !value;
		}
	}
	
	// Use this for initialisation
	void Start() 
	{
		animator = GetComponent<Animator>();
		Rigidbody[] temp = GetComponentsInChildren<Rigidbody>();
		for (int i = 0; i < temp.Length; i++)
		{
			rigidbodies.Add(temp[i]);
		}

		foreach(Rigidbody r in rigidbodies)
			r.isKinematic = true;
	}
}
