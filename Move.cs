using UnityEngine;

public class Move : MonoBehaviour
{
    private GameObject player;
    public static bool Left = false;

    void Start()
    {
        if (player == null)
            player = GameObject.FindWithTag("Player");
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.position = new Vector3(player.transform.position.x - (10f * Time.deltaTime), player.transform.position.y, player.transform.position.z);
            Left = true;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.position = new Vector3(player.transform.position.x + (10f * Time.deltaTime), player.transform.position.y, player.transform.position.z);
            Left = false;
        }
    }
}