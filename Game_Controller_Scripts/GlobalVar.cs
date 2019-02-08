using UnityEngine;
using System.Collections;

public class GlobalVar : MonoBehaviour {
	public static int nMacas = 6;
	public static int score = 0;
	public static int macaCai = 0;
	// Use this for initialization

	public static void SetPoints() {
		score += 10;
	}

	public static void SetNegativePoints() {
		score -= 5;
	}

	public static void setNovaMaca() {
		if (nMacas > macaCai)
			macaCai += 1;
	}
}