using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    private Collider2D _collider;

    private void Awake()
    {
        _collider = GetComponent<Collider2D>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Area"))
            return;

        Vector3 playerPos = GameManager.instance.player.transform.position;
        Vector3 tilePos = transform.position;
        float diffX = Mathf.Abs(playerPos.x - tilePos.x);
        float diffY = Mathf.Abs(playerPos.y - tilePos.y);

        Vector2 playerDir = GameManager.instance.player.GetComponent<Movement>().CurrentDirection();
        float dirX = playerDir.x < 0 ? -1 : 1;
        float dirY = playerDir.y < 0 ? -1 : 1;

        switch (transform.tag)
        {
            case "Ground": 
                if (diffX > diffY)
                {
                    transform.Translate(Vector3.right * dirX * 40);
                }
                else if (diffX < diffY)
                {
                    transform.Translate(Vector3.up * dirY * 40);
                }
                break;
            case "Enemy":
                if (_collider.enabled)
                {
                    transform.Translate(playerDir * 20 + new Vector2(Random.Range(-3f, 3f), Random.Range(-3f, 3f)));
                }

                break;
        }
    }
}
