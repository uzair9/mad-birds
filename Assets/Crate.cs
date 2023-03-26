using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
  SpriteRenderer mySpriteRenderer;

  void Start()
  {
    mySpriteRenderer = GetComponent<SpriteRenderer>();
  }

  void OnCollisionEnter2D(Collision2D collisionInfo)
  {
    if (collisionInfo.gameObject.layer == 6)
    {
      // Only on colliding with the Bird ...
      mySpriteRenderer.color = new Color(0.55f, 0.55f, 0.55f, 1f);
    }
  }
}
