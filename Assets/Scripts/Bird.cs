using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
  Rigidbody2D myRigidBody; // Pointer to this object's RigidBody2D component
  SpriteRenderer mySpriteRenderer; // Pointer to this object's SpriteRenderer component
  Vector2 birdDefaultPosition;
  [SerializeField] float launchSpeed; // Can also keep public to serialize in Unity.

  Bird()
  {
    launchSpeed = 500f;
  }

  void Start()
  {
    myRigidBody = GetComponent<Rigidbody2D>(); // Exactly the same as dragging-dropping in the Unity Inspector
    myRigidBody.isKinematic = true;
    birdDefaultPosition = myRigidBody.position;

    mySpriteRenderer = GetComponent<SpriteRenderer>();
  }

  void OnMouseDown()
  {
    mySpriteRenderer.color = Color.red;
  }

  void OnMouseDrag()
  {
    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    if (mousePosition.x > birdDefaultPosition.x)
    {
      mousePosition.x = birdDefaultPosition.x;
    }

    myRigidBody.position = mousePosition;
  }

  void OnMouseUp()
  {
    mySpriteRenderer.color = Color.white;

    Vector2 birdCurrentPosition = myRigidBody.position;
    Vector2 directionToFly = birdDefaultPosition - birdCurrentPosition;
    myRigidBody.bodyType = RigidbodyType2D.Dynamic; // It is kinematic right now; force won't act on it
    myRigidBody.AddForce(directionToFly * launchSpeed);
  }

  void OnCollisionEnter2D(Collision2D collisionInfo)
  {
    StartCoroutine(WaitAndResetBird(2));
  }

  void OnBecameInvisible()
  {
    StartCoroutine(WaitAndResetBird(0.5f));
  }

  IEnumerator WaitAndResetBird(float waitingTime)
  {
    yield return new WaitForSeconds(waitingTime);
    resetBird();
  }

  void resetBird()
  {
    myRigidBody.position = birdDefaultPosition;
    myRigidBody.velocity = Vector2.zero;
    myRigidBody.bodyType = RigidbodyType2D.Kinematic;
  }
}
