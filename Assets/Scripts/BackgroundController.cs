using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour {

	public float timeOut;
  private float timeTrigger;
	public float runspeed = 0.2f;

	// Update is called once per frame
	void Update () {

		timeElapsed += Time.deltaTime;

        if(timeElapsed >= timeOut) {

						runspeed = runspeed +0.1f;

            timeElapsed = 0.0f;
					}


		float scroll = Mathf.Repeat (Time.time * runspeed, 1);
		Vector2 offset = new Vector2 (scroll, 0);
		GetComponent<Renderer>().sharedMaterial.SetTextureOffset ("_MainTex", offset);
	}
}
