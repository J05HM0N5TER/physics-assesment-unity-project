using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class buttonController : MonoBehaviour
{
    public Rigidbody platform = null;
    public Ragdoll ragdoll = null;

    private void OnTriggerEnter(Collider other)
    {
        ragdoll.RagdollOn = true;
        platform.isKinematic = false;
    }
}
