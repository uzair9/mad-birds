using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
  [SerializeField] Sprite deadSprite;

  void OnCollisionEnter2D(Collision2D collisionInfo)
  {
    int collisionLayer = collisionInfo.gameObject.layer;

    if (collisionLayer == 6 || collisionLayer == 3)
    {
      // Only on colliding with the Bird or the Crate objects ...
      gameObject.GetComponent<SpriteRenderer>().sprite = deadSprite;
    }
  }
}
