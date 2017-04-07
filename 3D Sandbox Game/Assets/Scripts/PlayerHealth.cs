﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
	[SerializeField]
	private int _health;
	public int maxHealth;
	public AudioClip damagedSound;

	public int health {
		get {
			return _health;
		}
		set {
			//health = value; Oh, this is the bug! Before i found this the program would crash when I touched the zombie due to infinite recursion
			if (value < _health) {
				Debug.Log ("Oof!");
				AudioSource.PlayClipAtPoint (damagedSound, transform.position, 100);
			}
			_health = value;

			if (_health > maxHealth) {
				_health = maxHealth;
			}
			if (_health < 0) {
				_health = 0;
			}


		}
	}

	// Use this for initialization
	void Start () {
		_health = maxHealth;

	}
	
	// Update is called once per frame
	void Update () {


	}
}
