using UnityEngine;

namespace Chapter.ObjectPoolObserver {
    public class CameraController : Observer {
        private bool _isTurboOn;
        private Vector3 _initialPosition;
        private float _shakeMagnitude = 0.1f;
        private DroneController _droneController;
        
        void OnEnable() {
            _initialPosition = gameObject.transform.localPosition;
        }

        void Update() {
            if (_isTurboOn) {
                gameObject.transform.localPosition = _initialPosition + (Random.insideUnitSphere * _shakeMagnitude);
            } else {
                gameObject.transform.localPosition = _initialPosition;
            }
        }
        public override void Notify(Subject subject) {
            if (!_droneController) {
                _droneController = subject.GetComponent<DroneController>();
            }

            if (_droneController) {
                _isTurboOn = _droneController.IsTurboOn;
            }
        }
    }

    
}