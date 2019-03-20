using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHover : MonoBehaviour {

    private Vector3 startPos;

    private void OnMouseEnter()
    {
        startPos = transform.position;
        iTween.MoveTo(gameObject, new Vector3(transform.position.x, transform.position.y, transform.position.z - 1), 1f);
    }

    private void OnMouseExit()
    {
        iTween.MoveTo(gameObject, startPos, 1f);
    }
}
