using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class NodeInfo : MonoBehaviour
{

    [System.Serializable]
    public struct Node
    {
        public Vector2 position;

        public Node(Vector2 pos)
        {
            position = pos;
        }

    }

}