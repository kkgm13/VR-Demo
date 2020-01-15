using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixLevels : MonoBehaviour {

	// Public Audio Mixer
	public AudioMixer masterMix;
	 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Set the Effect Music Level
	public void setEffectsLvl(float effectLvl){
		masterMix.SetFloat ("effectMusic", effectLvl);
	}

	//Set the Background Music Level
	public void setBackMusicLvl (float musicLvl){
		masterMix.SetFloat ("backgroundMusic", musicLvl);
	}

}
