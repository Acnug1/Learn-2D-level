using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{
    private void OnMouseDown()
    {
        transform.Translate(0, 10, 0);
    }
}
