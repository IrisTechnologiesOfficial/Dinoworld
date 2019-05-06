using UnityEngine;
using System.Collections.Generic;

public class Respawn : Monobehaviour
{
  public List<Vector2> RespawnPoints = new List<Vector2>();
  private Vector2 ActualRespawn = new Vector2();
  private GameObject player;
  
  public void Start()
  {
    player = GameObject.FindWithTag("Player");
  }
  
  public void Update()
  {
    if(SOMETHING HAPPEN)
      ActualRespawn = RespawnPoints[?];
    if(Player.HP < 1)
      {
        Player.HP = MaxLife;
        player.translation.position = new Vector3(ActualRespawn.x, ActualRespawn.y, Layer);
      }
  }
}
