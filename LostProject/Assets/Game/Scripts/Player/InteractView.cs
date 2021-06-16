using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractView : MonoBehaviour
{
    public PlayerControl playerControl;
    public IInteractable currentSelectd;
    public IInteractionActions currentActions;

    [SerializeField] private UiObserver _uiObserver;
    public InputReader input;

  
    [Range(0, 10)]
    public float range;
    [SerializeField] private LayerMask interactLayer;
    [SerializeField] private Camera _cam; 

    private void Awake()
    {
        _cam = Camera.main;
    }

    private void Update()
    {
        FindinteractTarget();
    }    

    private void ChangeSeleted(IInteractable interactable, IInteractionActions actions)
    {
        currentSelectd = interactable;
        currentActions = actions;
    }


    private Ray CreateRayFromScreenCenter()
    {
        var ray = _cam.ScreenPointToRay(GetScreenCenter());
        return ray;
    }

    private Vector3 GetScreenCenter()
    {
        var screenCenter = Vector3.zero;
        screenCenter.x = Screen.width / 2;
        screenCenter.y = Screen.height / 2;
        screenCenter.z = _cam.nearClipPlane;        

        return screenCenter;
    }


    private void FindinteractTarget()
    {
        

        if (!playerControl.canInteract) return;

        var ray = CreateRayFromScreenCenter();


        if (Physics.Raycast(ray, out var hit, range))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            IInteractionActions actions = hit.collider.GetComponent<IInteractionActions>();

            if (interactable != null)
            {

                if (interactable == currentSelectd) return;

                else if (currentSelectd != null)
                {
                    currentSelectd?.ExitLook();

                    ChangeSeleted(interactable, actions);

                    currentSelectd?.EnterLook();

                    return;
                }
                else
                {
                    ChangeSeleted(interactable, actions);

                    currentSelectd?.EnterLook();

                    return;
                }
            }
            else
            {
                if (currentSelectd == null) return;

                currentSelectd?.ExitLook();

                ChangeSeleted(null, null);

                return;
            }
        }
        else
        {
            if (currentSelectd == null) return;

            currentSelectd?.ExitLook();
            ChangeSeleted(null, null);

            return;
        }
    }

    private void OnDrawGizmos()
    {
        var ray = _cam.ScreenPointToRay(Input.mousePosition);

        Gizmos.color = Color.blue;
        Gizmos.DrawRay(ray.origin, ray.direction * range);
    }
}