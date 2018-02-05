using UnityEngine;
using System.Collections;

public class AnimationControl : MonoBehaviour {

    private Animator anim;

	void Start () {
        //Get a reference to the animator
        anim = GetComponent<Animator>();
	}
	
	void Update () {
        anim.SetFloat("Speed", Input.GetAxis("Vertical"));
        anim.SetFloat("Direction", Input.GetAxis("Horizontal"));

        //Checking for running
        if (Input.GetKey(KeyCode.LeftShift) == true)
        {
            anim.SetBool("IsShiftHeld", true);

            //if(Input.)
        } else
        {
            anim.SetBool("IsShiftHeld", false);
        }
	}
}
