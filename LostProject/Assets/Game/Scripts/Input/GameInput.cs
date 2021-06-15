// GENERATED AUTOMATICALLY FROM 'Assets/Game/Scripts/Input/GameInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""6c33a6f7-d026-4a80-a462-9d672e7db54b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""75a85a14-754c-442a-8f2a-6b05368d3ae9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""73fce086-6060-4650-ae8c-abe4dfefa42f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""5f1a8ec3-7752-4f2a-be5c-d9cc2092c318"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouching"",
                    ""type"": ""Button"",
                    ""id"": ""6338f442-e2a7-4c7e-9bbd-3278a0d4c163"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Vault"",
                    ""type"": ""Button"",
                    ""id"": ""a9d6450a-d56a-4708-a834-64e105bb8dc4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""PrimaryAction"",
                    ""type"": ""Button"",
                    ""id"": ""0e57eb5b-1e43-4a49-9214-6cfab4d6c157"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""SecondAction"",
                    ""type"": ""Button"",
                    ""id"": ""9fccdb9a-e31e-4a79-a319-e47561f5c681"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""InventoryAccess"",
                    ""type"": ""Button"",
                    ""id"": ""b97bd464-52eb-482e-a7e7-8eae5fbfc931"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""LightOn"",
                    ""type"": ""Button"",
                    ""id"": ""5c686335-8186-4c85-ab14-458c78c7a8dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""LightOff"",
                    ""type"": ""Button"",
                    ""id"": ""49f18e4a-1c51-459d-99aa-dab5d8afdd17"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""LightSwitch"",
                    ""type"": ""Value"",
                    ""id"": ""04035f39-655d-4ea0-a92f-bc31888109e2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""RechargeOil"",
                    ""type"": ""Button"",
                    ""id"": ""740b2d3c-8cb7-47df-ac5f-770a366b2a62"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""PauseMenu"",
                    ""type"": ""Button"",
                    ""id"": ""4646dc99-bc97-48d5-b9b9-781b17178a78"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7e063bb3-cde6-4926-883a-180bc6bf9745"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone,NormalizeVector2"",
                    ""groups"": ""Xbox"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""f9383750-f1e7-4dc7-8def-7c67f3f336c9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5893ff1f-eb89-4cb2-871a-6cc6f1bf8d16"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pc"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f540b8d6-1454-4cd3-bb49-25db9ccbb761"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pc"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""feb9f89f-9ed6-43f3-9398-1eed15ad288d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pc"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5dbc1ca0-584e-4919-870f-b0ee78fbaa51"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pc"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3906ed07-cf70-467f-88d2-05eef6c16c01"",
                    ""path"": ""<XInputController>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dcd36b01-1393-4154-aeab-ff36c035a71d"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pc"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34cc1c76-5ca8-4cd6-bff2-40b5ccdbb90b"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Xbox"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0277ce8c-7a99-4317-a4d3-423bd2898f2e"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pc"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b96f507b-25a1-435f-a695-afeb64037f0b"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Crouching"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9af34e45-67c4-4f90-8550-9c5b5afcaeac"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pc"",
                    ""action"": ""Crouching"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1d2a474-1460-4e45-a6ff-5817e6bfc9d2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Vault"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57dba32a-f041-4b26-b813-0c8eaed22caa"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pc"",
                    ""action"": ""Vault"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""faebb2b3-a7df-48be-895a-4b93fcce33ba"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""PrimaryAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8c0a8db-fc28-4442-9133-609572d123cb"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""PrimaryAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""54ca5747-83af-480e-99bd-9188b582a5b2"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a89dad38-ddb1-40f4-954f-a9fd59aa71bd"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""SecondAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e7a8be1-15d8-4653-a9ed-96fe72c7725b"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pc"",
                    ""action"": ""InventoryAccess"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1676720-b0cd-4d58-bc15-e02470da9540"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LightOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b85b72a-01ca-43f6-ad2b-59cde9b9283e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LightOff"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea2ebb43-672d-4892-bc8e-ad0e3f350b25"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(min=-1,max=1)"",
                    ""groups"": ""Pc"",
                    ""action"": ""LightSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb7886ed-9e3d-4cd8-8533-236deab5ea62"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RechargeOil"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27c29481-d5bf-40fb-bfc7-800cbe9f5e20"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Inventory"",
            ""id"": ""3dcb7c46-a872-4313-95c0-34602a8076a5"",
            ""actions"": [
                {
                    ""name"": ""InventoryDeaccess"",
                    ""type"": ""Button"",
                    ""id"": ""725e3dff-70bb-4fed-b9cd-0ee58cd80d90"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PauseMenu"",
                    ""type"": ""Button"",
                    ""id"": ""35a1ecaf-3b6b-46cb-95fd-089b9db505ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""44a6b943-b27a-4c43-a2df-905740ef0d82"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Pc"",
                    ""action"": ""InventoryDeaccess"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f634e31-c94e-42dc-b862-da7ee90b463a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Inspection"",
            ""id"": ""a13132e9-89b9-454a-a879-86daba187fec"",
            ""actions"": [
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""10032f50-bf22-4e58-ab58-e6a0e52eaf6c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryActionInspect"",
                    ""type"": ""Button"",
                    ""id"": ""0c65e09e-c972-4180-bccd-c8e6a95dfea4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""SecondActionInspect"",
                    ""type"": ""Button"",
                    ""id"": ""1981b803-6696-4df5-9f23-cfcd62d751a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""PauseMenu"",
                    ""type"": ""Button"",
                    ""id"": ""28815717-dfe2-4d97-af7b-21f245f54d70"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""422b3607-615b-4d25-b953-8595b32b5c78"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb133c5e-f8eb-4383-ae80-f4dd7ecc44cf"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""PrimaryActionInspect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d78f6a51-d726-40fe-80b2-d60a1cbdfb1e"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondActionInspect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97f274cc-5f0b-4bdb-ba32-4d35bd792e38"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""SecondActionInspect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44660e9c-603e-475f-9138-c0b150bd176c"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Xbox"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8629d78-d3be-4975-a5cd-6ebc201681df"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""ee8afe57-3d8d-4623-b276-d5165575cad3"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""c04c6313-80d4-417a-bf67-0761037d60bd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""ac35b932-5a2b-460d-8e78-5b48bacc2957"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""d142d6dd-5723-4244-913b-64df9ace762c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5ce69e47-1b42-4180-b8eb-84f46715656e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""553f890e-35f7-4476-8776-c03532034355"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c990049d-e34b-4762-ae43-66f124bdee0b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ff0b4475-ed5f-4eb3-835c-c498c070175e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0f9aa014-85d6-4a5d-b9a3-24861e20eac8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDevicePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4b08e2f6-36b0-4a21-bce7-8e1a12b30b1a"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceOrientation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8391bef8-4c4a-43bb-83a0-74b3a1add00a"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""273abfad-dce2-4274-a3e1-5385133b5647"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""33947442-bfeb-4535-848e-d7aed22fccb0"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b9842ff0-eb15-4e5c-9b60-b1514e1fcc70"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""58e3fce3-5c3a-4c76-a0a9-ac95c0b66470"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6deb1479-7238-4182-ab8e-9faaec720c2d"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""de7c5c86-5103-4baf-a1c7-e15bf2843c85"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""20abe91d-8b73-4a31-aff1-e1d2f83f74a4"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2fd72021-2c0a-426a-9de8-f2d0ec0f11a1"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9354a71c-1a7a-40fc-8fe1-e6b1242db1f1"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""08a0e33f-2939-4f31-bb12-1d621c8ef290"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""fe429eaf-4cef-41c3-8430-cc96eeba82b5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9a65d55d-3b94-421c-a873-d6c15b236003"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fbe9a37e-0764-4460-86a5-60e78770ba39"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""03472202-ab05-4d2f-968f-33ad5b7aff4d"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""85267223-ed94-4aa0-94bb-2de17c810dee"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""d9db7b55-aca4-4fb2-b441-5e4e12c96e5c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ae443783-b8a6-4193-b50e-010f7f993a2f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""312f8f3f-3f5e-47e0-8226-fb303fbc155f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""78dc022c-d464-471d-bda7-648505c9b5c2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b08e5d8c-8faf-4429-b164-4878f701c300"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""90a9db5f-cf21-443d-99b8-dc37fa237577"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ae796782-5178-4b6d-bb80-81723ff34de3"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ee4f486d-5643-417b-a85e-20e9fd374f25"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""87b2b391-0ea5-4187-9f5e-64620ea25c1a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""baf4a38d-ff83-46d6-8cb3-2dda5b1a0373"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""734e3138-6683-4d3d-bcde-cc3d12281b0e"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd138154-10f2-4a56-880d-9888bb250cab"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebc6bbe8-c494-44c7-953b-2e9d0f382564"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61883e12-9daf-41a2-91e2-0101a7544e72"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98e28b1b-133b-487e-8401-2e335fe391c8"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""389946fc-7937-44f0-b525-0a8b52e8477a"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c75febdf-6f61-4e6c-a123-ae404ceb6a4f"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4471790b-ec08-4c4e-a098-a86fdb3d2c57"",
                    ""path"": ""<XRController>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97bbd4f1-5f1e-4cae-a118-21a1e80d4151"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""597b7ddc-9722-4659-898c-b2ec89271f74"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""313023b0-f75c-46d1-be73-771ec74f7cf1"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5056c0a-27b4-4e30-9f24-d5b38f18867f"",
                    ""path"": ""<XRController>/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5bc1f38-cac4-4838-ae4f-98f6eb1bb43a"",
                    ""path"": ""<XRController>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceOrientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Pause"",
            ""id"": ""c7f287cc-69aa-4c4a-a472-60a18e6b537c"",
            ""actions"": [
                {
                    ""name"": ""PauseMenu"",
                    ""type"": ""Button"",
                    ""id"": ""4688c2d8-4532-47d2-9df2-33ff9780e070"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""892a362c-68fa-43a6-aab2-27f4bbb8c135"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Xbox"",
            ""bindingGroup"": ""Xbox"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Pc"",
            ""bindingGroup"": ""Pc"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Run = m_Gameplay.FindAction("Run", throwIfNotFound: true);
        m_Gameplay_Look = m_Gameplay.FindAction("Look", throwIfNotFound: true);
        m_Gameplay_Crouching = m_Gameplay.FindAction("Crouching", throwIfNotFound: true);
        m_Gameplay_Vault = m_Gameplay.FindAction("Vault", throwIfNotFound: true);
        m_Gameplay_PrimaryAction = m_Gameplay.FindAction("PrimaryAction", throwIfNotFound: true);
        m_Gameplay_SecondAction = m_Gameplay.FindAction("SecondAction", throwIfNotFound: true);
        m_Gameplay_InventoryAccess = m_Gameplay.FindAction("InventoryAccess", throwIfNotFound: true);
        m_Gameplay_LightOn = m_Gameplay.FindAction("LightOn", throwIfNotFound: true);
        m_Gameplay_LightOff = m_Gameplay.FindAction("LightOff", throwIfNotFound: true);
        m_Gameplay_LightSwitch = m_Gameplay.FindAction("LightSwitch", throwIfNotFound: true);
        m_Gameplay_RechargeOil = m_Gameplay.FindAction("RechargeOil", throwIfNotFound: true);
        m_Gameplay_PauseMenu = m_Gameplay.FindAction("PauseMenu", throwIfNotFound: true);
        // Inventory
        m_Inventory = asset.FindActionMap("Inventory", throwIfNotFound: true);
        m_Inventory_InventoryDeaccess = m_Inventory.FindAction("InventoryDeaccess", throwIfNotFound: true);
        m_Inventory_PauseMenu = m_Inventory.FindAction("PauseMenu", throwIfNotFound: true);
        // Inspection
        m_Inspection = asset.FindActionMap("Inspection", throwIfNotFound: true);
        m_Inspection_Rotate = m_Inspection.FindAction("Rotate", throwIfNotFound: true);
        m_Inspection_PrimaryActionInspect = m_Inspection.FindAction("PrimaryActionInspect", throwIfNotFound: true);
        m_Inspection_SecondActionInspect = m_Inspection.FindAction("SecondActionInspect", throwIfNotFound: true);
        m_Inspection_PauseMenu = m_Inspection.FindAction("PauseMenu", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
        m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
        m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
        m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
        m_UI_ScrollWheel = m_UI.FindAction("ScrollWheel", throwIfNotFound: true);
        m_UI_MiddleClick = m_UI.FindAction("MiddleClick", throwIfNotFound: true);
        m_UI_RightClick = m_UI.FindAction("RightClick", throwIfNotFound: true);
        m_UI_TrackedDevicePosition = m_UI.FindAction("TrackedDevicePosition", throwIfNotFound: true);
        m_UI_TrackedDeviceOrientation = m_UI.FindAction("TrackedDeviceOrientation", throwIfNotFound: true);
        // Pause
        m_Pause = asset.FindActionMap("Pause", throwIfNotFound: true);
        m_Pause_PauseMenu = m_Pause.FindAction("PauseMenu", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Run;
    private readonly InputAction m_Gameplay_Look;
    private readonly InputAction m_Gameplay_Crouching;
    private readonly InputAction m_Gameplay_Vault;
    private readonly InputAction m_Gameplay_PrimaryAction;
    private readonly InputAction m_Gameplay_SecondAction;
    private readonly InputAction m_Gameplay_InventoryAccess;
    private readonly InputAction m_Gameplay_LightOn;
    private readonly InputAction m_Gameplay_LightOff;
    private readonly InputAction m_Gameplay_LightSwitch;
    private readonly InputAction m_Gameplay_RechargeOil;
    private readonly InputAction m_Gameplay_PauseMenu;
    public struct GameplayActions
    {
        private @GameInput m_Wrapper;
        public GameplayActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Run => m_Wrapper.m_Gameplay_Run;
        public InputAction @Look => m_Wrapper.m_Gameplay_Look;
        public InputAction @Crouching => m_Wrapper.m_Gameplay_Crouching;
        public InputAction @Vault => m_Wrapper.m_Gameplay_Vault;
        public InputAction @PrimaryAction => m_Wrapper.m_Gameplay_PrimaryAction;
        public InputAction @SecondAction => m_Wrapper.m_Gameplay_SecondAction;
        public InputAction @InventoryAccess => m_Wrapper.m_Gameplay_InventoryAccess;
        public InputAction @LightOn => m_Wrapper.m_Gameplay_LightOn;
        public InputAction @LightOff => m_Wrapper.m_Gameplay_LightOff;
        public InputAction @LightSwitch => m_Wrapper.m_Gameplay_LightSwitch;
        public InputAction @RechargeOil => m_Wrapper.m_Gameplay_RechargeOil;
        public InputAction @PauseMenu => m_Wrapper.m_Gameplay_PauseMenu;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Run.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRun;
                @Look.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @Crouching.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouching;
                @Crouching.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouching;
                @Crouching.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouching;
                @Vault.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnVault;
                @Vault.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnVault;
                @Vault.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnVault;
                @PrimaryAction.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPrimaryAction;
                @PrimaryAction.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPrimaryAction;
                @PrimaryAction.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPrimaryAction;
                @SecondAction.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSecondAction;
                @SecondAction.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSecondAction;
                @SecondAction.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSecondAction;
                @InventoryAccess.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInventoryAccess;
                @InventoryAccess.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInventoryAccess;
                @InventoryAccess.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInventoryAccess;
                @LightOn.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLightOn;
                @LightOn.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLightOn;
                @LightOn.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLightOn;
                @LightOff.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLightOff;
                @LightOff.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLightOff;
                @LightOff.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLightOff;
                @LightSwitch.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLightSwitch;
                @LightSwitch.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLightSwitch;
                @LightSwitch.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLightSwitch;
                @RechargeOil.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRechargeOil;
                @RechargeOil.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRechargeOil;
                @RechargeOil.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRechargeOil;
                @PauseMenu.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPauseMenu;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Crouching.started += instance.OnCrouching;
                @Crouching.performed += instance.OnCrouching;
                @Crouching.canceled += instance.OnCrouching;
                @Vault.started += instance.OnVault;
                @Vault.performed += instance.OnVault;
                @Vault.canceled += instance.OnVault;
                @PrimaryAction.started += instance.OnPrimaryAction;
                @PrimaryAction.performed += instance.OnPrimaryAction;
                @PrimaryAction.canceled += instance.OnPrimaryAction;
                @SecondAction.started += instance.OnSecondAction;
                @SecondAction.performed += instance.OnSecondAction;
                @SecondAction.canceled += instance.OnSecondAction;
                @InventoryAccess.started += instance.OnInventoryAccess;
                @InventoryAccess.performed += instance.OnInventoryAccess;
                @InventoryAccess.canceled += instance.OnInventoryAccess;
                @LightOn.started += instance.OnLightOn;
                @LightOn.performed += instance.OnLightOn;
                @LightOn.canceled += instance.OnLightOn;
                @LightOff.started += instance.OnLightOff;
                @LightOff.performed += instance.OnLightOff;
                @LightOff.canceled += instance.OnLightOff;
                @LightSwitch.started += instance.OnLightSwitch;
                @LightSwitch.performed += instance.OnLightSwitch;
                @LightSwitch.canceled += instance.OnLightSwitch;
                @RechargeOil.started += instance.OnRechargeOil;
                @RechargeOil.performed += instance.OnRechargeOil;
                @RechargeOil.canceled += instance.OnRechargeOil;
                @PauseMenu.started += instance.OnPauseMenu;
                @PauseMenu.performed += instance.OnPauseMenu;
                @PauseMenu.canceled += instance.OnPauseMenu;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Inventory
    private readonly InputActionMap m_Inventory;
    private IInventoryActions m_InventoryActionsCallbackInterface;
    private readonly InputAction m_Inventory_InventoryDeaccess;
    private readonly InputAction m_Inventory_PauseMenu;
    public struct InventoryActions
    {
        private @GameInput m_Wrapper;
        public InventoryActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @InventoryDeaccess => m_Wrapper.m_Inventory_InventoryDeaccess;
        public InputAction @PauseMenu => m_Wrapper.m_Inventory_PauseMenu;
        public InputActionMap Get() { return m_Wrapper.m_Inventory; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InventoryActions set) { return set.Get(); }
        public void SetCallbacks(IInventoryActions instance)
        {
            if (m_Wrapper.m_InventoryActionsCallbackInterface != null)
            {
                @InventoryDeaccess.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnInventoryDeaccess;
                @InventoryDeaccess.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnInventoryDeaccess;
                @InventoryDeaccess.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnInventoryDeaccess;
                @PauseMenu.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnPauseMenu;
            }
            m_Wrapper.m_InventoryActionsCallbackInterface = instance;
            if (instance != null)
            {
                @InventoryDeaccess.started += instance.OnInventoryDeaccess;
                @InventoryDeaccess.performed += instance.OnInventoryDeaccess;
                @InventoryDeaccess.canceled += instance.OnInventoryDeaccess;
                @PauseMenu.started += instance.OnPauseMenu;
                @PauseMenu.performed += instance.OnPauseMenu;
                @PauseMenu.canceled += instance.OnPauseMenu;
            }
        }
    }
    public InventoryActions @Inventory => new InventoryActions(this);

    // Inspection
    private readonly InputActionMap m_Inspection;
    private IInspectionActions m_InspectionActionsCallbackInterface;
    private readonly InputAction m_Inspection_Rotate;
    private readonly InputAction m_Inspection_PrimaryActionInspect;
    private readonly InputAction m_Inspection_SecondActionInspect;
    private readonly InputAction m_Inspection_PauseMenu;
    public struct InspectionActions
    {
        private @GameInput m_Wrapper;
        public InspectionActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotate => m_Wrapper.m_Inspection_Rotate;
        public InputAction @PrimaryActionInspect => m_Wrapper.m_Inspection_PrimaryActionInspect;
        public InputAction @SecondActionInspect => m_Wrapper.m_Inspection_SecondActionInspect;
        public InputAction @PauseMenu => m_Wrapper.m_Inspection_PauseMenu;
        public InputActionMap Get() { return m_Wrapper.m_Inspection; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InspectionActions set) { return set.Get(); }
        public void SetCallbacks(IInspectionActions instance)
        {
            if (m_Wrapper.m_InspectionActionsCallbackInterface != null)
            {
                @Rotate.started -= m_Wrapper.m_InspectionActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_InspectionActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_InspectionActionsCallbackInterface.OnRotate;
                @PrimaryActionInspect.started -= m_Wrapper.m_InspectionActionsCallbackInterface.OnPrimaryActionInspect;
                @PrimaryActionInspect.performed -= m_Wrapper.m_InspectionActionsCallbackInterface.OnPrimaryActionInspect;
                @PrimaryActionInspect.canceled -= m_Wrapper.m_InspectionActionsCallbackInterface.OnPrimaryActionInspect;
                @SecondActionInspect.started -= m_Wrapper.m_InspectionActionsCallbackInterface.OnSecondActionInspect;
                @SecondActionInspect.performed -= m_Wrapper.m_InspectionActionsCallbackInterface.OnSecondActionInspect;
                @SecondActionInspect.canceled -= m_Wrapper.m_InspectionActionsCallbackInterface.OnSecondActionInspect;
                @PauseMenu.started -= m_Wrapper.m_InspectionActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.performed -= m_Wrapper.m_InspectionActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.canceled -= m_Wrapper.m_InspectionActionsCallbackInterface.OnPauseMenu;
            }
            m_Wrapper.m_InspectionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @PrimaryActionInspect.started += instance.OnPrimaryActionInspect;
                @PrimaryActionInspect.performed += instance.OnPrimaryActionInspect;
                @PrimaryActionInspect.canceled += instance.OnPrimaryActionInspect;
                @SecondActionInspect.started += instance.OnSecondActionInspect;
                @SecondActionInspect.performed += instance.OnSecondActionInspect;
                @SecondActionInspect.canceled += instance.OnSecondActionInspect;
                @PauseMenu.started += instance.OnPauseMenu;
                @PauseMenu.performed += instance.OnPauseMenu;
                @PauseMenu.canceled += instance.OnPauseMenu;
            }
        }
    }
    public InspectionActions @Inspection => new InspectionActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Navigate;
    private readonly InputAction m_UI_Submit;
    private readonly InputAction m_UI_Cancel;
    private readonly InputAction m_UI_Point;
    private readonly InputAction m_UI_Click;
    private readonly InputAction m_UI_ScrollWheel;
    private readonly InputAction m_UI_MiddleClick;
    private readonly InputAction m_UI_RightClick;
    private readonly InputAction m_UI_TrackedDevicePosition;
    private readonly InputAction m_UI_TrackedDeviceOrientation;
    public struct UIActions
    {
        private @GameInput m_Wrapper;
        public UIActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
        public InputAction @Submit => m_Wrapper.m_UI_Submit;
        public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
        public InputAction @Point => m_Wrapper.m_UI_Point;
        public InputAction @Click => m_Wrapper.m_UI_Click;
        public InputAction @ScrollWheel => m_Wrapper.m_UI_ScrollWheel;
        public InputAction @MiddleClick => m_Wrapper.m_UI_MiddleClick;
        public InputAction @RightClick => m_Wrapper.m_UI_RightClick;
        public InputAction @TrackedDevicePosition => m_Wrapper.m_UI_TrackedDevicePosition;
        public InputAction @TrackedDeviceOrientation => m_Wrapper.m_UI_TrackedDeviceOrientation;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @ScrollWheel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @MiddleClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @RightClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @TrackedDevicePosition.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled += instance.OnTrackedDeviceOrientation;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // Pause
    private readonly InputActionMap m_Pause;
    private IPauseActions m_PauseActionsCallbackInterface;
    private readonly InputAction m_Pause_PauseMenu;
    public struct PauseActions
    {
        private @GameInput m_Wrapper;
        public PauseActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @PauseMenu => m_Wrapper.m_Pause_PauseMenu;
        public InputActionMap Get() { return m_Wrapper.m_Pause; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseActions set) { return set.Get(); }
        public void SetCallbacks(IPauseActions instance)
        {
            if (m_Wrapper.m_PauseActionsCallbackInterface != null)
            {
                @PauseMenu.started -= m_Wrapper.m_PauseActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.performed -= m_Wrapper.m_PauseActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.canceled -= m_Wrapper.m_PauseActionsCallbackInterface.OnPauseMenu;
            }
            m_Wrapper.m_PauseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PauseMenu.started += instance.OnPauseMenu;
                @PauseMenu.performed += instance.OnPauseMenu;
                @PauseMenu.canceled += instance.OnPauseMenu;
            }
        }
    }
    public PauseActions @Pause => new PauseActions(this);
    private int m_XboxSchemeIndex = -1;
    public InputControlScheme XboxScheme
    {
        get
        {
            if (m_XboxSchemeIndex == -1) m_XboxSchemeIndex = asset.FindControlSchemeIndex("Xbox");
            return asset.controlSchemes[m_XboxSchemeIndex];
        }
    }
    private int m_PcSchemeIndex = -1;
    public InputControlScheme PcScheme
    {
        get
        {
            if (m_PcSchemeIndex == -1) m_PcSchemeIndex = asset.FindControlSchemeIndex("Pc");
            return asset.controlSchemes[m_PcSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnCrouching(InputAction.CallbackContext context);
        void OnVault(InputAction.CallbackContext context);
        void OnPrimaryAction(InputAction.CallbackContext context);
        void OnSecondAction(InputAction.CallbackContext context);
        void OnInventoryAccess(InputAction.CallbackContext context);
        void OnLightOn(InputAction.CallbackContext context);
        void OnLightOff(InputAction.CallbackContext context);
        void OnLightSwitch(InputAction.CallbackContext context);
        void OnRechargeOil(InputAction.CallbackContext context);
        void OnPauseMenu(InputAction.CallbackContext context);
    }
    public interface IInventoryActions
    {
        void OnInventoryDeaccess(InputAction.CallbackContext context);
        void OnPauseMenu(InputAction.CallbackContext context);
    }
    public interface IInspectionActions
    {
        void OnRotate(InputAction.CallbackContext context);
        void OnPrimaryActionInspect(InputAction.CallbackContext context);
        void OnSecondActionInspect(InputAction.CallbackContext context);
        void OnPauseMenu(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnTrackedDevicePosition(InputAction.CallbackContext context);
        void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
    }
    public interface IPauseActions
    {
        void OnPauseMenu(InputAction.CallbackContext context);
    }
}
