using Abstractions;
using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace Core
{
    public sealed class UnitSworder : MonoBehaviour, ISelectable
    {
        public float Health => _health;
        public float MaxHealth => _maxHealth;
        public Sprite Icon => _icon;
        public GameObject prefab => _prefab;

        [SerializeField] private Transform _unitsParent;
        [SerializeField] private GameObject _prefab;
        [SerializeField] private float _maxHealth = 100;
        [SerializeField] private Sprite _icon;

        private float _health = 100;

        private void Attack()
        {
            Debug.Log("i go to attack!!!!!!!");
        }
        
        private void Stop()
        {
            Debug.Log("I stop!!!!!!!");
        }
        
        private void Patrol()
        {
            Debug.Log("I'm go to patrol positions!!!!!!!");
        }

        private void Move()
        {
            Debug.Log("I move to position!!!!!!");
        }
    } 
}