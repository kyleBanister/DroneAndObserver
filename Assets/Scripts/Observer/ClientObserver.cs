using UnityEngine;

namespace Chapter.ObjectPoolObserver {
    public class ClientObserver : MonoBehaviour {
        private DroneController _droneController;

        void Start()
        {
            _droneController = 
                (DroneController) 
                FindAnyObjectByType(typeof(DroneController));
        }

        void OnGUI() {
            GUILayout.Space(20);
            if (GUILayout.Button("Damage Drone")) {
                if (_droneController) {
                    _droneController.TakeDamage(15.0f);
                }
            }
            if (GUILayout.Button("Toggle Turbo")) {
                if (_droneController) {
                    _droneController.ToggleTurbo();
                }
            }
        }
    }
}