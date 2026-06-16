using UnityEngine;

public class SpawnerFollow : MonoBehaviour
{
 public Transform player;
public float distanceAhead = 20f;

void Update()
 {
 transform.position = new Vector3(
 player.position.x,
  transform.position.y,
 player.position.z + distanceAhead
 );
}}