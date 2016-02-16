using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Block : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter()
    {
        transform.DOScale(0f, 0.5f);
        Destroy(gameObject, 0.5f);
        GameMaster.instance.BlockDestroyed();
    }
}
