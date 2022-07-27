using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableEnemies : MonoBehaviour
{
  public EnemyFollow[] enemies;
    void OnTriggerEnter()
    {
      foreach(EnemyFollow enemy in enemies)enemy.enabled=true;
        
    }
    void Start(){
      foreach(EnemyFollow enemy in enemies)enemy.enabled=false;
    } 
}
