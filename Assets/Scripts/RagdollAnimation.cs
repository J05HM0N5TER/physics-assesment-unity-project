using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class RagdollAnimation : MonoBehaviour
{
    Vector3 previousPostion;
    Animator ani = null;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        previousPostion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        ani.SetFloat("speed", (transform.position - previousPostion).magnitude);
        previousPostion = transform.position;
    }
}
