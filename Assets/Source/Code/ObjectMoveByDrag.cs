using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObjectMoveByDrag : MonoBehaviour
{
    [SerializeField] List<GameObject> particleVFXs;

    private Vector3 startPos;
    private Transform target;

    private void OnEnable()
    {
        startPos = transform.position;
    }

    public void PickUp()
    {
        //transform.rotation = new Quaternion(0,0,0,0);
    }

    public void CheckOnMouseUp()
    {
        //transform.position = startPos;
        /*if (target)
        {
            transform.position = target.position;
            GetComponent<SpriteRenderer>().sortingOrder = 1;
            GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].gameObjects.Remove(gameObject);
            GameManager.Instance.CheckLevelUp();
            GetComponent<BoxCollider2D>().enabled = false;
            GameObject explosion = Instantiate(particleVFXs[Random.Range(0,particleVFXs.Count)], transform.position, transform.rotation);
            Destroy(explosion, .75f);
        }*/
        
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (transform.CompareTag("NotUse")) return;
        if (gameObject.tag == collision.gameObject.tag)
        {
            target = collision.transform;
        }
    }
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (transform.CompareTag("NotUse")) return;
        if (gameObject.tag == collision.gameObject.tag)
        {
            target = null;
        }
    }*/
}
