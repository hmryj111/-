using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int rows = 5; // 行数
    public int columns = 5; // 列数
    public float spacing = 2f; // 球体之间的间隔
    public Material earth; // 用于引用自定义材质

    void Start()
    {
        // 循环创建球体阵列
        for (int x = 0; x < columns; x++)
        {
            for (int z = 0; z < rows; z++)
            {
                // 计算每个球体的位置
                Vector3 position = new Vector3(x * spacing, 0f, z * spacing);

                // 创建一个新的球体
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

                // 设置球体的位置
                sphere.transform.position = position;

                // 检查自定义材质是否已经赋值
                if (earth != null)
                {
                    // 获取球体的 Renderer 组件
                    Renderer renderer = sphere.GetComponent<Renderer>();
                    // 为球体应用自定义材质
                    renderer.material = earth;
                }
            }
        }
    }
}
