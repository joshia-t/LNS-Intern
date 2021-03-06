using LNS.Entities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LNS.ObjectPooling
{
    /// <summary>
    /// Generic poolable instance
    /// </summary>
    public abstract class Poolable : MonoBehaviour
    {
        [Header("Poolable")]
        [SerializeField]
        private PoolableScriptableObject poolableType;

        public PoolableScriptableObject PoolableType
        {
            get { return poolableType; }
        }
        public virtual void Start()
        {
            if (!InstancePool.IsPooled(this))
            {
                InstancePool.AddToPool(this);
            }
        }

        public virtual void OnPoolCreate()
        {

        }
        public virtual void OnPoolRemove()
        {

        }
    }
}