using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
  Monster[] monsters;
  [SerializeField] string nextLevelName;

  void OnEnable()
  {
    monsters = FindObjectsOfType<Monster>();
  }

  void Update()
  {
    if (areMonstersDead())
    {
      SceneManager.LoadScene(nextLevelName);
    }
  }

  bool areMonstersDead()
  {
    foreach (Monster monster in monsters)
    {
      if (monster.gameObject.activeSelf)
        return false;
    }
    return true;
  }
}
