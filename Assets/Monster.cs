using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
  void OnCollisionEnter2D(Collision2D collisionInfo)
  {
    int collisionLayer = collisionInfo.gameObject.layer;

    if (collisionLayer == 6 || collisionLayer == 3)
    {
      // Only on colliding with the Bird or the Monster objects ...
      gameObject.SetActive(false);
    }
  }
}
