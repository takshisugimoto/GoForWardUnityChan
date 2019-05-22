using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {

	private AudioSource audioSource;
	public AudioClip audioClip;


	// Use this for initialization
	void Start () {
		//audioコンポーネントを取得する
		audioSource = GetComponent<AudioSource> ();



	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter2D (Collision2D collision) {
		//groundタグとCubePrefabが衝突時に音を鳴らす
		if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "CubePrefab") {
			gameObject.GetComponent<AudioSource>().PlayOneShot (audioClip);
		}
		}
	}
			
	
	
