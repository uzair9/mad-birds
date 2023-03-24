using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
  Rigidbody2D myRigidBody; // Pointer to this object's RigidBody2D component
  SpriteRenderer mySpriteRenderer; // Pointer to this object's SpriteRenderer component
  Vector2 birdDefaultPosition;

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
    transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
  }

  void OnMouseUp()
  {
    mySpriteRenderer.color = Color.white;

    Vector2 birdCurrentPosition = myRigidBody.position;
    Vector2 directionToFly = birdDefaultPosition - birdCurrentPosition;
    myRigidBody.bodyType = RigidbodyType2D.Dynamic; // It is kinematic right now; force won't act on it
    myRigidBody.AddForce(directionToFly * 500f);
  }
}
