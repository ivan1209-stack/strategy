using System;
using UnityEngine;
using UserControlSystem;

namespace UserControlSystem.UI.Presenter
{
    public class OutlineSelect : MonoBehaviour
    {
        [SerializeField] private SelectableValue _selected;
        private Outline _outlineComponent;
        private bool flag = false;

        private void Update()
        {
            if ( _outlineComponent != null && _selected.CurrentValue != _outlineComponent)
            {
                OffOtline();
            }

            if (_selected.CurrentValue == null && _outlineComponent != null)
            {
                OffOtline();
            }
            if (_selected.CurrentValue != null)
            {
                _outlineComponent = _selected.CurrentValue.prefab.GetComponent<Outline>();
                OnOtline();
            }
        }
        public void OffOtline()
        {
            _outlineComponent.enabled = false;
        }
        
        public void OnOtline()
        {
            _outlineComponent.enabled = true;
        }
    }
}