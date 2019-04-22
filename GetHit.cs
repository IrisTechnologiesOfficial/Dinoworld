using UnityEngine;

public class GetHit : MonoBehaviour
{
    private const string Tag = "Enemy";
    public Animation hit;
    public bool Impulse = true;
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == Tag)
        {
            if(hit != null)
                hit.Play();
            if (Impulse)
            {
                if(Move.Left)
                    col.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1500f * Time.deltaTime, 0f), ForceMode2D.Impulse);
                else
                    col.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1500f * Time.deltaTime, 0f), ForceMode2D.Impulse);
            }
        }
    }
}