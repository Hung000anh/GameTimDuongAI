using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static NodeInfo;

public class NodeManager : MonoBehaviour
{
    public List<Node> nodeList = new List<Node>(); // Danh sách node (hiện tại rỗng)
    public string prefabTagToCheck = "Object static"; // Tag của prefab cần kiểm tra
    void Start()
    {

        foreach (Transform nodeTransform in transform)
        {
            // Kiểm tra xem node có chứa bất kỳ prefab nào không
            if (!NodeContainsPrefab(nodeTransform))
            {
                Node newNodeInfo = new Node(nodeTransform.position);

                nodeList.Add(newNodeInfo);
            }
        }
    }

    private bool NodeContainsPrefab(Transform nodeTransform)
    {
        // Lặp qua các child của node để kiểm tra xem có prefab có tag cần kiểm tra không
        foreach (Transform child in nodeTransform)
        {
            if (child.CompareTag(prefabTagToCheck))
            {
                return true;
            }
        }
        return false;
    }
}