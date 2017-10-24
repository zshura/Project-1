using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCommand : MonoBehaviour {

	int bronzePlayer;
	int silverPlayer;
	int goldPlayer;
	int bronzeSupply;
	int silverSupply;
	int goldSupply;
	int miningSpeed;
	int timeToMine;
	public GameObject CubePreFab;
	GameObject currentCube;


	Vector3 cubePosition;

	// Use this for initialization
	void Start () {
		bronzePlayer = 0;
		silverPlayer = 0;
		goldPlayer = 0;
		miningSpeed = 3;
		bronzeSupply = 2;
		silverSupply = 2;
		goldSupply = 1;
		timeToMine = miningSpeed;


	}


	// Update is called once per frame
	void Update () {

		if (Time.time > timeToMine) {
			//mine some ore, and update how many ore the player has


			//only mine bronze if we have at least 1 in the supply
			if (bronzeSupply >= 1) {
				bronzeSupply -= 1;
				bronzePlayer += 1;


				cubePosition = new Vector3 (Random.Range (-4, 5), Random.Range (-4, 5), 0);
				currentCube = (GameObject) Instantiate (CubePreFab, cubePosition, Quaternion.identity);
				currentCube.GetComponent <Renderer>(). material.color = Color.red;  

			}

			//only mine silver if there's no bronze in the supply and at least 1 silver
			else if (bronzeSupply == 0 && silverSupply >= 1) {
				silverSupply -= 1;
				silverPlayer += 1;

				cubePosition = new Vector3 (Random.Range (-4, 5), Random.Range (-4, 5), 0);
				currentCube = (GameObject) Instantiate (CubePreFab, cubePosition, Quaternion.identity);
				currentCube.GetComponent <Renderer>(). material.color = Color.white; 

			}

			//When two bronze and two silver, create a gold

			if (bronzePlayer == 2 && silverPlayer == 2 && goldSupply == 1) {
				
				goldSupply -= 1;
				goldPlayer += 1;


				cubePosition = new Vector3 (Random.Range (-4, 5), Random.Range (-4, 5), 0);
				currentCube = (GameObject) Instantiate (CubePreFab, cubePosition, Quaternion.identity);
				currentCube.GetComponent <Renderer>(). material.color = Color.yellow;  

			}
				
			print ("Bronze:" +bronzePlayer + "... Silver:"+silverPlayer + "...Gold:"+goldPlayer);

			timeToMine += miningSpeed;


		}
	}
}
