using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
  Monster[] monsters;
  [SerializeField] string nextLevelName;
  [SerializeField] GameObject gameFinished;
  public bool isGameOver = false;

  void OnEnable()
  {
    monsters = FindObjectsOfType<Monster>();
  }

  void Update()
  {
    if (areMonstersDead())
    {
      if (nextLevelName != "GameFinished")
      {
        SceneManager.LoadScene(nextLevelName);
      }
      else
      {
        isGameOver = true;
        gameFinished.SetActive(true);
      }
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
