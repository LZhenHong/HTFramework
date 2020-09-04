﻿using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace HT.Framework
{
    /// <summary>
    /// 步骤预览目标
    /// </summary>
    internal sealed class StepPreview : MonoBehaviour
    {
#if UNITY_EDITOR
        private void Awake()
        {
            Log.Error("步骤控制者：发现步骤预览目标 [" + transform.FullName() + "]，预览目标不应该存在于运行时！");
        }
        
        private void OnDrawGizmos()
        {
            Handles.Label(transform.position, name, "Tooltip");
        }
#endif
    }
}