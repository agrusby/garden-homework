using UnityEngine;
using System.Collections;

public class generator : MonoBehaviour {

	public Transform building, dog, sculpture1, sculpture2, tree;

	int buildingCount = 300;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < buildingCount; i++) {
			float randomNumber = Random.Range (0f, 100f);
			if (randomNumber >= 0f && randomNumber < 10f){
				Instantiate (building, new Vector3( Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f) ), Quaternion.identity );
			}
			else if (randomNumber >= 10f && randomNumber < 35f){
				Instantiate (dog, new Vector3( Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f) ), Quaternion.identity );
			}
			else if (randomNumber >= 35f && randomNumber < 55f){
				Instantiate (sculpture1, new Vector3( Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f) ), Quaternion.identity );
			}
			else if (randomNumber >= 55f && randomNumber < 80f){
				Instantiate (sculpture2, new Vector3( Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f) ), Quaternion.identity );
			}
			else if (randomNumber >= 80f && randomNumber < 100f){
				Instantiate (tree, new Vector3( Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f) ), Quaternion.identity );
			}
				}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
