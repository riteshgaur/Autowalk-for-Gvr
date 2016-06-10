using UnityEngine;
using System.Collections;
public class Autowalk : MonoBehaviour {
	public Transform target;
	private bool isWalking;
	void Update () {
		if (GvrViewer.Instance.Triggered) {
			isWalking = !isWalking;
		}
		if (isWalking) {
			Vector3 direction = new Vector3(target.transform.forward.x, 0, target.transform.forward.z).normalized * 3 * Time.deltaTime;
			Quaternion rotation = Quaternion.Euler(new Vector3(0, -transform.rotation.eulerAngles.y, 0));
			transform.Translate(rotation * direction);
		}
	}
}
