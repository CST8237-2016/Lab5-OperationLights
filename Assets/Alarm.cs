using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Light))]
public class Alarm : MonoBehaviour {

  public AudioSource alarmSound;
  public GameObject ball;

  // Use this for initialization
  void Start() {

  }

  void OnTriggerEnter(Collider collider) {
    if(collider.gameObject == ball) {
      alarmSound.Play();
    }
  }

  void OnTriggerExit(Collider collider) {
    if(collider.gameObject == ball) {
      alarmSound.Stop();
    }
  }

}
