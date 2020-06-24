using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MusicPause : MonoBehaviour {
	// Use this for initialization
	AudioSource[] As;
	void Awake()
    {
		As = GetComponentsInChildren<AudioSource>();
	}
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public  void musicPause()
    {
		foreach (AudioSource Ass in As)
        {
			if (Ass != null)
            {
				Ass.Stop();
			}
        }
    }
}
