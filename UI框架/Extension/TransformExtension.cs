using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

// ================================
//* 功能描述：TransformExtension  
//* 创 建 者：chenghaixiao
//* 创建日期：2016/10/9 15:42:18
// ================================
namespace Assets.JackCheng.UI
{
    public static class TransformExtension 
    {
        public static void DestroyAllChild(this Transform _trans) {
            int count = _trans.childCount;
            for (int i = 0; i < count; i++) {
                Transform o = _trans.GetChild(i);
                if (o != null) {
                    GameObject.Destroy(o.gameObject);
                    o = null;
                }
            }
        }

        public static Transform AddPrefabToTransform(this Transform _trans, Transform _prefab, string _name = "") {
            Transform clone = GameObject.Instantiate(_prefab);
            clone.SetParent(_trans, false);
            if (string.IsNullOrEmpty(_name))
            {
                clone.gameObject.name = _name;
            }

            return clone;
        }
    }
}
