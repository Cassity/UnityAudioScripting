using UnityEngine;
using System.Collections;

public class CharacterAudioManager : MonoBehaviour {
    public AudioClip[] WalkingFootstepsSounds;
	public AudioClip[] RunningFootstepsSounds;

	public float OverallSpeed;


    private bool IsWalking;
    private bool IsRunning; 
    private AudioSource FsSource;
    private Rigidbody Body;
	private float MinVelocity = 0;
	private float MaxVelocity = 1;
	private float CurrentVelocity;

    
	// Use this for initialization
	void Awake () {
        FsSource = GetComponent<AudioSource>();
        Body = GetComponent<Rigidbody>();
	

	}
	
	// Update is called once per frame
	void Update () {
		
        CurrentVelocity = Body.velocity.magnitude;
		OverallSpeed = Mathf.Lerp(MinVelocity,MaxVelocity,CurrentVelocity);
		FsSource.volume = OverallSpeed;

		//Check if Running or Walking
	
        if(OverallSpeed > 0 & OverallSpeed != 1)
        {
            IsWalking = true;
            IsRunning = false;
          //  print("Walking");
        }
        else if (OverallSpeed == 1)
        {
            IsWalking = false;
            IsRunning = true;
           // print("Running");
        }
		else if (OverallSpeed < 0.5){
			IsWalking = false;
			IsRunning = false;

        
		}
	}
	

		//Play Footsteps Sounds
		void PlayFSSound () {
			
		if (IsWalking = true & IsRunning == false ){
			//FsSource.clip = WalkingFootstepsSounds;
			FsSource.PlayOneShot(WalkingFootstepsSounds[Random.Range(0,WalkingFootstepsSounds.Length)][Random.Range(0,clipStorage.Length)]);
			FsSource.Play();
		print("Walk");

    	}
		else if (IsRunning = true & IsWalking == false){
			//FsSource.clip = RunningFootstepsSound;
			FsSource.PlayOneShot(RunningFootstepsSounds[Random.Range(0,RunningFootstepsSounds.Length)]);
		print ("Run");
		
		}
		else if (IsRunning == false ){
			print ("NoSound");
		}
		else {
				print ("NoSound");
			}
	}
}
 