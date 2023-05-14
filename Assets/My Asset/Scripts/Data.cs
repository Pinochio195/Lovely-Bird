using System;
using UnityEngine;

namespace Data
{
    [Serializable]
    public class Player_Component
    {
        public Rigidbody2D rigidbody;
        public Animator animator;
        public BoxCollider2D boxCollider;
    }
    
}