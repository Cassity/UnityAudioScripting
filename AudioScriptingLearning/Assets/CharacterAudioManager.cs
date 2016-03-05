using UnityEngine;
using System.Collections;

public class CharacterAudioManager : MonoBehaviour {
    public AudioClip FootstepsSound;
    private bool IsWalking;
    private bool IsRunning;
    public float OverallSpeed;
    private AudioSource FsSource;
    private Rigidbody Body;
    
	// Use this for initialization
	void Awake () {
        FsSource = GetComponent<AudioSource>();
        Body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        OverallSpeed = Body.velocity.magnitude;
	
        if(OverallSpeed > 0 & OverallSpeed < 1)
        {
            IsWalking = true;
            IsRunning = false;
          //  print("Walking");
        }
        else if (OverallSpeed > 1)
        {
            IsWalking = false;
            IsRunning = true;
           // print("Running");
        }

        
	}

    function  OnCollisionEnter () {

        print("FS");
    }
    
}
 