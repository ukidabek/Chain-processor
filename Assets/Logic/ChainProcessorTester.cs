using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BaseGameLogic.ChainProcessing;

public class ChainProcessorTester : MonoBehaviour {

	ChainProcessor processor = null;

	// Use this for initialization
	void Start () 
	{
		processor = GetComponent<ChainProcessor> ();

		for (int i = 0; i < processor.Inputs.Count; i++) 
		{
			processor.Inputs [i].InData = new MathChainData (100);
		}

		processor.Process ();

		for (int i = 0; i < processor.Outputs.Count; i++) 
		{
			Debug.Log ((processor.Outputs [i].OutData as MathChainData).Data.ToString ());
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
