using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
  public AudioSource goalSound;
  public GameObject ball;

  public void OnCollisionEnter(Collision collision) {
    // If the ball has touched the goal, then we want to play a sound.
    if(collision.collider.gameObject == ball) {
      goalSound.Play();
    }
  }
}
