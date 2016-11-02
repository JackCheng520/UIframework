using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

// ================================
//* 功能描述：UIManager  
//* 创 建 者：chenghaixiao
//* 创建日期：2016/10/9 15:35:10
// ================================
namespace Assets.JackCheng.UI
{
    public class UIManager:JSington<UIManager>
    {
        public Dictionary<string, GameObject> dic = new Dictionary<string, GameObject>();

        public Transform _canvas;
        public UIManager() {
            _canvas = GameObject.Find("Canvas").transform;
        }

        public void Init() { }

        public GameObject GetUI(UIType _type) {
            if (!dic.ContainsKey(_type.Path) || dic[_type.Path] == null) 
            {
                GameObject o = GameObject.Instantiate(Resources.Load( _type.Path)) as GameObject;
                o.transform.SetParent(_canvas);
                o.transform.rectTransform().anchoredPosition = Vector3.zero;
                
                dic.AddOrReplace(_type.Path, o);
            }

            return dic[_type.Path];
        }

        public void DestroyUI(UIType _type) 
        {
            if (dic.ContainsKey(_type.Path)) {
                GameObject o = dic[_type.Path];
                dic.Remove(_type.Path);
                GameObject.Destroy(o);
                o = null;
            }
        }

    }
}
