using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WorldTickSystem : MonoBehaviour, ITick {

    private float currentTime = 0;


    private static bool exists = false;
    private void Awake() {
        if (!exists)
        {
            DontDestroyOnLoad(this.gameObject);
            exists = true;
        }
    }

    private void Update () {
	CalculateTicks();
    }

    public void CalculateTicks() {
        currentTime += Time.deltaTime;
	if(currentTime >= TickProperties.worldTickLength) {
		currentTime = 0f;
		TickProperties.ticksSinceLaunch++;
	}
    }

}


