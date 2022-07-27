using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableEnemies : MonoBehaviour
{
  public EnemyFollow[] enemies;
    void OnTriggerEnter()
    {
      foreach(EnemyFollow enemy in enemies)enemy.enabled=false;
        
    }
}
