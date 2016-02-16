using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Rotator : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);

		//Vector3 destination = new Vector3 (0, transform.position.y, 5);
		//transform.DOMove (destination, 2f);

	}
}
