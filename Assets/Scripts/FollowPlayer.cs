using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    Vector3 tF, fD;
    Vector3 mousePosition;
    Vector3 pos;
    float rotationOffset = 270;
    float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        tF = this.transform.up; //facing up
        Debug.DrawRay(this.transform.position, tF * 2, Color.green);
    }

    // Update is called once per frame
    void Update()
    {
        pos = Camera.main.WorldToScreenPoint(transform.position);
        //mouse position
        mousePosition = Input.mousePosition;
        Debug.Log(mousePosition);

        mousePosition.x = mousePosition.x - pos.x;
        mousePosition.y = mousePosition.y - pos.y;
        //angle from mouse pos to apple
        fD = mousePosition - this.transform.position;

        float angle = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + rotationOffset));

        Vector3 targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPos.z = 0;
        //move to player
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }
}
