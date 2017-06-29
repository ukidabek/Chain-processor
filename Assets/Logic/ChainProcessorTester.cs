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
	}
	
	// Update is called once per frame
	void Update () 
	{
		for (int i = 0; i < processor.Inputs.Count; i++) 
		{
			processor.Inputs [i].InData = new MathChainData (Random.Range(0f,100f));
		}

		processor.Process ();

		for (int i = 0; i < processor.Outputs.Count; i++) 
		{
			Debug.Log ( processor.Outputs [i].IOName + ": "+
				(processor.Outputs [i].OutData as MathChainData).Data.ToString ());
		}	
	}
}
