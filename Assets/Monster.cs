using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
  [SerializeField] Sprite deadSprite;
  [SerializeField] ParticleSystem particles;
  SpriteRenderer mySpriteRenderer;
  bool isDead = false;

  void Start()
  {
    mySpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
  }

  void OnCollisionEnter2D(Collision2D collisionInfo)
  {
    if (!isDead)
    {
      int collisionLayer = collisionInfo.gameObject.layer;

      if (collisionLayer == 6 || collisionLayer == 3)
      {
        // Only on colliding with the Bird or the Crate objects ...
        isDead = true;
        mySpriteRenderer.sprite = deadSprite;
        particles.Play();
      }
    }
  }
}
