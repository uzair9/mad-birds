using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
  Rigidbody2D myRigidBody; // Pointer to this object's RigidBody2D component
  SpriteRenderer mySpriteRenderer; // Pointer to this object's SpriteRenderer component

  void Start()
  {
    myRigidBody = GetComponent<Rigidbody2D>(); // Exactly the same as dragging-dropping in the Unity Inspector
    myRigidBody.isKinematic = true;
  }

  void OnMouseDown()
  {
    mySpriteRenderer = GetComponent<SpriteRenderer>();
    mySpriteRenderer.color = Color.red;
  }

  void OnMouseUp()
  {
    mySpriteRenderer = GetComponent<SpriteRenderer>();
    mySpriteRenderer.color = Color.white;
  }

  void OnMouseDrag()
  {
    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
  }

  void Update()
  {

  }
}
