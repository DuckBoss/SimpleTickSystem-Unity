using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Use this script to output debug values to a TextMeshPro UI Text.

public class FarmingTickUI : MonoBehaviour {

    public TMP_Text UI_Text;
    public FarmingGrowthSystem FarmScript;

    private void Update() {
        string toPrint = $"Ticks Since Growth: {FarmScript.TicksSinceGrowth}\n " +
                        $"Ticks Per Growth Phase: {FarmScript.TicksPerGrowthPhase}\n " +
                        $"Current Growth Phase: {FarmScript.CurrentGrowthPhase}\n " +
                        $"Max Growth Phase: {FarmScript.MaxGrowthPhases}\n" +
                        $"Farming Tick Length: {FarmingTickProperties.farmingTickLength}\n";

        UI_Text.text = toPrint;
    }

}
