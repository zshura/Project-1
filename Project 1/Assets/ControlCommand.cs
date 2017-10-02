using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCommand : MonoBehaviour {
	
	int bronzePlayer;
	int silverPlayer;
	int bronzeSupply;
	int silverSupply;
	int miningSpeed;
	int timeToMine;

	// Use this for initialization
	void Start () {
		bronzePlayer = 0;
		silverPlayer = 0;
		miningSpeed = 2;
		bronzeSupply = 3;
		silverSupply = 2;
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

		}

		 //only mine silver if there's no bronze in the supply and at least 1 silver
		else if (bronzeSupply == 0 && silverSupply >= 1) {
					silverSupply -= 1;
					silverPlayer += 1;

			}
		
			//make sure we wait another miningSpeed seconds before mining again

			//Tell the player how much ore they have
			print ("Bronze:" +bronzePlayer + "... Silver:"+silverPlayer);

			timeToMine += miningSpeed;

	
			}
		}
}