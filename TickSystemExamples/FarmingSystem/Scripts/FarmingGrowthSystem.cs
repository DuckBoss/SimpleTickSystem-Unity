using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmingGrowthSystem : MonoBehaviour, ITick, IGrowable {

	private double _currentTime = 0;

	private int _ticksSinceGrowth = 0;
	public int TicksSinceGrowth {
		get { return _ticksSinceGrowth; }
	}

	private int _curGrowthPhase = 0;
	public int CurrentGrowthPhase {
		get { return _curGrowthPhase; }
		set { _curGrowthPhase = value; }
	}
	
	private int _maxGrowthPhases = 5;
	public int MaxGrowthPhases {
		get { return _maxGrowthPhases; }
		set { _maxGrowthPhases = value; }
	}

	private int _ticksPerGrowthPhase = 100;
	public int TicksPerGrowthPhase {
		get { return _ticksPerGrowthPhase; }
		set { _ticksPerGrowthPhase = value; }
	}

	private bool _canGrow;
	public bool CanGrow {
		get { return _canGrow; }
		set { _canGrow = value; }
	}
	
	private void Start() {
		CanGrow = true;
	}

	private void Update () {
		if(CanGrow) {
			CalculateTicks();
			CalculateGrowthPhases();
		}
	}

	public void CalculateGrowthPhases() {
		
		if(CurrentGrowthPhase >= MaxGrowthPhases) {
			CanGrow = false;
			_ticksSinceGrowth = 0;
			return;
		}
		CanGrow = true;

		if(_ticksSinceGrowth >= TicksPerGrowthPhase) {
			CurrentGrowthPhase++;
			_ticksSinceGrowth = 0;
		}
		
	}

	public void CalculateTicks() {
        _currentTime += Time.deltaTime;
		if(_currentTime >= FarmingTickProperties.farmingTickLength) {
			_currentTime = 0f;
			_ticksSinceGrowth++;
		}
    }

}
