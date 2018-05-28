using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZmianaModelu : MonoBehaviour {

	public GameObject modelA;
	public GameObject modelB;
	public GameObject modelC;
	private int modelNumber;

	void Start () 
	{
		modelNumber = 1;
		modelB.SetActive(false);
		modelC.SetActive(false);
	}

	void ModelSwitch() 
	{
		if(modelNumber == 1)
		{
			modelA.SetActive(false);
			modelB.SetActive(true);
			modelNumber = 2;
		}

		else if(modelNumber == 2) 
		{
			modelB.SetActive(false);
			modelC.SetActive(true);
			modelNumber = 3;
		}

		else if(modelNumber == 3)
		{
			modelC.SetActive(false);
			modelA.SetActive(true);
			modelNumber = 1;
		}
	
	}



	void Update () 
	{
		if (Input.GetButtonDown("Jump")) 
		{
			ModelSwitch();
		}

	}
}
