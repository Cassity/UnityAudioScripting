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
		else if (OverallSpeed < 0.004){
			IsWalking = false;
			IsRunning = false;

        
		}
	}

	void PlayFS () {
		if (IsWalking = true){
		print("Walk");
    	}
		else if (IsRunning = true ){
		print ("Run");
		}
		else if (IsRunning == false & IsWalking == false ){
			print ("NoSound");
		}
		else {
				print ("NoSound");
			}
	}
}
 