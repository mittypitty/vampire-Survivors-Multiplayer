using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWeapenBehaviour : MonoBehaviour
{
    //Base Script of all projectile behaviours [to be placed on a prefab of a weapen that is a projectile]

    protected Vector3 direction;

    public float destroyAfterSeconds;

    protected virtual void Start()
    {
        Destroy(gameObject, destroyAfterSeconds);
    }

    public void DirectionChecker(Vector3 dir)
    {
        direction = dir;

        float dirx = direction.x;
        float diry = direction.y;

        Vector3 scale = transform.localScale;
        Vector3 rotation = transform.rotation.eulerAngles;

        if (dirx > 0 && diry == 0) //right
        {
            scale.x = scale.x * -1;
            scale.y = scale.y * -1;
        }

        if (dirx > 0 && diry == 0) //right
        {
            scale.x = -scale.x * -1;
            scale.y = -scale.y * -1;
        }
        else if (dirx == 0 && diry < 0) //down
        {
            scale.x = scale.x * 1;
            scale.y = scale.y * -1;
        }
        else if (dirx == 0 && diry > 0) //up
        {
            scale.x = scale.x * -1;
            scale.y = scale.y * 1;
        }
        else if (dirx > 0 && diry > 0) //right up
        {
            rotation.z = 270f;
        }
        else if (dirx > 0 && diry < 0) //right down
        {
            rotation.z = -180f;
        }
        else if (dirx < 0 && diry < 0) //left down
        {
            scale.x = scale.x * -1;
            scale.y = scale.y * -1;
            rotation.z = -90f;
        }
        else if (dirx < 0 && diry > 0) //left up
        {
            scale.x = -scale.x * -1;
            scale.y = -scale.y * -1;
            rotation.z = 0f;
        }

        transform.localScale = scale;
        transform.rotation = Quaternion.Euler(rotation);    
    }

}